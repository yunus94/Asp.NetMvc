﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Asp.NetMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult RazorSyntax()
        {
            return View();
        }
        public ActionResult HtmlHelpers()
        {
            return View();
        }
       public ActionResult CustomHtmlHelpers()
        {
            return View();
        }
        public ActionResult UrlLink()
        {
            return View();
        }
        public ActionResult HttpUtility()
        {
            return View();
        }
    }
}