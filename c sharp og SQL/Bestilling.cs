using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using c_sharp_og_SQL.SQcon;
using System.ComponentModel;

namespace c_sharp_og_SQL
{
    class Bestilling
    {
        public int Kundeid  { get; set; }

        public int Dag  { get; set; }

        public string Film { get; set; }

        public int Antalpladser { get; set; }

        public int Payed { get; set; }

        





    }
}
