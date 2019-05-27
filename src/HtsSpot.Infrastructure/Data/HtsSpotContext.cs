using HtsSpot.Core.Domain.Stats;
using Microsoft.EntityFrameworkCore;

namespace HtsSpot.Infrastructure.Data
{
    public class HtsSpotContext:DbContext
    {
        public DbSet<FacilityStats> FacilityStatses { get; set; }

        public HtsSpotContext(DbContextOptions<HtsSpotContext> options) : base(options)
        {
        }
    }
}
