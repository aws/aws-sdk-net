using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;
using System.Net;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [TestClass]
    public class CopyPartTests : TestBase<AmazonS3Client>
    {
        private const string testContent = "This is the content body!";
        private const string testKeyWithSlash = "/sourceTestKey.txt";

        private string bucketName;

        [TestInitialize]
        public void Initialize()
        {
            bucketName = S3TestUtils.CreateBucketWithWait(Client);

            Client.PutObject(new PutObjectRequest
            {
                BucketName = bucketName,
                Key = testKeyWithSlash,
                ContentBody = testContent
            });
        }

        [TestCleanup]
        public void TestCleanup()
        {
            AmazonS3Util.DeleteS3BucketWithObjects(Client, bucketName);
            BaseClean();
        }

        [TestMethod]
        [TestCategory("S3")]
        public void TestCopyPartWithLeadingSlash()
        {
            var destinationKeyWithSlash = "/destinationTestKey.txt";
            string uploadId = null;

            try
            {
                var multiPartUploadResponse = Client.InitiateMultipartUpload(new InitiateMultipartUploadRequest
                {
                    BucketName = bucketName,
                    Key = destinationKeyWithSlash,
                });

                uploadId = multiPartUploadResponse.UploadId;
                var copyPartResponse = Client.CopyPart(new CopyPartRequest
                {
                    DestinationBucket = bucketName,
                    DestinationKey = destinationKeyWithSlash,
                    
                    SourceBucket = bucketName,
                    SourceKey = testKeyWithSlash,

                    UploadId = uploadId,
                    PartNumber = 1,

                });
                Assert.IsNotNull(copyPartResponse.ETag);
                Assert.IsTrue(copyPartResponse.ETag != null && copyPartResponse.ETag.Length > 0);
                Assert.IsTrue(copyPartResponse.PartNumber == 1);

                var completeUploadRequest = new CompleteMultipartUploadRequest
                {
                    BucketName = bucketName,
                    Key = destinationKeyWithSlash,
                    UploadId = uploadId,
                };
                completeUploadRequest.AddPartETags(copyPartResponse);

                var completeUploadResponse = Client.CompleteMultipartUpload(completeUploadRequest);
                Assert.AreEqual(HttpStatusCode.OK, completeUploadResponse.HttpStatusCode);

                var getObjectResponse = Client.GetObject(new GetObjectRequest
                {
                    BucketName = bucketName,
                    Key = destinationKeyWithSlash
                });

                using (getObjectResponse.ResponseStream)
                using (var reader = new StreamReader(getObjectResponse.ResponseStream))
                {
                    var actualText = reader.ReadToEnd();
                    Assert.AreEqual(testContent, actualText);
                }
            }
            finally
            {
                if (uploadId != null)
                {
                    Client.AbortMultipartUpload(new AbortMultipartUploadRequest
                    {
                        BucketName = bucketName,
                        Key = destinationKeyWithSlash,
                        UploadId = uploadId
                    });
                }
            }
        }
    }
}
