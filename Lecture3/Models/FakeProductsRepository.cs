using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lecture3.Models
{
    public class FakeProductsRepository : IProductsRepository
    {
        public void Add(Product service)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product service)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = new List<Product>
            {
                new Product() { ID = 1, Price=25, Title ="I am a product"}
            };

            return products;
        }

        public Product GetProduct(int id)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Product service)
        {
            throw new NotImplementedException();
        }
    }
}
