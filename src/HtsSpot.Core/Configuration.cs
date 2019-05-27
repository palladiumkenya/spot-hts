using HtsSpot.Core.Application.Stats.Queries;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace HtsSpot.Core
{
    public static class Configuration
    {
        public static void AddCore(this IServiceCollection services)
        {
            services.AddMediatR(typeof(GetFacilityStats).Assembly);
        }
     }
}
