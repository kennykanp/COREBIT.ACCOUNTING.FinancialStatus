using AutoMapper.QueryableExtensions;
using COREBIT.Application.FinancialStatus.Dto;
using COREBIT.Application.FinancialStatus.Interface;
using COREBIT.Domain.FinancialStatus.Entity;
using COREBIT.Domain.FinancialStatus.Interfaces.Services;
using DDD.Helper.Application;
using DDD.Helper.Application.JsonConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace COREBIT.Application.FinancialStatus.Service
{
	public class ExampleEntityAppService : BaseAppService, IExampleEntityAppService
	{
		private readonly IExampleEntityService _exampleEntityService;

		public ExampleEntityAppService(IServiceProvider serviceProvider, IExampleEntityService exampleEntityService)
		: base(serviceProvider) =>
		_exampleEntityService = exampleEntityService;

		public async Task<IJsonResult> AddAsync(ExampleEntityDto dto)
		{
			_unitOfWork.BeginTransaction();

			var results = await _exampleEntityService.AddAsync(_mapper.Map<ExampleEntity>(dto));
			
			if (results.IsValid)
				_unitOfWork.CommitTransaction();

			return new JsonResult(results);
		}

		public async Task<IJsonResult> GetAsync(ExampleEntityDto dto)
		{
			var entity = _mapper.Map<ExampleEntity>(dto);
			var results = await _exampleEntityService.GetAsync(entity.MyProperty);
			return new JsonResult<ExampleEntityDto>(_mapper.Map<ExampleEntityDto>(results));
		}

		public async Task<IJsonResult> GetByAsync(int something)
		{
			var results = await _exampleEntityService.Find(p => p.MyProperty == something)
														.ProjectTo<ExampleEntityDto>(_mapper.ConfigurationProvider)
														.ToListAsync();
			return new JsonResult<IEnumerable<ExampleEntityDto>>(results);
		}
	}
}
