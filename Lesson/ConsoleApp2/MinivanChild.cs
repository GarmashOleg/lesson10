using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class abstract MinivanChild : Minivan
    {
        public MinivanChild(int numberOfSeats, string carName, int id, double price) : base(id, carName, price)
        {
        }
        public override string Name { get; set => throw new NotImplementedException(); }
        //public override string Name => "Minivan";

        
    }
}
