using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MvcMusicStore.Models;
using MvcMusicStore.ViewModel;
namespace MvcMusicStore.Controllers
{
    public class HomeController : Controller
    {
        public MusicStoreEntities db = new MusicStoreEntities();
        public ActionResult Index()
        {
        //    Song newsongs = new Song { Title = "jaan", SongId=1,DownloadLink = "no link found", Description = "bhangra" };
        //  //  Song newsongs1 = new Song { Title = "singhan", DownloadLink = "no link found",  AlbumId = 1, Description = "bhangra" };
        //    MusicStoreEntities db = new MusicStoreEntities();
        //    db.Songs.Add(newsongs);
        ////    db.Songs.Add(newsongs1);
                
        //    db.SaveChanges();


            ViewBag.Message = "Music is life";
           
            
            
           //Add few genres to work with databse .Database is created everytime new changes made to dbcontext classes.
            
            //-----------------------------//


           //Pass all the models to view by creating a viewmodel class with all other model as properties

            ViewModels vm = new ViewModels();
            vm.Genres = db.Genres.ToList();
            //var albummodel = db.Albums.Where(a => a.Title == "Talash");
           // Album albums = db.Albums.Find(1);
            vm.Albums = db.Albums.Where(a => a.Title == "Talash").ToList();
            return View(vm);

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
