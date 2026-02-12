using System;
using System.Collections.Generic;
using System.IO;

namespace ClassLibraryKektura
{
    public class Kektura
    {
        public string KiinduloPont { get; private set; }
        public string VegPont { get; private set; }
        public double SzakaszHosszKm { get; private set; }
        public int Emelkedes { get; private set; }
        public int Lejtes { get; private set; }
        public bool Pecsetelohely { get; private set; }

        public static int Kezdomagassag { get; private set; }
        public static List<Kektura> Kekturalista { get; private set; } = new List<Kektura>();

        public Kektura(string sor)
        {
            string[] db = sor.Split(';');

            KiinduloPont = db[0];
            VegPont = db[1];
            SzakaszHosszKm = double.Parse(db[2]);
            Emelkedes = int.Parse(db[3]);
            Lejtes = int.Parse(db[4]);
            Pecsetelohely = db[5] == "i";
        }

        public static void FileBeolvasas(string filenev)
        {
            try
            {
                Kekturalista.Clear();

                using (StreamReader sr = new StreamReader(filenev))
                {
                    Kezdomagassag = int.Parse(sr.ReadLine());

                    while (!sr.EndOfStream)
                    {
                        Kekturalista.Add(new Kektura(sr.ReadLine()));
                    }
                }
            }
            catch
            {
                throw new Exception("Hiba a file megnyitása során");
            }
        }
    }
}
