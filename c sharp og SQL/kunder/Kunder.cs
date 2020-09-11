using c_sharp_og_SQL.SQcon;


namespace c_sharp_og_SQL.kunder
{
    public class Kunder
    {
        public int Kundeid { get; set; }

        public string Fnavn { get; set; }

        public string Enavn { get; set; }

        public int Alder { get; set; }

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
     
        
        public static void UpdateFNavn(int id, string fnavn)
        {
            SQL.Update("kunder", $"Fnavn = '{fnavn}'", $"Kundeid = {id}");
        }
        public static void UpdateENavn(int id, string eNavn)
        {
            SQL.Update("kunder", $"Enavn = '{eNavn}'", $"Kundeid = {id}");
        }
        public static void UpdateAlder(int id, int alder)
        {
            SQL.Update("kunder", $"Alder = {alder}", $"Kundeid = {id}");
        }
        public static void UpdateNummer(int id, int nummer)
        {
            SQL.Update("kunder", $"Mobilnummer = {nummer}", $"Kundeid = {id}");
        }
        public static void UpdateMail(int id, string mail)
        {
            SQL.Update("kunder", $"Email = '{mail}'", $"Kundeid = {id}");
        }




    }
}
