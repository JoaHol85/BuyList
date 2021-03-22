using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BuyList.Data;
using BuyList.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace BuyList.Pages
{
    public class AddProductToBuyListModel : PageModel
    {
        private readonly BuyListContext _context;
        private readonly ApplicationDbContext _appContext;
        public AddProductToBuyListModel(BuyListContext context, ApplicationDbContext context2)
        {
            _context = context;
            _appContext = context2;

        }

        [BindProperty]
        public string BuyListName { get; set; }
        [BindProperty(SupportsGet = true)]
        public string UserIdString { get; set; }

        public List<ProductList> ListOfProductLists { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            ListOfProductLists = await _context.ProductList.ToListAsync();
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);    //
            
           // var q = _context.Member


            return Page();
        }

        public void GetUserBuyLists()
        {

            
        }
    }
}
