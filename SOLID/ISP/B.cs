using SOLID.SRP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.ISP
{
    internal class B(IWriteProductRepository writeProductRepository)

    {
        public void Update()
        {
            writeProductRepository.Create(new Product());
        }
    }
}
