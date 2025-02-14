using System;
using System.IO;
using Amazon.CloudFront;
using System.Collections.Generic;
using Xunit;
using System.Text.Json;
using System.Linq;
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
                using (var jsonObject = JsonDocument.Parse(policy))
                {
                    var statementList = jsonObject.RootElement.GetProperty("Statement");
                    Assert.True(statementList.ValueKind == JsonValueKind.Array);

                    var statement = statementList.EnumerateArray().First();

                    var resource = statement.GetProperty("Resource");
                    Assert.Equal(resource.ToString(), resourcePath);

                    var condition = statement.GetProperty("Condition");
                    Assert.True(condition.ValueKind == JsonValueKind.Object);

                    Assert.False(condition.TryGetProperty("IpAddress", out _));

                    var epochTime = condition.GetProperty("DateLessThan").GetProperty("AWS:EpochTime");
                    Assert.Equal(1357034400, long.Parse(epochTime.ToString()));
                }
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

            using (var jsonObject = JsonDocument.Parse(policyDocument))
            {
                var statementList = jsonObject.RootElement.GetProperty("Statement");
                Assert.True(statementList.ValueKind == JsonValueKind.Array);

                var statement = statementList.EnumerateArray().First();

                var resource = statement.GetProperty("Resource");
                Assert.Equal(resource.ToString(), resourcePath);

                var condition = statement.GetProperty("Condition");
                Assert.True(condition.ValueKind == JsonValueKind.Object);

                var sourceIp = condition.GetProperty("IpAddress").GetProperty("AWS:SourceIp");
                Assert.Equal(ipRange, sourceIp.ToString());

                var epochTime = condition.GetProperty("DateLessThan").GetProperty("AWS:EpochTime");
                Assert.Equal(1357034400, long.Parse(epochTime.ToString()));
            }
        }

        /// <summary>
        /// Tests that the issue mentioned in https://github.com/aws/aws-sdk-net/issues/3221 no longer throws an exception.
        /// </summary>
        [Fact]
        [Trait("Category","CloudFront")]
        public void TestGetCannedSignedUrlWithOpenSSL3()
        {
            var reader = new StringReader(@"
                              -----BEGIN PRIVATE KEY-----
                              MIIEvQIBADANBgkqhkiG9w0BAQEFAASCBKcwggSjAgEAAoIBAQCa5udYGtrIPUU5
                              EA0uTAGIc/gPFKqk9rnx6ubTkkEErA6ZiIbG/lj4bSRHendy06qd1X5zuJ4k73oi
                              SsXKzCOuJHAZA872+iIbFI5axdYH25E3LIzJZu7KHlL08QGsIl9ccx8usuSotsj2
                              pvb+uswg6kM3sy6Kiqw6e+5GlR4i0CNtt9pOTPb1+5ZQGehx0oeAypV4vGRZIQBm
                              aCYXo2sBMZI1nNhe6fW7jpNrtki+nh1CKpmxE2TEwfFNh8xCiZ4wCJ4Y8GE3Te9E
                              8otXM4+15ksIdMzJi7WbtiPsrEc4bxkBD+Hor8bGgFxXAWRRM3ttzLsZrotgEgYO
                              fu7y0EtXAgMBAAECggEALqqhx8lPYEQVNru/PNNpItLNSL3RKyGpo1hBcjv9moq7
                              W0XmVM0LwMwgwegDVHSwUhyfm/1ip33+LZaZQB+AIFaZ7u9WytFQtRfcSzyO3o8n
                              kJe7UnHQPtQj6ecxucohMJj+K/N5L9rhcG2cu+FK3h+1YHJ68wIUIQp1Ho6OJa5W
                              6/ad/aEPnSH5vd3LmUTSiD/jOtpoSge1axwVoCY4sdK8aTSAld/KexVHb7S5V2m2
                              IB1tZ+lE+5NyggKbop1ZtqsmJSbpNlHVDuboJMQppK8M/CENetykPe3L8BiIY3zU
                              J6jylM3dPA+bjlOvylZsWmtAe3ItajftzYSrGXKuAQKBgQDOubkIYSj+O8a5h4Hw
                              n/YequdduArKe/loKh2987mM2yqyU56XKoJ48GA6X3nZKPy5ZxcQD0maGUtf/6Bk
                              0rQwq+Tyk2m5fShIhTNoCukjteLClfyw6F2I+3xqMJi7+o0l+t2XB2nFXjTJE8jS
                              zL9uyDG+w45Q8PBbYhrrnMK9iQKBgQC/0vArSNkdrYf2gpVbGW15rWcCtloDm85l
                              X1TFIRAh4dVQyonz5ZD5VVl3RYsm0VaH01q6G3pgY8gfVyxPTebm01MC2z5GQk1V
                              1PWbeIbP4P1+wl1uFb4o9ksGGwhwUvm1JO/7PwmcClvdjvO3tv3rpotJAhJr2vBl
                              UAp87fBp3wKBgGamxKHLlU6BIlH4Xua8l7tsxAy+meUoIJW/7BrpzqaKIi6A5UxN
                              GJKzUiVKSbgy6SOrdEFORg8WJl6aEexe0Ikmoj5uQt6PrpQsSHWOjWxlIh/b2KmE
                              CQY/Uu1sCju106cbZjNbxAL0n6OFhoBemWSKVmFSu/WnXsMR+SosImt5AoGBALXf
                              UJkpi7low4WFEAj81eBM+WMH89aCDjHtLhltnLcTQMZGEoAtw8OzGY1NYX7fcjR7
                              vwS/cssbMC4O39MdIHTwHj+SEbxZtqtPq8LJhsBoKNDbhewPL2n1AvL6BIlDEsCe
                              Ee7cOMc6xxkNJaSlGqEoGd2R2ldqkQzt09PZYV1vAoGABLeRlh3Jw+T34o9xsCM3
                              N2hU89VWIgvy5Tnz2CekZ7Lw9oL4dACM0LnAs2XG258H1eaVICBkYM/HYPrrTDuf
                              CKahgTe2mWpYYIuX9FeuEde8/aCFjmx3Ex+QhApPRKh/Sjt/KDYklv/uM8yVwA0Z
                              i6bFYQM/GnNZd4VnbUZ28ro=
                              -----END PRIVATE KEY-----
                              ");

            Assert.NotNull(AmazonCloudFrontUrlSigner.GetCannedSignedURL("http://example.com", reader, "keyPairId", DateTime.UtcNow));
           
        }
    }
}
