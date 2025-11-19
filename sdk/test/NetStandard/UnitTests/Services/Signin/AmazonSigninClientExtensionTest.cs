using Amazon.Runtime.SharedInterfaces;
using Amazon.Signin;
using Amazon.Signin.Util;
using Xunit;
using System;

namespace AWSSDK.UnitTests
{
    public class AmazonSigninClientExtensionTest
    {
        [Fact]
        public void GenerateDPoPProof_ValidParameters_GeneratesProof()
        {
            ICoreAmazonSignin client = new AmazonSigninClient();
            var httpMethod = "POST";
            var uri = "https://signin.aws.amazon.com/v1/token";
            string dpopKey = null;

            var result = DPoPProofGenerator.GenerateProof(httpMethod, uri, ref dpopKey);

            Assert.NotNull(result);
            Assert.True(result.Length > 0);
        }

        [Fact]
        public void GenerateDPoPProof_InvalidKey_ThrowsException()
        {
            var httpMethod = "POST";
            var uri = "https://signin.aws.amazon.com/v1/token";
            var privateKey = "invalid-key";

#if !NET8_0_OR_GREATER
            Assert.Throws<InvalidOperationException>(() =>
                DPoPProofGenerator.GenerateProof(httpMethod, uri, ref privateKey));
#else
            Assert.Throws<ArgumentException>(() =>
                            DPoPProofGenerator.GenerateProof(httpMethod, uri, ref privateKey));
#endif
        }
    }
}