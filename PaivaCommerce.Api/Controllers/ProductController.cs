using Microsoft.AspNetCore.Mvc;
using PaivaCommerce.Application.Interfaces;

namespace PaivaCommerce.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductApplicationService _productApplicationService;
        public ProductController(IProductApplicationService productApplicationService)
        {
            _productApplicationService = productApplicationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            var result = await _productApplicationService.GetAllAsync();
            return Ok(result);
        }
    }
}