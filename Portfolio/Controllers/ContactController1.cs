using Microsoft.AspNetCore.Mvc;
using Portfolio.DataAccessLayer.Context;

namespace Portfolio.Controllers
{
	public class ContactController1 : Controller
	{
		PortfolioContext context=new PortfolioContext();
		public IActionResult Index()
		{
			var values= context.Contacts.ToList();
			return View(values);
		}
	}
}
