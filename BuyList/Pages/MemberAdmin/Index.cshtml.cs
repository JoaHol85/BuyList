using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BuyList.Data;
using BuyList.Models;

namespace BuyList.Pages.MemberAdmin
{
    public class IndexModel : PageModel
    {
        private readonly BuyList.Data.BuyListContext _context;

        public IndexModel(BuyList.Data.BuyListContext context)
        {
            _context = context;
        }

        public IList<Member> Member { get;set; }

        public async Task OnGetAsync()
        {
            Member = await _context.Member.ToListAsync();
        }
    }
}
