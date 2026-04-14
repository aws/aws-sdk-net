using Amazon.S3;
using Amazon.S3.Model;
using Amazon.S3.Transfer;
using Amazon.S3.Util;
using AWSSDK_DotNet.IntegrationTests.Utils;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace AWSSDK_DotNet.IntegrationTests.Tests.S3
{
    /// <summary>
    /// Static helpers and standalone types shared by all TransferUtility test classes.
    /// </summary>
    public static class TransferUtilityTestHelpers
    {
        public static readonly long MEG_SIZE = (int)Math.Pow(2, 20);
        public static readonly long KILO_SIZE = (int)Math.Pow(2, 10);

        public static void ConfigureProgressValidator(DirectoryProgressValidator<DownloadDirectoryProgressArgs> progressValidator)
        {
            progressValidator.Validate = (progress, lastProgress) =>
            {
                if (lastProgress != null)
                {
                    Assert.True(progress.NumberOfFilesDownloaded >= lastProgress.NumberOfFilesDownloaded);
                    Assert.True(progress.TransferredBytes >= lastProgress.TransferredBytes);
                    if (progress.NumberOfFilesDownloaded == lastProgress.NumberOfFilesDownloaded)
                    {
                        Assert.True(progress.TransferredBytes - lastProgress.TransferredBytes >= 100 * KILO_SIZE);
                    }
                }

                if (progress.NumberOfFilesDownloaded == progress.TotalNumberOfFiles)
                {
                    Assert.Equal(progress.TransferredBytes, progress.TotalBytes);
                    progressValidator.IsProgressEventComplete = true;
                }

                Console.WriteLine(progress.ToString());
            };
        }

        public static void ConfigureProgressValidator(DirectoryProgressValidator<UploadDirectoryProgressArgs> progressValidator)
        {
            progressValidator.Validate = (progress, lastProgress) =>
            {
                if (RetryUtilities.TestClockSkewCorrection)
                    return;

                Assert.False(string.IsNullOrEmpty(progress.CurrentFile));
                Assert.True(progress.TotalNumberOfBytesForCurrentFile > 0);
                Assert.True(progress.TransferredBytesForCurrentFile > 0);

                if (lastProgress != null)
                {
                    Assert.True(progress.NumberOfFilesUploaded >= lastProgress.NumberOfFilesUploaded);
                    Assert.True(progress.TransferredBytes > lastProgress.TransferredBytes);
                    if (progress.NumberOfFilesUploaded == lastProgress.NumberOfFilesUploaded)
                    {
                        Assert.True(progress.TransferredBytes - lastProgress.TransferredBytes >= 100 * KILO_SIZE);
                    }
                    else
                    {
                        Assert.Equal(progress.TransferredBytesForCurrentFile, progress.TotalNumberOfBytesForCurrentFile);
                    }
                }

                if (progress.NumberOfFilesUploaded == progress.TotalNumberOfFiles)
                {
                    Assert.Equal(progress.TransferredBytes, progress.TotalBytes);
                    progressValidator.IsProgressEventComplete = true;
                }

                Console.Write("\t{0} : {1}/{2}\t", progress.CurrentFile,
                    progress.TransferredBytesForCurrentFile, progress.TotalNumberOfBytesForCurrentFile);
                Console.WriteLine(progress.ToString());
            };
        }

        public static async Task ValidateFileContents(string bucketName, string key, string path)
        {
            var ext = Path.GetExtension(key);
            await ValidateFileContents(bucketName, key, path, AmazonS3Util.MimeTypeFromExtension(ext));
        }

        private static readonly AmazonS3Client _sharedValidationClient = new AmazonS3Client();

        public static async Task ValidateFileContents(string bucketName, string key, string path, string contentType)
        {
            var downloadPath = path + ".chk";
            var request = new GetObjectRequest
            {
                BucketName = bucketName,
                Key = key,
            };

            await UtilityMethods.WaitUntilAsync(async () =>
            {
                using (var response = await _sharedValidationClient.GetObjectAsync(request))
                {
                    if (!string.IsNullOrEmpty(contentType))
                    {
                        Assert.Equal(contentType, response.Headers.ContentType);
                    }

                    await response.WriteResponseStreamToFileAsync(downloadPath, append: false, cancellationToken: default);
                }
                return true;
            }, sleepSeconds: 2, maxWaitSeconds: 10);

            UtilityMethods.CompareFiles(path, downloadPath);
        }

        public static async Task ValidateDirectoryContents(string bucketName, string keyPrefix, DirectoryInfo sourceDirectory)
        {
            await ValidateDirectoryContents(bucketName, keyPrefix, sourceDirectory, null);
        }

        public static async Task ValidateDirectoryContents(string bucketName, string keyPrefix, DirectoryInfo sourceDirectory, string contentType)
        {
            var directoryPath = sourceDirectory.FullName;
            var files = sourceDirectory.GetFiles("*", SearchOption.AllDirectories);
            await Task.WhenAll(files.Select(file =>
            {
                var filePath = file.FullName;
                var key = filePath.Substring(directoryPath.Length + 1);
                key = (!string.IsNullOrEmpty(keyPrefix) ? keyPrefix + "/" : string.Empty) + key.Replace("\\", "/");
                return ValidateFileContents(bucketName, key, filePath, contentType);
            }));
        }

        public static DirectoryInfo CreateTestDirectory(long size = 0, int numberOfTestFiles = 5)
        {
            if (size == 0)
            {
                size = 1 * MEG_SIZE;
            }

            var directoryPath = GenerateDirectoryPath();
            for (int i = 0; i < numberOfTestFiles; i++)
            {
                var filePath = Path.Combine(Path.Combine(directoryPath, i.ToString()), "file.txt");
                UtilityMethods.GenerateFile(filePath, size);
            }

            return new DirectoryInfo(directoryPath);
        }

        public static DirectoryInfo CreateTestDirectoryWithFilePrefix(long size = 0, string filePrefix = null, int numberOfTestFiles = 5)
        {
            if (string.IsNullOrWhiteSpace(filePrefix))
            {
                return CreateTestDirectory(size, numberOfTestFiles);
            }

            int numberOfTestFilesInChildDirectory = numberOfTestFiles / 2;
            int numberOfTestFilesInParentDirectory = numberOfTestFiles - numberOfTestFilesInChildDirectory;

            if (size == 0)
            {
                size = 1 * KILO_SIZE;
            }

            var parentDirectory = GenerateDirectoryPath();
            for (int i = 0; i < numberOfTestFilesInParentDirectory; i++)
            {
                var parentDirectoryFilePath = Path.Combine(parentDirectory, filePrefix.Trim() + i.ToString() + "file.txt");
                UtilityMethods.GenerateFile(parentDirectoryFilePath, size);
            }

            var childDirectory = Path.Combine(parentDirectory, filePrefix);
            for (int i = 0; i < numberOfTestFilesInChildDirectory; i++)
            {
                var childDirectoryFilePath = Path.Combine(childDirectory, i.ToString() + "file.txt");
                UtilityMethods.GenerateFile(childDirectoryFilePath, size);
            }

            return new DirectoryInfo(parentDirectory);
        }

        public static string GenerateDirectoryPath(string baseName = "DirectoryTest")
        {
            var directoryName = UtilityMethods.GenerateName(baseName);
            var directoryPath = Path.Combine(Path.GetTempPath(), "transferutility", directoryName);
            Directory.CreateDirectory(directoryPath);
            return directoryPath;
        }
    }

    public abstract class ProgressValidator<T>
    {
        private readonly TaskCompletionSource<bool> _completionTcs = new TaskCompletionSource<bool>();
        private bool _isProgressEventComplete;
        private Exception _progressEventException;

        public T LastProgressEventValue { get; set; }

        public bool IsProgressEventComplete
        {
            get => _isProgressEventComplete;
            set
            {
                _isProgressEventComplete = value;
                if (value)
                {
                    _completionTcs.TrySetResult(true);
                }
            }
        }

        public Exception ProgressEventException
        {
            get => _progressEventException;
            set
            {
                _progressEventException = value;
                if (value != null)
                {
                    _completionTcs.TrySetResult(false);
                }
            }
        }

        public async Task AssertOnCompletionAsync()
        {
            if (RetryUtilities.TestClockSkewCorrection)
            {
                return;
            }

            await Task.WhenAny(_completionTcs.Task, Task.Delay(TimeSpan.FromSeconds(10)));

            if (this.ProgressEventException != null)
            {
                throw this.ProgressEventException;
            }

            Assert.True(this.IsProgressEventComplete, "IsProgressEventComplete is false");
        }
    }

    public class TransferProgressValidator<T> : ProgressValidator<T> where T : TransferProgressArgs
    {
        public Action<T> Validate { get; set; }
        public bool ValidateProgressInterval { get; set; }

        public TransferProgressValidator()
        {
            this.ValidateProgressInterval = true;
        }

        public void OnProgressEvent(object sender, T progress)
        {
            try
            {
                Console.WriteLine("Progress Event : {0}%\t{1}/{2}", progress.PercentDone, progress.TransferredBytes,
                    progress.TotalBytes);
                Assert.False(progress.PercentDone > 100, "Progress percent done cannot be greater than 100%");

                if (this.IsProgressEventComplete)
                    Assert.Fail("A progress event was received after completion.");

                if (progress.TransferredBytes == progress.TotalBytes)
                {
                    Assert.Equal(progress.PercentDone, 100);
                    this.IsProgressEventComplete = true;
                }

                if (this.LastProgressEventValue != null)
                {
                    if (progress.PercentDone < this.LastProgressEventValue.PercentDone)
                        Console.WriteLine("Progress Event : --------------------------");

                    Assert.True(progress.PercentDone >= this.LastProgressEventValue.PercentDone);
                    Assert.True(progress.TransferredBytes > this.LastProgressEventValue.TransferredBytes);

                    if (progress.TransferredBytes < progress.TotalBytes)
                    {
                        if (progress.TransferredBytes - this.LastProgressEventValue.TransferredBytes < 100 * TransferUtilityTestHelpers.KILO_SIZE)
                            Console.WriteLine("Progress Event : *******Part Uploaded********");

                        if (this.ValidateProgressInterval)
                        {
                            Assert.True(progress.TransferredBytes - this.LastProgressEventValue.TransferredBytes >= 100 * TransferUtilityTestHelpers.KILO_SIZE);
                        }
                    }
                }

                Validate(progress);
                this.LastProgressEventValue = progress;
            }
            catch (Exception ex)
            {
                this.ProgressEventException = ex;
                Console.WriteLine("Exception caught: {0}", ex.Message);
                throw;
            }
        }
    }

    public class DirectoryProgressValidator<T> : ProgressValidator<T>
    {
        public Action<T, T> Validate { get; set; }

        public void OnProgressEvent(object sender, T progress)
        {
            try
            {
                Validate(progress, this.LastProgressEventValue);
            }
            catch (Exception ex)
            {
                this.ProgressEventException = ex;
                Console.WriteLine("Exception caught: {0}", ex.Message);
                throw;
            }
            finally
            {
                this.LastProgressEventValue = progress;
            }
        }
    }

    public class TransferLifecycleEventValidator<T>
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
                EventFired = true;
            }
            catch (Exception ex)
            {
                EventException = ex;
                EventFired = false;
                Console.WriteLine("Exception caught in lifecycle event: {0}", ex.Message);
            }
        }

        public void AssertEventFired()
        {
            if (EventException != null)
                throw EventException;
            Assert.True(EventFired, $"{typeof(T).Name} event was not fired");
        }
    }

    public class UnseekableStream : MemoryStream
    {
        private readonly bool _setZeroLengthStream;

        public UnseekableStream(byte[] buffer) : base(buffer) { }

        public UnseekableStream(bool setZeroLengthStream) : base()
        {
            _setZeroLengthStream = setZeroLengthStream;
        }

        public override bool CanSeek => false;

        public override long Length
        {
            get
            {
                if (_setZeroLengthStream)
                {
                    return 0;
                }

                throw new NotSupportedException();
            }
        }
    }
}
