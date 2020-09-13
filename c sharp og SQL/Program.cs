using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_og_SQL.SQcon;
using c_sharp_og_SQL.kunder;

namespace c_sharp_og_SQL
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            do
            {
                if (SQL.SqlConnectionOK())
            {
                    Console.WriteLine("tryk A For at oprette en kunde");
                    Console.WriteLine("tryk B For at rette en kunde");
                    Console.WriteLine("tryk C For at se alle kunder");
                    Console.WriteLine("tryk D For at slette en kunde");
                    Console.WriteLine("trye E For at aflustte programmer");


                    ConsoleKeyInfo inputKey = Console.ReadKey(true);
                switch (inputKey.Key)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        Console.WriteLine("indtast dit Navn");
                        string infNavn = Console.ReadLine();
                        Console.WriteLine("indtast dit Efternavn");
                        string inEnavn = Console.ReadLine();
                        Console.WriteLine("indtast din alder");
                        int inAlder = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("indtast dit mobil nummer");
                        int InNummer = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("indtast din Email");
                        string inMail = Console.ReadLine();


                        Kunder nyKunde = new Kunder(infNavn, inEnavn, inAlder, InNummer, inMail);
                        nyKunde.Opret();

                        break;

                    case ConsoleKey.B:
                        Console.Clear();
                        Console.WriteLine("Du kan nu opdatere dine oplysinger skriv dit id på din bruger");                            
                            int kundeid = Convert.ToInt32(Console.ReadLine());

                            bool editExit = false;
                            do
                            {
                                Console.Clear();
                                Console.WriteLine("tryk A For at opdatere fornavn kunde");
                                Console.WriteLine("trye ESC For at aflustte programmer");
                        
                                ConsoleKeyInfo editInputKey = Console.ReadKey(true);

                                switch (editInputKey.Key)
                                {
                                    case ConsoleKey.A:
                                        Console.Clear();
                                        System.Console.WriteLine("Indtast nyt navn");
                                        Kunder.UpdateFNavn(kundeid, Console.ReadLine());
                                        Console.Clear();
                                        System.Console.WriteLine("Navn opdateret");
                                        Console.ReadKey(true);
                                        Console.Clear();

                                        System.Console.WriteLine("Indtast nyt Efternavn");
                                        Kunder.UpdateENavn(kundeid, Console.ReadLine());
                                        Console.Clear();
                                        System.Console.WriteLine("Efternavn opdateret");
                                        Console.ReadKey(true);

                                        Console.Clear();
                                        System.Console.WriteLine("Indtast ny alder");
                                        Kunder.UpdateAlder(kundeid, Convert.ToInt32(Console.ReadLine()));
                                        Console.Clear();
                                        System.Console.WriteLine("alder opdateret");
                                        Console.ReadKey(true);

                                        Console.Clear();
                                        System.Console.WriteLine("Indtast nyt mobilnummer");
                                        Kunder.UpdateNummer(kundeid, Convert.ToInt32(Console.ReadLine()));
                                        Console.Clear();
                                        System.Console.WriteLine("mobilnummer opdateret");
                                        Console.ReadKey(true);

                                        Console.Clear();
                                        System.Console.WriteLine("Indtast ny mail");
                                        Kunder.UpdateMail(kundeid,(Console.ReadLine()));
                                        Console.Clear();
                                        System.Console.WriteLine("Mail opdateret");
                                        Console.ReadKey(true);

                                        break;
                                    case ConsoleKey.Escape:
                                        editExit = true;
                                        break;
                                    default:
                                        break;
                                }
                            } while (!editExit);

                            
                        break;

                    case ConsoleKey.C:
                        Console.WriteLine("tryk C For se alle kunder");

                        SQL.DataReader();
                        Console.Read();

                        break;
                    case ConsoleKey.D:
                        Console.WriteLine("Indtast ID på den bruger der skal slettes");
                            
                            SQL.Deleteuser(Convert.ToInt32(Console.ReadLine()));
                            Console.Clear();
                            Console.WriteLine("du er nu slttet");

                        break;
                    case ConsoleKey.E:
                        exit = true;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Der er ikke forbindelse til databasen programmet kunne ikke køre");
                exit = true;
            }
            } while (!exit);

            

                

        }
    }
}
