using Amazon.S3.Transfer;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Integration tests for TransferUtility upload directory lifecycle events.
    /// Tests the initiated, completed, and failed events for directory uploads.
    /// </summary>
    [Trait("Category", "S3")]
    public class TransferUtilityUploadDirectoryLifecycleTests : TransferUtilityTestBase
    {
        public TransferUtilityUploadDirectoryLifecycleTests(TransferUtilityFixture fixture) : base(fixture) { }

        [Fact]
        public async Task UploadDirectoryInitiatedEventTest()
        {
            var eventValidator = new TransferLifecycleEventValidator<UploadDirectoryInitiatedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.NotNull(args.Request.BucketName);
                    Assert.NotNull(args.Request.Directory);

                    // Verify that total files and bytes are provided in initiated event
                    Assert.True(args.TotalFiles > 0, "TotalFiles should be greater than 0");
                    Assert.True(args.TotalBytes > 0, "TotalBytes should be greater than 0");
                }
            };

            await UploadDirectoryWithLifecycleEvents(1 * TransferUtilityTestHelpers.MEG_SIZE, eventValidator, null, null);
            eventValidator.AssertEventFired();
        }

        [Fact]
        public async Task UploadDirectoryCompletedEventTest()
        {
            var eventValidator = new TransferLifecycleEventValidator<UploadDirectoryCompletedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.NotNull(args.Response);

                    // Verify progress information is available in completed event
                    Assert.True(args.TotalFiles > 0, "TotalFiles should be greater than 0");
                    Assert.Equal(args.TransferredFiles, args.TotalFiles);
                    Assert.True(args.TotalBytes > 0, "TotalBytes should be greater than 0");
                    Assert.Equal(args.TransferredBytes, args.TotalBytes);

                    // Verify response contains expected data
                    Assert.Equal(args.TransferredFiles, args.Response.ObjectsUploaded);
                    Assert.Equal(0, args.Response.ObjectsFailed);
                    Assert.Equal(DirectoryResult.Success, args.Response.Result);
                }
            };

            await UploadDirectoryWithLifecycleEvents(1 * TransferUtilityTestHelpers.MEG_SIZE, null, eventValidator, null);
            eventValidator.AssertEventFired();
        }

        [Fact]
        public async Task UploadDirectoryFailedEventTest()
        {
            var eventValidator = new TransferLifecycleEventValidator<UploadDirectoryFailedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                }
            };

            // Use an invalid bucket name to force a real exception
            // Bucket names with uppercase letters are invalid and will cause an exception
            var invalidBucketName = "INVALID-BUCKET-NAME-" + Guid.NewGuid().ToString();
            var directory = CreateTestDirectory(1 * TransferUtilityTestHelpers.MEG_SIZE);
            var directoryPath = directory.FullName;

            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = invalidBucketName,
                Directory = directoryPath,
                KeyPrefix = "test-prefix",
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories
            };
            request.UploadDirectoryFailedEvent += eventValidator.OnEventFired;

            try
            {
                await _transfer.UploadDirectoryAsync(request);
                Assert.Fail("Expected an exception to be thrown for invalid bucket name");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Expected exception caught: {ex.GetType().Name} - {ex.Message}");
            }

            eventValidator.AssertEventFired();
        }

        [Fact]
        public async Task UploadDirectoryCompleteLifecycleTest()
        {
            var initiatedValidator = new TransferLifecycleEventValidator<UploadDirectoryInitiatedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.Equal(_bucketName, args.Request.BucketName);
                    Assert.NotNull(args.Request.Directory);
                    Assert.True(args.TotalFiles > 0);
                    Assert.True(args.TotalBytes > 0);
                }
            };

            var completedValidator = new TransferLifecycleEventValidator<UploadDirectoryCompletedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.NotNull(args.Response);
                    Assert.Equal(args.TransferredFiles, args.TotalFiles);
                    Assert.Equal(args.TransferredBytes, args.TotalBytes);
                    Assert.True(args.TotalFiles > 0, "Should have uploaded at least one file");
                    Assert.Equal(DirectoryResult.Success, args.Response.Result);
                }
            };

            await UploadDirectoryWithLifecycleEvents(1 * TransferUtilityTestHelpers.MEG_SIZE, initiatedValidator, completedValidator, null);

            initiatedValidator.AssertEventFired();
            completedValidator.AssertEventFired();
        }

        async Task UploadDirectoryWithLifecycleEvents(long fileSize,
            TransferLifecycleEventValidator<UploadDirectoryInitiatedEventArgs> initiatedValidator,
            TransferLifecycleEventValidator<UploadDirectoryCompletedEventArgs> completedValidator,
            TransferLifecycleEventValidator<UploadDirectoryFailedEventArgs> failedValidator)
        {
            var directory = CreateTestDirectory(fileSize);
            var keyPrefix = directory.Name;
            var directoryPath = directory.FullName;

            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = _bucketName,
                Directory = directoryPath,
                KeyPrefix = keyPrefix,
                ContentType = plainTextContentType,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories
            };

            if (initiatedValidator != null) request.UploadDirectoryInitiatedEvent += initiatedValidator.OnEventFired;
            if (completedValidator != null) request.UploadDirectoryCompletedEvent += completedValidator.OnEventFired;
            if (failedValidator != null) request.UploadDirectoryFailedEvent += failedValidator.OnEventFired;

            await _transfer.UploadDirectoryAsync(request);
        }

        static DirectoryInfo CreateTestDirectory(long fileSize = 0, int numberOfTestFiles = 3)
        {
            if (fileSize == 0)
                fileSize = 1 * TransferUtilityTestHelpers.MEG_SIZE;

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
            var directoryPath = Path.Combine(Path.GetTempPath(), "transferutility", directoryName);
            Directory.CreateDirectory(directoryPath);
            return directoryPath;
        }
    }
}
