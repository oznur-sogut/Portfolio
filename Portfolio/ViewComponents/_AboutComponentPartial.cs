using Microsoft.AspNetCore.Mvc;
using Portfolio.DataAccessLayer.Context;

namespace Portfolio.ViewComponents
{
    public class _AboutComponentPartial:ViewComponent
    {
        PortfolioContext portfolioContext = new PortfolioContext(); 
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = portfolioContext.Abouts.Select(x => x.AboutTitle).FirstOrDefault();
            ViewBag.aboutSubDescription =portfolioContext.Abouts.Select(x =>x .AboutSubDescription).FirstOrDefault();
            ViewBag.aboutDetails =portfolioContext.Abouts.Select(x => x.AboutDetails).FirstOrDefault();
            return View();
        }
    }
}
