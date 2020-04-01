using System;
using Warehouse_app.BaseType;

namespace Warehouse_app.Products.Food
{
    internal class CannedFood : FoodBase
    {
        private readonly int _lifeCycle = 6;

        internal CannedFood(string name, decimal price, DateTime dateIncoming) : base(name, price, dateIncoming)
        {
            Name = name;
            Price = price;
            DateIncoming = dateIncoming;
            DateExpiration = dateIncoming.AddMonths(_lifeCycle);
        }
    }
}
