using Product_Task.Models;
using System;

namespace Product_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product("Fanta", 0.7, Enums.ProductType.Drink);
            Product product2 = new Product("Kruassan", 1, Enums.ProductType.Bakery);
            Product product3 = new Product("Golden", 15, Enums.ProductType.Fish, 1);
            Product product4 = new Product("Rabbit", 20, Enums.ProductType.Meat, 2);

            Console.WriteLine(product1);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(product2);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(product3);
            Console.WriteLine("----------------------------------------");
            Console.WriteLine(product4);
            Console.WriteLine("----------------------------------------");

        }
    }
}
