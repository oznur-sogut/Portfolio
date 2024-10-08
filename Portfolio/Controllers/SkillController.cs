using Microsoft.AspNetCore.Mvc;
using Portfolio.DataAccessLayer.Context;

namespace Portfolio.Controllers
{
	public class SkillController : Controller
	{
		PortfolioContext context = new PortfolioContext();
		public IActionResult SillList()
		{
			var value=context.Skillss.ToList();

			return View(value);
		}
	}
}
