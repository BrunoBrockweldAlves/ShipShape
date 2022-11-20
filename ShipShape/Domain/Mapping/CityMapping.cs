using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShipShape.Domain.Entities;

namespace ShipShape.Domain.Mapping
{
    public class CityMapping : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id);

            builder.Property(x => x.Id)
                .HasColumnName("id_city");

            builder.Property(x => x.Name)
                .HasColumnName("cityName");

            builder.Property(x => x.Latitude);

            builder.Property(x => x.Longitude);

            builder.ToTable("city");
        }
    }
}