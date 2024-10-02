using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _MyPortfolioComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
