using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleImageGallery.Data.Models
{
    public class GalleryImage 
    {
        public int Id { get; set; }
        public string Title { get; set; } = "NA";
        public DateTime DateCreated { get; set; }= DateTime.Now;
        public string Url { get; set; } = "NA";
        public virtual IEnumerable<ImageTag> Tags { get; set; }= Enumerable.Empty<ImageTag>();
        public virtual IEnumerable<Category> ImageCategory { get; set; }=Enumerable.Empty<Category>();  

    }
}
