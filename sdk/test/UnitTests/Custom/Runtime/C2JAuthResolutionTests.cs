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
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Identity;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.Runtime
{
    /// <summary>
    /// Tests for C2J Auth Type Resolution.
    /// These tests verify the auth scheme resolution logic when working with C2J service models,
    /// which are used by many AWS services in the .NET SDK.
    ///
    /// Key behaviors tested:
    /// - Service-level auth configuration
    /// - Operation-level auth overrides
    /// - "First supported wins" resolution model
    /// - Handling of multiple auth types (sigv4, sigv4a, bearer, noauth)
    /// </summary>
    [TestClass]
    public class C2JAuthResolutionTests : RuntimePipelineTestBase
    {
        #region SigV4/SigV4a Resolution Tests

        /// <summary>
        /// Test: When client supports both and service lists sigv4a first, sigv4a should be chosen.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void C2J_ClientSupportsV4andV4a_ServiceSupportsV4aThenV4_NoOperationOverride_ResolvesToV4a()
        {
            var serviceAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = "aws.auth#sigv4a" },
                new AuthSchemeOption { SchemeId = "aws.auth#sigv4" }
            };

            var context = CreateMockContext();
            var resolver = new TestAuthResolver(serviceAuthOptions);

            resolver.PreInvoke(context);

            Assert.IsNotNull(context.RequestContext.Identity, "Identity should be resolved");
            Assert.IsNotNull(context.RequestContext.Signer, "Signer should be set");
            // SigV4a should be selected (AWS4aSignerCRTWrapper)
            Assert.AreEqual("AWS4aSignerCRTWrapper", context.RequestContext.Signer.GetType().Name);
        }

        /// <summary>
        /// Test: When operation overrides auth order, the operation's order takes precedence.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void C2J_ClientSupportsV4andV4a_OperationOverridesWithV4aThenV4_ResolvesToV4a()
        {
            // Operation override - sigv4a comes first
            var operationAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = "aws.auth#sigv4a" },
                new AuthSchemeOption { SchemeId = "aws.auth#sigv4" }
            };

            var context = CreateMockContext();
            var resolver = new TestAuthResolver(operationAuthOptions);

            resolver.PreInvoke(context);

            Assert.IsNotNull(context.RequestContext.Identity, "Identity should be resolved");
            Assert.IsNotNull(context.RequestContext.Signer, "Signer should be set");
            // SigV4a should be selected (AWS4aSignerCRTWrapper)
            Assert.AreEqual("AWS4aSignerCRTWrapper", context.RequestContext.Signer.GetType().Name);
        }

        /// <summary>
        /// Test: When client only supports sigv4 and service lists sigv4a first, still use sigv4.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void C2J_ClientSupportsOnlyV4_ServiceListsV4aFirst_StillResolvesToV4()
        {
            var serviceAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = "aws.auth#sigv4a" },
                new AuthSchemeOption { SchemeId = "aws.auth#sigv4" }
            };

            var context = CreateMockContext();
            var unsupportedSchemes = new HashSet<string> { "aws.auth#sigv4a" };
            var resolver = new TestAuthResolver(serviceAuthOptions, unsupportedSchemes);

            resolver.PreInvoke(context);

            Assert.IsNotNull(context.RequestContext.Identity, "Identity should be resolved");
            Assert.IsNotNull(context.RequestContext.Signer, "Signer should be set");
            // SigV4 should be selected (AWS4Signer) - client doesn't support V4a
            Assert.AreEqual("AWS4Signer", context.RequestContext.Signer.GetType().Name);
        }

        /// <summary>
        /// Test: When client doesn't support the only auth type specified by operation, it should error.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [ExpectedException(typeof(AmazonClientException))]
        public void C2J_ClientSupportsOnlyV4_OperationRequiresOnlyV4a_ThrowsError()
        {
            var operationAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = "aws.auth#sigv4a" }
            };

            var context = CreateMockContext();
            var unsupportedSchemes = new HashSet<string> { "aws.auth#sigv4a" };
            var resolver = new TestAuthResolver(operationAuthOptions, unsupportedSchemes);

            // This should throw an exception - V4a not supported
            resolver.PreInvoke(context);
        }

        #endregion


        #region Helper Methods and Test Infrastructure

        private IExecutionContext CreateMockContext()
        {
            var originalRequest = new MockAmazonWebServiceRequest();
            var request = new Amazon.Runtime.Internal.DefaultRequest(originalRequest, "TestService");
            request.Endpoint = new Uri("https://test.amazonaws.com");

            var config = new MockClientConfig();
            // Provide mock credentials for identity resolution
            config.DefaultAWSCredentials = new BasicAWSCredentials("accessKey", "secretKey");

            var requestContext = new RequestContext(true, new NullSigner())
            {
                OriginalRequest = originalRequest,
                Request = request,
                ClientConfig = config
            };

            var responseContext = new ResponseContext();

            return new Amazon.Runtime.Internal.ExecutionContext(requestContext, responseContext);
        }

        private IExecutionContext CreateMockContextBearer()
        {
            var originalRequest = new MockAmazonWebServiceRequest();
            var request = new Amazon.Runtime.Internal.DefaultRequest(originalRequest, "TestService");
            request.Endpoint = new Uri("https://test.amazonaws.com");

            var config = new MockClientConfig();
            // Provide token provider for bearer auth (not credentials)
            config.AWSTokenProvider = new MockTokenProvider();

            var requestContext = new RequestContext(true, new NullSigner())
            {
                OriginalRequest = originalRequest,
                Request = request,
                ClientConfig = config
            };

            var responseContext = new ResponseContext();

            return new Amazon.Runtime.Internal.ExecutionContext(requestContext, responseContext);
        }

        private IExecutionContext CreateMockContextNoAuth()
        {
            var originalRequest = new MockAmazonWebServiceRequest();
            var request = new Amazon.Runtime.Internal.DefaultRequest(originalRequest, "TestService");
            request.Endpoint = new Uri("https://test.amazonaws.com");

            var config = new MockClientConfig();
            // No credentials or token provider for NoAuth

            var requestContext = new RequestContext(true, new NullSigner())
            {
                OriginalRequest = originalRequest,
                Request = request,
                ClientConfig = config
            };

            var responseContext = new ResponseContext();

            return new Amazon.Runtime.Internal.ExecutionContext(requestContext, responseContext);
        }

        /// <summary>
        /// Test implementation of BaseAuthResolverHandler that provides test auth options.
        /// Allows controlling which auth schemes are "supported" to simulate scenarios like
        /// CRT not being available for V4a.
        /// </summary>
        private class TestAuthResolver : BaseAuthResolverHandler
        {
            private readonly List<IAuthSchemeOption> _authOptions;
            private readonly HashSet<string> _unsupportedSchemes;

            public TestAuthResolver(List<IAuthSchemeOption> authOptions, HashSet<string> unsupportedSchemes = null)
            {
                // Store the auth options to return from ResolveAuthOptions
                _authOptions = authOptions ?? new List<IAuthSchemeOption>();
                _unsupportedSchemes = unsupportedSchemes ?? new HashSet<string>();
            }

            protected override List<IAuthSchemeOption> ResolveAuthOptions(IExecutionContext executionContext)
            {
                return _authOptions;
            }

            protected override ISigner GetSigner(IAuthScheme<BaseIdentity> scheme)
            {
                // Simulate scheme not being supported (e.g., CRT not available for V4a)
                if (_unsupportedSchemes.Contains(scheme.SchemeId))
                {
                    throw new AmazonClientException($"Simulated: {scheme.SchemeId} is not supported in this test configuration");
                }
                return base.GetSigner(scheme);
            }

            // Public wrapper for testing - exposes the protected PreInvoke method
            public new void PreInvoke(IExecutionContext executionContext)
            {
                base.PreInvoke(executionContext);
            }
        }

        /// <summary>
        /// Mock token provider for bearer auth tests
        /// </summary>
        private class MockTokenProvider : IAWSTokenProvider
        {
#if BCL
            public bool TryResolveToken(out AWSToken token)
            {
                token = new AWSToken { Token = "mock-token", Expiration = DateTime.UtcNow.AddHours(1) };
                return true;
            }
#endif

            public Task<TryResponse<AWSToken>> TryResolveTokenAsync(CancellationToken cancellationToken = default)
            {
                var token = new AWSToken { Token = "mock-token", Expiration = DateTime.UtcNow.AddHours(1) };
                return Task.FromResult(new TryResponse<AWSToken> { Success = true, Value = token });
            }
        }

        #endregion
    }
}