using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Lab5Final.Models;

namespace Lab5Final.ViewModels
{
    public class ShoppingCartViewModel
    {
        public virtual List<Cart> CartItems { get; set; }
        public virtual decimal CartTotal { get; set; }
    }
}