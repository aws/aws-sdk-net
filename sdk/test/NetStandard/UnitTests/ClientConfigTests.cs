﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;

using Xunit;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon;


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
            "CorrectedUtcNow",
            "ClockOffset",
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
                $"({string.Join(",", unknownProperties)})");
        }

#if NET8_0_OR_GREATER
        [Fact]
        [Trait("Category", "Core")]
        public void DisableDangerousDisablePathAndQueryCanonicalizationTest()
        {
            AWSConfigs.DisableDangerousDisablePathAndQueryCanonicalization = true;
            try
            {
                var internalRequest = new DefaultRequest(new Amazon.S3.Model.GetObjectRequest
                {
                    BucketName = "TheBucket",
                    Key = "foo/../bar.txt"
                }, "S3");

                internalRequest.Endpoint = new Uri("https://s3.us-east-1.amazonaws.com/");
                internalRequest.ResourcePath = "foo/../bar.txt";

                var uri = AmazonServiceClient.ComposeUrl(internalRequest);

                // The GetComponents will throw an exception if the Uri was created with 
                // DangerousDisablePathAndQueryCanonicalization set to true.
                Assert.Equal("bar.txt", uri.GetComponents(UriComponents.Path, UriFormat.Unescaped));
            }
            finally
            {
                AWSConfigs.DisableDangerousDisablePathAndQueryCanonicalization = false;
            }
        }
#endif
    }
}
