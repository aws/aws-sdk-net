using Amazon.Runtime;
using Amazon.S3;
using Amazon.S3.Model;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class ChecksumPutTests : ChecksumTestBase
    {
        public ChecksumPutTests(ChecksumMrapFixture mrapFixture) : base(mrapFixture)
        {
        }

        /// <summary>
        /// Tests a SigV4 PutObject with the checksum placed in the header
        /// </summary>
        [Theory]
        [MemberData(nameof(GetAlgorithmsToTest))]
        public async Task TestV4SignedHeadersPut(CoreChecksumAlgorithm algorithm)
        {
            await PutAndGetChecksumTestHelper(algorithm, new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = $"sigv4-headers-{algorithm}",
                ContentBody = _testContent,
                ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString()),
                UseChunkEncoding = false
            });
        }

        /// <summary>
        /// Tests a SigV4 PutObject with the checksum placed in the trailer
        /// </summary>
        [Theory]
        [MemberData(nameof(GetAlgorithmsToTest))]
        public async Task TestV4SignedTrailersPut(CoreChecksumAlgorithm algorithm)
        {
            await PutAndGetChecksumTestHelper(algorithm, new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = $"sigv4-trailers-{algorithm}",
                ContentBody = _testContent,
                DisablePayloadSigning = false,
                ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString()),
                UseChunkEncoding = true
            });
        }

        /// <summary>
        /// Tests a SigV4 PutObject with an unsigned payload and the checksum in the trailer
        /// </summary>
        [Theory]
        [MemberData(nameof(GetAlgorithmsToTest))]
        public async Task TestV4UnsignedTrailersPut(CoreChecksumAlgorithm algorithm)
        {
            await PutAndGetChecksumTestHelper(algorithm, new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = $"sigv4-unsignedcontent-trailers-{algorithm}",
                ContentBody = _testContent,
                DisablePayloadSigning = true,
                ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString()),
                UseChunkEncoding = true
            });
        }

        /// <summary>
        /// Tests a SigV4a PutObject with the checksum placed in the header
        /// </summary>
        [Theory]
        [MemberData(nameof(GetAlgorithmsToTest))]
        public async Task TestV4aSignedHeadersPut(CoreChecksumAlgorithm algorithm)
        {
            await PutAndGetChecksumTestHelper(algorithm, new PutObjectRequest
            {
                BucketName = _mrapArn,
                Key = $"sigv4a-headers-{algorithm}",
                ContentBody = _testContent,
                ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString()),
                UseChunkEncoding = false
            });
        }

        /// <summary>
        /// Tests a SigV4a PutObject with the checksum placed in the trailer
        /// </summary>
        [Theory]
        [MemberData(nameof(GetAlgorithmsToTest))]
        public async Task TestV4aSignedTrailersPut(CoreChecksumAlgorithm algorithm)
        {
            await PutAndGetChecksumTestHelper(algorithm, new PutObjectRequest
            {
                BucketName = _mrapArn,
                Key = $"sigv4a-trailers-{algorithm}",
                ContentBody = _testContent,
                ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString()),
                UseChunkEncoding = true
            });
        }

        /// <summary>
        /// Tests a SigV4a PutObject with an unsigned payload and the checksum in the trailer
        /// </summary>
        [Theory]
        [MemberData(nameof(GetAlgorithmsToTest))]
        public async Task TestV4aUnsignedTrailersPut(CoreChecksumAlgorithm algorithm)
        {
            await PutAndGetChecksumTestHelper(algorithm, new PutObjectRequest
            {
                BucketName = _mrapArn,
                Key = $"sigv4a-unsignedcontent-trailers-{algorithm}",
                ContentBody = _testContent,
                DisablePayloadSigning = true,
                ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString()),
                UseChunkEncoding = true
            });
        }

