using Microsoft.AspNetCore.Mvc;
using Portfolio.DataAccessLayer.Context;

namespace Portfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutNavbarComponentPartial: ViewComponent
    {
        PortfolioContext context=new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.toDoListCount=context.ToDoLists.Where(x => x.ToDoListStatus==false).Count();
            ViewBag.messageCount=context.Messages.Where(x => x.IsRead==false).Count();
            var value = context.ToDoLists.Where(x => x.ToDoListStatus==false).ToList();
            ViewBag.newMessage = context.Messages.Where(x => x.IsRead == false).ToList();
            return View(value);
        }
    }
}
