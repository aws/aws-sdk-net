using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Transfer.Internal;
using Moq;
using System;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    /// <summary>
    /// Shared test utilities and helper methods for multipart download tests.
    /// Provides mock object creation, test data generation, and common test scenarios.
    /// </summary>
    public static class MultipartDownloadTestHelpers
    {
        #region Test Constants

        public const int DefaultPartSize = 8 * 1024 * 1024; // 8MB
        public const int SmallPartSize = 5 * 1024 * 1024; // 5MB
        public const int BufferSize = 8192; // 8KB
        public const int DefaultConcurrentRequests = 10;
        public const int DefaultMaxInMemoryParts = 5;
        
        #endregion

        #region Mock GetObjectResponse Creation

        /// <summary>
        /// Creates a mock GetObjectResponse with configurable properties for testing.
        /// </summary>
        public static Mock<GetObjectResponse> CreateMockGetObjectResponse(
            long contentLength,
            int? partsCount = null,
            string contentRange = null,
            string eTag = "test-etag",
            byte[] testData = null,
            bool includeHeaders = true)
        {
            var mockResponse = new Mock<GetObjectResponse>();
            
            // Basic properties
            mockResponse.Setup(x => x.ContentLength).Returns(contentLength);
            mockResponse.Setup(x => x.ETag).Returns(eTag);
            
            // PartsCount (for multipart uploads)
            if (partsCount.HasValue)
            {
                mockResponse.Setup(x => x.PartsCount).Returns(partsCount.Value);
            }
            
            // ContentRange (for range requests)
            if (contentRange != null)
            {
                mockResponse.Setup(x => x.ContentRange).Returns(contentRange);
            }
            
            // ResponseStream with test data
            if (testData == null)
            {
                testData = GenerateTestData((int)contentLength, 0);
            }
            var responseStream = new MemoryStream(testData);
            mockResponse.Setup(x => x.ResponseStream).Returns(responseStream);
            
            // Headers
            if (includeHeaders)
            {
                var headers = new HeadersCollection();
                headers["x-amz-server-side-encryption"] = "AES256";
                mockResponse.Setup(x => x.Headers).Returns(headers);
            }
            
            // Metadata
            mockResponse.Setup(x => x.Metadata).Returns(new MetadataCollection());
            
            // Server-side encryption
            mockResponse.Setup(x => x.ServerSideEncryptionMethod).Returns(ServerSideEncryptionMethod.AES256);
            
            return mockResponse;
        }

        /// <summary>
        /// Creates a GetObjectResponse for a single-part download scenario.
        /// </summary>
        public static Mock<GetObjectResponse> CreateSinglePartResponse(
            long objectSize,
            string eTag = "single-part-etag")
        {
            return CreateMockGetObjectResponse(
                contentLength: objectSize,
                partsCount: null,  // No PartsCount indicates single part
                contentRange: null,
                eTag: eTag);
        }

        /// <summary>
        /// Creates a GetObjectResponse for the first part of a multipart download (PART strategy).
        /// </summary>
        public static Mock<GetObjectResponse> CreateMultipartFirstPartResponse(
            long partSize,
            int totalParts,
            long totalObjectSize,
            string eTag = "multipart-etag")
        {
            // ContentRange format: "bytes 0-{partSize-1}/{totalObjectSize}"
            var contentRange = $"bytes 0-{partSize - 1}/{totalObjectSize}";
            
            return CreateMockGetObjectResponse(
                contentLength: partSize,
                partsCount: totalParts,
                contentRange: contentRange,
                eTag: eTag);
        }

        /// <summary>
        /// Creates a GetObjectResponse for a range request (RANGE strategy).
        /// </summary>
        public static Mock<GetObjectResponse> CreateRangeResponse(
            long rangeStart,
            long rangeEnd,
            long totalObjectSize,
            string eTag = "range-etag")
        {
            var rangeSize = rangeEnd - rangeStart + 1;
            var contentRange = $"bytes {rangeStart}-{rangeEnd}/{totalObjectSize}";
            
            return CreateMockGetObjectResponse(
                contentLength: rangeSize,
                partsCount: null,
                contentRange: contentRange,
                eTag: eTag);
        }

        #endregion

        #region Mock S3 Client Creation

        /// <summary>
        /// Creates a mock S3 client with configurable GetObjectAsync behavior.
        /// </summary>
        public static Mock<IAmazonS3> CreateMockS3Client(
            Func<GetObjectRequest, CancellationToken, Task<GetObjectResponse>> getObjectBehavior = null)
        {
            var mockClient = new Mock<IAmazonS3>();
            
            if (getObjectBehavior != null)
            {
                mockClient
                    .Setup(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()))
                    .Returns(getObjectBehavior);
            }
            
            // Setup Config property
            var mockConfig = new Mock<AmazonS3Config>();
            mockConfig.Setup(x => x.BufferSize).Returns(BufferSize);
            mockClient.Setup(x => x.Config).Returns(mockConfig.Object);
            
            return mockClient;
        }

        /// <summary>
        /// Creates a mock S3 client that returns responses for multiple parts in sequence.
        /// </summary>
        public static Mock<IAmazonS3> CreateMockS3ClientForMultipart(
            int totalParts,
            long partSize,
            long totalObjectSize,
            string eTag = "multipart-etag",
            bool usePartStrategy = true)
        {
            var partResponses = new GetObjectResponse[totalParts];
            
            for (int i = 0; i < totalParts; i++)
            {
                int partNumber = i + 1;
                long actualPartSize = (partNumber == totalParts) 
                    ? totalObjectSize - (partSize * (totalParts - 1))  // Last part may be smaller
                    : partSize;
                
                Mock<GetObjectResponse> mockResponse;
                
                if (usePartStrategy)
                {
                    // PART strategy: First part has PartsCount
                    if (partNumber == 1)
                    {
                        mockResponse = CreateMultipartFirstPartResponse(actualPartSize, totalParts, totalObjectSize, eTag);
                    }
                    else
                    {
                        var contentRange = $"bytes {(partNumber - 1) * partSize}-{(partNumber - 1) * partSize + actualPartSize - 1}/{totalObjectSize}";
                        mockResponse = CreateMockGetObjectResponse(actualPartSize, totalParts, contentRange, eTag);
                    }
                }
                else
                {
                    // RANGE strategy: Use byte ranges
                    long rangeStart = (partNumber - 1) * partSize;
                    long rangeEnd = rangeStart + actualPartSize - 1;
                    mockResponse = CreateRangeResponse(rangeStart, rangeEnd, totalObjectSize, eTag);
                }
                
                partResponses[i] = mockResponse.Object;
            }
            
            var callCount = 0;
            return CreateMockS3Client((request, ct) =>
            {
                var responseIndex = Interlocked.Increment(ref callCount) - 1;
                if (responseIndex >= partResponses.Length)
                    throw new InvalidOperationException($"Unexpected GetObjectAsync call #{responseIndex + 1}");
                    
                return Task.FromResult(partResponses[responseIndex]);
            });
        }

        #endregion

        #region Test Data Generation

        /// <summary>
        /// Generates predictable test data with a repeating pattern for verification.
        /// </summary>
        public static byte[] GenerateTestData(int size, int seed = 0)
        {
            return Enumerable.Range(seed, size).Select(i => (byte)(i % 256)).ToArray();
        }

        /// <summary>
        /// Generates test data with a part-specific pattern (all bytes set to part number).
        /// </summary>
        public static byte[] GeneratePartSpecificData(int size, int partNumber)
        {
            return Enumerable.Repeat((byte)(partNumber % 256), size).ToArray();
        }

        /// <summary>
        /// Generates mixed pattern data for boundary testing.
        /// </summary>
        public static byte[] CreateMixedPattern(int size, int seed)
        {
            var random = new Random(seed);
            var data = new byte[size];
            
            // Create a pattern with different regions
            for (int i = 0; i < size; i++)
            {
                if (i < size / 3)
                    data[i] = (byte)(i % 256);  // Sequential
                else if (i < 2 * size / 3)
                    data[i] = (byte)random.Next(256);  // Random
                else
                    data[i] = (byte)((size - i) % 256);  // Reverse sequential
            }
            
            return data;
        }

        /// <summary>
        /// Verifies that two byte arrays are identical.
        /// </summary>
        public static bool VerifyDataMatch(byte[] expected, byte[] actual, int offset, int count)
        {
            if (actual == null || expected == null)
                return false;
                
            if (offset + count > actual.Length || count > expected.Length)
                return false;
            
            for (int i = 0; i < count; i++)
            {
                if (actual[offset + i] != expected[i])
                    return false;
            }
            
            return true;
        }

        #endregion

        #region StreamConfiguration Creation

        /// <summary>
        /// Creates a default StreamConfiguration for testing.
        /// </summary>
        internal static StreamConfiguration CreateStreamConfiguration(
            int concurrentRequests = DefaultConcurrentRequests,
            int maxInMemoryParts = DefaultMaxInMemoryParts,
            int bufferSize = BufferSize,
            long partSize = DefaultPartSize)
        {
            return new StreamConfiguration(
                concurrentRequests,
                maxInMemoryParts,
                bufferSize,
                partSize);
        }

        /// <summary>
        /// Creates a StreamConfiguration with minimal settings for testing.
        /// </summary>
        internal static StreamConfiguration CreateMinimalStreamConfiguration()
        {
            return new StreamConfiguration(1, 1, 1024, 8 * 1024 * 1024);
        }

        #endregion

        #region Mock Request Creation

        /// <summary>
        /// Creates a mock TransferUtilityOpenStreamRequest for testing.
        /// </summary>
        public static TransferUtilityOpenStreamRequest CreateOpenStreamRequest(
            string bucketName = "test-bucket",
            string key = "test-key",
            long? partSize = null,
            MultipartDownloadType downloadType = MultipartDownloadType.PART)
        {
            var request = new TransferUtilityOpenStreamRequest
            {
                BucketName = bucketName,
                Key = key,
                MultipartDownloadType = downloadType
            };
            
            if (partSize.HasValue)
            {
                request.PartSize = partSize.Value;
            }
            
            return request;
        }

        #endregion
    }
}
