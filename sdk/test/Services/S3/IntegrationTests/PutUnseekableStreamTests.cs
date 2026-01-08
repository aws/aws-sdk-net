using System.IO;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class PutUnseekableStreamTests : TestBase<AmazonS3Client>
    {
        private static string bucketName;

        [ClassInitialize()]
        public static void Initialize(TestContext a)
        {
            StreamWriter writer = File.CreateText("PutObjectFile.txt");
            writer.Write("This is some sample text.!!");
            writer.Close();

            bucketName = S3TestUtils.CreateBucketWithWait(Client, true);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
            BaseClean();
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task TestPutObject()
        {
            var stream = new CustomStream(Encoding.UTF8.GetBytes("Hello, S3!"));
            var putRequest = new PutObjectRequest
            {
                BucketName = bucketName,
                Key = "put-object-unseekable-test.txt",
                InputStream = stream,
                DisablePayloadSigning = true
            };

            await Client.PutObjectAsync(putRequest);

            var getRequest = new GetObjectRequest
            {
                BucketName = bucketName,
                Key = "put-object-unseekable-test.txt"
            };
            using (var getResponse = await Client.GetObjectAsync(getRequest))
            {
                using (var reader = new StreamReader(getResponse.ResponseStream))
                {
                    var content = reader.ReadToEnd();
                    Assert.AreEqual("Hello, S3!", content);
                }
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task TestUploadPart()
        {
            var stream = new CustomStream(Encoding.UTF8.GetBytes("Hello, S3!"));

            var initiateMultipartUploadRequest = new InitiateMultipartUploadRequest
            {
                BucketName = bucketName,
                Key = "upload-part-unseekable-test.txt"
            };

            var initiateMultipartUploadResponse = await Client.InitiateMultipartUploadAsync(initiateMultipartUploadRequest);

            var uploadPartRequest = new UploadPartRequest
            {
                BucketName = bucketName,
                Key = "upload-part-unseekable-test.txt",
                UploadId = initiateMultipartUploadResponse.UploadId,
                PartNumber = 1,
                PartSize = stream.Length,
                InputStream = stream,
                DisablePayloadSigning = true,
                IsLastPart = true,
            };


            var uploadPartResponse = await Client.UploadPartAsync(uploadPartRequest);

            var completeMultipartUploadRequest = new CompleteMultipartUploadRequest
            {
                BucketName = bucketName,
                Key = "upload-part-unseekable-test.txt",
                UploadId = initiateMultipartUploadResponse.UploadId
            };

            completeMultipartUploadRequest.AddPartETags(uploadPartResponse);

            await Client.CompleteMultipartUploadAsync(completeMultipartUploadRequest);

            var getRequest = new GetObjectRequest
            {
                BucketName = bucketName,
                Key = "upload-part-unseekable-test.txt"
            };
            using (var getResponse = await Client.GetObjectAsync(getRequest))
            {
                using (var reader = new StreamReader(getResponse.ResponseStream))
                {
                    var content = reader.ReadToEnd();
                    Assert.AreEqual("Hello, S3!", content);
                }
            }
        }


        public class CustomStream : MemoryStream
        {
            public CustomStream(byte[] buffer) : base(buffer)
            {
            }

            public override bool CanSeek => false;

        }
    }
}
