using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Net;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class CopyObjectTests : TestBase<AmazonS3Client>
    {
        private const string testContent = "This is the content body!";
        private const string testKey = "testKey.txt";
        private const string testKeyWithSlash = "/sourceTestKey.txt";

        private string eastBucketName;
        private string westBucketName;

        private AmazonS3Client usEastClient;

        [TestInitialize]
        public void Initialize()
        {
            usEastClient = new AmazonS3Client(RegionEndpoint.USEast1);
            eastBucketName = S3TestUtils.CreateBucketWithWait(usEastClient);
            
            usEastClient.PutObject(new PutObjectRequest
            {
                BucketName = eastBucketName,
                Key = testKey,
                ContentBody = testContent
            });

            usEastClient.PutObject(new PutObjectRequest
            {
                BucketName = eastBucketName,
                Key = testKeyWithSlash,
                ContentBody = testContent
            });

            var usWestClient = new AmazonS3Client(RegionEndpoint.USWest1);
            westBucketName = S3TestUtils.CreateBucketWithWait(usWestClient);
        }

        [TestCleanup]
        public void TestCleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(Client, eastBucketName);
            AmazonS3Util.DeleteS3BucketWithObjects(Client, westBucketName);
            BaseClean();
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestCopyObject()
        {
            var response = usEastClient.CopyObject(new CopyObjectRequest
            {
                SourceBucket = eastBucketName,
                SourceKey = testKey,
                DestinationBucket = westBucketName,
                DestinationKey = testKey
            });
        }

        [DataRow(false, testKey, "/destinationTestKey1.txt", "destinationTestKey1.txt")]
        [DataRow(true, testKeyWithSlash, "/destinationTestKey2.txt", "/destinationTestKey2.txt")]
        [DataTestMethod]
        [TestCategory("S3")]
        public void TestCopyObjectWithLeadingSlash(bool disableTrimmingLeadingSlash, string sourceKey, string destinationKey, string expectedKey)
        {
            var copyObjectResponse = usEastClient.CopyObject(new CopyObjectRequest
            {
                SourceBucket = eastBucketName,
                SourceKey = sourceKey,

                DestinationBucket = westBucketName,
                DestinationKey = destinationKey,
                
                DisableTrimmingLeadingSlash = disableTrimmingLeadingSlash
            });
            Assert.AreEqual(HttpStatusCode.OK, copyObjectResponse.HttpStatusCode);

            var getObjectResponse = Client.GetObject(new GetObjectRequest
            {
                BucketName = westBucketName,
                Key = expectedKey
            });

            using (getObjectResponse.ResponseStream)
            using (var reader = new StreamReader(getObjectResponse.ResponseStream))
            {
                var actualText = reader.ReadToEnd();
                Assert.AreEqual(testContent, actualText);
            }
        }
    }
}
