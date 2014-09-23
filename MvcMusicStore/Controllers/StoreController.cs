using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;


    public class StoreController : Controller
    {
        //
        // GET: /Store/
        public ActionResult Index()
        {
            var genre = new List<Genre> { 
            new Genre{name="ROCk"},
            new Genre{name="Bhangra"},
            new Genre{name="romantic"}            
            };

            return View(genre);
        }

        //GET:/Store/Browse
        public ActionResult Browse(string Genre)
        {
            string message = HttpUtility.HtmlEncode(Genre).ToString();
            ViewBag.genre = message;
            return View();
        }

        //GET:Store/Details
        public ActionResult Details(string Id )
        {
            var album=new Albums {Title="album"+ Id};
            return View(album);
        }



        
    }
