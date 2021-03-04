using System;

namespace ödevv
{
    class Program
    {
        public static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productname = "elbise";
            product1.productprice = 5;

            Product product2 = new Product();
            product2.productname = "pantalon";
            product2.productprice = 10;

            Console.WriteLine(product1.productname + ": " + product1.productprice);

            Product[] products = new Product[] { product1, product2 };
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].productname);
            }

            foreach (Product product in products)
            {
                Console.WriteLine(product.productname);
            }
            int j = 0;
            while (products.Length < j)
            {
                Console.WriteLine(products[j].productname);
                j++;
            }

        }
        class Product
        {
            public string productname { get; set; }
            public int productprice { get; set; }
        }
    }
}
