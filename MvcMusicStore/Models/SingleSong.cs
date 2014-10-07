using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class SingleSong
    {
        public int SongId { get; set; }
        public String Title { get; set; }
        public DateTime ReleasedDate { get; set; }
        public int GenreId { get; set; }
        public int ArtistId { get; set; }
        public int AlbumId { get; set; }
        public String DownloadLink { get; set; }
        public Genre Genre { get; set; }
        public Artist Artist { get; set; }
        
    }
}