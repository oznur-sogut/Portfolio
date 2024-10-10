using Microsoft.AspNetCore.Mvc;
using Portfolio.DataAccessLayer.Context;
using Portfolio.DataAccessLayer.Entities;

namespace Portfolio.Controllers
{
	public class SocialMediaController : Controller
	{
		PortfolioContext context=new PortfolioContext();
		public IActionResult SocialMediaList()
		{
			var value=context.SocialMedias.ToList();
			return View(value);
		}
		[HttpGet]
		public IActionResult CreateSocialMedia()
		{
			return RedirectToAction("SocialMediaList");
		}
		[HttpPost]
		public IActionResult CreateSocialMedia(SocialMedia socialMedia)
		{
			context.SocialMedias.Add(socialMedia);
			context.SaveChanges();
			return RedirectToAction("SocialMediaList");
		}
		public IActionResult DeleteSocialMedia(int id)
		{
			var values = context.SocialMedias.Find(id);
			context.SocialMedias.Remove(values);
			context.SaveChanges();
			return RedirectToAction("SocialMediaList");
		}
		[HttpGet]
		public IActionResult UpdateSocialMedia(int id)
		{
			var values = context.SocialMedias.Find(id);
			return View(values);
		}
		[HttpPost]
		public IActionResult UpdateSocialMedia(SocialMedia socialMedia)
		{
			context.SocialMedias.Update(socialMedia);
			context.SaveChanges();
			return RedirectToAction("SocialMediaList");
		}
	}
}
