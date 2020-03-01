using System;
using lifebet.dataaccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace lifebet.dataaccess.InjectionConfig
{
    public static class DataAccessConfig
    {
        public static void AddDataAccess(this IServiceCollection services, IConfiguration configuration)
        {
               services.AddDbContext<LifebetContext>(options =>
                    options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        }
    }
}
