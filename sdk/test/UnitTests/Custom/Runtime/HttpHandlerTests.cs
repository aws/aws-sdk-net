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
using Amazon.Runtime.Internal;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class HttpHandlerTests
    {
        static object callbackSender = new object();

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestSuccessfulCall()
        {
            var factory = new MockHttpRequestFactory();
            var httpHandler = new HttpHandler<Stream>(factory, callbackSender);
            var runtimePipeline = new RuntimePipeline(httpHandler);

            var listBucketsRequest = new ListBucketsRequest();
            var executionContext = CreateExecutionContextForListBuckets();     

            httpHandler.InvokeSync(executionContext);

            Assert.IsNotNull(executionContext.ResponseContext.HttpResponse);            
            var httpRequest = factory.LastCreatedRequest;
            Assert.AreEqual("GET",httpRequest.Method);
            Assert.IsTrue(httpRequest.IsConfigureRequestCalled);
            Assert.IsTrue(httpRequest.IsSetRequestHeadersCalled);
            Assert.IsTrue(httpRequest.IsDisposed);
            Assert.IsFalse(httpRequest.IsAborted);            
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestErrorCall()
        {
            var factory = new MockHttpRequestFactory
            {
                GetResponseAction = () => { throw new IOException(); }
            };
            var httpHandler = new HttpHandler<Stream>(factory, callbackSender);
            var runtimePipeline = new RuntimePipeline(httpHandler);
            var executionContext = CreateExecutionContextForListBuckets();            

            Utils.AssertExceptionExpected(() =>
            {
                httpHandler.InvokeSync(executionContext);
            }, typeof(IOException));
            
            var httpRequest = factory.LastCreatedRequest;
            Assert.AreEqual("GET", httpRequest.Method);
            Assert.IsTrue(httpRequest.IsConfigureRequestCalled);
            Assert.IsTrue(httpRequest.IsSetRequestHeadersCalled);
            Assert.IsTrue(httpRequest.IsDisposed);            
        }

#if BCL45

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async45")]
        public async Task TestSuccessfulAsyncCall()
        {
            var factory = new MockHttpRequestFactory();
            var httpHandler = new HttpHandler<Stream>(factory, callbackSender);
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

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async45")]
        public async Task TestErrorAsyncCall()
        {
            var factory = new MockHttpRequestFactory
            {
                GetResponseAction = () => { throw new IOException(); }
            };
            var httpHandler = new HttpHandler<Stream>(factory, callbackSender);
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
        }

#elif !BCL45 && BCL

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async35")]
        public void TestSuccessfulAsyncCall()
        {
            var factory = new MockHttpRequestFactory();
            var httpHandler = new HttpHandler<Stream>(factory, callbackSender);
            var runtimePipeline = new RuntimePipeline(httpHandler);

            var listBucketsRequest = new ListBucketsRequest();
            var executionContext = CreateAsyncExecutionContextForListBuckets();

            var asyncResult = httpHandler.InvokeAsync(executionContext);
            asyncResult.AsyncWaitHandle.WaitOne();

            Assert.IsNull(executionContext.ResponseContext.AsyncResult.Exception);
            Assert.IsNotNull(executionContext.ResponseContext.HttpResponse);
            var httpRequest = factory.LastCreatedRequest;
            Assert.AreEqual("GET", httpRequest.Method);
            Assert.IsTrue(httpRequest.IsConfigureRequestCalled);
            Assert.IsTrue(httpRequest.IsSetRequestHeadersCalled);
            Assert.IsTrue(httpRequest.IsDisposed);
            Assert.IsFalse(httpRequest.IsAborted);   
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async35")]
        public void TestErrorAsyncCall()
        {
            var factory = new MockHttpRequestFactory
            {
                GetResponseAction = () => { throw new IOException(); }
            };
            var httpHandler = new HttpHandler<Stream>(factory, callbackSender);
            var runtimePipeline = new RuntimePipeline(httpHandler);
            var executionContext = CreateAsyncExecutionContextForListBuckets();

            var asyncResult = httpHandler.InvokeAsync(executionContext);
            asyncResult.AsyncWaitHandle.WaitOne();

            Assert.IsNotNull(executionContext.ResponseContext.AsyncResult.Exception);
            Assert.IsInstanceOfType(executionContext.ResponseContext.AsyncResult.Exception,typeof(IOException));

            var httpRequest = factory.LastCreatedRequest;
            Assert.AreEqual("GET", httpRequest.Method);
            Assert.IsTrue(httpRequest.IsConfigureRequestCalled);
            Assert.IsTrue(httpRequest.IsSetRequestHeadersCalled);
            Assert.IsTrue(httpRequest.IsDisposed);
        }
#endif

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
        public class MockHttpRequestFactory : IHttpRequestFactory<Stream>
        {            
            public Action GetResponseAction { get; set; }
            public Func<MockHttpRequest, HttpWebResponse> ResponseCreator { get; set; }

            public MockHttpRequest LastCreatedRequest { get; private set; }

            public IHttpRequest<Stream> CreateHttpRequest(Uri requestUri)
            {
                this.LastCreatedRequest = new MockHttpRequest(requestUri, this.GetResponseAction, this.ResponseCreator);
                return this.LastCreatedRequest;
            }

            public void Dispose()
            {                
            }
        }

        public class MockHttpRequest : IHttpRequest<Stream>
        {
            private Stream requestStream = null;

            public bool IsDisposed { get; set; }

            public bool IsAborted { get; set; }

            public bool IsConfigureRequestCalled { get; set; }

            public bool IsSetRequestHeadersCalled { get; set; }

            public bool IsGetRequestContentCalled { get; set; }
            
            public string Method { get; set; }

            public Uri RequestUri { get; set; }

            public Action GetResponseAction { get; set; }
            public Func<MockHttpRequest, HttpWebResponse> ResponseCreator { get; set; }

            public MockHttpRequest(Uri requestUri, Action action, Func<MockHttpRequest, HttpWebResponse> responseCreator = null)
            {
                this.RequestUri = requestUri;
                this.GetResponseAction = action;
                this.ResponseCreator = responseCreator ?? CreateResponse;
            }

            private HttpWebResponse CreateResponse(MockHttpRequest request)
            {
                // Extract the last segment of the URI, this is the custom URI 
                // sent by the unit tests.
                var resourceName = request.RequestUri.Host.Split('.').Last();
                var response =  MockWebResponse.CreateFromResource(resourceName);

                if (response.StatusCode >= HttpStatusCode.OK && response.StatusCode <= (HttpStatusCode)299)
                    return response;
                else                
                    throw new HttpErrorResponseException(new HttpWebRequestResponseData(response));                
            }
            
            public void ConfigureRequest(IRequestContext requestContext)
            {
                this.IsConfigureRequestCalled = true;
            }

            public void SetRequestHeaders(IDictionary<string, string> headers)
            {
                this.IsSetRequestHeadersCalled = true;
            }

            public Stream GetRequestContent()
            {
                this.IsGetRequestContentCalled = true;
                requestStream = new MemoryStream();
                return requestStream;
            }

            public Amazon.Runtime.Internal.Transform.IWebResponseData GetResponse()
            {
                if (this.GetResponseAction!=null)                
                    this.GetResponseAction();

                var response = ResponseCreator(this);
                return new HttpWebRequestResponseData(response);
            }

            public void WriteToRequestBody(Stream requestContent, Stream contentStream, 
                IDictionary<string, string> contentHeaders, IRequestContext requestContext)
            {
                Assert.IsNotNull(requestContent);
                Assert.IsNotNull(contentStream);
                Assert.IsNotNull(contentHeaders);
                Assert.IsNotNull(requestContext);
            }

            public void WriteToRequestBody(Stream requestContent, byte[] content, IDictionary<string, string> contentHeaders)
            {
                Assert.IsNotNull(requestContent);
                Assert.IsNotNull(content);
                Assert.IsNotNull(contentHeaders);
            }

            public void Abort()
            {
                this.IsAborted = true;
            }

#if BCL45
            public Task<Stream> GetRequestContentAsync()
            {
                return Task.FromResult<Stream>(new MemoryStream());
            }

            public Task<IWebResponseData> GetResponseAsync(System.Threading.CancellationToken cancellationToken)
            {
                if (this.GetResponseAction != null)
                    this.GetResponseAction();

                return Task.FromResult<IWebResponseData>(new HttpWebRequestResponseData(
                    MockWebResponse.CreateFromResource(this.RequestUri.Host)
                    as HttpWebResponse));
            }

#elif !BCL45 && BCL

            public IAsyncResult BeginGetRequestContent(AsyncCallback callback, object state)
            {
                var asyncResult = new RuntimeAsyncResult(callback, state);

                System.Threading.ThreadPool.QueueUserWorkItem((obj) =>
                {
                    callback(asyncResult);
                });

                return asyncResult;
            }

            public Stream EndGetRequestContent(IAsyncResult asyncResult)
            {
                requestStream = new MemoryStream();
                return requestStream;
            }

            public IAsyncResult BeginGetResponse(AsyncCallback callback, object state)
            {
                var asyncResult = new RuntimeAsyncResult(callback, state);

                System.Threading.ThreadPool.QueueUserWorkItem((obj) =>
                {
                    ((System.Threading.ManualResetEvent)asyncResult.AsyncWaitHandle).Set();
                    if (callback!=null)
                    {
                        callback(asyncResult);    
                    }                    
                });

                return asyncResult;
            }

            public Amazon.Runtime.Internal.Transform.IWebResponseData EndGetResponse(IAsyncResult asyncResult)
            {
                if (this.GetResponseAction != null)
                    this.GetResponseAction();

                return new HttpWebRequestResponseData(
                    MockWebResponse.CreateFromResource(this.RequestUri.Host)
                    as HttpWebResponse);
            }
#endif
            public void Dispose()
            {
                this.IsDisposed = true;
            }

            public Stream SetupProgressListeners(Stream originalStream, long progressUpdateInterval, object sender, EventHandler<StreamTransferProgressArgs> callback)
            {
                return originalStream;
            }
        }
    }
}
