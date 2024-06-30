using Microsoft.AspNetCore.Mvc;
using SimpleAspNetCoreApp.Models;
using SimpleAspNetCoreApp.Services;
using System.Collections.Generic;

namespace SimpleAspNetCoreApp.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductApiController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductApiController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetProducts()
        {
            return Ok(_productService.GetProducts());
        }

        [HttpPost]
        public ActionResult<Product> AddProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _productService.AddProduct(product);
            return CreatedAtAction(nameof(GetProducts), new { id = product.Id }, product);
        }
    }
}
