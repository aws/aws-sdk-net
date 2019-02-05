using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;

using Xunit;

using Amazon;
using Amazon.Extensions.NETCore.Setup;
using Amazon.NETCore.SetupTests;
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

        [Fact]
        public void TestRegionFoundFromEnvironmentVariable()
        {
            var existingValue = Environment.GetEnvironmentVariable("AWS_REGION");
            try
            {
                Environment.SetEnvironmentVariable("AWS_REGION", RegionEndpoint.APSouth1.SystemName);

                var builder = new ConfigurationBuilder();
                IConfiguration config = builder.Build();
                var options = config.GetAWSOptions();

                IAmazonS3 client = options.CreateServiceClient<IAmazonS3>();
                Assert.Equal(RegionEndpoint.APSouth1, client.Config.RegionEndpoint);
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_REGION", existingValue);
            }
        }

        [Fact]
        public void GetLogToConfigTest()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("./TestFiles/LogToConfigTest.json");

            IConfiguration config = builder.Build();
            var options = config.GetAWSOptions();

            Assert.Equal(LoggingOptions.Console, options.LogTo);

            // The services extension propagates the initial logging option to AWSConfigs, so it is expected to be None here
            Assert.Equal(LoggingOptions.None, AWSConfigs.LoggingConfig.LogTo);
        }

        [Fact]
        public async Task LogToUpdatesOnFileChangeTest()
        {
            var testFileContents = File.ReadAllText("./TestFiles/LogToConfigTest.json");

            using (var tempFileHelper = new TempFileHelper(testFileContents))
            {
                var builder = new ConfigurationBuilder();
                builder.AddJsonFile(tempFileHelper.Path, true, true);

                IConfiguration config = builder.Build();

                var options = config.GetAWSOptions();

                using (var monitor = new AWSOptionsMonitor(config, options))
                {
                    Assert.Equal(LoggingOptions.Console, options.LogTo);
                    // The services extension propagates the initial logging option to AWSConfigs, so it is expected to be None here
                    Assert.Equal(LoggingOptions.None, AWSConfigs.LoggingConfig.LogTo);

                    var updatedFileContents =
                        testFileContents.Replace(@"""LogTo"": ""Console""", @"""LogTo"": ""Console,Log4Net""");

                    tempFileHelper.Write(updatedFileContents);

                    await Task.Delay(500).ConfigureAwait(false);

                    Assert.Equal(LoggingOptions.Console | LoggingOptions.Log4Net, options.LogTo);
                    // The monitor propagates updates to AWSConfigs, so it is expected to be set now
                    Assert.Equal(LoggingOptions.Console | LoggingOptions.Log4Net, AWSConfigs.LoggingConfig.LogTo);
                }
            }
        }
    }
}
