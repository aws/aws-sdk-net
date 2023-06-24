using Amazon.RestJsonTest.Model;
using Amazon.RestJsonTest.Model.Internal.MarshallTransformations;
using AWSSDK_DotNet35.UnitTests.TestTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests.RestJsonTest.Net35
{
    [TestClass]
    public class RestJsonTests
    {
        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonTest")]
        public void TestBodyTest()
        {
            var request = new TestBodyRequest();
            request.TestConfig = new TestConfig();
            request.TestConfig.Timeout = 10;
            request.TestId = "t-12345";
            var marshaller = new TestBodyRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            Assert.IsTrue(internalRequest.Headers.ContainsKey("Content-Type"));
            Assert.IsTrue(internalRequest.Headers["Content-Type"] == "application/json");
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonTest")]
        public void TestPayloadNoParamsTest()
        {
            var request = new TestPayloadRequest();
            request.PayloadConfig = new PayloadConfig();
            var marshaller = new TestPayloadRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var body = System.Text.Encoding.Default.GetString(internalRequest.Content);
            Assert.AreEqual(body, "{}");
            Assert.IsTrue(internalRequest.Headers.ContainsKey("Content-Type"));
            Assert.IsTrue(internalRequest.Headers["Content-Type"] == "application/json");
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonTest")]
        public void TestPayloadTest()
        {
            var request = new TestPayloadRequest();
            request.PayloadConfig = new PayloadConfig();
            request.PayloadConfig.Data = 25;
            request.TestId = "t-12345";
            var marshaller = new TestPayloadRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            Assert.IsTrue(internalRequest.Headers.ContainsKey("Content-Type"));
            Assert.IsTrue(internalRequest.Headers["Content-Type"] == "application/json");
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonTest")]
        public void TestPayloadOptionalParamTest()
        {
            var request = new TestPayloadRequest();
            request.PayloadConfig = new PayloadConfig();
            request.TestId = "t-12345";
            var marshaller = new TestPayloadRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            var body = System.Text.Encoding.Default.GetString(internalRequest.Content);
            Assert.AreEqual(body, "{}");
            Assert.IsTrue(internalRequest.Headers.ContainsKey("Content-Type"));
            Assert.IsTrue(internalRequest.Headers["Content-Type"] == "application/json");
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonTest")]
        public void TestBlobPayloadTest()
        {
            var request = new TestBlobPayloadRequest();
            request.Data = new System.IO.MemoryStream(new byte[] { 1, 2, 3, 4 });
            request.ContentType = "image/jpg";
            var marshaller = new TestBlobPayloadRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            Assert.IsTrue(internalRequest.Headers.ContainsKey("Content-Type"));
            Assert.IsTrue(internalRequest.Headers["Content-Type"] == "image/jpg");
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonTest")]
        public void TestEmptyBlobPayloadTest()
        {
            var request = new TestBlobPayloadRequest();
            var marshaller = new TestBlobPayloadRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            Assert.IsFalse(internalRequest.Headers.ContainsKey("Content-Type"));
            Assert.IsNull(internalRequest.Content);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonTest")]
        public void TestNoPayloadTest()
        {
            var request = new NoPayloadRequest();
            var marshaller = new NoPayloadRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            Assert.IsFalse(internalRequest.Headers.ContainsKey("Content-Length"));
            Assert.IsFalse(internalRequest.Headers.ContainsKey("Content-Type"));
            Assert.IsNull(internalRequest.Content);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonTest")]
        public void TestNoPayloadTestOptionalParam()
        {
            var request = new NoPayloadRequest();
            request.TestId = "t-12345";
            var marshaller = new NoPayloadRequestMarshaller();
            var internalRequest = marshaller.Marshall(request);
            Assert.IsFalse(internalRequest.Headers.ContainsKey("Content-Length"));
            Assert.IsFalse(internalRequest.Headers.ContainsKey("Content-Type"));
            Assert.IsNull(internalRequest.Content);
        }
    }
}
