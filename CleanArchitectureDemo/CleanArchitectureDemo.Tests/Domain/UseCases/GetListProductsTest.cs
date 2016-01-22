using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using CleanArchitectureDemo.Domain.Entities;
using CleanArchitectureDemo.UseCases;
using CleanArchitectureDemo.Domain.UseCases.GetListProducts;
using Moq;
using CleanArchitectureDemo.Domain.Repositories;

namespace CleanArchitectureDemo.Domain.UseCases
{
    [TestClass]
    public class GetListProductsTest
    {
        [TestMethod]
        public void GetListProducts_ShouldReturnProducts()
        {
            List<Product> products = new List<Product>();
            products.Add(new Product(1, "Lenovo G570", 1200m, 1, "Lenovo"));
            products.Add(new Product(2, "Apple Macbook pro", 2200m, 5, "Apple"));

            Mock<IProductRepository> productRepository = new Mock<IProductRepository>();
            productRepository.Setup(repository => repository.Get()).Returns(products);

            GetListProductsInteractor listProduct = new GetListProductsInteractor(productRepository.Object);
            
            GetListProductsResponse response = listProduct.Execute();

            Assert.IsTrue(response != null && response.Products != null && response.Products.Count > 0);
        }
    }
}
