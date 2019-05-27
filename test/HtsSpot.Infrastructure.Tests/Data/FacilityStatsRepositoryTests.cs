using System;
using System.Linq;
using HtsSpot.Core.Domain.Stats;
using NUnit.Framework;
using Microsoft.Extensions.DependencyInjection;

namespace HtsSpot.Infrastructure.Tests.Data
{
    [TestFixture]
    public class FacilityStatsRepositoryTests
    {

        private IFacilityStatsRepository _repository;

        [SetUp]
        public void SetUp()
        {
            _repository = TestInitializer.ServiceProvider.GetService<IFacilityStatsRepository>();
        }
        [Test]
        public void should_GetAll()
        {
            var stats = _repository.GetAll().ToList();
            Assert.True(stats.Any());
            stats.ForEach(Console.WriteLine);
        }

        [Test]
        public void should_GetCount()
        {
            var stats = _repository.GetCount().Result;
            Assert.True(stats>0);
        }
    }
}
