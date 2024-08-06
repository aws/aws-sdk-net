using System;

using Amazon.CloudFront;
using System.IO;
using Xunit;

namespace AWSSDK_DotNet.UnitTests
{
    public class CloudFrontTests
    {
        /// <summary>
        /// Test to verify fix for misconfigured AmazonCloudFrontCookieSigner.Protocols flags enum.
        /// </summary>
        [Fact]
        [Trait("Category","CloudFront")]
        public void TestProtocolEnum()
        {
            var http = AmazonCloudFrontCookieSigner.Protocols.Http;
            var https = AmazonCloudFrontCookieSigner.Protocols.Https;
            var httpAndHttps = AmazonCloudFrontCookieSigner.Protocols.Http | AmazonCloudFrontCookieSigner.Protocols.Https;

            Assert.True(Evaluate(httpAndHttps));
            Assert.False(Evaluate(http));
            Assert.False(Evaluate(https));
        }

        private static bool Evaluate(AmazonCloudFrontCookieSigner.Protocols protocol)
        {
            return protocol ==
                (AmazonCloudFrontCookieSigner.Protocols.Http | AmazonCloudFrontCookieSigner.Protocols.Https);
        }
    }
}