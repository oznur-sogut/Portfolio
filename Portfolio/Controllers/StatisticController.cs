using Microsoft.AspNetCore.Mvc;
using Portfolio.DataAccessLayer.Context;

namespace Portfolio.Controllers
{
    public class StatisticController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult Index()
        {

            ViewBag.skill = context.Skillss.Count();
            ViewBag.message = context.Messages.Count();
            ViewBag.messageRead = context.Messages.Where(x => x.IsRead.Equals(true)).Count();
            ViewBag.messageNotRead = context.Messages.Where(x => x.IsRead.Equals(false)).Count();
            ViewBag.reference = context.Testimonials.Count();
            ViewBag.experience = context.Experiences.Count();
            ViewBag.project = context.MyPortfolios.Count();
            return View();
        }
    }
}
