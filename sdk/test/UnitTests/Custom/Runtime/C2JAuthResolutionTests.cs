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
using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.Runtime
{
    /// <summary>
    /// Tests for C2J Auth Type Resolution as specified in the Multi-Auth and SigV4a Enhancement Proposal.
    /// These tests verify the auth scheme resolution logic when working with C2J (Cloud to Java) service models,
    /// which are still used by many AWS services in the .NET SDK.
    /// 
    /// Field Notes (SDK Veteran Architecture Documentation):
    /// =====================================================
    /// C2J is Amazon's legacy service model format that predates Smithy. While newer services use Smithy,
    /// a significant portion of the AWS SDK for .NET still relies on C2J models. The auth resolution logic
    /// for C2J models is different from Smithy models in that:
    /// 
    /// 1. C2J uses string-based auth type names (e.g., "sigv4", "sigv4a", "bearer")
    /// 2. Service-level auth is defined in the service metadata
    /// 3. Operation-level auth overrides are defined per operation
    /// 4. The resolution follows a "first supported wins" model from the auth list
    /// 
    /// Historical Context:
    /// - C2J was the original service modeling format for AWS SDKs
    /// - Many core services (S3, DynamoDB, EC2) still use C2J models
    /// - The transition to Smithy is ongoing but will take years to complete
    /// - Both model formats must be supported for backwards compatibility
    /// 
    /// Test Case Source: Lines 484-518 of the Multi-Auth and SigV4a Enhancement Proposal
    /// </summary>
    [TestClass]
    public class C2JAuthResolutionTests : RuntimePipelineTestBase
    {
        private readonly MethodInfo _resolveAuthSchemeMethod;

        public C2JAuthResolutionTests()
        {
            // Get the private ResolveAuthScheme method via reflection
            var handlerType = typeof(BaseAuthResolverHandler);
            _resolveAuthSchemeMethod = handlerType.GetMethod(
                "ResolveAuthScheme",
                BindingFlags.NonPublic | BindingFlags.Instance,
                null,
                new[] { typeof(List<IAuthSchemeOption>), typeof(IExecutionContext) },
                null);

            Assert.IsNotNull(_resolveAuthSchemeMethod, "Could not find ResolveAuthScheme method");
        }

        #region SigV4/SigV4a Resolution Tests (Table 1, lines 484-494)

        /// <summary>
        /// Test case from line 486: sigv4, sigv4a | sigv4, sigv4a | n/a | sigv4
        /// When client supports both sigv4 and sigv4a, and service supports both in that order,
        /// sigv4 should be chosen (first in the list).
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void C2J_ClientSupportsV4andV4a_ServiceSupportsV4ThenV4a_NoOperationOverride_ResolvesToV4()
        {
            var serviceAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("aws.auth#sigv4"),
                new AuthSchemeOption("aws.auth#sigv4a")
            };

            var context = CreateMockContext();
            var resolver = new TestAuthResolver(supportsSigV4: true, supportsSigV4a: true);

            var result = resolver.TestResolveAuthScheme(serviceAuthOptions, context);

            Assert.IsNotNull(result);
            Assert.AreEqual("aws.auth#sigv4", result.SchemeId);
        }

        /// <summary>
        /// Test case from line 487: sigv4, sigv4a | sigv4a, sigv4 | n/a | sigv4a
        /// When client supports both and service lists sigv4a first, sigv4a should be chosen.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void C2J_ClientSupportsV4andV4a_ServiceSupportsV4aThenV4_NoOperationOverride_ResolvesToV4a()
        {
            var serviceAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("aws.auth#sigv4a"),
                new AuthSchemeOption("aws.auth#sigv4")
            };

            var context = CreateMockContext();
            var resolver = new TestAuthResolver(supportsSigV4: true, supportsSigV4a: true);

            var result = resolver.TestResolveAuthScheme(serviceAuthOptions, context);

            Assert.IsNotNull(result);
            Assert.AreEqual("aws.auth#sigv4a", result.SchemeId);
        }

        /// <summary>
        /// Test case from line 488: sigv4, sigv4a | sigv4, sigv4a | sigv4a, sigv4 | sigv4a
        /// When operation overrides auth order, the operation's order takes precedence.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void C2J_ClientSupportsV4andV4a_OperationOverridesWithV4aThenV4_ResolvesToV4a()
        {
            // Operation override - sigv4a comes first
            var operationAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("aws.auth#sigv4a"),
                new AuthSchemeOption("aws.auth#sigv4")
            };

            var context = CreateMockContext();
            var resolver = new TestAuthResolver(supportsSigV4: true, supportsSigV4a: true);

            var result = resolver.TestResolveAuthScheme(operationAuthOptions, context);

            Assert.IsNotNull(result);
            Assert.AreEqual("aws.auth#sigv4a", result.SchemeId);
        }

        /// <summary>
        /// Test case from line 489: sigv4, sigv4a | sigv4, sigv4a | noauth | noauth
        /// When operation specifies noauth, it should be used regardless of service auth.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void C2J_ClientSupportsV4andV4a_OperationSpecifiesNoAuth_ResolvesToNoAuth()
        {
            var operationAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("smithy.api#noAuth")
            };

            var context = CreateMockContext();
            var resolver = new TestAuthResolver(supportsSigV4: true, supportsSigV4a: true, supportsNoAuth: true);

            var result = resolver.TestResolveAuthScheme(operationAuthOptions, context);

            Assert.IsNotNull(result);
            Assert.AreEqual("smithy.api#noAuth", result.SchemeId);
        }

        /// <summary>
        /// Test case from line 490: sigv4 | sigv4, sigv4a | n/a | sigv4
        /// When client only supports sigv4, it should use sigv4 even if service supports both.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void C2J_ClientSupportsOnlyV4_ServiceSupportsBoth_ResolvesToV4()
        {
            var serviceAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("aws.auth#sigv4"),
                new AuthSchemeOption("aws.auth#sigv4a")
            };

            var context = CreateMockContext();
            var resolver = new TestAuthResolver(supportsSigV4: true, supportsSigV4a: false);

            var result = resolver.TestResolveAuthScheme(serviceAuthOptions, context);

            Assert.IsNotNull(result);
            Assert.AreEqual("aws.auth#sigv4", result.SchemeId);
        }

        /// <summary>
        /// Test case from line 491: sigv4 | sigv4a, sigv4 | n/a | sigv4
        /// When client only supports sigv4 and service lists sigv4a first, still use sigv4.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void C2J_ClientSupportsOnlyV4_ServiceListsV4aFirst_StillResolvesToV4()
        {
            var serviceAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("aws.auth#sigv4a"),
                new AuthSchemeOption("aws.auth#sigv4")
            };

            var context = CreateMockContext();
            var resolver = new TestAuthResolver(supportsSigV4: true, supportsSigV4a: false);

            var result = resolver.TestResolveAuthScheme(serviceAuthOptions, context);

            Assert.IsNotNull(result);
            Assert.AreEqual("aws.auth#sigv4", result.SchemeId);
        }

        /// <summary>
        /// Test case from line 492: sigv4 | sigv4, sigv4a | sigv4a, sigv4 | sigv4
        /// Client only supports sigv4, operation overrides order but still resolves to sigv4.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void C2J_ClientSupportsOnlyV4_OperationOverridesWithV4aThenV4_StillResolvesToV4()
        {
            var operationAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("aws.auth#sigv4a"),
                new AuthSchemeOption("aws.auth#sigv4")
            };

            var context = CreateMockContext();
            var resolver = new TestAuthResolver(supportsSigV4: true, supportsSigV4a: false);

            var result = resolver.TestResolveAuthScheme(operationAuthOptions, context);

            Assert.IsNotNull(result);
            Assert.AreEqual("aws.auth#sigv4", result.SchemeId);
        }

        /// <summary>
        /// Test case from line 493: sigv4 | sigv4, sigv4a | noauth | noauth
        /// Client only supports sigv4, operation specifies noauth.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void C2J_ClientSupportsOnlyV4_OperationSpecifiesNoAuth_ResolvesToNoAuth()
        {
            var operationAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("smithy.api#noAuth")
            };

            var context = CreateMockContext();
            var resolver = new TestAuthResolver(supportsSigV4: true, supportsSigV4a: false, supportsNoAuth: true);

            var result = resolver.TestResolveAuthScheme(operationAuthOptions, context);

            Assert.IsNotNull(result);
            Assert.AreEqual("smithy.api#noAuth", result.SchemeId);
        }

        /// <summary>
        /// Test case from line 494: sigv4 | sigv4, sigv4a | sigv4a | ERROR
        /// When client doesn't support the only auth type specified by operation, it should error.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [ExpectedException(typeof(AmazonClientException))]
        public void C2J_ClientSupportsOnlyV4_OperationRequiresOnlyV4a_ThrowsError()
        {
            var operationAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("aws.auth#sigv4a")
            };

            var context = CreateMockContext();
            var resolver = new TestAuthResolver(supportsSigV4: true, supportsSigV4a: false);

            // This should throw an exception
            resolver.TestResolveAuthScheme(operationAuthOptions, context);
        }

        #endregion

        #region SigV4/Bearer Resolution Tests (Table 2, lines 507-517)

        /// <summary>
        /// Test case from line 509: sigv4, bearer | sigv4, bearer | n/a | sigv4
        /// When client supports both sigv4 and bearer, and service lists sigv4 first, use sigv4.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void C2J_ClientSupportsV4andBearer_ServiceSupportsV4ThenBearer_ResolvesToV4()
        {
            var serviceAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("aws.auth#sigv4"),
                new AuthSchemeOption("smithy.api#httpBearerAuth")
            };

            var context = CreateMockContext();
            var resolver = new TestAuthResolver(supportsSigV4: true, supportsBearer: true);

            var result = resolver.TestResolveAuthScheme(serviceAuthOptions, context);

            Assert.IsNotNull(result);
            Assert.AreEqual("aws.auth#sigv4", result.SchemeId);
        }

        /// <summary>
        /// Test case from line 510: sigv4, bearer | bearer, sigv4 | n/a | bearer
        /// When service lists bearer first, use bearer.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void C2J_ClientSupportsV4andBearer_ServiceSupportsBearerThenV4_ResolvesToBearer()
        {
            var serviceAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("smithy.api#httpBearerAuth"),
                new AuthSchemeOption("aws.auth#sigv4")
            };

            var context = CreateMockContext();
            var resolver = new TestAuthResolver(supportsSigV4: true, supportsBearer: true);

            var result = resolver.TestResolveAuthScheme(serviceAuthOptions, context);

            Assert.IsNotNull(result);
            Assert.AreEqual("smithy.api#httpBearerAuth", result.SchemeId);
        }

        /// <summary>
        /// Test case from line 511: sigv4, bearer | sigv4, bearer | bearer, sigv4 | bearer
        /// Operation override changes the order to bearer first.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void C2J_ClientSupportsV4andBearer_OperationOverridesWithBearerFirst_ResolvesToBearer()
        {
            var operationAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("smithy.api#httpBearerAuth"),
                new AuthSchemeOption("aws.auth#sigv4")
            };

            var context = CreateMockContext();
            var resolver = new TestAuthResolver(supportsSigV4: true, supportsBearer: true);

            var result = resolver.TestResolveAuthScheme(operationAuthOptions, context);

            Assert.IsNotNull(result);
            Assert.AreEqual("smithy.api#httpBearerAuth", result.SchemeId);
        }

        /// <summary>
        /// Test case from line 512: sigv4, bearer | sigv4, bearer | noauth | noauth
        /// Client supports both, operation specifies noauth.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void C2J_ClientSupportsV4andBearer_OperationSpecifiesNoAuth_ResolvesToNoAuth()
        {
            var operationAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("smithy.api#noAuth")
            };

            var context = CreateMockContext();
            var resolver = new TestAuthResolver(supportsSigV4: true, supportsBearer: true, supportsNoAuth: true);

            var result = resolver.TestResolveAuthScheme(operationAuthOptions, context);

            Assert.IsNotNull(result);
            Assert.AreEqual("smithy.api#noAuth", result.SchemeId);
        }

        /// <summary>
        /// Test case from line 513: sigv4 | sigv4, bearer | n/a | sigv4
        /// Client only supports sigv4, so use it even if bearer is also offered.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void C2J_ClientSupportsOnlyV4_ServiceSupportsBoth_UsesV4()
        {
            var serviceAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("aws.auth#sigv4"),
                new AuthSchemeOption("smithy.api#httpBearerAuth")
            };

            var context = CreateMockContext();
            var resolver = new TestAuthResolver(supportsSigV4: true, supportsBearer: false);

            var result = resolver.TestResolveAuthScheme(serviceAuthOptions, context);

            Assert.IsNotNull(result);
            Assert.AreEqual("aws.auth#sigv4", result.SchemeId);
        }

        /// <summary>
        /// Test case from line 514: sigv4 | bearer, sigv4 | n/a | sigv4
        /// Client only supports sigv4, service lists bearer first but client uses sigv4.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void C2J_ClientSupportsOnlyV4_ServiceListsBearerFirst_StillUsesV4()
        {
            var serviceAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("smithy.api#httpBearerAuth"),
                new AuthSchemeOption("aws.auth#sigv4")
            };

            var context = CreateMockContext();
            var resolver = new TestAuthResolver(supportsSigV4: true, supportsBearer: false);

            var result = resolver.TestResolveAuthScheme(serviceAuthOptions, context);

            Assert.IsNotNull(result);
            Assert.AreEqual("aws.auth#sigv4", result.SchemeId);
        }

        /// <summary>
        /// Test case from line 515: sigv4 | sigv4, bearer | bearer, sigv4 | sigv4
        /// Client only supports sigv4, operation lists bearer first but client uses sigv4.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void C2J_ClientSupportsOnlyV4_OperationListsBearerFirst_StillUsesV4()
        {
            var operationAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("smithy.api#httpBearerAuth"),
                new AuthSchemeOption("aws.auth#sigv4")
            };

            var context = CreateMockContext();
            var resolver = new TestAuthResolver(supportsSigV4: true, supportsBearer: false);

            var result = resolver.TestResolveAuthScheme(operationAuthOptions, context);

            Assert.IsNotNull(result);
            Assert.AreEqual("aws.auth#sigv4", result.SchemeId);
        }

        /// <summary>
        /// Test case from line 516: sigv4 | sigv4, bearer | noauth | noauth
        /// Client only supports sigv4, operation specifies noauth.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void C2J_ClientSupportsOnlyV4_ServiceSupportsV4Bearer_OperationNoAuth_ResolvesToNoAuth()
        {
            var operationAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("smithy.api#noAuth")
            };

            var context = CreateMockContext();
            var resolver = new TestAuthResolver(supportsSigV4: true, supportsBearer: false, supportsNoAuth: true);

            var result = resolver.TestResolveAuthScheme(operationAuthOptions, context);

            Assert.IsNotNull(result);
            Assert.AreEqual("smithy.api#noAuth", result.SchemeId);
        }

        /// <summary>
        /// Test case from line 517: sigv4 | sigv4, bearer | bearer | ERROR
        /// Operation requires bearer but client doesn't support it.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [ExpectedException(typeof(AmazonClientException))]
        public void C2J_ClientSupportsOnlyV4_OperationRequiresBearer_ThrowsError()
        {
            var operationAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption("smithy.api#httpBearerAuth")
            };

            var context = CreateMockContext();
            var resolver = new TestAuthResolver(supportsSigV4: true, supportsBearer: false);

            // This should throw
            resolver.TestResolveAuthScheme(operationAuthOptions, context);
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
        /// Test implementation of BaseAuthResolverHandler that allows us to control
        /// which auth schemes are "supported" for testing purposes.
        /// </summary>
        private class TestAuthResolver : BaseAuthResolverHandler
        {
            private readonly bool _supportsSigV4;
            private readonly bool _supportsSigV4a;
            private readonly bool _supportsBearer;
            private readonly bool _supportsNoAuth;

            public TestAuthResolver(
                bool supportsSigV4 = false, 
                bool supportsSigV4a = false, 
                bool supportsBearer = false,
                bool supportsNoAuth = false)
            {
                _supportsSigV4 = supportsSigV4;
                _supportsSigV4a = supportsSigV4a;
                _supportsBearer = supportsBearer;
                _supportsNoAuth = supportsNoAuth;
            }

            protected override List<IAuthSchemeOption> ResolveAuthOptions(IExecutionContext executionContext)
            {
                // Not used in these tests
                return new List<IAuthSchemeOption>();
            }

            /// <summary>
            /// Override to control which auth schemes are "supported" based on test parameters.
            /// In real usage, this checks for runtime support and identity providers.
            /// </summary>
            protected override bool IsAuthSchemeSupported(IAuthSchemeOption authOption, IExecutionContext executionContext)
            {
                switch (authOption.SchemeId)
                {
                    case "aws.auth#sigv4":
                        return _supportsSigV4;
                    case "aws.auth#sigv4a":
                        return _supportsSigV4a;
                    case "smithy.api#httpBearerAuth":
                        return _supportsBearer;
                    case "smithy.api#noAuth":
                        return _supportsNoAuth;
                    default:
                        return false;
                }
            }

            /// <summary>
            /// Public wrapper to test the protected ResolveAuthScheme method
            /// </summary>
            public IAuthSchemeOption TestResolveAuthScheme(List<IAuthSchemeOption> authOptions, IExecutionContext context)
            {
                // Use reflection to call the private method
                var method = typeof(BaseAuthResolverHandler).GetMethod(
                    "ResolveAuthScheme",
                    BindingFlags.NonPublic | BindingFlags.Instance);

                return (IAuthSchemeOption)method.Invoke(this, new object[] { authOptions, context });
            }
        }

        #endregion
    }
}