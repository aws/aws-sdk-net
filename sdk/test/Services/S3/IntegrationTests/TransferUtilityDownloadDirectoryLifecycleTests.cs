using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Threading.Tasks;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Integration tests for TransferUtility download directory lifecycle events.
    /// Tests the initiated, completed, and failed events for directory downloads.
    /// </summary>
    [TestClass]
    public class TransferUtilityDownloadDirectoryLifecycleTests : TestBase<AmazonS3Client>
    {
        public static readonly long MEG_SIZE = (int)Math.Pow(2, 20);
        public static readonly long KILO_SIZE = (int)Math.Pow(2, 10);
        public static readonly string BasePath = Path.Combine(Path.GetTempPath(), "transferutility", "downloaddirectorylifecycle");

        private static string bucketName;
        private static string plainTextContentType = "text/plain";

        [ClassInitialize]
        public static async Task ClassInitialize(TestContext a)
        {
            bucketName = await S3TestUtils.CreateBucketWithWaitAsync(Client);
        }

        [ClassCleanup]
        public static async Task ClassCleanup()
        {
            await AmazonS3Util.DeleteS3BucketWithObjectsAsync(Client, bucketName);
            BaseClean();
            if (Directory.Exists(BasePath))
            {
                Directory.Delete(BasePath, true);
            }
        }

        [TestMethod]
        [TestCategory("S3")]
        public void DownloadDirectoryInitiatedEventTest()
        {
            var eventValidator = new TransferLifecycleEventValidator<DownloadDirectoryInitiatedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.IsNotNull(args.Request.BucketName);
                    Assert.IsNotNull(args.Request.S3Directory);
                    Assert.IsNotNull(args.Request.LocalDirectory);
                }
            };
            DownloadDirectoryWithLifecycleEvents(10 * MEG_SIZE, eventValidator, null, null);
            eventValidator.AssertEventFired();
        }

        [TestMethod]
        [TestCategory("S3")]
        public void DownloadDirectoryCompletedEventTest()
        {
            var eventValidator = new TransferLifecycleEventValidator<DownloadDirectoryCompletedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.IsNotNull(args.Response);
                    
                    // Verify progress information is available in completed event
                    Assert.IsTrue(args.TotalFiles > 0, "TotalFiles should be greater than 0");
                    Assert.AreEqual(args.TransferredFiles, args.TotalFiles, "All files should be transferred");
                    Assert.IsTrue(args.TotalBytes > 0, "TotalBytes should be greater than 0");
                    Assert.AreEqual(args.TransferredBytes, args.TotalBytes, "All bytes should be transferred");
                }
            };
            DownloadDirectoryWithLifecycleEvents(12 * MEG_SIZE, null, eventValidator, null);
            eventValidator.AssertEventFired();
        }

        [TestMethod]
        [TestCategory("S3")]
        public void DownloadDirectoryFailedEventTest()
        {
            var eventValidator = new TransferLifecycleEventValidator<DownloadDirectoryFailedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                }
            };
            
            // Use an invalid bucket name to force a real exception
            // Bucket names with uppercase letters are invalid and will cause an exception
            var invalidBucketName = "INVALID-BUCKET-NAME-" + Guid.NewGuid().ToString();
            var testDirectory = "test-directory";
            
            var localDirectory = GenerateDirectoryPath();
            
            var transferUtility = new TransferUtility(Client);
            var request = new TransferUtilityDownloadDirectoryRequest
            {
                BucketName = invalidBucketName, // This will cause an exception due to invalid bucket name
                LocalDirectory = localDirectory,
                S3Directory = testDirectory
            };

            request.DownloadDirectoryFailedEvent += eventValidator.OnEventFired;

            try
            {
                transferUtility.DownloadDirectory(request);
                Assert.Fail("Expected an exception to be thrown for invalid bucket name");
            }
            catch (Exception ex)
            {
                // Expected exception - the failed event should have been fired
                Console.WriteLine($"Expected exception caught: {ex.GetType().Name} - {ex.Message}");
            }
            
            eventValidator.AssertEventFired();
        }

        [TestMethod]
        [TestCategory("S3")]
        public void DownloadDirectoryCompleteLifecycleTest()
        {
            var initiatedValidator = new TransferLifecycleEventValidator<DownloadDirectoryInitiatedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.AreEqual(bucketName, args.Request.BucketName);
                    Assert.IsNotNull(args.Request.S3Directory);
                    Assert.IsNotNull(args.Request.LocalDirectory);
                }
            };
            
            var completedValidator = new TransferLifecycleEventValidator<DownloadDirectoryCompletedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.IsNotNull(args.Response);
                    Assert.AreEqual(args.TransferredFiles, args.TotalFiles);
                    Assert.AreEqual(args.TransferredBytes, args.TotalBytes);
                    Assert.IsTrue(args.TotalFiles > 0, "Should have downloaded at least one file");
                }
            };

            DownloadDirectoryWithLifecycleEvents(15 * MEG_SIZE, initiatedValidator, completedValidator, null);
            
            initiatedValidator.AssertEventFired();
            completedValidator.AssertEventFired();
        }

        #region Helper Methods

        void DownloadDirectoryWithLifecycleEvents(long fileSize,
            TransferLifecycleEventValidator<DownloadDirectoryInitiatedEventArgs> initiatedValidator,
            TransferLifecycleEventValidator<DownloadDirectoryCompletedEventArgs> completedValidator,
            TransferLifecycleEventValidator<DownloadDirectoryFailedEventArgs> failedValidator)
        {
            // First create and upload a test directory
            var testDirectory = CreateAndUploadTestDirectory(fileSize);
            var s3Directory = testDirectory.Name;
            
            DownloadDirectoryWithLifecycleEventsAndS3Directory(s3Directory, initiatedValidator, completedValidator, failedValidator);
        }

        void DownloadDirectoryWithLifecycleEventsAndS3Directory(string s3Directory,
            TransferLifecycleEventValidator<DownloadDirectoryInitiatedEventArgs> initiatedValidator,
            TransferLifecycleEventValidator<DownloadDirectoryCompletedEventArgs> completedValidator,
            TransferLifecycleEventValidator<DownloadDirectoryFailedEventArgs> failedValidator)
        {
            var localDirectory = GenerateDirectoryPath();
            
            var transferUtility = new TransferUtility(Client);
            var request = new TransferUtilityDownloadDirectoryRequest
            {
                BucketName = bucketName,
                LocalDirectory = localDirectory,
                S3Directory = s3Directory
            };

            if (initiatedValidator != null)
            {
                request.DownloadDirectoryInitiatedEvent += initiatedValidator.OnEventFired;
            }

            if (completedValidator != null)
            {
                request.DownloadDirectoryCompletedEvent += completedValidator.OnEventFired;
            }

            if (failedValidator != null)
            {
                request.DownloadDirectoryFailedEvent += failedValidator.OnEventFired;
            }

            transferUtility.DownloadDirectory(request);
            
            // Validate downloaded directory contents if it was successful
            if (Directory.Exists(localDirectory))
            {
                var downloadedFiles = Directory.GetFiles(localDirectory, "*", SearchOption.AllDirectories);
                Console.WriteLine($"Downloaded {downloadedFiles.Length} files to {localDirectory}");
            }
        }

        DirectoryInfo CreateAndUploadTestDirectory(long fileSize, int numberOfTestFiles = 3)
        {
            var directory = CreateTestDirectory(fileSize, numberOfTestFiles);
            var keyPrefix = directory.Name;
            var directoryPath = directory.FullName;

            var transferUtility = new TransferUtility(Client);
            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
                Directory = directoryPath,
                KeyPrefix = keyPrefix,
                ContentType = plainTextContentType,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories,
            };

            transferUtility.UploadDirectory(request);
            
            // Validate the upload was successful
            ValidateDirectoryContentsInS3(Client, bucketName, keyPrefix, directory);

            return directory;
        }

        public static DirectoryInfo CreateTestDirectory(long fileSize = 0, int numberOfTestFiles = 3)
        {
            if (fileSize == 0)
                fileSize = 1 * MEG_SIZE;

            var directoryPath = GenerateDirectoryPath();
            for (int i = 0; i < numberOfTestFiles; i++)
            {
                var filePath = Path.Combine(Path.Combine(directoryPath, i.ToString()), "file.txt");
                UtilityMethods.GenerateFile(filePath, fileSize);
            }

            return new DirectoryInfo(directoryPath);
        }

        public static string GenerateDirectoryPath(string baseName = "DownloadDirectoryLifecycleTest")
        {
            var directoryName = UtilityMethods.GenerateName(baseName);
            var directoryPath = Path.Combine(BasePath, directoryName);
            return directoryPath;
        }

        public static void ValidateDirectoryContentsInS3(IAmazonS3 s3client, string bucketName, string keyPrefix, DirectoryInfo sourceDirectory)
        {
            var directoryPath = sourceDirectory.FullName;
            var files = sourceDirectory.GetFiles("*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                var filePath = file.FullName;
                var relativePath = filePath.Substring(directoryPath.Length + 1);
                var key = (!string.IsNullOrEmpty(keyPrefix) ? keyPrefix + "/" : string.Empty) + relativePath.Replace("\\", "/");
                
                // Verify the object exists in S3
                var metadata = s3client.GetObjectMetadata(new GetObjectMetadataRequest
                {
                    BucketName = bucketName,
                    Key = key
                });
                Assert.IsNotNull(metadata, $"Object {key} should exist in S3");
            }
        }

        #endregion

        #region Shared Helper Classes

        class TransferLifecycleEventValidator<T>
        {
            public Action<T> Validate { get; set; }
            public bool EventFired { get; private set; }
            public Exception EventException { get; private set; }

            public void OnEventFired(object sender, T eventArgs)
            {
                try
                {
                    Console.WriteLine("Lifecycle Event Fired: {0}", typeof(T).Name);
                    Validate?.Invoke(eventArgs);
                    EventFired = true;  // Only set if validation passes
                }
                catch (Exception ex)
                {
                    EventException = ex;
                    EventFired = false;  // Ensure we don't mark as fired on failure
                    Console.WriteLine("Exception caught in lifecycle event: {0}", ex.Message);
                    // Don't re-throw, let AssertEventFired() handle it
                }
            }

            public void AssertEventFired()
            {
                if (EventException != null)
                    throw EventException;
                Assert.IsTrue(EventFired, $"{typeof(T).Name} event was not fired");
            }
        }

        #endregion
    }
}
