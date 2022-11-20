using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShipShape.Domain.Entities;

namespace ShipShape.Domain.Mapping
{
    public class EnvironmentScoreMapping : IEntityTypeConfiguration<EnvironmentScore>
    {
        public void Configure(EntityTypeBuilder<EnvironmentScore> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id);

            builder.Property(x => x.CityId)
                .HasColumnName("id_city");

            builder.Property(x => x.Beach)
                .HasColumnName("beach");

            builder.Property(x => x.Field)
                .HasColumnName("field");

            builder.Property(x => x.Mountain)
                .HasColumnName("mountain");

            builder.ToTable("environmentsScore");
        }
    }
}