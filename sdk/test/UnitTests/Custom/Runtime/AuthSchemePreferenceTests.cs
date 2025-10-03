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