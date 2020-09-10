using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_og_SQL.SQcon;


namespace c_sharp_og_SQL.kunder
{
    public class Kunder
    {
        public int Kundeid { get; set; }

        public string Fnavn { get; set; }

        public string  Enavn { get; set; }

        public int Alder  { get; set; }

        public int Mobilnummer { get; set; }

        public string Mail { get; set; }

        internal void Opret()
        {
            SQL.insert("USE[Biograf]" +
                    "INSERT INTO Kunder([Fnavn], [Enavn], [Alder], [Mobilnummer], [Email])" +
                    $"Values('{Fnavn}', '{Enavn}', {Alder}, {Mobilnummer}, '{Mail}')");
        }

        public Kunder(string fnavn, string enavn, int alder, int nummer, string mail)
        {
            Fnavn = fnavn;
            Enavn = enavn;
            Alder = alder;
            Mobilnummer = nummer;
            Mail = mail;

            
        }
    }
}
