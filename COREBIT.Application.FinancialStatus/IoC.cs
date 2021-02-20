using COREBIT.Application.FinancialStatus.AutoMapper;
using COREBIT.Application.FinancialStatus.Interface;
using COREBIT.Application.FinancialStatus.Service;
using COREBIT.Domain.FinancialStatus.Interfaces.RepositoryContracts;
using COREBIT.Domain.FinancialStatus.Interfaces.Services;
using COREBIT.Domain.FinancialStatus.Services;
using COREBIT.Infraestructure.FinancialStatus.Persistence;
using COREBIT.Infraestructure.FinancialStatus.Repository;
using DDD.Helper.Application;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace COREBIT.Application.FinancialStatus
{
	public static class IoC
	{
		public static IServiceCollection AddDDDConfiguration(this IServiceCollection services, IConfiguration configuration)
		{
			// DDD Helper
			services.DDDHelperIoC(configuration);

			// Database Config
			services.AddDbContextConfiguration(configuration);

			// Automapper Config
			services.AddDependencyInjectionAutoMapper();

			// AppService Config
			services.AddDependencyInjectionAppService();

			// Service Config
			services.AddDependencyInjectionService();

			// Repository Config
			services.AddDependencyInjectionRepository();

			return services;
		}

		private static void AddDependencyInjectionAppService(this IServiceCollection services) =>
			services.AddScoped<IExampleEntityAppService, ExampleEntityAppService>();

		private static void AddDependencyInjectionService(this IServiceCollection services) =>
			services.AddScoped<IExampleEntityService, ExampleEntityService>();

		private static void AddDependencyInjectionRepository(this IServiceCollection services) =>
			services.AddScoped<IExampleEntityRepository, ExampleEntityRepository>();
	}
}
