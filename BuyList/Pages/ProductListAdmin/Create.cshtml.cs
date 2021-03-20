using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using BuyList.Data;
using BuyList.Models;

namespace BuyList.Pages.ProductListAdmin
{
    public class CreateModel : PageModel
    {
        private readonly BuyList.Data.BuyListContext _context;

        public CreateModel(BuyList.Data.BuyListContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ProductList ProductList { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ProductList.Add(ProductList);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
