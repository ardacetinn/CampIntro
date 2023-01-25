using System;
using System.Reflection.Metadata;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Prize = 15;
            product1.Description = "Amasya Apple";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Prize = 80;
            product2.Description = "Diyarbakır Watermelon";

            Product[] products = new Product[] {
                product1,
                product2
            };

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Prize);
                Console.WriteLine(product.Description);
                Console.WriteLine("-----------");
            }

            Console.WriteLine("---------Metotlar--------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

        }
    }
}