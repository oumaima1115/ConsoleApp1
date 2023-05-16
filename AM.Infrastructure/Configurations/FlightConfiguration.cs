using AM.ApplicationCor.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AM.Infrastructure.Configurations
{
    public class FlightConfiguration : IEntityTypeConfiguration<Flight>
    {
        public void Configure(EntityTypeBuilder<Flight> builder)
        {

            //Many to Many
            //builder.HasMany(f => f.Passengers)
            //.WithMany(p => p.Flights)
            //.UsingEntity(
            //    j => j.ToTable("Reservation")
            //   );//Table d'association

            //One To Many
            builder.HasOne(f => f.Plane)
                .WithMany(p => p.Flights)
                .HasForeignKey(f => f.PlaneId)
                .OnDelete(DeleteBehavior.ClientSetNull); //The values of foreign key properties in dependent entities are set to null when the related principal is deleted

        }
    }
}
