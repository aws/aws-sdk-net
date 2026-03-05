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

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class CalculatePartSizeTests
    {
        /// <summary>
        /// Tests the exact file size from the bug report (87,241,523,200 bytes / ~81.24 GiB).
        /// This file size caused the original bug because integer division truncated the part size
        /// to 8,724,152 bytes, requiring 10,001 parts which exceeds S3's limit of 10,000.
        /// With Math.Ceiling, the part size becomes 8,724,153 bytes, keeping it at exactly 10,000 parts.
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        public void CalculatePartSize_BugReportFileSize_UsesCeilingToStayWithinPartLimit()
        {
            // Arrange - exact file size from the bug report
            long contentLength = 87241523200L; // ~81.24 GiB
            long targetPartSize = S3Constants.DefaultPartSize; // 8 MiB

            // Act
            long partSize = MultipartUploadCommand.CalculatePartSize(contentLength, targetPartSize);

            // Assert - with Math.Ceiling, part size should be 8,724,153 (not 8,724,152 from integer division)
            long expectedPartSize = (long)Math.Ceiling((double)contentLength / S3Constants.MaxNumberOfParts);
            Assert.AreEqual(expectedPartSize, partSize);
            Assert.AreEqual(8724153L, partSize, "Part size should be rounded up to avoid exceeding max parts");

            // Verify the number of parts is within S3's limit
            long numberOfParts = (long)Math.Ceiling((double)contentLength / partSize);
            Assert.IsTrue(numberOfParts <= S3Constants.MaxNumberOfParts,
                $"Number of parts ({numberOfParts}) should not exceed S3's limit of {S3Constants.MaxNumberOfParts}");
        }

        /// <summary>
        /// Verifies that when content length divides evenly by MaxNumberOfParts,
        /// the result is the same whether using integer division or Math.Ceiling.
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        public void CalculatePartSize_ExactlyDivisible_ReturnsCorrectPartSize()
        {
            // Arrange - content length that divides evenly
            long contentLength = S3Constants.MaxNumberOfParts * 1000L; // 10,000,000 bytes
            long targetPartSize = S3Constants.MinPartSize; // 5 MiB (larger than calculated minimum)

            // Act
            long partSize = MultipartUploadCommand.CalculatePartSize(contentLength, targetPartSize);

            // Assert - target part size is larger, so it should be used
            Assert.AreEqual(targetPartSize, partSize);

            // Verify the number of parts is within S3's limit
            long numberOfParts = (long)Math.Ceiling((double)contentLength / partSize);
            Assert.IsTrue(numberOfParts <= S3Constants.MaxNumberOfParts);
        }

        /// <summary>
        /// Verifies that when content length has a remainder when divided by MaxNumberOfParts,
        /// Math.Ceiling ensures we don't exceed the maximum number of parts.
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        public void CalculatePartSize_WithRemainder_RoundsUpToAvoidExceedingMaxParts()
        {
            // Arrange - content length with remainder when divided by 10,000
            long contentLength = S3Constants.MaxNumberOfParts * 1000L + 1; // 10,000,001 bytes
            long targetPartSize = 500L; // Small target to force use of calculated minimum

            // Act
            long partSize = MultipartUploadCommand.CalculatePartSize(contentLength, targetPartSize);

            // Assert - should round up to 1001 (not 1000 from integer division)
            Assert.AreEqual(1001L, partSize);

            // Verify with truncating division it would exceed limit
            long truncatedPartSize = contentLength / S3Constants.MaxNumberOfParts; // 1000
            long partsWithTruncation = (long)Math.Ceiling((double)contentLength / truncatedPartSize);
            Assert.IsTrue(partsWithTruncation > S3Constants.MaxNumberOfParts,
                "Truncating division would exceed max parts, proving ceiling is necessary");

            // Verify with ceiling division it stays within limit
            long numberOfParts = (long)Math.Ceiling((double)contentLength / partSize);
            Assert.IsTrue(numberOfParts <= S3Constants.MaxNumberOfParts);
        }

        /// <summary>
        /// Verifies that when target part size is larger than the calculated minimum,
        /// the target part size is used.
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        public void CalculatePartSize_TargetLargerThanMinimum_ReturnsTargetPartSize()
        {
            // Arrange
            long contentLength = 100 * 1024 * 1024L; // 100 MiB
            long targetPartSize = S3Constants.DefaultPartSize; // 8 MiB

            // Act
            long partSize = MultipartUploadCommand.CalculatePartSize(contentLength, targetPartSize);

            // Assert - target is larger than minimum needed, so target should be used
            Assert.AreEqual(targetPartSize, partSize);
        }

        /// <summary>
        /// Verifies that for very large files approaching S3's 50 TiB max object size limit,
        /// the part size is calculated correctly to stay within 10,000 parts.
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        public void CalculatePartSize_VeryLargeFile_StaysWithinPartLimit()
        {
            // Arrange - close to S3's max object size of 50 TiB
            long contentLength = 50L * 1024 * 1024 * 1024 * 1024; // 50 TiB
            long targetPartSize = S3Constants.DefaultPartSize;

            // Act
            long partSize = MultipartUploadCommand.CalculatePartSize(contentLength, targetPartSize);

            // Assert - verify part count stays within limit
            long numberOfParts = (long)Math.Ceiling((double)contentLength / partSize);
            Assert.IsTrue(numberOfParts <= S3Constants.MaxNumberOfParts,
                $"Number of parts ({numberOfParts}) should not exceed S3's limit of {S3Constants.MaxNumberOfParts}");
        }

        /// <summary>
        /// Tests multiple file sizes around the 80 GiB boundary where the bug manifests.
        /// </summary>
        [TestMethod]
        [TestCategory("S3")]
        public void CalculatePartSize_FileSizesAround80GiB_AllStayWithinPartLimit()
        {
            long targetPartSize = S3Constants.DefaultPartSize;

            // Test file sizes from 79 GiB to 85 GiB
            for (long gib = 79; gib <= 85; gib++)
            {
                long contentLength = gib * 1024 * 1024 * 1024;
                long partSize = MultipartUploadCommand.CalculatePartSize(contentLength, targetPartSize);
                long numberOfParts = (long)Math.Ceiling((double)contentLength / partSize);

                Assert.IsTrue(numberOfParts <= S3Constants.MaxNumberOfParts,
                    $"File size {gib} GiB: Number of parts ({numberOfParts}) should not exceed {S3Constants.MaxNumberOfParts}");
            }
        }
    }

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

            s3Client
                .Setup(x => x.CompleteMultipartUploadAsync(
                    It.IsAny<CompleteMultipartUploadRequest>(),
                    It.IsAny<CancellationToken>()))
                .ReturnsAsync(new CompleteMultipartUploadResponse
                {
                    BucketName = "test-bucket",
                    Key = "test",
                    ETag = "test-etag",
                    Location = "https://test-bucket.s3.amazonaws.com/test"
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
        public void Validation_ConstructUploadPartRequest()
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
