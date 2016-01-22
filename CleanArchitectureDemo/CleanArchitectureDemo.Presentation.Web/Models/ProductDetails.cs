using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CleanArchitectureDemo.Presentation.Web.Models
{
    public class ProductDetails
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
        public string Brand { get; set; }
    }
}