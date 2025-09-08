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
using Amazon.Runtime.Internal.Auth;
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
            var supportedSchemes = new List<IAuthSchemeOption> 
            { 
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A }
            };

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[1].SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithSigV4aPreference_PrioritizesSigV4a()
        {
            // Arrange
            var supportedSchemes = new List<IAuthSchemeOption> 
            { 
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A }
            };
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "sigv4a", "sigv4" });

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[1].SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithHttpBearerPreference_PrioritizesHttpBearer()
        {
            // Arrange
            var supportedSchemes = new List<IAuthSchemeOption> 
            { 
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.Bearer }
            };
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "httpBearerAuth", "sigv4" });

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.Bearer, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[1].SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithUnsupportedPreference_IgnoresUnsupported()
        {
            // Arrange
            var supportedSchemes = new List<IAuthSchemeOption> 
            { 
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A }
            };
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "unsupported", "sigv4a", "sigv4" });

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[1].SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithPartialPreference_AppendsUnmentionedSchemes()
        {
            // Arrange
            var supportedSchemes = new List<IAuthSchemeOption> 
            { 
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.Bearer }
            };
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "httpBearerAuth" });

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert
            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(AuthSchemeOption.Bearer, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[1].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[2].SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithEmptySupported_ReturnsEmpty()
        {
            // Arrange
            var supportedSchemes = new List<IAuthSchemeOption>();

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert
            Assert.AreEqual(0, result.Count);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithNullSupported_ReturnsEmpty()
        {
            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, null);

            // Assert
            Assert.AreEqual(0, result.Count);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithEnvironmentVariable_UsesEnvPreference()
        {
            // Arrange
            Environment.SetEnvironmentVariable("AWS_AUTH_SCHEME_PREFERENCE", "sigv4a,sigv4");
            var supportedSchemes = new List<IAuthSchemeOption> 
            { 
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A }
            };

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[1].SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithGlobalConfig_UsesGlobalPreference()
        {
            // Arrange
            AWSConfigs.AuthSchemePreference = new AuthSchemePreference(new[] { "sigv4a", "sigv4" });
            var supportedSchemes = new List<IAuthSchemeOption> 
            { 
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A }
            };

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[1].SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithClientConfigOverridesEnv_UsesClientConfig()
        {
            // Arrange
            Environment.SetEnvironmentVariable("AWS_AUTH_SCHEME_PREFERENCE", "sigv4,sigv4a");
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "sigv4a", "sigv4" });
            var supportedSchemes = new List<IAuthSchemeOption> 
            { 
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A }
            };

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[1].SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithNoAuth_ReturnsNoAuth()
        {
            // Arrange
            var supportedSchemes = new List<IAuthSchemeOption> 
            { 
                new AuthSchemeOption { SchemeId = AuthSchemeOption.NoAuth }
            };

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(AuthSchemeOption.NoAuth, result[0].SchemeId);
        }

        [TestCategory("UnitTest")]
        [TestMethod]
        public void ResolveAuthSchemes_WithFullSchemeIds_MatchesCorrectly()
        {
            // Arrange
            var supportedSchemes = new List<IAuthSchemeOption> 
            { 
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A }
            };
            // Use full scheme IDs in preference
            _clientConfig.AuthSchemePreference = new AuthSchemePreference(new[] { "aws.auth#sigv4a", "aws.auth#sigv4" });

            // Act
            var result = _resolver.ResolveAuthSchemes(_clientConfig, supportedSchemes);

            // Assert
            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[1].SchemeId);
        }

        /// <summary>
        /// Test client configuration for testing purposes.
        /// </summary>
        private class TestClientConfig : IClientConfig
        {
            public AuthSchemePreference AuthSchemePreference { get; set; }
            
            public AuthSchemePreference GetAuthSchemePreference()
            {
                return AuthSchemePreference;
            }

            public SigV4aRegionSetConfiguration GetSigV4aRegionSetConfiguration()
            {
                return null;
            }

            // Other IClientConfig properties (not relevant for this test)
            public string RegionEndpointServiceName { get; set; }
            public string ServiceURL { get; set; }
            public string ServiceId { get; set; }
            public ICredentials Credentials { get; set; }
            public AWSCredentials DefaultAWSCredentials { get; set; }
            public CredentialProfile Profile { get; set; }
            public IIdentityResolverConfiguration IdentityResolverConfiguration { get; set; }
            public ITelemetryProvider TelemetryProvider { get; set; }
            public IAWSTokenProvider AWSTokenProvider { get; set; }
            public SigningAlgorithm SignatureMethod { get; set; }
            public bool GetIsSignatureMethodExplicitlySet() => false;

            // Other IClientConfig members not shown for brevity...
        }
    }
}