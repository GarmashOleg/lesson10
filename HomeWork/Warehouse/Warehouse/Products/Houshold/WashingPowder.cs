using System;
using Warehouse_app.Interfaces;
using Warehouse_lib;

namespace Warehouse_app.Products.Houshold
{
    internal class WashingPowder : Product, INonFood
    {
        internal WashingPowder(string name, decimal price, DateTime dateIncoming) : base (name, price, dateIncoming)
        {
        }
    }
}
