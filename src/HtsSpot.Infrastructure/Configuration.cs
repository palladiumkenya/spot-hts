using System.Reflection;
using HtsSpot.Core.Domain.Stats;
using HtsSpot.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace HtsSpot.Infrastructure
{
    public static class Configuration
    {
        public static void AddInfrastructure(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<HtsSpotContext>(o => o.UseSqlServer(connectionString,
                x => x.MigrationsAssembly(typeof(HtsSpotContext).GetTypeInfo().Assembly.GetName().Name)));
            services
                .AddScoped<IFacilityStatsRepository, FacilityStatsRepository>();
        }
    }
}
