using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Modul4HW5.Entities;

namespace Modul4HW5.Services
{
    public class EntityProvider
    {
        private Artist[] _artists;
        private Song[] _songs;
        private Genre[] _genres;
        private ArtistSong[] _artistSong;

        public EntityProvider()
        {
            _artists = new Artist[]
            {
                new Artist()
                {
                    Id = 1,
                    Name = "PopArtist1",
                    DateOfBirth = new DateTime(1970, 1, 1),
                    Email = "Pop1@gmail.com",
                    InstagramURL = "https://www.instagram.com/Pop1/",
                    Phone = "88005553535",
                },

                new Artist()
                {
                    Id = 2,
                    Name = "PopArtist2",
                    DateOfBirth = new DateTime(1980, 1, 1),
                    Email = "Pop2@gmail.com",
                    InstagramURL = "https://www.instagram.com/Pop2/",
                    Phone = "0509177329",
                },

                new Artist()
                {
                    Id = 3,
                    Name = "RapArtist1",
                    DateOfBirth = new DateTime(1990, 1, 1),
                    Email = "Rap1@gmail.com",
                    InstagramURL = "https://www.instagram.com/Rap1/",
                    Phone = "0937299315",
                },

                new Artist()
                {
                    Id = 4,
                    Name = "RapArtist2",
                    DateOfBirth = new DateTime(1999, 1, 1),
                    Email = "Rap2@gmail.com",
                    InstagramURL = "https://www.instagram.com/Pop2/",
                    Phone = "17293711842",
                },

                new Artist()
                {
                    Id = 5,
                    Name = "RockAetist1",
                    DateOfBirth = new DateTime(2002, 1, 1),
                    Email = "Rock1@gmail.com",
                    InstagramURL = "https://www.instagram.com/Rock1/",
                    Phone = "32574523451",
                }
            };
            _genres = new Genre[]
            {
                new Genre()
                {
                    Id = 1,
                    Title = "Rap"
                },

                new Genre()
                {
                    Id = 2,
                    Title = "Pop"
                },

                new Genre()
                {
                    Id = 3,
                    Title = "Jazz"
                },

                new Genre()
                {
                    Id = 4,
                    Title = "Rock"
                },

                new Genre()
                {
                    Id = 5,
                    Title = "Folk"
                }
            };
            _artistSong = new ArtistSong[]
            {
                new ArtistSong()
                {
                    Id = 1,
                    ArtistId = 3,
                    SongId = 1
                },

                new ArtistSong()
                {
                    Id = 2,
                    ArtistId = 4,
                    SongId = 1
                },

                new ArtistSong()
                {
                    Id = 3,
                    ArtistId = 3,
                    SongId = 2
                },

                new ArtistSong()
                {
                    Id = 4,
                    ArtistId = 4,
                    SongId = 3
                },

                new ArtistSong()
                {
                    Id = 5,
                    ArtistId = 1,
                    SongId = 4
                },

                new ArtistSong()
                {
                    Id = 6,
                    ArtistId = 2,
                    SongId = 4
                },

                new ArtistSong()
                {
                    Id = 7,
                    ArtistId = 5,
                    SongId = 5
                },
            };
            _songs = new Song[]
            {
                new Song()
                {
                    Id = 1,
                    Duration = 2.30D,
                    ReleasedDate = new DateTime(2000, 1, 1),
                    GenreId = 1,
                    Title = "RapSong1"
                },

                new Song()
                {
                    Id = 2,
                    Duration = 2.30D,
                    ReleasedDate = new DateTime(2005, 1, 1),
                    GenreId = 1,
                    Title = "RapSong2"
                },

                new Song()
                {
                    Id = 3,
                    Duration = 2.30D,
                    ReleasedDate = new DateTime(2010, 1, 1),
                    GenreId = 1,
                    Title = "RapSong3"
                },

                new Song()
                {
                    Id = 4,
                    Duration = 2.30D,
                    ReleasedDate = new DateTime(2015, 1, 1),
                    GenreId = 1,
                    Title = "PopSong1"
                },

                new Song()
                {
                    Id = 5,
                    Duration = 2.30D,
                    ReleasedDate = new DateTime(2020, 1, 1),
                    GenreId = 2,
                    Title = "RockSong1"
                },
            };
        }

        public Artist[] GetArtists() => _artists;
        public Song[] GetSongs() => _songs;
        public Genre[] GetGenres() => _genres;
        public ArtistSong[] GetArtistSong() => _artistSong;
    }
}
