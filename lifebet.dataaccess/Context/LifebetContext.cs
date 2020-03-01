using lifebet.entity;
using Microsoft.EntityFrameworkCore;

namespace lifebet.dataaccess.Context
{
    internal class LifebetContext : DbContext
    {
        public LifebetContext(DbContextOptions<LifebetContext> options)
            : base(options)
        {
        }

        public DbSet<Event> Events { get; set; }
    }
}
