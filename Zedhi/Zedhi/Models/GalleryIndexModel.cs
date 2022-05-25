using SimpleImageGallery.Data.Models;

namespace Zedhi.Models
{
    public class GalleryIndexModel
    {
        public IEnumerable<GalleryImage> Images { get; set; }=new List<GalleryImage>();
        public string SearchQuery { get; set; } = "NA";
    }
}
