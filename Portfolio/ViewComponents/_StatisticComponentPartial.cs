using Microsoft.AspNetCore.Mvc;
using Portfolio.DataAccessLayer.Context;

namespace Portfolio.ViewComponents
{
    public class _StatisticComponentPartial: ViewComponent
    {
        PortfolioContext context= new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.testimonial=context.Testimonials.Select(x => x.TestimonialID).Count();
            ViewBag.skill=context.Skillss.Select(x => x.SkillsID).Count();
            ViewBag.portfolio=context.MyPortfolios.Select(x => x.MyPortfolioID).Count();
            ViewBag.experience=context.Experiences.Select(x => x.ExperienceID).Count();
            return View();
        }
    }
}
