using BPNPaymentIntegration.Application.Interfaces;
using BPNPaymentIntegration.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BPNPaymentIntegration.Controllers
{
	[ApiController]
	[Route("api/products")]
	public class ProductController : ControllerBase
	{
		private readonly IProductService _productService;

		public ProductController(IProductService productService)
		{
			_productService = productService;
		}

		[HttpGet]
		public ActionResult<IEnumerable<Product>> GetProducts()
		{
			return Ok(_productService.GetProducts());
		}
	}
}
