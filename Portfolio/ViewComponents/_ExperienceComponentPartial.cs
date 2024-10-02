﻿using Microsoft.AspNetCore.Mvc;
using Portfolio.DataAccessLayer.Context;

namespace Portfolio.ViewComponents
{
    public class _ExperienceComponentPartial: ViewComponent
    {
        PortfolioContext context= new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values=context.Experiences.ToList();
            return View(values);
        }
    }
}
