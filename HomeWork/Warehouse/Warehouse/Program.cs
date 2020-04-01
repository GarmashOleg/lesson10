using System;
using System.Collections.Generic;
using Warehouse_lib;
using Warehouse_app.Products.Food;
using Warehouse_app.Products.Houshold;
using Warehouse_app.Interfaces;

namespace Warehouse_app
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Emulate Expiration date
            var dateIncoming = DateTime.Now.AddDays(-4).Date;


            // New List with products
            var products = new List<IProduct>
            //List<IProduct> Products = new List<IProduct>
            {
                new WashingPowder ("WashingPowder", 5, dateIncoming),
                new Bread ("Bread", 6, dateIncoming),
                new Sausage ("Sausage", 6, dateIncoming),
                new CannedFood ("CannedFood", 6, dateIncoming)
            };


            // Check products end remove outdated. And Print info
            for (int count=0; count < products.Count; count++)
            {
                dynamic item = products[count];
                var propertyFilter = "DateExpiration";
                var property = item.GetType().GetProperty($"{propertyFilter}");

                item.PrintInfo();

                if (property != null)
                {
                    item = (IDateExpiration)item;
                    if (item.DateExpiration <= DateTime.Now)
                    {
                        Console.WriteLine("==> Product {0} outdated and will be removed", item.Name);
                        products.Remove(item);
                        count--;
                    }
                }
            }


            // Print updated list
            Console.WriteLine("\n-------- Updated warehouse ------------");
            products.ForEach(item => item.PrintInfo());

            Console.ReadLine();
        }
    }
}
