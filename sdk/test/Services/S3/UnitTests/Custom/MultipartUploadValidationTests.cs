using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Transfer.Internal;
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests.S3.NetFramework.Custom
{
    [TestClass]
    public class MultipartUploadValidationTests
    {
        private static string _tempFilePath;
        private const long fileSizeInBytes = 40 * 1024 * 1024;
        
        [ClassInitialize]
        public static void ClassInitialize(TestContext context)
        {
            _tempFilePath = Path.GetTempFileName();

            CreateFileWithSpecificSize(_tempFilePath, fileSizeInBytes);
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            if (File.Exists(_tempFilePath))
            {
                File.Delete(_tempFilePath);
            }
        }

        private static void CreateFileWithSpecificSize(string path, long size)
        {
            using (var fileStream = new FileStream(path, FileMode.Create, FileAccess.Write))
            {
                fileStream.SetLength(size);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task Validation_HappyPath()
        {
            var initiateMultipartUploadResponse = new InitiateMultipartUploadResponse
            {
                UploadId = "test"
            };

            var s3Client = new Mock<AmazonS3Client>();
            s3Client
                .Setup(x => x.InitiateMultipartUploadAsync(
                    It.IsAny<InitiateMultipartUploadRequest>(),
                    It.IsAny<CancellationToken>()))
                .ReturnsAsync(initiateMultipartUploadResponse);

            s3Client
                .Setup(x => x.UploadPartAsync(It.IsAny<UploadPartRequest>(), It.IsAny<CancellationToken>()))
                .ReturnsAsync((UploadPartRequest request, CancellationToken cancellationToken) =>
                {
                    return new UploadPartResponse { PartNumber = request.PartNumber };
                });

            var uploadRequest = new TransferUtilityUploadRequest
            {
                FilePath = _tempFilePath,
                BucketName = "test-bucket",
                Key = "test"
            };
            var multipartUpload = new MultipartUploadCommand(s3Client.Object, new TransferUtilityConfig(), uploadRequest);
            await multipartUpload.ExecuteAsync(new CancellationToken());
        }

        [TestMethod]
        [TestCategory("S3")]
        public async Task Validation_ConstructUploadPartRequest()
        {
            var initiateMultipartUploadResponse = new InitiateMultipartUploadResponse
            {
                UploadId = "test"
            };

            var s3Client = new Mock<AmazonS3Client>();

            s3Client
                .Setup(x => x.InitiateMultipartUploadAsync(
                    It.IsAny<InitiateMultipartUploadRequest>(),
                    It.IsAny<CancellationToken>()))
                .ReturnsAsync(initiateMultipartUploadResponse);

            var uploadRequest = new TransferUtilityUploadRequest
            {
                FilePath = _tempFilePath,
                BucketName = "test-bucket",
                Key = "test"
            };

            var multipartUpload = new MultipartUploadCommand(s3Client.Object, new TransferUtilityConfig(), uploadRequest);

            var partSize = Math.Max(S3Constants.DefaultPartSize, uploadRequest.ContentLength / S3Constants.MaxNumberOfParts);

            long filePosition = 0;
            for (int i = 1; filePosition < uploadRequest.ContentLength; i++)
            {
                var constructUploadPartRequest = multipartUpload.ConstructUploadPartRequest(i, filePosition, initiateMultipartUploadResponse);

                var expectedFileOffset = (i - 1) * partSize;
                var remainingBytes = uploadRequest.ContentLength - expectedFileOffset;
                var isLastPart = false;
                if (remainingBytes <= partSize)
                    isLastPart = true;

                Assert.AreEqual(i, constructUploadPartRequest.PartNumber);
                Assert.AreEqual(isLastPart, constructUploadPartRequest.IsLastPart);
                Assert.AreEqual(
                    isLastPart ? remainingBytes : partSize, 
                    constructUploadPartRequest.PartSize);
                Assert.AreEqual(expectedFileOffset, constructUploadPartRequest.FilePosition);

                filePosition += partSize;
            }

        }
    }
}
