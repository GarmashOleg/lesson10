using System;
using Warehouse_app.Interfaces;
using Warehouse_lib;

namespace Warehouse_app.BaseType
{
    // Base class for Food products
    class FoodBase : Product, IFood
    {
        internal FoodBase(string name, decimal price, DateTime dateIncoming) : base(name, price, dateIncoming)
        {
            Name = name;
            Price = price;
            DateIncoming = dateIncoming;
        }

        public virtual DateTime DateExpiration { get; set; }

        public override string ToString()
        {
            return base.ToString() + $", Expiration date: {DateExpiration.ToShortDateString()}";
        }
    }
}
