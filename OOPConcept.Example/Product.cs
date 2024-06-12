using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPConcept.Example;

internal class BaseProduct
{
    public int Id { get; set; }
    
}

internal class Product : BaseProduct
{
    public string Name { get; init; } = default!; // init keyword ü sayesinde nesne üretildikten sonra değişiklik yapılamaz.
    public decimal Price { get; init; }

    private Product()
    {
    }

    // static factory method
    public static Product Create(string Name, decimal Price)
    {
        ArgumentException.ThrowIfNullOrEmpty(Name, nameof(Product.Name));


        CheckPrice(Price);

        return new Product() { Name = Name, Price = Price };
    }


    private static void CheckPrice(decimal Price)
    {
        if (Price > 3000)
        {
            throw new Exception("");
        }
    }
}