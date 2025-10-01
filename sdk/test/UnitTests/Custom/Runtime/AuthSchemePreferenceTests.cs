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

using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Endpoints;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Test cases for authentication scheme preference configuration.
    /// These tests verify that users can configure their preferred authentication schemes
    /// and that the SDK correctly reorders authentication options based on those preferences.
    ///
    /// Key behaviors tested:
    /// - The preference list reorders available auth schemes, not overrides them
    /// - Unsupported auth schemes in the preference list are ignored
    /// - The SDK maintains security by always placing noAuth last
    /// </summary>
    [TestClass]
    public class AuthSchemePreferenceTests
    {
        // Cache reflection info to avoid repeated lookups
        private static readonly Type _baseAuthResolverHandlerType = typeof(BaseAuthResolverHandler);
        private static readonly MethodInfo _applyAuthSchemePreferenceMethod;
        
        static AuthSchemePreferenceTests()
        {
            // Note for future maintainers: ApplyAuthSchemePreference is a private method
            // We use reflection here for unit testing without exposing internals
            _applyAuthSchemePreferenceMethod = _baseAuthResolverHandlerType.GetMethod(
                "ApplyAuthSchemePreference",
                BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static);
            
            Assert.IsNotNull(_applyAuthSchemePreferenceMethod, 
                "ApplyAuthSchemePreference method not found - has the method been renamed or moved?");
        }

        /// <summary>
        /// Test default behavior when no preference list is configured.
        /// Expected: Original auth scheme order is preserved (sigv4, sigv4a).
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestNoPreferenceList_DefaultOrder()
        {
            var authOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A }
            };

            var config = new TestClientConfig();
            config.AuthSchemePreference = null;

            var result = ApplyAuthSchemePreference(authOptions, config);

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[1].SchemeId);
        }

        /// <summary>
        /// Test that a single scheme preference correctly reorders auth options.
        /// Expected: sigv4a is moved to first position when preferred.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestPreferenceList_SingleScheme_Reorders()
        {
            var authOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A }
            };

            var config = new TestClientConfig();
            config.AuthSchemePreference = "sigv4a";

            var result = ApplyAuthSchemePreference(authOptions, config);

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[1].SchemeId);
        }

        /// <summary>
        /// Test that multiple schemes in preference list are applied in order.
        /// Expected: Auth schemes are reordered to match preference list order.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestPreferenceList_MultipleSchemes_RespectsOrder()
        {
            var authOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A }
            };

            var config = new TestClientConfig();
            config.AuthSchemePreference = "sigv4a, sigv4";

            var result = ApplyAuthSchemePreference(authOptions, config);

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[1].SchemeId);
        }

        /// <summary>
        /// Test that unsupported schemes in preference list are ignored.
        /// When a preferred scheme is not available, the SDK falls back to available schemes.
        /// Expected: sigv4 is used when sigv4a is preferred but not available.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestPreferenceList_UnsupportedScheme_Ignored()
        {
            var authOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 }
            };

            var config = new TestClientConfig();
            config.AuthSchemePreference = "sigv4a";

            var result = ApplyAuthSchemePreference(authOptions, config);

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[0].SchemeId);
        }

        /// <summary>
        /// Test preference list behavior when operation has limited auth options.
        /// When an operation only supports a subset of auth schemes, the preference list
        /// is applied only to those available options.
        /// Expected: sigv4 is used when operation only supports sigv4.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestPreferenceList_OperationOverride_PreferenceAppliestoOperation()
        {
            // When operation overrides to only support sigv4
            var authOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 }
            };

            var config = new TestClientConfig();
            config.AuthSchemePreference = "sigv4a";

            var result = ApplyAuthSchemePreference(authOptions, config);

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[0].SchemeId);
        }

        /// <summary>
        /// Test client-side limitation handling.
        /// When the client only has certain auth scheme implementations available,
        /// preferences for unavailable schemes are ignored.
        /// Expected: sigv4 is used when client only supports sigv4, even if sigv4a is preferred.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestPreferenceList_ClientLimitation_OnlySupportedSchemesUsed()
        {
            // Service supports both but client only has sigv4 implementation
            var authOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 }
            };

            var config = new TestClientConfig();
            config.AuthSchemePreference = "sigv4a";

            var result = ApplyAuthSchemePreference(authOptions, config);

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[0].SchemeId);
        }

        /// <summary>
        /// Test handling of unknown schemes in preference list.
        /// When preference list contains schemes that don't exist in available options,
        /// those schemes are ignored and the SDK falls back to default ordering.
        /// Expected: Original order (sigv4, sigv4a) when preference contains unknown scheme.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestPreferenceList_UnknownScheme_IgnoredFallsBackToDefault()
        {
            var authOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A }
            };

            var config = new TestClientConfig();
            config.AuthSchemePreference = "sigv3"; // sigv3 doesn't exist in available options

            var result = ApplyAuthSchemePreference(authOptions, config);

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[1].SchemeId);
        }

        /// <summary>
        /// Test that spaces and tabs between auth scheme names are properly trimmed.
        /// The SDK should handle various whitespace patterns gracefully.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestPreferenceList_WhitespaceHandling()
        {
            var authOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A },
                new AuthSchemeOption { SchemeId = "smithy.api#httpBearerAuth" }
            };

            var config = new TestClientConfig();
            // Test various whitespace patterns
            config.AuthSchemePreference = "sigv4a, \tsigv4   ,\t httpBearerAuth \t";

            var result = ApplyAuthSchemePreference(authOptions, config);

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[1].SchemeId);
            Assert.AreEqual("smithy.api#httpBearerAuth", result[2].SchemeId);
        }

        /// <summary>
        /// Test Bearer auth scheme preference handling.
        /// Bearer auth can be preferred over signature-based authentication schemes.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestPreferenceList_BearerAuth_Reordering()
        {
            var authOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = "smithy.api#httpBearerAuth" }
            };

            var config = new TestClientConfig();
            config.AuthSchemePreference = "httpBearerAuth, sigv4";

            var result = ApplyAuthSchemePreference(authOptions, config);

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual("smithy.api#httpBearerAuth", result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[1].SchemeId);
        }

        /// <summary>
        /// Test that duplicate schemes in preference list are handled correctly.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestPreferenceList_DuplicatesHandled()
        {
            var authOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A }
            };

            var config = new TestClientConfig();
            config.AuthSchemePreference = "sigv4a, sigv4a, sigv4, sigv4"; // Duplicates

            var result = ApplyAuthSchemePreference(authOptions, config);

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[1].SchemeId);
        }

        /// <summary>
        /// Test empty preference list returns original order.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestPreferenceList_EmptyString_NoReordering()
        {
            var authOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4A }
            };

            var config = new TestClientConfig();
            config.AuthSchemePreference = "";

            var result = ApplyAuthSchemePreference(authOptions, config);

            Assert.AreEqual(2, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[1].SchemeId);
        }

        /// <summary>
        /// Test that noAuth scheme is always placed last for security.
        /// CRITICAL: noAuth must always be last to prevent unauthenticated requests
        /// when authentication is available.
        /// This test verifies that even when noAuth is preferred, it's moved to the end.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestPreferenceList_NoAuth_Handling()
        {
            var authOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 },
                new AuthSchemeOption { SchemeId = "smithy.api#noAuth" }
            };

            var config = new TestClientConfig();
            config.AuthSchemePreference = "noAuth, sigv4";

            var result = ApplyAuthSchemePreference(authOptions, config);

            Assert.AreEqual(2, result.Count);
            // SECURITY: noAuth must always be last, even when preferred
            Assert.AreEqual(AuthSchemeOption.SigV4, result[0].SchemeId);
            Assert.AreEqual("smithy.api#noAuth", result[1].SchemeId);
        }

        /// <summary>
        /// Test that noAuth is always placed last even when it's the only preference.
        /// This verifies the critical security requirement in all scenarios.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestPreferenceList_NoAuthOnly_AlwaysLast()
        {
            var authOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = "smithy.api#httpBearerAuth" },
                new AuthSchemeOption { SchemeId = "smithy.api#noAuth" },
                new AuthSchemeOption { SchemeId = AuthSchemeOption.SigV4 }
            };

            var config = new TestClientConfig();
            config.AuthSchemePreference = "noAuth";  // Only noAuth in preference

            var result = ApplyAuthSchemePreference(authOptions, config);

            Assert.AreEqual(3, result.Count);
            // SECURITY: noAuth must be last, other schemes maintain their original order
            Assert.AreEqual("smithy.api#httpBearerAuth", result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[1].SchemeId);
            Assert.AreEqual("smithy.api#noAuth", result[2].SchemeId);  // Always last!
        }

        #region Helper Methods

        /// <summary>
        /// Helper method to invoke the private ApplyAuthSchemePreference method.
        /// </summary>
        private List<IAuthSchemeOption> ApplyAuthSchemePreference(
            List<IAuthSchemeOption> authOptions,
            IClientConfig config)
        {
            // Create a mock handler instance for invoking the method
            var handler = new TestAuthResolverHandler();
            var result = _applyAuthSchemePreferenceMethod.Invoke(
                handler,
                new object[] { authOptions, config });
            
            return (List<IAuthSchemeOption>)result;
        }

        /// <summary>
        /// Test implementation of BaseAuthResolverHandler for unit testing.
        /// </summary>
        private class TestAuthResolverHandler : BaseAuthResolverHandler
        {
            protected override List<IAuthSchemeOption> ResolveAuthOptions(IExecutionContext executionContext)
            {
                // Not used in these tests
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// Test client configuration for unit testing.
        /// </summary>
        private class TestClientConfig : ClientConfig
        {
            public TestClientConfig() : base(new DummyDefaultConfigurationProvider())
            {
                this.RegionEndpoint = RegionEndpoint.USEast1;
            }

            public override string RegionEndpointServiceName { get; } = "TestService";
            public override string ServiceVersion { get; } = "1.0";
            public override string UserAgent => "TestUserAgent";

            public override Endpoint DetermineServiceOperationEndpoint(ServiceOperationEndpointParameters parameters)
            {
                return new Endpoint(this.ServiceURL ?? "https://example.com");
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

        #endregion
    }
}