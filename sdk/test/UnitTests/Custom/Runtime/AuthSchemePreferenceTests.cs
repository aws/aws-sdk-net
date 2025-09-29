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

using Amazon.Runtime;
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
    /// Test cases for Manual auth schemes configuration (preference list reordering).
    /// These tests verify the auth scheme preference list functionality as specified in the SEP document lines 556-564.
    /// 
    /// Test veteran's field notes:
    /// - This feature was introduced in 2025 for the "Selectable Authentication Schemes" Kingpin Goal
    /// - The preference list is a customer experience enhancement, not a hard override
    /// - Unsupported auth schemes in the preference list are ignored
    /// - The pattern follows the SRA's auth scheme resolver approach
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
        /// SEP Test Case: Supported Auth | Service Trait | Operation Trait | Preference List | Resolved Auth
        ///                sigv4, sigv4a  | sigv4, sigv4a | n/a            | n/a            | sigv4
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
        /// SEP Test Case: Supported Auth | Service Trait | Operation Trait | Preference List | Resolved Auth
        ///                sigv4, sigv4a  | sigv4, sigv4a | n/a            | sigv4a         | sigv4a
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
        /// SEP Test Case: Supported Auth | Service Trait | Operation Trait | Preference List    | Resolved Auth
        ///                sigv4, sigv4a  | sigv4, sigv4a | n/a            | sigv4a, sigv4     | sigv4a
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
        /// SEP Test Case: Supported Auth | Service Trait | Operation Trait | Preference List | Resolved Auth
        ///                sigv4, sigv4a  | sigv4         | n/a            | sigv4a         | sigv4
        /// 
        /// Veteran's note: When the preference specifies an unsupported scheme, it's ignored
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
        /// SEP Test Case: Supported Auth | Service Trait | Operation Trait | Preference List | Resolved Auth
        ///                sigv4, sigv4a  | sigv4, sigv4a | sigv4          | sigv4a         | sigv4
        /// 
        /// Veteran's note: Operation trait overrides service trait, preference applies to the operation's options
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
        /// SEP Test Case: Supported Auth | Service Trait | Operation Trait | Preference List | Resolved Auth
        ///                sigv4          | sigv4, sigv4a | n/a            | sigv4a         | sigv4
        /// 
        /// Veteran's note: Client only supports sigv4, preference for sigv4a is ignored
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
        /// SEP Test Case: Supported Auth | Service Trait | Operation Trait | Preference List | Resolved Auth
        ///                sigv4, sigv4a  | sigv4, sigv4a | n/a            | sigv3          | sigv4
        /// 
        /// Veteran's note: Unknown auth scheme in preference list is ignored, falls back to default order
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
        /// SEP requirement: Space and tab characters between names MUST be ignored.
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
            // Test various whitespace patterns as per SEP
            config.AuthSchemePreference = "sigv4a, \tsigv4   ,\t httpBearerAuth \t";

            var result = ApplyAuthSchemePreference(authOptions, config);

            Assert.AreEqual(3, result.Count);
            Assert.AreEqual(AuthSchemeOption.SigV4A, result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[1].SchemeId);
            Assert.AreEqual("smithy.api#httpBearerAuth", result[2].SchemeId);
        }

        /// <summary>
        /// Test Bearer auth scheme preference handling.
        /// Veteran's note: Bearer auth uses a different identity type than SigV4/SigV4a
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
        /// Test that noAuth scheme is handled correctly.
        /// Veteran's note: noAuth allows operations to proceed without credentials
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
            Assert.AreEqual("smithy.api#noAuth", result[0].SchemeId);
            Assert.AreEqual(AuthSchemeOption.SigV4, result[1].SchemeId);
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
            public TestClientConfig() : base()
            {
                this.RegionEndpoint = RegionEndpoint.USEast1;
            }

            public override string ServiceName => "TestService";
            
            public override string UserAgent => "TestUserAgent";
        }

        #endregion
    }
}