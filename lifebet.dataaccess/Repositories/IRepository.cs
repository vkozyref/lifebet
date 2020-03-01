using System;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace lifebet.dataaccess.Repositories
{
    public interface IRepository<TEntity, TId>
    {
        Task AddAsync(TEntity obj);
        Task<TEntity> GetAsync(TId id);
        void Add(TEntity obj);
        Task<TEntity[]> GetAsync(Expression<Func<TEntity, bool>> filter);
        void Update(TEntity obj);
        void Remove(TId id);
    }
}
