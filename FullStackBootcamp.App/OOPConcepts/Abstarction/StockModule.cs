using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackBootcamp.App.OOPConcepts.Abstarction
{

    internal interface IStockRepository
    {
        void DecreaseStock(int productId, int count);
        bool CheckStock(int productId, int count);

        void GetById();
    }
    internal class StockRepository:IStockRepository
    {
        internal int Count { get; set; }

        public bool CheckStock(int productId, int count)
        {
            throw new NotImplementedException();
        }

        public void DecreaseStock(int orderId, int count)
        {
            // decrease stock in db
        }

        public void GetById()
        {
            throw new NotImplementedException();
        }
    }
}
