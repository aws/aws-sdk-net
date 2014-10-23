using System;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.S3;
using AWSSDK_DotNet.IntegrationTests.Utils;


namespace AWSSDK_DotNet.IntegrationTests.Tests
{
    [TestClass]
    public class General
    {
        [TestMethod]
        public void TestClientDispose()
        {
            IAmazonS3 client;
            using(client = new AmazonS3Client())
            {
                var response = client.ListBuckets();
                Assert.IsNotNull(response);
                Assert.IsNotNull(response.ResponseMetadata);
                Assert.IsNotNull(response.ResponseMetadata.RequestId);
                Assert.IsFalse(string.IsNullOrEmpty(response.ResponseMetadata.RequestId));
            }

            AssertExtensions.ExpectException(() => client.ListBuckets(), typeof(ObjectDisposedException));
        }
    }
}
