using System;

namespace Metotlar
{
    //do not repeat yourself-dry- clean code- best practice
    class Program
    {
        static void Main(string[] args)
        {
            string ürünadı = "elma";
            double fiyat = 15;
            string aciklama = "amasya elması";

            string[] meyveler = new string[] {"elma","karpuz" };
            Urun urun1 = new Urun();
            urun1.Adı = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adı = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpusu";

            Urun[] urunler = new Urun[] {urun1,urun2 };
             //type safe -- tip güvenli 
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adı);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-----------------------------");
            }

            Console.WriteLine("--------------------------Metot----------------------------");
            //encapsulation ekle birde parametreyi class aldık ekle2de değişken
            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);

            sepetmanager.Ekle2("armut", "yeşil armut", 12,5);
            sepetmanager.Ekle2("elma", "yeşil elma", 15,6);


        }
    }
}
