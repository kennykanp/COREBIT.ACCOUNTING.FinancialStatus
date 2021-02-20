using COREBIT.Domain.FinancialStatus.Entity;
using COREBIT.Infraestructure.FinancialStatus.Persistence.EntityConfig;
using Microsoft.EntityFrameworkCore;

namespace COREBIT.Infraestructure.FinancialStatus.Persistence
{
	public class DbContextConfig : DbContext
	{
		public DbContextConfig(DbContextOptions<DbContextConfig> options) : base(options)
		{
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);

			modelBuilder.ApplyConfiguration(new ExampleEntityConfig());
		}

		public DbSet<ExampleEntity> ExampleEntity { get; set; }
	}
}
