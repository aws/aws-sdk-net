/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime.Internal.Util;

namespace Amazon.S3.Transfer.Internal
{
    internal partial class UploadDirectoryCommand : BaseCommand<TransferUtilityUploadDirectoryResponse>
    {
        public bool UploadFilesConcurrently { get; set; }
        private readonly Logger _logger = Logger.GetLogger(typeof(UploadDirectoryCommand));

        public override async Task<TransferUtilityUploadDirectoryResponse> ExecuteAsync(CancellationToken cancellationToken)
        {
            string prefix = GetKeyPrefix();
            string basePath = new DirectoryInfo(this._request.Directory).FullName;

            _logger.DebugFormat("UploadDirectoryCommand starting. BasePath={0}, Prefix={1}, UploadFilesConcurrently={2}, ConcurrentServiceRequests={3}",
                basePath, prefix, UploadFilesConcurrently, this._config.ConcurrentServiceRequests);

            string[] filePaths = await GetFiles(basePath, this._request.SearchPattern, this._request.SearchOption, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            this._totalNumberOfFiles = filePaths.Length;

            _logger.DebugFormat("Discovered {0} file(s) to upload. TotalBytes={1}", _totalNumberOfFiles, _totalBytes);

            // Two-level throttling architecture:
            // 1. File-level throttler: Controls how many files are uploaded concurrently
            // 2. HTTP-level throttler: Controls total HTTP requests across ALL file uploads
            //
            // Example with ConcurrentServiceRequests = 10:
            //   - fileOperationThrottler = 10: Up to 10 files can upload simultaneously
            //   - sharedHttpRequestThrottler = 10: All 10 files share 10 total HTTP request slots
            //   - Without HTTP throttler: Would result in 10 files × 10 parts = 100 concurrent HTTP requests
            //   - With HTTP throttler: Enforces 10 total concurrent HTTP requests across all files
            //
            // This prevents resource exhaustion when uploading many large files with multipart uploads.
            SemaphoreSlim sharedHttpRequestThrottler = null;
            SemaphoreSlim fileOperationThrottler = null;
            CancellationTokenSource internalCts = null;
            try
            {
                var pendingTasks = new List<Task>();

                // File-level throttler: Controls concurrent file operations
                fileOperationThrottler = UploadFilesConcurrently ?
                    new SemaphoreSlim(this._config.ConcurrentServiceRequests) :
                    new SemaphoreSlim(1);
                _logger.DebugFormat("Created fileOperationThrottler with initial count={0}", UploadFilesConcurrently ? this._config.ConcurrentServiceRequests : 1);

                // HTTP-level throttler: Shared across all uploads to control total HTTP concurrency
                sharedHttpRequestThrottler = this._utility.S3Client is Amazon.S3.Internal.IAmazonS3Encryption ?
                    // If we are using AmazonS3EncryptionClient, don't set the HTTP throttler.
                    // The fileOperationThrottler will be used to control how many files are uploaded in parallel.
                    // Each upload (multipart) will upload parts serially.
                    null :
                    // Use a throttler which will be shared between simple and multipart uploads
                    // to control total concurrent HTTP requests across all file operations.
                    new SemaphoreSlim(this._config.ConcurrentServiceRequests);
                if (sharedHttpRequestThrottler == null)
                {
                    _logger.Debug(null, "sharedHttpRequestThrottler disabled due to encryption client. Multipart uploads will be serial per file.");
                }
                else
                {
                    _logger.DebugFormat("Created sharedHttpRequestThrottler with initial count={0}", this._config.ConcurrentServiceRequests);
                }

                internalCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);

                foreach (string filepath in filePaths)
                {
                    _logger.DebugFormat("Waiting for fileOperationThrottler to schedule file.");
                    await fileOperationThrottler.WaitAsync(cancellationToken).ConfigureAwait(continueOnCapturedContext: false);
                    _logger.DebugFormat("Acquired fileOperationThrottler. Currently scheduled: {0}", pendingTasks.Count + 1);

                    try
                    {
                        cancellationToken.ThrowIfCancellationRequested();
                        if (internalCts.IsCancellationRequested)
                        {
                            // Operation cancelled as one of the upload requests failed with an exception,
                            // don't schedule any more upload tasks. 
                            // Don't throw an OperationCanceledException here as we want to process the 
                            // responses and throw the original exception.
                            _logger.Debug(null, "Internal cancellation requested; breaking out of scheduling loop.");
                            break;
                        }

                        var uploadRequest = ConstructRequest(basePath, filepath, prefix);

                        Action<Exception> onFailure = (ex) =>
                        {
                            this._request.OnRaiseObjectUploadFailedEvent(
                                new ObjectUploadFailedEventArgs(
                                    this._request,
                                    uploadRequest,
                                    ex));
                        };

                        var task = _failurePolicy.ExecuteAsync(
                            async () => {
                                _logger.DebugFormat("Starting upload command");
                                var command = _utility.GetUploadCommand(uploadRequest, sharedHttpRequestThrottler);
                                await command.ExecuteAsync(internalCts.Token)
                                    .ConfigureAwait(false);
                                var uploaded = Interlocked.Increment(ref _numberOfFilesSuccessfullyUploaded);
                                _logger.DebugFormat("Completed upload. FilesSuccessfullyUploaded={0}", uploaded);
                            },
                            onFailure,
                            internalCts
                        );

                        pendingTasks.Add(task);
                        _logger.DebugFormat("Scheduled upload task. PendingTasks=01}", pendingTasks.Count);
                    }
                    finally
                    {
                        fileOperationThrottler.Release();
                    }
                }

                _logger.DebugFormat("Awaiting completion of {0} scheduled task(s)", pendingTasks.Count);
                await TaskHelpers.WhenAllOrFirstExceptionAsync(pendingTasks, cancellationToken)
                    .ConfigureAwait(continueOnCapturedContext: false);
            }
            finally
            {
                internalCts.Dispose();
                fileOperationThrottler.Dispose();
                sharedHttpRequestThrottler?.Dispose();
                _logger.DebugFormat("UploadDirectoryCommand finished. FilesSuccessfullyUploaded={0}", _numberOfFilesSuccessfullyUploaded);
            }

            var response = new TransferUtilityUploadDirectoryResponse
            {
                ObjectsUploaded = _numberOfFilesSuccessfullyUploaded,
                ObjectsFailed = _errors.Count,
                Errors = _errors.ToList(),
                Result = _errors.Count == 0 ?
                    DirectoryResult.Success :
                    (_numberOfFilesSuccessfullyUploaded > 0 ?
                        DirectoryResult.PartialSuccess :
                        DirectoryResult.Failure)
            };

            _logger.DebugFormat("Response summary: Uploaded={0}, Failed={1}, Result={2}", response.ObjectsUploaded, response.ObjectsFailed, response.Result);
            return response;
        }

        private Task<string[]> GetFiles(string path, string searchPattern, SearchOption searchOption, CancellationToken cancellationToken)
        {
            return Task.Run(() =>
                { 
                    var filePaths = Directory.GetFiles(path, searchPattern, searchOption);
                    foreach (var filePath in filePaths)
                    {
                        _totalBytes += new FileInfo(filePath).Length;
                    }
                    return filePaths;
                }, cancellationToken);

        }
    }
}
