using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShipShape.Domain.Entities;

namespace ShipShape.Domain.Mapping
{
    public class RestrictionScoreMapping : IEntityTypeConfiguration<RestrictionScore>
    {
        public void Configure(EntityTypeBuilder<RestrictionScore> builder)
        {
            builder.HasKey(x => x.Id);
            builder.HasIndex(x => x.Id);

            builder.Property(x => x.CityId)
                .HasColumnName("id_city");

            builder.Property(x => x.PetFriendly)
                .HasColumnName("petFriendly");

            builder.Property(x => x.KidFriendly)
                .HasColumnName("kidFriendly");

            builder.Property(x => x.Accessibility)
                .HasColumnName("accessibility");

            builder.ToTable("restrictionScore");
        }
    }
}