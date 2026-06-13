using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Exam1.Entities;

namespace Exam1.FluentApies
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.CategoryId);

            builder.Property(c => c.Name).HasMaxLength(100)
                   .IsRequired();
        }
    }
}