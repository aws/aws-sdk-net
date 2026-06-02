using System;
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using Amazon.Runtime.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    [TestCategory("UnitTest")]
    [TestCategory("Runtime")]
    public class ClientConfigTests
    {
        [TestMethod]
        //| Configured "use_fips_endpoint" | Configured Region | Expected("use_fips_endpoint", Resolved Region) |
        //| --- | ---| --- |
        [DataRow(true, "us-west-2", true, "us-west-2" )]
        [DataRow(false, "us-west-2" ,false, "us-west-2" )]
        [DataRow(true, "fips-us-west-2" ,true, "us-west-2" )]
        [DataRow(false, "fips-us-west-2" ,true, "us-west-2" )]
        [DataRow(true, "rekognition-fips.us-west-2" ,true, "rekognition.us-west-2" )]
        [DataRow(false, "rekognition-fips.us-west-2" ,true, "rekognition.us-west-2" )]
        [DataRow(true, "query-fips-us-west-2" ,true, "query-us-west-2" )]
        [DataRow(false, "query-fips-us-west-2" ,true, "query-us-west-2" )]
        public void Test(bool useFIPSEndpoint, string configuredRegion, bool expectedUseFIPS, string expectedResolvedRegion)
        {
            // ARRANGE
            var config = new TestClientConfig
            {
                UseFIPSEndpoint = useFIPSEndpoint,
                RegionEndpoint = RegionEndpoint.GetBySystemName(configuredRegion)
            };

            Assert.AreEqual(config.UseFIPSEndpoint, expectedUseFIPS, "config.UseFIPSEndpoint");
            Assert.AreEqual(config.RegionEndpoint.SystemName, expectedResolvedRegion, "config.RegionEndpoint.SystemName");
        }

        [TestMethod]
        [DataRow(0, true)]
        [DataRow(10485760, true)]
        [DataRow(128, true)]
        [DataRow(-1, false)]
        [DataRow(10485761, false)]
        public void TestRequestMinCompressionValidation(long requestMinCompression, bool isValid)
        {
            if (!isValid)
            {
                Assert.ThrowsExactly<ArgumentException>( 
                    () => new TestClientConfig { RequestMinCompressionSizeBytes = requestMinCompression }
                );
            }
            else
            {
                new TestClientConfig
                {
                    RequestMinCompressionSizeBytes = requestMinCompression
                };
            }
        }

        [TestMethod]
        [DataRow("@external.com#")]
        [DataRow("us-east-1-")]
        [DataRow("-us-east-1")]
        [DataRow("+-*/")]
        [DataRow("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa")] // Over 63 characters
        public void TestThrowsForInvalidRegion(string region)
        {
            Assert.ThrowsExactly<AmazonClientException>(() => new TestClientConfig
            {
                RegionEndpoint = RegionEndpoint.GetBySystemName(region),
            });

            // The endpoint resolvers will check the AuthenticationRegion property as well,
            // so we validate it too.
            Assert.ThrowsExactly<AmazonClientException>(() => new TestClientConfig
            {
                AuthenticationRegion = region,
            });

            // Value set via environment variable should also be validated.
            var currentRegion = Environment.GetEnvironmentVariable("AWS_REGION");
            try
            {
                Environment.SetEnvironmentVariable("AWS_REGION", region);
                FallbackRegionFactory.Reset();

                var config = new TestClientConfig();
                
                // Throws as expected here.
                Assert.ThrowsExactly<AmazonClientException>(() => config.RegionEndpoint);

                // This verifies a second get (which could happen in another component) also fails.
                Assert.ThrowsExactly<AmazonClientException>(() => config.RegionEndpoint);
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_REGION", currentRegion);
                FallbackRegionFactory.Reset();
            }
        }

        [TestMethod]
        public void TestDoesNotThrowForCustomServiceUrl()
        {
            // A customer may set this config when interacting with LocalStack.
            var config = new TestClientConfig
            {
                ServiceURL = "http://localhost:4566",
                AuthenticationRegion = "eu-west-1",
            };

            Assert.IsNotNull(config.AuthenticationRegion);
            Assert.IsNotNull(config.ServiceURL);
        }

        [TestMethod]
        public void RegionEndpointPreservedWhenServiceURLResolvedFromGlobalEnvVar()
        {
            var savedRegion = Environment.GetEnvironmentVariable("AWS_REGION");
            var savedEndpoint = Environment.GetEnvironmentVariable("AWS_ENDPOINT_URL");
            try
            {
                Environment.SetEnvironmentVariable("AWS_REGION", "us-east-2");
                Environment.SetEnvironmentVariable("AWS_ENDPOINT_URL", "http://localhost:4566");
                FallbackRegionFactory.Reset();

                var config = new TestClientConfig();
                config.ServiceId = "S3";

                Assert.AreEqual("http://localhost:4566/", config.ServiceURL);
                Assert.AreEqual("us-east-2", config.RegionEndpoint.SystemName);
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_REGION", savedRegion);
                Environment.SetEnvironmentVariable("AWS_ENDPOINT_URL", savedEndpoint);
                FallbackRegionFactory.Reset();
            }
        }

        [TestMethod]
        public void RegionEndpointPreservedWhenServiceURLResolvedFromServiceSpecificEnvVar()
        {
            var savedRegion = Environment.GetEnvironmentVariable("AWS_REGION");
            var savedEndpoint = Environment.GetEnvironmentVariable("AWS_ENDPOINT_URL_S3");
            try
            {
                Environment.SetEnvironmentVariable("AWS_REGION", "eu-west-1");
                Environment.SetEnvironmentVariable("AWS_ENDPOINT_URL_S3", "http://localhost:9000");
                FallbackRegionFactory.Reset();

                var config = new TestClientConfig();
                config.ServiceId = "S3";

                Assert.AreEqual("http://localhost:9000/", config.ServiceURL);
                Assert.AreEqual("eu-west-1", config.RegionEndpoint.SystemName);
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_REGION", savedRegion);
                Environment.SetEnvironmentVariable("AWS_ENDPOINT_URL_S3", savedEndpoint);
                FallbackRegionFactory.Reset();
            }
        }

        [TestMethod]
        public void ExplicitServiceURLSetterStillClearsRegionEndpoint()
        {
            var config = new TestClientConfig
            {
                RegionEndpoint = RegionEndpoint.USWest2,
            };

            Assert.AreEqual("us-west-2", config.RegionEndpoint.SystemName);

            config.ServiceURL = "http://localhost:4566";

            Assert.IsNull(config.RegionEndpoint);
            Assert.AreEqual("http://localhost:4566/", config.ServiceURL);
        }
    }

    /// <summary>
    /// Concrete implementation to use for testing <see cref="ClientConfig"/>.
    /// </summary>
    public class TestClientConfig : ClientConfig
    {
        public TestClientConfig() :
            base(new DummyDefaultConfigurationProvider())
        {
        }

        public TestClientConfig(IDefaultConfigurationProvider provider) :
            base(provider)
        {
        }

        public override string RegionEndpointServiceName { get; } = "Testing";
        public override string ServiceVersion { get; } = "Test";
        public override string UserAgent { get; } = "Test";

        private class DummyDefaultConfigurationProvider : IDefaultConfigurationProvider
        {
            public IDefaultConfiguration GetDefaultConfiguration(
                RegionEndpoint clientRegion,
                DefaultConfigurationMode? requestedConfigurationMode = null)
            {
                return new DefaultConfiguration();
            }
        }
        
        /// <summary>
        /// Returns the endpoint that will be used for a particular request.
        /// </summary>
        /// <param name="parameters">A Container class for parameters used for endpoint resolution.</param>
        /// <returns>The resolved endpoint for the given request.</returns>
        public override Endpoint DetermineServiceOperationEndpoint(ServiceOperationEndpointParameters parameters)
        {
            // If the current service doesn't have an endpoint rule set (which is the case for configs
            // that are used for testing), we'll return a placeholder endpoint so that unit tests pass.
            return new Endpoint(this.ServiceURL ?? "https://example.com");
        }
    }
}