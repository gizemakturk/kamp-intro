using System;

namespace Kampintro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety(string int ...)
            string kategoriEtiketi = "Kategori";
            int ogrencisayısı = 32000;
            double faizoranı=1.45;
            bool sistemegirisyapmısmı = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }


            if (sistemegirisyapmısmı==true)
            {
                Console.WriteLine("Kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu ");
            }
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine("Hello World!");
        }
    }
}
