using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents
{
    public class _HeadComponentPartial: ViewComponent
    {
        //backendte headComponentpartial ile ilgili yapılan işlemlerin tutulduğu method
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
