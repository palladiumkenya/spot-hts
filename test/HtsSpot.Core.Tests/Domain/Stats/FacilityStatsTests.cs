using System;
using System.Collections.Generic;
using System.Linq;
using FizzWare.NBuilder;
using HtsSpot.Core.Domain.Stats;
using NUnit.Framework;

namespace HtsSpot.Core.Tests.Domain.Stats
{
    [TestFixture]
    public class FacilityStatsTests
    {
        private List<FacilityStats> _facilityStats;

        [SetUp]
        public void SetUp()
        {
            _facilityStats = Builder<FacilityStats>.CreateListOfSize(2)
                .Build()
                .ToList();
        }

        [Test]
        public void should_Get_TimeAgo()
        {
            var facility = _facilityStats.First();
            facility.LastUpdate=DateTime.Now.AddHours(-1);
            Assert.False(string.IsNullOrWhiteSpace(facility.TimeAgo));
            Console.WriteLine(facility.TimeAgo);
        }

        [Test]
        public void should_Get_TimeAgo_No_Date()
        {
            var facility = _facilityStats.Last();
            facility.LastUpdate = null;
            Assert.True(string.IsNullOrWhiteSpace(facility.TimeAgo));
        }
    }
}
