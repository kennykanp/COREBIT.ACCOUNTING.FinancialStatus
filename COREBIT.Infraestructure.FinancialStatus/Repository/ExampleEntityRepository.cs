using COREBIT.Domain.FinancialStatus.Entity;
using COREBIT.Domain.FinancialStatus.Interfaces.RepositoryContracts;
using DDD.Helper.Infraestructure.Repository;
using Microsoft.EntityFrameworkCore;

namespace COREBIT.Infraestructure.FinancialStatus.Repository
{
	public class ExampleEntityRepository : Repository<ExampleEntity, int>, IExampleEntityRepository
	{
		public ExampleEntityRepository(DbContext dbContext) : base(dbContext)
		{
		}
	}
}
