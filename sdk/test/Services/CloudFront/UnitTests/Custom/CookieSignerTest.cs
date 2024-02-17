using System;
using System.IO;
using System.Text;
using Amazon.CloudFront;
using Json.LitJson;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AWSSDK_DotNet35.UnitTests
{
    [TestClass]
    public class CookieSignerTest
    {
        private static StreamReader privateRSAKeyStreamReader = null;

        [TestInitialize]
        public void Initialize()
        {
            privateRSAKeyStreamReader = new StreamReader(Utils.GetResourceStream("sample.rsa.private.key.txt"));
        }

        [TestMethod]
        [TestCategory("CloudFront")]
        public void CannedPolicyValidation()
        {
            string expectedSignature = 
                "IGIL8ItK6uqLzFAR1338Mf5RqqU9VIhG9G0nUmgl4VPdozBDS5fyRMZH39cFqWfK7gXSCOGBGt9X0yYRwqO-yikx5f9eQUQ3pyNukf-iQ~cp4upSVG6ETsR8NQQ1eeiP3DruH4hzwXqmh-ozD~bSzqbvbFW24LclBFG8f6QH~QY_";
            string expectedKeyPair = "CannedKeyPairId";

            var cookies = AmazonCloudFrontCookieSigner.GetCookiesForCannedPolicy(
                "http://awesome.dot.com/amazing/uri/",
                expectedKeyPair,
                privateRSAKeyStreamReader,
                new DateTime(2024, 1, 1, 12, 0, 0, DateTimeKind.Utc)
            );
            Assert.IsNotNull(cookies);

            Assert.AreEqual("CloudFront-Expires", cookies.Expires.Key);
            Assert.AreEqual("1704110400", cookies.Expires.Value);

            Assert.AreEqual("CloudFront-Signature", cookies.Signature.Key);
            Assert.AreEqual(expectedSignature, cookies.Signature.Value);

            Assert.AreEqual("CloudFront-Key-Pair-Id", cookies.KeyPairId.Key);
            Assert.AreEqual(expectedKeyPair, cookies.KeyPairId.Value);
        }

        [TestMethod]
        [TestCategory("CloudFront")]
        public void CustomPolicyValidation()
        {
            // This is the base64 representation of the IAM policy:
            // {"Statement": [{"Resource":"https://awesome.dot.com/amazing/uri","Condition":{"DateLessThan":{"AWS:EpochTime":1704110400},"IpAddress":{"AWS:SourceIp":"192.0.2.0/24"}}}]}
            string expectedPolicy =
                "eyJTdGF0ZW1lbnQiOiBbeyJSZXNvdXJjZSI6Imh0dHBzOi8vYXdlc29tZS5kb3QuY29tL2FtYXppbmcvdXJpIiwiQ29uZGl0aW9uIjp7IkRhdGVMZXNzVGhhbiI6eyJBV1M6RXBvY2hUaW1lIjoxNzA0MTEwNDAwfSwiSXBBZGRyZXNzIjp7IkFXUzpTb3VyY2VJcCI6IjE5Mi4wLjIuMC8yNCJ9fX1dfQ__";
            string expectedSignature =
                "V1yosye5qeoTsErf40Z1cDxYHthvcaaLcw2P53GwklJrYI6ojYyeq2a5HyUDzd2H62sQzzt9SxXmZLzpsgVWa3dc1KWX2TSR8qLQ7oikHkyRem6JAyLp19zou29tTdVySF2~b7LPP3NxgtJZqIlOtTOMVshawUhp~PGv9alE7R8_";
            string expectedKeyPair = "CustomKeyPairId";

            var cookies = AmazonCloudFrontCookieSigner.GetCookiesForCustomPolicy(
                AmazonCloudFrontCookieSigner.Protocols.Https,
                "awesome.dot.com", 
                privateRSAKeyStreamReader,
                "amazing/uri",
                expectedKeyPair, 
                new DateTime(2024, 1, 1, 12, 0, 0, DateTimeKind.Utc),
                "192.0.2.0/24"
            );
            Assert.IsNotNull(cookies);

            Assert.AreEqual("CloudFront-Policy", cookies.Policy.Key);
            Assert.AreEqual(expectedPolicy, cookies.Policy.Value);

            Assert.AreEqual("CloudFront-Signature", cookies.Signature.Key);
            Assert.AreEqual(expectedSignature, cookies.Signature.Value);

            Assert.AreEqual("CloudFront-Key-Pair-Id", cookies.KeyPairId.Key);
            Assert.AreEqual(expectedKeyPair, cookies.KeyPairId.Value);
        }
        
        [TestMethod]
        [TestCategory("CloudFront")]
        public void CustomPolicyResourceValidation_WhenPassingResourceWithLeadingSlash()
        {
            // This is the base64 representation of the IAM policy:
            // {"Statement": [{"Resource":"https://awesome.dot.com/amazing/uri","Condition":{"DateLessThan":{"AWS:EpochTime":1704110400},"IpAddress":{"AWS:SourceIp":"192.0.2.0/24"}}}]}
            string expectedPolicy =
                "eyJTdGF0ZW1lbnQiOiBbeyJSZXNvdXJjZSI6Imh0dHBzOi8vYXdlc29tZS5kb3QuY29tL2FtYXppbmcvdXJpIiwiQ29uZGl0aW9uIjp7IkRhdGVMZXNzVGhhbiI6eyJBV1M6RXBvY2hUaW1lIjoxNzA0MTEwNDAwfSwiSXBBZGRyZXNzIjp7IkFXUzpTb3VyY2VJcCI6IjE5Mi4wLjIuMC8yNCJ9fX1dfQ__";
            
            string expectedResourceUrl = "https://awesome.dot.com/amazing/uri"; // contains only a single slash (/) between ".com" and "amazing"

            string resourcePathWithLeadingSlash = "/amazing/uri";  // Resource path containing leading slash

            var cookies = AmazonCloudFrontCookieSigner.GetCookiesForCustomPolicy(
                AmazonCloudFrontCookieSigner.Protocols.Https,
                "awesome.dot.com", 
                privateRSAKeyStreamReader,
                resourcePathWithLeadingSlash,
                "CustomKeyPairId",
                new DateTime(2024, 1, 1, 12, 0, 0, DateTimeKind.Utc),
                "192.0.2.0/24"
            );
            Assert.IsNotNull(cookies);

            Assert.AreEqual("CloudFront-Policy", cookies.Policy.Key);
            Assert.AreEqual(expectedPolicy, cookies.Policy.Value);
            
            string policyJson = Encoding.UTF8.GetString(
                Convert.FromBase64String(cookies.Policy.Value.Replace('-', '+').Replace('_', '=').Replace('~', '/')));
            
            var policyData = JsonMapper.ToObject(policyJson);
            var actualResourceUrl = policyData["Statement"][0]["Resource"].ToString();

            Assert.AreEqual(expectedResourceUrl, actualResourceUrl);
        }
    }
}
