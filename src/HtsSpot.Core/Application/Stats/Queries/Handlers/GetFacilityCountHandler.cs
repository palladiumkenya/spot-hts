using System;
using System.Threading;
using System.Threading.Tasks;
using CSharpFunctionalExtensions;
using HtsSpot.Core.Domain.Stats;
using MediatR;
using Serilog;

namespace HtsSpot.Core.Application.Stats.Queries.Handlers
{
    public class GetFacilityCountHandler:IRequestHandler<GetFacilityCount,Result<int>>
    {
        private readonly IFacilityStatsRepository _repository;

        public GetFacilityCountHandler(IFacilityStatsRepository repository)
        {
            _repository = repository;
        }

        public async Task<Result<int>> Handle(GetFacilityCount request, CancellationToken cancellationToken)
        {
            try
            {
                var count = await _repository.GetCount();
                return Result.Ok(count);
            }
            catch (Exception e)
            {
                Log.Error(e,$"{nameof(GetFacilityStatsHandler)} error");
                return Result.Fail<int>(e.Message);
            }
        }
    }
}