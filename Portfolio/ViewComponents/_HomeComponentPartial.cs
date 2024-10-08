using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
	public class _HomeComponentPartial: ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
