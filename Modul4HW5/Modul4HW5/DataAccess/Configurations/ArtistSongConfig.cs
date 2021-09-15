using Modul4HW5.Entities;
using Modul4HW5.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modul4HW5.DataAccess.Configurations
{
    public class ArtistSongConfig : IEntityTypeConfiguration<ArtistSong>
    {
        private readonly EntityProvider _entityProvider;
        public ArtistSongConfig(EntityProvider entityProvider)
        {
            _entityProvider = entityProvider;
        }

        public void Configure(EntityTypeBuilder<ArtistSong> builder)
        {
            builder.HasKey(t => t.Id);
            builder.Property(t => t.ArtistId)
                .IsRequired();
            builder.Property(t => t.SongId)
                .IsRequired();
            builder.HasData(_entityProvider.GetArtistSong());
        }
    }
}
