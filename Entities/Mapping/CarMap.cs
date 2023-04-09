using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Entities.Mapping
{
    public class CarMap : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();
            builder.Property(c => c.DailyPrice).IsRequired(true);
            builder.Property(c => c.ModelYear).IsRequired(true);
            builder.Property(p => p.DailyPrice).HasPrecision(10, 2);
            builder.HasOne<Brand>().WithMany().HasForeignKey(c => c.BrandId);
            builder.HasOne<Color>().WithMany().HasForeignKey(c => c.ColorId);
            builder.ToTable("Cars");
        }
      
    }
}
