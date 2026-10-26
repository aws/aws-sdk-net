#if !NETFRAMEWORK
using Amazon.Runtime.Internal.Transform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class HttpClientResponseDataTests
    {
        private static HttpClientResponseData CreateResponseData()
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new StringContent("{}", Encoding.UTF8, "application/json")
            };
            response.Headers.TryAddWithoutValidation("x-amzn-RequestId", "request-id");
            response.Headers.TryAddWithoutValidation("x-amz-id-2", "id-2");
            response.Headers.TryAddWithoutValidation("Cache-Control", "max-age=0, no-cache");
            return new HttpClientResponseData(response);
        }

        [TestMethod]
        public void HeaderNamesKeepResponseThenContentOrder()
        {
            var data = CreateResponseData();

            // Response headers come first in the order they were added; content headers follow. Reading
            // ContentLength in the constructor materializes a Content-Length entry in the content header store.
            var names = data.GetHeaderNames();
            CollectionAssert.AreEqual(new[] { "x-amzn-RequestId", "x-amz-id-2", "Cache-Control" }, names.Take(3).ToArray());
            CollectionAssert.AreEquivalent(new[] { "Content-Type", "Content-Length" }, names.Skip(3).ToArray());
        }

        [TestMethod]
        public void HeaderLookupsAreCaseInsensitive()
        {
            var data = CreateResponseData();

            Assert.IsTrue(data.IsHeaderPresent("X-AMZN-REQUESTID"));
            Assert.IsTrue(data.IsHeaderPresent("content-type"));
            Assert.IsFalse(data.IsHeaderPresent("x-amz-missing"));
            Assert.AreEqual("request-id", data.GetHeaderValue("x-amzn-requestid"));
            Assert.AreEqual(string.Empty, data.GetHeaderValue("x-amz-missing"));
        }

        [TestMethod]
        public void ContentHeadersAreExposedWithTheirValues()
        {
            var data = CreateResponseData();

            Assert.AreEqual("application/json", data.ContentType);
            StringAssert.StartsWith(data.GetHeaderValue("Content-Type"), "application/json");
            Assert.AreEqual(2, data.ContentLength);
        }
    }
}
#endif
