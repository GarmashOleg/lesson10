using System;

namespace Warehouse_lib
{
    // Base class for All products
    public class Product : IProduct
    {
        private string _name;
        private decimal _price = 0;

        public Product(string name, decimal price, DateTime dateIncoming)
        {
            Name = name;
            Price = price;
            DateIncoming = dateIncoming;
        }

        // Not Implemented in thad projet
        public void WrongInput()
        {
            Console.WriteLine("Not valid. Try again");
        }

        // That string will overrided for some products
        public override string ToString()
        {
            return String.Format("Product name: {0}, Price: {1}, Incoming Date: {2}", Name, Price, DateIncoming.ToShortDateString());
        }

        // Print product info
        public virtual void PrintInfo()
        {
            Console.WriteLine(ToString());
        }

        // Product Name validation
        public string Name
        {
            get => _name;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    WrongInput();
                    return;
                }
                _name = value;
            }
        }

        // Product Price validation
        public decimal Price
        {
            get => _price;
            set
            {
                if (value < 0)
                {
                    WrongInput();
                    return;
                }
                _price = value;
            }
        }

        public DateTime DateIncoming { get; set; }
    }
}
