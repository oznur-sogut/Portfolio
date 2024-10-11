using Microsoft.AspNetCore.Mvc;
using Portfolio.DataAccessLayer.Context;

namespace Portfolio.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.messageAd=context.Messages.Select(x => x.MessageNameSurname).FirstOrDefault();
            ViewBag.messageSubject=context.Messages.Select(x => x.MessageSubject).FirstOrDefault();
            ViewBag.messageMail=context.Messages.Select(x => x.MessageEmail).FirstOrDefault();
            ViewBag.messageDescription=context.Messages.Select(x => x.MessageDetails).FirstOrDefault();
            ViewBag.contactDescription=context.Contacts.Select(x => x.ContactDescription).FirstOrDefault();
            var value = context.Contacts.ToList();
            return View(value);
        }
    }
}
