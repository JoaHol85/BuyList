using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuyList.Models
{
    public class Product
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public bool Bought { get; set; }
        public string UserId { get; set; }
        public ProductList ProductList { get; set; }
    }
}