#if NETFRAMEWORK
        /// <summary>
        /// Validates the PutObject request does not fail when adding the trailing header key for retried requests.
        /// </summary>
        /// <remarks>https://github.com/aws/aws-sdk-net/issues/3154</remarks>
        [Fact]
        public void TestDuplicateTrailingHeaderKey()
        {
            var s3Config = new AmazonS3Config
            {
                // Unrealistic timeout so SDK will do a retry
                Timeout = TimeSpan.FromMilliseconds(1),
                RetryMode = RequestRetryMode.Standard,
                MaxErrorRetry = 1
            };

            using (var s3Client = new AmazonS3Client(s3Config))
            {
                var putObjectRequest = new PutObjectRequest
                {
                    BucketName = _bucketName,
                    Key = "s3-retry-bug",
                    ContentBody = _testContent,
                    ChecksumAlgorithm = ChecksumAlgorithm.CRC32C,
                };

                // Due to the low timeout in the S3Config, we'll still get an exception but verify it's not the
                // "ArgumentException" reported in the GitHub issue.
                AssertExtensions.ExpectException<AmazonServiceException>(() => s3Client.PutObject(putObjectRequest));
            }
        }
#endif

        /// <summary>
        /// Validates when a pre-calculated checksum is provided, it's used instead of calculating a new value.
        /// </summary>
        [Fact]
        public async Task TestPrecalculatedHeaderIsUsed()
        {
            var response = await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = "test-file.txt",
                ContentBody = "Hello world",
                ChecksumSHA256 = "ZOyIygCyaOW6GjVnihtTFtIS9PNmskdyMlNKiuyjfzw="
            });

            Assert.NotNull(response.ChecksumSHA256);
            Assert.Null(response.ChecksumCRC32);
        }

        [Theory]
        [InlineData(CoreChecksumAlgorithm.CRC64NVME)]
        [InlineData(CoreChecksumAlgorithm.CRC32C)]
        public async Task TestCrtChecksumIsCalculated(CoreChecksumAlgorithm algorithm)
        {
            var putResponse = await _client.PutObjectAsync(new PutObjectRequest
            {
                BucketName = _bucketName,
                Key = $"test-file-{algorithm}.txt",
                ContentBody = "Hello world",
                ChecksumAlgorithm = ChecksumAlgorithm.FindValue(algorithm.ToString()),
            });

            if (algorithm == CoreChecksumAlgorithm.CRC32C)
            {
                Assert.NotNull(putResponse.ChecksumCRC32C);
            }
            else if (algorithm == CoreChecksumAlgorithm.CRC64NVME)
            {
                Assert.NotNull(putResponse.ChecksumCRC64NVME);
            }
        }

        [Theory]
        // When the user sets ResponseChecksumValidation to WHEN_SUPPORTED, and the user has set the requestValidationModeMember to ENABLED, assert that the response checksum is validated.
        [InlineData(ResponseChecksumValidation.WHEN_SUPPORTED, true, true)]
        // When the user sets ResponseChecksumValidation to WHEN_SUPPORTED, and the user has NOT set the requestValidationModeMember to ENABLED, assert that the response checksum is validated.
        [InlineData(ResponseChecksumValidation.WHEN_SUPPORTED, false, true)]
        // When the user sets ResponseChecksumValidation to WHEN_REQUIRED, and the user has set the requestValidationModeMember to ENABLED, assert that the response checksum is validated.
        [InlineData(ResponseChecksumValidation.WHEN_REQUIRED, true, true)]
        // When the user sets ResponseChecksumValidation to WHEN_REQUIRED, and the user has NOT set the requestValidationModeMember to ENABLED, assert that the response checksum is NOT validated.
        [InlineData(ResponseChecksumValidation.WHEN_REQUIRED, false, false)]
        public async Task TestResponseChecksumValidation(ResponseChecksumValidation responseChecksumValidation, bool enableChecksumMode, bool isChecksumAlgorithmSet)
        {
            var s3Config = new AmazonS3Config
            {
                ResponseChecksumValidation = responseChecksumValidation,
            };

            using (var s3Client = new AmazonS3Client(s3Config))
            {
                var key = UtilityMethods.GenerateName(nameof(ChecksumPutTests));
                var putRequest = new PutObjectRequest
                {
                    BucketName = _bucketName,
                    Key = key,
                    ContentBody = _testContent,
                };
                await s3Client.PutObjectAsync(putRequest);

                var getRequest = new GetObjectRequest
                {
                    BucketName = putRequest.BucketName,
                    Key = putRequest.Key,
                };
                if (enableChecksumMode)
                {
                    getRequest.ChecksumMode = ChecksumMode.ENABLED;
                }

                var response = await s3Client.GetObjectAsync(getRequest);
                Assert.Equal(response.ResponseMetadata.ChecksumAlgorithm == CoreChecksumAlgorithm.NONE, !isChecksumAlgorithmSet);
            }
        }
    }
}
