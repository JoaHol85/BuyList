using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BuyList.Data;
using BuyList.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BuyList.Pages
{
    public class AddBuyListModel : PageModel
    {
        private readonly BuyListContext _context;
        public AddBuyListModel(BuyListContext context)
        {
            _context = context;
        }

        [BindProperty]
        public ProductList BuyList { get; set; }
        
        public void OnGet()
        {
            
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if(BuyList.Name != null && BuyList.UserId != null)
            {
                _context.ProductList.Add(BuyList);
                await _context.SaveChangesAsync();
            }
            return Page();
        }
    }
}
