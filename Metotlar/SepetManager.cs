using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    //manager bir operasyon tutuyo demek
    class SepetManager
    {
        //syntax
        public void Ekle(Urun urun) 
        {
            Console.WriteLine("Tebriksss..Sepete eklendi : "+ urun.Adı);

        }
        //böyle yapınca yeni bir özellik eklenince heryer hata vardi ama parametreyi class alırsak bir sorun cıkmaz(encapsulation)
         public void Ekle2(string urunAdi,string aciklama,double fiyat,int stokadedi)
        {
            Console.WriteLine("Tebriksss..Sepete eklendi : " +urunAdi);
        }
    }
}
