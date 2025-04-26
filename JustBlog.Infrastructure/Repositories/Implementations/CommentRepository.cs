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
    public class CommentRepository : GenericRepository<Comment, Guid>, ICommentRepository
    {
        public CommentRepository(JustBlogDbContext context) : base(context) { }

        public IEnumerable<Comment> GetCommentsByPostId(Guid postId)
        {
            return _dbSet.Where(c => c.PostId == postId).ToList();
        }
    }
}
