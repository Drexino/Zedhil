using Microsoft.EntityFrameworkCore;
using SimpleImageGallery.Data;
using SimpleImageGallery.Data.Models;

namespace Zedhi.Interface
{
    public class ImageService : IImage
    {
        private readonly SimpleImageGalleryDbContext _dbContext;
        public ImageService(SimpleImageGalleryDbContext dbContext)
        {
            _dbContext=dbContext;
        }
        public IEnumerable<GalleryImage> GetAllImages()
        {
            return _dbContext.GalleryImages
                .Include(img => img.Tags);
        }

        public GalleryImage GetById(int id)
        {
            #pragma warning disable CS8603 // Possible null reference return.
            return _dbContext.GalleryImages.Find(id);
            #pragma warning restore CS8603 // Possible null reference return.
        }

        public IEnumerable<GalleryImage> GetImagesWithTag(string tag)
        {
           return GetAllImages().Where(img
               =>img.Tags
               .Any(t=>t.Description==tag));
        }
    }
}
