using Microsoft.AspNetCore.Mvc;
using SimpleImageGallery.Data.Models;
using Zedhi.Models;

namespace Zedhi.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            var hikingImageTags = new List<ImageTag>();
            var imageCategory = new List<Category>();

            var houseImageTags = new List<ImageTag>();
            var imageCategories = new List<Category>();


            var tag1 = new ImageTag()
            {
                Description = "Travels",
                Id = 0
            };
            var tag2 = new ImageTag()
            {
                Id = 1,
                Description = "Property"
            };
            hikingImageTags.AddRange(new List<ImageTag> { tag1, tag1 });

            var cat1 = new Category()
            {
                Id = 0,
                CatDescription = "Props"
            };
            var category1 = new Category()

            {
                Id = 1,
                CatDescription = "Hotels"
            };
            imageCategory.Add(cat1);
            imageCategory.Add(category1);

            
            var imageList=new   List<GalleryImage>()
            {
                new GalleryImage()
                {
                    Title = "Short Descr",
                    Url = "https://images.pexels.com/photos/3869651/pexels-photo-3869651.jpeg",
                    DateCreated = DateTime.Now,
                    Tags = hikingImageTags,
                    ImageCategory=imageCategory,

                },
                
                new GalleryImage()
                {
                    Title = "Short Descr1",
                    Url = "https://images.pexels.com/photos/215529/pexels-photo-215529.jpeg",
                    DateCreated = DateTime.Now,
                    Tags = houseImageTags,
                    ImageCategory=imageCategories,

                },
                 new GalleryImage()
                {
                    Title = "Short Descr",
                    Url = "https://images.pexels.com/photos/106399/pexels-photo-106399.jpeg",
                    DateCreated = DateTime.Now,
                    Tags = hikingImageTags,
                    ImageCategory=imageCategory,

                },

                new GalleryImage()
                {
                    Title = "Short Descr1",
                    Url = "https://images.pexels.com/photos/116675/pexels-photo-116675.jpeg",
                    DateCreated = DateTime.Now,
                    Tags = houseImageTags,
                    ImageCategory=imageCategories,

                },
                 new GalleryImage()
                {
                    Title = "Short Descr",
                    Url = "https://images.pexels.com/photos/63294/autos-technology-vw-multi-storey-car-park-63294.jpeg",
                    DateCreated = DateTime.Now,
                    Tags = hikingImageTags,
                    ImageCategory=imageCategory,

                },

                new GalleryImage()
                {
                    Title = "Short Descr1",
                    Url = "https://images.pexels.com/photos/136872/pexels-photo-136872.jpeg",
                    DateCreated = DateTime.Now,
                    Tags = houseImageTags,
                    ImageCategory=imageCategories,

                }
            };
            var modelnew = new GalleryIndexModel()
            {
                Images=imageList,
                SearchQuery=""
            };
            return View(modelnew);
        }
    }
}
