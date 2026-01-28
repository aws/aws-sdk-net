using Amazon.S3;
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class S3ExtensionsTests : TestBase<AmazonS3Client>
    {
        private static string _bucketName;

        [ClassInitialize]
        public static async Task Setup(TestContext context)
        {
            _bucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client);
        }

        [ClassCleanup]
        public static async Task ClassCleanup()
        {
            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(Client, _bucketName);
        }

        [TestMethod]
        public async Task EnsureBucketExists()
        {
            IAmazonS3 s3Client = Client;
            await s3Client.EnsureBucketExistsAsync(_bucketName);
        }
    }
}