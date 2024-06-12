using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcept.Example
{
    internal class ProductRepositoryWithCache : IProductRepository
    {
        public bool Any(int productId)
        {
            throw new NotImplementedException();
        }

        public int GetNewId()
        {
            throw new NotImplementedException();
        }

        public List<Product> GetProducts()
        {
            throw new NotImplementedException();
        }

        public int Save(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
