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

            var song = StoreDb.Songs.ToList();
          //  var genre = StoreDb.Genres.ToList();
           // var artist = StoreDb.Artists.ToList();
            return View(song);
            
        }

        //GET:/Store/Browse
        public ActionResult Browse(string Genre)
        {
            // albums selected via genre name
            var genremodel = StoreDb.Genres.Include("Albums").Single(g => g.Name == Genre);
             return View(genremodel);

        }

        //GET:Store/Details
        public ActionResult Details(int Id )
        {
            var albummodel = StoreDb.Albums.Include("Songs").Single(a => a.AlbumId == Id);
            return View(albummodel);
           }



        
    }
