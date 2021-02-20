using COREBIT.Domain.FinancialStatus.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace COREBIT.Infraestructure.FinancialStatus.Persistence.EntityConfig
{
	public class ExampleEntityConfig : IEntityTypeConfiguration<ExampleEntity>
	{
		public void Configure(EntityTypeBuilder<ExampleEntity> builder)
		{
			// INFO : This is a example
			builder.ToTable("NEWNAMETABLE");

			builder.HasKey(p => p.MyProperty);

		}
	}
}
