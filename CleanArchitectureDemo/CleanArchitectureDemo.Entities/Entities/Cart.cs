using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Domain.Entities
{
    public class Cart
    {
        public int CartId { get; private set; }
        public decimal TotalAmount { get; private set; }
        public List<CartItem> CartItems { get; private set; }

        public void AddToCart(CartItem cartItem)
        {
            if(cartItem.Product.Stock > 0)
                CartItems.Add(cartItem);
        }

        public decimal GetTotalAmount()
        {
            decimal totalAmount = 0;
            foreach (CartItem cartItem in CartItems)
                totalAmount += cartItem.Product.Price * cartItem.Quantity;
            return totalAmount;
        }
    }
}
