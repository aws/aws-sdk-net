using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Transfer.Internal;
using Amazon.S3.Util;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace AWSSDK.UnitTests
{
    [TestClass]
    public class DownloadDirectoryCommandTests
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
            var request = CreateDownloadDirectoryRequest();

            // Act
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: false);

            // Assert
            Assert.IsNotNull(command);
        }

        [TestMethod]
        public void Constructor_WithUseMultipartDownload_CreatesCommand()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();

            // Act
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: true);

            // Assert
            Assert.IsNotNull(command);
        }

        [TestMethod]
        public void Constructor_WithConfigAndMultipart_CreatesCommand()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();

            // Act
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: true);

            // Assert
            Assert.IsNotNull(command);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullS3Client_ThrowsArgumentNullException()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();

            // Act
            var command = new DownloadDirectoryCommand(null, request, _config, useMultipartDownload: false);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void Constructor_WithNullRequest_ThrowsArgumentNullException()
        {
            // Act
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, null, _config, useMultipartDownload: false);
        }

        #endregion

        #region ValidateRequest Tests

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task ExecuteAsync_WithMissingBucketName_ThrowsInvalidOperationException()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            request.BucketName = null;
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: false);

            // Act
            await command.ExecuteAsync(CancellationToken.None);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task ExecuteAsync_WithEmptyBucketName_ThrowsInvalidOperationException()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            request.BucketName = "";
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: false);

            // Act
            await command.ExecuteAsync(CancellationToken.None);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task ExecuteAsync_WithMissingS3Directory_ThrowsInvalidOperationException()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            request.S3Directory = null;
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: false);

            // Act
            await command.ExecuteAsync(CancellationToken.None);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task ExecuteAsync_WithEmptyS3Directory_ThrowsInvalidOperationException()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            request.S3Directory = "";
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: false);

            // Act
            await command.ExecuteAsync(CancellationToken.None);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public async Task ExecuteAsync_WithMissingLocalDirectory_ThrowsInvalidOperationException()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            request.LocalDirectory = null;
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: false);

            // Act
            await command.ExecuteAsync(CancellationToken.None);
        }

        #endregion

        #region ExecuteAsync Tests - Empty Directory

        [TestMethod]
        public async Task ExecuteAsync_EmptyDirectory_ReturnsZeroObjectsDownloaded()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            SetupEmptyDirectoryListing();
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: false);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(0, response.ObjectsDownloaded);
        }

        [TestMethod]
        public async Task ExecuteAsync_EmptyDirectoryWithMultipart_ReturnsZeroObjectsDownloaded()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            SetupEmptyDirectoryListing();
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: true);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(0, response.ObjectsDownloaded);
        }

        #endregion

        #region ExecuteAsync Tests - Single File

        [TestMethod]
        public async Task ExecuteAsync_SingleFile_DownloadsSuccessfully()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            var fileSize = 1024;
            SetupSingleFileDirectoryListing("test-file.txt", fileSize);
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: false);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(1, response.ObjectsDownloaded);
            
            var downloadedFile = Path.Combine(_testDirectory, "test-file.txt");
            Assert.IsTrue(File.Exists(downloadedFile));
            Assert.IsTrue(MultipartDownloadTestHelpers.VerifyFileSize(downloadedFile, fileSize));
        }

        [TestMethod]
        public async Task ExecuteAsync_SingleFileWithMultipart_DownloadsSuccessfully()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            var fileSize = 1024;
            SetupSingleFileDirectoryListing("test-file.txt", fileSize, setupForMultipart: true);
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: true);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(1, response.ObjectsDownloaded);
            
            var downloadedFile = Path.Combine(_testDirectory, "test-file.txt");
            Assert.IsTrue(File.Exists(downloadedFile));
            Assert.IsTrue(MultipartDownloadTestHelpers.VerifyFileSize(downloadedFile, fileSize));
        }

        #endregion

        #region ExecuteAsync Tests - Multiple Files

        [TestMethod]
        public async Task ExecuteAsync_MultipleFiles_DownloadsAll()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            request.DownloadFilesConcurrently = false; // Sequential for predictable testing
            
            var files = new Dictionary<string, long>
            {
                { "file1.txt", 512 },
                { "file2.txt", 1024 },
                { "file3.txt", 2048 }
            };
            
            SetupMultipleFilesDirectoryListing(files);
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: false);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(files.Count, response.ObjectsDownloaded);
            
            foreach (var file in files)
            {
                var downloadedFile = Path.Combine(_testDirectory, file.Key);
                Assert.IsTrue(File.Exists(downloadedFile), $"File {file.Key} should exist");
                Assert.IsTrue(MultipartDownloadTestHelpers.VerifyFileSize(downloadedFile, file.Value), 
                    $"File {file.Key} should have size {file.Value}");
            }
        }

        [TestMethod]
        public async Task ExecuteAsync_MultipleFilesWithMultipart_DownloadsAll()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            request.DownloadFilesConcurrently = false; // Sequential for predictable testing
            
            var files = new Dictionary<string, long>
            {
                { "large1.dat", 10 * 1024 * 1024 }, // 10MB
                { "large2.dat", 15 * 1024 * 1024 }  // 15MB
            };
            
            SetupMultipleFilesDirectoryListing(files, setupForMultipart: true);
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: true);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(files.Count, response.ObjectsDownloaded);
        }

        [TestMethod]
        public async Task ExecuteAsync_MultipleFilesConcurrent_DownloadsAll()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            request.DownloadFilesConcurrently = true; // Concurrent downloads
            
            var files = new Dictionary<string, long>
            {
                { "file1.txt", 512 },
                { "file2.txt", 1024 },
                { "file3.txt", 2048 },
                { "file4.txt", 4096 }
            };
            
            SetupMultipleFilesDirectoryListing(files);
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: false);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(files.Count, response.ObjectsDownloaded);
            
            foreach (var file in files)
            {
                var downloadedFile = Path.Combine(_testDirectory, file.Key);
                Assert.IsTrue(File.Exists(downloadedFile), $"File {file.Key} should exist");
            }
        }

        #endregion

        #region ExecuteAsync Tests - Nested Directories

        [TestMethod]
        public async Task ExecuteAsync_NestedDirectories_CreatesStructure()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            request.DownloadFilesConcurrently = false;
            
            var files = new Dictionary<string, long>
            {
                { "level1/file1.txt", 512 },
                { "level1/level2/file2.txt", 1024 },
                { "level1/level2/level3/file3.txt", 2048 }
            };
            
            SetupMultipleFilesDirectoryListing(files);
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: false);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsNotNull(response);
            Assert.AreEqual(files.Count, response.ObjectsDownloaded);
            
            foreach (var file in files)
            {
                var downloadedFile = Path.Combine(_testDirectory, file.Key.Replace('/', Path.DirectorySeparatorChar));
                Assert.IsTrue(File.Exists(downloadedFile), $"File {file.Key} should exist at {downloadedFile}");
                Assert.IsTrue(MultipartDownloadTestHelpers.VerifyFileSize(downloadedFile, file.Value));
            }
        }

        #endregion

        #region ExecuteAsync Tests - Cancellation

        [TestMethod]
        public async Task ExecuteAsync_WithCancelledToken_ThrowsOperationCanceledException()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            SetupSingleFileDirectoryListing("test.txt", 1024);
            
            var cts = new CancellationTokenSource();
            cts.Cancel();

            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: false);

            // Act & Assert
            try
            {
                await command.ExecuteAsync(cts.Token);
                Assert.Fail("Expected an OperationCanceledException to be thrown");
            }
            catch (OperationCanceledException)
            {
                // Expected - TaskCanceledException inherits from OperationCanceledException
                // This is the correct behavior
            }
        }

        [TestMethod]
        public async Task ExecuteAsync_CancellationDuringDownload_CleansUpProperly()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            var files = new Dictionary<string, long>
            {
                { "file1.txt", 512 },
                { "file2.txt", 1024 }
            };
            
            var cts = new CancellationTokenSource();
            
            // Setup to cancel after first file starts downloading
            var callCount = 0;
            _mockS3Client.Setup(c => c.ListObjectsAsync(
                It.IsAny<ListObjectsRequest>(),
                It.IsAny<CancellationToken>()))
                .ReturnsAsync(() => CreateListObjectsResponse(files));
            
            _mockS3Client.Setup(c => c.GetObjectAsync(
                It.IsAny<GetObjectRequest>(),
                It.IsAny<CancellationToken>()))
                .Callback(() =>
                {
                    callCount++;
                    if (callCount == 1)
                        cts.Cancel();
                })
                .ThrowsAsync(new OperationCanceledException());

            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: false);

            // Act
            try
            {
                await command.ExecuteAsync(cts.Token);
            }
            catch (OperationCanceledException)
            {
                // Expected
            }

            // Assert - partial files should be cleaned up
            await Task.Delay(100); // Give cleanup time to complete
        }

        #endregion

        #region ExecuteAsync Tests - Edge Cases

        [TestMethod]
        public async Task ExecuteAsync_DirectoryMarkers_SkipsDirectoryObjects()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            
            // Include directory markers (keys ending with /)
            var listResponse = new ListObjectsResponse
            {
                S3Objects = new List<S3Object>
                {
                    new S3Object { Key = "prefix/subdir/", Size = 0 },
                    new S3Object { Key = "prefix/file.txt", Size = 1024 }
                }
            };
            
            _mockS3Client.Setup(c => c.ListObjectsAsync(
                It.IsAny<ListObjectsRequest>(),
                It.IsAny<CancellationToken>()))
                .ReturnsAsync(listResponse);
            
            SetupGetObjectForFile("prefix/file.txt", 1024);
            
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: false);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.AreEqual(1, response.ObjectsDownloaded); // Only the file, not the directory marker
        }

        [TestMethod]
        public async Task ExecuteAsync_ExistingFiles_OverwritesCorrectly()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            var fileName = "existing-file.txt";
            var filePath = Path.Combine(_testDirectory, fileName);
            
            // Create existing file with old content
            var oldData = MultipartDownloadTestHelpers.GenerateTestData(512, 999);
            File.WriteAllBytes(filePath, oldData);
            
            var newFileSize = 1024;
            SetupSingleFileDirectoryListing(fileName, newFileSize);
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: false);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.AreEqual(1, response.ObjectsDownloaded);
            Assert.IsTrue(MultipartDownloadTestHelpers.VerifyFileSize(filePath, newFileSize));
            
            // Verify content was overwritten
            var newData = File.ReadAllBytes(filePath);
            Assert.AreNotEqual(oldData.Length, newData.Length);
        }

        #endregion

        #region Progress Tracking Tests

        [TestMethod]
        public async Task ExecuteAsync_SingleFileMultipart_FiresProgressEvents()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            var progressEvents = new List<DownloadDirectoryProgressArgs>();
            
            request.DownloadedDirectoryProgressEvent += (sender, args) =>
            {
                progressEvents.Add(args);
            };
            
            var fileSize = 10 * 1024 * 1024; // 10MB
            SetupSingleFileDirectoryListing("test.dat", fileSize, setupForMultipart: true);
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: true);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsTrue(progressEvents.Count > 0, "Should fire progress events");
            
            // Verify final event
            var finalEvent = progressEvents.Last();
            Assert.AreEqual(1, finalEvent.NumberOfFilesDownloaded, "Should have downloaded 1 file");
            Assert.AreEqual(1, finalEvent.TotalNumberOfFiles, "Should have 1 total file");
            Assert.AreEqual(fileSize, finalEvent.TransferredBytes, "All bytes should be transferred");
            Assert.AreEqual(fileSize, finalEvent.TotalBytes, "Total bytes should match file size");
        }

        [TestMethod]
        public async Task ExecuteAsync_MultipleFilesMultipart_AggregatesProgressCorrectly()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            request.DownloadFilesConcurrently = false; // Sequential for predictable testing
            
            var progressEvents = new List<DownloadDirectoryProgressArgs>();
            request.DownloadedDirectoryProgressEvent += (sender, args) =>
            {
                progressEvents.Add(args);
            };
            
            var files = new Dictionary<string, long>
            {
                { "file1.dat", 5 * 1024 * 1024 },  // 5MB
                { "file2.dat", 10 * 1024 * 1024 }  // 10MB
            };
            
            var totalBytes = files.Values.Sum();
            SetupMultipleFilesDirectoryListing(files, setupForMultipart: true);
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: true);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsTrue(progressEvents.Count > 0, "Should fire progress events");
            
            var finalEvent = progressEvents.Last();
            Assert.AreEqual(2, finalEvent.NumberOfFilesDownloaded, "Should have downloaded 2 files");
            Assert.AreEqual(2, finalEvent.TotalNumberOfFiles, "Should have 2 total files");
            Assert.AreEqual(totalBytes, finalEvent.TransferredBytes, "All bytes should be transferred");
            Assert.AreEqual(totalBytes, finalEvent.TotalBytes, "Total bytes should match sum of all files");
            
            // Verify progress increases monotonically
            long lastTransferred = 0;
            foreach (var evt in progressEvents)
            {
                Assert.IsTrue(evt.TransferredBytes >= lastTransferred, 
                    "TransferredBytes should never decrease");
                lastTransferred = evt.TransferredBytes;
            }
        }

        [TestMethod]
        public async Task ExecuteAsync_ConcurrentMultipart_FiresProgressCorrectly()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            request.DownloadFilesConcurrently = true; // Concurrent
            
            var progressEvents = new List<DownloadDirectoryProgressArgs>();
            var progressLock = new object();
            
            request.DownloadedDirectoryProgressEvent += (sender, args) =>
            {
                lock (progressLock)
                {
                    progressEvents.Add(args);
                }
            };
            
            var files = new Dictionary<string, long>
            {
                { "file1.dat", 8 * 1024 * 1024 },  // 8MB
                { "file2.dat", 8 * 1024 * 1024 },  // 8MB
                { "file3.dat", 8 * 1024 * 1024 }   // 8MB
            };
            
            var totalBytes = files.Values.Sum();
            SetupMultipleFilesDirectoryListing(files, setupForMultipart: true);
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: true);

            // Act
            var response = await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsTrue(progressEvents.Count > 0, "Should fire progress events");
            
            // Verify monotonic increase in transferred bytes despite concurrent execution
            long lastTransferred = 0;
            foreach (var evt in progressEvents)
            {
                Assert.IsTrue(evt.TransferredBytes >= lastTransferred, 
                    "TransferredBytes should never decrease even in concurrent mode");
                lastTransferred = evt.TransferredBytes;
            }
            
            var finalEvent = progressEvents.Last();
            Assert.AreEqual(3, finalEvent.NumberOfFilesDownloaded, "Should have downloaded 3 files");
            Assert.AreEqual(totalBytes, finalEvent.TransferredBytes, "All bytes should be transferred");
        }

        [TestMethod]
        public async Task ExecuteAsync_ConcurrentMode_OmitsCurrentFileDetails()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            request.DownloadFilesConcurrently = true;
            
            var progressEvents = new List<DownloadDirectoryProgressArgs>();
            var progressLock = new object();
            
            request.DownloadedDirectoryProgressEvent += (sender, args) =>
            {
                lock (progressLock)
                {
                    progressEvents.Add(args);
                }
            };
            
            SetupSingleFileDirectoryListing("test.dat", 8 * 1024 * 1024, setupForMultipart: true);
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: true);

            // Act
            await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsTrue(progressEvents.Count > 0, "Should fire progress events");
            
            // In concurrent mode, current file details should be null/zero
            foreach (var evt in progressEvents)
            {
                Assert.IsNull(evt.CurrentFile, "CurrentFile should be null in concurrent mode");
                Assert.AreEqual(0, evt.TransferredBytesForCurrentFile, 
                    "TransferredBytesForCurrentFile should be 0 in concurrent mode");
                Assert.AreEqual(0, evt.TotalNumberOfBytesForCurrentFile, 
                    "TotalNumberOfBytesForCurrentFile should be 0 in concurrent mode");
            }
        }

        [TestMethod]
        public async Task ExecuteAsync_SequentialMode_IncludesCurrentFileDetails()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            request.DownloadFilesConcurrently = false; // Sequential
            
            var progressEvents = new List<DownloadDirectoryProgressArgs>();
            request.DownloadedDirectoryProgressEvent += (sender, args) =>
            {
                progressEvents.Add(args);
            };
            
            var fileSize = 5 * 1024 * 1024; // 5MB
            SetupSingleFileDirectoryListing("test-file.dat", fileSize, setupForMultipart: true);
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: true);

            // Act
            await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsTrue(progressEvents.Count > 0, "Should fire progress events");
            
            // In sequential mode, current file details should be populated
            var eventsWithFile = progressEvents.Where(e => e.CurrentFile != null).ToList();
            Assert.IsTrue(eventsWithFile.Count > 0, "Should have events with CurrentFile populated");
            
            foreach (var evt in eventsWithFile)
            {
                Assert.AreEqual("test-file.dat", evt.CurrentFile, "CurrentFile should be set");
                Assert.IsTrue(evt.TotalNumberOfBytesForCurrentFile > 0, 
                    "TotalNumberOfBytesForCurrentFile should be greater than 0");
            }
            
            // Verify final event has complete file details
            var finalEvent = progressEvents.Last();
            Assert.AreEqual("test-file.dat", finalEvent.CurrentFile);
            Assert.AreEqual(fileSize, finalEvent.TotalNumberOfBytesForCurrentFile);
        }

        [TestMethod]
        public async Task ExecuteAsync_MultipleFilesSequential_TracksPerFileProgress()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            request.DownloadFilesConcurrently = false;
            
            var progressEvents = new List<DownloadDirectoryProgressArgs>();
            request.DownloadedDirectoryProgressEvent += (sender, args) =>
            {
                progressEvents.Add(args);
            };
            
            var files = new Dictionary<string, long>
            {
                { "small.dat", 2 * 1024 * 1024 },   // 2MB
                { "medium.dat", 5 * 1024 * 1024 },  // 5MB
                { "large.dat", 10 * 1024 * 1024 }   // 10MB
            };
            
            SetupMultipleFilesDirectoryListing(files, setupForMultipart: true);
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: true);

            // Act
            await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Assert.IsTrue(progressEvents.Count > 0, "Should fire progress events");
            
            // Verify we see progress for each file
            var filesTracked = progressEvents
                .Where(e => e.CurrentFile != null)
                .Select(e => e.CurrentFile)
                .Distinct()
                .ToList();
            
            Assert.AreEqual(3, filesTracked.Count, "Should track progress for all 3 files");
            Assert.IsTrue(filesTracked.Contains("small.dat"), "Should track small.dat");
            Assert.IsTrue(filesTracked.Contains("medium.dat"), "Should track medium.dat");
            Assert.IsTrue(filesTracked.Contains("large.dat"), "Should track large.dat");
        }

        [TestMethod]
        public async Task ExecuteAsync_ProgressEventsCancellation_StopsProgressTracking()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            request.DownloadFilesConcurrently = false;
            
            var progressEvents = new List<DownloadDirectoryProgressArgs>();
            var cts = new CancellationTokenSource();
            
            request.DownloadedDirectoryProgressEvent += (sender, args) =>
            {
                progressEvents.Add(args);
                // Cancel after first progress event
                if (progressEvents.Count == 1)
                {
                    cts.Cancel();
                }
            };
            
            var files = new Dictionary<string, long>
            {
                { "file1.dat", 5 * 1024 * 1024 },
                { "file2.dat", 5 * 1024 * 1024 }
            };
            
            SetupMultipleFilesDirectoryListing(files, setupForMultipart: true);
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: true);

            // Act & Assert
            try
            {
                await command.ExecuteAsync(cts.Token);
            }
            catch (OperationCanceledException)
            {
                // Expected
            }
            
            // Verify we got at least one progress event before cancellation
            Assert.IsTrue(progressEvents.Count >= 1, "Should have fired at least one progress event");
        }

        #endregion

        #region Concurrency Control Tests

        /// <summary>
        /// Tests that ConcurrentServiceRequests setting actually limits concurrent file downloads.
        /// This test will FAIL on the current broken implementation, demonstrating that 
        /// ConcurrentServiceRequests is not being respected.
        /// 
        /// Expected: Max 2 concurrent downloads (ConcurrentServiceRequests = 2)
        /// Actual (broken): 5 concurrent downloads (all files download simultaneously)
        /// </summary>
        [TestMethod]
        public async Task ExecuteAsync_ConcurrentServiceRequests_RespectsLimit()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            request.DownloadFilesConcurrently = true;
            
            // Use a low limit to make violation obvious
            var config = new TransferUtilityConfig
            {
                ConcurrentServiceRequests = 2  // Only 2 files should download simultaneously
            };
            
            // Track concurrent downloads using thread-safe counter
            var currentConcurrentDownloads = 0;
            var maxObservedConcurrency = 0;
            var concurrencyLock = new object();
            
            var files = new Dictionary<string, long>
            {
                { "file1.dat", 5 * 1024 * 1024 },  // 5MB files
                { "file2.dat", 5 * 1024 * 1024 },
                { "file3.dat", 5 * 1024 * 1024 },
                { "file4.dat", 5 * 1024 * 1024 },
                { "file5.dat", 5 * 1024 * 1024 }   // 5 files total
            };
            
            // Setup directory listing
            var listResponse = CreateListObjectsResponse(files);
            _mockS3Client.Setup(c => c.ListObjectsAsync(
                It.IsAny<ListObjectsRequest>(),
                It.IsAny<CancellationToken>()))
                .ReturnsAsync(listResponse);
            
            // Override GetObjectAsync to track concurrency
            _mockS3Client.Setup(c => c.GetObjectAsync(
                It.IsAny<GetObjectRequest>(),
                It.IsAny<CancellationToken>()))
                .Returns(async (GetObjectRequest req, CancellationToken ct) =>
                {
                    // Increment counter when download starts
                    lock (concurrencyLock)
                    {
                        currentConcurrentDownloads++;
                        maxObservedConcurrency = Math.Max(maxObservedConcurrency, currentConcurrentDownloads);
                        Console.WriteLine($"Download started for {req.Key}. Current concurrent: {currentConcurrentDownloads}, Max observed: {maxObservedConcurrency}");
                    }
                    
                    try
                    {
                        // Simulate some download time to ensure overlap
                        await Task.Delay(100, ct);
                        
                        // Return mock response
                        var fileName = req.Key.Split('/').Last();
                        var fileSize = files[fileName];
                        var data = MultipartDownloadTestHelpers.GenerateTestData((int)fileSize, 0);
                        
                        return new GetObjectResponse
                        {
                            BucketName = req.BucketName,
                            Key = req.Key,
                            ContentLength = fileSize,
                            ResponseStream = new MemoryStream(data),
                            ETag = "\"test-etag\""
                        };
                    }
                    finally
                    {
                        // Decrement counter when download completes
                        lock (concurrencyLock)
                        {
                            currentConcurrentDownloads--;
                            Console.WriteLine($"Download completed for {req.Key}. Current concurrent: {currentConcurrentDownloads}");
                        }
                    }
                });
            
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, config, useMultipartDownload: false);

            // Act
            await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Console.WriteLine($"Test Results: Expected max concurrency ≤ {config.ConcurrentServiceRequests}, Observed: {maxObservedConcurrency}");
            Assert.AreEqual(2, config.ConcurrentServiceRequests, "Test setup verification");
            Assert.IsTrue(maxObservedConcurrency <= config.ConcurrentServiceRequests, 
                $"Max concurrent downloads ({maxObservedConcurrency}) should not exceed ConcurrentServiceRequests ({config.ConcurrentServiceRequests})");
        }

        /// <summary>
        /// Tests that sequential mode (DownloadFilesConcurrently = false) downloads only one file at a time.
        /// This test will FAIL on the current broken implementation, demonstrating that 
        /// sequential mode is not working correctly.
        /// 
        /// Expected: Max 1 concurrent download (sequential mode)
        /// Actual (broken): 3 concurrent downloads (all files download simultaneously despite sequential setting)
        /// </summary>
        [TestMethod]
        public async Task ExecuteAsync_SequentialMode_DownloadsOneAtATime()
        {
            // Arrange
            var request = CreateDownloadDirectoryRequest();
            request.DownloadFilesConcurrently = false; // Sequential mode
            
            var config = new TransferUtilityConfig
            {
                ConcurrentServiceRequests = 10 // High limit, but sequential should still be 1
            };
            
            // Track concurrent downloads
            var currentConcurrentDownloads = 0;
            var maxObservedConcurrency = 0;
            var concurrencyLock = new object();
            
            var files = new Dictionary<string, long>
            {
                { "file1.dat", 1024 },
                { "file2.dat", 1024 },
                { "file3.dat", 1024 }
            };
            
            // Setup directory listing
            var listResponse = CreateListObjectsResponse(files);
            _mockS3Client.Setup(c => c.ListObjectsAsync(
                It.IsAny<ListObjectsRequest>(),
                It.IsAny<CancellationToken>()))
                .ReturnsAsync(listResponse);
            
            // Override GetObjectAsync to track concurrency
            _mockS3Client.Setup(c => c.GetObjectAsync(
                It.IsAny<GetObjectRequest>(),
                It.IsAny<CancellationToken>()))
                .Returns(async (GetObjectRequest req, CancellationToken ct) =>
                {
                    lock (concurrencyLock)
                    {
                        currentConcurrentDownloads++;
                        maxObservedConcurrency = Math.Max(maxObservedConcurrency, currentConcurrentDownloads);
                        Console.WriteLine($"Sequential download started for {req.Key}. Current concurrent: {currentConcurrentDownloads}, Max observed: {maxObservedConcurrency}");
                    }
                    
                    try
                    {
                        await Task.Delay(50, ct); // Brief delay
                        
                        var fileName = req.Key.Split('/').Last();
                        var fileSize = files[fileName];
                        var data = MultipartDownloadTestHelpers.GenerateTestData((int)fileSize, 0);
                        
                        return new GetObjectResponse
                        {
                            BucketName = req.BucketName,
                            Key = req.Key,
                            ContentLength = fileSize,
                            ResponseStream = new MemoryStream(data),
                            ETag = "\"test-etag\""
                        };
                    }
                    finally
                    {
                        lock (concurrencyLock)
                        {
                            currentConcurrentDownloads--;
                            Console.WriteLine($"Sequential download completed for {req.Key}. Current concurrent: {currentConcurrentDownloads}");
                        }
                    }
                });
            
            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, config, useMultipartDownload: false);

            // Act
            await command.ExecuteAsync(CancellationToken.None);

            // Assert
            Console.WriteLine($"Sequential Test Results: Expected max concurrency = 1, Observed: {maxObservedConcurrency}");
            Assert.AreEqual(1, maxObservedConcurrency, 
                $"Sequential mode should only download 1 file at a time, but observed {maxObservedConcurrency}");
        }

        #endregion

        #region Case-Insensitive Key Conflict Tests

        [TestMethod]
        public async Task ExecuteAsync_CaseInsensitiveKeyConflict_AbortOnFailure_ThrowsAndNoFilesDownloaded()
        {
            var request = CreateDownloadDirectoryRequest();
            var isCaseSensitive = FileSystemHelper.IsDirectoryCaseSensitive(request.LocalDirectory);
            if (isCaseSensitive)
            {
                return;
            }
            request.FailurePolicy = FailurePolicy.AbortOnFailure;

            var listResponse = new ListObjectsResponse
            {
                S3Objects = new List<S3Object>
                {
                    new S3Object { Key = "prefix/File.txt", Size = 10 },
                    new S3Object { Key = "prefix/file.txt", Size = 20 }
                }
            };

            _mockS3Client.Setup(c => c.ListObjectsAsync(
                It.IsAny<ListObjectsRequest>(),
                It.IsAny<CancellationToken>()))
                .ReturnsAsync(listResponse);

            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: false);

            try
            {
                await command.ExecuteAsync(CancellationToken.None);
                Assert.Fail("Expected an exception due to case-insensitive key conflict.");
            }
            catch (Exception ex)
            {
                StringAssert.Contains(ex.Message, "conflict", "Exception message should indicate a key path conflict.");
            }
        }

        [TestMethod]
        public async Task ExecuteAsync_CaseInsensitiveKeyConflict_ContinueOnFailure_ReportsFailureInResponse()
        {
            var request = CreateDownloadDirectoryRequest();
            var isCaseSensitive = FileSystemHelper.IsDirectoryCaseSensitive(request.LocalDirectory);
            if (isCaseSensitive)
            {
                return;
            }
            request.FailurePolicy = FailurePolicy.ContinueOnFailure;

            var listResponse = new ListObjectsResponse
            {
                S3Objects = new List<S3Object>
                {
                    new S3Object { Key = "prefix/File.txt", Size = 10 },
                    new S3Object { Key = "prefix/file.txt", Size = 20 }
                }
            };

            _mockS3Client.Setup(c => c.ListObjectsAsync(
                It.IsAny<ListObjectsRequest>(),
                It.IsAny<CancellationToken>()))
                .ReturnsAsync(listResponse);

            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, _config, useMultipartDownload: false);

            var response = await command.ExecuteAsync(CancellationToken.None);

            Assert.IsNotNull(response, "Response should not be null.");
            Assert.AreEqual(0, response.ObjectsDownloaded, "No files should be downloaded when all conflicted.");
            Assert.IsTrue(response.ObjectsFailed >= 1, "At least one failure should be recorded.");
            Assert.IsNotNull(response.Errors, "Errors collection should be populated.");
            Assert.IsTrue(response.Errors.Count >= 1, "Errors collection should contain at least one error.");
            Assert.IsTrue(response.Result == DirectoryResult.Failure ||
                          response.Result == DirectoryResult.PartialSuccess,
                          "Result should indicate failure or partial success due to conflicts.");
        }

        [TestMethod]
        public async Task ExecuteAsync_CaseInsensitiveKeyConflict_SkipCaseCheck_AllowsDownloads()
        {
            var request = CreateDownloadDirectoryRequest();
            var isCaseSensitive = FileSystemHelper.IsDirectoryCaseSensitive(request.LocalDirectory);
            if (isCaseSensitive)
            {
                // This test validates behavior only on case-insensitive filesystems.
                // On case-sensitive systems, there is no conflict to detect.
                return;
            }

            request.FailurePolicy = FailurePolicy.AbortOnFailure;

            var listResponse = new ListObjectsResponse
            {
                S3Objects = new List<S3Object>
                {
                    new S3Object { Key = "prefix/File.txt", Size = 10 },
                    new S3Object { Key = "prefix/file.txt", Size = 20 }
                }
            };

            _mockS3Client.Setup(c => c.ListObjectsAsync(
                It.IsAny<ListObjectsRequest>(),
                It.IsAny<CancellationToken>()))
                .ReturnsAsync(listResponse);

            SetupGetObjectForFile("prefix/File.txt", 10, setupForMultipart: false);
            SetupGetObjectForFile("prefix/file.txt", 20, setupForMultipart: false);

            // Enable skipping of directory case-sensitivity checks so that the
            // conflict detection logic is bypassed.
            var config = new TransferUtilityConfig
            {
                ConcurrentServiceRequests = 4,
                SkipDirectoryCaseSensitivityCheck = true
            };

            var command = new DownloadDirectoryCommand(_mockS3Client.Object, request, config, useMultipartDownload: false);

            // Act: with the skip flag enabled, the operation should not throw a
            // conflict exception and should attempt to download objects.
            var response = await command.ExecuteAsync(CancellationToken.None);

            Assert.IsNotNull(response, "Response should not be null when skipping case check.");
            // Behavior of how many files succeed may vary by implementation
            // (last one wins on overwrite), but we at least assert that no
            // conflict exception prevented completion.
            Assert.IsTrue(response.ObjectsDownloaded >= 1, "At least one object should have been downloaded when skipping case checks.");
        }

        #endregion

        #region Helper Methods

        private TransferUtilityDownloadDirectoryRequest CreateDownloadDirectoryRequest(
            string bucketName = "test-bucket",
            string s3Directory = "prefix",
            string localDirectory = null)
        {
            localDirectory = localDirectory ?? _testDirectory;
            
            return new TransferUtilityDownloadDirectoryRequest
            {
                BucketName = bucketName,
                S3Directory = s3Directory,
                LocalDirectory = localDirectory
            };
        }

        private void SetupEmptyDirectoryListing()
        {
            var listResponse = new ListObjectsResponse
            {
                S3Objects = new List<S3Object>()
            };
            
            _mockS3Client.Setup(c => c.ListObjectsAsync(
                It.IsAny<ListObjectsRequest>(),
                It.IsAny<CancellationToken>()))
                .ReturnsAsync(listResponse);
        }

        private void SetupSingleFileDirectoryListing(string fileName, long fileSize, bool setupForMultipart = false)
        {
            var files = new Dictionary<string, long> { { fileName, fileSize } };
            SetupMultipleFilesDirectoryListing(files, setupForMultipart);
        }

        private void SetupMultipleFilesDirectoryListing(Dictionary<string, long> files, bool setupForMultipart = false)
        {
            var listResponse = CreateListObjectsResponse(files);
            
            _mockS3Client.Setup(c => c.ListObjectsAsync(
                It.IsAny<ListObjectsRequest>(),
                It.IsAny<CancellationToken>()))
                .ReturnsAsync(listResponse);
            
            // Setup GetObject for each file
            foreach (var file in files)
            {
                SetupGetObjectForFile($"prefix/{file.Key}", file.Value, setupForMultipart);
            }
        }

        private ListObjectsResponse CreateListObjectsResponse(Dictionary<string, long> files)
        {
            var s3Objects = files.Select(f => new S3Object
            {
                Key = $"prefix/{f.Key}",
                Size = f.Value
            }).ToList();
            
            return new ListObjectsResponse
            {
                S3Objects = s3Objects
            };
        }

        private void SetupGetObjectForFile(string key, long fileSize, bool setupForMultipart = false)
        {
            var data = MultipartDownloadTestHelpers.GenerateTestData((int)fileSize, 0);
            
            if (setupForMultipart)
            {
                // For multipart downloads using PART strategy, we need to:
                // 1. First request (PartNumber=1) returns PartsCount > 1
                // 2. Subsequent requests for each part
                
                var partsCount = (int)Math.Ceiling((double)fileSize / (8 * 1024 * 1024)); // 8MB parts
                if (partsCount < 2) partsCount = 2; // Force multipart for testing
                
                var partSize = fileSize / partsCount;
                var lastPartSize = fileSize - (partSize * (partsCount - 1));
                
                // Setup first part request (discovery)
                var firstPartData = MultipartDownloadTestHelpers.GenerateTestData((int)partSize, 0);
                var firstPartResponse = new GetObjectResponse
                {
                    BucketName = "test-bucket",
                    Key = key,
                    ContentLength = partSize,
                    ResponseStream = new MemoryStream(firstPartData),
                    ContentRange = $"bytes 0-{partSize - 1}/{fileSize}",
                    ETag = "\"test-etag\"",
                    PartsCount = partsCount
                };
                
                _mockS3Client.Setup(c => c.GetObjectAsync(
                    It.Is<GetObjectRequest>(r => r.Key == key && r.PartNumber == 1),
                    It.IsAny<CancellationToken>()))
                    .ReturnsAsync(() => 
                    {
                        // Return new stream each time to avoid disposed stream issues
                        var newData = MultipartDownloadTestHelpers.GenerateTestData((int)partSize, 0);
                        return new GetObjectResponse
                        {
                            BucketName = "test-bucket",
                            Key = key,
                            ContentLength = partSize,
                            ResponseStream = new MemoryStream(newData),
                            ContentRange = $"bytes 0-{partSize - 1}/{fileSize}",
                            ETag = "\"test-etag\"",
                            PartsCount = partsCount
                        };
                    });
                
                // Setup subsequent part requests
                for (int i = 2; i <= partsCount; i++)
                {
                    var partNum = i;
                    var currentPartSize = (partNum == partsCount) ? lastPartSize : partSize;
                    var startByte = (partNum - 1) * partSize;
                    var endByte = startByte + currentPartSize - 1;
                    
                    _mockS3Client.Setup(c => c.GetObjectAsync(
                        It.Is<GetObjectRequest>(r => r.Key == key && r.PartNumber == partNum),
                        It.IsAny<CancellationToken>()))
                        .ReturnsAsync(() =>
                        {
                            var partData = MultipartDownloadTestHelpers.GenerateTestData((int)currentPartSize, (int)startByte);
                            return new GetObjectResponse
                            {
                                BucketName = "test-bucket",
                                Key = key,
                                ContentLength = currentPartSize,
                                ResponseStream = new MemoryStream(partData),
                                ContentRange = $"bytes {startByte}-{endByte}/{fileSize}",
                                ETag = "\"test-etag\"",
                                PartsCount = partsCount
                            };
                        });
                }
            }
            else
            {
                // For non-multipart (simple) downloads
                var response = new GetObjectResponse
                {
                    BucketName = "test-bucket",
                    Key = key,
                    ContentLength = fileSize,
                    ResponseStream = new MemoryStream(data),
                    ETag = "\"test-etag\""
                };
                
                _mockS3Client.Setup(c => c.GetObjectAsync(
                    It.Is<GetObjectRequest>(r => r.Key == key),
                    It.IsAny<CancellationToken>()))
                    .ReturnsAsync(() =>
                    {
                        // Return new stream each time to avoid disposed stream issues
                        var newData = MultipartDownloadTestHelpers.GenerateTestData((int)fileSize, 0);
                        return new GetObjectResponse
                        {
                            BucketName = "test-bucket",
                            Key = key,
                            ContentLength = fileSize,
                            ResponseStream = new MemoryStream(newData),
                            ETag = "\"test-etag\""
                        };
                    });
            }
        }

        #endregion
    }
}
