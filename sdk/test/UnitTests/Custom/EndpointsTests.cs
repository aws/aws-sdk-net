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
using Amazon.Runtime.Endpoints;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class EndpointsTests
    {
        public class TestEndpointProvider : IEndpointProvider
        {
            public Endpoint ResolveEndpoint(EndpointParameters parameters)
            {
                return new Endpoint("https://localhost:7777");
            }
        }

        [TestMethod]
        [TestCategory("Endpoints")]
        public void EndpointResolverRetainsUriPortNumberWhenHttpIsEnforced()
        {
            var config = new MockClientConfig
            {
                EndpointProvider = new TestEndpointProvider(),
                UseHttp = true
            };
            var requestContext = new RequestContext(false, new NullSigner())
            {
                ClientConfig = config,
                Request = new DefaultRequest(new MockAmazonWebServiceRequest(), "test-service")
            };
            var executionContext = new ExecutionContext(requestContext, null);
            var resolver = new BaseEndpointResolver();
            resolver.ProcessRequestHandlers(executionContext);
            var endpoint = executionContext.RequestContext.Request.Endpoint;
            Assert.AreEqual(7777, endpoint.Port);
            Assert.AreEqual("http", endpoint.Scheme);
        }

        /// <summary>
        /// Asserts that UseHTTP=true does not manipulate 
        /// an explicit ServiceURL using HTTPS
        /// </summary>
        [TestMethod]
        [TestCategory("Endpoints")]
        public void EndpointResolverHttpsServiceURLVsUseHttp()
        {
            var serviceURL = "https://service.amazonaws.com";

            var config = new MockClientConfig
            {
                EndpointProvider = new TestEndpointProvider(),
                ServiceURL = serviceURL,
                UseHttp = true
            };
            var originalRequest = new MockAmazonWebServiceRequest();
            var requestContext = new RequestContext(false, new NullSigner())
            {
                ClientConfig = config,
                Request = new DefaultRequest(originalRequest, "test-service"),
                OriginalRequest = originalRequest,
            };

            var executionContext = new ExecutionContext(requestContext, null);
            var resolver = new BaseEndpointResolver();
            resolver.ProcessRequestHandlers(executionContext);
            var endpoint = executionContext.RequestContext.Request.Endpoint;

            Assert.AreEqual("https", endpoint.Scheme);
        }

        /// <summary>
        /// Asserts that ClientConfig can override AuthenticationRegion
        /// </summary>
        [TestMethod]
        [TestCategory("Endpoints")]
        public void ClientConfigOverridesAuthenticationRegion()
        {
            var config = new MockClientConfig
            {
                EndpointProvider = new TestEndpointProvider(),
                AuthenticationRegion = "authentication-region"
            };

            var requestContext = new RequestContext(false, new NullSigner())
            {
                ClientConfig = config,
                Request = new DefaultRequest(new MockAmazonWebServiceRequest(), "test-service")
            };

            var executionContext = new ExecutionContext(requestContext, null);
            var resolver = new BaseEndpointResolver();
            resolver.ProcessRequestHandlers(executionContext);

            Assert.AreEqual("authentication-region", executionContext.RequestContext.Request.AuthenticationRegion);
        }

        /// <summary>
        /// Counts how often the ruleset is evaluated and lets a test change the parameters between calls.
        /// </summary>
        private class CountingEndpointProvider : IEndpointProvider
        {
            public int Calls;

            public Endpoint ResolveEndpoint(EndpointParameters parameters)
            {
                Calls++;
                return new Endpoint("https://" + parameters["Region"] + ".localhost:7777", "{\"authSchemes\":[{\"name\":\"sigv4\"}]}", null);
            }
        }

        private class ParameterizedEndpointResolver : BaseEndpointResolver
        {
            public string Region = "us-east-1";

            protected override EndpointParameters MapEndpointsParameters(Amazon.Runtime.IRequestContext requestContext)
            {
                var parameters = new EndpointParameters();
                parameters["Region"] = Region;
                return parameters;
            }
        }

        private static ExecutionContext CreateExecutionContext(IEndpointProvider provider)
        {
            var config = new MockClientConfig { EndpointProvider = provider };
            var requestContext = new RequestContext(false, new NullSigner())
            {
                ClientConfig = config,
                Request = new DefaultRequest(new MockAmazonWebServiceRequest(), "test-service")
            };
            return new ExecutionContext(requestContext, null);
        }

        /// <summary>
        /// Resolving the endpoint twice for the same request (as the auth resolver and the endpoint resolver do for S3)
        /// evaluates the ruleset once and yields the same endpoint.
        /// </summary>
        [TestMethod]
        [TestCategory("Endpoints")]
        public void EndpointResolverReusesEndpointForUnchangedParameters()
        {
            var provider = new CountingEndpointProvider();
            var executionContext = CreateExecutionContext(provider);
            var resolver = new ParameterizedEndpointResolver();

            var first = resolver.GetEndpoint(executionContext);
            resolver.ProcessRequestHandlers(executionContext);

            Assert.AreEqual(1, provider.Calls);
            Assert.AreSame(first.Attributes, executionContext.RequestContext.Request.EndpointAttributes);
            Assert.AreEqual("https://us-east-1.localhost:7777/", executionContext.RequestContext.Request.Endpoint.ToString());
        }

        /// <summary>
        /// Changed parameters on the same request context resolve again.
        /// </summary>
        [TestMethod]
        [TestCategory("Endpoints")]
        public void EndpointResolverResolvesAgainWhenParametersChange()
        {
            var provider = new CountingEndpointProvider();
            var executionContext = CreateExecutionContext(provider);
            var resolver = new ParameterizedEndpointResolver();

            resolver.GetEndpoint(executionContext);
            resolver.Region = "eu-west-1";
            resolver.ProcessRequestHandlers(executionContext);

            Assert.AreEqual(2, provider.Calls);
            Assert.AreEqual("https://eu-west-1.localhost:7777/", executionContext.RequestContext.Request.Endpoint.ToString());
        }

        /// <summary>
        /// Resolvers that do not map parameters (the base implementation returns null) resolve on every call without failing.
        /// </summary>
        [TestMethod]
        [TestCategory("Endpoints")]
        public void EndpointResolverHandlesNullParameters()
        {
            var provider = new TestEndpointProvider();
            var executionContext = CreateExecutionContext(provider);
            var resolver = new BaseEndpointResolver();

            resolver.GetEndpoint(executionContext);
            resolver.ProcessRequestHandlers(executionContext);

            Assert.AreEqual("https://localhost:7777/", executionContext.RequestContext.Request.Endpoint.ToString());
        }

    }
}