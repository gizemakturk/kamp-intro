using System;

namespace Dongüler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "yazılım kampı";
            string kurs2 = "temel kurs";

            //array

            string[] kurslar = new string[] { "yazılım kampı", "temel kurs" ,"java"};

            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            
            Console.WriteLine("for bitti");
            
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("sayfa sonu");
        }
    }
}
