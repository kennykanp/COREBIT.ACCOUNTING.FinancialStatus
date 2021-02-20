using COREBIT.API.FinancialStatus.Configurations;
using COREBIT.Application.FinancialStatus;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace COREBIT.API.FinancialStatus
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		public void ConfigureServices(IServiceCollection services)
		{
			// IoC Config
			services.AddDDDConfiguration(Configuration);

			// Controllers Config
			services.AddControllers();

			//Swagger Config
			services.AddSwaggerConfiguration();

		}

		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
				app.UseSwaggerSetup();
			}

			app.UseRouting();

			app.UseAuthorization();

			app.UseEndpoints(endpoints => 
				endpoints.MapControllers());
		}
	}
}
