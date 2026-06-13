using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Exam1.Entities;

namespace Exam1.FluentApies
{
    public class FoodConfiguration : IEntityTypeConfiguration<Food>
    {
        public void Configure(EntityTypeBuilder<Food> builder)
        {
            builder.HasKey(f => f.FoodId);

            builder.Property(f => f.Name)
                   .IsRequired();

            builder.Property(f => f.Price)
                   .HasColumnType("decimal(18,2)");

            builder.HasOne(f => f.Category)
                   .WithMany()
                   .HasForeignKey(f => f.CategoryId);
        }
    }
}