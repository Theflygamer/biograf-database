using System;
using System.Data.SqlClient;

namespace c_sharp_og_SQL.SQcon
{
    class SQL
    {
        private static string ConnectionString = "Data Source=localhost;Initial Catalog=biograf; Integrated Security=SSPI;Connect Timeout=5;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public static bool SqlConnectionOK()
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                    return true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    return false;
                }

            }
        }
        public static void insert(string sql)
        {
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                cmd.ExecuteNonQuery();
            }

        }


        public static void DataReader()
        {
            Console.WriteLine("");
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Kunder", con);

                SqlDataReader reader = cmd.ExecuteReader();
                //Er der rækker?
                Console.WriteLine(reader.HasRows);

                while (reader.Read())
                {
                    int Kundeid = reader.GetInt32(0);
                    string Fnavn = reader.GetString(1);
                    string Enavn = reader.GetString(2);
                    int Alder = reader.GetInt32(3);
                    int Mobilnummer = reader.GetInt32(4);
                    string Email = reader.GetString(5);
                    Console.WriteLine($"Id: {Kundeid} navn:    {Fnavn} adresse:    {Enavn} - alder:    {Alder}  Mobilnummer:    {Mobilnummer} Email:    {Email}");
                }

            }
        }

        public static void Update(string table, string setString, string conditionString)
        {
            Console.WriteLine("du opdatere nu dit data");
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"USE Biograf UPDATE {table} SET {setString} WHERE {conditionString}", con);

                SqlDataReader reader = cmd.ExecuteReader();
                //Er der rækker?
                Console.WriteLine(reader.HasRows);


            }

        }

        public static void Deleteuser(int Kundeid)
        {

            Console.WriteLine("du sletter nu din bruger");
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                SqlCommand cmd = new SqlCommand($"DELETE FROM Kunder WHERE Kundeid='{Kundeid}' ", con);

                SqlDataReader reader = cmd.ExecuteReader();
                //Er der rækker?
                Console.WriteLine(reader.HasRows);
            }
        }
    }


    

    
    



}
