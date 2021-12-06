using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameStop_API.Model;
using GameStop_API.Services;
using Microsoft.AspNetCore.Http;

namespace GameStop_API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase //ControllerBase cannot handle the views. only the resources
    {
        private IProductService _productService = ScaffoldingProductService.GetInstance();

        [HttpGet]
        public IEnumerable<Product> GetAll()
        {
            return _productService.GetAll();
        }

        [HttpPost]
        public IActionResult AddProduct(
            //this allows the body of the call to be passed as parameter to the method
            //transforms JSON into a C# object (!!!!)
            [FromBody] Product newProduct)
        {
            _productService.AddProduct(newProduct);
            return Ok();
        }
    }
}
