using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using AutoMapper;
using HtsSpot.Core.Domain.Stats;
using HtsSpot.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using NUnit.Framework;

namespace HtsSpot.Infrastructure.Tests
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
                .AddTransient<IFacilityStatsRepository, FacilityStatsRepository>();

            ServiceProvider = services.BuildServiceProvider();
        }
    }
}
