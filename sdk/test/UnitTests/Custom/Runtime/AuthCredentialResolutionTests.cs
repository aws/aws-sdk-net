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
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Identity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.Runtime
{
    /// <summary>
    /// Tests for Resolving Auth and Credentials as specified in the Multi-Auth and SigV4a Enhancement Proposal.
    /// These tests verify that an auth scheme is only considered "supported" when BOTH:
    /// 1. The SDK has an implementation for the auth scheme (signer)
    /// 2. The SDK has an identity provider registered for the auth scheme (credentials)
    /// 
    /// Field Notes (SDK Veteran Architecture Documentation):
    /// =====================================================
    /// This is a critical aspect of the multi-auth implementation that prevents runtime failures.
    /// An auth scheme might be implemented in the SDK (e.g., we have a SigV4 signer) but if there
    /// are no credentials available (no identity provider), the auth scheme cannot be used.
    /// 
    /// The separation between "implementation" and "identity" is important:
    /// - Implementation: The signer that knows HOW to sign requests (e.g., AWS4Signer, BearerTokenSigner)
    /// - Identity: The credentials/token that provides WHAT to sign with (e.g., AWS credentials, bearer token)
    /// 
    /// Historical Context:
    /// - This requirement comes from the Smithy Reference Architecture (SRA)
    /// - It prevents selecting an auth scheme that would fail at signing time
    /// - The check happens during auth resolution, not during signing, for better error messages
    /// 
    /// Common Scenarios:
    /// - SigV4 without AWS credentials: Cannot use SigV4
    /// - Bearer auth without a token provider: Cannot use bearer auth
    /// - Multiple auth schemes available: Use first one with BOTH implementation and identity
    /// 
    /// Test Case Source: Lines 544-553 of the Multi-Auth and SigV4a Enhancement Proposal
    /// </summary>
    [TestClass]
    public class AuthCredentialResolutionTests : RuntimePipelineTestBase
    {
        #region Resolving Auth and Credentials Tests (Table from lines 544-553)

        /// <summary>
        /// Test case from line 545: sigv4, bearer | sigv4, bearer | sigv4
        /// Runtime supports both, identity providers for both, service lists sigv4 first.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void AuthCredentials_BothRuntimeAndIdentity_UsesFirstInList()
        {
            var serviceAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("aws.auth#sigv4"),
                new AuthSchemeOption("smithy.api#httpBearerAuth")
            };

            var resolver = new TestAuthResolverWithIdentity(
                hasSigV4Runtime: true,
                hasBearerRuntime: true,
                hasSigV4Identity: true,
                hasBearerIdentity: true);

            var context = CreateMockContext();
            var result = resolver.TestResolveWithIdentity(serviceAuthOptions, context);

            Assert.IsNotNull(result);
            Assert.AreEqual("aws.auth#sigv4", result.SchemeId);
        }

        /// <summary>
        /// Test case from line 546: sigv4, bearer | bearer, sigv4 | sigv4
        /// Service lists sigv4 first. Both runtime and identity available for both.
        /// The identity provider column order doesn't matter - resolution follows service order.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void AuthCredentials_BothRuntimeAndIdentity_ServiceListsSigV4First_UsesSigV4()
        {
            // Service lists sigv4 first (implied from SEP context)
            var serviceAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("aws.auth#sigv4"),
                new AuthSchemeOption("smithy.api#httpBearerAuth")
            };

            var resolver = new TestAuthResolverWithIdentity(
                hasSigV4Runtime: true,
                hasBearerRuntime: true,
                hasSigV4Identity: true,   // Both identity providers available
                hasBearerIdentity: true);  // Order in table doesn't affect resolution

            var context = CreateMockContext();
            var result = resolver.TestResolveWithIdentity(serviceAuthOptions, context);

            Assert.IsNotNull(result);
            // Should use sigv4 (first in service list)
            Assert.AreEqual("aws.auth#sigv4", result.SchemeId);
        }

        /// <summary>
        /// Test case from line 547: sigv4, bearer | bearer | bearer
        /// Only bearer identity available, so use bearer.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void AuthCredentials_OnlyBearerIdentityAvailable_UsesBearer()
        {
            var serviceAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("aws.auth#sigv4"),
                new AuthSchemeOption("smithy.api#httpBearerAuth")
            };

            var resolver = new TestAuthResolverWithIdentity(
                hasSigV4Runtime: true,
                hasBearerRuntime: true,
                hasSigV4Identity: false,  // No AWS credentials
                hasBearerIdentity: true);  // But have bearer token

            var context = CreateMockContext();
            var result = resolver.TestResolveWithIdentity(serviceAuthOptions, context);

            Assert.IsNotNull(result);
            Assert.AreEqual("smithy.api#httpBearerAuth", result.SchemeId);
        }

        /// <summary>
        /// Test case from line 548: sigv4, bearer | sigv4 | sigv4
        /// Only sigv4 identity available, so use sigv4.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void AuthCredentials_OnlySigV4IdentityAvailable_UsesSigV4()
        {
            var serviceAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("aws.auth#sigv4"),
                new AuthSchemeOption("smithy.api#httpBearerAuth")
            };

            var resolver = new TestAuthResolverWithIdentity(
                hasSigV4Runtime: true,
                hasBearerRuntime: true,
                hasSigV4Identity: true,   // Have AWS credentials
                hasBearerIdentity: false); // No bearer token

            var context = CreateMockContext();
            var result = resolver.TestResolveWithIdentity(serviceAuthOptions, context);

            Assert.IsNotNull(result);
            Assert.AreEqual("aws.auth#sigv4", result.SchemeId);
        }

        /// <summary>
        /// Test case from line 549: sigv4, bearer | n/a | ERROR
        /// No identity providers available for any supported auth scheme.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [ExpectedException(typeof(AmazonClientException))]
        public void AuthCredentials_NoIdentityProviders_ThrowsError()
        {
            var serviceAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("aws.auth#sigv4"),
                new AuthSchemeOption("smithy.api#httpBearerAuth")
            };

            var resolver = new TestAuthResolverWithIdentity(
                hasSigV4Runtime: true,
                hasBearerRuntime: true,
                hasSigV4Identity: false,  // No AWS credentials
                hasBearerIdentity: false); // No bearer token

            var context = CreateMockContext();
            
            // Should throw because no identity providers are available
            resolver.TestResolveWithIdentity(serviceAuthOptions, context);
        }

        /// <summary>
        /// Test case from line 550: sigv4 | bearer | ERROR
        /// Runtime doesn't support bearer, but only bearer identity is available.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [ExpectedException(typeof(AmazonClientException))]
        public void AuthCredentials_RuntimeDoesntSupportBearer_OnlyBearerIdentity_ThrowsError()
        {
            var serviceAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("aws.auth#sigv4"),
                new AuthSchemeOption("smithy.api#httpBearerAuth")
            };

            var resolver = new TestAuthResolverWithIdentity(
                hasSigV4Runtime: true,
                hasBearerRuntime: false,  // No bearer implementation
                hasSigV4Identity: false,  // No AWS credentials
                hasBearerIdentity: true);  // Have bearer token (but can't use it)

            var context = CreateMockContext();
            
            // Should throw because sigv4 has no identity and bearer has no runtime
            resolver.TestResolveWithIdentity(serviceAuthOptions, context);
        }

        #endregion

        #region Additional Edge Cases

        /// <summary>
        /// Test that having runtime support without identity is not sufficient.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [ExpectedException(typeof(AmazonClientException))]
        public void AuthCredentials_HasRuntimeButNoIdentity_CannotUseScheme()
        {
            var serviceAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("aws.auth#sigv4")
            };

            var resolver = new TestAuthResolverWithIdentity(
                hasSigV4Runtime: true,     // Have the signer
                hasBearerRuntime: false,
                hasSigV4Identity: false,   // But no credentials
                hasBearerIdentity: false);

            var context = CreateMockContext();
            
            // Should throw even though we have runtime support
            resolver.TestResolveWithIdentity(serviceAuthOptions, context);
        }

        /// <summary>
        /// Test that having identity without runtime support is not sufficient.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [ExpectedException(typeof(AmazonClientException))]
        public void AuthCredentials_HasIdentityButNoRuntime_CannotUseScheme()
        {
            var serviceAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("aws.auth#sigv4")
            };

            var resolver = new TestAuthResolverWithIdentity(
                hasSigV4Runtime: false,    // No signer implementation
                hasBearerRuntime: false,
                hasSigV4Identity: true,    // Have credentials
                hasBearerIdentity: false);

            var context = CreateMockContext();
            
            // Should throw even though we have credentials
            resolver.TestResolveWithIdentity(serviceAuthOptions, context);
        }

        /// <summary>
        /// Test fallback behavior when preferred auth scheme lacks identity.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void AuthCredentials_PreferredSchemeNoIdentity_FallsBackToNext()
        {
            var serviceAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("smithy.api#httpBearerAuth"),  // Preferred but no token
                new AuthSchemeOption("aws.auth#sigv4")              // Fallback with credentials
            };

            var resolver = new TestAuthResolverWithIdentity(
                hasSigV4Runtime: true,
                hasBearerRuntime: true,
                hasSigV4Identity: true,    // Have AWS credentials
                hasBearerIdentity: false);  // No bearer token

            var context = CreateMockContext();
            var result = resolver.TestResolveWithIdentity(serviceAuthOptions, context);

            Assert.IsNotNull(result);
            // Should skip bearer (no identity) and use sigv4
            Assert.AreEqual("aws.auth#sigv4", result.SchemeId);
        }

        /// <summary>
        /// Test with SigV4a - similar requirements apply.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void AuthCredentials_SigV4aRequiresBothRuntimeAndIdentity()
        {
            var serviceAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("aws.auth#sigv4a"),
                new AuthSchemeOption("aws.auth#sigv4")
            };

            // Has SigV4a runtime but no identity (no AWS credentials)
            var resolver = new TestAuthResolverWithIdentity(
                hasSigV4Runtime: true,
                hasBearerRuntime: false,
                hasSigV4Identity: true,
                hasBearerIdentity: false,
                hasSigV4aRuntime: true,
                hasSigV4aIdentity: false);  // No credentials for v4a

            var context = CreateMockContext();
            var result = resolver.TestResolveWithIdentity(serviceAuthOptions, context);

            Assert.IsNotNull(result);
            // Should skip v4a (no identity) and use v4
            Assert.AreEqual("aws.auth#sigv4", result.SchemeId);
        }

        #endregion

        #region Helper Methods and Test Infrastructure

        private IExecutionContext CreateMockContext()
        {
            var request = new Amazon.Runtime.Internal.DefaultRequest(
                new Amazon.Runtime.Internal.AmazonWebServiceRequest(), 
                "TestService");
            request.Endpoint = new Uri("https://test.amazonaws.com");

            var requestContext = new RequestContext(true, new NullSigner())
            {
                Request = request,
                ClientConfig = new MockClientConfig()
            };

            var responseContext = new ResponseContext();

            return new ExecutionContext(requestContext, responseContext);
        }

        /// <summary>
        /// Test resolver that simulates the interaction between runtime support and identity providers.
        /// </summary>
        private class TestAuthResolverWithIdentity : BaseAuthResolverHandler
        {
            private readonly bool _hasSigV4Runtime;
            private readonly bool _hasSigV4aRuntime;
            private readonly bool _hasBearerRuntime;
            private readonly bool _hasSigV4Identity;
            private readonly bool _hasSigV4aIdentity;
            private readonly bool _hasBearerIdentity;

            public TestAuthResolverWithIdentity(
                bool hasSigV4Runtime = false,
                bool hasBearerRuntime = false,
                bool hasSigV4Identity = false,
                bool hasBearerIdentity = false,
                bool hasSigV4aRuntime = false,
                bool hasSigV4aIdentity = false)
            {
                _hasSigV4Runtime = hasSigV4Runtime;
                _hasBearerRuntime = hasBearerRuntime;
                _hasSigV4Identity = hasSigV4Identity;
                _hasBearerIdentity = hasBearerIdentity;
                _hasSigV4aRuntime = hasSigV4aRuntime;
                _hasSigV4aIdentity = hasSigV4aIdentity;
            }

            protected override List<IAuthSchemeOption> ResolveAuthOptions(IExecutionContext executionContext)
            {
                return new List<IAuthSchemeOption>();
            }

            protected override bool IsAuthSchemeSupported(IAuthSchemeOption authOption, IExecutionContext executionContext)
            {
                // An auth scheme is only supported if it has BOTH runtime AND identity
                switch (authOption.SchemeId)
                {
                    case "aws.auth#sigv4":
                        return _hasSigV4Runtime && _hasSigV4Identity;
                    case "aws.auth#sigv4a":
                        return _hasSigV4aRuntime && _hasSigV4aIdentity;
                    case "smithy.api#httpBearerAuth":
                        return _hasBearerRuntime && _hasBearerIdentity;
                    case "smithy.api#noAuth":
                        return true;  // NoAuth doesn't need identity
                    default:
                        return false;
                }
            }

            public IAuthSchemeOption TestResolveWithIdentity(
                List<IAuthSchemeOption> authOptions,
                IExecutionContext context)
            {
                // Find first auth scheme with both runtime and identity support
                foreach (var option in authOptions)
                {
                    if (IsAuthSchemeSupported(option, context))
                    {
                        return option;
                    }
                }

                throw new AmazonClientException("No supported auth scheme found with both runtime and identity");
            }
        }

        /// <summary>
        /// Mock identity resolver for testing.
        /// In real implementation, this would check for AWS credentials, bearer tokens, etc.
        /// </summary>
        private interface IIdentityResolver
        {
            Task<IIdentity> ResolveIdentityAsync(string authScheme);
            bool HasIdentityFor(string authScheme);
        }

        /// <summary>
        /// Mock implementation of identity types.
        /// </summary>
        private class MockAWSCredentialsIdentity : IIdentity
        {
            public DateTime? Expiration => null;
        }

        private class MockBearerTokenIdentity : IIdentity
        {
            public DateTime? Expiration => null;
            public string Token { get; set; }
        }

        #endregion
    }
}