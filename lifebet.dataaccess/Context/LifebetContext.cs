using System;
using lifebet.entity;
using Microsoft.EntityFrameworkCore;

namespace lifebet.dataaccess.Context
{
    internal class LifebetContext : DbContext
    {
        public DbSet<Event> Events { get; set; }
    }
}
