using COREBIT.Application.FinancialStatus.Dto;
using DDD.Helper.Application.JsonConfiguration;
using System.Threading.Tasks;

namespace COREBIT.Application.FinancialStatus.Interface
{
	public interface IExampleEntityAppService
	{
		Task<IJsonResult> AddAsync(ExampleEntityDto dto);
		Task<IJsonResult> GetAsync(ExampleEntityDto dto);
		Task<IJsonResult> GetByAsync(int something);
	}
}
