using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Modul4HW5.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InstagramURL = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genres",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genres", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<double>(type: "float", nullable: false),
                    ReleasedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Songs_Genres_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArtistSong",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistId = table.Column<int>(type: "int", nullable: false),
                    SongId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArtistSong", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ArtistSong_Artists_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artists",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArtistSong_Songs_SongId",
                        column: x => x.SongId,
                        principalTable: "Songs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "Id", "DateOfBirth", "Email", "InstagramURL", "Name", "Phone" },
                values: new object[,]
                {
                    { 1, new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pop1@gmail.com", "https://www.instagram.com/Pop1/", "PopArtist1", "88005553535" },
                    { 2, new DateTime(1980, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pop2@gmail.com", "https://www.instagram.com/Pop2/", "PopArtist2", "0509177329" },
                    { 3, new DateTime(1990, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rap1@gmail.com", "https://www.instagram.com/Rap1/", "RapArtist1", "0937299315" },
                    { 4, new DateTime(1999, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rap2@gmail.com", "https://www.instagram.com/Pop2/", "RapArtist2", "17293711842" },
                    { 5, new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rock1@gmail.com", "https://www.instagram.com/Rock1/", "RockAetist1", "32574523451" }
                });

            migrationBuilder.InsertData(
                table: "Genres",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Rap" },
                    { 2, "Pop" },
                    { 3, "Jazz" },
                    { 4, "Rock" },
                    { 5, "Folk" }
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "Id", "Duration", "GenreId", "ReleasedDate", "Title" },
                values: new object[,]
                {
                    { 1, 2.2999999999999998, 1, new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RapSong1" },
                    { 2, 2.2999999999999998, 1, new DateTime(2005, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RapSong2" },
                    { 3, 2.2999999999999998, 1, new DateTime(2010, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RapSong3" },
                    { 4, 2.2999999999999998, 1, new DateTime(2015, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "PopSong1" },
                    { 5, 2.2999999999999998, 2, new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "RockSong1" }
                });

            migrationBuilder.InsertData(
                table: "ArtistSong",
                columns: new[] { "Id", "ArtistId", "SongId" },
                values: new object[,]
                {
                    { 1, 3, 1 },
                    { 2, 4, 1 },
                    { 3, 3, 2 },
                    { 4, 4, 3 },
                    { 5, 1, 4 },
                    { 6, 2, 4 },
                    { 7, 5, 5 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArtistSong_ArtistId",
                table: "ArtistSong",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_ArtistSong_SongId",
                table: "ArtistSong",
                column: "SongId");

            migrationBuilder.CreateIndex(
                name: "IX_Songs_GenreId",
                table: "Songs",
                column: "GenreId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArtistSong");

            migrationBuilder.DropTable(
                name: "Artists");

            migrationBuilder.DropTable(
                name: "Songs");

            migrationBuilder.DropTable(
                name: "Genres");
        }
    }
}
