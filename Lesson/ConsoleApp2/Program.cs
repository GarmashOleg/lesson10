using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualBasic.CompilerServices;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main(string[] args)
        {
            var vehicles = new List<IVehicle>
            {
                new MinivanChild(5, "BMW", 1, 888888),
                new Van(
                    100,
                    100000,
                    new Insurance(DateTime.Now, DateTime.Now, "Oleh Harmash"),
                    "Lada",
                    10,
                    999999),
                new MinivanChild (5, "Kalina", 15, 888888),
                new Bicycle(),
                new MinivanChildDouble (5, "BMW", 1, 111),
                new MinivanChildDouble (5, "BMW", 1, 222)
        };

            var casteMinivanDouble = vehicles.Last() as MinivanChild;
            //var casteMinivanChild = vehicles.Last() as MinivanChildDouble;

            var castedBisycle = vehicles.Last();

            foreach (IVehicle car in vehicles)
            {
                Console.Write(car.Name + " ");
                Console.WriteLine("Speed: " + car.GetSpeed());
            }

            IVehicle van = new Van(
                100,
                100000,
                new Insurance(DateTime.Now, DateTime.Now, "Yuliia Nechyporuk"),
                "Lada",
                10,
                12000);

            van.PrintInfo();
        }
    }
}