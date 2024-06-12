using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcept.Example
{
    internal interface IProductRepository
    {
        int Save(Product product);
        bool Any(int productId);
        List<Product> GetProducts();

        int GetNewId();
    }
}
