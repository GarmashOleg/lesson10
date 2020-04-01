using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_lib
{
    public interface IProduct
    {
        string Name { get; }
        decimal Price { get; set; }
        DateTime DateIncoming { get; set; }

        void PrintInfo();
    }
}
