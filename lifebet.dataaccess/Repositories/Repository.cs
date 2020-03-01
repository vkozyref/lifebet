using lifebet.dataaccess.Context;
using lifebet.entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace lifebet.dataaccess.Repositories
{
    internal class Repository<TEntity, TId> : IRepository<TEntity, TId>
        where TEntity : class, IEntity<TId>
    {
        protected readonly LifebetContext DbContext;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(LifebetContext context)
        {
            DbContext = context;
            DbSet = DbContext.Set<TEntity>();
        }
              
        public virtual async Task AddAsync(TEntity obj)
        {
            await DbSet.AddAsync(obj);
        }
       
        public virtual async Task<TEntity> GetAsync(TId id)
        {
            return await DbSet.FindAsync(id);
        }

        public virtual void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public virtual void Update(TEntity obj)
        {
            DbSet.Update(obj);
        }

        public virtual void Remove(TId id)
        {
            DbSet.Remove(DbSet.Find(id));
        }

        public async Task<TEntity[]> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            return await DbSet.Where(filter).ToArrayAsync();
        }
    }
}
