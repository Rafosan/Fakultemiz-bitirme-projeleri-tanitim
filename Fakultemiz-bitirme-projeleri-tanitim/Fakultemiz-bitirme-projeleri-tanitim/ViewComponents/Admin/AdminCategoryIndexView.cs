﻿using Microsoft.AspNetCore.Mvc;

namespace Fakultemiz_bitirme_projeleri_tanitim.ViewComponents.Admin
{
    public class AdminCategoryIndexView:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
