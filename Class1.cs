using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace KT1_3
{
    //3.1 Muodosta entiteettejä vastaavat luokat ja mieti jokaiselle luokalle 1-4 ominaisuutta

    //-Autot
    //-Huolto-operaatiot
    //-Mekaanikot
    //-Varaosat

    //3.2 Testaa luokkia tekemällä luokista ilmentymiä ja asettamalla luokkien ominaisuuksiin arvoja ja hakemalla ominaisuuden arvoja ilmentymältä ja tulostamalla arvoja konsoliin.

    internal class Program
    {
        static void Main(string[] args)                 //Mainissa luodaan ilmentymat ja tehdaan testituloste
        {
            //Init
            Autot auto1 = new Autot();
            auto1.Merkki = "Subaru";
            auto1.Malli = "Legacy";
            auto1.Vuosimalli = 1987;
            auto1.Vari = "Punainen";
            Console.WriteLine(auto1.ToString());

            Console.WriteLine();
            Autot auto2 = new Autot();
            auto2.Merkki = "BMW";
            auto2.Malli = "Isetta";
            auto2.Vuosimalli = 1987;
            auto2.Vari = "Pinkki";
            Console.WriteLine(auto2.ToString());

            Console.WriteLine();

            Huollot huolto1 = new Huollot();
            huolto1.Tyyppi = "taysremontti";
            huolto1.Auto = auto2.ToString();
            huolto1.Paivamaara = "15.08.2023";
            huolto1.Huoltonumero = 358;
            Console.WriteLine(huolto1.ToString());

            Console.WriteLine();

            Mekaanikot mekaanikko1 = new Mekaanikot();
            mekaanikko1.Nimi = "Matti Näsä";
            mekaanikko1.TyontekijaNumero = 47;
            Console.WriteLine(mekaanikko1.ToString());

            Console.WriteLine();

            Varaosat osa1 = new Varaosat();
            osa1.VaraosanNimi = "Mobil1 oljy, 3l";
            osa1.Kappalemaara = 1;
            Console.WriteLine(osa1.ToString());
        }
    }
    //Alla osiossa on luokat ja tulostusohjeet
    public class Autot
    {
        public string? Merkki { get; set; }
        public string? Malli { get; set; }
        public int? Vuosimalli { get; set; }
        public string? Vari { get; set; }

        public override string ToString()
        {
            return $"Auto merkkiä {Merkki}, mallia {Malli}, vuosimallia {Vuosimalli} ja väriltään {Vari}.";
        }
    }

    public class Huollot
    {
        public string? Tyyppi { get; set; }
        public string? Auto { get; set; }
        public int? Huoltonumero { get; set; }
        public string? Paivamaara { get; set; }
        public override string ToString()
        {
            return $"{Auto} Tehty huoltonimike {Tyyppi} paivamaaralla {Paivamaara}. Huoltonumero on {Huoltonumero}.";
        }
    }

    public class Mekaanikot
    {
        public string? Nimi { get; set; }
        public int? TyontekijaNumero { get; set; }
        public override string ToString()
        {
            return $"Mekaanikko {Nimi}, numero {TyontekijaNumero}.";
        }
    }

    public class Varaosat
    {
        public string? VaraosanNimi { get; set; }
        public int? Kappalemaara { get; set; }
        public override string ToString()
        {
            return $"Varaosa: {VaraosanNimi}, kaytetty {Kappalemaara} kpl.";
        }
    }
}