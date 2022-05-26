using SimpleImageGallery.Data.Models;

namespace Zedhi.Interface
{
    public interface IImage
    {
        public IEnumerable<GalleryImage> GetAllImages();
        public IEnumerable<GalleryImage> GetImagesWithTag(string tag);
        public GalleryImage GetById(int id);
    }
}
