using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Endpoints;
using Amazon.Runtime.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class ClientConfigTests
    {
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
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

        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
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