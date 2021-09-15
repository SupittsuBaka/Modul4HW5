using Modul4HW5.Entities;
using Modul4HW5.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modul4HW5.DataAccess.Configurations
{
    public class SongConfig : IEntityTypeConfiguration<Song>
    {
        private readonly EntityProvider _entityProvider;

        public SongConfig(EntityProvider entityProvider)
        {
            _entityProvider = entityProvider;
        }

        public void Configure(EntityTypeBuilder<Song> builder)
        {
            builder.ToTable("Songs")
                .HasKey(p => p.Id);
            builder.Property(t => t.Duration)
                .IsRequired();
            builder.Property(t => t.Title)
                .IsRequired();
            builder.Property(t => t.ReleasedDate)
                .IsRequired();
            builder.HasData(_entityProvider.GetSongs());
        }
    }
}
