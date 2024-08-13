using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;

using Xunit;
using Amazon.Runtime;


namespace UnitTests
{
    public class ClientConfigTests
    {
        static readonly HashSet<string> KNOWN_PROPERTIES = new HashSet<string>
        {
            "ServiceVersion",
            "SignatureMethod",
            "SignatureVersion",
            "UserAgent",
            "RegionEndpoint",
            "RegionEndpointServiceName",
            "ServiceURL",
            "UseHttp",
            "AuthenticationRegion",
            "AuthenticationServiceName",
            "MaxErrorRetry",
            "LogResponse",
            "AWSTokenProvider",
            "BufferSize",
            "ProgressUpdateInterval",
            "ResignRetries",
            "AllowAutoRedirect",
            "LogMetrics",
            "DisableLogging",
            "ProxyCredentials",
            "Timeout",
            "UseDualstackEndpoint",
            "UseFIPSEndpoint",
            "ProxyHost",
            "ProxyPort",
            "CacheHttpClient",
            "ThrottleRetries",
            "MaxConnectionsPerServer",
            "HttpClientCacheSize",
            "ReadWriteTimeout",
            "HttpClientFactory",
            "DisableHostPrefixInjection",
            "EndpointDiscoveryEnabled",
            "EndpointDiscoveryCacheLimit",
            "DefaultConfigurationMode",
            "UseAlternateUserAgentHeader",
            "IsMaxErrorRetrySet",
            "RetryMode",
            "FastFailRequests",
            "EndpointProvider",
            "Profile",
            "IgnoreConfiguredEndpointUrls",
            "ServiceId",
            "CredentialProfileStoreChain",
            "DisableRequestCompression",
            "RequestMinCompressionSizeBytes",
            "ClientAppId",
            "TelemetryProvider",
        };

        [Fact]
        [Trait("Category", "Core")]
        public void CheckForNewConfigProperties()
        {
            var unknownProperties =
                typeof(ClientConfig)
                    .GetTypeInfo()
                    .DeclaredProperties
                    .Where(p => p.GetMethod?.IsPublic == true)
                    .Where(p => !KNOWN_PROPERTIES.Contains(p.Name))
                    .ToList();

            Assert.False(
                unknownProperties.Any(),
                "New properties added to ClientConfig. ClientConfig properties that are set on the HttpClient must be added to the " +
                "HttpRequestMessageFactory.CreateConfigUniqueString.  Once evaluated add the new properties to known properties collection. " +
                $"({string.Join(",", unknownProperties)})" +
                "New properties should also be added to AWSSDK.Extensions.NETCore.Setup. In the DefaultClientConfig source file is " +
                "maintenance information for instructions on how to add new properties to AWSSDK.Extensions.NETCore.Setup.");
        }
    }
}
