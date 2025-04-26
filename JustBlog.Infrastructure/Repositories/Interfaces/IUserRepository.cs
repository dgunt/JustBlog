using JustBlog.Domain.Enitities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Infrastructure.Repositories.Interfaces
{
    public interface IUserRepository : IGenericRepository<User, Guid> { }
}
