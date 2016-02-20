using CleanArchitectureDemo.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CleanArchitectureDemo.Domain.Entities;

namespace CleanArchitectureDemo.Infrastructure.Data
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> Get()
        {
            //Retrieve productsEF

            //Map to domain products

            //return domain products
            throw new NotImplementedException();
        }

        public Product GetById(int productId)
        {
            throw new NotImplementedException();
        }
    }
}
