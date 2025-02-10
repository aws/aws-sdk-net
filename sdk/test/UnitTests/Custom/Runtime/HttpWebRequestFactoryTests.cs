using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Net;
using Amazon.Runtime;
using Amazon.S3;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using Moq;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;
using Amazon.Runtime.Telemetry;


namespace AWSSDK.UnitTests
{
    [TestClass]
    public class HttpWebRequestFactoryTests
    {
        private readonly IFixture _fixture;

        public HttpWebRequestFactoryTests()
        {
            _fixture = new Fixture()
                .Customize(new AutoMoqCustomization());

        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestHttpRequestSuccess()
        {
#if ASYNC_AWAIT
            _fixture.Customize<RequestContext>(cc =>
                cc.With(config => config.CancellationToken, CancellationToken.None)
            );

            _ = TestHttpRequest(CancellationToken.None);
#else
            TestHttpRequest(CancellationToken.None);
#endif
        }

#if ASYNC_AWAIT
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public async System.Threading.Tasks.Task TestHttpRequestCancellation()
        {
            var cts = new CancellationTokenSource();
            cts.Cancel();
            var token = cts.Token;
            try
            {
                await TestHttpRequest(token);
            }
            catch (OperationCanceledException exception)
            {
                Assert.AreEqual(token, exception.CancellationToken);
                Assert.AreEqual(true, exception.CancellationToken.IsCancellationRequested);
                return;
            }

            Assert.Fail("An OperationCanceledException was not thrown");
        }
        
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestHttpResponseCancellation()
        {
            var cts = new CancellationTokenSource();
            var token = cts.Token;
            try
            {
                var request = CreateHttpRequest(token, out var requestContext, TimeSpan.FromMilliseconds(1));

                var testContent = _fixture.Create<string>();
                var sourceStream = new MemoryStream(Encoding.UTF8.GetBytes(testContent));
                var destinationStream = new MemoryStream();
                request.WriteToRequestBody(destinationStream, sourceStream, null, requestContext);
                
                request.GetResponseAsync(token).GetAwaiter().GetResult();
            }
            catch (OperationCanceledException exception)
            {
                Assert.AreNotEqual(token, exception.CancellationToken);
                Assert.AreEqual(true, exception.CancellationToken.IsCancellationRequested);
                return;
            }

            Assert.Fail("An WebException was not thrown");
        }
#endif

#if BCL
        public async System.Threading.Tasks.Task TestHttpRequest(CancellationToken cancellationToken)
#else
        public void TestHttpRequest(CancellationToken cancellationToken)
#endif
        {
            var request = CreateHttpRequest(cancellationToken, out var requestContext);

            var testContent = _fixture.Create<string>();

            var sourceStream = new MemoryStream(Encoding.UTF8.GetBytes(testContent));
            var destinationStream = new MemoryStream();
#if BCL
            await request.WriteToRequestBodyAsync(destinationStream, sourceStream, null, requestContext);
#else
            request.WriteToRequestBody(destinationStream, sourceStream, null, requestContext);
#endif

            var sourceContent = Encoding.UTF8.GetBytes(testContent);
            destinationStream = new MemoryStream();
#if BCL
            await request.WriteToRequestBodyAsync(destinationStream, sourceContent, null, cancellationToken);
#else
            request.WriteToRequestBody(destinationStream, sourceContent, null);
#endif
        }

        private IHttpRequest<Stream> CreateHttpRequest(CancellationToken cancellationToken, out RequestContext requestContext, TimeSpan? requestTimeout = null)
        {
//Create Web Request
            var targetUri = _fixture.Create<Uri>();
            var sut = _fixture.Create<HttpWebRequestFactory>();
            var request = sut.CreateHttpRequest(targetUri);

            Assert.IsNotNull(request);

            //Target Method
            var targetMethod = "PUT";
            request.Method = targetMethod;
            var httpWebRequest = ((HttpRequest) request).Request;
            Assert.AreEqual(targetMethod, httpWebRequest.Method);

            // Request Context
            var proxyCreds = _fixture.Create<NetworkCredential>();
            var proxyHost = _fixture.Create<string>();
            var timeout = requestTimeout ?? TimeSpan.FromSeconds(40);
            var readWriteTimeout = TimeSpan.FromSeconds(20);
            var maxIdleTime = _fixture.Create<int>();
            var proxyPort = _fixture.Create<int>();
            var useNagleAlgorithm = _fixture.Create<bool>();

            _fixture.Customize<AmazonS3Config>(cc => cc
                .With(config => config.ProxyHost, proxyHost)
                .With(config => config.ProxyPort, proxyPort)
                .With(config => config.ProxyCredentials, proxyCreds)
                .With(config => config.Timeout, timeout)
                .With(config => config.ReadWriteTimeout, readWriteTimeout)
                .With(config => config.MaxIdleTime, maxIdleTime)
                .With(config => config.UseNagleAlgorithm, useNagleAlgorithm)
                .With(config => config.ConnectionLimit, 10)
                .With(config => config.ServiceURL, "")
                .With(config => config.TelemetryProvider, new DefaultTelemetryProvider())
            );

            _fixture.Customize<RequestContext>(cc => cc
                .FromFactory(() => new RequestContext(true, new NullSigner()))
#if ASYNC_AWAIT
                .With(context => context.CancellationToken, cancellationToken)
#endif
                .With(context => context.ClientConfig, _fixture.Create<AmazonS3Config>())
                .Without(context => context.CSMCallAttempt)
                .Without(context => context.CSMCallEvent)
            );

            requestContext = _fixture.Create<RequestContext>();

            request.ConfigureRequest(requestContext);

            Assert.IsInstanceOfType(httpWebRequest.Proxy, typeof(WebProxy));
            Assert.AreEqual(new Uri($"http://{proxyHost}:{proxyPort}"), ((WebProxy) httpWebRequest.Proxy).Address);
            Assert.AreEqual(proxyCreds, httpWebRequest.Proxy.Credentials);
            Assert.AreEqual(timeout.TotalMilliseconds, httpWebRequest.Timeout);
            Assert.AreEqual(readWriteTimeout.TotalMilliseconds, httpWebRequest.ReadWriteTimeout);
            Assert.AreEqual(maxIdleTime, httpWebRequest.ServicePoint.MaxIdleTime);
            Assert.AreEqual(useNagleAlgorithm, httpWebRequest.ServicePoint.UseNagleAlgorithm);

            var acceptHeader = _fixture.Create<string>();
            var contentTypeHeader = _fixture.Create<string>();
            var contentLength = 0;
            var userAgentHeader = _fixture.Create<string>();
            var date = DateTime.UtcNow;
            var rangeHeader = _fixture.Create<string>();
            var contentRangeHeader = _fixture.Create<string>();
            var nonStandardHeader = _fixture.Create<string>();

            request.SetRequestHeaders(new Dictionary<string, string>
            {
                {"Accept", acceptHeader},
                {"Content-Type", contentTypeHeader},
                {"Content-Length", contentLength.ToString()},
                {"User-Agent", userAgentHeader},
                {"Date", date.ToString("r")},
                {"Range", rangeHeader},
                {"Content-Range", contentRangeHeader},
                {"If-Modified-Since", date.ToString("r")},
                {"Expires", date.ToString("r")},
                {"NonStandardHeader", nonStandardHeader},
            });

            Assert.AreEqual(acceptHeader, httpWebRequest.Accept);
            Assert.AreEqual(contentTypeHeader, httpWebRequest.ContentType);
            Assert.AreEqual(contentLength, httpWebRequest.ContentLength);
            Assert.AreEqual(userAgentHeader, httpWebRequest.UserAgent);
            Assert.AreEqual(DateTime.Parse(date.ToString("r")), httpWebRequest.Date);
            Assert.AreEqual(targetUri.Host, httpWebRequest.Host);
            Assert.AreEqual(DateTime.Parse(date.ToString("r")), httpWebRequest.IfModifiedSince);
            Assert.AreEqual(DateTime.Parse(date.ToString("r")), DateTime.Parse(httpWebRequest.Headers["Expires"]));
            Assert.AreEqual(rangeHeader, httpWebRequest.Headers["Range"]);
            Assert.AreEqual(contentRangeHeader, httpWebRequest.Headers["Content-Range"]);
            Assert.AreEqual(nonStandardHeader, httpWebRequest.Headers["NonStandardHeader"]);
            return request;
        }

    }
}
