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
using System.Threading;
using System.Net;

using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class HttpWebRequestFactoryTests
    {
        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestHttpRequest()
        {
            IHttpRequestFactory<Stream> factory = new HttpWebRequestFactory();
            var request = factory.CreateHttpRequest(new Uri(@"https://testuri"));
            

            Assert.IsNotNull(request);
            request.Method = "PUT";
            var httpWebRequest = ((HttpRequest)request).Request;
            Assert.AreEqual("PUT", httpWebRequest.Method);

            var putObjectRequest = new PutObjectRequest
            {
                BucketName = "TestBucket",
                Key = "TestKey",
                ContentBody = "Test_Content",       
                
            };
            var proxyCreds = new System.Net.NetworkCredential("UserName","Password");
            var requestContext = new RequestContext(true)
            {
                ClientConfig = new AmazonS3Config
                {                    
                    ConnectionLimit = 10,
                    MaxIdleTime = 1000,
                    ProxyCredentials = proxyCreds,
                    ProxyHost = "proxyhost",
                    ProxyPort = 8080,
                    ReadWriteTimeout = TimeSpan.FromSeconds(20),
                    Timeout = TimeSpan.FromSeconds(40),
                    UseNagleAlgorithm = false,       
                },
                Marshaller = new PutObjectRequestMarshaller(),
                OriginalRequest = putObjectRequest,
                Request = new PutObjectRequestMarshaller().Marshall(putObjectRequest),
                Unmarshaller = new PutObjectResponseUnmarshaller()
            };

            request.ConfigureRequest(requestContext);
            
            Assert.IsInstanceOfType(httpWebRequest.Proxy, typeof(WebProxy));
            Assert.AreEqual(new Uri("http://proxyhost:8080"), ((WebProxy)httpWebRequest.Proxy).Address);
            Assert.AreEqual(proxyCreds, httpWebRequest.Proxy.Credentials);
            Assert.AreEqual(40000, httpWebRequest.Timeout);
            Assert.AreEqual(20000, httpWebRequest.ReadWriteTimeout);
            Assert.AreEqual(1000, httpWebRequest.ServicePoint.MaxIdleTime);
            Assert.AreEqual(false, httpWebRequest.ServicePoint.UseNagleAlgorithm);

            var date = DateTime.Now.ToUniversalTime();

            request.SetRequestHeaders(new Dictionary<string, string>
            {
                {"Accept","text/plain"},
                //{"Connection","Keep-Alive"},
                {"Content-Type","application/json"},
                {"Content-Length","100"},
                //{"Expect","100-continue"},
                {"User-Agent","awssdk"},
                {"Date",date.ToString("r")},
                //{"Host","s3.amazonaws.com"},
                {"Range","bytes=100-200"},
                {"Content-Range","bytes 100-300/*"},
                {"If-Modified-Since",date.ToString("r")},
                {"Expires",date.ToString("r")},
                {"NonStandardHeader","TestValue"},
            });

            Assert.AreEqual("text/plain", httpWebRequest.Accept);
            Assert.AreEqual("application/json", httpWebRequest.ContentType);
            Assert.AreEqual(100, httpWebRequest.ContentLength);
            Assert.AreEqual("awssdk", httpWebRequest.UserAgent);
            Assert.AreEqual(DateTime.Parse(date.ToString("r")), httpWebRequest.Date);
            Assert.AreEqual("testuri", httpWebRequest.Host);
            Assert.AreEqual(DateTime.Parse(date.ToString("r")), httpWebRequest.IfModifiedSince);
            Assert.AreEqual(DateTime.Parse(date.ToString("r")), DateTime.Parse(httpWebRequest.Headers["Expires"]));
            Assert.AreEqual("bytes=100-200", httpWebRequest.Headers["Range"]);
            Assert.AreEqual("bytes 100-300/*", httpWebRequest.Headers["Content-Range"]);
            Assert.AreEqual("TestValue", httpWebRequest.Headers["NonStandardHeader"]);

            var sourceStream = new MemoryStream(Encoding.UTF8.GetBytes("Test_Content"));
            var length = sourceStream.Length;
            var destinationStream = new MemoryStream();
            request.WriteToRequestBody(destinationStream, sourceStream, null, requestContext);

            var sourceContent = Encoding.UTF8.GetBytes("Test_Content");
            destinationStream = new MemoryStream();
            request.WriteToRequestBody(destinationStream, sourceContent, null);
        }

#if ASYNC_AWAIT
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestHttpRequestCancellation()
        {
            IHttpRequestFactory<Stream> factory = new HttpWebRequestFactory();
            var request = factory.CreateHttpRequest(new Uri(@"https://testuri"));
            request.Method = "PUT";
            var httpWebRequest = ((HttpRequest)request).Request;
            Assert.AreEqual("PUT", httpWebRequest.Method);

            var putObjectRequest = new PutObjectRequest
            {
                BucketName = "TestBucket",
                Key = "TestKey",
                ContentBody = "Test_Content",
            };
            var requestContext = new RequestContext(true)
            {
                ClientConfig = new AmazonS3Config
                {
                },
                Marshaller = new PutObjectRequestMarshaller(),
                OriginalRequest = putObjectRequest,
                Request = new PutObjectRequestMarshaller().Marshall(putObjectRequest),
                Unmarshaller = new PutObjectResponseUnmarshaller(),
            };

            request.ConfigureRequest(requestContext);

            var sourceStream = new MemoryStream(Encoding.UTF8.GetBytes("Test_Content"));
            var length = sourceStream.Length;
            var destinationStream = new MemoryStream();

            var cts = new CancellationTokenSource();
            cts.Cancel();           
            var token = cts.Token;
            requestContext.CancellationToken = token;
            try
            {
                request.WriteToRequestBody(destinationStream, sourceStream, null, requestContext);
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
    }
}
