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

        #region GetObjectResponse Creation

        /// <summary>
        /// Creates a GetObjectResponse with configurable properties for testing.
        /// </summary>
        public static GetObjectResponse CreateMockGetObjectResponse(
            long contentLength,
            int? partsCount = null,
            string contentRange = null,
            string eTag = "test-etag",
            byte[] testData = null,
            bool includeHeaders = true)
        {
            return CreateMockGetObjectResponseWithEncryption(
                contentLength,
                partsCount,
                contentRange,
                eTag,
                testData,
                includeHeaders,
                ServerSideEncryptionMethod.AES256,
                null);
        }

        /// <summary>
        /// Creates a GetObjectResponse with configurable properties including encryption settings.
        /// </summary>
        public static GetObjectResponse CreateMockGetObjectResponseWithEncryption(
            long contentLength,
            int? partsCount,
            string contentRange,
            string eTag,
            byte[] testData,
            bool includeHeaders,
            ServerSideEncryptionMethod serverSideEncryptionMethod,
            string serverSideEncryptionKeyManagementServiceKeyId)
        {
            var response = new GetObjectResponse();
            
            // Set ContentLength
            response.ContentLength = contentLength;
            
            // Set ETag
            response.ETag = eTag;
            
            // PartsCount (for multipart uploads)
            if (partsCount.HasValue)
            {
                response.PartsCount = partsCount.Value;
            }
            
            // ContentRange (for range requests)
            if (contentRange != null)
            {
                response.ContentRange = contentRange;
            }
            
            // ResponseStream with test data
            if (testData == null)
            {
                testData = GenerateTestData((int)contentLength, 0);
            }
            response.ResponseStream = new MemoryStream(testData);
            
            // Headers
            if (includeHeaders)
            {
                response.Headers["x-amz-server-side-encryption"] = "AES256";
            }
            
            // Server-side encryption
            response.ServerSideEncryptionMethod = serverSideEncryptionMethod;
            
            // KMS key ID (if provided)
            if (!string.IsNullOrEmpty(serverSideEncryptionKeyManagementServiceKeyId))
            {
                response.ServerSideEncryptionKeyManagementServiceKeyId = serverSideEncryptionKeyManagementServiceKeyId;
            }
            
            return response;
        }

        /// <summary>
        /// Creates a GetObjectResponse for a single-part download scenario.
        /// </summary>
        public static GetObjectResponse CreateSinglePartResponse(
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
        public static GetObjectResponse CreateMultipartFirstPartResponse(
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
        public static GetObjectResponse CreateRangeResponse(
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
            
            // Setup Config property - BufferSize is not virtual, so set directly
            var mockConfig = new Mock<AmazonS3Config>();
            mockConfig.Object.BufferSize = BufferSize;
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
                
                GetObjectResponse response;
                
                if (usePartStrategy)
                {
                    // PART strategy: First part has PartsCount
                    if (partNumber == 1)
                    {
                        response = CreateMultipartFirstPartResponse(actualPartSize, totalParts, totalObjectSize, eTag);
                    }
                    else
                    {
                        var contentRange = $"bytes {(partNumber - 1) * partSize}-{(partNumber - 1) * partSize + actualPartSize - 1}/{totalObjectSize}";
                        response = CreateMockGetObjectResponse(actualPartSize, totalParts, contentRange, eTag);
                    }
                }
                else
                {
                    // RANGE strategy: Use byte ranges
                    long rangeStart = (partNumber - 1) * partSize;
                    long rangeEnd = rangeStart + actualPartSize - 1;
                    response = CreateRangeResponse(rangeStart, rangeEnd, totalObjectSize, eTag);
                }
                
                partResponses[i] = response;
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

        #region BufferedDownloadConfiguration Creation

        /// <summary>
        /// Creates a default BufferedDownloadConfiguration for testing.
        /// </summary>
        internal static BufferedDownloadConfiguration CreateBufferedDownloadConfiguration(
            int concurrentRequests = DefaultConcurrentRequests,
            int maxInMemoryParts = DefaultMaxInMemoryParts,
            int bufferSize = BufferSize,
            long partSize = DefaultPartSize)
        {
            return new BufferedDownloadConfiguration(
                concurrentRequests,
                maxInMemoryParts,
                bufferSize,
                partSize);
        }

        /// <summary>
        /// Creates a BufferedDownloadConfiguration with minimal settings for testing.
        /// </summary>
        internal static BufferedDownloadConfiguration CreateMinimalBufferedDownloadConfiguration()
        {
            return new BufferedDownloadConfiguration(1, 1, 1024, 8 * 1024 * 1024);
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

        #region Advanced Mock Creation Helpers

        /// <summary>
        /// Creates a mock S3 client that returns responses sequentially.
        /// </summary>
        public static Mock<IAmazonS3> CreateSequentialMockClient(params GetObjectResponse[] responses)
        {
            var callCount = 0;
            return CreateMockS3Client((request, ct) =>
            {
                var responseIndex = Interlocked.Increment(ref callCount) - 1;
                if (responseIndex >= responses.Length)
                    throw new InvalidOperationException($"Unexpected GetObjectAsync call #{responseIndex + 1}");
                return Task.FromResult(responses[responseIndex]);
            });
        }

        /// <summary>
        /// Creates a mock S3 client that captures the cancellation token used.
        /// </summary>
        public static Mock<IAmazonS3> CreateMockS3ClientWithTokenCapture(Action<CancellationToken> tokenCapture)
        {
            var mockClient = new Mock<IAmazonS3>();
            mockClient.Setup(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()))
                .Callback<GetObjectRequest, CancellationToken>((req, ct) => tokenCapture(ct))
                .ReturnsAsync(CreateSinglePartResponse(1024));
            
            var mockConfig = new Mock<AmazonS3Config>();
            mockConfig.Object.BufferSize = BufferSize;
            mockClient.Setup(x => x.Config).Returns(mockConfig.Object);
            
            return mockClient;
        }

        /// <summary>
        /// Creates a mock S3 client that throws OperationCanceledException.
        /// </summary>
        public static Mock<IAmazonS3> CreateMockS3ClientWithCancellation()
        {
            var mockClient = new Mock<IAmazonS3>();
            mockClient.Setup(x => x.GetObjectAsync(It.IsAny<GetObjectRequest>(), It.IsAny<CancellationToken>()))
                .ThrowsAsync(new OperationCanceledException());
            
            var mockConfig = new Mock<AmazonS3Config>();
            mockConfig.Object.BufferSize = BufferSize;
            mockClient.Setup(x => x.Config).Returns(mockConfig.Object);
            
            return mockClient;
        }

        #endregion

        #region Test Setup Helpers

        /// <summary>
        /// Configuration for validation tests.
        /// </summary>
        internal class ValidationTestConfig
        {
            public long PartSize { get; set; }
            public long TotalSize { get; set; }
            public int TotalParts { get; set; }
            public string ETag { get; set; }
        }

        /// <summary>
        /// Types of validation failures that can occur during multipart downloads.
        /// </summary>
        public enum ValidationFailureType
        {
            MissingContentRange,
            InvalidContentRangeFormat,
            UnparseableRange,
            RangeMismatch,
            ETagMismatch
        }

        /// <summary>
        /// Creates a mock S3 client configured to produce a specific validation failure.
        /// </summary>
        internal static Mock<IAmazonS3> CreateMockClientWithValidationFailure(ValidationFailureType failureType)
        {
            var config = new ValidationTestConfig
            {
                PartSize = 8 * 1024 * 1024,
                TotalSize = 20 * 1024 * 1024,
                TotalParts = 3,
                ETag = "test-etag"
            };

            GetObjectResponse firstPartResponse;
            GetObjectResponse secondPartResponse;

            if (failureType == ValidationFailureType.ETagMismatch)
            {
                // PART strategy for ETag testing
                firstPartResponse = CreateMultipartFirstPartResponse(
                    config.PartSize, config.TotalParts, config.TotalSize, config.ETag);
                secondPartResponse = CreateMockGetObjectResponse(
                    config.PartSize, config.TotalParts,
                    $"bytes {config.PartSize}-{2 * config.PartSize - 1}/{config.TotalSize}",
                    "different-etag");
            }
            else
            {
                // RANGE strategy for ContentRange validation testing
                firstPartResponse = CreateRangeResponse(0, config.PartSize - 1, config.TotalSize, config.ETag);
                secondPartResponse = CreateInvalidResponse(failureType, config);
            }

            return CreateSequentialMockClient(firstPartResponse, secondPartResponse);
        }

        /// <summary>
        /// Creates an invalid GetObjectResponse based on the failure type.
        /// </summary>
        private static GetObjectResponse CreateInvalidResponse(ValidationFailureType failureType, ValidationTestConfig config)
        {
            return failureType switch
            {
                ValidationFailureType.MissingContentRange => CreateMockGetObjectResponse(
                    config.PartSize, null, null, config.ETag),
                ValidationFailureType.InvalidContentRangeFormat => CreateMockGetObjectResponse(
                    config.PartSize, null, "invalid-format-no-slash", config.ETag),
                ValidationFailureType.UnparseableRange => CreateMockGetObjectResponse(
                    config.PartSize, null, "bytes abc-xyz/20971520", config.ETag),
                ValidationFailureType.RangeMismatch => CreateMockGetObjectResponse(
                    config.PartSize, null, $"bytes 0-{config.PartSize - 1}/{config.TotalSize}", config.ETag),
                _ => throw new ArgumentException($"Unknown failure type: {failureType}")
            };
        }

        /// <summary>
        /// Creates a coordinator configured for validation testing.
        /// </summary>
        internal static MultipartDownloadManager CreateCoordinatorForValidationTest(
            IAmazonS3 client, ValidationFailureType failureType)
        {
            var downloadType = failureType == ValidationFailureType.ETagMismatch
                ? MultipartDownloadType.PART
                : MultipartDownloadType.RANGE;

            var request = CreateOpenStreamRequest(
                partSize: failureType == ValidationFailureType.ETagMismatch ? null : 8 * 1024 * 1024,
                downloadType: downloadType);

            var config = CreateBufferedDownloadConfiguration(concurrentRequests: 1);
            
            var mockDataHandler = new Mock<IPartDataHandler>();
            mockDataHandler.Setup(x => x.ProcessPartAsync(It.IsAny<int>(), It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            mockDataHandler.Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);

            return new MultipartDownloadManager(client, request, config, mockDataHandler.Object);
        }

        /// <summary>
        /// Creates a response appropriate for discovery based on download type and parameters.
        /// </summary>
        internal static GetObjectResponse CreateDiscoveryResponse(
            MultipartDownloadType downloadType, long objectSize, int? partsCount)
        {
            if (downloadType == MultipartDownloadType.PART)
            {
                if (partsCount == null || partsCount == 1)
                {
                    return CreateSinglePartResponse(objectSize, "single-part-etag");
                }
                else
                {
                    long partSize = objectSize / partsCount.Value;
                    return CreateMultipartFirstPartResponse(partSize, partsCount.Value, objectSize, "multipart-etag");
                }
            }
            else // RANGE
            {
                if (objectSize <= DefaultPartSize)
                {
                    return CreateMockGetObjectResponse(objectSize, null, null, "small-object-etag");
                }
                else
                {
                    return CreateRangeResponse(0, DefaultPartSize - 1, objectSize, "range-etag");
                }
            }
        }

        /// <summary>
        /// Creates a complete test setup for discovery testing.
        /// </summary>
        internal static (Mock<IAmazonS3>, MultipartDownloadManager) CreateDiscoveryTestSetup(
            MultipartDownloadType downloadType, long objectSize, int? partsCount, long? partSize = null)
        {
            var mockResponse = CreateDiscoveryResponse(downloadType, objectSize, partsCount);
            var mockClient = CreateMockS3Client((req, ct) => Task.FromResult(mockResponse));
            var request = CreateOpenStreamRequest(
                partSize: partSize ?? (downloadType == MultipartDownloadType.RANGE ? DefaultPartSize : (long?)null),
                downloadType: downloadType);
            var config = CreateBufferedDownloadConfiguration();
            
            var mockDataHandler = new Mock<IPartDataHandler>();
            mockDataHandler.Setup(x => x.ProcessPartAsync(It.IsAny<int>(), It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            mockDataHandler.Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);

            var coordinator = new MultipartDownloadManager(mockClient.Object, request, config, mockDataHandler.Object);

            return (mockClient, coordinator);
        }

        /// <summary>
        /// Creates a basic mock data handler for testing.
        /// </summary>
        internal static Mock<IPartDataHandler> CreateMockDataHandler()
        {
            var mockHandler = new Mock<IPartDataHandler>();
            mockHandler.Setup(x => x.ProcessPartAsync(It.IsAny<int>(), It.IsAny<GetObjectResponse>(), It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            mockHandler.Setup(x => x.WaitForCapacityAsync(It.IsAny<CancellationToken>()))
                .Returns(Task.CompletedTask);
            mockHandler.Setup(x => x.ReleaseCapacity());
            mockHandler.Setup(x => x.OnDownloadComplete(It.IsAny<Exception>()));
            return mockHandler;
        }

        #endregion

        #region FileDownloadConfiguration Creation

        /// <summary>
        /// Creates a default FileDownloadConfiguration for testing.
        /// </summary>
        internal static FileDownloadConfiguration CreateFileDownloadConfiguration(
            int concurrentRequests = DefaultConcurrentRequests,
            int bufferSize = BufferSize,
            long partSize = DefaultPartSize,
            string destinationPath = null)
        {
            destinationPath = destinationPath ?? Path.Combine(Path.GetTempPath(), $"test-download-{Guid.NewGuid()}.dat");
            return new FileDownloadConfiguration(
                concurrentRequests,
                bufferSize,
                partSize,
                destinationPath);
        }

        #endregion

        #region TransferUtilityDownloadRequest Creation

        /// <summary>
        /// Creates a mock TransferUtilityDownloadRequest for testing.
        /// </summary>
        public static TransferUtilityDownloadRequest CreateDownloadRequest(
            string bucketName = "test-bucket",
            string key = "test-key",
            string filePath = null,
            long? partSize = null)
        {
            filePath = filePath ?? Path.Combine(Path.GetTempPath(), $"test-download-{Guid.NewGuid()}.dat");
            
            var request = new TransferUtilityDownloadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath
            };
            
            if (partSize.HasValue)
            {
                request.PartSize = partSize.Value;
            }
            
            return request;
        }

        #endregion

        #region Temporary File Management

        /// <summary>
        /// Creates a temporary file path for testing.
        /// Returns path in temp directory with unique name.
        /// </summary>
        public static string CreateTempFilePath(string fileName = null)
        {
            fileName = fileName ?? $"test-download-{Guid.NewGuid()}.dat";
            return Path.Combine(Path.GetTempPath(), fileName);
        }

        /// <summary>
        /// Cleans up temporary files used in tests.
        /// Safe to call even if files don't exist.
        /// </summary>
        public static void CleanupTempFiles(params string[] filePaths)
        {
            foreach (var filePath in filePaths)
            {
                if (string.IsNullOrEmpty(filePath))
                    continue;

                try
                {
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }
                }
                catch
                {
                    // Best effort cleanup - don't throw
                }
            }
        }

        /// <summary>
        /// Creates a temporary directory for test files.
        /// </summary>
        public static string CreateTempDirectory()
        {
            var tempDir = Path.Combine(Path.GetTempPath(), $"S3Tests_{Guid.NewGuid()}");
            Directory.CreateDirectory(tempDir);
            return tempDir;
        }

        /// <summary>
        /// Cleans up a temporary directory and all its contents.
        /// Safe to call even if directory doesn't exist.
        /// </summary>
        public static void CleanupTempDirectory(string directoryPath)
        {
            if (string.IsNullOrEmpty(directoryPath))
                return;

            try
            {
                if (Directory.Exists(directoryPath))
                {
                    Directory.Delete(directoryPath, recursive: true);
                }
            }
            catch
            {
                // Best effort cleanup - don't throw
            }
        }

        #endregion

        #region File Verification

        /// <summary>
        /// Verifies file contents match expected data.
        /// </summary>
        public static bool VerifyFileContents(string filePath, byte[] expectedData)
        {
            if (!File.Exists(filePath))
                return false;

            try
            {
                var actualData = File.ReadAllBytes(filePath);
                return actualData.SequenceEqual(expectedData);
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Verifies file exists and has expected size.
        /// </summary>
        public static bool VerifyFileSize(string filePath, long expectedSize)
        {
            if (!File.Exists(filePath))
                return false;

            try
            {
                var fileInfo = new FileInfo(filePath);
                return fileInfo.Length == expectedSize;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Reads file contents for verification.
        /// </summary>
        public static byte[] ReadFileContents(string filePath)
        {
            if (!File.Exists(filePath))
                return null;

            try
            {
                return File.ReadAllBytes(filePath);
            }
            catch
            {
                return null;
            }
        }

        #endregion

        #region Multi-part File Writing Simulation

        /// <summary>
        /// Simulates writing multiple parts to a file for testing.
        /// Each part has predictable data based on part number and seed.
        /// </summary>
        public static void WritePartsToFile(
            string filePath,
            int totalParts,
            long partSize,
            int seed = 0)
        {
            using (var fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write, FileShare.None))
            {
                for (int i = 0; i < totalParts; i++)
                {
                    var partData = GenerateTestData((int)partSize, seed + i * (int)partSize);
                    fileStream.Write(partData, 0, partData.Length);
                }
            }
        }

        /// <summary>
        /// Verifies multi-part file contents match expected pattern.
        /// </summary>
        public static bool VerifyMultipartFileContents(
            string filePath,
            int totalParts,
            long partSize,
            int seed = 0)
        {
            if (!File.Exists(filePath))
                return false;

            try
            {
                using (var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    for (int i = 0; i < totalParts; i++)
                    {
                        var expectedData = GenerateTestData((int)partSize, seed + i * (int)partSize);
                        var actualData = new byte[partSize];
                        
                        var bytesRead = fileStream.Read(actualData, 0, (int)partSize);
                        if (bytesRead != partSize)
                            return false;

                        if (!expectedData.SequenceEqual(actualData))
                            return false;
                    }
                    
                    // Verify no extra data
                    return fileStream.Position == fileStream.Length;
                }
            }
            catch
            {
                return false;
            }
        }

        #endregion
    }
}
