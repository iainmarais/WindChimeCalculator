using ChimeCalculator.BusinessLogic.Models;
using Microsoft.AspNetCore.Mvc;

namespace ChimeCalculator.Api.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class ChimeController : ControllerBase
	{
		[HttpPost]
		public CylinderModel Post(ChimeInput input)
		{
			var calc = new BusinessLogic.ChimeCalculator();
			
			return calc.Caculate(input);
		}
	}
}
