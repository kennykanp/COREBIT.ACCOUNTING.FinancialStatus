using COREBIT.Application.FinancialStatus.Dto;
using COREBIT.Application.FinancialStatus.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace COREBIT.API.FinancialStatus.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class ExampleController : ControllerBase
	{
		private readonly IExampleEntityAppService _exampleEntityAppService;

		public ExampleController(IExampleEntityAppService exampleEntityAppService) =>
			_exampleEntityAppService = exampleEntityAppService;

		[HttpGet]
		public async Task<IActionResult> GetAsync([FromBody] ExampleEntityDto dto) =>
			new OkObjectResult(await _exampleEntityAppService.GetAsync(dto));

		[HttpPost]
		public async Task<IActionResult> AddAsync([FromBody] ExampleEntityDto dto) =>
			new OkObjectResult(await _exampleEntityAppService.AddAsync(dto));

		[HttpGet("GetBy")]
		public async Task<IActionResult> GetByAsync(int something) =>
			new OkObjectResult(await _exampleEntityAppService.GetByAsync(something));
	}
}
