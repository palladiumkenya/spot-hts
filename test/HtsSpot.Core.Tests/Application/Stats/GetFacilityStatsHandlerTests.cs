using System;
using System.Linq;
using HtsSpot.Core.Application.Stats.Queries;
using HtsSpot.Core.Domain.Stats;
using MediatR;
using NUnit.Framework;
using Microsoft.Extensions.DependencyInjection;

namespace HtsSpot.Core.Tests.Application.Stats
{
    [TestFixture]
    public class GetFacilityStatsHandlerTests
    {
        private IMediator _mediator;

        [SetUp]
        public void SetUp()
        {
            _mediator = TestInitializer.ServiceProvider.GetService<IMediator>();
        }
        [Test]
        public void should_GetFacilityStats()
        {
            var result = _mediator.Send(new GetFacilityStats()).Result;
            Assert.True(result.IsSuccess);
            var stats = result.Value.ToList();
            Assert.True(stats.Any());
            stats.ForEach(Console.WriteLine);
          }
    }
}
