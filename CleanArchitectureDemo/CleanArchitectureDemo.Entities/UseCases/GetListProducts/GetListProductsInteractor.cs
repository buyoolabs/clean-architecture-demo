using CleanArchitectureDemo.Domain.Entities;
using CleanArchitectureDemo.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Domain.UseCases.GetListProducts
{
    public class GetListProductsInteractor
    {
        IProductRepository productRepository;

        public GetListProductsInteractor(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        public GetListProductsResponse Execute()
        {
            //List<Product> products = new List<Product>();
            //List<Product> products = new List<Product>();
            //products.Add(new Product(1, "Lenovo G570", 1200m, 1, "Lenovo"));
            //products.Add(new Product(2, "Apple Macbook pro", 2200m, 5, "Apple"));
            List<Product> products = productRepository.Get();

            GetListProductsResponse response = new GetListProductsResponse();
            ProductsItem productsItem = null;
            foreach (Product p in products)
            {
                productsItem = new ProductsItem();
                productsItem.ProductId = p.ProductId;
                productsItem.Title = p.Title;
                productsItem.Price = p.Price;
                response.Products.Add(productsItem);
                productsItem = null;
            }

            return response;
        }    
    }
}
