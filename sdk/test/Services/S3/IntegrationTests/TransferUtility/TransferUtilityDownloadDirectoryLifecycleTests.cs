using Amazon.S3.Transfer;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.IO;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class TransferUtilityDownloadDirectoryLifecycleTests : TransferUtilityTestBase
    {
        public TransferUtilityDownloadDirectoryLifecycleTests(TransferUtilityFixture fixture) : base(fixture) { }

        [Fact]
        public async Task DownloadDirectoryInitiatedEventTest()
        {
            var eventValidator = new TransferLifecycleEventValidator<DownloadDirectoryInitiatedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.NotNull(args.Request.BucketName);
                    Assert.NotNull(args.Request.S3Directory);
                    Assert.NotNull(args.Request.LocalDirectory);
                }
            };

            await DownloadDirectoryWithLifecycleEvents(1 * TransferUtilityTestHelpers.MEG_SIZE, eventValidator, null, null);
            eventValidator.AssertEventFired();
        }

        [Fact]
        public async Task DownloadDirectoryCompletedEventTest()
        {
            var eventValidator = new TransferLifecycleEventValidator<DownloadDirectoryCompletedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.NotNull(args.Response);
                    Assert.True(args.TotalFiles > 0);
                    Assert.Equal(args.TransferredFiles, args.TotalFiles);
                    Assert.True(args.TotalBytes > 0);
                    Assert.Equal(args.TransferredBytes, args.TotalBytes);
                }
            };
            
            await DownloadDirectoryWithLifecycleEvents(1 * TransferUtilityTestHelpers.MEG_SIZE, null, eventValidator, null);
            eventValidator.AssertEventFired();
        }

        [Fact]
        public async Task DownloadDirectoryFailedEventTest()
        {
            var eventValidator = new TransferLifecycleEventValidator<DownloadDirectoryFailedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                }
            };
            
            var invalidBucketName = "INVALID-BUCKET-NAME-" + Guid.NewGuid().ToString();
            var testDirectory = "test-directory";
            var localDirectory = GenerateDirectoryPath();
            
            var request = new TransferUtilityDownloadDirectoryRequest
            {
                BucketName = invalidBucketName,
                LocalDirectory = localDirectory,
                S3Directory = testDirectory
            };
            request.DownloadDirectoryFailedEvent += eventValidator.OnEventFired;

            try
            {
                await _transfer.DownloadDirectoryAsync(request);
                Assert.Fail("Expected an exception to be thrown for invalid bucket name");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Expected exception caught: {ex.GetType().Name} - {ex.Message}");
            }
            
            eventValidator.AssertEventFired();
        }

        [Fact]
        public async Task DownloadDirectoryCompleteLifecycleTest()
        {
            var initiatedValidator = new TransferLifecycleEventValidator<DownloadDirectoryInitiatedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.Equal(_bucketName, args.Request.BucketName);
                    Assert.NotNull(args.Request.S3Directory);
                    Assert.NotNull(args.Request.LocalDirectory);
                }
            };
            
            var completedValidator = new TransferLifecycleEventValidator<DownloadDirectoryCompletedEventArgs>
            {
                Validate = (args) =>
                {
                    Assert.NotNull(args.Request);
                    Assert.NotNull(args.Response);
                    Assert.Equal(args.TransferredFiles, args.TotalFiles);
                    Assert.Equal(args.TransferredBytes, args.TotalBytes);
                    Assert.True(args.TotalFiles > 0);
                }
            };

            await DownloadDirectoryWithLifecycleEvents(1 * TransferUtilityTestHelpers.MEG_SIZE, initiatedValidator, completedValidator, null);
            initiatedValidator.AssertEventFired();
            completedValidator.AssertEventFired();
        }

        async Task DownloadDirectoryWithLifecycleEvents(long fileSize,
            TransferLifecycleEventValidator<DownloadDirectoryInitiatedEventArgs> initiatedValidator,
            TransferLifecycleEventValidator<DownloadDirectoryCompletedEventArgs> completedValidator,
            TransferLifecycleEventValidator<DownloadDirectoryFailedEventArgs> failedValidator)
        {
            var testDirectory = await CreateAndUploadTestDirectory(fileSize);
            var s3Directory = testDirectory.Name;
            
            var localDirectory = GenerateDirectoryPath();
            
            var request = new TransferUtilityDownloadDirectoryRequest
            {
                BucketName = _bucketName,
                LocalDirectory = localDirectory,
                S3Directory = s3Directory
            };

            if (initiatedValidator != null) request.DownloadDirectoryInitiatedEvent += initiatedValidator.OnEventFired;
            if (completedValidator != null) request.DownloadDirectoryCompletedEvent += completedValidator.OnEventFired;
            if (failedValidator != null) request.DownloadDirectoryFailedEvent += failedValidator.OnEventFired;

            await _transfer.DownloadDirectoryAsync(request);
        }

        async Task<DirectoryInfo> CreateAndUploadTestDirectory(long fileSize, int numberOfTestFiles = 3)
        {
            var directory = CreateTestDirectory(fileSize, numberOfTestFiles);
            var keyPrefix = directory.Name;
            var directoryPath = directory.FullName;

            await _transfer.UploadDirectoryAsync(new TransferUtilityUploadDirectoryRequest
            {
                BucketName = _bucketName,
                Directory = directoryPath,
                KeyPrefix = keyPrefix,
                ContentType = plainTextContentType,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories,
            });
            
            return directory;
        }

        public static DirectoryInfo CreateTestDirectory(long fileSize = 0, int numberOfTestFiles = 3)
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

        public static string GenerateDirectoryPath(string baseName = "DownloadDirectoryLifecycleTest")
        {
            var directoryName = UtilityMethods.GenerateName(baseName);
            var directoryPath = Path.Combine(Path.GetTempPath(), "transferutility", directoryName);
            Directory.CreateDirectory(directoryPath);
            return directoryPath;
        }
    }
}
