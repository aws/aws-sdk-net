using Amazon.Runtime;
using System;
using Amazon;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Endpoints;

namespace CrtIntegrationTests
{
    /// <summary>
    /// Generic service client configuration
    /// </summary>
    public class TestClientConfig : ClientConfig
    {
        public override string ServiceVersion => throw new NotImplementedException();

        public override string UserAgent => throw new NotImplementedException();

        public override string RegionEndpointServiceName => "";

        public TestClientConfig()
            : base(new DummyDefaultConfigurationProvider())
        {
        }

        private class DummyDefaultConfigurationProvider : IDefaultConfigurationProvider
        {
            public IDefaultConfiguration GetDefaultConfiguration(
                RegionEndpoint clientRegion,
                DefaultConfigurationMode? requestedConfigurationMode = null)
            {
                return new DefaultConfiguration();
            }
        }

        public override Endpoint DetermineServiceOperationEndpoint(ServiceOperationEndpointParameters parameters)
        {
            // If the current service doesn't have an endpoint rule set (which is the case for configs
            // that are used for testing), we'll return a placeholder endpoint so that unit tests pass.
            return new Endpoint(this.ServiceURL ?? "https://example.com");
        }
    }
}
