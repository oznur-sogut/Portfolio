using Microsoft.AspNetCore.Mvc;
using Portfolio.DataAccessLayer.Context;

namespace Portfolio.ViewComponents
{
    public class _SkillsComponentPartial: ViewComponent
    {
        PortfolioContext context=new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values=context.Skillss.ToList();
            return View(values);
        }
    }
}
