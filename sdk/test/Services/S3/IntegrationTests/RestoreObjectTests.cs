using Amazon;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class RestoreObjectTests : TestBase<AmazonS3Client>
    {
        private static string bucketName;
        private static string keyName = "test-restore-object";

        [ClassInitialize]
        public static void Initialize(TestContext context)
        {
            bucketName = S3TestUtils.CreateBucketWithWait(Client);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
        }

        [TestMethod]
        public void TestRestoreObject()
        {
            // Put object with Glacier storage class
            Client.PutObject(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = keyName,
                ContentBody = "Test content for restore",
                StorageClass = S3StorageClass.Glacier
            });

            // Restore the object
            var restoreRequest = new RestoreObjectRequest
            {
                BucketName = bucketName,
                Key = keyName,
                Days = 1
            };

            var response = Client.RestoreObject(restoreRequest);
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.Accepted, response.HttpStatusCode);
        }

        [TestMethod]
        public void TestRestoreObjectWithTier()
        {
            // Put object with Glacier storage class
            Client.PutObject(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = keyName,
                ContentBody = "Test content for restore",
                StorageClass = S3StorageClass.Glacier
            });

            // Restore the object
            // note: S3 does not accept RetrievalTier + Days combination for some reason. S3 expects the tier that is wrapped in
            // glacier job parameters when doing a barebones restore with tier and days set.
            // https://github.com/aws/aws-sdk/issues/246
            var restoreRequest = new RestoreObjectRequest
            {
                BucketName = bucketName,
                Key = keyName,
                Days = 1,
                Tier = GlacierJobTier.Standard
            };

            var response = Client.RestoreObject(restoreRequest);
            Assert.IsNotNull(response);
            Assert.AreEqual(HttpStatusCode.Accepted, response.HttpStatusCode);
        }
    }
}
