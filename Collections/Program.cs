using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] {"engin ","murat","kerem","halil" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);

            List<string> isimler2 = new List<string> { "engin ", "murat", "kerem", "halil" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            isimler2.Add("ilker");
            Console.WriteLine(isimler2[4]);
        }
    }
}
