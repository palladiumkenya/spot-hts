using System;
using HtsSpot.Core.Application.Stats.Queries;
using HtsSpot.Core.Domain.Stats;
using HtsSpot.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace HtsSpot.Core.Tests
{
    [SetUpFixture]
    public class TestInitializer
    {
        public static IServiceProvider ServiceProvider;
        public static IConfigurationRoot Configuration;

        [OneTimeSetUp]
        public void Init()
        {
            var config =Configuration= new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var connection = config.GetConnectionString("HtsCentralConnection");

            var services = new ServiceCollection()
                .AddDbContext<HtsSpotContext>(x => x.UseSqlServer(connection))
                .AddTransient<IFacilityStatsRepository, FacilityStatsRepository>()
                .AddMediatR(typeof(GetFacilityStats).Assembly);

            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
