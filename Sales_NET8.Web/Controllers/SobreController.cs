﻿using Microsoft.AspNetCore.Mvc;

namespace Sales_NET8.Web.Controllers
{
    public class SobreController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}