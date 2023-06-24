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
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace AWSSDK.UnitTests.Runtime
{
    /// <summary>
    /// Tests <see cref="BearerTokenSigner"/> behavior
    /// </summary>
    [TestClass]
    public class BearerTokenSignerTests : RuntimePipelineTestBase
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SignThrowsExceptionIfSchemeIsHttp()
        { 
            var signer =  new BearerTokenSigner();

            var mockRequest = new Mock<IRequest>();
            mockRequest
                .Setup(x => x.Endpoint)
                .Returns(new Uri("http://non-secure-endpoint.com"));

            Exception exception = null;

            try
            {
                signer.Sign(
                    mockRequest.Object,
                    clientConfig: null,
                    metrics: null,
                    credentials: null);
            }
            catch (Exception e)
            {
                exception = e;
            }

            Assert.IsNotNull(exception);
            Assert.IsInstanceOfType(exception, typeof(AmazonClientException));
            Assert.IsTrue(exception.Message.Contains("Endpoint must not use 'http'"));
        }


#if AWS_ASYNC_API
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public async Task SignAsyncThrowsExceptionIfSchemeIsHttp()
        { 
            var signer =  new BearerTokenSigner();

            var mockRequest = new Mock<IRequest>();
            mockRequest
                .Setup(x => x.Endpoint)
                .Returns(new Uri("http://non-secure-endpoint.com"));

            Exception exception = null;

            try
            {
                await signer.SignAsync(
                    mockRequest.Object,
                    clientConfig: null,
                    metrics: null,
                    credentials: null);
            }
            catch (Exception e)
            {
                exception = e;
            }

            Assert.IsNotNull(exception);
            Assert.IsTrue(exception.Message.Contains("Endpoint must not use 'http'"));
        }
#endif

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void MinimalBearerAuthCase()
        {
            var fakeAuthToken = "mF_9.B5f-4.1JqM";

            var mockConfig = new MockClientConfig
            {
                AWSTokenProvider = new StaticTokenProvider(fakeAuthToken)
            };

            var pipeline = new RuntimePipeline(new MockHandler());
            pipeline.AddHandler(new Signer());
            pipeline.AddHandler(new CredentialsRetriever(new AnonymousAWSCredentials()));

            var context = CreateTestContext(new BearerTokenSigner(), null, mockConfig);
            pipeline.InvokeSync(context);

            AssertAuthorizationHeaderIs(context, fakeAuthToken);
        }

#if AWS_ASYNC_API
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public async Task MinimalBearerAuthCaseAsync()
        {
            var fakeAuthToken = "mF_9.B5f-4.1JqM";

            var mockConfig = new MockClientConfig
            {
                AWSTokenProvider = new StaticTokenProvider(fakeAuthToken)
            };

            var pipeline = new RuntimePipeline(new MockHandler());
            pipeline.AddHandler(new Signer());
            pipeline.AddHandler(new CredentialsRetriever(new AnonymousAWSCredentials()));

            var context = CreateTestContext(new BearerTokenSigner(), null, mockConfig);
            await pipeline.InvokeAsync<AmazonWebServiceResponse>(context);

            AssertAuthorizationHeaderIs(context, fakeAuthToken);
        }
#endif

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void LongerTokenCase()
        {
            var fakeAuthToken = "eW91J3JlIG5vdCBzdXBwb3NlZCB0byBkZWNvZGUgdGhpcyE";

            var mockConfig = new MockClientConfig
            {
                AWSTokenProvider = new StaticTokenProvider(fakeAuthToken)
            };

            var pipeline = new RuntimePipeline(new MockHandler());
            pipeline.AddHandler(new Signer());
            pipeline.AddHandler(new CredentialsRetriever(new AnonymousAWSCredentials()));

            var context = CreateTestContext(new BearerTokenSigner(), null, mockConfig);
            pipeline.InvokeSync(context);

            AssertAuthorizationHeaderIs(context, fakeAuthToken);
        }

#if AWS_ASYNC_API
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public async Task LongerTokenCaseAsync()
        {
            var fakeAuthToken = "eW91J3JlIG5vdCBzdXBwb3NlZCB0byBkZWNvZGUgdGhpcyE";

            var mockConfig = new MockClientConfig
            {
                AWSTokenProvider = new StaticTokenProvider(fakeAuthToken)
            };

            var pipeline = new RuntimePipeline(new MockHandler());
            pipeline.AddHandler(new Signer());
            pipeline.AddHandler(new CredentialsRetriever(new AnonymousAWSCredentials()));

            var context = CreateTestContext(new BearerTokenSigner(), null, mockConfig);
            await pipeline.InvokeAsync<AmazonWebServiceResponse>(context);

            AssertAuthorizationHeaderIs(context, fakeAuthToken);
        }
#endif

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SingerShouldOverrideExistingHeader()
        {
            var fakeAuthToken = "mF_9.B5f-4.1JqM";

            var mockConfig = new MockClientConfig
            {
                AWSTokenProvider = new StaticTokenProvider(fakeAuthToken)
            };

            var pipeline = new RuntimePipeline(new MockHandler());
            pipeline.AddHandler(new Signer());
            pipeline.AddHandler(new CredentialsRetriever(new AnonymousAWSCredentials()));

            var context = CreateTestContext(new BearerTokenSigner(), null, mockConfig);

            context.RequestContext.Request.Headers.Add("Authorization", "Bearer foo");
            AssertAuthorizationHeaderIs(context, "foo");

            pipeline.InvokeSync(context);

            AssertAuthorizationHeaderIs(context, fakeAuthToken);
        }

#if AWS_ASYNC_API
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public async Task SingerShouldOverrideExistingHeaderAsync()
        {
            var fakeAuthToken = "mF_9.B5f-4.1JqM";

            var mockConfig = new MockClientConfig
            {
                AWSTokenProvider = new StaticTokenProvider(fakeAuthToken)
            };

            var pipeline = new RuntimePipeline(new MockHandler());
            pipeline.AddHandler(new Signer());
            pipeline.AddHandler(new CredentialsRetriever(new AnonymousAWSCredentials()));

            var context = CreateTestContext(new BearerTokenSigner(), null, mockConfig);

            context.RequestContext.Request.Headers.Add("Authorization", "Bearer foo");
            AssertAuthorizationHeaderIs(context, "foo");

            await pipeline.InvokeAsync<AmazonWebServiceResponse>(context);

            AssertAuthorizationHeaderIs(context, fakeAuthToken);
        }
#endif

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void SingerRequiresAToken()
        {
            var mockConfig = new MockClientConfig
            {
                AWSTokenProvider = new AWSTokenProviderChain() // chain is empty
            };

            var pipeline = new RuntimePipeline(new MockHandler());
            pipeline.AddHandler(new Signer());
            pipeline.AddHandler(new CredentialsRetriever(new AnonymousAWSCredentials()));

            var context = CreateTestContext(new BearerTokenSigner(), null, mockConfig);

            Exception exception = null;

            try
            {
                pipeline.InvokeSync(context);
            }
            catch (Exception e)
            {
                exception = e;
            }

            Assert.IsNotNull(exception);
            Assert.IsInstanceOfType(exception, typeof(AmazonClientException));
            Assert.AreEqual(exception.Message, "No Token found.  Operation requires a Bearer token.");
        }

#if AWS_ASYNC_API
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public async Task SingerRequiresATokenAsync()
        {
            var mockConfig = new MockClientConfig
            {
                AWSTokenProvider = new AWSTokenProviderChain() // chain is empty
            };

            var pipeline = new RuntimePipeline(new MockHandler());
            pipeline.AddHandler(new Signer());
            pipeline.AddHandler(new CredentialsRetriever(new AnonymousAWSCredentials()));

            var context = CreateTestContext(new BearerTokenSigner(), null, mockConfig);

            Exception exception = null;

            try
            {
                await pipeline.InvokeAsync<AmazonWebServiceResponse>(context);
            }
            catch (Exception e)
            {
                exception = e;
            }

            Assert.IsNotNull(exception);
            Assert.IsInstanceOfType(exception, typeof(AmazonClientException));
            Assert.AreEqual(exception.Message, "No Token found.  Operation requires a Bearer token.");
        }
#endif


        private void AssertAuthorizationHeaderIs(IExecutionContext context, string expected)
        {
            if (!context.RequestContext.Request.Headers.TryGetValue("Authorization", out var authHeader))
                Assert.Fail("No Authorization header found");

            expected = expected.Replace("Bearer ", "");

            Assert.AreEqual($"Bearer {expected}", authHeader);
        }

    }
}
