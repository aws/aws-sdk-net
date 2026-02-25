using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Amazon.CloudFront;
using ThirdParty.Json.LitJson;
using System.Collections.Generic;

namespace AWSSDK_DotNet35.UnitTests
{
    [TestClass]
    public class URLSignerTest
    {
        private static string privateRSAKeyResourceName = @"sample.rsa.private.key.txt";
        private static StreamReader privateRSAKeyStreamReader = null;

        [TestInitialize]
        public void Initialize()
        {
            privateRSAKeyStreamReader = new StreamReader(Utils.GetResourceStream(privateRSAKeyResourceName));
        }

        [TestMethod]
        [TestCategory("CloudFront")]
        public void SignURLValidation()
        {
            string expectedSignedURL = @"http://awesome.dot.com/amazing/uri/?Policy=U2VjcmV0UG9saWN5"
                                    + @"&Signature=nmwKvD6cFoniNsMZeuxrzooEt73MtzS78g3u0Pym835Ty1cfV0sWK1sGnPpafaMw95kGNv7eHE3eivEosdXenrYMnz8EtobPOLyx4SQ4RvDrBfrjiNTGGgAowORLYc6sztZ8AKEQiQ9KVaOVNJ8DR5e2TQ7S~bNU91c0PEfrrcA_"
                                    + @"&Key-Pair-Id=amazingKeyPairId";
            string signedURL = AmazonCloudFrontUrlSigner.SignUrl("http://awesome.dot.com/amazing/uri/", "amazingKeyPairId", privateRSAKeyStreamReader, "SecretPolicy");

            Assert.AreEqual(expectedSignedURL, signedURL);
        }

        [TestMethod]
        [TestCategory("CloudFront")]
        public void SignURLCannedValidation()
        {
            string expectedSignedURL = @"http://awesome.dot.com/amazing/uri/?Expires=1492153200" +
                @"&Signature=XSFtfQPkZ3SgEulXvGpBH7L~Bfh3wv4kPtrYHkFA2yubVZ9tibq0Cz4HDaA-TVkuPOw0ipC4AmzOX8tjrtoD1U1N" +
                @"MsnnA3H4SQJI4Pe9AXjJwARrbFegGmCLoMmun2FxbOZqo2zb1ltBMOx7HtXBF5lQVkdukQsam4B6g3Mm9ec_&Key-Pair-Id=amazingKeyPairId";

            string signedURL = AmazonCloudFrontUrlSigner.SignUrlCanned("http://awesome.dot.com/amazing/uri/",
                "amazingKeyPairId", privateRSAKeyStreamReader, new DateTime(2017, 4, 14, 7, 0, 0, DateTimeKind.Utc));

            Assert.AreEqual(expectedSignedURL, signedURL);
        }

        [TestMethod]
        [TestCategory("CloudFront")]
        public void PolicyStatementWithNoAddress()
        {
            var resourcePath = "http://d111111abcdef8.cloudfront.net/game_download.zip";
            var dateTime = new DateTime(2013, 1, 1, 10, 00, 0, DateTimeKind.Utc);
            var policyWithEmptyString = AmazonCloudFrontUrlSigner.BuildPolicyForSignedUrl(
                                    resourcePath,
                                    dateTime,
                                    "");

            var policyWithNull = AmazonCloudFrontUrlSigner.BuildPolicyForSignedUrl(
                                    resourcePath,
                                    dateTime,
                                    null);

            Assert.AreEqual(policyWithEmptyString, policyWithNull);

            foreach(var policy in new List<string> { policyWithEmptyString, policyWithNull })
            {
                var jsonObject = JsonMapper.ToObject(policy);

                var statementList = jsonObject["Statement"];
                Assert.IsTrue(statementList.IsArray);

                var statement = statementList[0];
                Assert.IsNotNull(statement);

                var resource = statement["Resource"];
                Assert.AreEqual(resource.ToString(), resourcePath);

                var condition = statement["Condition"];
                Assert.IsNotNull(condition);
                Assert.IsTrue(condition.IsObject);

                var IpAddress = condition["IpAddress"];
                Assert.IsNull(IpAddress);

                var epochTime = condition["DateLessThan"]["AWS:EpochTime"];
                Assert.AreEqual(1357034400, long.Parse(epochTime.ToString()));
            }
        }

