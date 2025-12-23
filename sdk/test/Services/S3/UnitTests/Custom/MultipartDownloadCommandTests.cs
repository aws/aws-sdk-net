using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Transfer.Internal;
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class MultipartDownloadCommandTests
    {
        private string _testDirectory;
        private Mock<IAmazonS3> _mockS3Client;
        private TransferUtilityConfig _config;

        [TestInitialize]
        public void Setup()
        {
            _testDirectory = MultipartDownloadTestHelpers.CreateTempDirectory();
            _mockS3Client = new Mock<IAmazonS3>();
            _config = new TransferUtilityConfig
            {
                ConcurrentServiceRequests = 4
            };

            // Setup default S3 client config
            var s3Config = new AmazonS3Config
            {
                BufferSize = 8192,
            };
            _mockS3Client.Setup(c => c.Config).Returns(s3Config);
        }

        [TestCleanup]
        public void Cleanup()
        {
            MultipartDownloadTestHelpers.CleanupTempDirectory(_testDirectory);
        }

        #region Constructor Tests

        [TestMethod]
        public void Constructor_WithValidParameters_CreatesCommand()
        {
            // Arrange
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: Path.Combine(_testDirectory, "test.dat"));

            // Act
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Assert
            Assert.IsNotNull(command);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullS3Client_ThrowsArgumentNullException()
        {
            // Arrange
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: Path.Combine(_testDirectory, "test.dat"));

            // Act
            var command = new MultipartDownloadCommand(null, request, _config);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullRequest_ThrowsArgumentNullException()
        {
            // Act
            var command = new MultipartDownloadCommand(_mockS3Client.Object, null, _config);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullConfig_ThrowsArgumentNullException()
        {
            // Arrange
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: Path.Combine(_testDirectory, "test.dat"));

            // Act
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, null);
        }

        [TestMethod]
        public void Constructor_WithSharedHttpThrottler_CreatesCommand()
        {
            // Arrange
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: Path.Combine(_testDirectory, "test.dat"));
            var sharedThrottler = new SemaphoreSlim(10);

            try
            {
                // Act
                var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config, sharedThrottler);

                // Assert
                Assert.IsNotNull(command);
            }
            finally
            {
                sharedThrottler.Dispose();
            }
        }

        [TestMethod]
        public void Constructor_WithNullSharedHttpThrottler_CreatesCommand()
        {
            // Arrange
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: Path.Combine(_testDirectory, "test.dat"));

            // Act
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config, sharedHttpThrottler: null);

            // Assert
            Assert.IsNotNull(command);
        }

        #endregion

        #region ValidateRequest Tests

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task ExecuteAsync_WithMissingBucketName_ThrowsInvalidOperationException()
        {
            // Arrange
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                bucketName: null,
                filePath: Path.Combine(_testDirectory, "test.dat"));
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            await command.ExecuteAsync(CancellationToken.None);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task ExecuteAsync_WithEmptyBucketName_ThrowsInvalidOperationException()
        {
            // Arrange
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                bucketName: "",
                filePath: Path.Combine(_testDirectory, "test.dat"));
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            await command.ExecuteAsync(CancellationToken.None);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task ExecuteAsync_WithMissingKey_ThrowsInvalidOperationException()
        {
            // Arrange
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                key: null,
                filePath: Path.Combine(_testDirectory, "test.dat"));
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            await command.ExecuteAsync(CancellationToken.None);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task ExecuteAsync_WithEmptyKey_ThrowsInvalidOperationException()
        {
            // Arrange
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                key: "",
                filePath: Path.Combine(_testDirectory, "test.dat"));
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            await command.ExecuteAsync(CancellationToken.None);
        }

