using System;
using Warehouse_app.BaseType;

namespace Warehouse_app.Products.Food
{
    internal class Bread : FoodBase
    {
        private readonly int _lifeCycle = 3;

        internal Bread(string name, decimal price, DateTime dateIncoming) : base(name, price, dateIncoming)
        {
            Name = name;
            Price = price;
            DateIncoming = dateIncoming;
            DateExpiration = dateIncoming.AddDays(_lifeCycle);
        }
    }
}
