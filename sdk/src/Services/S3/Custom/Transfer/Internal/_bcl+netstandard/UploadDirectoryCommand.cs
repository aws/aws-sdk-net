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
            try
            {
                // Step 1: Setup paths and discover files
                string prefix = GetKeyPrefix();
                string basePath = new DirectoryInfo(this._request.Directory).FullName;

                _logger.DebugFormat("UploadDirectoryCommand.ExecuteAsync: Starting - BasePath={0}, Prefix={1}, UploadFilesConcurrently={2}, ConcurrentServiceRequests={3}",
                    basePath, prefix, UploadFilesConcurrently, this._config.ConcurrentServiceRequests);

                // Step 2: Discover files to upload
                string[] filePaths = await DiscoverFilesAsync(basePath, cancellationToken)
                    .ConfigureAwait(false);

                this._totalNumberOfFiles = filePaths.Length;
                _logger.DebugFormat("UploadDirectoryCommand.ExecuteAsync: Discovered {0} file(s) to upload. TotalBytes={1}",
                    _totalNumberOfFiles, _totalBytes);

                FireTransferInitiatedEvent();


                // Step 3: Setup resources and execute uploads
                using (var resources = CreateUploadResources(cancellationToken))
                {
                    await ExecuteParallelUploadsAsync(
                        filePaths,
                        basePath,
                        prefix,
                        resources,
                        cancellationToken)
                    .ConfigureAwait(false);
                }

                // Step 4: Build and return response
                _logger.DebugFormat("UploadDirectoryCommand.ExecuteAsync: Completed - FilesSuccessfullyUploaded={0}, FilesFailed={1}",
                    _numberOfFilesSuccessfullyUploaded, _errors.Count);

                var response = BuildResponse();
                FireTransferCompletedEvent(response);
                return response;
            }
            catch
            {
                FireTransferFailedEvent();
                throw;
            }
        }

        /// <summary>
        /// Encapsulates disposable resources used during directory upload.
        /// </summary>
        private sealed class UploadResources : IDisposable
        {
            public SemaphoreSlim HttpRequestThrottler { get; }
            public CancellationTokenSource InternalCancellationTokenSource { get; }

            public UploadResources(
                SemaphoreSlim httpRequestThrottler,
                CancellationTokenSource cancellationTokenSource)
            {
                HttpRequestThrottler = httpRequestThrottler;
                InternalCancellationTokenSource = cancellationTokenSource;
            }

            public void Dispose()
            {
                InternalCancellationTokenSource?.Dispose();
                HttpRequestThrottler?.Dispose();
            }
        }

        /// <summary>
        /// Discovers files to upload from the local directory and calculates total bytes.
        /// </summary>
        private async Task<string[]> DiscoverFilesAsync(string basePath, CancellationToken cancellationToken)
        {
            return await Task.Run(() =>
            {
                var filePaths = Directory.GetFiles(
                    basePath,
                    this._request.SearchPattern,
                    this._request.SearchOption);

                foreach (var filePath in filePaths)
                {
                    _totalBytes += new FileInfo(filePath).Length;
                }

                return filePaths;
            }, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates resources needed for parallel uploads with proper throttling.
        /// 
        /// Throttling architecture:
        /// - Task pool pattern (ForEachWithConcurrencyAsync): Controls concurrent file uploads
        /// - HttpRequestThrottler: Controls total HTTP requests across ALL file uploads
        ///
        /// Example with ConcurrentServiceRequests = 10:
        ///   - Task pool creates max 10 concurrent file upload tasks
        ///   - HttpRequestThrottler = 10: All files share 10 total HTTP request slots
        ///   - Without HTTP throttler: 10 multipart files × 10 parts = 100 concurrent HTTP requests
        ///   - With HTTP throttler: Enforces 10 total concurrent HTTP requests across all files
        ///
        /// Special case: When using AmazonS3EncryptionClient, HTTP throttler is disabled.
        /// The task pool concurrency control is sufficient since encryption uploads are serial per file.
        /// </summary>
        private UploadResources CreateUploadResources(CancellationToken cancellationToken)
        {
            SemaphoreSlim httpRequestThrottler = null;

            // HTTP-level throttler: Shared across all uploads to control total HTTP concurrency
            // Disabled for encryption client since each upload processes parts serially
            if (this._utility.S3Client is Amazon.S3.Internal.IAmazonS3Encryption)
            {
                _logger.DebugFormat("UploadDirectoryCommand.CreateUploadResources: HTTP throttler disabled for encryption client. Multipart uploads will be serial per file.");
            }
            else
            {
                httpRequestThrottler = new SemaphoreSlim(this._config.ConcurrentServiceRequests);
                _logger.DebugFormat("UploadDirectoryCommand.CreateUploadResources: Created HTTP throttler with MaxConcurrentRequests={0}",
                    this._config.ConcurrentServiceRequests);
            }

            var internalCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);

            return new UploadResources(httpRequestThrottler, internalCts);
        }

        /// <summary>
        /// Executes parallel uploads of all files using task pool pattern.
        /// Only creates as many tasks as the concurrency limit allows (not all files up front).
        /// </summary>
        private async Task ExecuteParallelUploadsAsync(
            string[] filePaths,
            string basePath,
            string prefix,
            UploadResources resources,
            CancellationToken cancellationToken)
        {
            int concurrencyLevel = UploadFilesConcurrently
                ? this._config.ConcurrentServiceRequests
                : 1;

            _logger.DebugFormat("UploadDirectoryCommand.ExecuteParallelUploadsAsync: Starting task pool with ConcurrencyLevel={0}, TotalFiles={1}",
                concurrencyLevel, filePaths.Length);

            await TaskHelpers.ForEachWithConcurrencyAsync(
                filePaths,
                concurrencyLevel,
                async (filepath, ct) =>
                {
                    ct.ThrowIfCancellationRequested();

                    await UploadSingleFileAsync(
                        filepath,
                        basePath,
                        prefix,
                        resources.HttpRequestThrottler,
                        resources.InternalCancellationTokenSource)
                    .ConfigureAwait(false);
                },
                cancellationToken)
            .ConfigureAwait(false);

            _logger.DebugFormat("UploadDirectoryCommand.ExecuteParallelUploadsAsync: Task pool completed - FilesSuccessfullyUploaded={0}, FilesFailed={1}",
                _numberOfFilesSuccessfullyUploaded, _errors.Count);
        }

        /// <summary>
        /// Uploads a single file to S3 with failure handling.
        /// </summary>
        private async Task UploadSingleFileAsync(
            string filepath,
            string basePath,
            string prefix,
            SemaphoreSlim httpRequestThrottler,
            CancellationTokenSource internalCts)
        {
            if (internalCts.IsCancellationRequested)
                return;

            var uploadRequest = ConstructRequest(basePath, filepath, prefix);

            // Create failure callback
            Action<Exception> onFailure = (ex) =>
            {
                this._request.OnRaiseObjectUploadFailedEvent(
                    new ObjectUploadFailedEventArgs(
                        this._request,
                        uploadRequest,
                        ex));
            };

            // Execute upload with failure policy
            await _failurePolicy.ExecuteAsync(
                () => ExecuteUploadCommandAsync(uploadRequest, httpRequestThrottler, internalCts.Token),
                onFailure,
                internalCts
            ).ConfigureAwait(false);
        }

        /// <summary>
        /// Creates and executes the appropriate upload command for the file.
        /// </summary>
        private async Task ExecuteUploadCommandAsync(
            TransferUtilityUploadRequest uploadRequest,
            SemaphoreSlim httpRequestThrottler,
            CancellationToken cancellationToken)
        {
            _logger.DebugFormat("UploadDirectoryCommand.ExecuteUploadCommandAsync: Starting upload command");

            var command = _utility.GetUploadCommand(uploadRequest, httpRequestThrottler);
            await command.ExecuteAsync(cancellationToken).ConfigureAwait(false);

            var uploaded = Interlocked.Increment(ref _numberOfFilesSuccessfullyUploaded);
            _logger.DebugFormat("UploadDirectoryCommand.ExecuteUploadCommandAsync: Completed upload. FilesSuccessfullyUploaded={0}", uploaded);
        }

        /// <summary>
        /// Builds the response object based on upload results.
        /// </summary>
        private TransferUtilityUploadDirectoryResponse BuildResponse()
        {
            var response = new TransferUtilityUploadDirectoryResponse
            {
                ObjectsUploaded = _numberOfFilesSuccessfullyUploaded,
                ObjectsFailed = _errors.Count,
                Errors = _errors.ToList(),
                Result = _errors.Count == 0
                    ? DirectoryResult.Success
                    : (_numberOfFilesSuccessfullyUploaded > 0
                        ? DirectoryResult.PartialSuccess
                        : DirectoryResult.Failure)
            };

            _logger.DebugFormat("UploadDirectoryCommand.BuildResponse: Uploaded={0}, Failed={1}, Result={2}",
                response.ObjectsUploaded, response.ObjectsFailed, response.Result);

            return response;
        }
    }
}
