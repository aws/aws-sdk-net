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
    /// Integration tests for TransferUtility upload directory lifecycle events.
    /// Tests the initiated, completed, and failed events for directory uploads.
    /// </summary>
    [TestClass]
    [TestCategory("S3")]
    public class TransferUtilityUploadDirectoryLifecycleTests : TestBase<AmazonS3Client>
    {
        public static readonly long MEG_SIZE = (int)Math.Pow(2, 20);
        public static readonly long KILO_SIZE = (int)Math.Pow(2, 10);
        public static readonly string BasePath = Path.Combine(Path.GetTempPath(), "transferutility", "uploaddirectorylifecycle");

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
        public async Task UploadDirectoryInitiatedEventTest()
        {
            var eventValidator = new TransferLifecycleEventValidator<UploadDirectoryInitiatedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.IsNotNull(args.Request.BucketName);
                    Assert.IsNotNull(args.Request.Directory);
                    
                    // Verify that total files and bytes are provided in initiated event
                    Assert.IsTrue(args.TotalFiles > 0, "TotalFiles should be greater than 0");
                    Assert.IsTrue(args.TotalBytes > 0, "TotalBytes should be greater than 0");
                }
            };
            
            await UploadDirectoryWithLifecycleEvents(10 * MEG_SIZE, eventValidator, null, null);
            eventValidator.AssertEventFired();
        }

        [TestMethod]
        public async Task UploadDirectoryCompletedEventTest()
        {
            var eventValidator = new TransferLifecycleEventValidator<UploadDirectoryCompletedEventArgs>
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
                    
                    // Verify response contains expected data
                    Assert.AreEqual(args.TransferredFiles, args.Response.ObjectsUploaded, "Response ObjectsUploaded should match TransferredFiles");
                    Assert.AreEqual(0, args.Response.ObjectsFailed, "No objects should have failed");
                    Assert.AreEqual(DirectoryResult.Success, args.Response.Result, "Result should be Success");
                }
            };
            
            await UploadDirectoryWithLifecycleEvents(12 * MEG_SIZE, null, eventValidator, null);
            eventValidator.AssertEventFired();
        }

        [TestMethod]
        public async Task UploadDirectoryFailedEventTest()
        {
            var eventValidator = new TransferLifecycleEventValidator<UploadDirectoryFailedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                }
            };
            
            // Use an invalid bucket name to force a real exception
            // Bucket names with uppercase letters are invalid and will cause an exception
            var invalidBucketName = "INVALID-BUCKET-NAME-" + Guid.NewGuid().ToString();
            var directory = CreateTestDirectory(5 * MEG_SIZE);
            var directoryPath = directory.FullName;
            
            var transferUtility = new TransferUtility(Client);
            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = invalidBucketName, // This will cause an exception due to invalid bucket name
                Directory = directoryPath,
                KeyPrefix = "test-prefix",
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories
            };

            request.UploadDirectoryFailedEvent += eventValidator.OnEventFired;

            try
            {
                await transferUtility.UploadDirectoryAsync(request);
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
        public async Task UploadDirectoryCompleteLifecycleTest()
        {
            var initiatedValidator = new TransferLifecycleEventValidator<UploadDirectoryInitiatedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.AreEqual(bucketName, args.Request.BucketName);
                    Assert.IsNotNull(args.Request.Directory);
                    Assert.IsTrue(args.TotalFiles > 0);
                    Assert.IsTrue(args.TotalBytes > 0);
                }
            };
            
            var completedValidator = new TransferLifecycleEventValidator<UploadDirectoryCompletedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.IsNotNull(args.Request);
                    Assert.IsNotNull(args.Response);
                    Assert.AreEqual(args.TransferredFiles, args.TotalFiles);
                    Assert.AreEqual(args.TransferredBytes, args.TotalBytes);
                    Assert.IsTrue(args.TotalFiles > 0, "Should have uploaded at least one file");
                    Assert.AreEqual(DirectoryResult.Success, args.Response.Result);
                }
            };

            await UploadDirectoryWithLifecycleEvents(15 * MEG_SIZE, initiatedValidator, completedValidator, null);
            
            initiatedValidator.AssertEventFired();
            completedValidator.AssertEventFired();
        }

        #region Helper Methods

        async Task UploadDirectoryWithLifecycleEvents(long fileSize,
            TransferLifecycleEventValidator<UploadDirectoryInitiatedEventArgs> initiatedValidator,
            TransferLifecycleEventValidator<UploadDirectoryCompletedEventArgs> completedValidator,
            TransferLifecycleEventValidator<UploadDirectoryFailedEventArgs> failedValidator)
        {
            var directory = CreateTestDirectory(fileSize);
            var keyPrefix = directory.Name;
            var directoryPath = directory.FullName;
            
            await UploadDirectoryWithLifecycleEventsAndDirectory(directoryPath, keyPrefix, initiatedValidator, completedValidator, failedValidator);
        }

        async Task UploadDirectoryWithLifecycleEventsAndDirectory(string directoryPath, string keyPrefix,
            TransferLifecycleEventValidator<UploadDirectoryInitiatedEventArgs> initiatedValidator,
            TransferLifecycleEventValidator<UploadDirectoryCompletedEventArgs> completedValidator,
            TransferLifecycleEventValidator<UploadDirectoryFailedEventArgs> failedValidator)
        {
            var transferUtility = new TransferUtility(Client);
            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
                Directory = directoryPath,
                KeyPrefix = keyPrefix,
                ContentType = plainTextContentType,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories
            };

            if (initiatedValidator != null)
            {
                request.UploadDirectoryInitiatedEvent += initiatedValidator.OnEventFired;
            }

            if (completedValidator != null)
            {
                request.UploadDirectoryCompletedEvent += completedValidator.OnEventFired;
            }

            if (failedValidator != null)
            {
                request.UploadDirectoryFailedEvent += failedValidator.OnEventFired;
            }

            await transferUtility.UploadDirectoryAsync(request);
            
            // Validate uploaded directory contents if it was successful
            var directory = new DirectoryInfo(directoryPath);
            await ValidateDirectoryContentsInS3(Client, bucketName, keyPrefix, directory);
        }

        static DirectoryInfo CreateTestDirectory(long fileSize = 0, int numberOfTestFiles = 3)
        {
            if (fileSize == 0)
            {
                fileSize = 1 * MEG_SIZE;
            }

            var directoryPath = GenerateDirectoryPath();
            for (int i = 0; i < numberOfTestFiles; i++)
            {
                var filePath = Path.Combine(Path.Combine(directoryPath, i.ToString()), "file.txt");
                UtilityMethods.GenerateFile(filePath, fileSize);
            }

            return new DirectoryInfo(directoryPath);
        }

        static string GenerateDirectoryPath(string baseName = "UploadDirectoryLifecycleTest")
        {
            var directoryName = UtilityMethods.GenerateName(baseName);
            var directoryPath = Path.Combine(BasePath, directoryName);
            return directoryPath;
        }

        static async Task ValidateDirectoryContentsInS3(IAmazonS3 s3client, string bucketName, string keyPrefix, DirectoryInfo sourceDirectory)
        {
            var directoryPath = sourceDirectory.FullName;
            var files = sourceDirectory.GetFiles("*", SearchOption.AllDirectories);
            foreach (var file in files)
            {
                var filePath = file.FullName;
                var relativePath = filePath.Substring(directoryPath.Length + 1);
                var key = (!string.IsNullOrEmpty(keyPrefix) ? keyPrefix + "/" : string.Empty) + relativePath.Replace("\\", "/");
                
                // Verify the object exists in S3
                var metadata = await s3client.GetObjectMetadataAsync(new GetObjectMetadataRequest
                {
                    BucketName = bucketName,
                    Key = key
                });
                Assert.IsNotNull(metadata, $"Object {key} should exist in S3");
                Console.WriteLine($"Validated object exists in S3: {key}");
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
