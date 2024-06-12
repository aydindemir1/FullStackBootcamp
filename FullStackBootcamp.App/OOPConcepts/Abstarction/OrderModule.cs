using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FullStackBootcamp.App.OOPConcepts.Abstarction
{

    public class Order
    {

    }
    internal class OrderModule
    {
        private IStockRepository _stockRepository;

        public OrderModule(IStockRepository stockRepository)
        {
            _stockRepository = stockRepository;
        }



        public void Create(Order order)
        {
            var hasStock = _stockRepository.CheckStock(1, 2);
            if(hasStock==false) { 
                
            }
            //create order


            _stockRepository.DecreaseStock(1, 4);

             // DescreaseStock(orderId,count)
        }
    }
}
