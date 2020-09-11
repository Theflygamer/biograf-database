using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using c_sharp_og_SQL.SQcon;

namespace c_sharp_og_SQL
{
    class Kundeup
    {

        public int Kundeid { get; set; }

        public string Fnavn { get; set; }

        public string Enavn { get; set; }

        public int Alder { get; set; }

        public int Mobilnummer { get; set; }

        public string Mail { get; set; }



        public Kundeup(string fnavn1, string enavn1, int alder1, int nummer1, string mail1)
        {
            Fnavn = fnavn1;
            Enavn = enavn1;
            Alder = alder1;
            Mobilnummer = nummer1;
            Mail = mail1;

        }
    }
}
