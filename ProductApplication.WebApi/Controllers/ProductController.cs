using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using ProductApplication.Contract.Contracts;
using ProductApplication.ViewModel.ViewModels;

namespace ProductApplication.WebApi.Controllers
{
    [ApiController]
   

    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<ProductController> _logger;
        private readonly IProductRepository _productRepository;

        public ProductController(ILogger<ProductController> logger, IProductRepository productRepository)
        {
            _logger = logger;
            _productRepository = productRepository;
        }

        [HttpGet(Name = "GetProducts")]
        public IEnumerable<ProductData> Get()
        {
            return _productRepository.GetAllProducts();
        }
    }
}