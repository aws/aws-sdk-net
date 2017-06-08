using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;

using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Tests for versioned S3 buckets
    /// </summary>
    [TestClass]
    public class VersioningTests : TestBase<AmazonS3Client>
    {
        private const string content = "Test content";
        private const string key = "test.txt";

        private static string bucketName;

        [ClassInitialize()]
        public static void Initialize(TestContext tc)
        {
            bucketName = S3TestUtils.CreateBucket(Client);
            Client.PutBucketVersioning(new PutBucketVersioningRequest
            {
                BucketName = bucketName,
                VersioningConfig = new S3BucketVersioningConfig
                {
                    Status = VersionStatus.Enabled
                }
            });
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
            BaseClean();
        }


        [TestMethod]
        [TestCategory("S3")]
        public void TestVersionBucketName()
        {
            var count = 5;
            for (int i = 0; i < count; i++)
            {
                Client.PutObject(new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ContentBody = content
                });
            }

            var versions = Client.ListVersions(bucketName).Versions;
            Assert.AreEqual(count, versions.Count);

            foreach(var version in versions)
            {
                Assert.AreEqual(bucketName, version.BucketName);
                Assert.AreEqual(key, version.Key);
            }
        }
    }
}