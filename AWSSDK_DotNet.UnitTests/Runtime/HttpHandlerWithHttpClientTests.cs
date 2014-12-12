using AWSSDK.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using System.IO;
using AWSSDK_DotNet35.UnitTests;
using Amazon.Runtime.Internal.Util;
using System.Net;

using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using System.Net.Http;
using Amazon.Runtime.Internal;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class HttpHandlerWithHttpClientTests
    {
        static object callbackSender = new object();

        [TestMethod]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async45")]
        public async Task TestSuccessfulAsyncCall()
        {
            var factory = new MockHttpRequestMessageFactory();
            var httpHandler = new HttpHandler<HttpContent>(factory, callbackSender);
            var runtimePipeline = new RuntimePipeline(httpHandler);

            var listBucketsRequest = new ListBucketsRequest();
            var executionContext = CreateExecutionContextForListBuckets();

            await httpHandler.InvokeAsync<ListBucketsResponse>(executionContext);

            Assert.IsNotNull(executionContext.ResponseContext.HttpResponse);
            var httpRequest = factory.LastCreatedRequest;
            Assert.AreEqual("GET", httpRequest.Method);
            Assert.IsTrue(httpRequest.IsConfigureRequestCalled);
            Assert.IsTrue(httpRequest.IsSetRequestHeadersCalled);
            Assert.IsTrue(httpRequest.IsDisposed);
            Assert.IsFalse(httpRequest.IsAborted);
        }

        [TestMethod]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async45")]
        public async Task TestErrorAsyncCall()
        {
            var factory = new MockHttpRequestMessageFactory
            {
                GetResponseAction = () => { throw new IOException(); }
            };
            var httpHandler = new HttpHandler<HttpContent>(factory, callbackSender);
            var runtimePipeline = new RuntimePipeline(httpHandler);
            var executionContext = CreateExecutionContextForListBuckets();

            await Utils.AssertExceptionExpectedAsync(() =>
            {
                return httpHandler.InvokeAsync<AmazonWebServiceResponse>(executionContext);
            }, typeof(IOException));

            var httpRequest = factory.LastCreatedRequest;
            Assert.AreEqual("GET", httpRequest.Method);
            Assert.IsTrue(httpRequest.IsConfigureRequestCalled);
            Assert.IsTrue(httpRequest.IsSetRequestHeadersCalled);
            Assert.IsTrue(httpRequest.IsDisposed);
            Assert.IsTrue(httpRequest.IsAborted);
        }

        private ExecutionContext CreateExecutionContextForListBuckets()
        {
            var listBucketsRequest = new ListBucketsRequest();
            var executionContext = new ExecutionContext(
                new RequestContext(true)
                {
                    ClientConfig = new AmazonS3Config(),
                    Marshaller = new ListBucketsRequestMarshaller(),                    
                    OriginalRequest = listBucketsRequest,
                    Request = new ListBucketsRequestMarshaller().Marshall(listBucketsRequest),
                    Unmarshaller = new ListBucketsResponseUnmarshaller()
                },
                new ResponseContext()
            );
            executionContext.RequestContext.Request.Endpoint = new Uri(@"http://ListBuckets");
            return executionContext;
        }

        private AsyncExecutionContext CreateAsyncExecutionContextForListBuckets()
        {
            var listBucketsRequest = new ListBucketsRequest();
            var executionContext = new AsyncExecutionContext(
                new AsyncRequestContext(true)
                {
                    ClientConfig = new AmazonS3Config(),
                    Marshaller = new ListBucketsRequestMarshaller(),
                    OriginalRequest = listBucketsRequest,
                    Request = new ListBucketsRequestMarshaller().Marshall(listBucketsRequest),
                    Unmarshaller = new ListBucketsResponseUnmarshaller()
                },
                new AsyncResponseContext()
            );
            executionContext.RequestContext.Request.Endpoint = new Uri(@"http://ListBuckets");
            return executionContext;
        }

        /// <summary>
        /// Not thread safe, initialize once for each test.
        /// </summary>
        public class MockHttpRequestMessageFactory : IHttpRequestFactory<HttpContent>
        {
            public Action GetResponseAction { get; set; }

            public MockHttpRequest LastCreatedRequest { get; private set; }

            public IHttpRequest<HttpContent> CreateHttpRequest(Uri requestUri)
            {
                this.LastCreatedRequest = new MockHttpRequest(requestUri, this.GetResponseAction);
                return this.LastCreatedRequest;
            }

            public void Dispose()
            {
            }
        }

        public class MockHttpRequest : IHttpRequest<HttpContent>
        {
            public bool IsDisposed { get; set; }

            public bool IsAborted { get; set; }

            public bool IsConfigureRequestCalled { get; set; }

            public bool IsSetRequestHeadersCalled { get; set; }

            public bool IsGetRequestContentCalled { get; set; }

            public string Method { get; set; }

            public Uri RequestUri { get; set; }

            public Action GetResponseAction { get; set; }

            public MockHttpRequest(Uri requestUri, Action action)
            {
                this.RequestUri = requestUri;
                this.GetResponseAction = action;
            }

            public void ConfigureRequest(IRequestContext requestContext)
            {
                this.IsConfigureRequestCalled = true;
            }

            public void SetRequestHeaders(IDictionary<string, string> headers)
            {
                this.IsSetRequestHeadersCalled = true;
            }

            public HttpContent GetRequestContent()
            {
                throw new NotSupportedException();
            }

            public Amazon.Runtime.Internal.Transform.IWebResponseData GetResponse()
            {
                throw new NotSupportedException();
            }

            public void WriteToRequestBody(HttpContent requestContent, Stream contentStream,
                IDictionary<string, string> contentHeaders, IRequestContext requestContext)
            {
                Assert.IsNotNull(requestContent);
                Assert.IsNotNull(contentStream);
                Assert.IsNotNull(contentHeaders);
                Assert.IsNotNull(requestContext);
            }

            public void WriteToRequestBody(HttpContent requestContent, byte[] content, IDictionary<string, string> contentHeaders)
            {
                Assert.IsNotNull(requestContent);
                Assert.IsNotNull(content);
                Assert.IsNotNull(contentHeaders);
            }

            public void Abort()
            {
                this.IsAborted = true;
            }

            public Task<HttpContent> GetRequestContentAsync()
            {
                this.IsGetRequestContentCalled = true;
                return Task.FromResult<HttpContent>(new StreamContent(new MemoryStream(), 1024));
            }

            public Task<IWebResponseData> GetResponseAsync(System.Threading.CancellationToken cancellationToken)
            {
                if (this.GetResponseAction != null)
                    this.GetResponseAction();

                return Task.FromResult<IWebResponseData>(new HttpWebRequestResponseData(
                    MockWebResponse.CreateFromResource(this.RequestUri.Host)
                    as HttpWebResponse));
            }

            public void Dispose()
            {
                this.IsDisposed = true;
            }
        }
    }
}
