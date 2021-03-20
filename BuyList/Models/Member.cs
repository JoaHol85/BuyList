using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuyList.Models
{
    public class Member
    {
        public int ID { get; set; }
        public string UserId { get; set; }
        public ProductList ProductList { get; set; }
    }
}

