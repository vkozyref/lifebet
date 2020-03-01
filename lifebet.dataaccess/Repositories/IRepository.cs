using System.Threading.Tasks;

namespace lifebet.dataaccess.Repositories
{
    public interface IRepository<TEntity, TId>
    {
        Task AddAsync(TEntity obj);
        Task<TEntity> GetAsync(TId id);
        void Add(TEntity obj);
        TEntity Get(TId id);
        void Update(TEntity obj);
        void Remove(TId id);
    }
}
