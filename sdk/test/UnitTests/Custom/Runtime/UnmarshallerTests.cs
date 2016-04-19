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
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal;
using Amazon.Util;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class UnmarshallerTests : RuntimePipelineTestBase<Unmarshaller>
    {
        [ClassInitialize]
        public static void Initialize(TestContext t)
        {
            Handler = new Unmarshaller(true);
            RuntimePipeline.AddHandler(Handler);
        }

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestListBucketsResponseUnmarshalling()
        {
            Tester.Reset();

            var context = CreateTestContext();
            var request = new ListBucketsRequest();
            ((RequestContext)context.RequestContext).OriginalRequest = request;
            ((RequestContext)context.RequestContext).Request = new ListBucketsRequestMarshaller().Marshall(request);
            ((RequestContext)context.RequestContext).Unmarshaller = ListBucketsResponseUnmarshaller.Instance;

            var response = MockWebResponse.CreateFromResource("ListBucketsResponse.txt")
                as HttpWebResponse;
            context.ResponseContext.HttpResponse = new HttpWebRequestResponseData(response);

            RuntimePipeline.InvokeSync(context);

            Assert.AreEqual(1, Tester.CallCount);
            Assert.IsInstanceOfType(context.ResponseContext.Response, typeof(ListBucketsResponse));

            var listBucketsResponse = context.ResponseContext.Response as ListBucketsResponse;
            Assert.AreEqual(4, listBucketsResponse.Buckets.Count);
            Assert.AreEqual("-UUNhfhfx0J622sdKihbDfqEvIa94CkVQvcb4AGlNmRbpbInOTYXSA==", listBucketsResponse.ResponseMetadata.Metadata[HeaderKeys.XAmzCloudFrontIdHeader]);
        }

#if BCL45

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async45")]
        public async Task TestListBucketsResponseUnmarshallingAsync()
        {
            Tester.Reset();

            var context = CreateTestContext();
            var request = new ListBucketsRequest();
            ((RequestContext)context.RequestContext).OriginalRequest = request;
            ((RequestContext)context.RequestContext).Request = new ListBucketsRequestMarshaller().Marshall(request);
            ((RequestContext)context.RequestContext).Unmarshaller = ListBucketsResponseUnmarshaller.Instance;

            var response = MockWebResponse.CreateFromResource("ListBucketsResponse.txt")
                as HttpWebResponse;
            context.ResponseContext.HttpResponse = new HttpWebRequestResponseData(response);

            var listBucketsResponse = await RuntimePipeline.InvokeAsync<ListBucketsResponse>(context);

            Assert.AreEqual(1, Tester.CallCount);            
            Assert.IsInstanceOfType(context.ResponseContext.Response, typeof(ListBucketsResponse));
            Assert.AreEqual(4, listBucketsResponse.Buckets.Count);
        }

#elif !BCL45 && BCL

        [TestMethod][TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        [TestCategory(@"Runtime\Async35")]
        public void TestListBucketsResponseUnmarshallingAsync()
        {
            Tester.Reset();

            var context = CreateAsyncTestContext();
            var request = new ListBucketsRequest();
            ((RequestContext)context.RequestContext).OriginalRequest = request;
            ((RequestContext)context.RequestContext).Request = new ListBucketsRequestMarshaller().Marshall(request);
            ((RequestContext)context.RequestContext).Unmarshaller = ListBucketsResponseUnmarshaller.Instance;

            var response = MockWebResponse.CreateFromResource("ListBucketsResponse.txt")
                as HttpWebResponse;
            context.ResponseContext.HttpResponse = new HttpWebRequestResponseData(response);

            var asyncResult = RuntimePipeline.InvokeAsync(context);
            asyncResult.AsyncWaitHandle.WaitOne();

            Assert.AreEqual(1, Tester.CallCount);
            Assert.IsInstanceOfType(context.ResponseContext.Response, typeof(ListBucketsResponse));

            var listBucketsResponse = context.ResponseContext.Response as ListBucketsResponse;
            Assert.AreEqual(4, listBucketsResponse.Buckets.Count);
        }

#endif


        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Runtime")]
        public void TestHandlingHTMLErrorResponse()
        {
            string errorRepsonse = "<html><body>Error: <br> The Error Message</body></html>";
            var stream = new MemoryStream(UTF8Encoding.UTF8.GetBytes(errorRepsonse));
            var responseData = new FakeResponseData {StatusCode = HttpStatusCode.BadGateway };

            XmlUnmarshallerContext context = new XmlUnmarshallerContext(stream, false, responseData);

            var unmarshaller = new S3ErrorResponseUnmarshaller();
            S3ErrorResponse response = unmarshaller.Unmarshall(context);
            Assert.IsNotNull(response);
        }

        public class FakeResponseData : IWebResponseData
        {
            public long ContentLength { get; set; }

            public string ContentType { get; set; }

            public bool IsSuccessStatusCode { get; set; }

            public IHttpResponseBody ResponseBody { get; set; }

            public HttpStatusCode StatusCode { get; set; }

            public string[] GetHeaderNames()
            {
                return new string[0];
            }

            public string GetHeaderValue(string headerName)
            {
                return null;
            }

            public bool IsHeaderPresent(string headerName)
            {
                return false;
            }
        }
    }
}
