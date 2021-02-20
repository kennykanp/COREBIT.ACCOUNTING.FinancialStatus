using AutoMapper;
using COREBIT.Application.FinancialStatus.AutoMapper.Profiles;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace COREBIT.Application.FinancialStatus.AutoMapper
{
	public static class AutoMapperConfiguration
	{
		public static IServiceCollection AddDependencyInjectionAutoMapper(this IServiceCollection services)
		{
			if (services == null)
				throw new ArgumentNullException(nameof(services));

			services.AddAutoMapper(typeof(ExampleEntityProfile));
			return services;
		}
	}
}