#if BCL
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task ExecuteAsync_WithMissingFilePath_ThrowsInvalidOperationException()
        {
            // Arrange
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(filePath: null);
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            await command.ExecuteAsync(CancellationToken.None);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task ExecuteAsync_WithEmptyFilePath_ThrowsInvalidOperationException()
        {
            // Arrange
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(filePath: "");
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            await command.ExecuteAsync(CancellationToken.None);
        }
#endif

        #endregion

        #region CreateConfiguration Tests

        [TestMethod]
        public async Task ExecuteAsync_UsesRequestPartSize_WhenSet()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var customPartSize = 16 * 1024 * 1024; // 16MB
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath,
                partSize: customPartSize);

            SetupSuccessfulSinglePartDownload(1024);
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            await command.ExecuteAsync(CancellationToken.None);

            // Assert - Verify coordinator was called (validates config was created)
            _mockS3Client.Verify(c => c.GetObjectAsync(
                It.IsAny<GetObjectRequest>(),
                It.IsAny<CancellationToken>()), Times.Once);
        }

        [TestMethod]
        public async Task ExecuteAsync_UsesDefaultPartSize_WhenNotSet()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);
            // Don't set PartSize - should use 8MB default

            SetupSuccessfulSinglePartDownload(1024);
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            await command.ExecuteAsync(CancellationToken.None);

            // Assert - Verify coordinator was called
            _mockS3Client.Verify(c => c.GetObjectAsync(
                It.IsAny<GetObjectRequest>(),
                It.IsAny<CancellationToken>()), Times.Once);
        }

        [TestMethod]
        public async Task ExecuteAsync_UsesConcurrentRequestsFromConfig()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);
            _config.ConcurrentServiceRequests = 10;

            SetupSuccessfulSinglePartDownload(1024);
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            await command.ExecuteAsync(CancellationToken.None);

            // Assert
            _mockS3Client.Verify(c => c.GetObjectAsync(
                It.IsAny<GetObjectRequest>(),
                It.IsAny<CancellationToken>()), Times.Once);
        }

        [TestMethod]
        public async Task ExecuteAsync_UsesBufferSizeFromS3ClientConfig()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);

            var s3Config = new AmazonS3Config
            {
                BufferSize = 16384,  // Custom buffer size
            };
            _mockS3Client.Setup(c => c.Config).Returns(s3Config);

            SetupSuccessfulSinglePartDownload(1024);
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            await command.ExecuteAsync(CancellationToken.None);

            // Assert
            // Verify the command executed successfully with custom buffer size
            _mockS3Client.Verify(c => c.GetObjectAsync(
                It.IsAny<GetObjectRequest>(),
                It.IsAny<CancellationToken>()), Times.Once);
        }

        #endregion

        #region ExecuteAsync Tests - Single Part Download

        [TestMethod]
        public async Task ExecuteAsync_SinglePartDownload_CompletesSuccessfully()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "single-part.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);

            var fileSize = 1024;
            SetupSuccessfulSinglePartDownload(fileSize);
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(File.Exists(destinationPath));
            Assert.IsTrue(MultipartDownloadTestHelpers.VerifyFileSize(destinationPath, fileSize));
        }

        [TestMethod]
        public async Task ExecuteAsync_SinglePartDownload_SetsContentLengthCorrectly()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);

            var fileSize = 2048;
            SetupSuccessfulSinglePartDownload(fileSize);
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.AreEqual(fileSize, response.Headers.ContentLength);
        }

        [TestMethod]
        public async Task ExecuteAsync_SinglePartDownload_SetsContentRangeCorrectly()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);

            var fileSize = 1024;
            SetupSuccessfulSinglePartDownload(fileSize);
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.AreEqual($"bytes 0-{fileSize - 1}/{fileSize}", response.ContentRange);
        }

        #endregion

        #region ExecuteAsync Tests - Response Mapping

        [TestMethod]
        public async Task ExecuteAsync_MapsETagCorrectly()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);

            var expectedETag = "\"abc123def456\"";
            SetupSuccessfulSinglePartDownload(1024, eTag: expectedETag);
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.AreEqual(expectedETag, response.ETag);
        }

        [TestMethod]
        public async Task ExecuteAsync_MapsServerSideEncryptionMethodCorrectly()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);

            SetupSuccessfulSinglePartDownload(1024, 
                serverSideEncryptionMethod: ServerSideEncryptionMethod.AES256);
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.AreEqual(ServerSideEncryptionMethod.AES256, response.ServerSideEncryptionMethod);
        }

        [TestMethod]
        public async Task ExecuteAsync_MapsServerSideEncryptionKeyManagementServiceKeyId()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);

            var kmsKeyId = "arn:aws:kms:us-east-1:123456789012:key/12345678-1234-1234-1234-123456789012";
            SetupSuccessfulSinglePartDownload(1024, 
                serverSideEncryptionKeyManagementServiceKeyId: kmsKeyId);
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.AreEqual(kmsKeyId, response.ServerSideEncryptionKeyManagementServiceKeyId);
        }

        [TestMethod]
        public async Task ExecuteAsync_MapsServerSideEncryptionCustomerMethod()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);

            SetupSuccessfulSinglePartDownload(1024,
                serverSideEncryptionCustomerMethod: ServerSideEncryptionCustomerMethod.AES256);
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.AreEqual(ServerSideEncryptionCustomerMethod.AES256, 
                response.ServerSideEncryptionCustomerMethod);
        }

        [TestMethod]
        public async Task ExecuteAsync_MapsMetadataCorrectly()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);

            var metadata = new MetadataCollection();
            metadata["x-amz-meta-custom"] = "custom-value";
            SetupSuccessfulSinglePartDownload(1024, metadata: metadata);
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response.Metadata);
            Assert.IsTrue(response.Metadata.Count > 0);
        }

        #endregion

        #region ExecuteAsync Tests - Composite Checksum Handling

        [TestMethod]
        public async Task ExecuteAsync_CompositeChecksum_SetsAllChecksumsToNull()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);

            SetupSuccessfulSinglePartDownload(1024,
                checksumType: ChecksumType.COMPOSITE,
                checksumCRC32: "somecrc32",
                checksumSHA256: "somesha256");
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.AreEqual(ChecksumType.COMPOSITE, response.ChecksumType);
            Assert.IsNull(response.ChecksumCRC32);
            Assert.IsNull(response.ChecksumCRC32C);
            Assert.IsNull(response.ChecksumCRC64NVME);
            Assert.IsNull(response.ChecksumSHA1);
            Assert.IsNull(response.ChecksumSHA256);
        }

        [TestMethod]
        public async Task ExecuteAsync_NonCompositeChecksum_PreservesChecksums()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);

            var expectedCRC32 = "somecrc32value";
            SetupSuccessfulSinglePartDownload(1024,
                checksumType: null, // Not composite
                checksumCRC32: expectedCRC32);
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.AreEqual(expectedCRC32, response.ChecksumCRC32);
        }

        [TestMethod]
        public async Task ExecuteAsync_NullChecksumType_DoesNotThrow()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);

            SetupSuccessfulSinglePartDownload(1024, checksumType: null);
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act & Assert - Should not throw
            var response = await command.ExecuteAsync(CancellationToken.None);
            Assert.IsNotNull(response);
        }

        #endregion

        #region ExecuteAsync Tests - Error Handling

        [TestMethod]
        [ExpectedException(typeof(AmazonS3Exception))]
        public async Task ExecuteAsync_S3ClientThrows_PropagatesException()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);

            _mockS3Client.Setup(c => c.GetObjectAsync(
                It.IsAny<GetObjectRequest>(),
                It.IsAny<CancellationToken>()))
                .ThrowsAsync(new AmazonS3Exception("S3 error"));

            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            await command.ExecuteAsync(CancellationToken.None);
        }

        [TestMethod]
        public async Task ExecuteAsync_Exception_CleansUpTempFiles()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);

            _mockS3Client.Setup(c => c.GetObjectAsync(
                It.IsAny<GetObjectRequest>(),
                It.IsAny<CancellationToken>()))
                .ThrowsAsync(new Exception("Download failed"));

            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            try
            {
                await command.ExecuteAsync(CancellationToken.None);
            }
            catch
            {
                // Expected exception
            }

            // Assert - No temp files should remain
            await Task.Delay(100); // Give cleanup time to complete
            var tempFiles = Directory.GetFiles(_testDirectory, "*.s3tmp.*");
            Assert.AreEqual(0, tempFiles.Length);
        }

        #endregion

        #region ExecuteAsync Tests - Cancellation

        [TestMethod]
        [ExpectedException(typeof(OperationCanceledException))]
        public async Task ExecuteAsync_WithCancelledToken_ThrowsOperationCanceledException()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);

            var cts = new CancellationTokenSource();
            cts.Cancel();

            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            await command.ExecuteAsync(cts.Token);
        }

        [TestMethod]
        public async Task ExecuteAsync_CancellationDuringDownload_CleansUpProperly()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "test.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);

            var cts = new CancellationTokenSource();
            
            // Setup mock to cancel after being called
            _mockS3Client.Setup(c => c.GetObjectAsync(
                It.IsAny<GetObjectRequest>(),
                It.IsAny<CancellationToken>()))
                .Callback(() => cts.Cancel())
                .ThrowsAsync(new OperationCanceledException());

            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            try
            {
                await command.ExecuteAsync(cts.Token);
            }
            catch (OperationCanceledException)
            {
                // Expected
            }

            // Assert - Temp files should be cleaned up
            await Task.Delay(100); // Give cleanup time to complete
            var tempFiles = Directory.GetFiles(_testDirectory, "*.s3tmp.*");
            Assert.AreEqual(0, tempFiles.Length);
        }

        #endregion

        #region Integration Tests

        [TestMethod]
        public async Task Integration_SmallFileDownload_CompletesSuccessfully()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "small-file.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);

            var fileSize = 512; // Small file
            SetupSuccessfulSinglePartDownload(fileSize);
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(File.Exists(destinationPath));
            Assert.IsTrue(MultipartDownloadTestHelpers.VerifyFileSize(destinationPath, fileSize));
            Assert.AreEqual(fileSize, response.Headers.ContentLength);
            Assert.AreEqual($"bytes 0-{fileSize - 1}/{fileSize}", response.ContentRange);

            // Verify no temp files remain
            var tempFiles = Directory.GetFiles(_testDirectory, "*.s3tmp.*");
            Assert.AreEqual(0, tempFiles.Length);
        }

        [TestMethod]
        public async Task Integration_LargeFileDownload_CompletesSuccessfully()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "large-file.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);

            var fileSize = 1024 * 1024; // 1MB file
            SetupSuccessfulSinglePartDownload(fileSize);
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(File.Exists(destinationPath));
            Assert.IsTrue(MultipartDownloadTestHelpers.VerifyFileSize(destinationPath, fileSize));
            Assert.AreEqual(fileSize, response.Headers.ContentLength);
        }

        [TestMethod]
        public async Task Integration_ZeroByteFile_HandlesCorrectly()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "empty-file.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);

            SetupSuccessfulSinglePartDownload(0);
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(File.Exists(destinationPath));
            Assert.AreEqual(0, new FileInfo(destinationPath).Length);
        }

        [TestMethod]
        public async Task Integration_OverwriteExistingFile_SucceedsAndOverwrites()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "overwrite-test.dat");
            
            // Create existing file with different content
            var oldData = MultipartDownloadTestHelpers.GenerateTestData(512, 999);
            File.WriteAllBytes(destinationPath, oldData);
            
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);

            var newFileSize = 1024;
            SetupSuccessfulSinglePartDownload(newFileSize);
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(File.Exists(destinationPath));
            Assert.IsTrue(MultipartDownloadTestHelpers.VerifyFileSize(destinationPath, newFileSize));
            
            // Verify content was overwritten (not same as oldData)
            var newData = File.ReadAllBytes(destinationPath);
            Assert.AreNotEqual(oldData.Length, newData.Length);
        }

        [TestMethod]
        public async Task Integration_NestedDirectory_CreatesDirectoryAndDownloads()
        {
            // Arrange
            var nestedPath = Path.Combine(_testDirectory, "level1", "level2", "level3", "nested-file.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: nestedPath);

            var fileSize = 2048;
            SetupSuccessfulSinglePartDownload(fileSize);
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(File.Exists(nestedPath));
            Assert.IsTrue(MultipartDownloadTestHelpers.VerifyFileSize(nestedPath, fileSize));
        }

        #endregion

        #region Shared HTTP Throttler Tests

        [TestMethod]
        public async Task ExecuteAsync_WithSharedHttpThrottler_CompletesSuccessfully()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "throttled-download.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);

            var fileSize = 1024;
            SetupSuccessfulSinglePartDownload(fileSize);
            
            var sharedThrottler = new SemaphoreSlim(10);
            try
            {
                var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config, sharedThrottler);

                // Act
                var response = await command.ExecuteAsync(CancellationToken.None);

                // Assert
                Assert.IsNotNull(response);
                Assert.IsTrue(File.Exists(destinationPath));
                Assert.IsTrue(MultipartDownloadTestHelpers.VerifyFileSize(destinationPath, fileSize));
            }
            finally
            {
                sharedThrottler.Dispose();
            }
        }

        [TestMethod]
        public async Task ExecuteAsync_WithoutSharedHttpThrottler_CompletesSuccessfully()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "no-throttler-download.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);

            var fileSize = 1024;
            SetupSuccessfulSinglePartDownload(fileSize);
            
            var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config, sharedHttpThrottler: null);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.IsTrue(File.Exists(destinationPath));
            Assert.IsTrue(MultipartDownloadTestHelpers.VerifyFileSize(destinationPath, fileSize));
        }

        [TestMethod]
        public async Task ExecuteAsync_SharedHttpThrottler_DoesNotBlockSinglePartDownload()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "single-part-throttled.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);

            var fileSize = 512; // Small file (single part)
            SetupSuccessfulSinglePartDownload(fileSize);
            
            // Create throttler with limited capacity
            var sharedThrottler = new SemaphoreSlim(1);
            try
            {
                var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config, sharedThrottler);

                // Act
                var response = await command.ExecuteAsync(CancellationToken.None);

                // Assert
                Assert.IsNotNull(response);
                Assert.IsTrue(File.Exists(destinationPath));
                
                // Verify throttler was not exhausted (single part doesn't use it heavily)
                Assert.AreEqual(1, sharedThrottler.CurrentCount);
            }
            finally
            {
                sharedThrottler.Dispose();
            }
        }

        [TestMethod]
        public async Task ExecuteAsync_SharedHttpThrottler_ReleasedOnSuccess()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "throttler-released.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);

            var fileSize = 1024;
            SetupSuccessfulSinglePartDownload(fileSize);
            
            var sharedThrottler = new SemaphoreSlim(5);
            var initialCount = sharedThrottler.CurrentCount;
            
            try
            {
                var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config, sharedThrottler);

                // Act
                await command.ExecuteAsync(CancellationToken.None);

                // Assert - throttler should be back to initial state
                Assert.AreEqual(initialCount, sharedThrottler.CurrentCount);
            }
            finally
            {
                sharedThrottler.Dispose();
            }
        }

        [TestMethod]
        public async Task ExecuteAsync_SharedHttpThrottler_ReleasedOnException()
        {
            // Arrange
            var destinationPath = Path.Combine(_testDirectory, "throttler-released-error.dat");
            var request = MultipartDownloadTestHelpers.CreateDownloadRequest(
                filePath: destinationPath);

            _mockS3Client.Setup(c => c.GetObjectAsync(
                It.IsAny<GetObjectRequest>(),
                It.IsAny<CancellationToken>()))
                .ThrowsAsync(new AmazonS3Exception("Test exception"));

            var sharedThrottler = new SemaphoreSlim(5);
            var initialCount = sharedThrottler.CurrentCount;
            
            try
            {
                var command = new MultipartDownloadCommand(_mockS3Client.Object, request, _config, sharedThrottler);

                // Act & Assert
                await Assert.ThrowsExceptionAsync<AmazonS3Exception>(
                    async () => await command.ExecuteAsync(CancellationToken.None));

                // Throttler should be back to initial state even after exception
                Assert.AreEqual(initialCount, sharedThrottler.CurrentCount);
            }
            finally
            {
                sharedThrottler.Dispose();
            }
        }

        #endregion

        #region Helper Methods

        private void SetupSuccessfulSinglePartDownload(
            long fileSize,
            string eTag = null,
            ServerSideEncryptionMethod serverSideEncryptionMethod = null,
            string serverSideEncryptionKeyManagementServiceKeyId = null,
            ServerSideEncryptionCustomerMethod serverSideEncryptionCustomerMethod = null,
            MetadataCollection metadata = null,
            ChecksumType checksumType = null,
            string checksumCRC32 = null,
            string checksumSHA256 = null)
        {
            var data = MultipartDownloadTestHelpers.GenerateTestData((int)fileSize, 0);
            
            var response = new GetObjectResponse
            {
                ContentLength = fileSize,
                ResponseStream = new MemoryStream(data),
                // Real S3 behavior: ContentRange is NOT included for simple GET requests
                // (single-part downloads without Range headers).
                // ContentRange IS included when Range headers are used, even for single-part downloads.
                // This mock simulates a simple GET without Range headers.
                ContentRange = null,
                ETag = eTag ?? "\"default-etag\"",
                ServerSideEncryptionMethod = serverSideEncryptionMethod,
                ServerSideEncryptionKeyManagementServiceKeyId = serverSideEncryptionKeyManagementServiceKeyId,
                ServerSideEncryptionCustomerMethod = serverSideEncryptionCustomerMethod,
                ChecksumType = checksumType,
                ChecksumCRC32 = checksumCRC32,
                ChecksumSHA256 = checksumSHA256
            };

            // Add metadata items if provided (Metadata property is read-only)
            if (metadata != null)
            {
                foreach (var key in metadata.Keys)
                {
                    response.Metadata[key] = metadata[key];
                }
            }

            _mockS3Client.Setup(c => c.GetObjectAsync(
                It.IsAny<GetObjectRequest>(),
                It.IsAny<CancellationToken>()))
                .ReturnsAsync(response);
        }

        #endregion
    }
}
