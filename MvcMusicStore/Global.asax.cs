using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Data.Entity;
using MvcMusicStore.Models;

namespace MvcMusicStore
{
    // Note: For instructions on enabling IIS6 or IIS7 classic mode, 
    // visit http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            Database.SetInitializer(new MusicStoreDbInitializer());
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            AuthConfig.RegisterAuth();
        }
    }

    public class MusicStoreDbInitializer : DropCreateDatabaseAlways<MusicStoreEntities>
    {
        protected override void Seed(MusicStoreEntities context)
        {
            context.Albums.Add(new Album
            {
                AlbumId = 1,
                GenreId = 1,
                ArtistId = 1,
                DowndloadLink = "No link",
                Title = "Talash",
                ReleasedDate=DateTime.Today.Date ,
                Price = 12,
                AlbumArtUrl = "Sorry no url now",
                Artist =new Artist { Name="Babbu maan",ArtistId=1}

            });

            context.Albums.Add(new Album
            {
                AlbumId = 2,
                GenreId = 1,
                ArtistId = 2,
                DowndloadLink = "No link",
                Title = "Drake - Nothing Was The Same",
                ReleasedDate = DateTime.Today.Date,
                Price = 12,
                AlbumArtUrl = "~/AlbumArt/2.jpg",
                Artist = new Artist { Name = "Drake", ArtistId = 2 }

            });
            context.Albums.Add(new Album
            {
                AlbumId = 3,
                GenreId = 1,
                ArtistId = 3,
                DowndloadLink = "No link",
                Title = "Blurred Lines",
                ReleasedDate = DateTime.Today.Date,
                Price = 12,
                AlbumArtUrl = "~/AlbumArt/3.jpg",
                Artist = new Artist { Name = "Robin Thicke", ArtistId = 3 }

            });

            Genre gen1 = new Genre { Name = "Disco",GenreId=1, Description = "This type of generes is good in disco environment" };
            Genre gen2 = new Genre { Name = "Jazz", GenreId=2,Description = "THis is jazz music" };
            Genre gen3 = new Genre { Name = "Rock",GenreId=3, Description = "Rock includes band music" };
            

            context.Genres.Add(gen1);
            context.Genres.Add(gen2);
            context.Genres.Add(gen3);
            
            //context.Songs.Add(new Song
            //{
            //    SongId = 1,
            //    AlbumId = 1,
            //    Title = "Tralla",
            //    DownloadLink = "No link found yet",
            //    Description = "jatt ne tralla pauna hai"
            //});

            //context.Songs.Add(new Song 
            //{
            // SongId=2 ,
            // AlbumId=1,
            // Title="Jaan",
            // DownloadLink="No link found yet",
            // Description="Jaan nikldi jandi"

            //});

            base.Seed(context);
        }

    }
}














