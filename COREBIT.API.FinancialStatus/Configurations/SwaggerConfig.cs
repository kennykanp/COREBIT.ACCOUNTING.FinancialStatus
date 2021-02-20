using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace COREBIT.API.FinancialStatus.Configurations
{
	public static class SwaggerConfig
	{
		public static void AddSwaggerConfiguration(this IServiceCollection services)
		{
			if (services == null)
				throw new ArgumentNullException(nameof(services));

			services.AddSwaggerGen(swg =>
			{
				swg.SwaggerDoc("v1", new OpenApiInfo
				{
					Version = "v1",
					Title = "COREBIT ACCOUNTING FinancialStatus",
					Description = "FinancialStatus Swagger surface",
					Contact = new OpenApiContact { Name = "COREBIT", Email = "kenny.nino@ecorebit.com", Url = new Uri("http://ecorebit.com/") }
				});

				swg.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
				{
					Description = "Input the JWT like: Bearer {your token}",
					Name = "Authorization",
					Scheme = "Bearer",
					BearerFormat = "JWT",
					In = ParameterLocation.Header,
					Type = SecuritySchemeType.ApiKey
				});

				swg.AddSecurityRequirement(new OpenApiSecurityRequirement
				    {
						{
							new OpenApiSecurityScheme
							{
								Reference = new OpenApiReference
								{
									Type = ReferenceType.SecurityScheme,
									Id = "Bearer"
								}
							},
							Array.Empty<string>()
						}
				    });
			});
		}

		public static void UseSwaggerSetup(this IApplicationBuilder app)
		{
			if (app == null)
				throw new ArgumentNullException(nameof(app));

			app.UseSwagger();

			app.UseSwaggerUI(c =>
			{
				c.SwaggerEndpoint("./swagger/v1/swagger.json", "FinancialStatus v1");
				c.RoutePrefix = string.Empty;
			});
		}
	}
}
