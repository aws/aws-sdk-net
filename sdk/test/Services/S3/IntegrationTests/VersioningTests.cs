using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

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

        [ClassInitialize]
        public static async Task Initialize(TestContext tc)
        {
            bucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client);
            await Client.PutBucketVersioningAsync(new PutBucketVersioningRequest
            {
                BucketName = bucketName,
                VersioningConfig = new S3BucketVersioningConfig
                {
                    Status = VersionStatus.Enabled
                }
            });

            await S3TestUtils.WaitForConsistencyAsync(async () =>
            {
                var res = await Client.GetBucketVersioningAsync(new GetBucketVersioningRequest
                {
                    BucketName = bucketName
                });
                return res.VersioningConfig?.Status == VersionStatus.Enabled ? res : null;
            });
        }

        [ClassCleanup]
        public static async Task ClassCleanup()
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
                        
            var response = S3TestUtils.WaitForConsistency(() =>
            {
                var res = Client.ListVersions(bucketName);                
                return res.Versions?.Count == count ? res : null;
            });

            var versions = response.Versions;
            Assert.AreEqual(count, versions.Count);

            foreach(var version in versions)
            {
                Assert.AreEqual(bucketName, version.BucketName);
                Assert.AreEqual(key, version.Key);
            }
        }
    }
}