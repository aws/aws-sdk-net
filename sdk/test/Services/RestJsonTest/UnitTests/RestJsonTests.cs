using Amazon.RestJsonTest;
using Amazon.RestJsonTest.Model;
using Amazon.RestJsonTest.Model.Internal.MarshallTransformations;
using Amazon.Runtime.Internal;
using Amazon.Util;
using AWSSDK.UnitTests.Mocking;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AWSSDK.UnitTests.RestJsonTest
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

            var internalRequest = TestUtils.RunMockRequest(request, TestBodyRequestMarshaller.Instance, new AmazonRestJsonTestConfig());

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

            var internalRequest = TestUtils.RunMockRequest(request, TestPayloadRequestMarshaller.Instance, new AmazonRestJsonTestConfig());
            var body = Encoding.Default.GetString(internalRequest.Content);

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

            var internalRequest = TestUtils.RunMockRequest(request, TestPayloadRequestMarshaller.Instance, new AmazonRestJsonTestConfig());

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

            var internalRequest = TestUtils.RunMockRequest(request, TestPayloadRequestMarshaller.Instance, new AmazonRestJsonTestConfig());
            var body = Encoding.Default.GetString(internalRequest.Content);

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
            request.Data = new MemoryStream(new byte[] { 1, 2, 3, 4 });
            request.ContentType = "image/jpg";

            var internalRequest = TestUtils.RunMockRequest(request, TestBlobPayloadRequestMarshaller.Instance, new AmazonRestJsonTestConfig());

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

            var internalRequest = TestUtils.RunMockRequest(request, TestBlobPayloadRequestMarshaller.Instance, new AmazonRestJsonTestConfig());

            Assert.IsTrue(internalRequest.Headers.ContainsKey("Content-Type"));
            Assert.IsNull(internalRequest.Content);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonTest")]
        public void TestNoPayloadTest()
        {
            var request = new NoPayloadRequest();

            var internalRequest = TestUtils.RunMockRequest(request, NoPayloadRequestMarshaller.Instance, new AmazonRestJsonTestConfig());

            Assert.IsFalse(internalRequest.Headers.ContainsKey("Content-Length"));
            Assert.IsFalse(internalRequest.Headers.ContainsKey("Content-Type"));
            Assert.IsNull(internalRequest.Content);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonTest")]
        public void TestNoPayloadPutTest()
        {
            var request = new NoPayloadPostRequest();

            // Unlike NoPayloadRequest above which uses GET, this uses POST so it could theoretically have a body
            var internalRequest = TestUtils.RunMockRequest(request, NoPayloadPostRequestMarshaller.Instance, new AmazonRestJsonTestConfig());

            // But it desn't so ensure that the content related headers aren't set
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

            var internalRequest = TestUtils.RunMockRequest(request, NoPayloadRequestMarshaller.Instance, new AmazonRestJsonTestConfig());

            Assert.IsFalse(internalRequest.Headers.ContainsKey("Content-Length"));
            Assert.IsFalse(internalRequest.Headers.ContainsKey("Content-Type"));
            Assert.IsNull(internalRequest.Content);
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonTest")]
        public void TestStaticEndpointHostTrait()
        {
            var request = new StaticOpRequest
            {
                Name = "myname"
            };

            var internalRequest = TestUtils.RunMockRequest(request, StaticOpRequestMarshaller.Instance, new AmazonRestJsonTestConfig());

            Assert.AreEqual(internalRequest.HostPrefix, "data-");
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonTest")]
        public void TestMemberRefEndpointHostTrait()
        {
            var request = new MemberRefOpRequest
            {
                Name = "myname"
            };

            var internalRequest = TestUtils.RunMockRequest(request, MemberRefOpRequestMarshaller.Instance, new AmazonRestJsonTestConfig());

            Assert.AreEqual(internalRequest.HostPrefix, "foo-myname.");
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonTest")]
        public void TestQueryStringEscaping()
        {
            var request = new QueryStringEscapingRequest
            {
                QueryString = " %:/?#[]@!$&'()*+,;=😹"
            };

            var internalRequest = TestUtils.RunMockRequest(request, QueryStringEscapingRequestMarshaller.Instance, new AmazonRestJsonTestConfig());

            Assert.AreEqual("String=%20%25%3A%2F%3F%23%5B%5D%40%21%24%26%27%28%29%2A%2B%2C%3B%3D%F0%9F%98%B9", ToQueryString(internalRequest));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonTest")]
        public void TestQueryStringList()
        {
            var request = new QueryStringListRequest
            {
                QueryStringList = new List<string> { "one", "two", "three", "fou/r" } 
            };

            var internalRequest = TestUtils.RunMockRequest(request, QueryStringListRequestMarshaller.Instance, new AmazonRestJsonTestConfig());

            Assert.AreEqual("item=fou%2Fr&item=one&item=three&item=two", ToQueryString(internalRequest));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonTest")]
        public void TestQueryIntegerList()
        {
            var marshaller = new QueryIntegerListRequestMarshaller();
            var request = new QueryIntegerListRequest
            {
                QueryIntegerList = new List<int> { 1, 2, 3, 4 }
            };

            var internalRequest = TestUtils.RunMockRequest(request, QueryIntegerListRequestMarshaller.Instance, new AmazonRestJsonTestConfig());

            Assert.AreEqual("item=1&item=2&item=3&item=4", ToQueryString(internalRequest));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonTest")]
        public void TestQueryTimestampList()
        {
            var request = new QueryTimestampListRequest
            {
                QueryTimestampList = new List<DateTime> { 
                    new DateTime(1970, 1, 1, 0, 0, 1, DateTimeKind.Utc),
                    new DateTime(1970, 1, 1, 0, 0, 2, DateTimeKind.Utc),
                    new DateTime(1970, 1, 1, 0, 0, 3, DateTimeKind.Utc)
                }
            };

            var internalRequest = TestUtils.RunMockRequest(request, QueryTimestampListRequestMarshaller.Instance, new AmazonRestJsonTestConfig());

            Assert.AreEqual("item=1970-01-01T00%3A00%3A01Z&item=1970-01-01T00%3A00%3A02Z&item=1970-01-01T00%3A00%3A03Z", ToQueryString(internalRequest));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonTest")]
        public void TestQueryTimestampListWithMs()
        {
            var request = new QueryTimestampListRequest
            {
                QueryTimestampList = new List<DateTime> {
                    new DateTime(1970, 1, 1, 0, 0, 1, 123, DateTimeKind.Utc),
                    new DateTime(1970, 1, 1, 0, 0, 2, 123, DateTimeKind.Utc),
                    new DateTime(1970, 1, 1, 0, 0, 3, 123, DateTimeKind.Utc)
                }
            };

            var internalRequest = TestUtils.RunMockRequest(request, QueryTimestampListRequestMarshaller.Instance, new AmazonRestJsonTestConfig());

            Assert.AreEqual("item=1970-01-01T00%3A00%3A01.123Z&item=1970-01-01T00%3A00%3A02.123Z&item=1970-01-01T00%3A00%3A03.123Z", ToQueryString(internalRequest));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonTest")]
        public void TestQueryBooleanList()
        {
            var request = new QueryBooleanListRequest
            {
                QueryBooleanList = new List<bool> { true, false, true }
            };

            var internalRequest = TestUtils.RunMockRequest(request, QueryBooleanListRequestMarshaller.Instance, new AmazonRestJsonTestConfig());

            Assert.AreEqual("item=false&item=true&item=true", ToQueryString(internalRequest));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonTest")]
        public void TestQueryStringListMap()
        {
            var request = new QueryStringListMapRequest
            {
                QueryParamsMapOfStringList = new Dictionary<string, List<string>>
                {
                    { "numbers", new List<string> { "one", "two", "three", "fou/r" }},
                    { "animals", new List<string> { "cat", "dog", "mouse" }}
                }
            };

            var internalRequest = TestUtils.RunMockRequest(request, QueryStringListMapRequestMarshaller.Instance, new AmazonRestJsonTestConfig());

            Assert.AreEqual("animals=cat&animals=dog&animals=mouse&numbers=fou%2Fr&numbers=one&numbers=three&numbers=two", ToQueryString(internalRequest));
        }

        [TestMethod]
        [TestCategory("UnitTest")]
        [TestCategory("Rest_Json")]
        [TestCategory("RestJsonTest")]
        public void TestQueryIntegerListMap()
        {
            var request = new QueryIntegerListMapRequest
            {
                QueryParamsMapOfIntegerList = new Dictionary<string, List<int>>
                {
                    { "numberSet1", new List<int> { 1, 2, 3, 4 }},
                    { "numberSet2", new List<int> { 8, 7, 6 }}
                }
            };

            var internalRequest = TestUtils.RunMockRequest(request, QueryIntegerListMapRequestMarshaller.Instance, new AmazonRestJsonTestConfig());

            Assert.AreEqual("numberSet1=1&numberSet1=2&numberSet1=3&numberSet1=4&numberSet2=6&numberSet2=7&numberSet2=8", ToQueryString(internalRequest));
        }

        private string ToQueryString(IRequest request)
        {
            return Encoding.UTF8.GetString(AWSSDKUtils.GetRequestPayloadBytes(request));
        }
    }
}
