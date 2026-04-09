using System;
using System.IO;
using System.Threading.Tasks;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Integration tests for TransferUtility.DownloadWithResponseAsync functionality.
    /// These tests verify end-to-end functionality with actual S3 operations and file I/O.
    ///
    /// Most test scenarios (buffer sizes, part boundaries, error handling) are covered
    /// in unit tests with mocked dependencies for faster execution.
    ///
    /// These integration tests focus on:
    /// - Basic single-part downloads to files
    /// - Basic multipart downloads to files
    /// - Real S3 metadata preservation
    /// - File handling (temp files, atomic writes, cleanup)
    /// - Checksum validation
    /// </summary>
    [Trait("Category", "S3")]
    public class TransferUtilityDownloadWithResponseTests : TransferUtilityTestBase
    {
        private static readonly long MB = 1024 * 1024;

        public TransferUtilityDownloadWithResponseTests(TransferUtilityFixture fixture) : base(fixture) { }

        [Fact]
        public async Task DownloadWithResponse_SinglePart_SmallObject()
        {
            var objectSize = 2 * MB;
            var (key, expectedChecksum) = await CreateTestObjectWithChecksum(objectSize);
            var downloadPath = Path.Combine(_basePath, key);

            var response = await _transfer.DownloadWithResponseAsync(downloadPath, _bucketName, key);

            Assert.NotNull(response);
            ValidateResponse(response, objectSize);
            
            Assert.True(File.Exists(downloadPath));
            var downloadedChecksum = CalculateFileChecksum(downloadPath);
            Assert.Equal(expectedChecksum, downloadedChecksum);
            
            var fileInfo = new FileInfo(downloadPath);
            Assert.Equal(objectSize, fileInfo.Length);
            
            VerifyNoTempFilesExist(downloadPath);
        }

        [Fact]
        public async Task DownloadWithResponse_SinglePart_EmptyObject()
        {
            var key = UtilityMethods.GenerateName("empty-object");
            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                ContentBody = ""
            });
            var downloadPath = Path.Combine(_basePath, key);

            var response = await _transfer.DownloadWithResponseAsync(downloadPath, _bucketName, key);

            Assert.NotNull(response);
            Assert.Equal(0, response.Headers.ContentLength);
            Assert.Null(response.ContentRange);
            
            Assert.True(File.Exists(downloadPath));
            var fileInfo = new FileInfo(downloadPath);
            Assert.Equal(0, fileInfo.Length);
            
            VerifyNoTempFilesExist(downloadPath);
        }

        [Fact]
        public async Task DownloadWithResponse_Multipart_BasicDownload()
        {
            var objectSize = 17 * MB;
            var partSize = 8 * MB;
            var key = UtilityMethods.GenerateName("multipart-download-test");
            var uploadPath = Path.Combine(_basePath, key + "-upload");
            var downloadPath = Path.Combine(_basePath, key);
            
            UtilityMethods.GenerateFile(uploadPath, objectSize);
            var expectedChecksum = CalculateFileChecksum(uploadPath);
            
            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = _bucketName,
                Key = key,
                FilePath = uploadPath,
                PartSize = partSize
            };
            
            await _transfer.UploadAsync(uploadRequest);

            var metadata = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = _bucketName,
                Key = key,
                PartNumber = 1
            });
            Assert.True(metadata.PartsCount > 1);

            var downloadRequest = new TransferUtilityDownloadRequest
            {
                BucketName = _bucketName,
                Key = key,
                FilePath = downloadPath,
                PartSize = partSize
            };

            var response = await _transfer.DownloadWithResponseAsync(downloadRequest);

            Assert.NotNull(response);
            ValidateResponse(response, objectSize);
            
            Assert.True(File.Exists(downloadPath));
            var downloadedChecksum = CalculateFileChecksum(downloadPath);
            Assert.Equal(expectedChecksum, downloadedChecksum);
            
            var fileInfo = new FileInfo(downloadPath);
            Assert.Equal(objectSize, fileInfo.Length);
            
            VerifyNoTempFilesExist(downloadPath);
            File.Delete(uploadPath);
        }

        [Fact]
        public async Task DownloadWithResponse_RangeStrategy_SmallSinglePartObject()
        {
            var objectSize = 2 * MB;
            var key = UtilityMethods.GenerateName("range-single-part-test");
            var uploadPath = Path.Combine(_basePath, key + "-upload");
            var downloadPath = Path.Combine(_basePath, key);
            
            UtilityMethods.GenerateFile(uploadPath, objectSize);
            var expectedChecksum = CalculateFileChecksum(uploadPath);
            
            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                FilePath = uploadPath
            });

            var downloadRequest = new TransferUtilityDownloadRequest
            {
                BucketName = _bucketName,
                Key = key,
                FilePath = downloadPath,
                MultipartDownloadType = MultipartDownloadType.RANGE,
                PartSize = 8 * MB
            };

            var response = await _transfer.DownloadWithResponseAsync(downloadRequest);

            Assert.NotNull(response);
            ValidateResponse(response, objectSize);
            Assert.NotNull(response.ContentRange);
            Assert.StartsWith("bytes ", response.ContentRange);
            
            Assert.True(File.Exists(downloadPath));
            var downloadedChecksum = CalculateFileChecksum(downloadPath);
            Assert.Equal(expectedChecksum, downloadedChecksum);
            
            VerifyNoTempFilesExist(downloadPath);
            File.Delete(uploadPath);
        }

        [Fact]
        public async Task DownloadWithResponse_Multipart_RangeDownload()
        {
            var objectSize = 17 * MB;
            var uploadPartSize = 8 * MB;
            var downloadPartSize = 6 * MB;
            var key = UtilityMethods.GenerateName("multipart-range-test");
            var uploadPath = Path.Combine(_basePath, key + "-upload");
            var downloadPath = Path.Combine(_basePath, key);
            
            UtilityMethods.GenerateFile(uploadPath, objectSize);
            var expectedChecksum = CalculateFileChecksum(uploadPath);
            
            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = _bucketName,
                Key = key,
                FilePath = uploadPath,
                PartSize = uploadPartSize
            };
            
            await _transfer.UploadAsync(uploadRequest);

            var metadata = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = _bucketName,
                Key = key,
                PartNumber = 1
            });
            Assert.True(metadata.PartsCount > 1);

            var downloadRequest = new TransferUtilityDownloadRequest
            {
                BucketName = _bucketName,
                Key = key,
                FilePath = downloadPath,
                MultipartDownloadType = MultipartDownloadType.RANGE,
                PartSize = downloadPartSize
            };

            var response = await _transfer.DownloadWithResponseAsync(downloadRequest);

            Assert.NotNull(response);
            ValidateResponse(response, objectSize);
            
            Assert.True(File.Exists(downloadPath));
            var downloadedChecksum = CalculateFileChecksum(downloadPath);
            Assert.Equal(expectedChecksum, downloadedChecksum);
            
            VerifyNoTempFilesExist(downloadPath);
            File.Delete(uploadPath);
        }

        [Fact]
        public async Task DownloadWithResponse_MultipartObjectWithChecksums_NullsCompositeChecksums()
        {
            var objectSize = 17 * MB;
            var key = UtilityMethods.GenerateName("composite-checksum-test");
            var uploadPath = Path.Combine(_basePath, key + "-upload");
            var downloadPath = Path.Combine(_basePath, key);
            
            UtilityMethods.GenerateFile(uploadPath, objectSize);

            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = _bucketName,
                Key = key,
                FilePath = uploadPath,
                ChecksumAlgorithm = ChecksumAlgorithm.CRC32,
                PartSize = 8 * MB
            };

            await _transfer.UploadAsync(uploadRequest);

            var metadata = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = _bucketName,
                Key = key,
                PartNumber = 1
            });
            Assert.True(metadata.PartsCount > 1);

            var downloadRequest = new TransferUtilityDownloadRequest
            {
                BucketName = _bucketName,
                Key = key,
                FilePath = downloadPath,
                ChecksumMode = ChecksumMode.ENABLED
            };

            var response = await _transfer.DownloadWithResponseAsync(downloadRequest);

            Assert.Equal(ChecksumType.COMPOSITE, response.ChecksumType);
            Assert.Null(response.ChecksumCRC32);
            Assert.Null(response.ChecksumCRC32C);
            Assert.Null(response.ChecksumCRC64NVME);
            Assert.Null(response.ChecksumSHA1);
            Assert.Null(response.ChecksumSHA256);
            Assert.NotNull(response.ETag);
            Assert.True(response.Headers.ContentLength > 0);
            
            Assert.True(File.Exists(downloadPath));
            var fileInfo = new FileInfo(downloadPath);
            Assert.Equal(objectSize, fileInfo.Length);
            
            VerifyNoTempFilesExist(downloadPath);
            File.Delete(uploadPath);
        }

        [Fact]
        public async Task DownloadWithResponse_PreservesMetadata()
        {
            var objectSize = 1 * MB;
            var key = UtilityMethods.GenerateName("metadata-test");
            var uploadPath = Path.Combine(_basePath, key + "-upload");
            var downloadPath = Path.Combine(_basePath, key);
            
            UtilityMethods.GenerateFile(uploadPath, objectSize);

            var putRequest = new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                FilePath = uploadPath,
                ContentType = "application/octet-stream"
            };
            putRequest.Metadata.Add("test-key", "test-value");
            putRequest.Metadata.Add("custom-header", "custom-value");

            await _client.PutObjectAsync(putRequest);

            var response = await _transfer.DownloadWithResponseAsync(downloadPath, _bucketName, key);

            Assert.NotNull(response);
            Assert.Equal("application/octet-stream", response.Headers.ContentType);
            Assert.True(response.Metadata.Keys.Contains("x-amz-meta-test-key"));
            Assert.Equal("test-value", response.Metadata["x-amz-meta-test-key"]);
            Assert.True(response.Metadata.Keys.Contains("x-amz-meta-custom-header"));
            Assert.Equal("custom-value", response.Metadata["x-amz-meta-custom-header"]);
            
            Assert.True(File.Exists(downloadPath));
            VerifyNoTempFilesExist(downloadPath);
            File.Delete(uploadPath);
        }

        [Fact]
        public async Task DownloadWithResponse_PreservesETag()
        {
            var objectSize = 1 * MB;
            var key = UtilityMethods.GenerateName("etag-test");
            var uploadPath = Path.Combine(_basePath, key + "-upload");
            var downloadPath = Path.Combine(_basePath, key);
            
            UtilityMethods.GenerateFile(uploadPath, objectSize);

            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                FilePath = uploadPath
            });

            var metadata = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = _bucketName,
                Key = key
            });
            var expectedETag = metadata.ETag;

            var response = await _transfer.DownloadWithResponseAsync(downloadPath, _bucketName, key);

            Assert.NotNull(response.ETag);
            Assert.Equal(expectedETag, response.ETag);
            
            Assert.True(File.Exists(downloadPath));
            VerifyNoTempFilesExist(downloadPath);
            File.Delete(uploadPath);
        }

        [Fact]
        public async Task DownloadWithResponse_CreatesDirectoryIfNeeded()
        {
            var objectSize = 2 * MB;
            var (key, expectedChecksum) = await CreateTestObjectWithChecksum(objectSize);
            
            var nestedDir = Path.Combine(_basePath, "level1", "level2", "level3");
            var downloadPath = Path.Combine(nestedDir, key);
            
            Assert.False(Directory.Exists(nestedDir));

            var response = await _transfer.DownloadWithResponseAsync(downloadPath, _bucketName, key);

            Assert.NotNull(response);
            Assert.True(Directory.Exists(nestedDir));
            Assert.True(File.Exists(downloadPath));
            
            var downloadedChecksum = CalculateFileChecksum(downloadPath);
            Assert.Equal(expectedChecksum, downloadedChecksum);
            
            VerifyNoTempFilesExist(downloadPath);
        }

        [Fact]
        public async Task DownloadWithResponse_OverwritesExistingFile()
        {
            var objectSize = 2 * MB;
            var (key, expectedChecksum) = await CreateTestObjectWithChecksum(objectSize);
            var downloadPath = Path.Combine(_basePath, key);
            
            var existingContent = new byte[1024];
            new Random().NextBytes(existingContent);
            File.WriteAllBytes(downloadPath, existingContent);
            
            var existingChecksum = CalculateFileChecksum(downloadPath);
            Assert.NotEqual(expectedChecksum, existingChecksum);

            var response = await _transfer.DownloadWithResponseAsync(downloadPath, _bucketName, key);

            Assert.NotNull(response);
            Assert.True(File.Exists(downloadPath));
            
            var downloadedChecksum = CalculateFileChecksum(downloadPath);
            Assert.Equal(expectedChecksum, downloadedChecksum);
            
            var fileInfo = new FileInfo(downloadPath);
            Assert.Equal(objectSize, fileInfo.Length);
            
            VerifyNoTempFilesExist(downloadPath);
        }

        /// <summary>
        /// Creates a test object in S3 with the specified size and returns its key and checksum.
        /// </summary>
        private async Task<(string key, string checksum)> CreateTestObjectWithChecksum(long objectSize)
        {
            var key = UtilityMethods.GenerateName("download-test");
            var filePath = Path.Combine(_basePath, key);
            UtilityMethods.GenerateFile(filePath, objectSize);
            
            var checksum = CalculateFileChecksum(filePath);
            
            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                FilePath = filePath
            });
            
            File.Delete(filePath);
            
            return (key, checksum);
        }

        /// <summary>
        /// Calculates the MD5 checksum of a file.
        /// </summary>
        private static string CalculateFileChecksum(string filePath)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            using (var stream = File.OpenRead(filePath))
            {
                var hash = md5.ComputeHash(stream);
                return Convert.ToBase64String(hash);
            }
        }

        /// <summary>
        /// Validates that the response contains expected values.
        /// </summary>
        private static void ValidateResponse(TransferUtilityDownloadResponse response, long expectedSize)
        {
            Assert.NotNull(response.Headers);
            Assert.Equal(expectedSize, response.Headers.ContentLength);
            Assert.NotNull(response.ETag);
        }

        /// <summary>
        /// Verifies that no temporary files remain after download completion.
        /// Temp files use the pattern: {originalPath}.s3tmp.{8-char-id}
        /// </summary>
        private static void VerifyNoTempFilesExist(string filePath)
        {
            var directory = Path.GetDirectoryName(filePath);
            var fileName = Path.GetFileName(filePath);
            
            if (Directory.Exists(directory))
            {
                var tempFiles = Directory.GetFiles(directory, fileName + ".s3tmp.*");
                Assert.Equal(0, tempFiles.Length);
            }
        }
    }
}
