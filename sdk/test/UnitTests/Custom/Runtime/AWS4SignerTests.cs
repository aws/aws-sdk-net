#if !NETFRAMEWORK
using System.Collections.Generic;
using Amazon.Runtime.Internal.Auth;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK.UnitTests
{
    [TestClass]
    [TestCategory("Core")]
    public class AWS4SignerTests
    {
        [TestMethod]
        public void CanonicalizeHeaderNames()
        {
            var headers = new Dictionary<string, string>
            {
                { "Header1", "Value1" },
                { "Header2", "Value2" },
                { "Header3", "Value3" }
            };

            var signer = new AWS4SignerTestee();
            var canonicalizedHeaders = signer.TestCanonicalizeHeaderNames(headers);

            Assert.AreEqual("header1;header2;header3", canonicalizedHeaders);
        }

        [TestMethod]
        public void CanonicalizeHeaders()
        {
            var headers = new Dictionary<string, string>
            {
                { "Header1", "Value1" },
                { "Header2", " Value2 " },
                { "Header3", "   Value3   " }
            };

            var signer = new AWS4SignerTestee();
            var canonicalizedHeaders = signer.TestCanonicalizeHeaders(headers);

            Assert.AreEqual("header1:Value1\nheader2:Value2\nheader3:Value3\n", canonicalizedHeaders);
        }

        class AWS4SignerTestee : AWS4Signer
        {
            public string TestCanonicalizeHeaderNames(IDictionary<string, string> headers)
            {
                return CanonicalizeHeaderNames(headers);
            }

            public string TestCanonicalizeHeaders(IDictionary<string, string> headers)
            {
                return CanonicalizeHeaders(headers);
            }
        }
    }
}
#endif
