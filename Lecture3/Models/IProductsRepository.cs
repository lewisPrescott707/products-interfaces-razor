using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lecture3.Models
{
    public interface IProductsRepository
    {
        IEnumerable<Product> GetAllProducts();

        Product GetProduct(int id);

        void Update(Product service);

        void Add(Product service);

        void Delete(Product service);

        void Save();
    }
}
