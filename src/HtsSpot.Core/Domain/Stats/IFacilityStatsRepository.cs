using System.Collections.Generic;
using System.Threading.Tasks;

namespace HtsSpot.Core.Domain.Stats
{
    public interface IFacilityStatsRepository
    {
        IEnumerable<FacilityStats> GetAll();
        Task<int> GetCount();
    }
}
