using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Master Home Page";
            //Master Page Changes
            //ABCD Changes
            //Master New chnages
            //ABCDE Changes
            return View();
        }
    }
}
