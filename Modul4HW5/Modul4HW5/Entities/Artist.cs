using System;
using System.Collections.Generic;

namespace Modul4HW5.Entities
{
    public class Artist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string InstagramURL { get; set; }
        public virtual List<ArtistSong> Songs { get; set; } = new List<ArtistSong>();
    }
}
