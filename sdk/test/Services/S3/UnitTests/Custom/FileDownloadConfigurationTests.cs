using Amazon.S3.Transfer.Internal;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class FileDownloadConfigurationTests
    {
        #region Constructor Tests - Valid Parameters

        [TestMethod]
        public void Constructor_WithValidParameters_CreatesConfiguration()
        {
            // Arrange
            var concurrentRequests = 5;
            var bufferSize = 8192;
            var partSize = 8 * 1024 * 1024;
            var destinationPath = "test.dat";

            // Act
            var config = new FileDownloadConfiguration(
                concurrentRequests,
                bufferSize,
                partSize,
                destinationPath);

            // Assert
            Assert.IsNotNull(config);
        }

        [TestMethod]
        public void Constructor_SetsConcurrentServiceRequests()
        {
            // Arrange
            var expectedConcurrentRequests = 10;

            // Act
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                concurrentRequests: expectedConcurrentRequests);

            // Assert
            Assert.AreEqual(expectedConcurrentRequests, config.ConcurrentServiceRequests);
        }

        [TestMethod]
        public void Constructor_SetsTargetPartSizeBytes()
        {
            // Arrange
            var expectedPartSize = 16 * 1024 * 1024;

            // Act
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                partSize: expectedPartSize);

            // Assert
            Assert.AreEqual(expectedPartSize, config.TargetPartSizeBytes);
        }

        [TestMethod]
        public void Constructor_SetsBufferSize()
        {
            // Arrange
            var expectedBufferSize = 16384;

            // Act
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                bufferSize: expectedBufferSize);

            // Assert
            Assert.AreEqual(expectedBufferSize, config.BufferSize);
        }

        [TestMethod]
        public void Constructor_SetsDestinationFilePath()
        {
            // Arrange
            var expectedPath = Path.Combine(Path.GetTempPath(), "test-file.dat");

            // Act
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: expectedPath);

            // Assert
            Assert.AreEqual(expectedPath, config.DestinationFilePath);
        }

        #endregion

        #region Constructor Tests - Parameter Validation

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_WithZeroConcurrentServiceRequests_ThrowsArgumentOutOfRangeException()
        {
            // Act
            var config = new FileDownloadConfiguration(0, 8192, 8 * 1024 * 1024, "test.dat");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_WithNegativeConcurrentServiceRequests_ThrowsArgumentOutOfRangeException()
        {
            // Act
            var config = new FileDownloadConfiguration(-1, 8192, 8 * 1024 * 1024, "test.dat");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_WithZeroBufferSize_ThrowsArgumentOutOfRangeException()
        {
            // Act
            var config = new FileDownloadConfiguration(10, 0, 8 * 1024 * 1024, "test.dat");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_WithNegativeBufferSize_ThrowsArgumentOutOfRangeException()
        {
            // Act
            var config = new FileDownloadConfiguration(10, -1, 8 * 1024 * 1024, "test.dat");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_WithZeroTargetPartSizeBytes_ThrowsArgumentOutOfRangeException()
        {
            // Act
            var config = new FileDownloadConfiguration(10, 8192, 0, "test.dat");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void Constructor_WithNegativeTargetPartSizeBytes_ThrowsArgumentOutOfRangeException()
        {
            // Act
            var config = new FileDownloadConfiguration(10, 8192, -1, "test.dat");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_WithNullDestinationFilePath_ThrowsArgumentException()
        {
            // Act
            var config = new FileDownloadConfiguration(10, 8192, 8 * 1024 * 1024, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_WithEmptyDestinationFilePath_ThrowsArgumentException()
        {
            // Act
            var config = new FileDownloadConfiguration(10, 8192, 8 * 1024 * 1024, "");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Constructor_WithWhitespaceDestinationFilePath_ThrowsArgumentException()
        {
            // Act
            var config = new FileDownloadConfiguration(10, 8192, 8 * 1024 * 1024, "   ");
        }

        #endregion

        #region Property Tests

        [TestMethod]
        public void BufferSize_PropertyGetter_ReturnsCorrectValue()
        {
            // Arrange
            var expectedBufferSize = 16384;
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                bufferSize: expectedBufferSize);

            // Act
            var actualBufferSize = config.BufferSize;

            // Assert
            Assert.AreEqual(expectedBufferSize, actualBufferSize);
        }

        [TestMethod]
        public void DestinationFilePath_PropertyGetter_ReturnsCorrectValue()
        {
            // Arrange
            var expectedPath = "test-file.dat";
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: expectedPath);

            // Act
            var actualPath = config.DestinationFilePath;

            // Assert
            Assert.AreEqual(expectedPath, actualPath);
        }

        [TestMethod]
        public void ConcurrentServiceRequests_InheritsFromBase()
        {
            // Arrange
            var expectedValue = 15;
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                concurrentRequests: expectedValue);

            // Act
            var actualValue = config.ConcurrentServiceRequests;

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        [TestMethod]
        public void TargetPartSizeBytes_InheritsFromBase()
        {
            // Arrange
            var expectedValue = 16 * 1024 * 1024;
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                partSize: expectedValue);

            // Act
            var actualValue = config.TargetPartSizeBytes;

            // Assert
            Assert.AreEqual(expectedValue, actualValue);
        }

        #endregion

        #region Edge Case Tests

        [TestMethod]
        public void Constructor_WithMinimumValidValues_CreatesConfiguration()
        {
            // Arrange & Act
            var config = new FileDownloadConfiguration(1, 1, 1, "a");

            // Assert
            Assert.IsNotNull(config);
            Assert.AreEqual(1, config.ConcurrentServiceRequests);
            Assert.AreEqual(1, config.BufferSize);
            Assert.AreEqual(1, config.TargetPartSizeBytes);
            Assert.AreEqual("a", config.DestinationFilePath);
        }

        [TestMethod]
        public void Constructor_WithLargeBufferSize_CreatesConfiguration()
        {
            // Arrange
            var largeBufferSize = 1024 * 1024; // 1MB buffer

            // Act
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                bufferSize: largeBufferSize);

            // Assert
            Assert.AreEqual(largeBufferSize, config.BufferSize);
        }

        [TestMethod]
        public void Constructor_WithLargePartSize_CreatesConfiguration()
        {
            // Arrange
            var largePartSize = 128L * 1024 * 1024; // 128MB

            // Act
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                partSize: largePartSize);

            // Assert
            Assert.AreEqual(largePartSize, config.TargetPartSizeBytes);
        }

        [TestMethod]
        public void Constructor_WithVeryLongFilePath_CreatesConfiguration()
        {
            // Arrange - Create a long but valid path
            var longFileName = new string('a', 200) + ".dat";
            var longPath = Path.Combine(Path.GetTempPath(), longFileName);

            // Act
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: longPath);

            // Assert
            Assert.AreEqual(longPath, config.DestinationFilePath);
        }

        [TestMethod]
        public void Constructor_WithFilePathContainingSpecialCharacters_CreatesConfiguration()
        {
            // Arrange
            var specialPath = Path.Combine(Path.GetTempPath(), "test-file[1]@2024.dat");

            // Act
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: specialPath);

            // Assert
            Assert.AreEqual(specialPath, config.DestinationFilePath);
        }

        [TestMethod]
        public void Constructor_WithUNCPath_CreatesConfiguration()
        {
            // Arrange
            var uncPath = @"\\server\share\file.dat";

            // Act
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: uncPath);

            // Assert
            Assert.AreEqual(uncPath, config.DestinationFilePath);
        }

        [TestMethod]
        public void Constructor_WithRelativePath_CreatesConfiguration()
        {
            // Arrange
            var relativePath = @".\subfolder\file.dat";

            // Act
            var config = MultipartDownloadTestHelpers.CreateFileDownloadConfiguration(
                destinationPath: relativePath);

            // Assert
            Assert.AreEqual(relativePath, config.DestinationFilePath);
        }

        #endregion
    }
}
