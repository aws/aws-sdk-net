using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

using Xunit;

using Amazon;
using Amazon.S3;
using Amazon.Extensions.NETCore.Setup;
using Moq;
using System;
using Amazon.Runtime;
using AWSSDK.Extensions.NETCore.Setup;
using Castle.Core.Logging;

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

        [Fact]
        public void InjectS3ClientWithOverridingConfigAndCustomCredentialsProviderFunc()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("./TestFiles/GetClientConfigSettingsTest.json");

            IConfiguration config = builder.Build();

            ServiceCollection services = new ServiceCollection();
            services.AddDefaultAWSOptions(config.GetAWSOptions());
            services.AddAWSService<IAmazonS3>(
                new AWSOptions {Region = RegionEndpoint.EUCentral1 },
                credentialsFactoryFunc: (sp, options) => new DefaultAWSCredentialsFactory(options, Mock.Of<Microsoft.Extensions.Logging.ILogger<DefaultAWSCredentialsFactory>>()));

            var serviceProvider = services.BuildServiceProvider();

            var controller = ActivatorUtilities.CreateInstance<TestController>(serviceProvider);
            Assert.NotNull(controller.S3Client);
            Assert.Equal(RegionEndpoint.EUCentral1, controller.S3Client.Config.RegionEndpoint);
        }

        [Fact]
        public void GivenCustomAddCredentialsFactoryCall_WhenInjectingS3Client_ThenUseCustomCredentials()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("./TestFiles/GetClientConfigSettingsTest.json");

            IConfiguration config = builder.Build();

            var mockCredentialsFactory = new Mock<IAWSCredentialsFactory>();
            mockCredentialsFactory
                .Setup(x => x.Create())
                .Returns(new BasicAWSCredentials("test", "test"));

            ServiceCollection services = new ServiceCollection();
            services.AddDefaultAWSOptions(config.GetAWSOptions());
            services.AddCredentialsFactory(_ => mockCredentialsFactory.Object);
            services.AddAWSService<IAmazonS3>();

            var serviceProvider = services.BuildServiceProvider();

            var controller = ActivatorUtilities.CreateInstance<TestController>(serviceProvider);
            Assert.NotNull(controller.S3Client);
            Assert.Equal(RegionEndpoint.USWest2, controller.S3Client.Config.RegionEndpoint);
            mockCredentialsFactory.Verify(x => x.Create(), Times.Once);
        }

        [Fact]
        public void GivenCustomAddCredentialsFactory_WhenInjectingS3ClientWithOverridingConfigAndCustomCredentialsProviderFunc_ThenUseOverride()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("./TestFiles/GetClientConfigSettingsTest.json");

            IConfiguration config = builder.Build();

            var mockCredentialsFactory = new Mock<IAWSCredentialsFactory>();
            mockCredentialsFactory
                .Setup(x => x.Create())
                .Returns(new BasicAWSCredentials("test", "test"));

            var mockOverridenCredentialsFactory = new Mock<IAWSCredentialsFactory>();
            mockOverridenCredentialsFactory
                .Setup(x => x.Create())
                .Returns(new BasicAWSCredentials("overriden", "overriden"));

            var awsOptions = new AWSOptions {Region = RegionEndpoint.EUCentral1 };
            AWSOptions providedOptionsToCredentialsFactoryFunc = new AWSOptions();

            ServiceCollection services = new ServiceCollection();
            services.AddDefaultAWSOptions(config.GetAWSOptions());
            services.AddCredentialsFactory(sp => mockCredentialsFactory.Object);
            services.AddAWSService<IAmazonS3>(
                awsOptions,
                credentialsFactoryFunc: (sp, options) =>
                {
                    providedOptionsToCredentialsFactoryFunc = options;
                    return mockOverridenCredentialsFactory.Object;
                });

            var serviceProvider = services.BuildServiceProvider();

            var controller = ActivatorUtilities.CreateInstance<TestController>(serviceProvider);
            Assert.NotNull(controller.S3Client);
            Assert.Equal(RegionEndpoint.EUCentral1, controller.S3Client.Config.RegionEndpoint);
            Assert.Equal(providedOptionsToCredentialsFactoryFunc, awsOptions);
            mockOverridenCredentialsFactory.Verify(x => x.Create(), Times.Once);
            mockCredentialsFactory.Verify(x => x.Create(), Times.Never);
        }

        [Fact]
        public void GivenCustomAddCredentialsFactory_WhenInjectingS3ClientWithOverridingConfigAndNoCustomCredentialsProviderFunc_ThrowException()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("./TestFiles/GetClientConfigSettingsTest.json");

            IConfiguration config = builder.Build();

            var mockCredentialsFactory = new Mock<IAWSCredentialsFactory>();
            mockCredentialsFactory
                .Setup(x => x.Create())
                .Returns(new BasicAWSCredentials("test", "test"));

            ServiceCollection services = new ServiceCollection();
            services.AddDefaultAWSOptions(config.GetAWSOptions());
            services.AddCredentialsFactory(sp => mockCredentialsFactory.Object);
            services.AddAWSService<IAmazonS3>(new AWSOptions {Region = RegionEndpoint.EUCentral1 });

            var serviceProvider = services.BuildServiceProvider();

            Func<TestController> controllerAction = () => ActivatorUtilities.CreateInstance<TestController>(serviceProvider);
            Assert.Throws<ArgumentNullException>(controllerAction);
            mockCredentialsFactory.Verify(x => x.Create(), Times.Never);
        }

        [Fact]
        public void GivenDefaultAddCredentialsFactory_WhenInjectingS3ClientWithSameConfigAsRegisteredAndNoCustomCredentialsProviderFunc_ThenWork()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("./TestFiles/GetClientConfigSettingsTest.json");

            IConfiguration config = builder.Build();

            var awsOptions = new AWSOptions {Region = RegionEndpoint.EUCentral1 };
            var mockCredentialsFactory = new Mock<IAWSCredentialsFactory>();
            mockCredentialsFactory
                .Setup(x => x.Create())
                .Returns(new BasicAWSCredentials("test", "test"));

            ServiceCollection services = new ServiceCollection();
            services.AddDefaultAWSOptions(awsOptions);
            services.AddCredentialsFactory(_ => mockCredentialsFactory.Object);
            services.AddAWSService<IAmazonS3>(awsOptions);

            var serviceProvider = services.BuildServiceProvider();

            var controller = ActivatorUtilities.CreateInstance<TestController>(serviceProvider);
            Assert.NotNull(controller.S3Client);
            Assert.Equal(RegionEndpoint.EUCentral1, controller.S3Client.Config.RegionEndpoint);
            mockCredentialsFactory.Verify(x => x.Create(), Times.Once);
        }

        [Fact]
        public void GivenDefaultAddCredentialsFactoryCall_WhenInjectingS3ClientWithOverridingConfigAndNoCustomCredentialsProviderFunc_ThenWork()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("./TestFiles/GetClientConfigSettingsTest.json");

            IConfiguration config = builder.Build();

            ServiceCollection services = new ServiceCollection();
            services.AddDefaultAWSOptions(config.GetAWSOptions());
            services.AddCredentialsFactory();
            services.AddAWSService<IAmazonS3>(new AWSOptions {Region = RegionEndpoint.EUCentral1 });

            var serviceProvider = services.BuildServiceProvider();

            var controller = ActivatorUtilities.CreateInstance<TestController>(serviceProvider);
            Assert.NotNull(controller.S3Client);
            Assert.Equal(RegionEndpoint.EUCentral1, controller.S3Client.Config.RegionEndpoint);
        }

        [Fact]
        public void GivenDefaultAddCredentialsFactoryCall_WhenInjectingS3Client_ThenWork()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("./TestFiles/GetClientConfigSettingsTest.json");

            IConfiguration config = builder.Build();

            ServiceCollection services = new ServiceCollection();
            services.AddDefaultAWSOptions(config.GetAWSOptions());
            services.AddCredentialsFactory();
            services.AddAWSService<IAmazonS3>();

            var serviceProvider = services.BuildServiceProvider();

            var controller = ActivatorUtilities.CreateInstance<TestController>(serviceProvider);
            Assert.NotNull(controller.S3Client);
            Assert.Equal(RegionEndpoint.USWest2, controller.S3Client.Config.RegionEndpoint);
        }

        [Fact]
        public void GivenNoAddCredentialsFactoryCall_WhenInjectingS3ClientWithOverridingConfigAndNoCustomCredentialsProviderFunc_ThenUseDefault()
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
        public void GivenNoAddCredentialsFactoryCall_WhenInjectingS3ClientWithNoOverridingConfigAndNoCustomCredentialsProviderFunc_ThenUseDefault()
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
        public void GivenNoAddCredentialsFactoryCall_WhenInjectingS3ClientWithNoOverridingConfigButCustomCredentialsProviderFunc_ThenUseCustom()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("./TestFiles/GetClientConfigSettingsTest.json");

            IConfiguration config = builder.Build();

            var mockOverridenCredentialsFactory = new Mock<IAWSCredentialsFactory>();
            mockOverridenCredentialsFactory
                .Setup(x => x.Create())
                .Returns(new BasicAWSCredentials("overriden", "overriden"));

            ServiceCollection services = new ServiceCollection();
            services.AddDefaultAWSOptions(config.GetAWSOptions());
            services.AddAWSService<IAmazonS3>((AWSOptions)null, credentialsFactoryFunc: (sp, options) => mockOverridenCredentialsFactory.Object);

            var serviceProvider = services.BuildServiceProvider();

            var controller = ActivatorUtilities.CreateInstance<TestController>(serviceProvider);
            Assert.NotNull(controller.S3Client);
            Assert.Equal(RegionEndpoint.USWest2, controller.S3Client.Config.RegionEndpoint);
            mockOverridenCredentialsFactory.Verify(x => x.Create(), Times.Once);
        }

        [Fact]
        public void GivenCustomAddCredentialsFactoryCall_WhenInjectingS3ClientWithNoOverridingConfigButCustomCredentialsProviderFunc_ThenUseCustom()
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("./TestFiles/GetClientConfigSettingsTest.json");

            IConfiguration config = builder.Build();

            var mockCredentialsFactory = new Mock<IAWSCredentialsFactory>();
            mockCredentialsFactory
                .Setup(x => x.Create())
                .Returns(new BasicAWSCredentials("test", "test"));

            var mockOverridenCredentialsFactory = new Mock<IAWSCredentialsFactory>();
            mockOverridenCredentialsFactory
                .Setup(x => x.Create())
                .Returns(new BasicAWSCredentials("overriden", "overriden"));

            ServiceCollection services = new ServiceCollection();
            services.AddDefaultAWSOptions(config.GetAWSOptions());
            services.AddCredentialsFactory(_ => mockCredentialsFactory.Object);
            services.AddAWSService<IAmazonS3>((AWSOptions)null, credentialsFactoryFunc: (sp, options) => mockOverridenCredentialsFactory.Object);

            var serviceProvider = services.BuildServiceProvider();

            var controller = ActivatorUtilities.CreateInstance<TestController>(serviceProvider);
            Assert.NotNull(controller.S3Client);
            Assert.Equal(RegionEndpoint.USWest2, controller.S3Client.Config.RegionEndpoint);
            mockOverridenCredentialsFactory.Verify(x => x.Create(), Times.Once);
            mockCredentialsFactory.Verify(x => x.Create(), Times.Never);
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
