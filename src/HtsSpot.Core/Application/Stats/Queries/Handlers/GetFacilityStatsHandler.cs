using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using CSharpFunctionalExtensions;
using HtsSpot.Core.Domain.Stats;
using MediatR;
using Serilog;

namespace HtsSpot.Core.Application.Stats.Queries.Handlers
{
    public class GetFacilityStatsHandler:IRequestHandler<GetFacilityStats,Result<IEnumerable<FacilityStats>>>
    {
        private readonly IFacilityStatsRepository _repository;

        public GetFacilityStatsHandler(IFacilityStatsRepository repository)
        {
            _repository = repository;
        }

        public Task<Result<IEnumerable<FacilityStats>>> Handle(GetFacilityStats request, CancellationToken cancellationToken)
        {
            try
            {
                var facilityStats =  _repository.GetAll().ToList();
                return Task.FromResult(Result.Ok<IEnumerable<FacilityStats>>(facilityStats));
            }
            catch (Exception e)
            {
                Log.Error(e,$"{nameof(GetFacilityStatsHandler)} error");
                return Task.FromResult(Result.Fail<IEnumerable<FacilityStats>>(e.Message));
            }
        }
    }
}
