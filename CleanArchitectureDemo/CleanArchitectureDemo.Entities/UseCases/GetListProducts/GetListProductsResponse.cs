using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Domain.UseCases.GetListProducts
{
    public class GetListProductsResponse
    {
        public List<ProductsItem> Products;
        public GetListProductsResponse()
        {
            Products = new List<ProductsItem>();
        }
    }

    public class ProductsItem
    {
        public int ProductId { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}
