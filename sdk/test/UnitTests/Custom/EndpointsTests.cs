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
            var requestContext = new RequestContext(false, new NullSigner())
            {
                ClientConfig = config,
                Request = new DefaultRequest(new MockAmazonWebServiceRequest(), "test-service")
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
    }
}