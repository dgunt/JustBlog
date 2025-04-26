using JustBlog.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Infrastructure.Repositories
{
    public class GenericRepository<TEntity, TKey> : IGenericRepository<TEntity, TKey> where TEntity : class
    {
        protected readonly JustBlogDbContext _context;
        protected readonly DbSet<TEntity> _dbSet;

        public GenericRepository(JustBlogDbContext context)
        {
            _context = context;
            _dbSet = _context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll() => _dbSet.AsQueryable();

        public TEntity GetById(TKey id) => _dbSet.Find(id);

        public void Add(TEntity entity) => _dbSet.Add(entity);

        public void Update(TEntity entity) => _dbSet.Update(entity);

        public void Delete(TEntity entity) => _dbSet.Remove(entity);
    }
}
