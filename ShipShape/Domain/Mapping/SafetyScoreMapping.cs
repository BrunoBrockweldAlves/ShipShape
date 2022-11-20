using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShipShape.Domain.Entities;

namespace ShipShape.Domain.Mapping
{
    public class SafetyScoreMapping : IEntityTypeConfiguration<SafetyScore>
    {
        public void Configure(EntityTypeBuilder<SafetyScore> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id);

            builder.Property(x => x.CityId)
                .HasColumnName("id_city");

            builder.Property(x => x.LgbtqiaPlus)
                .HasColumnName("lgbtq");

            builder.Property(x => x.Medical)
                .HasColumnName("medical");

            builder.Property(x => x.PhysicalHarm)
                .HasColumnName("physicalHarm");

            builder.ToTable("safetyScore");
        }
    }
}