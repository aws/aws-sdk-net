using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Abstract base class for Checksum integration tests.
    /// </summary>
    public abstract class ChecksumTestBase
    {
        protected readonly AmazonS3Client _client;
        protected readonly string _bucketName;
        protected readonly string _mrapArn;
        protected static string _testContent = "Hello world";
        protected const long MegSize = 1048576;

        public static TheoryData<CoreChecksumAlgorithm> GetAlgorithmsToTest => new TheoryData<CoreChecksumAlgorithm>
        {
            // TODO: Disabling CRT algorithms since we're still seeing issues with native dependencies in customer environments.
            //CoreChecksumAlgorithm.CRC64NVME,
            //CoreChecksumAlgorithm.CRC32C,
            CoreChecksumAlgorithm.CRC32,
            CoreChecksumAlgorithm.SHA1,
            CoreChecksumAlgorithm.SHA256
        };

        public ChecksumTestBase(ChecksumMrapFixture mrapFixture)
        {
            _client = mrapFixture.Client;
            _bucketName = mrapFixture.BucketName;
            _mrapArn = mrapFixture.MrapArn;
        }

        protected async Task PutAndGetChecksumTestHelper(CoreChecksumAlgorithm algorithm, PutObjectRequest putRequest)
        {
            await _client.PutObjectAsync(putRequest);

            var getObjectAttributesResponse = await _client.GetObjectAttributesAsync(new GetObjectAttributesRequest
            {
                BucketName = putRequest.BucketName,
                Key = putRequest.Key,
                ObjectAttributes = new List<ObjectAttributes> { ObjectAttributes.Checksum }
            });
            Assert.NotNull(getObjectAttributesResponse);

            var response = await _client.GetObjectAsync(new GetObjectRequest
            {
                BucketName = putRequest.BucketName,
                Key = putRequest.Key,
                ChecksumMode = ChecksumMode.ENABLED
            });
            Assert.Equal(algorithm, response.ResponseMetadata.ChecksumAlgorithm);
            Assert.Equal(ChecksumValidationStatus.PENDING_RESPONSE_READ, response.ResponseMetadata.ChecksumValidationStatus);

            await new StreamReader(response.ResponseStream).ReadToEndAsync();
            response.ResponseStream.Dispose();
        }

        protected async Task CopyObjectUsingMultipartTestHelper(CoreChecksumAlgorithm algorithm, string bucketName)
        {
            var guid = Guid.NewGuid().ToString("N");
            var filePath = Path.Combine(Path.GetTempPath(), "multipartcopy-" + guid + ".txt");
            var retrievedFilepath = Path.Combine(Path.GetTempPath(), "retreived-" + guid + ".txt");
            var totalSize = MegSize * 6;

            UtilityMethods.GenerateFile(filePath, totalSize);
            string sourceKey = "sourceKey-" + guid;
            string copiedKey = "sourceKey-" + guid + "-copy";
            try
            {
                var transferConfig = new TransferUtilityConfig { MinSizeBeforePartUpload = 5000000 };
                var transfer = new TransferUtility(_client, transferConfig);
                await transfer.UploadAsync(new TransferUtilityUploadRequest
                {
                    BucketName = bucketName,
                    Key = sourceKey,
                    FilePath = filePath
                });

                List<CopyPartResponse> copyResponses = new List<CopyPartResponse>();
                var initResponse = await _client.InitiateMultipartUploadAsync(new InitiateMultipartUploadRequest
                {
                    BucketName = bucketName,
                    Key = copiedKey,
                    ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString())
                });

                var metadataResponse = await _client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                {
                    BucketName = bucketName,
                    Key = sourceKey
                });
                long objectSize = metadataResponse.ContentLength;

                long partSize = 5 * (long)Math.Pow(2, 20);

                long bytePosition = 0;
                for (int i = 1; bytePosition < objectSize; i++)
                {
                    var copyRequest = new CopyPartRequest
                    {
                        DestinationBucket = bucketName,
                        DestinationKey = copiedKey,
                        SourceBucket = bucketName,
                        SourceKey = sourceKey,
                        UploadId = initResponse.UploadId,
                        FirstByte = bytePosition,
                        LastByte = bytePosition + partSize - 1 >= objectSize ? objectSize - 1 : bytePosition + partSize - 1,
                        PartNumber = i
                    };

                    copyResponses.Add(await _client.CopyPartAsync(copyRequest));
                    bytePosition += partSize;
                }

                var completeRequest = new CompleteMultipartUploadRequest
                {
                    BucketName = bucketName,
                    Key = copiedKey,
                    UploadId = initResponse.UploadId
                };
                completeRequest.AddPartETagsAndChecksums(copyResponses);

                var completeUploadResponse = await _client.CompleteMultipartUploadAsync(completeRequest);
                Assert.NotNull(completeUploadResponse.ETag);
                Assert.Equal(copiedKey, completeUploadResponse.Key);
                Assert.NotNull(completeUploadResponse.Location);

                var getResponse = await _client.GetObjectAsync(new GetObjectRequest
                {
                    BucketName = bucketName,
                    Key = copiedKey
                });
                await getResponse.WriteResponseStreamToFileAsync(retrievedFilepath, append: false, cancellationToken: default);
                UtilityMethods.CompareFiles(filePath, retrievedFilepath);
            }
            finally
            {
                if (File.Exists(filePath)) File.Delete(filePath);
                if (File.Exists(retrievedFilepath)) File.Delete(retrievedFilepath);
            }
        }

        protected async Task MultipartTestHelper(CoreChecksumAlgorithm algorithm, string bucketName, bool disablePayloadSigning)
        {
            var guid = Guid.NewGuid().ToString("N");
            var filePath = Path.Combine(Path.GetTempPath(), "multi-" + guid + ".txt");
            var retrievedFilepath = Path.Combine(Path.GetTempPath(), "retreived-" + guid + ".txt");
            var totalSize = MegSize * 11;

            UtilityMethods.GenerateFile(filePath, totalSize);
            string key = "sourceKey-" + guid;

            Stream inputStream = File.OpenRead(filePath);
            try
            {
                var initResponse = await _client.InitiateMultipartUploadAsync(new InitiateMultipartUploadRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString())
                });

                var uploadRequest = new UploadPartRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId,
                    PartNumber = 1,
                    PartSize = 5 * MegSize,
                    InputStream = inputStream,
                    ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString()),
                    DisablePayloadSigning = disablePayloadSigning
                };
                var up1Response = await _client.UploadPartAsync(uploadRequest);

                uploadRequest = new UploadPartRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId,
                    PartNumber = 2,
                    PartSize = 5 * MegSize,
                    InputStream = inputStream,
                    ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString()),
                    DisablePayloadSigning = disablePayloadSigning
                };
                var up2Response = await _client.UploadPartAsync(uploadRequest);

                uploadRequest = new UploadPartRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId,
                    PartNumber = 3,
                    InputStream = inputStream,
                    ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString()),
                    DisablePayloadSigning = disablePayloadSigning,
                    IsLastPart = true
                };
                var up3Response = await _client.UploadPartAsync(uploadRequest);

                var listPartResponse = await _client.ListPartsAsync(new ListPartsRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId
                });
                Assert.Equal(3, listPartResponse.Parts.Count);
                AssertPartsAreEqual(up1Response, listPartResponse.Parts[0]);
                AssertPartsAreEqual(up2Response, listPartResponse.Parts[1]);
                AssertPartsAreEqual(up3Response, listPartResponse.Parts[2]);

                var compRequest = new CompleteMultipartUploadRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    UploadId = initResponse.UploadId
                };
                compRequest.AddPartETagsAndChecksums(up1Response, up2Response, up3Response);

                var compResponse = await _client.CompleteMultipartUploadAsync(compRequest);
                Assert.NotNull(compResponse.ETag);
                Assert.Equal(key, compResponse.Key);
                Assert.NotNull(compResponse.Location);

                var getResponse = await _client.GetObjectAsync(new GetObjectRequest
                {
                    BucketName = bucketName,
                    Key = key,
                    ChecksumMode = ChecksumMode.ENABLED
                });
                await getResponse.WriteResponseStreamToFileAsync(retrievedFilepath, append: false, cancellationToken: default);
                UtilityMethods.CompareFiles(filePath, retrievedFilepath);

                if (algorithm == CoreChecksumAlgorithm.CRC64NVME)
                {
                    Assert.Equal(CoreChecksumAlgorithm.CRC64NVME, getResponse.ResponseMetadata.ChecksumAlgorithm);
                }
                else
                {
                    Assert.Equal(CoreChecksumAlgorithm.NONE, getResponse.ResponseMetadata.ChecksumAlgorithm);
                    Assert.Equal(ChecksumValidationStatus.NOT_VALIDATED, getResponse.ResponseMetadata.ChecksumValidationStatus);
                }
            }
            finally
            {
                inputStream.Close();
                if (File.Exists(filePath)) File.Delete(filePath);
                if (File.Exists(retrievedFilepath)) File.Delete(retrievedFilepath);
            }
        }

        protected static void AssertPartsAreEqual(UploadPartResponse uploadPartResponse, PartDetail partDetail)
        {
            Assert.Equal(uploadPartResponse.PartNumber, partDetail.PartNumber);
            Assert.Equal(uploadPartResponse.ETag, partDetail.ETag);
            Assert.Equal(uploadPartResponse.ChecksumCRC32C, partDetail.ChecksumCRC32C);
            Assert.Equal(uploadPartResponse.ChecksumCRC32, partDetail.ChecksumCRC32);
            Assert.Equal(uploadPartResponse.ChecksumSHA1, partDetail.ChecksumSHA1);
            Assert.Equal(uploadPartResponse.ChecksumSHA256, partDetail.ChecksumSHA256);
        }
    }
}
