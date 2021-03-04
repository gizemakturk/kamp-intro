using System;
using System.Collections.Generic;
using System.Text;
//Gizem Aktürk
//03.03.2021
namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Tebriksss.. Bankamıza Eklendiniz. "+ musteri.Adı+" - "+musteri.Soyadi );
        }
         public void MusteriListele(Musteri [] musteriler )
        {
           
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri.Id);
                Console.WriteLine(musteri.Adı);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Yasi);
                Console.WriteLine(musteri.Meslek);
                Console.WriteLine("--------------------------");
            }
         }
        public void MusteriSilme(Musteri musteri)
        {
            Console.WriteLine("Bankamızdan Silindiniz. " + musteri.Adı + " - " + musteri.Soyadi);
        }
    }
}
