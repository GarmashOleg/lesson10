using System;

namespace ConsoleApp2
{
    public abstract class Car : IVehicle
    {
        public Car(int id, string carName, double price)
        {
            CarName = carName;
            ID = id;
            Price = price;
        }

        public int ID { get; set; }

        public string CarName { get; set; }

        public double Price { get; set; }

        public abstract string Name { get; set; }

        public virtual int GetSpeed()
        {
            return 10;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine(ToString());
        }

        public double GetSale()
        {
            var saleSum = new Random().Next(5, 20);
            return Price - (saleSum / 100.0 * Price);
        }

        public override string ToString()
        {
            return $"Id: {ID}, Name: {CarName}, Price {Price}";
        }
    }
}