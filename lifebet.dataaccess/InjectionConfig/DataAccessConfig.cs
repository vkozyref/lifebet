using System;
using lifebet.dataaccess.Context;
using lifebet.dataaccess.Repositories;
using lifebet.dataaccess.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace lifebet.dataaccess.InjectionConfig
{
    public static class DataAccessConfig
    {
        public static void AddDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<LifebetContext>(options =>
                 options.UseNpgsql(connectionString));

            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IBettingUnitOfWork, BettingUnitOfWork>();
        }
    }
}
