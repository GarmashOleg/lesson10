
using System;

namespace ConsoleApp2
{
    public class Minivan : Car
    {
        private int maxNumberOfSeats = 10;
        private int numberOfSeats = 4;


        public Minivan(int numberOfSeats, string carName, int id, double price) : base(id, carName, price)
        {
            NumberOfSeats = numberOfSeats;
        }
        public override string Name => "Minivan";

        public override int GetSpeed()
        {
            return 150;
        }

        public override void PrintInfo()
        {
            Console.WriteLine(ToString());
        }

        public int NumberOfSeats
        {
            get => numberOfSeats;
            set
            {
                if (value < 0 || value > maxNumberOfSeats)
                {
                    System.Console.WriteLine("Invalid input");
                }
                else
                {
                    numberOfSeats = value;
                }
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"Id: {ID}, Name: {CarName}, Price: {Price}";
        }
    }
}
