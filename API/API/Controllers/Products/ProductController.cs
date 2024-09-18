using API.Interface;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult InsertProduct()
        {
            return Ok();

        }
    }
}
