using Microsoft.AspNetCore.Mvc;
using Portfolio.DataAccessLayer.Context;
using Portfolio.DataAccessLayer.Entities;

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
        [HttpGet]
        public IActionResult CreatePortfolio()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreatePortfolio (MyPortfolio myPortfolio)
        {
            context.MyPortfolios.Add(myPortfolio);
            context.SaveChanges();
            return RedirectToAction("MyPortfolioList");
        }
        [HttpGet]
        public IActionResult UpdatePortfolio (int id)
        {
            var value= context.MyPortfolios.Find(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdatePortfolio (MyPortfolio myPortfolio)
        {
            context.MyPortfolios.Update(myPortfolio);
            context.SaveChanges();
            return RedirectToAction("MyPortfolioList");
        }
        public IActionResult OpenPortfolio(int id)
        {
            var value = context.MyPortfolios.Find(id);
            return View(value);
        }

    }
}
