using Microsoft.AspNetCore.Mvc;
using Portfolio.DataAccessLayer.Context;
using Portfolio.DataAccessLayer.Entities;

namespace Portfolio.Controllers
{
    public class AboutController : Controller
    {
        PortfolioContext context=new PortfolioContext();
        public IActionResult AboutList()
        {
            var value=context.Abouts.ToList();
            return View(value);
        }
        [HttpGet]
        public IActionResult UpdateAbout(int id)
        {
            var value = context.Abouts.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateAbout(About about)
        {
            context.Abouts.Update(about);
            context.SaveChanges();
            return RedirectToAction("AboutList");
        }
    }
}
