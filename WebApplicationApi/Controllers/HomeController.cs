using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplicationApi.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            return RedirectToAction("Create", "Register");
            //return View();
        }

        public ActionResult Accessi()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Home()
        {
            ViewBag.Message = "Your LoginOut page.";

            return View();
        }

        public ActionResult Prodotti()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Create()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}