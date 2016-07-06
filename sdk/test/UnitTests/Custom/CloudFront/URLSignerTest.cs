using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using Amazon.CloudFront;
using System.Diagnostics;
using System.Security;

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

            Assert.AreEqual(signedURL, expectedSignedURL);
        }

        [TestMethod]
        [TestCategory("CloudFront")]
        public void SignURLCannedValidation()
        {
            string expectedSignedURL = @"http://awesome.dot.com/amazing/uri/?Expires=-2147483648"
                                    + @"&Signature=D613LzV~14C6sXGxXuG6fKFWwZC1wYOKEJg-YRZYtTwYDeTubr1qqHq9yakw42EUVbYK~l4-lq-5foS4LfAvFMx2uL51NS99W4aRSC0u8G9drcveRyJghFflh18hdC5Q-YXEFt-gtbxio3hndUYM2GYCbtBGXad7dDKx7bXvc5k_"
                                    + @"&Key-Pair-Id=amazingKeyPairId";
            string signedURL = AmazonCloudFrontUrlSigner.SignUrlCanned("http://awesome.dot.com/amazing/uri/", "amazingKeyPairId", privateRSAKeyStreamReader, new DateTime(1776, 7, 4));

            Assert.AreEqual(signedURL, expectedSignedURL);
        }
    }
}
