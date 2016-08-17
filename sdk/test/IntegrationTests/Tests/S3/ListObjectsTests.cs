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
    /// Summary description for PutObjectTest
    /// </summary>
    [TestClass]
    public class ListObjectsTests : TestBase<AmazonS3Client>
    {
        private const string content = "Test content";
        private static string bucketName;
        private static List<string> keys = new List<string>
        {
            //"a/",
            //"a/b/",
            "a/b/c",
            "a/b/d",
            "a/e",
            "a/f"
        };

        [ClassInitialize()]
        public static void Initialize(TestContext a)
        {
            bucketName = S3TestUtils.CreateBucket(Client);

            foreach(var key in keys)
            {
                if (key.EndsWith("/"))
                    continue;

                Client.PutObject(new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ContentBody = content
                });
            }
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
            BaseClean();
        }


        [TestMethod]
        [TestCategory("S3")]
        public void TestListV2()
        {
            var response = Client.ListObjectsV2(new ListObjectsV2Request
            {
                BucketName = bucketName,
                StartAfter = keys[0],
                FetchOwner = true
            });
            Assert.IsFalse(response.IsTruncated);
            Assert.AreEqual(keys.Count - 1, response.KeyCount);
            Assert.AreEqual(keys.Count - 1, response.S3Objects.Count);
            Assert.IsNull(response.ContinuationToken);
            Assert.IsNotNull(response.S3Objects[0].Owner);

            response = Client.ListObjectsV2(new ListObjectsV2Request
            {
                BucketName = bucketName,
                MaxKeys = 1,
                StartAfter = keys[0],
                FetchOwner = true
            });
            Assert.IsTrue(response.IsTruncated);
            Assert.AreEqual(1, response.KeyCount);
            Assert.AreEqual(1, response.MaxKeys);
            Assert.AreEqual(1, response.S3Objects.Count);
            Assert.IsNull(response.ContinuationToken);
            Assert.IsNotNull(response.NextContinuationToken);
            Assert.IsNotNull(response.S3Objects[0].Owner);

            response = Client.ListObjectsV2(new ListObjectsV2Request
            {
                BucketName = bucketName,
                MaxKeys = 1,
                FetchOwner = true,
                ContinuationToken = response.NextContinuationToken
            });
            Assert.IsTrue(response.IsTruncated);
            Assert.AreEqual(1, response.KeyCount);
            Assert.AreEqual(1, response.MaxKeys);
            Assert.IsNotNull(response.ContinuationToken);
            Assert.IsNotNull(response.NextContinuationToken);
            Assert.AreEqual(1, response.S3Objects.Count);
            Assert.IsNotNull(response.S3Objects[0].Owner);


            response = Client.ListObjectsV2(new ListObjectsV2Request
            {
                BucketName = bucketName,
                MaxKeys = 1,
            });
            Assert.IsTrue(response.IsTruncated);
            Assert.AreEqual(1, response.KeyCount);
            Assert.AreEqual(1, response.MaxKeys);
            Assert.AreEqual(1, response.S3Objects.Count);
            Assert.IsNull(response.ContinuationToken);
            Assert.IsNotNull(response.NextContinuationToken);
            Assert.IsNull(response.S3Objects[0].Owner);

            response = Client.ListObjectsV2(new ListObjectsV2Request
            {
                BucketName = bucketName,
                MaxKeys = 1,
                ContinuationToken = response.NextContinuationToken
            });
            Assert.IsTrue(response.IsTruncated);
            Assert.AreEqual(1, response.KeyCount);
            Assert.AreEqual(1, response.MaxKeys);
            Assert.IsNotNull(response.ContinuationToken);
            Assert.IsNotNull(response.NextContinuationToken);
            Assert.AreEqual(1, response.S3Objects.Count);
            Assert.IsNull(response.S3Objects[0].Owner);
        }

    }
}