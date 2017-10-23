using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Xunit;

using Amazon;
using Amazon.S3;
using Amazon.Extensions.NETCore.Setup;
using Amazon.Extensions.NETCore.Setup.Internal;
using Amazon.Runtime;

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
        public void HandlerTest()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("./TestFiles/GetClientConfigSettingsTest.json");
            IConfiguration config = builder.Build();

            ServiceCollection services = new ServiceCollection();
            services.AddDefaultAWSOptions(config.GetAWSOptions());
            services.AddAWSService<IAmazonS3>(new AWSOptions { Region = RegionEndpoint.EUCentral1 });
            services.AddAmazonServiceClientCreateEventHandle(new WrapperHandler());

            var serviceProvider = services.BuildServiceProvider();

            var client = serviceProvider.GetService<IAmazonS3>();
            Assert.True(client is WrapperHandler.WrapperS3Client);
        }

        public class WrapperHandler : Amazon.Extensions.NETCore.Setup.Internal.IAmazonServiceClientEventHandler
        {
            public string Name => "FakeWrapper";

            public IAmazonService Process(IAmazonService client)
            {
                return new WrapperS3Client(client as IAmazonS3);
            }

            public class WrapperS3Client : AmazonS3Client
            {
                IAmazonS3 _s3Client;

                public WrapperS3Client(IAmazonS3 client)
                    : base(client.Config.RegionEndpoint)
                {
                    this._s3Client = client;
                }
            }
        }

        public class TestController
        {
            public IAmazonS3 S3Client { get; private set; }
            public TestController(IAmazonS3 s3Client)
            {
                S3Client = s3Client;
            }
        }

    }
}
