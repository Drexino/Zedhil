using Microsoft.AspNetCore.Mvc;
using SimpleImageGallery.Data.Models;
using Zedhi.Interface;
using Zedhi.Models;

namespace Zedhi.Controllers
{
    public class GalleryController : Controller
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        private readonly IImage _imageService;
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public GalleryController(IImage imageService)
        {
            _imageService=imageService;
        }
        public IActionResult Index()
        {
          
            var imageList= _imageService.GetAllImages(); 
            var modelnew = new GalleryIndexModel()
            {
                Images=imageList,
                SearchQuery=""
            };
            return View(modelnew);
        }
    }
}
