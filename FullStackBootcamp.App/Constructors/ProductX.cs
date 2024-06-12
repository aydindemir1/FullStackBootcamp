using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackBootcamp.App.Constructures
{
    internal class ProductX
    {

        // static member
        public static int Tax { get; set; }
        
        // instance member
        public string Name { get; set; }
        public int Count { get; set; }
        
       public static int TaxCalculate(int Tax)
        {
            return Tax * 100;
        }

        public  int TaxCalculate2(int Tax)
        {
            return Tax * 200;
        }

        static ProductX()
        {
            Tax = 20;
        }

        public ProductX()
        {
            Name = "Kalem 1";
            Count = 2;
        }

        public ProductX(string name, int count)
        {
            Name = name;
            Count = count;
        }
    }
}
