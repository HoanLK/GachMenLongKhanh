using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace gachMenLongKhanh.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Sanpham()
        {
            ViewBag.Message = "Your catalogue page.";

            return View();
        }

        public ActionResult Loaisanpham()
        {
            ViewBag.Message = "Your product page.";

            return View();
        }

        public ActionResult Tuvan()
        {
            ViewBag.Message = "Your suicide page.";

            return View();
        }

        public ActionResult Baiviet()
        {
            ViewBag.Message = "Your topic page.";

            return View();
        }
    }
}