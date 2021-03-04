using System;
//Gizem Aktürk
//03.03.2021
namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Musteri musteri1 = new Musteri();
            musteri1.Id = 111;
            musteri1.Adı = "Talip";
            musteri1.Soyadi = "AAA";
            musteri1.Yasi = 30;
            musteri1.Meslek = "Polis";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 222;
            musteri2.Adı = "Gulsu";
            musteri2.Soyadi = "BBB";
            musteri2.Yasi = 35;
            musteri2.Meslek = "Hemsire";

            Musteri musteri3 = new Musteri();
            musteri3.Id =333;
            musteri3.Adı = "Tuna";
            musteri3.Soyadi = "CCC";
            musteri3.Yasi = 10;
            musteri3.Meslek = "Futbolcu";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriEkle(musteri1);
            Console.WriteLine("----------------------");
            Musteri[] musteriler = new Musteri[] { musteri1,musteri2,musteri3};
            musteriManager.MusteriListele(musteriler);
            musteriManager.MusteriSilme(musteri3);


        }
    }
}
