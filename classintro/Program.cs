using System;

namespace classintro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adı = "engin";
            Kurs kurs1=new Kurs();
            kurs1.Kursadı="c++";
            kurs1.kursuneğitmeni = "ayse";
            kurs1.izlenmeoranı = 5;
           
            Kurs kurs2 = new Kurs();
            kurs2.Kursadı = "java";
            kurs2.kursuneğitmeni = "ali";
            kurs2.izlenmeoranı = 55;

            Console.WriteLine(kurs1.Kursadı+": "+ kurs1.kursuneğitmeni);

            Console.WriteLine("Hello World!");

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2 };

            foreach (Kurs kurs  in kurslar)
            {
                Console.WriteLine(kurs.Kursadı);
            }
        }
    }

    class Kurs
    {
        public string Kursadı { get; set; }
        public string kursuneğitmeni { get; set; }
        public int izlenmeoranı { get; set; }
    }
}
