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
    public class RoleRepository : GenericRepository<Role, Guid>, IRoleRepository
    {
        public RoleRepository(JustBlogDbContext context) : base(context) { }
    }
}