        [TestMethod]
        [TestCategory("CloudFront")]
        public void PolicyStatementWithAddress()
        {
            var resourcePath = "http://*";
            var dateTime = new DateTime(2013, 1, 1, 10, 00, 0, DateTimeKind.Utc);
            var ipRange = "192.0.2.0/24";
            var policyDocument = AmazonCloudFrontUrlSigner.BuildPolicyForSignedUrl(
                                    resourcePath,
                                    dateTime,
                                    ipRange);

            var jsonObject = JsonMapper.ToObject(policyDocument);

            var statementList = jsonObject["Statement"];
            Assert.IsTrue(statementList.IsArray);

            var statement = statementList[0];
            Assert.IsNotNull(statement);

            var resource = statement["Resource"];
            Assert.AreEqual(resource.ToString(), resourcePath);

            var condition = statement["Condition"];
            Assert.IsNotNull(condition);
            Assert.IsTrue(condition.IsObject);

            var sourceIp = condition["IpAddress"]["AWS:SourceIp"];
            Assert.AreEqual(ipRange, sourceIp.ToString());

            var epochTime = condition["DateLessThan"]["AWS:EpochTime"];
            Assert.AreEqual(1357034400, long.Parse(epochTime.ToString()));
        }

        [DataTestMethod]
        [TestCategory("CloudFront")]
        [DataRow("https://example.com/file\",\"Resource\":\"*\",\"x\":\"")]
        [DataRow("https://example.com/file\\bad")]
        [DataRow("https://example.com/file\n")]
        public void BuildPolicyForSignedUrl_RejectsInvalidResourcePath(string maliciousUrl)
        {
            var dateTime = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            var exception = Assert.ThrowsException<ArgumentException>(() =>
                AmazonCloudFrontUrlSigner.BuildPolicyForSignedUrl(maliciousUrl, dateTime, ""));

            Assert.AreEqual("resourcePath", exception.ParamName);
        }

        [DataTestMethod]
        [TestCategory("CloudFront")]
        [DataRow("192.168.0.1/24\",\"x\":\"injected")]
        [DataRow("192.168.0.1/24\\injected")]
        [DataRow("192.168.0.1/24\n")]
        public void BuildPolicyForSignedUrl_RejectsInvalidIpAddress(string maliciousIp)
        {
            var resourcePath = "https://example.com/file.txt";
            var dateTime = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            var exception = Assert.ThrowsException<ArgumentException>(() =>
                AmazonCloudFrontUrlSigner.BuildPolicyForSignedUrl(resourcePath, dateTime, maliciousIp));

            Assert.AreEqual("limitToIpAddressCIDR", exception.ParamName);
        }

        [DataTestMethod]
        [TestCategory("CloudFront")]
        [DataRow("https://d111111abcdef8.cloudfront.net/path/to/file.txt")]
        [DataRow("*")]
        [DataRow("https://example.com/file?.txt")]
        public void BuildPolicyForSignedUrl_AcceptsValidResourcePaths(string resourcePath)
        {
            var dateTime = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            var policy = AmazonCloudFrontUrlSigner.BuildPolicyForSignedUrl(resourcePath, dateTime, "");
            Assert.IsNotNull(policy);

            var jsonObject = JsonMapper.ToObject(policy);
            var resource = jsonObject["Statement"][0]["Resource"];
            Assert.AreEqual(resourcePath, resource.ToString());
        }

        [DataTestMethod]
        [TestCategory("CloudFront")]
        [DataRow("https://example.com/file\",\"Resource\":\"*\",\"x\":\"")]
        [DataRow("https://example.com/file\\bad")]
        [DataRow("https://example.com/file\n")]
        public void SignUrlCanned_RejectsInvalidResourceUrl(string maliciousUrl)
        {
            var dateTime = new DateTime(2024, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            Assert.ThrowsException<ArgumentException>(() =>
                AmazonCloudFrontUrlSigner.SignUrlCanned(maliciousUrl, "keyPairId",
                    privateRSAKeyStreamReader, dateTime));
        }
    }
}
