using System.Linq;
using Microsoft.EntityFrameworkCore;
using Modul4HW5.DataAccess;
using Modul4HW5.Services;

namespace Modul4HW5
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var config = new ConfigService();
            var dbOptions = new DbContextOptionsBuilder<ApplicationContext>()
                .UseSqlServer(config.ConnectionString).Options;

            using var db = new ApplicationContext(dbOptions);
            var songs = db.Songs.Include(s => s.Artists).Include(s => s.Genre);
            var artistSongs = db.ArtistSong.Include(a => a.Artist).Include(a => a.Song);
            var genres = db.Genres.Include(g => g.Songs);

            var query1 = artistSongs
                .Select(t => new { Song = t.Song.Title, Artist = t.Artist.Name, Genre = t.Song.Genre.Title })
                .Where(t => t.Genre != null)
                .ToList();

            var query2 = genres
                .Select(t => new { Genre = t.Title, Count = t.Songs.Count })
                .ToList();

            var query3 = songs
                .Where(t => t.ReleasedDate < db.Artists.Max(s => s.DateOfBirth))
                .Select(a => new { Genre = a.Genre })
                .ToList();
        }
    }
}
