using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace drofustask1.Interfaces
{
    public interface IProductService
    {
        void ListAllProducts();
        void OrderProduct(string productName);
    }
}
