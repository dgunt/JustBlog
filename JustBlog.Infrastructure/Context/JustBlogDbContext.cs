using JustBlog.Domain.Enitities;
using JustBlog.Infrastructure.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Infrastructure.Context
{
    public class JustBlogDbContext : IdentityDbContext<User, Role, Guid>
    {
        public JustBlogDbContext(DbContextOptions<JustBlogDbContext> options) : base(options) { }

        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Áp dụng tất cả cấu hình từ thư mục Configuration
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PostConfiguration).Assembly);

            // Cấu hình quan hệ nhiều-nhiều giữa Post và Tag
            modelBuilder.Entity<Post>()
                .HasMany(p => p.Tags)
                .WithMany(t => t.Posts)
                .UsingEntity(j => j.ToTable("PostTags"));
        }
    }
}
