using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //intelicence - for fazınca açılan kutu
            string kurs1 = "Yazilim Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java Kursu";
            string[] kurslar = new string[] 
            {
                "Yazilim Geliştirici Yetiştirme Kampı",
                "Programlamaya Başlangıç İçin Temel Kurs",
                "Java Kursu"

            };



            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

        }
    }
}
