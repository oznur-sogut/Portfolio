using Microsoft.AspNetCore.Mvc;
using Portfolio.DataAccessLayer.Context;

namespace Portfolio.Controllers
{
    public class MyPortfolioController : Controller
    {
        PortfolioContext context= new PortfolioContext();
        public IActionResult MyPortfolioList()
        {
           var value= context.MyPortfolios.ToList();
            return View(value);
        }
    }
}
