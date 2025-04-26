using JustBlog.Domain.Enitities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Infrastructure.Configurations
{
    // UserConfiguration.cs
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");
            builder.Property(u => u.Age).IsRequired();
            builder.Property(u => u.AboutMe).HasMaxLength(1000).IsRequired(false);
            builder.Property(u => u.RegisteredOn).IsRequired();
        }
    }
}
