using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class Song
    {
       public int SongId { get; set; }
       public int AlbumId { get; set ; }
        public String Title { get; set; }
        public DateTime ReleasedDate { get; set; }
        public String DownloadLink { get; set; }
        public string Description { get; set; }
        
        public Album Album { get; set; }
    }
}