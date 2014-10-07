using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MvcMusicStore.Models;

namespace MvcMusicStore.ViewModel
{
    public class ViewModels
    {
        public List<Album> Albums { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Artist> Artists { get; set; }
        public List<Song> Songs { get; set; }

        
    }
}