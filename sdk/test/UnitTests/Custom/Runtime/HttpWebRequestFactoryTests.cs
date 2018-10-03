using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Threading;
using System.Net;

using Amazon.S3;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Util;
using Moq;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;


namespace AWSSDK.UnitTests
{
    [TestClass]
    public class HttpWebRequestFactoryTests
    {
        private readonly IFixture _fixture;

        private readonly Mock<ILogger> _loggerMock;
        private readonly Mock<IAmazonSecurityProtocolManager> _amazonSecurityPointManagerMock;

        public HttpWebRequestFactoryTests()
        {
            _fixture = new Fixture()
                .Customize(new AutoMoqCustomization());

            _loggerMock = _fixture.Freeze<Mock<ILogger>>();
            _amazonSecurityPointManagerMock = _fixture.Freeze<Mock<IAmazonSecurityProtocolManager>>();

            HttpWebRequestFactory.SetIsProtocolUpdated(false);
        }

        #region Http Request Basic Checks

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestHttpRequestSuccess()
        {
#if ASYNC_AWAIT
            _fixture.Customize<RequestContext>(cc =>
                cc.With(config => config.CancellationToken, CancellationToken.None)
            );
#endif
            TestHttpRequest(CancellationToken.None);

        }

#if ASYNC_AWAIT
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestHttpRequestCancellation()
        {
            var cts = new CancellationTokenSource();
            cts.Cancel();
            var token = cts.Token;
            try
            {
                TestHttpRequest(token);
            }
            catch (OperationCanceledException exception)
            {
                Assert.AreEqual(token, exception.CancellationToken);
                Assert.AreEqual(true, exception.CancellationToken.IsCancellationRequested);
                return;
            }

            Assert.Fail("An OperationCanceledException was not thrown");
        }
#endif

        public void TestHttpRequest(CancellationToken cancellationToken)
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
            var timeout = TimeSpan.FromSeconds(40);
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

            var requestContext = _fixture.Create<RequestContext>();

            request.ConfigureRequest(requestContext);

            Assert.IsInstanceOfType(httpWebRequest.Proxy, typeof(WebProxy));
            Assert.AreEqual(new Uri($"http://{proxyHost}:{proxyPort}"), ((WebProxy) httpWebRequest.Proxy).Address);
            Assert.AreEqual(proxyCreds, httpWebRequest.Proxy.Credentials);
            Assert.AreEqual(timeout.Seconds * 1000, httpWebRequest.Timeout);
            Assert.AreEqual(readWriteTimeout.Seconds * 1000, httpWebRequest.ReadWriteTimeout);
            Assert.AreEqual(maxIdleTime, httpWebRequest.ServicePoint.MaxIdleTime);
            Assert.AreEqual(useNagleAlgorithm, httpWebRequest.ServicePoint.UseNagleAlgorithm);

            var acceptHeader = _fixture.Create<string>();
            var contentTypeHeader = _fixture.Create<string>();
            var contentLength = _fixture.Create<int>();
            var userAgentHeader = _fixture.Create<string>();
            var date = DateTime.Now.ToUniversalTime();
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

            var testContent = _fixture.Create<string>();

            var sourceStream = new MemoryStream(Encoding.UTF8.GetBytes(testContent));
            var destinationStream = new MemoryStream();
            request.WriteToRequestBody(destinationStream, sourceStream, null, requestContext);

            var sourceContent = Encoding.UTF8.GetBytes(testContent);
            destinationStream = new MemoryStream();
            request.WriteToRequestBody(destinationStream, sourceContent, null);
        }

        #endregion

        #region TLS Resolution

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestTlsResolutionSecurityProtocolSystemDefault()
        {
            _amazonSecurityPointManagerMock.Setup(spm => spm.IsSecurityProtocolSystemDefault()).Returns(true);

            new HttpWebRequestFactory(_amazonSecurityPointManagerMock.Object);

            _amazonSecurityPointManagerMock.Verify(spm => spm.IsSecurityProtocolSystemDefault(), Times.Once);
            _amazonSecurityPointManagerMock.VerifyNoOtherCalls();
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestTlsResolutionSecurityProtocolChange()
        {
            _amazonSecurityPointManagerMock.Setup(spm => spm.IsSecurityProtocolSystemDefault()).Returns(false);

            new HttpWebRequestFactory(_amazonSecurityPointManagerMock.Object);

            _amazonSecurityPointManagerMock.Verify(spm => spm.IsSecurityProtocolSystemDefault(), Times.Once);
            _amazonSecurityPointManagerMock.Verify(spm => spm.UpdateProtocolsToSupported(), Times.Once);
            _amazonSecurityPointManagerMock.VerifyNoOtherCalls();
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestTlsResolutionSecurityProtocolChangeFailUnsupported()
        {
            _amazonSecurityPointManagerMock.Setup(spm => spm.IsSecurityProtocolSystemDefault()).Returns(false);
            _amazonSecurityPointManagerMock.Setup(spm => spm.UpdateProtocolsToSupported())
                .Throws<NotSupportedException>();
            var logMessage = "";
            _loggerMock.Setup(logger => logger.InfoFormat(It.IsAny<string>()))
                .Callback<string, object[]>((value, _) => logMessage = value);

            new HttpWebRequestFactory(_amazonSecurityPointManagerMock.Object, _loggerMock.Object);

            TlsModificationCommonErrorChecks();
            Assert.IsFalse(logMessage.StartsWith("Unexpected error"));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestTlsResolutionSecurityProtocolChangeFailUnexpected()
        {
            _amazonSecurityPointManagerMock.Setup(spm => spm.IsSecurityProtocolSystemDefault()).Returns(false);
            _amazonSecurityPointManagerMock.Setup(spm => spm.UpdateProtocolsToSupported())
                .Throws<Exception>();
            var logMessage = "";
            _loggerMock.Setup(logger => logger.InfoFormat(It.IsAny<string>()))
                .Callback<string, object[]>((value, _) => logMessage = value);

            new HttpWebRequestFactory(_amazonSecurityPointManagerMock.Object, _loggerMock.Object);

            TlsModificationCommonErrorChecks();
            Assert.IsTrue(logMessage.StartsWith("Unexpected error"));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestTlsResolutionSecurityProtocolAlreadyAttempted()
        {
            _amazonSecurityPointManagerMock.Setup(spm => spm.IsSecurityProtocolSystemDefault()).Returns(true);

            new HttpWebRequestFactory(_amazonSecurityPointManagerMock.Object);
            new HttpWebRequestFactory(_amazonSecurityPointManagerMock.Object);

            _amazonSecurityPointManagerMock.Verify(spm => spm.IsSecurityProtocolSystemDefault(), Times.Once);
            _amazonSecurityPointManagerMock.VerifyNoOtherCalls();
        }

        private void TlsModificationCommonErrorChecks()
        {
            _amazonSecurityPointManagerMock.Verify(spm => spm.IsSecurityProtocolSystemDefault(), Times.Once);
            _amazonSecurityPointManagerMock.Verify(spm => spm.UpdateProtocolsToSupported(), Times.Once);
            _loggerMock.Verify(logger => logger.InfoFormat(It.IsAny<string>()), Times.Once);
            _amazonSecurityPointManagerMock.VerifyNoOtherCalls();
            _loggerMock.VerifyNoOtherCalls();
        }

        #endregion
    }
}
