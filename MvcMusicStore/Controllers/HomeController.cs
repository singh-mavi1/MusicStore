using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Music is life";
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Music Store lets you download your favourite songs.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Please feel free to contact us ";
            return View();
        }
    }
}
