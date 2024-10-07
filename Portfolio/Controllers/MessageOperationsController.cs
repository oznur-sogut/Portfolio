using Microsoft.AspNetCore.Mvc;
using Portfolio.DataAccessLayer.Context;

namespace Portfolio.Controllers
{
	public class MessageOperationsController : Controller
	{
		PortfolioContext context= new PortfolioContext();
		public IActionResult MassegeInBox()
		{
			var value = context.Messages.ToList();
			return View(value);
		}
		public IActionResult MassegeIReadTrue(int id)
		{
			var value = context.Messages.Find(id);
			value.IsRead = true;
			context.SaveChanges();
			return RedirectToAction("MassegeInBox");
		}
		public IActionResult MessageIReadFalse(int id)
		{
			var value = context.Messages.Find(id);
			value.IsRead = false;
			context.SaveChanges();
			return RedirectToAction("MassegeInBox");
		}
		public IActionResult DeleteMessage(int id)
		{
			var value = context.Messages.Find(id);
			context.Messages.Remove(value);
			context.SaveChanges();
			return RedirectToAction("MassegeInBox");
		}
		public IActionResult OpenMessage (int id)
		{
			var value = context.Messages.Find(id);
			return View(value);
		}
	}
}
