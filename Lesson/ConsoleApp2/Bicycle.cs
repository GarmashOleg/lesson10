using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Bicycle : IVehicle
    {
        public string Name => "Bicycle!";
        public int GetSpeed()
        {
            return 15;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine(Name);
        }
    }
}