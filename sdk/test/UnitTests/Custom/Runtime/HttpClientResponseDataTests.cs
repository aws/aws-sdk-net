#if !NETFRAMEWORK
using Amazon.Runtime.Internal.Transform;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Net;
using System.Net.Http;

namespace AWSSDK.UnitTests
{
    [TestClass]
    [TestCategory("UnitTest")]
    [TestCategory("Runtime")]
    public class HttpClientResponseDataTests
    {
        [TestMethod]
        public void CopiesResponseAndContentHeaders()
        {
            var response = new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent("{}") };
            response.Headers.TryAddWithoutValidation("x-amzn-RequestId", "req-1");
            response.Headers.TryAddWithoutValidation("x-amz-meta-multi", new[] { "first", "second" });
            response.Content.Headers.TryAddWithoutValidation("Content-Language", "en");

            var data = new HttpClientResponseData(response);

            Assert.AreEqual("req-1", data.GetHeaderValue("X-AMZN-REQUESTID"));
            Assert.AreEqual("first", data.GetHeaderValue("x-amz-meta-multi"));
            Assert.AreEqual("en", data.GetHeaderValue("content-language"));
            Assert.AreEqual(string.Empty, data.GetHeaderValue("missing"));

            Assert.IsTrue(data.IsHeaderPresent("X-Amz-Meta-Multi"));
            Assert.IsFalse(data.IsHeaderPresent("missing"));

            CollectionAssert.AreEqual(
                response.Headers.Select(h => h.Key).Concat(response.Content.Headers.Select(h => h.Key)).ToArray(),
                data.GetHeaderNames());
        }
    }
}
#endif
