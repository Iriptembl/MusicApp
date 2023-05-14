using Microsoft.EntityFrameworkCore;

namespace MusicApp.Models
{
    public class MusicAppContext: DbContext
    {
        public virtual DbSet<Album> Albums { get; set; }
        public virtual DbSet<Artist> Artists { get; set; }
        public virtual DbSet<Song> Songs { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<Country> Countries { get; set; }

        public MusicAppContext(DbContextOptions<MusicAppContext> options)
            : base(options) 
        {
            Database.EnsureCreated();
        }
    }
}
