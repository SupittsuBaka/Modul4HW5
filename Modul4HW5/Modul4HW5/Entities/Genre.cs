using System.Collections.Generic;

namespace Modul4HW5.Entities
{
    public class Genre
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual List<Song> Songs { get; set; } = new List<Song>();
    }
}
