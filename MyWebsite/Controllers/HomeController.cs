using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyWebsite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Begin/

        public ActionResult Index()
        {
            ViewBag.Msg = "こんにちは！ ASP.NET MVC!!";
            return View();
        }

    }
}
