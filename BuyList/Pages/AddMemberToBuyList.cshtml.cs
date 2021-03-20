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
    public class AddMemberToBuyListModel : PageModel
    {
        private readonly BuyListContext _context;
        public AddMemberToBuyListModel(BuyListContext context)
        {
            _context = context;
        }
        [BindProperty]
        public string BuyListName { get; set; }
        [BindProperty]
        public string MemberId { get; set; }


        public List<ProductList> ListOfBuyLists = new List<ProductList>();

        public async Task<IActionResult> OnGetAsync()
        {
            ListOfBuyLists = await _context.ProductList.ToListAsync();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            Member member = new Member();
            var q = await _context.ProductList.FirstOrDefaultAsync(q => q.Name == BuyListName);
            member.ProductList = q;
            member.UserId = MemberId;
            _context.Member.Add(member);
            await _context.SaveChangesAsync();
            return Page();
        }

       
    }
}
