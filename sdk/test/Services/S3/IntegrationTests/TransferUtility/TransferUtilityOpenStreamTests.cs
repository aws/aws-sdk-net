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
    [Trait("Category", "S3")]
    public class TransferUtilityOpenStreamTests : TransferUtilityTestBase
    {
        private static readonly long MB = 1024 * 1024;

        public TransferUtilityOpenStreamTests(TransferUtilityFixture fixture) : base(fixture) { }

        [Fact]
        public async Task OpenStream_SinglePart_SmallObject()
        {
            var objectSize = 2 * MB;
            var (key, expectedChecksum) = await CreateTestObjectWithChecksum(objectSize);

            using (var response = await _transfer.OpenStreamWithResponseAsync(_bucketName, key))
            {
                Assert.NotNull(response);
                Assert.NotNull(response.ResponseStream);
                ValidateHeaders(response, objectSize);

                var downloadedBytes = await ReadStreamToByteArray(response.ResponseStream, objectSize, (int)(1 * MB));
                var actualChecksum = CalculateChecksum(downloadedBytes);
                
                Assert.Equal(expectedChecksum, actualChecksum);
                Assert.Equal(objectSize, downloadedBytes.Length);
            }
        }

        [Fact]
        public async Task OpenStream_SinglePart_EmptyObject()
        {
            var key = UtilityMethods.GenerateName("empty-object");
            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                ContentBody = ""
            });

            using (var response = await _transfer.OpenStreamWithResponseAsync(_bucketName, key))
            {
                Assert.NotNull(response);
                Assert.NotNull(response.ResponseStream);
                Assert.Equal(0, response.Headers.ContentLength);
                
                var buffer = new byte[1024];
                var bytesRead = await response.ResponseStream.ReadAsync(buffer, 0, buffer.Length);
                Assert.Equal(0, bytesRead);
            }
        }

        [Fact]
        public async Task OpenStream_Multipart_BasicDownload()
        {
            var objectSize = 17 * MB;
            var partSize = 8 * MB;
            var key = UtilityMethods.GenerateName("openstream-test");
            var filePath = Path.Combine(_basePath, key);
            UtilityMethods.GenerateFile(filePath, objectSize);
            
            var expectedChecksum = CalculateFileChecksum(filePath);
            
            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = _bucketName,
                Key = key,
                FilePath = filePath,
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

            var request = new TransferUtilityOpenStreamRequest
            {
                BucketName = _bucketName,
                Key = key,
                PartSize = partSize
            };

            using (var response = await _transfer.OpenStreamWithResponseAsync(request))
            {
                Assert.NotNull(response);
                Assert.NotNull(response.ResponseStream);
                ValidateHeaders(response, objectSize);

                var downloadedBytes = await ReadStreamToByteArray(response.ResponseStream, objectSize, (int)(2 * MB));
                var actualChecksum = CalculateChecksum(downloadedBytes);
                
                Assert.Equal(expectedChecksum, actualChecksum);
                Assert.Equal(objectSize, downloadedBytes.Length);
            }
        }

        [Fact]
        public async Task OpenStream_Multipart_RangeDownload()
        {
            var objectSize = 17 * MB;
            var uploadPartSize = 8 * MB;
            var downloadPartSize = 6 * MB;
            var key = UtilityMethods.GenerateName("openstream-range-test");
            var filePath = Path.Combine(_basePath, key);
            UtilityMethods.GenerateFile(filePath, objectSize);
            
            var expectedChecksum = CalculateFileChecksum(filePath);
            
            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = _bucketName,
                Key = key,
                FilePath = filePath,
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

            var request = new TransferUtilityOpenStreamRequest
            {
                BucketName = _bucketName,
                Key = key,
                MultipartDownloadType = MultipartDownloadType.RANGE,
                PartSize = downloadPartSize
            };

            using (var response = await _transfer.OpenStreamWithResponseAsync(request))
            {
                Assert.NotNull(response);
                Assert.NotNull(response.ResponseStream);
                ValidateHeaders(response, objectSize);

                var downloadedBytes = await ReadStreamToByteArray(response.ResponseStream, objectSize, (int)(2 * MB));
                var actualChecksum = CalculateChecksum(downloadedBytes);
                
                Assert.Equal(expectedChecksum, actualChecksum);
                Assert.Equal(objectSize, downloadedBytes.Length);
            }
        }

        [Fact]
        public async Task OpenStream_MultipartObjectWithChecksums_NullsCompositeChecksums()
        {
            var objectSize = 17 * MB;
            var key = UtilityMethods.GenerateName("composite-checksum-test");
            var filePath = Path.Combine(_basePath, key);
            UtilityMethods.GenerateFile(filePath, objectSize);

            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = _bucketName,
                Key = key,
                FilePath = filePath,
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

            var openStreamRequest = new TransferUtilityOpenStreamRequest
            {
                BucketName = _bucketName,
                Key = key,
                ChecksumMode = ChecksumMode.ENABLED
            };

            using (var response = await _transfer.OpenStreamWithResponseAsync(openStreamRequest))
            {
                Assert.Equal(ChecksumType.COMPOSITE, response.ChecksumType);
                Assert.Null(response.ChecksumCRC32);
                Assert.Null(response.ChecksumCRC32C);
                Assert.Null(response.ChecksumCRC64NVME);
                Assert.Null(response.ChecksumSHA1);
                Assert.Null(response.ChecksumSHA256);
                Assert.NotNull(response.ETag);
                Assert.True(response.Headers.ContentLength > 0);
                Assert.NotNull(response.ResponseStream);

                var buffer = new byte[1024];
                var bytesRead = await response.ResponseStream.ReadAsync(buffer, 0, buffer.Length);
                Assert.True(bytesRead > 0);
            }
        }

        [Fact]
        public async Task OpenStream_PreservesMetadata()
        {
            var objectSize = 1 * MB;
            var key = UtilityMethods.GenerateName("metadata-test");
            var filePath = Path.Combine(_basePath, key);
            UtilityMethods.GenerateFile(filePath, objectSize);

            var putRequest = new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                FilePath = filePath,
                ContentType = "application/octet-stream"
            };
            putRequest.Metadata.Add("test-key", "test-value");
            putRequest.Metadata.Add("custom-header", "custom-value");

            await _client.PutObjectAsync(putRequest);

            using (var response = await _transfer.OpenStreamWithResponseAsync(_bucketName, key))
            {
                Assert.NotNull(response);
                Assert.Equal("application/octet-stream", response.Headers.ContentType);
                Assert.True(response.Metadata.Keys.Contains("x-amz-meta-test-key"));
                Assert.Equal("test-value", response.Metadata["x-amz-meta-test-key"]);
                Assert.True(response.Metadata.Keys.Contains("x-amz-meta-custom-header"));
                Assert.Equal("custom-value", response.Metadata["x-amz-meta-custom-header"]);
            }
        }

        [Fact]
        public async Task OpenStream_PreservesETag()
        {
            var objectSize = 1 * MB;
            var key = UtilityMethods.GenerateName("etag-test");
            var filePath = Path.Combine(_basePath, key);
            UtilityMethods.GenerateFile(filePath, objectSize);

            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                FilePath = filePath
            });

            var metadata = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = _bucketName,
                Key = key
            });
            var expectedETag = metadata.ETag;

            using (var response = await _transfer.OpenStreamWithResponseAsync(_bucketName, key))
            {
                Assert.NotNull(response.ETag);
                Assert.Equal(expectedETag, response.ETag);
            }
        }

        [Theory]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(10)]
        public async Task OpenStream_WithVariousMaxInMemoryParts_DownloadsSuccessfully(int maxInMemoryParts)
        {
            var objectSize = 17 * MB;
            var uploadPartSize = 8 * MB;
            var downloadPartSize = 8 * MB;
            var key = UtilityMethods.GenerateName($"maxinmemory-{maxInMemoryParts}-test");
            var filePath = Path.Combine(_basePath, key);
            UtilityMethods.GenerateFile(filePath, objectSize);
            
            var expectedChecksum = CalculateFileChecksum(filePath);
            
            var uploadRequest = new TransferUtilityUploadRequest
            {
                BucketName = _bucketName,
                Key = key,
                FilePath = filePath,
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

            var downloadRequest = new TransferUtilityOpenStreamRequest
            {
                BucketName = _bucketName,
                Key = key,
                PartSize = downloadPartSize,
                MaxInMemoryParts = maxInMemoryParts
            };

            using (var response = await _transfer.OpenStreamWithResponseAsync(downloadRequest))
            {
                Assert.NotNull(response);
                Assert.NotNull(response.ResponseStream);

                var downloadedBytes = await ReadStreamToByteArray(response.ResponseStream, objectSize, (int)(2 * MB));
                var actualChecksum = CalculateChecksum(downloadedBytes);
                
                Assert.Equal(expectedChecksum, actualChecksum);
                Assert.Equal(objectSize, downloadedBytes.Length);
            }
        }

        private async Task<(string key, string checksum)> CreateTestObjectWithChecksum(long objectSize)
        {
            var key = UtilityMethods.GenerateName("openstream-test");
            var filePath = Path.Combine(_basePath, key);
            UtilityMethods.GenerateFile(filePath, objectSize);
            
            var checksum = CalculateFileChecksum(filePath);
            
            await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = key,
                FilePath = filePath
            });
            
            return (key, checksum);
        }

        private static string CalculateFileChecksum(string filePath)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            using (var stream = File.OpenRead(filePath))
            {
                var hash = md5.ComputeHash(stream);
                return Convert.ToBase64String(hash);
            }
        }

        private static void ValidateHeaders(TransferUtilityOpenStreamResponse response, long expectedSize)
        {
            Assert.NotNull(response.Headers);
            Assert.Equal(expectedSize, response.Headers.ContentLength);
            Assert.NotNull(response.ETag);
        }

        private static async Task<byte[]> ReadStreamToByteArray(Stream stream, long totalSize, int bufferSize)
        {
            var result = new byte[totalSize];
            var buffer = new byte[bufferSize];
            long totalRead = 0;
            
            int bytesRead;
            while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length)) > 0)
            {
                Array.Copy(buffer, 0, result, totalRead, bytesRead);
                totalRead += bytesRead;
            }
            
            Assert.Equal(totalSize, totalRead);
            return result;
        }

        private static string CalculateChecksum(byte[] data)
        {
            using (var md5 = System.Security.Cryptography.MD5.Create())
            {
                var hash = md5.ComputeHash(data);
                return Convert.ToBase64String(hash);
            }
        }
    }
}
