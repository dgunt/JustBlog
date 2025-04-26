using JustBlog.Domain.Enitities;
using JustBlog.Infrastructure.Context;
using JustBlog.Infrastructure.Repositories.Implementations;
using JustBlog.Infrastructure.Repositories.Interfaces;
using JustBlog.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly JustBlogDbContext _context;

        public UnitOfWork(JustBlogDbContext context)
        {
            _context = context;
            PostRepository = new PostRepository(_context);
            CommentRepository = new CommentRepository(_context);
            UserRepository = new UserRepository(_context);
            RoleRepository = new RoleRepository(_context);
            CategoryRepository = new GenericRepository<Category, Guid>(_context);
            TagRepository = new GenericRepository<Tag, Guid>(_context);
        }

        public IPostRepository PostRepository { get; }
        public ICommentRepository CommentRepository { get; }
        public IUserRepository UserRepository { get; }
        public IRoleRepository RoleRepository { get; }
        public IGenericRepository<Category, Guid> CategoryRepository { get; }
        public IGenericRepository<Tag, Guid> TagRepository { get; }

        public int SaveChanges() => _context.SaveChanges();

        public void Dispose() => _context.Dispose();
    }
}
