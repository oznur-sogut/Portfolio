﻿using Microsoft.AspNetCore.Mvc;

namespace Portfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutScriptComponentPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
