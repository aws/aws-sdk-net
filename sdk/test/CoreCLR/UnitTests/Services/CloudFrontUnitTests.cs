using System.IO; 
using Amazon.CloudFront;
using System;
using Xunit;
namespace AWSSDK_CoreCLR.UnitTests
{
    public class CloudFrontTests
    {
        private static string privateRSAKeyResourceName = @"UnitTests.sample.rsa.private.key.txt";
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
            string expectedSignedURL = @"http://awesome.dot.com/amazing/uri/?Expires=-6106035600"
                                    + @"&Signature=RezrUdl1C4O4LiHnK2orurG-KjuAoPb3wcJr7R0wrvaERJ7H4FVv4OtNxT2QcY~m7KmAXOJEL6aR6Xs3CujxAb2rMOeIev6yy6C~YVkMQQucBDof6HiFdfCZD-aZr7IQxiap6Kd9uqwR9tTp9rKBENzvI3hHyKtCY8Rn~SzwpGU_"
                                    + @"&Key-Pair-Id=amazingKeyPairId";
            string signedURL = AmazonCloudFrontUrlSigner.SignUrlCanned("http://awesome.dot.com/amazing/uri/", "amazingKeyPairId", privateRSAKeyStreamReader, new DateTime(1776, 7, 4));

            Assert.Equal(expectedSignedURL, signedURL);
        }
    }
}
