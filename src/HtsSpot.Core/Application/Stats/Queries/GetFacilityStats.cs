using System.Collections.Generic;
using CSharpFunctionalExtensions;
using HtsSpot.Core.Domain.Stats;
using MediatR;

namespace HtsSpot.Core.Application.Stats.Queries
{
    public class GetFacilityStats:IRequest<Result<IEnumerable<FacilityStats>>>
    {

    }
}
