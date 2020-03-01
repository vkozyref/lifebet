using lifebet.dataaccess.Context;
using lifebet.entity;

namespace lifebet.dataaccess.Repositories
{
    internal class EventRepository : Repository<Event, int>, IEventRepository
    {
        public EventRepository(LifebetContext context) : base(context)
        {
        }
    }
}