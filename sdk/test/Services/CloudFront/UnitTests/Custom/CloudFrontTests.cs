using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.CloudFront;
using Json.LitJson;
using System.IO;

namespace AWSSDK_DotNet.UnitTests
{
    [TestClass]
    public class CloudFrontTests
    {
        /// <summary>
        /// Test to verify fix for misconfigured AmazonCloudFrontCookieSigner.Protocols flags enum.
        /// </summary>
        [TestMethod]
        [TestCategory("CloudFront")]
        public void TestProtocolEnum()
        {
            var http = AmazonCloudFrontCookieSigner.Protocols.Http;
            var https = AmazonCloudFrontCookieSigner.Protocols.Https;
            var httpAndHttps = AmazonCloudFrontCookieSigner.Protocols.Http | AmazonCloudFrontCookieSigner.Protocols.Https;

            Assert.IsTrue(Evaluate(httpAndHttps));
            Assert.IsFalse(Evaluate(http));
            Assert.IsFalse(Evaluate(https));
        }

        private static bool Evaluate(AmazonCloudFrontCookieSigner.Protocols protocol)
        {
            return protocol ==
                (AmazonCloudFrontCookieSigner.Protocols.Http | AmazonCloudFrontCookieSigner.Protocols.Https);
        }
    }
}