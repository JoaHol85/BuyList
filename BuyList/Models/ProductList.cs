using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuyList.Models
{
    public class ProductList
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public ICollection<Product> ListOfProducts { get; set; }
        public ICollection<Member> ListMembers { get; set; }
    }
}

