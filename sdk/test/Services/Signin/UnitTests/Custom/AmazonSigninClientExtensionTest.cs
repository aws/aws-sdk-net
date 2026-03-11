using Amazon.Runtime.SharedInterfaces;
using Amazon.Signin;
using Amazon.Signin.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class AmazonSigninClientExtensionTest
    {
        [TestMethod]
        public void GetBaseEndpoint_ReturnsCorrectEndpoint()
        {
            ICoreAmazonSignin client = new AmazonSigninClient();
            
            var endpoint = client.GetBaseEndpoint();
            
            Assert.IsNotNull(endpoint);
            Assert.IsTrue(endpoint.Contains("signin"));
        }

        [TestMethod]
        public void GenerateDPoPProof_ValidParameters_GeneratesProof()
        {
            ICoreAmazonSignin client = new AmazonSigninClient();
            var httpMethod = "POST";
            var uri = "https://signin.aws.amazon.com/v1/token";
            string dpopKey = null;

            var result = client.GenerateDPoPProof(httpMethod, uri, ref dpopKey);

            Assert.IsNotNull(result);
            Assert.IsTrue(result.Length > 0);
        }

        [TestMethod]
        public void GenerateDPoPProof_InvalidKey_ThrowsException()
        {
            var httpMethod = "POST";
            var uri = "https://signin.aws.amazon.com/v1/token";
            var privateKey = "invalid-key";

            Assert.ThrowsException<InvalidOperationException>(() =>
                DPoPProofGenerator.GenerateProof(httpMethod, uri, ref privateKey));
        }
    }
}