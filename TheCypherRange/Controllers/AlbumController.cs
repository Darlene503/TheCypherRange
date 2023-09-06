using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace TheCypherRange.Controllers
{
    public class AlbumController : Controller
    {
        private readonly IAlbumRepository repo;

        public AlbumController(IAlbumRepository repo)
        {
            this.repo = repo;
        }


        public IActionResult Index()
        {
            var albums = repo.GetAllAlbums();

            return View(albums);
        }
    }
}
