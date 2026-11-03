using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Telemetry;
using Amazon.Runtime.Telemetry.Metrics;
using Amazon.Runtime.Telemetry.Metrics.NoOp;
using Amazon.Runtime.Telemetry.Tracing;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using AWSSDK_DotNet.UnitTests;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    [TestClass]
    [TestCategory("UnitTest")]
    [TestCategory("Runtime")]

    public class HttpHandlerTests
    {
        static object callbackSender = new object();

        [TestMethod]
#if !NETFRAMEWORK
        [Ignore]
#endif
        public void TestSuccessfulCall()
        {
            var factory = new MockHttpRequestFactory();
            var httpHandler = new HttpHandler<Stream>(factory, callbackSender);
            _ = new RuntimePipeline(httpHandler);
            
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

        [TestMethod]
#if !NETFRAMEWORK
        [Ignore]
#endif
        public void TestErrorCall()
        {
            var factory = new MockHttpRequestFactory
            {
                GetResponseAction = () => { throw new IOException(); }
            };
            var httpHandler = new HttpHandler<Stream>(factory, callbackSender);
            _ = new RuntimePipeline(httpHandler);
            
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

#if NETFRAMEWORK
        [TestMethod]
        [TestCategory(@"Runtime\AsyncNetFramework")]
        public async Task TestSuccessfulAsyncCall()
        {
            var factory = new MockHttpRequestFactory();
            var httpHandler = new HttpHandler<Stream>(factory, callbackSender);
            _ = new RuntimePipeline(httpHandler);
            
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
        [TestCategory(@"Runtime\AsyncNetFramework")]
        public async Task TestErrorAsyncCall()
        {
            var factory = new MockHttpRequestFactory
            {
                GetResponseAction = () => { throw new IOException(); }
            };
            var httpHandler = new HttpHandler<Stream>(factory, callbackSender);
            _ = new RuntimePipeline(httpHandler);
            
            var executionContext = CreateExecutionContextForListBuckets();
            await Assert.ThrowsExactlyAsync<IOException>(() => httpHandler.InvokeAsync<AmazonWebServiceResponse>(executionContext));
            
            var httpRequest = factory.LastCreatedRequest;
            Assert.AreEqual("GET", httpRequest.Method);
            Assert.IsTrue(httpRequest.IsConfigureRequestCalled);
            Assert.IsTrue(httpRequest.IsSetRequestHeadersCalled);
            Assert.IsTrue(httpRequest.IsDisposed);
        }

        [TestMethod]
        public void TestStoringContextAttributes()
        {
            var requestContext = new RequestContext(true, new NullSigner());

            requestContext.ContextAttributes["foo"] = "bar";
            Assert.AreEqual("bar", requestContext.ContextAttributes["foo"]);
        }
#endif

        [TestMethod]
        public void ComposeRequestUrl_MatchesComposeUrlAndReusesUnchangedUri()
        {
            var withPathResource = CreateRequest("https://bucket.s3.amazonaws.com", "/{Key+}");
            withPathResource.AddPathResource("{Key+}", "a/b+c:d");
            var withSubResource = CreateRequest("https://bucket.s3.amazonaws.com", "/key");
            withSubResource.AddSubResource("versionId", "v1");
            withSubResource.AddSubResource("acl");
            var withQuery = CreateRequest("https://sqs.us-east-1.amazonaws.com", "/");
            withQuery.UseQueryString = true;
            withQuery.Parameters["Prefix"] = "a b";
            var requests = new[]
            {
                CreateRequest("https://dynamodb.us-east-1.amazonaws.com", "/"),
                CreateRequest("https://dynamodb.us-east-1.amazonaws.com", "/"),
                CreateRequest("https://dynamodb.us-west-2.amazonaws.com", "/"),
                CreateRequest("https://bucket.s3.amazonaws.com", null),
                withPathResource,
                withSubResource,
                withQuery,
            };

            var handler = new HttpHandler<Stream>(new MockHttpRequestFactory(), callbackSender);
            Uri previous = null;
            foreach (var request in requests)
            {
                var expected = AmazonServiceClient.ComposeUrl(request);
                var actual = handler.ComposeRequestUrl(request);
                Assert.AreEqual(expected.OriginalString, actual.OriginalString);
                Assert.AreEqual(expected.AbsoluteUri, actual.AbsoluteUri);
#if !NETFRAMEWORK
                Assert.AreEqual(previous?.OriginalString == expected.OriginalString, ReferenceEquals(previous, actual));
#endif
                previous = actual;
            }
        }

#if NET8_0_OR_GREATER
        [TestMethod]
        public void ComposeRequestUrl_HonorsCanonicalizationSettingChanges()
        {
            var original = AWSConfigs.DisableDangerousDisablePathAndQueryCanonicalization;
            try
            {
                var handler = new HttpHandler<Stream>(new MockHttpRequestFactory(), callbackSender);
                var request = CreateRequest("https://bucket.s3.amazonaws.com", "/foo/../bar.txt");
                foreach (var disable in new[] { false, true, false })
                {
                    AWSConfigs.DisableDangerousDisablePathAndQueryCanonicalization = disable;
                    Assert.AreEqual(disable ? "/bar.txt" : "/foo/../bar.txt", handler.ComposeRequestUrl(request).AbsolutePath);
                }

                // The flag read for the cache key is the one used to parse, even if the setting changes in between.
                AWSConfigs.DisableDangerousDisablePathAndQueryCanonicalization = true;
                Assert.AreEqual("/foo/../bar.txt", AmazonServiceClient.CreateRequestUri("https://bucket.s3.amazonaws.com/foo/../bar.txt", false).AbsolutePath);
            }
            finally
            {
                AWSConfigs.DisableDangerousDisablePathAndQueryCanonicalization = original;
            }
        }
#endif

        [TestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public void RecordsRequestSizeOnlyWhenRequestMetricsEnabled(bool enableMetrics)
        {
            var httpHandler = new HttpHandler<Stream>(CreateListBucketsFactory(), callbackSender);
            _ = new RuntimePipeline(httpHandler);
            var executionContext = CreatePutContentContext(enableMetrics);
            httpHandler.InvokeSync(executionContext);
            AssertRequestSize(executionContext, enableMetrics);
        }

#if NETFRAMEWORK
        [TestMethod]
        [DataRow(true)]
        [DataRow(false)]
        public async Task RecordsRequestSizeOnlyWhenRequestMetricsEnabledAsync(bool enableMetrics)
        {
            var httpHandler = new HttpHandler<Stream>(CreateListBucketsFactory(), callbackSender);
            _ = new RuntimePipeline(httpHandler);
            var executionContext = CreatePutContentContext(enableMetrics);
            await httpHandler.InvokeAsync<ListBucketsResponse>(executionContext);
            AssertRequestSize(executionContext, enableMetrics);
        }
#endif

        [TestMethod]
        [DataRow(true, false)]
        [DataRow(false, true)]
        [DataRow(false, false)]
        public void RecordsHttpTelemetryUnlessBothProvidersAreNoOp(bool customMeter, bool customTracer)
        {
            var meterProvider = new RecordingMeterProvider();
            var tracerProvider = new RecordingTracerProvider();
            var config = new AmazonS3Config { TelemetryProvider = new DefaultTelemetryProvider() };
            if (customMeter)
                config.TelemetryProvider.RegisterMeterProvider(meterProvider);
            if (customTracer)
                config.TelemetryProvider.RegisterTracerProvider(tracerProvider);

            var httpHandler = new HttpHandler<Stream>(CreateListBucketsFactory(), callbackSender);
            _ = new RuntimePipeline(httpHandler);
            var executionContext = CreateExecutionContextForListBuckets(config);
            httpHandler.InvokeSync(executionContext);

            Assert.AreEqual(HttpStatusCode.OK, executionContext.ResponseContext.HttpResponse.StatusCode);
            CollectionAssert.AreEqual(customMeter ? new[] { 25L } : new long[0], meterProvider.BytesReceived);
            if (customTracer)
            {
                var span = tracerProvider.Spans.Single(s => s.Name == TelemetryConstants.HTTPRequestSpanName);
                Assert.AreEqual(200, span.Attributes[TelemetryConstants.HTTPStatusCodeAttributeKey]);
                Assert.AreEqual(25L, span.Attributes[TelemetryConstants.HTTPResponseContentLengthAttributeKey]);
            }
        }

#if !NETFRAMEWORK
        [TestMethod]
        public void HttpClientResponseData_CopiesFirstValueOfEachHeader()
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK) { Content = new ByteArrayContent(Encoding.UTF8.GetBytes("{\"a\":1}")) };
            response.Headers.TryAddWithoutValidation("x-amzn-RequestId", "request-id-1");
            response.Headers.TryAddWithoutValidation("x-multi", new[] { "first", "second" });
            response.Headers.TryAddWithoutValidation("x-empty", "");
            response.Headers.TryAddWithoutValidation("Cache-Control", "no-cache,   max-age=0");
            response.Headers.TryAddWithoutValidation("Age", "not-a-number");
            response.Headers.TryAddWithoutValidation("x-amz-dup", "from-response");
            response.Content.Headers.TryAddWithoutValidation("Content-Type", "application/json; charset=utf-8");
            response.Content.Headers.TryAddWithoutValidation("Last-Modified", "garbage");
            response.Content.Headers.TryAddWithoutValidation("X-Amz-Dup", "from-content");

            var data = new HttpClientResponseData(response);

            var expected = new[]
            {
                ("x-amzn-RequestId", "request-id-1"),
                ("x-multi", "first"),
                ("x-empty", ""),
                ("Cache-Control", "no-cache, max-age=0"),
                ("Age", "not-a-number"),
                ("x-amz-dup", "from-response"),
                ("Content-Type", "application/json; charset=utf-8"),
                ("Last-Modified", "garbage"),
                ("Content-Length", "7"),
            };
            CollectionAssert.AreEqual(expected.Select(h => h.Item1).ToArray(), data.GetHeaderNames());
            foreach (var (name, value) in expected)
            {
                Assert.AreEqual(value, data.GetHeaderValue(name.ToUpperInvariant()), name);
                Assert.IsTrue(data.IsHeaderPresent(name.ToLowerInvariant()), name);
            }
            Assert.AreEqual("application/json", data.ContentType);
            Assert.AreEqual(7, data.ContentLength);
            Assert.IsFalse(data.IsHeaderPresent("x-missing"));
            Assert.IsFalse(data.IsHeaderPresent(null));
        }

        [TestMethod]
        public void HttpClientResponseData_EventStreamConstructorHasNoHeaders()
        {
            var data = new HttpClientResponseData(new Dictionary<string, Amazon.Runtime.EventStreams.IEventStreamHeader>());
            Assert.IsNull(data.GetHeaderNames());
            Assert.AreEqual(string.Empty, data.GetHeaderValue("x-amzn-RequestId"));
            Assert.IsFalse(data.IsHeaderPresent("x-amzn-RequestId"));
        }

        [TestMethod]
        public void HttpWebRequestMessage_ReusesStandardHttpMethods()
        {
            foreach (var method in new[] { HttpMethod.Get, HttpMethod.Post, HttpMethod.Put, HttpMethod.Delete, HttpMethod.Head, HttpMethod.Options })
                Assert.AreSame(method, HttpWebRequestMessage.GetHttpMethod(method.Method));
            foreach (var method in new[] { "PATCH", "get" })
                Assert.AreEqual(new HttpMethod(method).Method, HttpWebRequestMessage.GetHttpMethod(method).Method);

            using (var message = new HttpWebRequestMessage(new HttpClient(), new Uri("https://example.com"), new MockClientConfig()))
            {
                message.Method = "POST";
                Assert.AreSame(HttpMethod.Post, message.Request.Method);
                Assert.AreEqual("POST", message.Method);
            }
        }
#endif

        private static IRequest CreateRequest(string endpoint, string resourcePath)
        {
            return new DefaultRequest(new MockAmazonWebServiceRequest(), "TestService")
            {
                Endpoint = new Uri(endpoint),
                ResourcePath = resourcePath
            };
        }

        private ExecutionContext CreatePutContentContext(bool enableMetrics)
        {
            var executionContext = CreateExecutionContextForListBuckets(enableMetrics: enableMetrics);
            executionContext.RequestContext.Request.HttpMethod = "PUT";
            executionContext.RequestContext.Request.Content = Encoding.UTF8.GetBytes("payload");
            return executionContext;
        }

        private static void AssertRequestSize(IExecutionContext executionContext, bool enableMetrics)
        {
            var properties = executionContext.RequestContext.Metrics.Properties;
            Assert.AreEqual(enableMetrics, properties.ContainsKey(Metric.RequestSize));
            if (enableMetrics)
                Assert.AreEqual(7, properties[Metric.RequestSize].Single());
        }

        internal static MockHttpRequestFactory CreateListBucketsFactory()
        {
            return new MockHttpRequestFactory
            {
#if NETFRAMEWORK
                ResponseCreator = _ => MockWebResponse.Create(HttpStatusCode.OK, new Dictionary<string, string> { { "Content-Length", "25" } }, "<ListAllMyBucketsResult/>")
#else
                ResponseCreator = _ => new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new ByteArrayContent(Encoding.UTF8.GetBytes("<ListAllMyBucketsResult/>"))
                }
#endif
            };
        }

        private class RecordingMeterProvider : MeterProvider
        {
            public List<long> BytesReceived { get; } = new List<long>();
            public override Meter GetMeter(string scope, Attributes attributes = null) => new RecordingMeter(this);

            private class RecordingMeter : NoOpMeter
            {
                private readonly RecordingMeterProvider _provider;
                public RecordingMeter(RecordingMeterProvider provider) { _provider = provider; }
                public override MonotonicCounter<T> CreateMonotonicCounter<T>(string name, string units = null, string description = null)
                    => name == TelemetryConstants.HTTPBytesReceivedMetricName ? new BytesCounter<T>(_provider) : base.CreateMonotonicCounter<T>(name, units, description);
            }

            private class BytesCounter<T> : MonotonicCounter<T> where T : struct
            {
                private readonly RecordingMeterProvider _provider;
                public BytesCounter(RecordingMeterProvider provider) { _provider = provider; }
                public override void Add(T value, Attributes attributes = null) => _provider.BytesReceived.Add(Convert.ToInt64(value));
            }
        }

        private class RecordingTracerProvider : TracerProvider
        {
            public List<RecordingSpan> Spans { get; } = new List<RecordingSpan>();
            public override Tracer GetTracer(string scope) => new RecordingTracer(this);

            private class RecordingTracer : Tracer
            {
                private readonly RecordingTracerProvider _provider;
                public RecordingTracer(RecordingTracerProvider provider) { _provider = provider; }
                public override TraceSpan CreateSpan(string name, Attributes initialAttributes = null, SpanKind spanKind = SpanKind.INTERNAL, SpanContext parentContext = null)
                {
                    var span = new RecordingSpan(name);
                    _provider.Spans.Add(span);
                    return span;
                }
            }
        }

        private class RecordingSpan : TraceSpan
        {
            public RecordingSpan(string name) { Name = name; }
            public Dictionary<string, object> Attributes { get; } = new Dictionary<string, object>();
            public override void SetAttribute(string key, object value) => Attributes[key] = value;
            public override void EmitEvent(string name, Attributes attributes = null) { }
            public override void SetStatus(SpanStatus status) { }
            public override void RecordException(Exception exception, Attributes attributes = null) { }
            public override void End() { }
        }

        private ExecutionContext CreateExecutionContextForListBuckets(IClientConfig config = null, bool enableMetrics = true)
        {
            var listBucketsRequest = new ListBucketsRequest();       
            var executionContext = new ExecutionContext(
                new RequestContext(enableMetrics, new NullSigner())
                {
                    ClientConfig = config ?? new AmazonS3Config(),
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

#if NETFRAMEWORK
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

#if NETFRAMEWORK
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

#if NETFRAMEWORK
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
#if NETFRAMEWORK
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
#if NETFRAMEWORK
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

#if !NETFRAMEWORK
            public void WriteToRequestBody(Stream requestContent, ReadOnlyMemory<byte> content, IDictionary<string, string> contentHeaders)
            {
                Assert.IsNotNull(requestContent);
                Assert.IsFalse(content.IsEmpty);
                Assert.IsNotNull(contentHeaders);
            }
#endif

            public void Abort()
            {
                this.IsAborted = true;
            }

#if NETFRAMEWORK
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

#if !NETFRAMEWORK
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
