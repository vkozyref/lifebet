using System;
using System.Threading.Tasks;
using lifebet.dataaccess.Repositories;

namespace lifebet.dataaccess.UnitOfWork
{
    public interface IBettingUnitOfWork
    {
        IEventRepository EventRepository { get; }

        Task SaveAsync();
    }
}
