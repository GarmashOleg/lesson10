using System;
using System.Collections.Generic;
using Microsoft.VisualBasic.CompilerServices;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main(string[] args)
        {
            var vehicles = new List<IVehicle>
            {
                new Minivan(5, "BMW", 1, 888888),
                new Van(
                    100,
                    100000,
                    new Insurance(DateTime.Now, DateTime.Now, "Oleh Harmash"),
                    "Lada",
                    10,
                    999999),
                new Minivan (5, "Kalina", 15, 888888),
                new Bicycle()
            };

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
