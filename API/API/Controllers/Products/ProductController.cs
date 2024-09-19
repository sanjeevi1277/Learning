using API.Interface;
using Microsoft.AspNetCore.Mvc;
using Model.Entities;

namespace API.Controllers.Products
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProduct _product;
        public ProductController(IProduct product)
        {
            _product = product;
        }
        [HttpPost("ADDPRODUCT")]
        public string InsertProduct(Product product)
        {
            var res = _product.AddProduct(product);
            return res;

        }
        [HttpGet("GETPRODUCT")]
        public IEnumerable<Product> Getproduct()
        {
            return _product.GetProduct();
        }
    }
}
