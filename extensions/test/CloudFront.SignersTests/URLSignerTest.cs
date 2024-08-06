using System;
using System.IO;
using Amazon.CloudFront;
using ThirdParty.Json.LitJson;
using System.Collections.Generic;
using Xunit;
namespace AWSSDK_DotNet.UnitTests
{
    public class URLSignerTest
    {
        private static StreamReader privateRSAKeyStreamReader = null;
        public URLSignerTest()
        {

           Initialize();
        }

        private void Initialize()
        {
            var resourceDirectory = Path.Combine(Environment.CurrentDirectory, "EmbeddedResource");
            var privateKeyTxtPath = Path.Combine(resourceDirectory, "sample.rsa.private.key.txt");
            privateRSAKeyStreamReader = new StreamReader(privateKeyTxtPath);
        }

        [Fact]
        [Trait("Category","CloudFront")]
        public void SignURLValidation()
        {
            string expectedSignedURL = @"http://awesome.dot.com/amazing/uri/?Policy=U2VjcmV0UG9saWN5"
                                    + @"&Signature=nmwKvD6cFoniNsMZeuxrzooEt73MtzS78g3u0Pym835Ty1cfV0sWK1sGnPpafaMw95kGNv7eHE3eivEosdXenrYMnz8EtobPOLyx4SQ4RvDrBfrjiNTGGgAowORLYc6sztZ8AKEQiQ9KVaOVNJ8DR5e2TQ7S~bNU91c0PEfrrcA_"
                                    + @"&Key-Pair-Id=amazingKeyPairId";
            string signedURL = AmazonCloudFrontUrlSigner.SignUrl("http://awesome.dot.com/amazing/uri/", "amazingKeyPairId", privateRSAKeyStreamReader, "SecretPolicy");

            Assert.Equal(expectedSignedURL, signedURL);
        }

        [Fact]
        [Trait("Category", "CloudFront")]
        public void SignURLCannedValidation()
        {
            string expectedSignedURL = @"http://awesome.dot.com/amazing/uri/?Expires=1492153200" +
                @"&Signature=XSFtfQPkZ3SgEulXvGpBH7L~Bfh3wv4kPtrYHkFA2yubVZ9tibq0Cz4HDaA-TVkuPOw0ipC4AmzOX8tjrtoD1U1N" +
                @"MsnnA3H4SQJI4Pe9AXjJwARrbFegGmCLoMmun2FxbOZqo2zb1ltBMOx7HtXBF5lQVkdukQsam4B6g3Mm9ec_&Key-Pair-Id=amazingKeyPairId";

            string signedURL = AmazonCloudFrontUrlSigner.SignUrlCanned("http://awesome.dot.com/amazing/uri/",
                "amazingKeyPairId", privateRSAKeyStreamReader, new DateTime(2017, 4, 14, 7, 0, 0, DateTimeKind.Utc));

            Assert.Equal(expectedSignedURL, signedURL);
        }

        [Fact]
        [Trait("Category", "CloudFront")]
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

            Assert.Equal(policyWithEmptyString, policyWithNull);

            foreach(var policy in new List<string> { policyWithEmptyString, policyWithNull })
            {
                var jsonObject = JsonMapper.ToObject(policy);

                var statementList = jsonObject["Statement"];
                Assert.True(statementList.IsArray);

                var statement = statementList[0];
                Assert.NotNull(statement);

                var resource = statement["Resource"];
                Assert.Equal(resource.ToString(), resourcePath);

                var condition = statement["Condition"];
                Assert.NotNull(condition);
                Assert.True(condition.IsObject);

                var IpAddress = condition["IpAddress"];
                Assert.Null(IpAddress);

                var epochTime = condition["DateLessThan"]["AWS:EpochTime"];
                Assert.Equal(1357034400, long.Parse(epochTime.ToString()));
            }
        }

        [Fact]
        [Trait("Category", "CloudFront")]
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
            Assert.True(statementList.IsArray);

            var statement = statementList[0];
            Assert.NotNull(statement);

            var resource = statement["Resource"];
            Assert.Equal(resource.ToString(), resourcePath);

            var condition = statement["Condition"];
            Assert.NotNull(condition);
            Assert.True(condition.IsObject);

            var sourceIp = condition["IpAddress"]["AWS:SourceIp"];
            Assert.Equal(ipRange, sourceIp.ToString());

            var epochTime = condition["DateLessThan"]["AWS:EpochTime"];
            Assert.Equal(1357034400, long.Parse(epochTime.ToString()));
        }
    }
}
