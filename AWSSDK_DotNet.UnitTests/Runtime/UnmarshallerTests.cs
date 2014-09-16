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

            var response = GetListBucketsResponse();
            context.ResponseContext.HttpResponse = new HttpWebRequestResponseData(response);

            RuntimePipeline.InvokeSync(context);

            Assert.AreEqual(1, Tester.CallCount);
            Assert.IsInstanceOfType(context.ResponseContext.Response, typeof(ListBucketsResponse));

            var listBucketsResponse = context.ResponseContext.Response as ListBucketsResponse;
            Assert.AreEqual(4, listBucketsResponse.Buckets.Count);
        }

        private static HttpWebResponse GetListBucketsResponse()
        {
            var body = @"<?xml version=""1.0"" encoding=""UTF-8""?>
<ListAllMyBucketsResult xmlns=""http://s3.amazonaws.com/doc/2006-03-01/"">
    <Owner>
        <ID>123456789</ID>
        <DisplayName>test-account</DisplayName>
    </Owner>
    <Buckets>
        <Bucket>
            <Name>Bucket1</Name>
            <CreationDate>2014-04-18T17:56:06.000Z</CreationDate>
        </Bucket>
        <Bucket>
            <Name>Bucket2</Name>
            <CreationDate>2014-06-05T23:18:53.000Z</CreationDate>
        </Bucket>
        <Bucket>
            <Name>Bucket3</Name>
            <CreationDate>2014-06-05T23:18:53.000Z</CreationDate>
        </Bucket>
        <Bucket>
            <Name>Bucket4</Name>
            <CreationDate>2014-06-05T23:18:53.000Z</CreationDate>
        </Bucket>
    </Buckets>
</ListAllMyBucketsResult>";
            var headers = new Dictionary<string, string>();
            headers["x-amz-request-id"] = "357B62B8E32948B9";
            headers["x-amz-id-2"] = "TFD+oMfRT5nVXm81tex2+Uh8R/VZRaztjPALzXknR7IC3RGfVPhpuiiHMtL0fFKF";
            headers["Content-Type"] = "application/xml";
            headers["Transfer-Encoding"] = "chunked";
            headers["Date"] = "Mon, 23 Jun 2014 03:31:12 GMT";
            headers["Server"] = "AmazonS3";

            var response = MockWebResponse.Create(HttpStatusCode.OK, headers, body)
                as HttpWebResponse;
            return response;
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

            var response = GetListBucketsResponse();
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

            var response = GetListBucketsResponse();
            context.ResponseContext.HttpResponse = new HttpWebRequestResponseData(response);

            var asyncResult = RuntimePipeline.InvokeAsync(context);
            asyncResult.AsyncWaitHandle.WaitOne();

            Assert.AreEqual(1, Tester.CallCount);
            Assert.IsInstanceOfType(context.ResponseContext.Response, typeof(ListBucketsResponse));

            var listBucketsResponse = context.ResponseContext.Response as ListBucketsResponse;
            Assert.AreEqual(4, listBucketsResponse.Buckets.Count);
        }

#endif
    }
}
