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
using System.Net.Http;
using Amazon;
using Amazon.Runtime.Internal;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class HttpRequestMessageFactoryTests
    {
        [TestMethod]
        [TestCategory("Runtime")]
        public void Test()
        {
            var proxyCreds = new System.Net.NetworkCredential("UserName", "Password");
            var clientConfig = new AmazonS3Config
            {
                ConnectionLimit = 10,
                MaxIdleTime = 1000,
                ProxyCredentials = proxyCreds,
                ProxyHost = "proxyhost",
                ProxyPort = 8080,
                ReadWriteTimeout = TimeSpan.FromSeconds(20),
                Timeout = TimeSpan.FromSeconds(40),
                UseNagleAlgorithm = false,
                RegionEndpoint = RegionEndpoint.USEast1
            };

            var requestFactory = new HttpRequestMessageFactory(clientConfig);
            IHttpRequestFactory<HttpContent> factory = requestFactory;
            var request = factory.CreateHttpRequest(new Uri(@"https://testuri"));

            Assert.IsNotNull(request);
            request.Method = "PUT";
            var httpWebRequestMessage = ((HttpWebRequestMessage)request);
            var httpRequestMessage = httpWebRequestMessage.Request;

            Assert.AreEqual(TimeSpan.FromSeconds(40), httpWebRequestMessage.HttpClient.Timeout);
            Assert.AreEqual(false, httpWebRequestMessage.HttpClient.DefaultRequestHeaders.ExpectContinue);
            Assert.AreEqual(HttpMethod.Put, httpRequestMessage.Method);

            var putObjectRequest = new PutObjectRequest
            {
                BucketName = "TestBucket",
                Key = "TestKey",
                ContentBody = "Test_Content",

            };

            var requestContext = new RequestContext(true)
            {
                ClientConfig = clientConfig,
                Marshaller = new PutObjectRequestMarshaller(),
                OriginalRequest = putObjectRequest,
                Request = new PutObjectRequestMarshaller().Marshall(putObjectRequest),
                Unmarshaller = new PutObjectResponseUnmarshaller()
            };

            request.ConfigureRequest(requestContext);

            var date = DateTime.Now.ToUniversalTime();
            var headers = new Dictionary<string, string>
            {
                {"Accept","text/plain"},
                //{"Connection","Keep-Alive"},
                {"Content-Type","application/json"},
                {"Content-Length","100"},
                //{"Expect","100-continue"},
                {"User-Agent","awssdk"},
                {"Date",date.ToString("r")},
                {"Host","s3.amazonaws.com"},
                {"Range","bytes=100-200"},
                {"Content-Range","bytes 100-300/*"},
                {"If-Modified-Since",date.ToString("r")},
                {"Expires",date.ToString("r")},
                {"NonStandardHeader","TestValue"},
            };

            request.SetRequestHeaders(headers);

            var sourceStream = new MemoryStream(Encoding.UTF8.GetBytes("Test_Content"));
            var length = sourceStream.Length;
            var destinationStream = httpRequestMessage.Content;
            request.WriteToRequestBody(destinationStream, sourceStream, headers, requestContext);
            Assert.AreEqual(length, httpRequestMessage.Content.Headers.ContentLength);

            var sourceContent = Encoding.UTF8.GetBytes("Test_Content123");
            destinationStream = httpRequestMessage.Content;
            request.WriteToRequestBody(destinationStream, sourceContent, headers);
            Assert.AreEqual(sourceContent.Length, httpRequestMessage.Content.Headers.ContentLength);

            Assert.AreEqual("text/plain", httpRequestMessage.Headers.Accept.First().MediaType);
            Assert.AreEqual("application/json", httpRequestMessage.Content.Headers.ContentType.MediaType);
            Assert.AreEqual("awssdk", httpRequestMessage.Headers.UserAgent.First().Product.Name);
            Assert.AreEqual(DateTime.Parse(date.ToString("r")), httpRequestMessage.Headers.Date);
            Assert.AreEqual("s3.amazonaws.com", httpRequestMessage.Headers.Host);
            Assert.AreEqual(DateTime.Parse(date.ToString("r")), httpRequestMessage.Headers.IfModifiedSince);
            Assert.AreEqual(DateTime.Parse(date.ToString("r")), httpRequestMessage.Content.Headers.Expires);
            Assert.AreEqual("bytes", httpRequestMessage.Headers.Range.Unit);
            Assert.AreEqual(100, httpRequestMessage.Headers.Range.Ranges.First().From);
            Assert.AreEqual(200, httpRequestMessage.Headers.Range.Ranges.First().To);
            Assert.AreEqual("bytes", httpRequestMessage.Content.Headers.ContentRange.Unit);
            Assert.AreEqual(100, httpRequestMessage.Content.Headers.ContentRange.From);
            Assert.AreEqual(300, httpRequestMessage.Content.Headers.ContentRange.To);
            Assert.AreEqual("TestValue", httpRequestMessage.Headers.GetValues("NonStandardHeader").First());
        }
    }
}
