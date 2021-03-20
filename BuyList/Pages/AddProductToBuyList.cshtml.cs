using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuyList.Data;
using BuyList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BuyList.Pages
{
    public class AddProductToBuyListModel : PageModel
    {
        private readonly BuyListContext _context;
        public AddProductToBuyListModel(BuyListContext context)
        {
            _context = context;
        }

        [BindProperty]
        public string BuyListName { get; set; }

        public List<ProductList> ListOfProductLists { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            ListOfProductLists = await _context.ProductList.ToListAsync();
            return Page();
        }
    }
}
