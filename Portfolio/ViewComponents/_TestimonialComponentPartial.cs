using Microsoft.AspNetCore.Mvc;
using Portfolio.DataAccessLayer.Context;

namespace Portfolio.ViewComponents
{
    public class _TestimonialComponentPartial: ViewComponent
    {
        PortfolioContext context=new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var value=context.Testimonials.ToList();
            return View(value);
        }
    }
}
