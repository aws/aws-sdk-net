using Amazon.Runtime;
using System;
using Amazon;
using Amazon.Runtime.Internal;

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
    }
}
