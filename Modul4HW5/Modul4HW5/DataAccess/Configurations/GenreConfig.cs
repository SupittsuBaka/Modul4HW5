using Modul4HW5.Entities;
using Modul4HW5.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Modul4HW5.DataAccess.Configurations
{
    public class GenreConfig : IEntityTypeConfiguration<Genre>
    {
        private readonly EntityProvider _entityProvider;

        public GenreConfig(EntityProvider entityProvider)
        {
            _entityProvider = entityProvider;
        }

        public void Configure(EntityTypeBuilder<Genre> builder)
        {
            builder.ToTable("Genres")
                .HasKey(t => t.Id);
            builder.Property(t => t.Title)
                .IsRequired();
            builder.HasData(_entityProvider.GetGenres());
        }
    }
}
