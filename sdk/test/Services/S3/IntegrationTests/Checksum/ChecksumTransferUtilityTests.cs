using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class ChecksumTransferUtilityTests : ChecksumTestBase
    {
        public ChecksumTransferUtilityTests(ChecksumMrapFixture mrapFixture) : base(mrapFixture)
        {
        }

        [Theory]
        [MemberData(nameof(GetAlgorithmsToTest))]
        public async Task TestMultipartUploadViaTransferUtility(CoreChecksumAlgorithm algorithm)
        {
            var transferConfig = new TransferUtilityConfig { MinSizeBeforePartUpload = 6000000 };
            var transfer = new TransferUtility(_client, transferConfig);
            var content = new string('a', 7000000);
            var key = UtilityMethods.GenerateName(nameof(ChecksumTransferUtilityTests));
            var filePath = Path.Combine(Path.GetTempPath(), key + ".txt");
            var retrievedFilepath = Path.Combine(Path.GetTempPath(), "retreived-" + key + ".txt");

            try
            {
                using (StreamWriter writer = File.CreateText(filePath))
                {
                    await writer.WriteAsync(content);
                }

                var uploadRequest = new TransferUtilityUploadRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    FilePath = filePath,
                    ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString())
                };
                await transfer.UploadAsync(uploadRequest);

                var getResponse = await _client.GetObjectAsync(new GetObjectRequest
                {
                    BucketName = _bucketName,
                    Key = uploadRequest.Key,
                    ChecksumMode = ChecksumMode.ENABLED
                });
                var getBody = await new StreamReader(getResponse.ResponseStream).ReadToEndAsync();
                Assert.Equal(content, getBody);

                if (algorithm == CoreChecksumAlgorithm.CRC64NVME)
                {
                    Assert.Equal(CoreChecksumAlgorithm.CRC64NVME, getResponse.ResponseMetadata.ChecksumAlgorithm);
                }
                else
                {
                    Assert.Equal(CoreChecksumAlgorithm.NONE, getResponse.ResponseMetadata.ChecksumAlgorithm);
                    Assert.Equal(ChecksumValidationStatus.NOT_VALIDATED, getResponse.ResponseMetadata.ChecksumValidationStatus);
                }

                if (algorithm != CoreChecksumAlgorithm.CRC64NVME)
                {
                    var getObjectAttributesResponse = await _client.GetObjectAttributesAsync(new GetObjectAttributesRequest
                    {
                        BucketName = _bucketName,
                        Key = uploadRequest.Key,
                        ObjectAttributes = new List<ObjectAttributes>
                        {
                            new ObjectAttributes("Checksum"),
                            new ObjectAttributes("ObjectParts"),
                            new ObjectAttributes("ObjectSize")
                        }
                    });
                    Assert.True(getObjectAttributesResponse.ObjectParts.Parts.Count > 0);
                    Assert.Equal(getObjectAttributesResponse.ObjectParts.Parts.Count, getObjectAttributesResponse.ObjectParts.TotalPartsCount);

                    var firstObjectPart = getObjectAttributesResponse.ObjectParts.Parts.First();
                    ChecksumAlgorithm expectedChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString());
                    if (expectedChecksumAlgorithm == ChecksumAlgorithm.CRC32)
                        Assert.NotNull(firstObjectPart.ChecksumCRC32);
                    if (expectedChecksumAlgorithm == ChecksumAlgorithm.CRC32C)
                        Assert.NotNull(firstObjectPart.ChecksumCRC32C);
                    if (expectedChecksumAlgorithm == ChecksumAlgorithm.SHA1)
                        Assert.NotNull(firstObjectPart.ChecksumSHA1);
                    if (expectedChecksumAlgorithm == ChecksumAlgorithm.SHA256)
                        Assert.NotNull(firstObjectPart.ChecksumSHA256);
                    Assert.Equal(1, firstObjectPart.PartNumber);
                    Assert.True(firstObjectPart.Size > 0);
                }

                await transfer.DownloadAsync(new TransferUtilityDownloadRequest
                {
                    BucketName = _bucketName,
                    Key = uploadRequest.Key,
                    FilePath = retrievedFilepath,
                    ChecksumMode = ChecksumMode.ENABLED
                });
            }
            finally
            {
                if (File.Exists(filePath)) File.Delete(filePath);
                if (File.Exists(retrievedFilepath)) File.Delete(retrievedFilepath);
            }
        }

        [Theory]
        [MemberData(nameof(GetAlgorithmsToTest))]
        public async Task TestSingleUploadViaTransferUtility(CoreChecksumAlgorithm algorithm)
        {
            var transferConfig = new TransferUtilityConfig { MinSizeBeforePartUpload = 6000000 };
            var transfer = new TransferUtility(_client, transferConfig);
            var content = new string('a', 5000000);
            var key = UtilityMethods.GenerateName(nameof(ChecksumTransferUtilityTests));
            var filePath = Path.Combine(Path.GetTempPath(), key + ".txt");
            var retrievedFilepath = Path.Combine(Path.GetTempPath(), "retreived-" + key + ".txt");

            try
            {
                using (StreamWriter writer = File.CreateText(filePath))
                {
                    await writer.WriteAsync(content);
                }

                var uploadRequest = new TransferUtilityUploadRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    FilePath = filePath,
                    ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString())
                };
                await transfer.UploadAsync(uploadRequest);

                var getResponse = await _client.GetObjectAsync(new GetObjectRequest
                {
                    BucketName = _bucketName,
                    Key = uploadRequest.Key,
                    ChecksumMode = ChecksumMode.ENABLED
                });
                var getBody = await new StreamReader(getResponse.ResponseStream).ReadToEndAsync();
                Assert.Equal(content, getBody);
                Assert.Equal(algorithm.ToString(), getResponse.ResponseMetadata.ChecksumAlgorithm.ToString(), ignoreCase: true);
                Assert.Equal(ChecksumValidationStatus.PENDING_RESPONSE_READ, getResponse.ResponseMetadata.ChecksumValidationStatus);

                await transfer.DownloadAsync(new TransferUtilityDownloadRequest
                {
                    BucketName = _bucketName,
                    Key = uploadRequest.Key,
                    FilePath = retrievedFilepath,
                    ChecksumMode = ChecksumMode.ENABLED
                });
            }
            finally
            {
                if (File.Exists(filePath)) File.Delete(filePath);
                if (File.Exists(retrievedFilepath)) File.Delete(retrievedFilepath);
            }
        }
    }
}
