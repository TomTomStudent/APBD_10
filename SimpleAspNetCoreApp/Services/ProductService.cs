using SimpleAspNetCoreApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace SimpleAspNetCoreApp.Services
{
    public class ProductService : IProductService
    {
        private readonly List<Product> _products = new List<Product>();

        public IEnumerable<Product> GetProducts()
        {
            return _products;
        }

        public void AddProduct(Product product)
        {
            product.Id = _products.Count + 1;
            _products.Add(product);
        }
    }
}
