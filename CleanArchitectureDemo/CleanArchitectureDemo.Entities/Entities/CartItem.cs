using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Domain.Entities
{
    public class CartItem
    {
        public Product Product { get; private set; }

        public int Quantity { get; set; }

    }
}
