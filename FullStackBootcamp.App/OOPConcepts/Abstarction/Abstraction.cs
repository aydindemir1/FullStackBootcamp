using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FullStackBootcamp.App.OOPConcepts.Abstarction
{
    public abstract class Computer
    {
        public int Ram { get; set; }
        public int Cpu { get; set; }
        public int Gpu { get; set; }

        public void Create()
        {
            
        }
    }

    internal class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }


    internal abstract class WriteProductRepositoryAbstract
    {
        public int Calculate(int tax, int price)
        {
            return tax * price;
        }
        public  abstract int Y { get; set; }
        internal abstract int Create(Product product);
        internal abstract void Update(Product product);
        internal abstract void Delete(int id);
    }

    internal class WriteProductRepositoryWithSqlServer2 : WriteProductRepositoryAbstract
    {
        public override int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        internal override int Create(Product product)
        {
            throw new NotImplementedException();
        }

        internal override void Delete(int id)
        {
            throw new NotImplementedException();
        }

        internal override void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
    internal interface IWriteProductRepository
    {
        public int Calculate(int tax, int price)
        {
            return tax * price;
        }
        public int Y { get; set; }
        int Create(Product product);
        void Update(Product product);
        void Delete(int id);

    }

    internal interface IReadProductRepository
    {
        Product GetById(int id);
        List<Product> GetAll();
    }

    internal class WriteProductRepositoryWithSqlServer : IWriteProductRepository
    {
        public int A { get; set; }
        public int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Method()
        {

        }
        public int Create(Product product)
        {
            // save to db
            return 1;

        }

        public void Delete(int id)
        {
            // save to db
        }

        public void Update(Product product)
        {
            // save to db
        }
    }

    internal class ReadProductRepositoryWithSqlServer : IReadProductRepository
    {
        public List<Product> GetAll()
        {
            return new List<Product>();
        }

        public Product GetById(int id)
        {
            return new Product();
        }
    }

    internal class ProductRepository : IWriteProductRepository, IReadProductRepository
    {
        public int Y { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int Create(Product product)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }


}
