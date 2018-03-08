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
            "ReadEntireResponse",
            "BufferSize",
            "ProgressUpdateInterval",
            "ResignRetries",
            "AllowAutoRedirect",
            "LogMetrics",
            "DisableLogging",
            "ProxyCredentials",
            "Timeout",
            "UseDualstackEndpoint",
            "ProxyHost",
            "ProxyPort",
            "CacheHttpClient",
            "ThrottleRetries",
            "MaxConnectionsPerServer",
            "HttpClientCacheSize",
            "ReadWriteTimeout",
            "CorrectedUtcNow",
            "ClockOffset"
        };

        [Fact]
        [Trait("Category", "Core")]
        public void CheckForNewConfigProperties()
        {
            List<string> unknownProperties = new List<string>();
            var properties = typeof(ClientConfig).GetTypeInfo().DeclaredProperties;
            foreach(var property in properties)
            {
                if(!KNOWN_PROPERTIES.Contains(property.Name))
                {
                    unknownProperties.Add(property.Name);
                }
            }

            Assert.True(unknownProperties.Count == 0, $"New properties added to ClientConfig. ClientConfig properties that are set on the HttpClient must be added to the HttpRequestMessageFactory.CreateConfigUniqueString. Once evaluated add the new properties to known properties collection. ({string.Join(",", unknownProperties)})");
        }
    }
}
