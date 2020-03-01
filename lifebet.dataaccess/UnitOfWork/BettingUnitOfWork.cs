using System;
using System.Threading.Tasks;
using lifebet.dataaccess.Context;
using lifebet.dataaccess.Repositories;

namespace lifebet.dataaccess.UnitOfWork
{
    internal class BettingUnitOfWork : IBettingUnitOfWork
    {
        private readonly LifebetContext _context;

        public BettingUnitOfWork(LifebetContext context)
        {
            _context = context;
        }

        public IEventRepository EventRepository => new EventRepository(_context);

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
