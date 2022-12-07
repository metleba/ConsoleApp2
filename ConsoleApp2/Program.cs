using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Ahmet";
            kurs2.IzlenmeOrani = 75;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Hasan";
            kurs3.IzlenmeOrani = 90;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };
            foreach (var kurs in kurslar)
            {
                
                Console.WriteLine(kurs.KursAdi);
            }

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i].Egitmen);
            }

            while (kurs1.KursAdi=="C#")
            {
                Console.WriteLine("salam");
                break;
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
