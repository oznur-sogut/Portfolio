﻿using Microsoft.AspNetCore.Mvc;
using Portfolio.DataAccessLayer.Context;

namespace Portfolio.ViewComponents
{
    public class _ContactComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.contactDescription=context.Contacts.Select(x => x.ContactDescription).FirstOrDefault();
            var value = context.Contacts.ToList();
            return View(value);
        }
    }
}
