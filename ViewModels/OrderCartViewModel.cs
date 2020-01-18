using System.Collections.Generic;
using CafeO.Models;

namespace CafeO.ViewModels
{
    public class OrderCartViewModel
    {
        public List<CartItem> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}