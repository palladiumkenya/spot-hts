using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
            return _context.FacilityStatses.AsNoTracking().OrderByDescending(x => x.LastUpdate);
        }

        public Task<int> GetCount()
        {
            return _context.FacilityStatses.AsNoTracking().Select(x => x.Id).CountAsync();
        }
    }
}
