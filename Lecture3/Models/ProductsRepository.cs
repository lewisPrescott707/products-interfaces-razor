using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lecture3.Models
{
    public class ProductsRepository : IProductsRepository
    {
        private readonly Lecture3.Models.ProductContext _context;

        public ProductsRepository(ProductContext context)
        {
            _context = context;
        }

        public void Add(Product service)
        {
            _context.Add(service);
        }

        public void Delete(Product service)
        {
            _context.Remove(service);
        }

        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products;
        }

        public Product GetProduct(int id)
        {
            return _context.Products.FirstOrDefault(d => d.ID == id);
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(Product service)
        {
            _context.Entry(service).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
        }
    }
}
