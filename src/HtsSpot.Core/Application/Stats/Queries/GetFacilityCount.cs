using CSharpFunctionalExtensions;
using MediatR;

namespace HtsSpot.Core.Application.Stats.Queries
{
    public class GetFacilityCount:IRequest<Result<int>>
    {

    }
}