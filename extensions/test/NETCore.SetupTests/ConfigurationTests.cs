using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;

using Xunit;

using Amazon;
using Amazon.S3;

namespace NETCore.SetupTests
{
    public class ConfigurationTests
    {
        public ConfigurationTests()
        {
        }

        [Fact]
        public void GetProfileAndRegion()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("./TestFiles/GetProfileAndRegionTest.json");

            IConfiguration config = builder.Build();
            var options = config.GetAWSOptions();

            Assert.Equal(RegionEndpoint.USWest2, options.Region);
            Assert.Equal("myProfile", options.Profile);
            Assert.Equal("myProfileLocation", options.ProfilesLocation);

            IAmazonS3 client = options.CreateServiceClient<IAmazonS3>();
            Assert.NotNull(client);
            Assert.Equal(RegionEndpoint.USWest2, client.Config.RegionEndpoint);
        }

        [Fact]
        public void LegacyNamesTest()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("./TestFiles/LegacyNamesTest.json");

            IConfiguration config = builder.Build();
            var options = config.GetAWSOptions();

            Assert.Equal(RegionEndpoint.USWest2, options.Region);
            Assert.Equal("myProfile", options.Profile);
            Assert.Equal("myProfileLocation", options.ProfilesLocation);

            IAmazonS3 client = options.CreateServiceClient<IAmazonS3>();
            Assert.NotNull(client);
            Assert.Equal(RegionEndpoint.USWest2, client.Config.RegionEndpoint);
        }

        [Fact]
        public void NonDefaultSectionTest()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("./TestFiles/NonDefaultSectionTest.json");

            IConfiguration config = builder.Build();
            var options = config.GetAWSOptions("AWSNonStandard");

            Assert.Equal(RegionEndpoint.EUCentral1, options.Region);

            IAmazonS3 client = options.CreateServiceClient<IAmazonS3>();
            Assert.NotNull(client);
            Assert.Equal(RegionEndpoint.EUCentral1, client.Config.RegionEndpoint);
        }

        [Fact]
        public void GetClientConfigSettingsTest()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("./TestFiles/GetClientConfigSettingsTest.json");

            IConfiguration config = builder.Build();
            var options = config.GetAWSOptions();

            Assert.Equal(RegionEndpoint.USWest2, options.Region);
            Assert.True(options.DefaultClientConfig.UseHttp);
            Assert.Equal(6, options.DefaultClientConfig.MaxErrorRetry);
            Assert.Equal(TimeSpan.FromMilliseconds(1000), options.DefaultClientConfig.Timeout);
            Assert.Equal("us-east-1", options.DefaultClientConfig.AuthenticationRegion);

            IAmazonS3 client = options.CreateServiceClient<IAmazonS3>();
            Assert.NotNull(client);
            Assert.Equal(RegionEndpoint.USWest2, client.Config.RegionEndpoint);
            Assert.True(client.Config.UseHttp);
            Assert.Equal(6, client.Config.MaxErrorRetry);
            Assert.Equal(TimeSpan.FromMilliseconds(1000), client.Config.Timeout);
            Assert.Equal("us-east-1", client.Config.AuthenticationRegion);
        }
    }
}
