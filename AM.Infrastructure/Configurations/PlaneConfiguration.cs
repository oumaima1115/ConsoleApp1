using AM.ApplicationCore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AM.Infrastructure.Configurations
{
    public class PlaneConfiguration : IEntityTypeConfiguration<Plane>
    {
        public void Configure(EntityTypeBuilder<Plane> builder)
        {
            builder.HasKey(p => p.PlaneId); // set PlaneId as the primary key
            builder.Property(p => p.Capacity).HasColumnName("PlaneCapacity"); // set the column name to "PlaneCapacity"
        }
    }
}
