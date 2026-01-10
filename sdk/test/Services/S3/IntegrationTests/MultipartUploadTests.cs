using Microsoft.VisualStudio.TestTools.UnitTesting;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using System.Net;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class MultipartUploadTests : TestBase<AmazonS3Client>
    {
        private static string bucketName;

        [ClassInitialize]
        public static async Task Initialize(TestContext a)
        {
            bucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client, true);
        }

        [ClassCleanup]
        public static async Task ClassCleanup()
        {
            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(Client, bucketName);
            BaseClean();
        }

        /// <summary>
        /// Test so that no regression happens like the one reported below.
        /// https://github.com/aws/aws-sdk-net/issues/3971 
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        public void TestInitiateMultipartUploadWithNoACL()
        {
            var initMpuResponse = Client.InitiateMultipartUpload(new InitiateMultipartUploadRequest
            {
                BucketName = bucketName,
                Key = "test-mpu",
                StorageClass = S3StorageClass.Standard,
                CannedACL = S3CannedACL.NoACL
            });
            Assert.AreEqual<HttpStatusCode>(initMpuResponse.HttpStatusCode, HttpStatusCode.OK);
            if (initMpuResponse.UploadId != null)
            {
                Client.AbortMultipartUpload(new AbortMultipartUploadRequest
                {
                    BucketName = bucketName,
                    Key = "test-mpu",
                    UploadId = initMpuResponse.UploadId
                });
            }

        }
    }
}
