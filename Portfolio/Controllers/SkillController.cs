using Microsoft.AspNetCore.Mvc;
using Portfolio.DataAccessLayer.Context;
using Portfolio.DataAccessLayer.Entities;

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
		public IActionResult DeleteSkill(int id)
		{
			var value = context.Skillss.Find(id);
			context.Skillss.Remove(value);
			context.SaveChanges();
			return RedirectToAction("SillList");
		}
		[HttpGet]
		public IActionResult UpdateSkill(int id)
		{
			var value = context.Skillss.Find(id);
			return View(value);
		}
		[HttpPost]
		public IActionResult UpdateSkill (Skills skill)
		{
			context.Skillss.Update(skill);
			context.SaveChanges();
			return RedirectToAction("SillList");
		}
		[HttpGet]
		public IActionResult CreateSkill()
		{
			return View();
		}
		[HttpPost]
		public IActionResult CreateSkill (Skills skill)
		{
			context.Skillss.Add(skill);
			context.SaveChanges();
			return RedirectToAction("SillList");
		}
	}
}
