using System.IO; 
using Amazon.CloudFront;
using System;
using Xunit;
namespace AWSSDK_CoreCLR.UnitTests
{
    public class CloudFrontTests
    {
        private static string privateRSAKeyResourceName = @"UnitTests.CoreCLR.sample.rsa.private.key.txt";
        private static StreamReader privateRSAKeyStreamReader = null;

        public CloudFrontTests()
        {
            privateRSAKeyStreamReader = new StreamReader(Utils.GetAssemblyResourceStream(privateRSAKeyResourceName));
        }

        [Fact]
        [Trait("Category", "CloudFront")]
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
    }
}
