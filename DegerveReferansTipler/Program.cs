﻿using System;

namespace DegerveReferansTipler
{
    class Program
    {
        //int , decimal , float,double bool= deger tip(stack)
        //array,class, interface= referans tip(sayılar stackte new deyince heap adresi olusuyor)
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sayı1 = 10;
            int sayı2 = 30;
            sayı1 = sayı2;
            sayı2 = 65;
            //sayı1? 30

            int[] sayılar1 = new int[] { 10, 20, 30 };
            int[] sayılar2 = new int[] { 100, 200, 300 };
            sayılar1 = sayılar2;
            sayılar2[0] = 999;
            //sayılar1[0]??  999 sayılar1 artık sayılar2nin adresini gösteriyor
        }
    }
}
