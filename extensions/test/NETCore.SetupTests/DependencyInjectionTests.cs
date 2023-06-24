using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Xunit;

using Amazon;
using Amazon.S3;
using Amazon.Extensions.NETCore.Setup;
using Moq;
using System;

namespace DependencyInjectionTests
{
    public class DependencyInjectionTests
    {
        [Fact]
        public void InjectS3ClientWithDefaultConfig()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("./TestFiles/GetClientConfigSettingsTest.json");

            IConfiguration config = builder.Build();

            ServiceCollection services = new ServiceCollection();
            services.AddDefaultAWSOptions(config.GetAWSOptions());
            services.AddAWSService<IAmazonS3>();

            var serviceProvider = services.BuildServiceProvider();

            var controller = ActivatorUtilities.CreateInstance<TestController>(serviceProvider);
            Assert.NotNull(controller.S3Client);
            Assert.Equal(RegionEndpoint.USWest2, controller.S3Client.Config.RegionEndpoint);
        }

        [Fact]
        public void InjectS3ClientWithoutDefaultConfig()
        {
            ServiceCollection services = new ServiceCollection();
            services.AddAWSService<IAmazonS3>(new AWSOptions {Region = RegionEndpoint.USEast1 });

            var serviceProvider = services.BuildServiceProvider();

            var controller = ActivatorUtilities.CreateInstance<TestController>(serviceProvider);
            Assert.NotNull(controller.S3Client);
            Assert.Equal(RegionEndpoint.USEast1, controller.S3Client.Config.RegionEndpoint);
        }

        [Fact]
        public void InjectS3ClientWithOverridingConfig()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("./TestFiles/GetClientConfigSettingsTest.json");

            IConfiguration config = builder.Build();

            ServiceCollection services = new ServiceCollection();
            services.AddDefaultAWSOptions(config.GetAWSOptions());
            services.AddAWSService<IAmazonS3>(new AWSOptions {Region = RegionEndpoint.EUCentral1 });

            var serviceProvider = services.BuildServiceProvider();

            var controller = ActivatorUtilities.CreateInstance<TestController>(serviceProvider);
            Assert.NotNull(controller.S3Client);
            Assert.Equal(RegionEndpoint.EUCentral1, controller.S3Client.Config.RegionEndpoint);
        }

        [Fact]
        public void TryAddServiceDontOverrideWhenAlreadySetup()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("./TestFiles/GetClientConfigSettingsTest.json");

            IConfiguration config = builder.Build();

            ServiceCollection services = new ServiceCollection();

            var mockS3 = Mock.Of<IAmazonS3>();
            services.AddSingleton(mockS3);

            services.AddDefaultAWSOptions(config.GetAWSOptions());
            services.TryAddAWSService<IAmazonS3>(new AWSOptions { Region = RegionEndpoint.EUCentral1 });

            var serviceProvider = services.BuildServiceProvider();

            var controller = ActivatorUtilities.CreateInstance<TestController>(serviceProvider);
            var s3 = controller.S3Client;
            Assert.NotNull(s3);
            Assert.True(s3.GetType() == mockS3.GetType());
        }

        [Fact]
        public void CreateAWSOptionsWithFunction()
        {
            var expectRegion = RegionEndpoint.APSouth1;
            var expectProfile = "MockProfile";

            var services = new ServiceCollection();
            services.AddSingleton(new AWSSetting
            {
                Region = expectRegion,
                Profile = expectProfile
            });

            services.AddDefaultAWSOptions(sp=> {
                var setting = sp.GetRequiredService<AWSSetting>();
                return new AWSOptions
                {
                    Region = setting.Region,
                    Profile = setting.Profile
                };
            });

            var serviceProvider = services.BuildServiceProvider();
            var awsOptions = serviceProvider.GetRequiredService<AWSOptions>();

            Assert.NotNull(awsOptions);
            Assert.Equal(expectRegion, awsOptions.Region);
            Assert.Equal(expectProfile, awsOptions.Profile);
        }

        [Fact]
        public void InjectS3ClientWithFactoryBuiltConfig()
        {
            var expectRegion = RegionEndpoint.APSouth1;
            var expectProfile = "MockProfile";

            var services = new ServiceCollection();
            services.AddSingleton(new AWSSetting
            {
                Region = expectRegion,
                Profile = expectProfile
            });

            services.AddDefaultAWSOptions(sp => {
                var setting = sp.GetRequiredService<AWSSetting>();
                return new AWSOptions
                {
                    Region = setting.Region,
                    Profile = setting.Profile
                };
            });

            services.AddAWSService<IAmazonS3>();

            var serviceProvider = services.BuildServiceProvider();

            var controller = ActivatorUtilities.CreateInstance<TestController>(serviceProvider);
            Assert.NotNull(controller.S3Client);
            Assert.Equal(expectRegion, controller.S3Client.Config.RegionEndpoint);
        }

        public class TestController
        {
            public IAmazonS3 S3Client { get; private set; }
            public TestController(IAmazonS3 s3Client)
            {
                S3Client = s3Client;
            }
        }

        internal class AWSSetting {
            public RegionEndpoint Region { get; set; }

            public string Profile { get; set; }
        }
    }
}
