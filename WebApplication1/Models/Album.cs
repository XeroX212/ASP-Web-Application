using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Album
    {
        public string Title { get; set; }
        public Genre Genre { get; set; }
        public string AlbumArtUrl { get; set; }
        public double Price { get; set; }
    }
}