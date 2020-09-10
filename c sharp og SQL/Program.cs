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
            if (SQL.SqlConnectionOK())
            {
                Console.WriteLine("Der er forbindelse til databasen");
                Kunder nyKunde = new Kunder("fa", "dwa", 12, 2321, "fess");
                nyKunde.Opret();
            }
            else
            {
                Console.WriteLine("Der er ikke forbindelse til databasen");
            }

            









        }
    }
}
