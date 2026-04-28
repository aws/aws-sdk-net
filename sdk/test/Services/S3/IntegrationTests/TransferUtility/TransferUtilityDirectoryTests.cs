using Amazon.S3;
using Amazon.S3.Transfer;
using AWSSDK_DotNet.IntegrationTests.Tests.S3.Fixtures;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    [Trait("Category", "S3")]
    public class TransferUtilityDirectoryTests : TransferUtilityTestBase
    {
        public TransferUtilityDirectoryTests(TransferUtilityFixture fixture) : base(fixture)
        {
        }

        [Fact]
        public async Task UploadDirectoryWithProgressTracker()
        {
            var progressValidator = new DirectoryProgressValidator<UploadDirectoryProgressArgs>();
            TransferUtilityTestHelpers.ConfigureProgressValidator(progressValidator);

            await UploadDirectory(2 * TransferUtilityTestHelpers.MEG_SIZE, progressValidator, true);
            await progressValidator.AssertOnCompletionAsync();
        }

        [Fact]
        public async Task DownloadNonExistentS3Directory()
        {
            var downloadPath = TransferUtilityTestHelpers.GenerateDirectoryPath();
            await _transfer.DownloadDirectoryAsync(new TransferUtilityDownloadDirectoryRequest
            {
                BucketName = _bucketName,
                S3Directory = "NonExistentS3Directory",
                LocalDirectory = downloadPath,
            });

            var downloadedFiles = Directory.EnumerateFiles(downloadPath, "*", SearchOption.AllDirectories).ToList();
            Assert.Equal(0, downloadedFiles.Count);
        }

        [Fact]
        public async Task DownloadDirectoryProgressTest()
        {
            using (RetryUtilities.DisableClockSkewCorrection())
            {
                var progressValidator = new DirectoryProgressValidator<DownloadDirectoryProgressArgs>();
                TransferUtilityTestHelpers.ConfigureProgressValidator(progressValidator);

                await DownloadDirectory(progressValidator);
                await progressValidator.AssertOnCompletionAsync();
            }
        }

        [Fact]
        public async Task DownloadDirectoryWithDisableSlashCorrectionForS3DirectoryProgressTest()
        {
            using (RetryUtilities.DisableClockSkewCorrection())
            {
                var progressValidator = new DirectoryProgressValidator<DownloadDirectoryProgressArgs>();
                TransferUtilityTestHelpers.ConfigureProgressValidator(progressValidator);

                int numberOfTestFiles = 5;
                var downloadDirectory = await DownloadDirectoryWithDisableSlashCorrectionForS3Directory(numberOfTestFiles, progressValidator);
                await progressValidator.AssertOnCompletionAsync();

                Assert.Equal(numberOfTestFiles, downloadDirectory.GetFiles("*", SearchOption.AllDirectories).Count());
                await TransferUtilityTestHelpers.ValidateDirectoryContents(_bucketName, string.Empty, downloadDirectory);
            }
        }

        [Fact]
        public async Task UploadDirectoryWithMixedFileTypesContentTypeTest()
        {
            var directory = CreateMixedFileTypeTestDirectory();
            var keyPrefix = directory.Name;

            var request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = _bucketName,
                Directory = directory.FullName,
                KeyPrefix = keyPrefix,
                SearchPattern = "*",
                SearchOption = SearchOption.AllDirectories
            };

            await _transfer.UploadDirectoryAsync(request);

            await ValidateDirectoryContentTypes(_bucketName, keyPrefix, directory);
        }

        [Fact]
        public async Task UploadDirectoryFailurePolicy_ContinueOnFailure_AllFailures()
        {
            var nonExistentBucket = "non-existent-" + Guid.NewGuid().ToString("N");
            var directory = TransferUtilityTestHelpers.CreateTestDirectory(1 * TransferUtilityTestHelpers.KILO_SIZE, numberOfTestFiles: 3);

            try
            {
                var request = new TransferUtilityUploadDirectoryRequest
                {
                    BucketName = nonExistentBucket,
                    Directory = directory.FullName,
                    SearchPattern = "*",
                    SearchOption = SearchOption.AllDirectories,
                    FailurePolicy = FailurePolicy.ContinueOnFailure,
                    UploadFilesConcurrently = true
                };

                var response = await _transfer.UploadDirectoryWithResponseAsync(request);
                Assert.NotNull(response);
                Assert.Equal(0, response.ObjectsUploaded);
                Assert.Equal(3, response.ObjectsFailed);
                Assert.Equal(DirectoryResult.Failure, response.Result);
            }
            finally
            {
                try { Directory.Delete(directory.FullName, true); } catch { }
            }
        }

        [Fact]
        public async Task UploadDirectoryFailurePolicy_ContinueOnFailure_AllSuccess()
        {
            var directory = TransferUtilityTestHelpers.CreateTestDirectory(1 * TransferUtilityTestHelpers.KILO_SIZE, numberOfTestFiles: 3);
            try
            {
                var request = new TransferUtilityUploadDirectoryRequest
                {
                    BucketName = _bucketName,
                    Directory = directory.FullName,
                    KeyPrefix = directory.Name,
                    SearchPattern = "*",
                    SearchOption = SearchOption.AllDirectories,
                    FailurePolicy = FailurePolicy.ContinueOnFailure,
                    UploadFilesConcurrently = true
                };

                var response = await _transfer.UploadDirectoryWithResponseAsync(request);
                Assert.NotNull(response);
                Assert.Equal(3, response.ObjectsUploaded);
                Assert.Equal(0, response.ObjectsFailed);
                Assert.Equal(DirectoryResult.Success, response.Result);

                await TransferUtilityTestHelpers.ValidateDirectoryContents(_bucketName, directory.Name, directory, plainTextContentType);
            }
            finally
            {
                try { Directory.Delete(directory.FullName, true); } catch { }
            }
        }

        [Fact]
        public async Task UploadDirectoryFailurePolicy_AbortOnFailure_Throws()
        {
            var nonExistentBucket = "non-existent-" + Guid.NewGuid().ToString("N");
            var directory = TransferUtilityTestHelpers.CreateTestDirectory(1 * TransferUtilityTestHelpers.KILO_SIZE, numberOfTestFiles: 2);

            try
            {
                var request = new TransferUtilityUploadDirectoryRequest
                {
                    BucketName = nonExistentBucket,
                    Directory = directory.FullName,
                    SearchPattern = "*",
                    SearchOption = SearchOption.AllDirectories,
                    FailurePolicy = FailurePolicy.AbortOnFailure,
                    UploadFilesConcurrently = true
                };

                await Assert.ThrowsAsync<AmazonS3Exception>(() => 
                    _transfer.UploadDirectoryWithResponseAsync(request)
                );
            }
            finally
            {
                try { Directory.Delete(directory.FullName, true); } catch { }
            }
        }
    }
}
