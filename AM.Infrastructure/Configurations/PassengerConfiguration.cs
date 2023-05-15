using AM.ApplicationCor.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AM.Infrastructure.Configurations
{
    public class PassengerConfiguration : IEntityTypeConfiguration<Passenger>
    {
        public void Configure(EntityTypeBuilder<Passenger> builder)
        {
            builder.HasKey(p => p.PassportNumber);

            builder.OwnsOne(p => p.FullName, fn =>
            {
                fn.Property(n => n.FirstName).HasColumnName("PassFirstName").HasMaxLength(30);
                fn.Property(n => n.LastName).HasColumnName("PassLastName").IsRequired();
            });

            builder.Property(p => p.BirthDate).HasColumnType("date");
            builder.Property(p => p.TelNumber).HasColumnType("varchar(8)").IsRequired();
            builder.Property(p => p.EmailAddress).HasColumnType("varchar(50)").IsRequired();

        }
    }
}
