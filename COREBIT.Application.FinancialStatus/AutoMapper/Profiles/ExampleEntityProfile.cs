using AutoMapper;
using COREBIT.Application.FinancialStatus.Dto;
using COREBIT.Domain.FinancialStatus.Entity;

namespace COREBIT.Application.FinancialStatus.AutoMapper.Profiles
{
	public class ExampleEntityProfile : Profile
	{
		public ExampleEntityProfile()
		{
			#region DtoToDomain
			CreateMap<ExampleEntityDto, ExampleEntity>();
			#endregion

			#region DomainToDto
			CreateMap<ExampleEntity, ExampleEntityDto>();
			#endregion
		}
	}
}
