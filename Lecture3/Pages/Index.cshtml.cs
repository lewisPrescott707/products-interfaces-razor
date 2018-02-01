﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lecture3.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace Lecture3.Pages
{
    public class IndexModel : PageModel
    {

        private readonly ProductContext _context;

        public IndexModel(ProductContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get; set; }

        public async Task OnGetAsync()
        {
            Product = await _context.Products.ToListAsync();
        }
    }
}
