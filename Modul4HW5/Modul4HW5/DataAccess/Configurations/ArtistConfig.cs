using Modul4HW5.Entities;
using Modul4HW5.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modul4HW5.DataAccess.Configurations
{
    public class ArtistConfig : IEntityTypeConfiguration<Artist>
    {
        private readonly EntityProvider _entityProvider;

        public ArtistConfig(EntityProvider entityProvider)
        {
            _entityProvider = entityProvider;
        }

        public void Configure(EntityTypeBuilder<Artist> builder)
        {
            builder.ToTable("Artists")
                .HasKey(p => p.Id);
            builder.Property(t => t.DateOfBirth)
                .IsRequired();
            builder.Property(t => t.Name)
                .IsRequired();
            builder.HasData(_entityProvider.GetArtists());
        }
    }
}
