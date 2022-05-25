using Microsoft.EntityFrameworkCore;

namespace Zedhi.Model
{
    public class ApplicationDbContext:DbContext
    {
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public ApplicationDbContext(DbContextOptions options):base(options)
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {

        }
        public DbSet<GalleryIndexModel> GalImages { get; set; }
        public DbSet<ImageTag> TagsImages { get; set; }
    }
}
