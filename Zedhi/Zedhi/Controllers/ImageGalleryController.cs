using Microsoft.AspNetCore.Mvc;
using Zedhi.Models;

namespace Zedhi.Controllers
{
    public class ImageGalleryController : Controller
    {
        public IActionResult Index()
        {
            var modelnew = new GalleryIndexModel()
            {

            };
            return View();
        }
    }
}
