using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Shop.Models
{
    public class CartModel
    {
        public int Count { get; set; } = 0;
        public decimal TotalPrice { get; set; } = 0;
    }
}
