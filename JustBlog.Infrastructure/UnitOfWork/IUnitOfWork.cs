using JustBlog.Domain.Enitities;
using JustBlog.Infrastructure.Repositories.Interfaces;
using JustBlog.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Infrastructure.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IPostRepository PostRepository { get; }
        ICommentRepository CommentRepository { get; }
        IUserRepository UserRepository { get; }
        IRoleRepository RoleRepository { get; }
        IGenericRepository<Category, Guid> CategoryRepository { get; }
        IGenericRepository<Tag, Guid> TagRepository { get; }
        int SaveChanges();
    }
}
