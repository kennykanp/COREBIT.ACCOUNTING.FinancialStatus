using COREBIT.Domain.FinancialStatus.Entity;
using COREBIT.Domain.FinancialStatus.Interfaces.RepositoryContracts;
using COREBIT.Domain.FinancialStatus.Interfaces.Services;
using DDD.Helper.Domain.Service;

namespace COREBIT.Domain.FinancialStatus.Services
{
	public class ExampleEntityService : Service<ExampleEntity, int>, IExampleEntityService
	{
		public ExampleEntityService(IExampleEntityRepository repository) : base(repository)
		{
		}
	}
}
