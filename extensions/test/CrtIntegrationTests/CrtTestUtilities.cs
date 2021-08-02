using Amazon.Runtime;
using System;

namespace CrtIntegrationTests
{
    /// <summary>
    /// Generic service client configuration
    /// </summary>
    public class TestClientConfig : ClientConfig
    {
        public override string ServiceVersion => throw new NotImplementedException();

        public override string UserAgent => throw new NotImplementedException();

        public override string RegionEndpointServiceName => throw new NotImplementedException();
    }
}
