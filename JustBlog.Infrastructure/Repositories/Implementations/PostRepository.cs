using JustBlog.Domain.Enitities;
using JustBlog.Infrastructure.Context;
using JustBlog.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Infrastructure.Repositories.Implementations
{
    public class PostRepository : GenericRepository<Post, Guid>, IPostRepository
    {
        public PostRepository(JustBlogDbContext context) : base(context) { }

        public IEnumerable<Post> GetLatestPosts(int count)
        {
            return _dbSet.OrderByDescending(p => p.PostedOn).Take(count).ToList();
        }
    }
}
