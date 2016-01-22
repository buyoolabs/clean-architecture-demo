using CleanArchitectureDemo.Domain.Entities;
using CleanArchitectureDemo.Domain.UseCases.GetListProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitectureDemo.Domain.Repositories
{
    public interface IProductRepository
    {
        List<Product> Get();

        Product GetById();
    }
}
