using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateAndEvent.App
{
   


    internal class DelegateExample
    {
        internal delegate void Sum(int a, int b);

        internal void Method1(int a, object o, Sum sum)
        {
            double c = 20;


        }
    }
}
