using System;
using System.Threading.Tasks;
using HtsSpot.Core.Application.Stats.Queries;
using HtsSpot.Core.Domain.Stats;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace HtsSpot.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StatsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StatsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> Get()
        {
            try
            {
                var results =await _mediator.Send(new GetFacilityStats());

                if (results.IsSuccess)
                    return Ok(results.Value);

                throw new Exception(results.Error);
            }
            catch (Exception e)
            {
                var msg = $"Error loading {nameof(FacilityStats)}";
                Log.Error(e,msg);
                return StatusCode(500, $"{msg} {e.Message}");
            }
        }
        [HttpGet("Count")]
        public async Task<ActionResult> GetCount()
        {
            try
            {
                var results =await _mediator.Send(new GetFacilityCount());

                if (results.IsSuccess)
                    return Ok(results.Value);

                throw new Exception(results.Error);
            }
            catch (Exception e)
            {
                var msg = $"Error loading Count";
                Log.Error(e,msg);
                return StatusCode(500, $"{msg} {e.Message}");
            }
        }
    }
}
