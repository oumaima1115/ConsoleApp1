using AM.ApplicationCor.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AM.Infrastructure.Configurations
{
    public class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {

            builder.OwnsOne(p => p.FullName, full =>
            {
                full.Property(f => f.FirstName).HasColumnName("PassFirstName").HasMaxLength(30);
                full.Property(f => f.LastName).HasColumnName("PassLastName").IsRequired();
            });

            //builder.HasDiscriminator<string>("IsTraveller")
            //         .HasValue<Passenger>("0")
            //         .HasValue<Traveller>("1")
            //         .HasValue<Staff>("2");


            builder.Property(p => p.BirthDate).HasColumnType("date");
            builder.Property(p => p.TelNumber).HasColumnType("varchar(8)").IsRequired();
            builder.Property(p => p.EmailAddress).HasColumnType("varchar(50)").IsRequired();

        }
    }
}
