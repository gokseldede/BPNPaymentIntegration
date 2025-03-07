using BPNPaymentIntegration.Application.Interfaces;
using BPNPaymentIntegration.Application.Services;
using BPNPaymentIntegration.Infrastructure.Context;
using BPNPaymentIntegration.Infrastructure.IRepository;
using BPNPaymentIntegration.Infrastructure.Repositories;
using BPNPaymentIntegration.Middleware;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

namespace BPNPaymentIntegration
{
	public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

			// Services Registration (Dependency Injection)
			builder.Services.AddControllers();
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen(c =>
			{
				c.SwaggerDoc("v1", new OpenApiInfo { Title = "BPN Payment API", Version = "v1" });
			});
			builder.Services.AddDbContext<AppDbContext>(options =>
				options.UseInMemoryDatabase("BPNPaymentDB"));

			builder.Services.AddHttpClient<IPaymentService, PaymentService>();


			builder.Services.AddScoped<IOrderService, OrderService>();
			builder.Services.AddScoped<IProductService, ProductService>();
			builder.Services.AddScoped<IOrderRepository, OrderRepository>();
			builder.Services.AddScoped<IProductRepository, ProductRepository>();

			builder.Services.AddControllers();

			var app = builder.Build();

			// Middleware & Pipeline Configuration
			if (app.Environment.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseSwagger();
				app.UseSwaggerUI(c =>
				{
					c.SwaggerEndpoint("/swagger/v1/swagger.json", "BPN Payment API v1");
					c.RoutePrefix = string.Empty;
				});
			}
			app.UseMiddleware<ExceptionHandlingMiddleware>();
			app.UseRouting();
			app.UseAuthorization();
			app.MapControllers();
			app.Run();
		}
	}
}
