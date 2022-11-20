using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShipShape.Domain.Entities;

namespace ShipShape.Domain.Mapping
{
    public class CostScoreScoreMapping : IEntityTypeConfiguration<CostScore>
    {
        public void Configure(EntityTypeBuilder<CostScore> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id);

            builder.Property(x => x.CityId)
                .HasColumnName("id_city");

            builder.Property(x => x.Stay)
                .HasColumnName("stay");

            builder.Property(x => x.Entertainment)
                .HasColumnName("entertainment");

            builder.ToTable("costScore");
        }
    }
}