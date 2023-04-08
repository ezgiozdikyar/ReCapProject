using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Mapping
{
    public class RentalMap : IEntityTypeConfiguration<Rental>
    {
        public void Configure(EntityTypeBuilder<Rental> builder)
        {
            builder.HasKey(r => r.Id);
            builder.Property(r => r.Id).ValueGeneratedOnAdd();
            builder.Property(r => r.RentDate).IsRequired(true);
            builder.HasOne<Car>().WithMany().HasForeignKey(r => r.CarId);
            builder.HasOne<Customer>().WithMany().HasForeignKey(r => r.CustomerId);
        }
    }
}
