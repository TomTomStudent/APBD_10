using Microsoft.AspNetCore.Mvc;
using SimpleAspNetCoreApp.Services;

namespace SimpleAspNetCoreApp.ViewComponents
{
    public class ProductListViewComponent : ViewComponent
    {
        private readonly IProductService _productService;

        public ProductListViewComponent(IProductService productService)
        {
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var products = _productService.GetProducts();
            return View(products);
        }
    }
}
