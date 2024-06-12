using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcept.Example;

internal class ProductRepository:IProductRepository
{
    private List<Product> Products { get; set; } = new();

    public bool Any(int productId)
    {
        return Products.Any(x => x.Id == productId);
    }

    public int GetNewId()
    {
        return Products.Count + 1;
    }
    public List<Product> GetProducts()
    {
        var innerProductList = new List<Product>();

        foreach (var item in Products)
        {
            innerProductList.Add(item);
        }
        return innerProductList;

    }
    public int Save(Product newProduct)
    {
       

        

        Products.Add(newProduct);
        return newProduct.Id;
    }
  
}
