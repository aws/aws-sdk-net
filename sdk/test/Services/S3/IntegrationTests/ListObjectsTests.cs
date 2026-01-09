using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
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
            "a/f",
            "a/g\rh",
            "a/g\ni",
            "a/g&j",
        };

        [ClassInitialize()]
        public static async Task Initialize(TestContext a)
        {
            bucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client);

            foreach (var key in keys)
            {
                if (key.EndsWith("/"))
                {
                    continue;
                }

                await Client.PutObjectAsync(new PutObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ContentBody = content
                });
            }
        }

        [ClassCleanup]
        public static async Task ClassCleanup()
        {
            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(Client, bucketName);
            BaseClean();
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestS3ObjectsContainBucketName()
        {
            var response = Client.ListObjects(new ListObjectsRequest
            {
                BucketName = bucketName
            });

            foreach (var s3Object in response.S3Objects)
            {
                Assert.AreEqual(s3Object.BucketName, bucketName);
            }
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
            Assert.IsFalse(response.IsTruncated.Value);
            Assert.AreEqual(keys.Count - 1, response.KeyCount);
            Assert.AreEqual(keys.Count - 1, response.S3Objects.Count);
            Assert.IsNull(response.ContinuationToken);
            Assert.IsNotNull(response.S3Objects[0].Owner);
            Assert.IsTrue(response.S3Objects.Any(o => o.Key.Contains("\r")));
            Assert.IsTrue(response.S3Objects.Any(o => o.Key.Contains("\n")));
            Assert.IsTrue(response.S3Objects.Any(o => o.Key.Contains("&")));

            response = Client.ListObjectsV2(new ListObjectsV2Request
            {
                BucketName = bucketName,
                MaxKeys = 1,
                StartAfter = keys[0],
                FetchOwner = true
            });
            Assert.IsTrue(response.IsTruncated.Value);
            Assert.AreEqual(1, response.KeyCount);
            Assert.AreEqual(1, response.MaxKeys);
            Assert.AreEqual(1, response.S3Objects.Count);
            Assert.IsNull(response.ContinuationToken);
            Assert.IsNotNull(response.NextContinuationToken);
            Assert.IsNotNull(response.S3Objects[0].Owner);
            Assert.AreEqual(response.S3Objects[0].BucketName, bucketName);

            response = Client.ListObjectsV2(new ListObjectsV2Request
            {
                BucketName = bucketName,
                MaxKeys = 1,
                FetchOwner = true,
                ContinuationToken = response.NextContinuationToken
            });
            Assert.IsTrue(response.IsTruncated.Value);
            Assert.AreEqual(1, response.KeyCount);
            Assert.AreEqual(1, response.MaxKeys);
            Assert.IsNotNull(response.ContinuationToken);
            Assert.IsNotNull(response.NextContinuationToken);
            Assert.AreEqual(1, response.S3Objects.Count);
            Assert.IsNotNull(response.S3Objects[0].Owner);
            Assert.AreEqual(response.S3Objects[0].BucketName, bucketName);

            response = Client.ListObjectsV2(new ListObjectsV2Request
            {
                BucketName = bucketName,
                MaxKeys = 1,
            });
            Assert.IsTrue(response.IsTruncated.Value);
            Assert.AreEqual(1, response.KeyCount);
            Assert.AreEqual(1, response.MaxKeys);
            Assert.AreEqual(1, response.S3Objects.Count);
            Assert.IsNull(response.ContinuationToken);
            Assert.IsNotNull(response.NextContinuationToken);
            Assert.IsNull(response.S3Objects[0].Owner);
            Assert.AreEqual(response.S3Objects[0].BucketName, bucketName);

            response = Client.ListObjectsV2(new ListObjectsV2Request
            {
                BucketName = bucketName,
                MaxKeys = 1,
                ContinuationToken = response.NextContinuationToken
            });
            Assert.IsTrue(response.IsTruncated.Value);
            Assert.AreEqual(1, response.KeyCount);
            Assert.AreEqual(1, response.MaxKeys);
            Assert.IsNotNull(response.ContinuationToken);
            Assert.IsNotNull(response.NextContinuationToken);
            Assert.AreEqual(1, response.S3Objects.Count);
            Assert.IsNull(response.S3Objects[0].Owner);
            Assert.AreEqual(response.S3Objects[0].BucketName, bucketName);
        }
    }
}