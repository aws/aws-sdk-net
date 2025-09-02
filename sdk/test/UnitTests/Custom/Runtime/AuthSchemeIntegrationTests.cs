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
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Endpoints;
using Amazon.Runtime.Identity;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Telemetry;
using Microsoft.VisualStudio.TestTools.UnitTesting;

#if BCL
using WebProxy = System.Net.WebProxy;
#endif

namespace AWSSDK.UnitTests.Runtime
{
    [TestClass]
    public class AuthSchemeIntegrationTests
    {
        private TestAuthResolverHandler _handler;
        private TestClientConfig _clientConfig;

        [TestInitialize]
        public void TestInitialize()
        {
            _handler = new TestAuthResolverHandler();
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
        public void AuthSchemeIntegration_WithNoPreference_UsesServiceDefinedOrder()
        {
            // Arrange
            var supportedOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A }
            };

            // Act
            var result = _handler.TestApplyAuthSchemePreferences(_clientConfig, supportedOptions);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[1].SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AuthSchemeIntegration_WithClientConfigPreference_ReprioritizesSchemes()
        {
            // Arrange
            var supportedOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A }
            };
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "sigv4a", "sigv4" });

            // Act
            var result = _handler.TestApplyAuthSchemePreferences(_clientConfig, supportedOptions);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[1].SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AuthSchemeIntegration_WithEnvironmentPreference_ReprioritizesSchemes()
        {
            // Arrange
            var supportedOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A }
            };
            Environment.SetEnvironmentVariable("AWS_AUTH_SCHEME_PREFERENCE", "sigv4a,sigv4");

            // Act
            var result = _handler.TestApplyAuthSchemePreferences(_clientConfig, supportedOptions);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[1].SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AuthSchemeIntegration_WithGlobalConfigPreference_ReprioritizesSchemes()
        {
            // Arrange
            var supportedOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A }
            };
            AWSConfigs.AuthSchemePreference = new AuthSchemePreference(new[] { "sigv4a", "sigv4" });

            // Act
            var result = _handler.TestApplyAuthSchemePreferences(_clientConfig, supportedOptions);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[1].SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AuthSchemeIntegration_WithConfigurationPrecedence_PrioritizesClientConfig()
        {
            // Arrange
            var supportedOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.Bearer }
            };
            
            // Set multiple configuration sources
            Environment.SetEnvironmentVariable("AWS_AUTH_SCHEME_PREFERENCE", "sigv4,sigv4a");
            AWSConfigs.AuthSchemePreference = new AuthSchemePreference(new[] { "httpBearerAuth", "sigv4" });
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "sigv4a", "httpBearerAuth" });

            // Act
            var result = _handler.TestApplyAuthSchemePreferences(_clientConfig, supportedOptions);

            // Assert - Should use client config preference
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.Bearer, result[1].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[2].SchemeId); // Remaining supported scheme
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AuthSchemeIntegration_WithUnsupportedPreference_IgnoresUnsupportedSchemes()
        {
            // Arrange
            var supportedOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 }
            };
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "sigv4a", "httpBearerAuth", "sigv4" });

            // Act
            var result = _handler.TestApplyAuthSchemePreferences(_clientConfig, supportedOptions);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[0].SchemeId); // Only supported scheme
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AuthSchemeIntegration_WithHttpBearerPreference_PrioritizesHttpBearer()
        {
            // Arrange
            var supportedOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.Bearer }
            };
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "httpBearerAuth", "sigv4" });

            // Act
            var result = _handler.TestApplyAuthSchemePreferences(_clientConfig, supportedOptions);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.Bearer, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[1].SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AuthSchemeIntegration_WithNoAuthPreference_PrioritizesNoAuth()
        {
            // Arrange
            var supportedOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.NoAuth }
            };
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "noAuth", "sigv4" });

            // Act
            var result = _handler.TestApplyAuthSchemePreferences(_clientConfig, supportedOptions);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.NoAuth, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[1].SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AuthSchemeIntegration_WithErrorInPreferenceResolution_FallsBackToOriginalOrder()
        {
            // Arrange
            var supportedOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A }
            };
            
            // Set an invalid client config that will cause an error
            var invalidClientConfig = new InvalidTestClientConfig();

            // Act
            var result = _handler.TestApplyAuthSchemePreferences(invalidClientConfig, supportedOptions);

            // Assert - Should fall back to original order
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[1].SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AuthSchemeIntegration_WithEmptyAuthOptions_ReturnsEmptyList()
        {
            // Arrange
            var supportedOptions = new List<IAuthSchemeOption>();
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "sigv4a", "sigv4" });

            // Act
            var result = _handler.TestApplyAuthSchemePreferences(_clientConfig, supportedOptions);

            // Assert
            Assert.AreEqual(0, result.Count);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void AuthSchemeIntegration_WithNullAuthOptions_ReturnsNull()
        {
            // Arrange
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "sigv4a", "sigv4" });

            // Act
            var result = _handler.TestApplyAuthSchemePreferences(_clientConfig, null);

            // Assert
            Assert.IsNull(result);
        }

        /// <summary>
        /// Test implementation of BaseAuthResolverHandler that exposes the ApplyAuthSchemePreferences method for testing.
        /// </summary>
        private class TestAuthResolverHandler : BaseAuthResolverHandler
        {
            public TestAuthResolverHandler()
            {
                // Initialize Logger to avoid null reference exceptions
                Logger = Amazon.Runtime.Internal.Util.Logger.GetLogger(typeof(TestAuthResolverHandler));
            }

            public List<IAuthSchemeOption> TestApplyAuthSchemePreferences(IClientConfig clientConfig, List<IAuthSchemeOption> authOptions)
            {
                return ApplyAuthSchemePreferences(clientConfig, authOptions);
            }

            protected override List<IAuthSchemeOption> ResolveAuthOptions(IExecutionContext executionContext)
            {
                // Not used in these tests
                throw new NotImplementedException();
            }
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
            public System.Net.ICredentials ProxyCredentials => null;
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
#if BCL
            public WebProxy GetWebProxy() => null;
            public WebProxy GetHttpsProxy() => null;
            public WebProxy GetHttpProxy() => null;
#else
            public IWebProxy GetWebProxy() => null;
            public IWebProxy GetHttpsProxy() => null;
            public IWebProxy GetHttpProxy() => null;
#endif
        }

        /// <summary>
        /// Invalid test client config that will cause errors during preference resolution.
        /// </summary>
        private class InvalidTestClientConfig : TestClientConfig
        {
            public override string ToString()
            {
                throw new InvalidOperationException("Test exception for error handling");
            }
        }
    }
}