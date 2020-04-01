using Warehouse_lib;

namespace Warehouse_app.Interfaces
{
    interface IFood : IProduct, IDateExpiration
    {
        // We can add some additional values for Food. (manufactured company for ex.)
    }
}
