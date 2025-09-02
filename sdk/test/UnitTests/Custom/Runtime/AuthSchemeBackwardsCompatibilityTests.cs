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
    public class AuthSchemeBackwardsCompatibilityTests
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
        public void BackwardsCompatibility_SignatureMethodHmacSHA256_PrioritizesSigV4OverPreferences()
        {
            // Arrange
            var supportedOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A }
            };
            
            // Set both SignatureMethod (legacy) and AuthSchemePreference (new)
            _clientConfig.ServiceId = "S3"; // SignatureMethod precedence only applies to S3
            _clientConfig.SignatureMethod = SigningAlgorithm.HmacSHA256;
            _clientConfig.IsSignatureMethodExplicitlySet = true;
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "sigv4a", "sigv4" });

            // Act
            var result = _handler.TestApplyAuthSchemePreferences(_clientConfig, supportedOptions);

            // Assert - SignatureMethod should take precedence, prioritizing SigV4
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[0].SchemeId, "SignatureMethod should prioritize SigV4 over AuthSchemePreference");
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[1].SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void BackwardsCompatibility_SignatureMethodHmacSHA1_PrioritizesSigV4OverPreferences()
        {
            // Arrange
            var supportedOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A }
            };
            
            // Set both SignatureMethod (legacy) and AuthSchemePreference (new)
            _clientConfig.ServiceId = "S3"; // SignatureMethod precedence only applies to S3
            _clientConfig.SignatureMethod = SigningAlgorithm.HmacSHA1;
            _clientConfig.IsSignatureMethodExplicitlySet = true;
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "sigv4a", "sigv4" });

            // Act
            var result = _handler.TestApplyAuthSchemePreferences(_clientConfig, supportedOptions);

            // Assert - SignatureMethod should take precedence, prioritizing SigV4
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[0].SchemeId, "SignatureMethod should prioritize SigV4 over AuthSchemePreference");
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[1].SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void BackwardsCompatibility_SignatureMethodWithEnvironmentPreference_SignatureMethodTakesPrecedence()
        {
            // Arrange
            var supportedOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.Bearer }
            };
            
            // Set SignatureMethod and environment preference
            _clientConfig.ServiceId = "S3"; // SignatureMethod precedence only applies to S3
            _clientConfig.SignatureMethod = SigningAlgorithm.HmacSHA256;
            _clientConfig.IsSignatureMethodExplicitlySet = true;
            Environment.SetEnvironmentVariable("AWS_AUTH_SCHEME_PREFERENCE", "httpBearerAuth,sigv4a,sigv4");

            // Act
            var result = _handler.TestApplyAuthSchemePreferences(_clientConfig, supportedOptions);

            // Assert - SignatureMethod should take precedence over environment variable
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[0].SchemeId, "SignatureMethod should take precedence over environment preference");
            // Remaining schemes should be in original order since SignatureMethod overrides preferences
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[1].SchemeId);
            Assert.AreEqual(AuthSchemeOption.Bearer, result[2].SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void BackwardsCompatibility_SignatureMethodWithGlobalPreference_SignatureMethodTakesPrecedence()
        {
            // Arrange
            var supportedOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.Bearer }
            };
            
            // Set SignatureMethod and global preference
            _clientConfig.ServiceId = "S3"; // SignatureMethod precedence only applies to S3
            _clientConfig.SignatureMethod = SigningAlgorithm.HmacSHA256;
            _clientConfig.IsSignatureMethodExplicitlySet = true;
            AWSConfigs.AuthSchemePreference = new AuthSchemePreference(new[] { "httpBearerAuth", "sigv4a", "sigv4" });

            // Act
            var result = _handler.TestApplyAuthSchemePreferences(_clientConfig, supportedOptions);

            // Assert - SignatureMethod should take precedence over global preference
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[0].SchemeId, "SignatureMethod should take precedence over global preference");
            // Remaining schemes should be in original order since SignatureMethod overrides preferences
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[1].SchemeId);
            Assert.AreEqual(AuthSchemeOption.Bearer, result[2].SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void BackwardsCompatibility_NoSignatureMethodSet_UsesAuthSchemePreferences()
        {
            // Arrange
            var supportedOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A }
            };
            
            // Don't set SignatureMethod, but set AuthSchemePreference
            _clientConfig.IsSignatureMethodExplicitlySet = false; // Explicitly indicate SignatureMethod was not set
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "sigv4a", "sigv4" });

            // Act
            var result = _handler.TestApplyAuthSchemePreferences(_clientConfig, supportedOptions);

            // Assert - Should use AuthSchemePreference when SignatureMethod is not set
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[0].SchemeId, "Should use AuthSchemePreference when SignatureMethod is not set");
            Assert.AreEqual(AuthSchemeOption.SigV4, result[1].SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void BackwardsCompatibility_SignatureMethodOnlyWithSigV4Support_WorksCorrectly()
        {
            // Arrange - Service only supports SigV4
            var supportedOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 }
            };
            
            _clientConfig.SignatureMethod = SigningAlgorithm.HmacSHA256;

            // Act
            var result = _handler.TestApplyAuthSchemePreferences(_clientConfig, supportedOptions);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[0].SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void BackwardsCompatibility_SignatureMethodWithNoSigV4Support_FallsBackToSupported()
        {
            // Arrange - Service doesn't support SigV4 (edge case)
            var supportedOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.Bearer },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.NoAuth }
            };
            
            _clientConfig.SignatureMethod = SigningAlgorithm.HmacSHA256;

            // Act
            var result = _handler.TestApplyAuthSchemePreferences(_clientConfig, supportedOptions);

            // Assert - Should fall back to supported schemes when SigV4 is not available
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.Bearer, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.NoAuth, result[1].SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void BackwardsCompatibility_LegacyAndNewConfigurationTogether_DocumentsPrecedenceRules()
        {
            // This test documents the precedence rules between legacy and new configuration methods
            
            // Arrange
            var supportedOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.Bearer }
            };
            
            // Set all possible configuration sources
            _clientConfig.ServiceId = "S3"; // SignatureMethod precedence only applies to S3
            _clientConfig.SignatureMethod = SigningAlgorithm.HmacSHA256;  // Legacy - highest priority
            _clientConfig.IsSignatureMethodExplicitlySet = true;
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "sigv4a", "httpBearerAuth" }); // Client config
            Environment.SetEnvironmentVariable("AWS_AUTH_SCHEME_PREFERENCE", "httpBearerAuth,sigv4"); // Environment
            AWSConfigs.AuthSchemePreference = new AuthSchemePreference(new[] { "sigv4a" }); // Global

            // Act
            var result = _handler.TestApplyAuthSchemePreferences(_clientConfig, supportedOptions);

            // Assert - SignatureMethod (legacy) should take precedence over all new configuration methods
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[0].SchemeId, 
                "Legacy SignatureMethod should have highest precedence");
            
            // Verify that the precedence rules are documented in the resolver
            var preference = AuthSchemeConfigurationResolver.ResolveAuthSchemePreference(_clientConfig);
            Assert.IsNotNull(preference);
            Assert.AreEqual(1, preference.PreferenceList.Count);
            Assert.AreEqual("sigv4", preference.PreferenceList[0]);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void BackwardsCompatibility_S3Service_SignatureMethodAppliesCorrectly()
        {
            // Arrange - Test S3-specific backwards compatibility
            var supportedOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A }
            };
            
            // Configure as S3 service
            _clientConfig.ServiceId = "S3";
            _clientConfig.SignatureMethod = SigningAlgorithm.HmacSHA256;
            _clientConfig.IsSignatureMethodExplicitlySet = true;
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "sigv4a", "sigv4" });

            // Act
            var result = _handler.TestApplyAuthSchemePreferences(_clientConfig, supportedOptions);

            // Assert - For S3, SignatureMethod should take precedence
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[0].SchemeId, "S3 with SignatureMethod should prioritize SigV4");
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[1].SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void BackwardsCompatibility_NonS3Service_SignatureMethodNotExplicitlySet_UsesPreference()
        {
            // Arrange - Non-S3 service with SignatureMethod not explicitly set
            var supportedOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A }
            };
            
            // Configure as non-S3 service
            _clientConfig.ServiceId = "DynamoDB";
            _clientConfig.SignatureMethod = SigningAlgorithm.HmacSHA256; // Default value
            _clientConfig.IsSignatureMethodExplicitlySet = false; // Not explicitly set
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "sigv4a", "sigv4" });

            // Act
            var result = _handler.TestApplyAuthSchemePreferences(_clientConfig, supportedOptions);

            // Assert - Should use preference since SignatureMethod wasn't explicitly set
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[0].SchemeId, "Should use preference when SignatureMethod not explicitly set");
            Assert.AreEqual(AuthSchemeOption.SigV4, result[1].SchemeId);
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
            public SigningAlgorithm SignatureMethod { get; set; }
            public bool IsSignatureMethodExplicitlySet { get; set; } = false;

            // Minimal implementation of required properties for testing
            public bool IgnoreConfiguredEndpointUrls => false;
            public string ServiceId { get; set; } = "TestService";
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
    }
}