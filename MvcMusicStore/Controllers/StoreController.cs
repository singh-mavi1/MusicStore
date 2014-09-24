using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMusicStore.Models;


    public class StoreController : Controller
    {
        MusicStoreEntities StoreDb = new MusicStoreEntities();
         
        //
        // GET: /Store/
        public ActionResult Index()
        {
           
           // var artist = StoreDb.Artists.ToList();
            var genre = StoreDb.Genres.ToList();
           // var artist = StoreDb.Artists.ToList();
            return View(genre);
            
        }

        //GET:/Store/Browse
        public ActionResult Browse(string Genre)
        {
            var genremodel = StoreDb.Genres.Single(g=>g.Name==Genre);

             return View(genremodel);
        }

        //GET:Store/Details
        public ActionResult Details(string Id )
        {
            var album=new Album {Title="album"+ Id};
            return View(album);
        }



        
    }
