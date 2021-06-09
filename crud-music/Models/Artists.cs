using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace crud_music.Models
{
    public class Artists
    {
        public int ArtistID { get; set; }
        public string ArtistName { get; set; }
        public string AlbumName { get; set; }
        public string ImageURL { get; set; }
        public DateTime ReleaseDate { get; set; }
        public decimal Price { get; set; }
        public string SampleURL { get; set; }
    }
}
