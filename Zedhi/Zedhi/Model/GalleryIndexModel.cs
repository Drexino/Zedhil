namespace Zedhi.Model
{
    public class GalleryIndexModel
    {
        public int Id { get; set; }
        public string? Title { get; set; } = "NA";
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public string? Url { get; set; } = "NA";
        public virtual IEnumerable<ImageTag>? Tags { get; set; }


    }
}
