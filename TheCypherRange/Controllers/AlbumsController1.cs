using Microsoft.AspNetCore.Mvc;

namespace TheCypherRange.Controllers
{
    public class AlbumsController1 : Controller
    {
        private readonly IAlbumRepository _repo;

        public AlbumsController1(IAlbumRepository repo)
        {
             _repo = repo;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
