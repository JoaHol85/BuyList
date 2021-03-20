﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BuyList.Data;
using BuyList.Models;

namespace BuyList.Pages.ProductListAdmin
{
    public class DetailsModel : PageModel
    {
        private readonly BuyList.Data.BuyListContext _context;

        public DetailsModel(BuyList.Data.BuyListContext context)
        {
            _context = context;
        }

        public ProductList ProductList { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ProductList = await _context.ProductList.FirstOrDefaultAsync(m => m.ID == id);

            if (ProductList == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
