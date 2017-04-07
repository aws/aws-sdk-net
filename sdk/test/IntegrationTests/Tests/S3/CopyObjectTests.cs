using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class CopyObjectTests : TestBase<AmazonS3Client>
    {
        private const string testContent = "This is the content body!";
        private const string testKey = "testKey.txt";

        private string eastBucketName;
        private string westBucketName;

        private AmazonS3Client usEastClient;

        [TestInitialize]
        public void Initialize()
        {
            usEastClient = new AmazonS3Client(RegionEndpoint.USEast1);
            eastBucketName = S3TestUtils.CreateBucket(usEastClient);
            usEastClient.PutObject(new PutObjectRequest
            {
                BucketName = eastBucketName,
                Key = testKey,
                ContentBody = testContent
            });
            var usWestClient = new AmazonS3Client(RegionEndpoint.USWest1);
            westBucketName = S3TestUtils.CreateBucket(usWestClient);
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
    }
}