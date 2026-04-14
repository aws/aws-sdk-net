using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.Util;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class TransferUtilityUploadWithResponseTests : TransferUtilityTestBase
    {
        public TransferUtilityUploadWithResponseTests(TransferUtilityFixture fixture) : base(fixture)
        {
        }

        [Fact]
        public async Task UploadWithResponseAsyncSmallFileTest()
        {
            var fileName = UtilityMethods.GenerateName(@"UploadWithResponseTest\SmallFile");
            var path = Path.Combine(_basePath, fileName);
            var fileSize = 1 * TransferUtilityTestHelpers.MEG_SIZE;
            UtilityMethods.GenerateFile(path, fileSize);

            var request = new TransferUtilityUploadRequest
            {
                BucketName = _bucketName,
                FilePath = path,
                Key = fileName,
                ContentType = octetStreamContentType
            };

            var response = await _transfer.UploadWithResponseAsync(request);
            Assert.NotNull(response);
            Assert.NotNull(response.ETag);
            Assert.True(response.ETag.Length > 0);

            var metadata = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = _bucketName,
                Key = fileName
            });
            Assert.Equal(fileSize, metadata.ContentLength);
            Assert.Equal(response.ETag, metadata.ETag);
        }

        [Fact]
        public async Task UploadWithResponseAsyncLargeFileTest()
        {
            var fileName = UtilityMethods.GenerateName(@"UploadWithResponseTest\LargeFile");
            var path = Path.Combine(_basePath, fileName);
            var fileSize = 17 * TransferUtilityTestHelpers.MEG_SIZE;
            UtilityMethods.GenerateFile(path, fileSize);

            var request = new TransferUtilityUploadRequest
            {
                BucketName = _bucketName,
                FilePath = path,
                Key = fileName,
                ContentType = octetStreamContentType
            };

            var response = await _transfer.UploadWithResponseAsync(request);
            Assert.NotNull(response);
            Assert.NotNull(response.ETag);
            Assert.True(response.ETag.Length > 0);

            var metadata = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = _bucketName,
                Key = fileName
            });
            Assert.Equal(fileSize, metadata.ContentLength);
            Assert.Equal(response.ETag, metadata.ETag);
        }

        [Fact]
        public async Task UploadWithResponseAsyncStreamTest()
        {
            var fileName = UtilityMethods.GenerateName(@"UploadWithResponseTest\StreamFile");
            var path = Path.Combine(_basePath, fileName);
            var fileSize = 1 * TransferUtilityTestHelpers.MEG_SIZE;
            UtilityMethods.GenerateFile(path, fileSize);

            using (var fileStream = File.OpenRead(path))
            {
                var request = new TransferUtilityUploadRequest
                {
                    BucketName = _bucketName,
                    InputStream = fileStream,
                    Key = fileName,
                    ContentType = octetStreamContentType
                };

                var response = await _transfer.UploadWithResponseAsync(request);
                Assert.NotNull(response);
                Assert.NotNull(response.ETag);
                Assert.True(response.ETag.Length > 0);

                var metadata = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                {
                    BucketName = _bucketName,
                    Key = fileName
                });
                Assert.Equal(fileSize, metadata.ContentLength);
                Assert.Equal(response.ETag, metadata.ETag);

                var downloadPath = path + ".download";
                await _transfer.DownloadAsync(new TransferUtilityDownloadRequest
                {
                    BucketName = _bucketName,
                    Key = fileName,
                    FilePath = downloadPath
                });
                UtilityMethods.CompareFiles(path, downloadPath);
            }
        }

        [Fact]
        public async Task UploadWithResponseAsyncWithChecksumTest()
        {
            var fileName = UtilityMethods.GenerateName(@"UploadWithResponseTest\ChecksumFile");
            var path = Path.Combine(_basePath, fileName);
            var fileSize = 1 * TransferUtilityTestHelpers.MEG_SIZE;
            UtilityMethods.GenerateFile(path, fileSize);

            var fileBytes = File.ReadAllBytes(path);
            var precalculatedChecksum = CryptoUtilFactory.CryptoInstance.ComputeCRC32Hash(fileBytes);

            var request = new TransferUtilityUploadRequest
            {
                BucketName = _bucketName,
                FilePath = path,
                Key = fileName,
                ContentType = octetStreamContentType,
                ChecksumCRC32 = precalculatedChecksum
            };

            var response = await _transfer.UploadWithResponseAsync(request);
            Assert.NotNull(response);
            Assert.NotNull(response.ETag);
            Assert.True(response.ETag.Length > 0);
        }

        [Fact]
        public async Task UploadWithResponseAsyncCompareWithLegacyUploadTest()
        {
            var fileName = UtilityMethods.GenerateName(@"UploadWithResponseTest\CompareFile");
            var path = Path.Combine(_basePath, fileName);
            var fileSize = 2 * TransferUtilityTestHelpers.MEG_SIZE;
            UtilityMethods.GenerateFile(path, fileSize);

            var responseRequest = new TransferUtilityUploadRequest
            {
                BucketName = _bucketName,
                FilePath = path,
                Key = fileName + "-with-response",
                ContentType = octetStreamContentType
            };

            var response = await _transfer.UploadWithResponseAsync(responseRequest);

            var legacyRequest = new TransferUtilityUploadRequest
            {
                BucketName = _bucketName,
                FilePath = path,
                Key = fileName + "-legacy",
                ContentType = octetStreamContentType
            };

            await _transfer.UploadAsync(legacyRequest);

            var responseMetadata = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = _bucketName,
                Key = fileName + "-with-response"
            });

            var legacyMetadata = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest
            {
                BucketName = _bucketName,
                Key = fileName + "-legacy"
            });

            Assert.Equal(responseMetadata.ContentLength, legacyMetadata.ContentLength);
            Assert.Equal(responseMetadata.Headers.ContentType, legacyMetadata.Headers.ContentType);
            Assert.NotNull(response.ETag);
            Assert.Equal(response.ETag, responseMetadata.ETag);
        }
    }
}
