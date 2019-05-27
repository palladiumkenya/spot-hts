using System.Collections.Generic;

namespace HtsSpot.Core.Domain.Stats
{
    public interface IFacilityStatsRepository
    {
        IEnumerable<FacilityStats> GetAll();
    }
}
