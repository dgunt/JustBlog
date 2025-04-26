using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JustBlog.Domain.Enitities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace JustBlog.Infrastructure.Configurations
{

    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {
            builder.ToTable("Posts");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Title).HasMaxLength(500).IsRequired();
            builder.Property(p => p.ShortDescription).HasMaxLength(1000);
            builder.Property(p => p.UrlSlug).HasMaxLength(200);
            builder.Property(p => p.Content).IsRequired();
            builder.Property(p => p.PostedOn).IsRequired();
            builder.Property(p => p.Published).IsRequired().HasDefaultValue(false);
            builder.Property(p => p.TotalRate)
               .HasPrecision(10, 2);

            // Quan hệ với Category
            builder.HasOne(p => p.Category)
                .WithMany(c => c.Posts)
                .HasForeignKey(p => p.CategoryId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
