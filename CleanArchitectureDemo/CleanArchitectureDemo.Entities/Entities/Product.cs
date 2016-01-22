using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Domain.Entities
{
    public class Product
    {
        public Product(int productId, string title, decimal price, int stock, string brand)
        {
            ProductId = productId;
            Title = title;
            Price = price;
            Stock = stock;
            Brand = brand;
        }

        public int ProductId { get; private set; }
        public string Title { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }
        public string Brand { get; private set; }
    }
}
