using Microsoft.AspNetCore.Mvc;
using Portfolio.DataAccessLayer.Context;
using Portfolio.DataAccessLayer.Entities;

namespace Portfolio.Controllers
{
	public class MyProfileController : Controller
	{
		PortfolioContext context=new PortfolioContext();
		public IActionResult MyProfileList()
		{
			var value = new PortfolioContext();
			return View(value);
		}
		[HttpGet]
		public IActionResult UpdateProfile(int id)
		{
			var value = context.Contacts.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateProfile(Contact contact)
		{
			context.Contacts.Update(contact);
			context.SaveChanges();
			return RedirectToAction("MyProfileList");
		}
	}
}
