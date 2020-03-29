using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class MinivanChildDouble : MinivanChild
    {
        public MinivanChildDouble(int numberOfSeats, string carName, int id, double price)
        {
        }

        public string Greeting => "Hello from double";
    }
}
