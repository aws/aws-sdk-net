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
using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Credentials.Internal;
using Amazon.Runtime.Endpoints;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Identity;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.Runtime
{
    /// <summary>
    /// Tests for alternative auth resolution mechanisms.
    /// These tests verify how Endpoints 2.0 can override model-based auth resolution, and how manual
    /// configuration takes precedence over all other sources.
    ///
    /// Auth resolution hierarchy:
    /// 1. Manual configuration (highest priority)
    /// 2. Endpoints 2.0 metadata
    /// 3. Operation-level auth configuration
    /// 4. Service-level auth configuration
    /// </summary>
    [TestClass]
    public class AlternativeAuthResolutionTests : RuntimePipelineTestBase
    {
        #region Alternative Auth Resolution Tests

        /// <summary>
        /// Endpoints 2.0 specifies sigv4a, which overrides the service's default order.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void AlternativeAuth_Endpoints2Specifies_SigV4a_OverridesServiceDefault()
        {
            // Endpoints 2.0 says to use sigv4a (overriding service default order)
            var endpointAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = "aws.auth#sigv4a" }
            };

            var context = CreateMockContext();
            var resolver = new TestAuthResolver(endpointAuthOptions);

            resolver.PreInvoke(context);

            Assert.IsNotNull(context.RequestContext.Identity, "Identity should be resolved");
            Assert.IsNotNull(context.RequestContext.Signer, "Signer should be set");
            // SigV4a should be selected (AWS4aSignerCRTWrapper)
            Assert.AreEqual("AWS4aSignerCRTWrapper", context.RequestContext.Signer.GetType().Name);
        }



        /// <summary>
        /// When no Endpoints 2.0 override exists, use the service default (sigv4 first).
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void AlternativeAuth_NoEndpointOverride_UsesServiceDefault()
        {
            // Service default order: sigv4 comes first
            var serviceAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = "aws.auth#sigv4" },
                new AuthSchemeOption { SchemeId = "aws.auth#sigv4a" }
            };

            var context = CreateMockContext();
            var resolver = new TestAuthResolver(serviceAuthOptions);

            resolver.PreInvoke(context);

            Assert.IsNotNull(context.RequestContext.Identity, "Identity should be resolved");
            Assert.IsNotNull(context.RequestContext.Signer, "Signer should be set");
            // SigV4 should be selected (AWS4Signer) - service default
            Assert.AreEqual("AWS4Signer", context.RequestContext.Signer.GetType().Name);
        }

        /// <summary>
        /// Manual configuration takes precedence over Endpoints 2.0.
        /// This is the MOST IMPORTANT test - manual config is never overridden.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void AlternativeAuth_ManualConfigurationOverridesEverything()
        {
            // Endpoints 2.0 wants sigv4a first, but both are available
            var endpointAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = "aws.auth#sigv4a" },
                new AuthSchemeOption { SchemeId = "aws.auth#sigv4" }
            };

            var context = CreateMockContextWithManualConfig("sigv4");
            var resolver = new TestAuthResolver(endpointAuthOptions);

            resolver.PreInvoke(context);

            Assert.IsNotNull(context.RequestContext.Identity, "Identity should be resolved");
            Assert.IsNotNull(context.RequestContext.Signer, "Signer should be set");
            // Manual config wins - should be sigv4, not sigv4a
            Assert.AreEqual("AWS4Signer", context.RequestContext.Signer.GetType().Name);
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

        private IExecutionContext CreateMockContextWithManualConfig(string authPreference)
        {
            var originalRequest = new MockAmazonWebServiceRequest();
            var request = new Amazon.Runtime.Internal.DefaultRequest(originalRequest, "TestService");
            request.Endpoint = new Uri("https://test.amazonaws.com");

            var config = new MockClientConfig();
            // Provide mock credentials for identity resolution
            config.DefaultAWSCredentials = new BasicAWSCredentials("accessKey", "secretKey");
            // Set manual auth preference
            config.AuthSchemePreference = authPreference;

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
        /// This simulates how endpoints 2.0 auth schemes override service defaults.
        /// </summary>
        private class TestAuthResolver : BaseAuthResolverHandler
        {
            private readonly List<IAuthSchemeOption> _authOptions;
            private readonly HashSet<string> _unsupportedSchemes;

            public TestAuthResolver(List<IAuthSchemeOption> authOptions, HashSet<string> unsupportedSchemes = null)
            {
                _authOptions = authOptions ?? new List<IAuthSchemeOption>();
                _unsupportedSchemes = unsupportedSchemes ?? new HashSet<string>();
            }

            protected override List<IAuthSchemeOption> ResolveAuthOptions(IExecutionContext executionContext)
            {
                // This simulates how endpoints 2.0 auth schemes override service defaults
                return _authOptions;
            }

            protected override ISigner GetSigner(IAuthScheme<BaseIdentity> scheme)
            {
                // Simulate scheme not being supported (e.g., CRT not available for V4a)
                if (_unsupportedSchemes?.Contains(scheme.SchemeId) == true)
                {
                    throw new AmazonClientException($"{scheme.SchemeId} is not supported in this test configuration");
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
        /// Mock request class for testing.
        /// </summary>
        private class MockAmazonWebServiceRequest : AmazonWebServiceRequest
        {
        }

        /// <summary>
        /// Mock client configuration for testing.
        /// </summary>
        private class MockClientConfig : ClientConfig
        {
            public MockClientConfig() : base(new DummyDefaultConfigurationProvider())
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1;
                // Use a custom identity resolver configuration that respects our test settings
                this.IdentityResolverConfiguration = new MockIdentityResolverConfiguration(this);
            }

            public override string RegionEndpointServiceName => "test";
            public override string ServiceVersion => "1.0";
            public override string UserAgent => "test-agent";

            public override Endpoint DetermineServiceOperationEndpoint(ServiceOperationEndpointParameters parameters)
            {
                // For testing, return a simple endpoint
                return new Endpoint("https://test.amazonaws.com");
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

        /// <summary>
        /// Mock identity resolver configuration that respects test settings.
        /// </summary>
        private class MockIdentityResolverConfiguration : IIdentityResolverConfiguration
        {
            private readonly MockClientConfig _config;

            public MockIdentityResolverConfiguration(MockClientConfig config)
            {
                _config = config;
            }

            public IIdentityResolver GetIdentityResolver<T>() where T : BaseIdentity
            {
                if (typeof(T) == typeof(AWSCredentials))
                {
                    return new MockAWSCredentialsResolver(_config);
                }
                if (typeof(T) == typeof(AnonymousAWSCredentials))
                {
                    return new AnonymousIdentityResolver();
                }
                throw new NotImplementedException($"{typeof(T).Name} is not supported");
            }
        }

        /// <summary>
        /// Mock AWS credentials resolver that only returns credentials when explicitly set.
        /// </summary>
        private class MockAWSCredentialsResolver : IIdentityResolver<AWSCredentials>
        {
            private readonly MockClientConfig _config;

            public MockAWSCredentialsResolver(MockClientConfig config)
            {
                _config = config;
            }

            public AWSCredentials ResolveIdentity(IClientConfig clientConfig)
            {
                // Only return credentials if they were explicitly set
                if (_config.DefaultAWSCredentials != null)
                {
                    return _config.DefaultAWSCredentials;
                }
                return null;
            }

            public Task<AWSCredentials> ResolveIdentityAsync(IClientConfig clientConfig, CancellationToken cancellationToken = default)
            {
                return Task.FromResult(ResolveIdentity(clientConfig));
            }

            BaseIdentity IIdentityResolver.ResolveIdentity(IClientConfig clientConfig) => ResolveIdentity(clientConfig);

            Task<BaseIdentity> IIdentityResolver.ResolveIdentityAsync(IClientConfig clientConfig, CancellationToken cancellationToken)
                => Task.FromResult<BaseIdentity>(ResolveIdentity(clientConfig));
        }

        #endregion
    }
}