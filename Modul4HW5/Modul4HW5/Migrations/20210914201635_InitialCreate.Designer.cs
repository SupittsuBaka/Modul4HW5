﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Modul4HW5.DataAccess;

namespace Modul4HW5.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20210914201635_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.10")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Modul4HW5.Entities.Artist", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InstagramURL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateOfBirth = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Pop1@gmail.com",
                            InstagramURL = "https://www.instagram.com/Pop1/",
                            Name = "PopArtist1",
                            Phone = "88005553535"
                        },
                        new
                        {
                            Id = 2,
                            DateOfBirth = new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Pop2@gmail.com",
                            InstagramURL = "https://www.instagram.com/Pop2/",
                            Name = "PopArtist2",
                            Phone = "0509177329"
                        },
                        new
                        {
                            Id = 3,
                            DateOfBirth = new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Rap1@gmail.com",
                            InstagramURL = "https://www.instagram.com/Rap1/",
                            Name = "RapArtist1",
                            Phone = "0937299315"
                        },
                        new
                        {
                            Id = 4,
                            DateOfBirth = new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Rap2@gmail.com",
                            InstagramURL = "https://www.instagram.com/Pop2/",
                            Name = "RapArtist2",
                            Phone = "17293711842"
                        },
                        new
                        {
                            Id = 5,
                            DateOfBirth = new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Email = "Rock1@gmail.com",
                            InstagramURL = "https://www.instagram.com/Rock1/",
                            Name = "RockAetist1",
                            Phone = "32574523451"
                        });
                });

            modelBuilder.Entity("Modul4HW5.Entities.ArtistSong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArtistId")
                        .HasColumnType("int");

                    b.Property<int>("SongId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ArtistId");

                    b.HasIndex("SongId");

                    b.ToTable("ArtistSong");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArtistId = 3,
                            SongId = 1
                        },
                        new
                        {
                            Id = 2,
                            ArtistId = 4,
                            SongId = 1
                        },
                        new
                        {
                            Id = 3,
                            ArtistId = 3,
                            SongId = 2
                        },
                        new
                        {
                            Id = 4,
                            ArtistId = 4,
                            SongId = 3
                        },
                        new
                        {
                            Id = 5,
                            ArtistId = 1,
                            SongId = 4
                        },
                        new
                        {
                            Id = 6,
                            ArtistId = 2,
                            SongId = 4
                        },
                        new
                        {
                            Id = 7,
                            ArtistId = 5,
                            SongId = 5
                        });
                });

            modelBuilder.Entity("Modul4HW5.Entities.Genre", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Genres");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Rap"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Pop"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Jazz"
                        },
                        new
                        {
                            Id = 4,
                            Title = "Rock"
                        },
                        new
                        {
                            Id = 5,
                            Title = "Folk"
                        });
                });

            modelBuilder.Entity("Modul4HW5.Entities.Song", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Duration")
                        .HasColumnType("float");

                    b.Property<int?>("GenreId")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReleasedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("GenreId");

                    b.ToTable("Songs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Duration = 2.2999999999999998,
                            GenreId = 1,
                            ReleasedDate = new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "RapSong1"
                        },
                        new
                        {
                            Id = 2,
                            Duration = 2.2999999999999998,
                            GenreId = 1,
                            ReleasedDate = new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "RapSong2"
                        },
                        new
                        {
                            Id = 3,
                            Duration = 2.2999999999999998,
                            GenreId = 1,
                            ReleasedDate = new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "RapSong3"
                        },
                        new
                        {
                            Id = 4,
                            Duration = 2.2999999999999998,
                            GenreId = 1,
                            ReleasedDate = new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "PopSong1"
                        },
                        new
                        {
                            Id = 5,
                            Duration = 2.2999999999999998,
                            GenreId = 2,
                            ReleasedDate = new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "RockSong1"
                        });
                });

            modelBuilder.Entity("Modul4HW5.Entities.ArtistSong", b =>
                {
                    b.HasOne("Modul4HW5.Entities.Artist", "Artist")
                        .WithMany("Songs")
                        .HasForeignKey("ArtistId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Modul4HW5.Entities.Song", "Song")
                        .WithMany("Artists")
                        .HasForeignKey("SongId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Artist");

                    b.Navigation("Song");
                });

            modelBuilder.Entity("Modul4HW5.Entities.Song", b =>
                {
                    b.HasOne("Modul4HW5.Entities.Genre", "Genre")
                        .WithMany("Songs")
                        .HasForeignKey("GenreId");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("Modul4HW5.Entities.Artist", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("Modul4HW5.Entities.Genre", b =>
                {
                    b.Navigation("Songs");
                });

            modelBuilder.Entity("Modul4HW5.Entities.Song", b =>
                {
                    b.Navigation("Artists");
                });
#pragma warning restore 612, 618
        }
    }
}
