using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Amazon.Runtime;
using System.IO;
using AWSSDK_DotNet.UnitTests;
using Amazon.Runtime.Internal.Util;
using System.Net;
using System.Reflection;
using System.Net.Http;

using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class HttpHandlerTests
    {
        static object callbackSender = new object();

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
#if !BCL
        [Ignore]
#endif
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
#if !BCL
        [Ignore]
#endif
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

#if BCL
        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\AsyncNetFramework")]
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
        [TestCategory(@"Runtime\AsyncNetFramework")]
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

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestStoringContextAttributes()
        {
            var requestContext = new RequestContext(true, new NullSigner());

            requestContext.ContextAttributes["foo"] = "bar";
            Assert.AreEqual("bar", requestContext.ContextAttributes["foo"]);
        }
#endif

        private ExecutionContext CreateExecutionContextForListBuckets()
        {
            var listBucketsRequest = new ListBucketsRequest();       
            var executionContext = new ExecutionContext(
                new RequestContext(true, new NullSigner())
                {
                    ClientConfig = new AmazonS3Config(),
                    Marshaller = new ListBucketsRequestMarshaller(),
                    OriginalRequest = listBucketsRequest,
                    Request = new ListBucketsRequestMarshaller().Marshall(listBucketsRequest),
                    Unmarshaller = new ListBucketsResponseUnmarshaller()
                },
                new ResponseContext()
            );

            // Create and set the internal ServiceMetadata via reflection
            var serviceMetaData = Assembly.GetAssembly(executionContext.GetType()).CreateInstance("Amazon.Runtime.Internal.ServiceMetadata");
            executionContext.RequestContext.GetType().GetProperty("ServiceMetaData").SetValue(executionContext.RequestContext, serviceMetaData);

            executionContext.RequestContext.Request.Endpoint = new Uri(@"http://ListBuckets");
            return executionContext;
        }

        /// <summary>
        /// Not thread safe, initialize once for each test.
        /// </summary>
        public class MockHttpRequestFactory : IHttpRequestFactory<Stream>
        {    
            public Action GetResponseAction { get; set; }

#if BCL
            public Func<MockHttpRequest, HttpWebResponse> ResponseCreator { get; set; }
#else
            public Func<MockHttpRequest, HttpResponseMessage> ResponseCreator { get; set; }
#endif

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

            public Version HttpProtocolVersion { get; set; }

#if BCL
            public Func<MockHttpRequest, HttpWebResponse> ResponseCreator { get; set; }

            public MockHttpRequest(Uri requestUri, Action action, Func<MockHttpRequest, HttpWebResponse> responseCreator = null)
#else
            public Func<MockHttpRequest, HttpResponseMessage> ResponseCreator { get; set; }

            public MockHttpRequest(Uri requestUri, Action action, Func<MockHttpRequest, HttpResponseMessage> responseCreator = null)
#endif
            {
                this.RequestUri = requestUri;
                this.GetResponseAction = action;
                this.ResponseCreator = responseCreator ?? CreateResponse;
            }

#if BCL
            private HttpWebResponse CreateResponse(MockHttpRequest request)
#else
            private HttpResponseMessage CreateResponse(MockHttpRequest request)
#endif
            {
                // Extract the last segment of the URI, this is the custom URI 
                // sent by the unit tests.
                var resourceName = request.RequestUri.Host.Split('.').Last();
                var response =  MockWebResponse.CreateFromResource(resourceName);

                if (response.StatusCode >= HttpStatusCode.OK && response.StatusCode <= (HttpStatusCode)299)
                    return response;
                else                
#if BCL
                    throw new HttpErrorResponseException(new HttpWebRequestResponseData(response));
#else
                {
                    var instance = Activator.CreateInstance(
                               typeof(HttpClientResponseData),
                               BindingFlags.Instance | BindingFlags.NonPublic,
                               binder: null,
                               args: new[] { response },
                               culture: null
                           );
                    throw new HttpErrorResponseException(instance as HttpClientResponseData);
                }
#endif
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
#if BCL
                return new HttpWebRequestResponseData(response);
#else
                var instance = Activator.CreateInstance(
                               typeof(HttpClientResponseData),
                               BindingFlags.Instance | BindingFlags.NonPublic,
                               binder: null,
                               args: new[] { response },
                               culture: null
                           );
                return instance as HttpClientResponseData;
#endif
            }

            /// <inheritdoc/>
            public IHttpRequestStreamHandle SetupHttpRequestStreamPublisher(IDictionary<string, string> contentHeaders, IHttpRequestStreamPublisher publisher)
            {
                throw new NotImplementedException();
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

#if BCL
            public Task WriteToRequestBodyAsync(Stream requestContent, Stream contentStream,
                       IDictionary<string, string> contentHeaders, IRequestContext requestContext)
            {
                Assert.IsNotNull(requestContent);
                Assert.IsNotNull(contentStream);
                Assert.IsNotNull(contentHeaders);
                Assert.IsNotNull(requestContext);

                return Task.FromResult(0);
            }

            public Task WriteToRequestBodyAsync(Stream requestContent, byte[] content, IDictionary<string, string> contentHeaders, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
            {
                Assert.IsNotNull(requestContent);
                Assert.IsNotNull(content);
                Assert.IsNotNull(contentHeaders);

                return Task.FromResult(0);
            }

            public Task<Stream> GetRequestContentAsync()
            {
                return GetRequestContentAsync(System.Threading.CancellationToken.None);
            }

            public Task<Stream> GetRequestContentAsync(System.Threading.CancellationToken cancellationToken)
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
#endif

            public void Dispose()
            {
                this.IsDisposed = true;
            }

            public Stream SetupProgressListeners(Stream originalStream, long progressUpdateInterval, object sender, EventHandler<StreamTransferProgressArgs> callback)
            {
                return originalStream;
            }

#if !BCL
            public Task<Stream> GetRequestContentAsync()
            {
                throw new NotImplementedException();
            }

            public Task<IWebResponseData> GetResponseAsync(System.Threading.CancellationToken cancellationToken)
            {
                throw new NotImplementedException();
            }
#endif
        }
    }
}
