/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Credentials;
using Amazon.Runtime.Endpoints;
using Amazon.Runtime.Identity;
using Amazon.Runtime.Telemetry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.Runtime
{
    [TestClass]
    public class AuthSchemeResolverTests
    {
        private DefaultAuthSchemeResolver _resolver;
        private TestClientConfig _clientConfig;

        [TestInitialize]
        public void TestInitialize()
        {
            _resolver = new DefaultAuthSchemeResolver();
            _clientConfig = new TestClientConfig();
            
            // Clear environment variables and global config before each test
            Environment.SetEnvironmentVariable("AWS_AUTH_SCHEME_PREFERENCE", null);
            AWSConfigs.AuthSchemePreference = null;
        }

        [TestCleanup]
        public void TestCleanup()
        {
            // Clean up environment variables and global config after each test
            Environment.SetEnvironmentVariable("AWS_AUTH_SCHEME_PREFERENCE", null);
            AWSConfigs.AuthSchemePreference = null;
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithNoPreference_ReturnsOriginalOrder()
        {
            // Arrange
            var supportedSchemes = new List<AuthScheme> { AuthScheme.SigV4, AuthScheme.SigV4a };

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthScheme.SigV4, result[0]);
            Assert.AreEqual(AuthScheme.SigV4a, result[1]);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithSigV4aPreference_PrioritizesSigV4a()
        {
            // Arrange
            var supportedSchemes = new List<AuthScheme> { AuthScheme.SigV4, AuthScheme.SigV4a };
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "sigv4a", "sigv4" });

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthScheme.SigV4a, result[0]);
            Assert.AreEqual(AuthScheme.SigV4, result[1]);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithHttpBearerPreference_PrioritizesHttpBearer()
        {
            // Arrange
            var supportedSchemes = new List<AuthScheme> { AuthScheme.SigV4, AuthScheme.HttpBearerAuth };
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "httpBearerAuth", "sigv4" });

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthScheme.HttpBearerAuth, result[0]);
            Assert.AreEqual(AuthScheme.SigV4, result[1]);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithUnsupportedPreference_IgnoresUnsupportedScheme()
        {
            // Arrange
            var supportedSchemes = new List<AuthScheme> { AuthScheme.SigV4 }; // Only SigV4 supported
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "sigv4a", "sigv4" }); // Prefers SigV4a first

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(AuthScheme.SigV4, result[0]); // SigV4a ignored, SigV4 used
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithPartiallyUnsupportedPreference_UsesOnlySupportedSchemes()
        {
            // Arrange
            var supportedSchemes = new List<AuthScheme> { AuthScheme.SigV4, AuthScheme.NoAuth };
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "httpBearerAuth", "sigv4a", "sigv4", "noAuth" });

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthScheme.SigV4, result[0]); // First supported scheme from preference
            Assert.AreEqual(AuthScheme.NoAuth, result[1]); // Second supported scheme from preference
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithEmptyPreference_ReturnsOriginalOrder()
        {
            // Arrange
            var supportedSchemes = new List<AuthScheme> { AuthScheme.SigV4, AuthScheme.SigV4a };
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new string[0]);

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthScheme.SigV4, result[0]);
            Assert.AreEqual(AuthScheme.SigV4a, result[1]);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithNullSupportedSchemes_ReturnsEmptyList()
        {
            // Arrange
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "sigv4" });

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, null);

            // Assert
            Assert.AreEqual(0, result.Count);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithEmptySupportedSchemes_ReturnsEmptyList()
        {
            // Arrange
            var supportedSchemes = new List<AuthScheme>();
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "sigv4" });

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert
            Assert.AreEqual(0, result.Count);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithIncorrectCasePreference_FallsBackToOriginalOrder()
        {
            // Arrange - Per Multi-auth spec: auth scheme names are case-sensitive
            var supportedSchemes = new List<AuthScheme> { AuthScheme.SigV4, AuthScheme.SigV4a };
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "SIGV4A", "SIGV4" }); // Incorrect case

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert - Should return original order since preference names don't match (case-sensitive)
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthScheme.SigV4, result[0]); // Original order maintained
            Assert.AreEqual(AuthScheme.SigV4a, result[1]);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithSchemeIdInPreference_MatchesCorrectly()
        {
            // Arrange
            var supportedSchemes = new List<AuthScheme> { AuthScheme.SigV4, AuthScheme.SigV4a };
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "aws.auth#sigv4a", "sigv4" }); // Using scheme ID

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthScheme.SigV4a, result[0]);
            Assert.AreEqual(AuthScheme.SigV4, result[1]);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithEnvironmentVariablePreference_UsesEnvironmentPreference()
        {
            // Arrange
            var supportedSchemes = new List<AuthScheme> { AuthScheme.SigV4, AuthScheme.SigV4a };
            Environment.SetEnvironmentVariable("AWS_AUTH_SCHEME_PREFERENCE", "sigv4a,sigv4");

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthScheme.SigV4a, result[0]);
            Assert.AreEqual(AuthScheme.SigV4, result[1]);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithGlobalConfigPreference_UsesGlobalPreference()
        {
            // Arrange
            var supportedSchemes = new List<AuthScheme> { AuthScheme.SigV4, AuthScheme.SigV4a };
            AWSConfigs.AuthSchemePreference = new AuthSchemePreference(new[] { "sigv4a", "sigv4" });

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthScheme.SigV4a, result[0]);
            Assert.AreEqual(AuthScheme.SigV4, result[1]);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithClientConfigPrecedence_PrioritizesClientConfig()
        {
            // Arrange
            var supportedSchemes = new List<AuthScheme> { AuthScheme.SigV4, AuthScheme.SigV4a, AuthScheme.HttpBearerAuth };
            
            // Set multiple configuration sources
            Environment.SetEnvironmentVariable("AWS_AUTH_SCHEME_PREFERENCE", "sigv4,sigv4a");
            AWSConfigs.AuthSchemePreference = new AuthSchemePreference(new[] { "httpBearerAuth", "sigv4" });
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "sigv4a", "httpBearerAuth" });

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert - Should use client config preference
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(AuthScheme.SigV4a, result[0]);
            Assert.AreEqual(AuthScheme.HttpBearerAuth, result[1]);
            Assert.AreEqual(AuthScheme.SigV4, result[2]); // Remaining supported scheme
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithAllSchemesInPreference_MaintainsPreferenceOrder()
        {
            // Arrange
            var supportedSchemes = new List<AuthScheme> { AuthScheme.SigV4, AuthScheme.SigV4a, AuthScheme.HttpBearerAuth, AuthScheme.NoAuth };
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "noAuth", "httpBearerAuth", "sigv4a", "sigv4" });

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert
            Assert.AreEqual(4, result.Count);
            Assert.AreEqual(AuthScheme.NoAuth, result[0]);
            Assert.AreEqual(AuthScheme.HttpBearerAuth, result[1]);
            Assert.AreEqual(AuthScheme.SigV4a, result[2]);
            Assert.AreEqual(AuthScheme.SigV4, result[3]);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithNullClientConfig_HandlesGracefully()
        {
            // Arrange
            var supportedSchemes = new List<AuthScheme> { AuthScheme.SigV4, AuthScheme.SigV4a };
            Environment.SetEnvironmentVariable("AWS_AUTH_SCHEME_PREFERENCE", "sigv4a,sigv4");

            // Act
            var result = _resolver.ResolveAuthSchemes(null, supportedSchemes);

            // Assert - Should still use environment variable
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthScheme.SigV4a, result[0]);
            Assert.AreEqual(AuthScheme.SigV4, result[1]);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithInvalidSchemeNames_IgnoresInvalidSchemes()
        {
            // Arrange
            var supportedSchemes = new List<AuthScheme> { AuthScheme.SigV4, AuthScheme.SigV4a };
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "invalidScheme", "sigv4a", "anotherInvalidScheme", "sigv4" });

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthScheme.SigV4a, result[0]); // First valid scheme from preference
            Assert.AreEqual(AuthScheme.SigV4, result[1]); // Second valid scheme from preference
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithCaseSensitiveNames_MatchesExactCase()
        {
            // Arrange - Per Multi-auth spec section 3.5.2: auth scheme names are case-sensitive
            var supportedSchemes = new List<AuthScheme> { AuthScheme.SigV4, AuthScheme.SigV4a };
            
            // Use exact case matching
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "sigv4a", "sigv4" });

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert - Should match with correct case
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthScheme.SigV4a, result[0]);
            Assert.AreEqual(AuthScheme.SigV4, result[1]);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithIncorrectCase_DoesNotMatch()
        {
            // Arrange - Per Multi-auth spec: auth scheme names are case-sensitive
            var supportedSchemes = new List<AuthScheme> { AuthScheme.SigV4, AuthScheme.SigV4a };
            
            // Use incorrect case - should NOT match
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "SigV4a", "SIGV4" });

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert - Should return original order since preference names don't match (case-sensitive)
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthScheme.SigV4, result[0]); // Original order maintained
            Assert.AreEqual(AuthScheme.SigV4a, result[1]);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithMixedCasePreference_OnlyMatchesCorrectCase()
        {
            // Arrange - Mix of correct and incorrect case
            var supportedSchemes = new List<AuthScheme> { AuthScheme.SigV4, AuthScheme.SigV4a, AuthScheme.HttpBearerAuth };
            
            // "sigv4a" is correct, "HttpBearerAuth" is incorrect (should be "httpBearerAuth")
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "sigv4a", "HttpBearerAuth", "sigv4" });

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert - Only correctly-cased schemes should be prioritized
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(AuthScheme.SigV4a, result[0]); // Matched (correct case)
            Assert.AreEqual(AuthScheme.SigV4, result[1]); // Matched (correct case)
            Assert.AreEqual(AuthScheme.HttpBearerAuth, result[2]); // Not matched, added at end
        }

        /// <summary>
        /// Test implementation of IClientConfig for testing purposes.
        /// </summary>
        private class TestClientConfig : IClientConfig
        {
            public AuthSchemePreference AuthSchemePreference { get; set; }
            public SigV4aRegionSetConfiguration SigV4aRegionSetConfiguration { get; set; }
            public bool IsSignatureMethodExplicitlySet => false;

            // Minimal implementation of required properties for testing
            public bool IgnoreConfiguredEndpointUrls => false;
            public string ServiceId => "TestService";
            public Profile Profile => null;
            public AWSCredentials DefaultAWSCredentials => null;
            public IIdentityResolverConfiguration IdentityResolverConfiguration => null;
            public IAWSTokenProvider AWSTokenProvider => null;
            public DefaultConfigurationMode DefaultConfigurationMode => DefaultConfigurationMode.Standard;
            public RegionEndpoint RegionEndpoint => RegionEndpoint.USEast1;
            public string RegionEndpointServiceName => "test";
            public string ServiceURL => null;
            public IEndpointProvider EndpointProvider => null;
            public bool UseHttp => false;
            public string ServiceVersion => "1.0";
            public SigningAlgorithm SignatureMethod => SigningAlgorithm.HmacSHA256;
            public string AuthenticationRegion => "us-east-1";
            public string AuthenticationServiceName => "test";
            public string UserAgent => "TestAgent";
            public bool DisableLogging => false;
            public bool LogMetrics => false;
            public bool LogResponse => false;
            public bool AllowAutoRedirect => true;
            public int BufferSize => 8192;
            public int MaxErrorRetry => 3;
            public bool IsMaxErrorRetrySet => false;
            public long ProgressUpdateInterval => 102400;
            public bool ResignRetries => true;
            public ICredentials ProxyCredentials => null;
            public TimeSpan? Timeout => null;
#if NET8_0_OR_GREATER
            public TimeSpan? ConnectTimeout => null;
#endif
            public bool UseDualstackEndpoint => false;
            public bool UseFIPSEndpoint => false;
            public bool DisableRequestCompression => false;
            public long RequestMinCompressionSizeBytes => 10240;
            public string ClientAppId => null;
            public bool ThrottleRetries => false;
            public bool DisableHostPrefixInjection => false;
            public bool EndpointDiscoveryEnabled => false;
            public int EndpointDiscoveryCacheLimit => 1000;
            public RequestRetryMode RetryMode => RequestRetryMode.Standard;
            public bool FastFailRequests => false;
            public bool UseAlternateUserAgentHeader => false;
            public TelemetryProvider TelemetryProvider => null;
            public RequestChecksumCalculation RequestChecksumCalculation => RequestChecksumCalculation.WHEN_SUPPORTED;
            public ResponseChecksumValidation ResponseChecksumValidation => ResponseChecksumValidation.WHEN_SUPPORTED;
            public AccountIdEndpointMode AccountIdEndpointMode => AccountIdEndpointMode.PREFERRED;
#if BCL
            public TcpKeepAlive TcpKeepAlive => null;
#endif
#if NETSTANDARD
            public int? MaxConnectionsPerServer => null;
            public bool CacheHttpClient => true;
            public int HttpClientCacheSize => 5;
#endif

            // Additional properties that may be required by the interface
            public string ProxyHost => null;
            public int ProxyPort => -1;
            public int MaxIdleTime => -1;
            public TimeSpan? ReadWriteTimeout => null;
            public int ConnectionLimit => -1;
            public bool UseNagleAlgorithm => false;

            public Endpoint DetermineServiceOperationEndpoint(ServiceOperationEndpointParameters parameters) => null;
            public void Validate() { }
            public WebProxy GetWebProxy() => null;
            public WebProxy GetHttpsProxy() => null;
            public WebProxy GetHttpProxy() => null;
        }
    }
}