using System.Collections.Generic;
using HtsSpot.Core.Domain.Stats;
using Microsoft.EntityFrameworkCore;

namespace HtsSpot.Infrastructure.Data
{
    public class FacilityStatsRepository:IFacilityStatsRepository
    {
        private readonly HtsSpotContext _context;

        public FacilityStatsRepository(HtsSpotContext context)
        {
            _context = context;
        }

        public IEnumerable<FacilityStats> GetAll()
        {
          return  _context.FacilityStatses.AsNoTracking();
        }
    }
}
