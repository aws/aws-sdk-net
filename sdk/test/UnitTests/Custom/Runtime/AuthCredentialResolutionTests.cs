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
    /// Tests for auth scheme resolution with credential availability.
    /// These tests verify that an auth scheme is only considered "supported" when BOTH:
    /// 1. The SDK has an implementation for the auth scheme (signer)
    /// 2. The SDK has an identity provider registered for the auth scheme (credentials)
    ///
    /// The separation between implementation and identity:
    /// - Implementation: The signer that knows HOW to sign requests (e.g., AWS4Signer, BearerTokenSigner)
    /// - Identity: The credentials/token that provides WHAT to sign with (e.g., AWS credentials, bearer token)
    ///
    /// Common scenarios:
    /// - SigV4 without AWS credentials: Cannot use SigV4
    /// - Bearer auth without a token provider: Cannot use bearer auth
    /// - Multiple auth schemes available: Use first one with BOTH implementation and identity
    /// </summary>
    [TestClass]
    public class AuthCredentialResolutionTests : RuntimePipelineTestBase
    {
        #region Resolving Auth and Credentials Tests

        /// <summary>
        /// Runtime supports both, identity providers for both, service lists sigv4 first.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void AuthCredentials_BothRuntimeAndIdentity_UsesFirstInList()
        {
            var serviceAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = "aws.auth#sigv4" },
                new AuthSchemeOption { SchemeId = "smithy.api#httpBearerAuth" }
            };

            // Both credentials and token provider available
            var context = CreateMockContextWithBothIdentities();
            var resolver = new TestAuthResolver(serviceAuthOptions);

            resolver.PreInvoke(context);

            Assert.IsNotNull(context.RequestContext.Identity, "Identity should be resolved");
            Assert.IsNotNull(context.RequestContext.Signer, "Signer should be set");
            // Should use sigv4 (first in service list)
            Assert.AreEqual("AWS4Signer", context.RequestContext.Signer.GetType().Name);
        }

        /// <summary>
        /// Only bearer identity available, so use bearer.
        /// </summary>
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void AuthCredentials_OnlyBearerIdentityAvailable_UsesBearer()
        {
            var serviceAuthOptions = new List<IAuthSchemeOption>
            {
                new AuthSchemeOption { SchemeId = "aws.auth#sigv4" },
                new AuthSchemeOption { SchemeId = "smithy.api#httpBearerAuth" }
            };

            // Only bearer token available, no AWS credentials
            var context = CreateMockContextBearerOnly();
            var resolver = new TestAuthResolver(serviceAuthOptions);

            resolver.PreInvoke(context);

            Assert.IsNotNull(context.RequestContext.Identity, "Identity should be resolved");
            Assert.IsNotNull(context.RequestContext.Signer, "Signer should be set");
            // Should skip sigv4 (no credentials) and use bearer
            Assert.AreEqual("BearerTokenSigner", context.RequestContext.Signer.GetType().Name);
        }

        /// <summary>
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
                new AuthSchemeOption { SchemeId = "aws.auth#sigv4" },
                new AuthSchemeOption { SchemeId = "smithy.api#httpBearerAuth" }
            };

            // No credentials or token provider
            var context = CreateMockContextNoIdentity();
            var resolver = new TestAuthResolver(serviceAuthOptions);

            // Should throw because no identity providers are available
            resolver.PreInvoke(context);
        }


        #endregion

        #region Helper Methods and Test Infrastructure

        private IExecutionContext CreateMockContextWithBothIdentities()
        {
            var originalRequest = new MockAmazonWebServiceRequest();
            var request = new Amazon.Runtime.Internal.DefaultRequest(originalRequest, "TestService");
            request.Endpoint = new Uri("https://test.amazonaws.com");

            var config = new MockClientConfig();
            // Provide both AWS credentials AND bearer token
            config.DefaultAWSCredentials = new BasicAWSCredentials("accessKey", "secretKey");
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

        private IExecutionContext CreateMockContextCredentialsOnly()
        {
            var originalRequest = new MockAmazonWebServiceRequest();
            var request = new Amazon.Runtime.Internal.DefaultRequest(originalRequest, "TestService");
            request.Endpoint = new Uri("https://test.amazonaws.com");

            var config = new MockClientConfig();
            // Only provide AWS credentials, no bearer token
            config.DefaultAWSCredentials = new BasicAWSCredentials("accessKey", "secretKey");
            config.AWSTokenProvider = null;

            var requestContext = new RequestContext(true, new NullSigner())
            {
                OriginalRequest = originalRequest,
                Request = request,
                ClientConfig = config
            };

            var responseContext = new ResponseContext();

            return new Amazon.Runtime.Internal.ExecutionContext(requestContext, responseContext);
        }

        private IExecutionContext CreateMockContextBearerOnly()
        {
            var originalRequest = new MockAmazonWebServiceRequest();
            var request = new Amazon.Runtime.Internal.DefaultRequest(originalRequest, "TestService");
            request.Endpoint = new Uri("https://test.amazonaws.com");

            var config = new MockClientConfig();
            // Only provide bearer token, no AWS credentials
            config.DefaultAWSCredentials = null;
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

        private IExecutionContext CreateMockContextNoIdentity()
        {
            var originalRequest = new MockAmazonWebServiceRequest();
            var request = new Amazon.Runtime.Internal.DefaultRequest(originalRequest, "TestService");
            request.Endpoint = new Uri("https://test.amazonaws.com");

            var config = new MockClientConfig();
            // No credentials or token provider
            config.DefaultAWSCredentials = null;
            config.AWSTokenProvider = null;

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
        /// The base class already handles checking for both runtime AND identity.
        /// </summary>
        private class TestAuthResolver : BaseAuthResolverHandler
        {
            private readonly List<IAuthSchemeOption> _authOptions;

            public TestAuthResolver(List<IAuthSchemeOption> authOptions)
            {
                _authOptions = authOptions ?? new List<IAuthSchemeOption>();
            }

            protected override List<IAuthSchemeOption> ResolveAuthOptions(IExecutionContext executionContext)
            {
                return _authOptions;
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
            private bool _allowCredentialResolution = true;

            public MockClientConfig() : base(new DummyDefaultConfigurationProvider())
            {
                RegionEndpoint = Amazon.RegionEndpoint.USEast1;
                // Use a custom identity resolver configuration that respects our test settings
                this.IdentityResolverConfiguration = new MockIdentityResolverConfiguration(this);
            }

            public void DisableCredentialResolution()
            {
                _allowCredentialResolution = false;
            }

            public bool ShouldResolveCredentials => _allowCredentialResolution;

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
                if (typeof(T) == typeof(AWSToken))
                {
                    return new MockAWSTokenResolver(_config);
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
                if (_config.ShouldResolveCredentials && _config.DefaultAWSCredentials != null)
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

        /// <summary>
        /// Mock AWS token resolver that only returns token when explicitly set.
        /// </summary>
        private class MockAWSTokenResolver : IIdentityResolver<AWSToken>
        {
            private readonly MockClientConfig _config;

            public MockAWSTokenResolver(MockClientConfig config)
            {
                _config = config;
            }

            public AWSToken ResolveIdentity(IClientConfig clientConfig)
            {
                // Only return token if token provider was explicitly set
                if (_config.AWSTokenProvider != null)
                {
#if BCL
                    if (_config.AWSTokenProvider.TryResolveToken(out var token))
                    {
                        return token;
                    }
#else
                    var result = _config.AWSTokenProvider.TryResolveTokenAsync().GetAwaiter().GetResult();
                    if (result.Success)
                    {
                        return result.Value;
                    }
#endif
                }
                return null;
            }

            public async Task<AWSToken> ResolveIdentityAsync(IClientConfig clientConfig, CancellationToken cancellationToken = default)
            {
                // Only return token if token provider was explicitly set
                if (_config.AWSTokenProvider != null)
                {
                    var result = await _config.AWSTokenProvider.TryResolveTokenAsync(cancellationToken).ConfigureAwait(false);
                    if (result.Success)
                    {
                        return result.Value;
                    }
                }
                return null;
            }

            BaseIdentity IIdentityResolver.ResolveIdentity(IClientConfig clientConfig) => ResolveIdentity(clientConfig);

            async Task<BaseIdentity> IIdentityResolver.ResolveIdentityAsync(IClientConfig clientConfig, CancellationToken cancellationToken)
                => await ResolveIdentityAsync(clientConfig, cancellationToken).ConfigureAwait(false);
        }

        #endregion
    }
}