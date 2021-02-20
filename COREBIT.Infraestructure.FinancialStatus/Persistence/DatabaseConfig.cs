using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace COREBIT.Infraestructure.FinancialStatus.Persistence
{
	public static class DatabaseConfig
	{
		public static IServiceCollection AddDbContextConfiguration(this IServiceCollection services, IConfiguration configuration)
		{
			services.AddScoped<DbContext, DbContextConfig>();

			services.AddDbContext<DbContextConfig>(options
				// TODO : Change [ExampleDomainDB] to a correct name
				=> options.UseOracle(configuration.GetConnectionString("ExampleDomainDB"), c =>
				{
					c.UseOracleSQLCompatibility("11");
					c.MaxBatchSize(30);
				}));

			return services;
		}
	}
}
