using Microsoft.EntityFrameworkCore;
using Modul4HW5.DataAccess.Configurations;
using Modul4HW5.Entities;
using Modul4HW5.Services;

namespace Modul4HW5.DataAccess
{
    public class ApplicationContext : DbContext
    {
        private readonly EntityProvider _entityProvider;
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            _entityProvider = new EntityProvider();
        }

        public DbSet<Artist> Artists { get; set; }
        public DbSet<Song> Songs { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<ArtistSong> ArtistSong { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ArtistConfig(_entityProvider));
            modelBuilder.ApplyConfiguration(new SongConfig(_entityProvider));
            modelBuilder.ApplyConfiguration(new GenreConfig(_entityProvider));
            modelBuilder.ApplyConfiguration(new ArtistSongConfig(_entityProvider));
        }
    }
}
