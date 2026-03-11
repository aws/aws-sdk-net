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
                Assert.ThrowsException<ArgumentException>( 
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

        [DataTestMethod]
        [DataRow("@external.com#")]
        [DataRow("us-east-1-")]
        [DataRow("-us-east-1")]
        [DataRow("+-*/")]
        [DataRow("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa")] // Over 63 characters
        public void TestThrowsForInvalidRegion(string region)
        {
            Assert.ThrowsException<AmazonClientException>(() => new TestClientConfig
            {
                RegionEndpoint = RegionEndpoint.GetBySystemName(region),
            });

            // The endpoint resolvers will check the AuthenticationRegion property as well,
            // so we validate it too.
            Assert.ThrowsException<AmazonClientException>(() => new TestClientConfig
            {
                AuthenticationRegion = region,
            });

            // Value set via environment variable should also be validated.
            var currentRegion = Environment.GetEnvironmentVariable("AWS_REGION");
            try
            {
                Environment.SetEnvironmentVariable("AWS_REGION", region);
                var config = new TestClientConfig();
                
                // Throws as expected here.
                Assert.ThrowsException<AmazonClientException>(() => config.RegionEndpoint);

                // This verifies a second get (which could happen in another component) also fails.
                Assert.ThrowsException<AmazonClientException>(() => config.RegionEndpoint);
            }
            finally
            {
                Environment.SetEnvironmentVariable("AWS_REGION", currentRegion);
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