using Microsoft.AspNetCore.Mvc;
using Portfolio.DataAccessLayer.Context;
using Portfolio.DataAccessLayer.Entities;

namespace Portfolio.Controllers
{
    public class MessageController1 : Controller
    {
        PortfolioContext context=new PortfolioContext();
        public IActionResult Inbox()
        {
            var values=context.Messages.ToList();
            return View(values);
        }
        public IActionResult ChangeIsReadToTrue(int id)
        {
            var value = context.Messages.Find(id);
            value.IsRead = true;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }
        public IActionResult ChangeIsReadToFalse(int id)
        {
            var value = context.Messages.Find(id);
            value.IsRead = false;
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }
        [HttpGet]
        public IActionResult UpdateMessage(int id)
        {
            var value = context.Messages.Find(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateMessage(Message messages)
        {
            var value = context.Messages.Update(messages);
            context.SaveChanges();
            return RedirectToAction("Inboox");

        }
        public IActionResult DeleteMessage(int id)
        {
            var value = context.Messages.Find(id);
            context.Messages.Remove(value);
            context.SaveChanges();
            return RedirectToAction("Inbox");
        }
    }
}
