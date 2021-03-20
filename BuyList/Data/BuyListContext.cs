using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BuyList.Models;

namespace BuyList.Data
{
    public class BuyListContext : DbContext
    {
        public BuyListContext (DbContextOptions<BuyListContext> options)
            : base(options)
        {
        }

        public DbSet<BuyList.Models.Product> Product { get; set; }

        public DbSet<BuyList.Models.ProductList> ProductList { get; set; }

        public DbSet<BuyList.Models.Member> Member { get; set; }

    }
}
