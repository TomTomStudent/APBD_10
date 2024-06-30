using SimpleAspNetCoreApp.Models;
using System.Collections.Generic;

namespace SimpleAspNetCoreApp.Services
{
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        void AddProduct(Product product);
    }
}
