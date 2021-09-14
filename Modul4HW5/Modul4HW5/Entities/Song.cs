using System;
using System.Collections.Generic;

namespace Modul4HW5.Entities
{
    public class Song
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Duration { get; set; }
        public DateTime ReleasedDate { get; set; }

        public int? GenreId { get; set; }
        public virtual Genre Genre { get; set; }

        public virtual List<ArtistSong> Artists { get; set; } = new List<ArtistSong>();
    }
}
