using System;
using System.Collections.Generic;
using System.Linq;

namespace Promotion_Engine
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                for (int counter = 0; ; counter++)
                {
                    List<Product> products = new List<Product>();

                    Console.WriteLine("\n" + "Please enter the total number of order");
                    int totalorders = Convert.ToInt32(Console.ReadLine());
                    for (int numofproduct = 0; numofproduct < totalorders; numofproduct++)
                    {
                        Console.WriteLine("Please enter product from the list:A,B,C or D");
                        string productType = Console.ReadLine();
                        Product product = new Product(productType);
                        products.Add(product);
                    }

                    int totalCost = GetTotalCostofProducts(products);
                    Console.WriteLine("The Total Price of order is " + totalCost);
                }
                
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    

        public static int GetTotalCostofProducts(List<Product> products)
        {
            int counterofA = 0, costOfA = 50;
            int counterofB = 0, costOfB = 30;
            int CounterofC = 0, costOfC = 20;
            int CounterofD = 0, costOfD = 15;
            foreach (Product pr in products)
            {
                if (pr.Id == "A" || pr.Id == "a")
                {
                    counterofA = counterofA + 1;
                }
                if (pr.Id == "B" || pr.Id == "b")
                {
                    counterofB = counterofB + 1;
                }
                if (pr.Id == "C" || pr.Id == "c")
                {
                    CounterofC = CounterofC + 1;
                }
                if (pr.Id == "D" || pr.Id == "d")
                {
                    CounterofD = CounterofD + 1;
                }
            }


            // This part can be handled by Dependency Injection
            AProductPack Apack = new AProductPack();
            BProductPack Bpack = new BProductPack();
            CProductPack Cpack = new CProductPack();
            DProductPack Dpack = new DProductPack();

            int totalCostOfA = Apack.GetPrice(counterofA, costOfA);
            int totalCostOfB = Bpack.GetPrice(counterofB, costOfB);
            int totalCostOfC = Cpack.GetPrice(CounterofC, costOfC);
            int totalCostofD = Dpack.GetPrice(CounterofD, costOfD);
            int Sum= totalCostOfA + totalCostOfB + totalCostOfC + totalCostofD;
            return Sum;

        }
    }
}
