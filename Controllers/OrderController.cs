using BPNPaymentIntegration.Application.DTOs;
using BPNPaymentIntegration.Application.Interfaces;
using BPNPaymentIntegration.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BPNPaymentIntegration.Controllers
{
	[ApiController]
	[Route("api/orders")]
	public class OrderController : ControllerBase
	{
		private readonly IOrderService _orderService;

		public OrderController(IOrderService orderService)
		{
			_orderService = orderService;
		}

		[HttpPost("create")]
		public async Task<ActionResult<Order>> CreateOrder([FromBody] OrderRequestDto request)
		{
			var order = await _orderService.CreateOrderAsync(request);
			return Ok(order);
		}

		[HttpPost("{id}/complete")]
		public async Task<ActionResult> CompleteOrder(Guid id)
		{
			await _orderService.CompleteOrderAsync(id);
			return Ok();
		}
	}
}
