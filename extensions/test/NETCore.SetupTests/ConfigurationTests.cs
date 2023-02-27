using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;

using Xunit;

using Amazon;
using Amazon.S3;
using Amazon.Runtime;

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
        public void GetRoleNameAndSessionName()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("./TestFiles/GetRoleNameAndSessionNameTest.json");

            IConfiguration config = builder.Build();
            var options = config.GetAWSOptions();

            Assert.Equal(RegionEndpoint.USWest2, options.Region);
            Assert.Equal("arn:aws:iam::123456789012:role/fake_role", options.SessionRoleArn);
            Assert.Equal("TestSessionName", options.SessionName);

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
            Assert.Equal(DefaultConfigurationMode.Standard, options.DefaultConfigurationMode);

            IAmazonS3 client = options.CreateServiceClient<IAmazonS3>();
            Assert.NotNull(client);
            Assert.Equal(RegionEndpoint.USWest2, client.Config.RegionEndpoint);
            Assert.True(client.Config.UseHttp);
            Assert.Equal(6, client.Config.MaxErrorRetry);
            Assert.Equal(TimeSpan.FromMilliseconds(1000), client.Config.Timeout);
            Assert.Equal("us-east-1", client.Config.AuthenticationRegion);
            Assert.Equal(DefaultConfigurationMode.Standard, client.Config.DefaultConfigurationMode);
            Assert.Equal(RequestRetryMode.Standard, client.Config.RetryMode);

            // Verify that setting the standard mode doesn't override explicit settings of retry mode to a non-legacy mode.
            options.DefaultClientConfig.RetryMode = RequestRetryMode.Adaptive;
            client = options.CreateServiceClient<IAmazonS3>();
            Assert.Equal(DefaultConfigurationMode.Standard, client.Config.DefaultConfigurationMode);
            Assert.Equal(RequestRetryMode.Adaptive, client.Config.RetryMode);
        }

        [Fact]
        public void GetClientConfigSettingsCaseInsensitiveTest()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("./TestFiles/GetClientConfigSettingsCaseInsensitiveTest.json");

            IConfiguration config = builder.Build();
            var options = config.GetAWSOptions();

            Assert.True(options.DefaultClientConfig.UseHttp);
            Assert.Equal(6, options.DefaultClientConfig.MaxErrorRetry);
            Assert.Equal(TimeSpan.FromMilliseconds(1000), options.DefaultClientConfig.Timeout);
            Assert.Equal("us-east-1", options.DefaultClientConfig.AuthenticationRegion);
            Assert.Equal(DefaultConfigurationMode.Standard, options.DefaultConfigurationMode);
            Assert.Equal("https://localhost:9021", options.DefaultClientConfig.ServiceURL);

            IAmazonS3 client = options.CreateServiceClient<IAmazonS3>();
            Assert.NotNull(client);
            Assert.True(client.Config.UseHttp);
            Assert.Equal(6, client.Config.MaxErrorRetry);
            Assert.Equal(TimeSpan.FromMilliseconds(1000), client.Config.Timeout);
            Assert.Equal("us-east-1", client.Config.AuthenticationRegion);
            Assert.Equal(DefaultConfigurationMode.Standard, client.Config.DefaultConfigurationMode);
            Assert.Equal(RequestRetryMode.Standard, client.Config.RetryMode);
            Assert.Equal("https://localhost:9021", client.Config.ServiceURL);

            // Verify that setting the standard mode doesn't override explicit settings of retry mode to a non-legacy mode.
            options.DefaultClientConfig.RetryMode = RequestRetryMode.Adaptive;
            client = options.CreateServiceClient<IAmazonS3>();
            Assert.Equal(DefaultConfigurationMode.Standard, client.Config.DefaultConfigurationMode);
            Assert.Equal(RequestRetryMode.Adaptive, client.Config.RetryMode);
        }

        [Fact]
        public void EnableLoggingTest()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("./TestFiles/EnableLoggingTest.json");

            IConfiguration config = builder.Build();
            var options = config.GetAWSOptions();

            Assert.Equal(RegionEndpoint.USWest2, options.Region);
            Assert.Equal(LoggingOptions.Console, options.Logging.LogTo);
            Assert.Equal(ResponseLoggingOption.OnError, options.Logging.LogResponses);
            Assert.Equal(2000, options.Logging.LogResponsesSizeLimit);
            Assert.True(options.Logging.LogMetrics);

            // Create first service client to force logging settings to be applied
            IAmazonS3 client = options.CreateServiceClient<IAmazonS3>();
            Assert.NotNull(client);
            Assert.Equal(RegionEndpoint.USWest2, client.Config.RegionEndpoint);

            Assert.Equal(LoggingOptions.Console, AWSConfigs.LoggingConfig.LogTo);
            Assert.Equal(ResponseLoggingOption.OnError, AWSConfigs.LoggingConfig.LogResponses);
            Assert.Equal(2000, AWSConfigs.LoggingConfig.LogResponsesSizeLimit);
            Assert.True(AWSConfigs.LoggingConfig.LogMetrics);
        }

        [Fact]
        public void TestRegionFoundFromEnvironmentVariable()
        {
            var existingValue = Environment.GetEnvironmentVariable("AWS_REGION");
            try
            {
                FallbackRegionFactory.Reset();
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
                FallbackRegionFactory.Reset();
            }
        }
    }
}
