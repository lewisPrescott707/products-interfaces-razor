using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Lecture3.Models;

namespace Lecture3.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly IProductsRepository _productsRepository;

        public IndexModel(IProductsRepository productsRepository)
        {
            _productsRepository = productsRepository;
        }

        public IList<Product> Product { get;set; }

        public void OnGet()
        {
            var products = _productsRepository.GetAllProducts();
            Product = products.ToList();
        }
    }
}
