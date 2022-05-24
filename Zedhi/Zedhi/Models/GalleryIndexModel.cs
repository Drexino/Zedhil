using SimpleImageGallery.Data.Models;

namespace Zedhi.Models
{
    public class GalleryIndexModel
    {
        public IEnumerable<GalleryImage>? Images { get; set; }
        public string SearchQuery  { get; set; }=string.Empty;  
    }
}
