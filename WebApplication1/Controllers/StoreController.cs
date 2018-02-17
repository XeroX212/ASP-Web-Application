using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class StoreController : Controller
    {
        // GET: Store
        public ActionResult Index()
        {
            //create mock list of genre objects
            var genres = new List<Genre>();

            for (int i = 1; i < 11; i++)
            {
                genres.Add(new Genre { Name = "Genre" + i.ToString() });
            }

            //pass mock list to the view
            //ViewBag.Genres = genres;
            return View(genres);
        }

        // GET: Store Details?genre=[value]
        public ActionResult Details(string genre)
        {
            //check for an empty genre
            if (genre == null)
            {
                //return View("Error");
                return RedirectToAction("Index");
            }

            //mock list of albums
            var albums = new List<Album>();

            for (int i = 1; i < 4; i++)
            {
                albums.Add(new Album { Title = "Album" + i.ToString(), AlbumArtUrl = "/Content/Images/placeholder.gif", Price = 8.99 });
            }

            return View(albums);
        }


    }
}