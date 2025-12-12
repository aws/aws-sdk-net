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
using Amazon.S3.Util;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;
using Amazon.Util.Internal;

namespace Amazon.S3.Transfer.Internal
{
    internal partial class DownloadDirectoryCommand : BaseCommand<TransferUtilityDownloadDirectoryResponse>
    {
        TransferUtilityConfig _config;

        public bool DownloadFilesConcurrently { get; set; }

        private readonly Logger _logger = Logger.GetLogger(typeof(DownloadDirectoryCommand));

        internal DownloadDirectoryCommand(IAmazonS3 s3Client, TransferUtilityDownloadDirectoryRequest request, TransferUtilityConfig config)
        : this(s3Client, request, config, useMultipartDownload: false)
        {
        }


        public override async Task<TransferUtilityDownloadDirectoryResponse> ExecuteAsync(CancellationToken cancellationToken)
        {
            try
            {
                FireTransferInitiatedEvent();

                _logger.DebugFormat("DownloadDirectoryCommand.ExecuteAsync: Starting - DownloadFilesConcurrently={0}, UseMultipartDownload={1}, ConcurrentServiceRequests={2}",
                    DownloadFilesConcurrently, this._useMultipartDownload, this._config.ConcurrentServiceRequests);

                // Step 1: Validate and setup
                ValidateRequest();
                EnsureDirectoryExists(new DirectoryInfo(this._request.LocalDirectory));

                // Step 2: List S3 objects
                var (s3Objects, prefixLength) = await ListS3ObjectsAsync(cancellationToken)
                    .ConfigureAwait(false);

                this._totalNumberOfFilesToDownload = s3Objects.Count;
                _logger.DebugFormat("DownloadDirectoryCommand.ExecuteAsync: Found {0} total objects, TotalBytes={1}",
                    s3Objects.Count, this._totalBytes);

                // Step 3: Filter to actual files (exclude directory markers)
                var objectsToDownload = FilterObjectsToDownload(s3Objects);

                // Step 4: Setup resources and execute downloads
                using (var resources = CreateDownloadResources(cancellationToken))
                {
                    await ExecuteParallelDownloadsAsync(
                        objectsToDownload,
                        prefixLength,
                        resources,
                        cancellationToken)
                    .ConfigureAwait(false);
                }

                // Step 5: Build response
                _logger.DebugFormat("DownloadDirectoryCommand.ExecuteAsync: Completed - ObjectsDownloaded={0}, ObjectsFailed={1}",
                    _numberOfFilesDownloaded, _errors.Count);

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
        /// Encapsulates disposable resources used during directory download.
        /// </summary>
        private sealed class DownloadResources : IDisposable
        {
            public SemaphoreSlim HttpRequestThrottler { get; }
            public CancellationTokenSource InternalCancellationTokenSource { get; }

            public DownloadResources(
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
        /// Lists S3 objects to download and calculates prefix length.
        /// </summary>
        private async Task<(List<S3Object> objects, int prefixLength)> ListS3ObjectsAsync(
            CancellationToken cancellationToken)
        {
            List<S3Object> objs;
            string listRequestPrefix;

            try
            {
                var listRequest = ConstructListObjectRequest();
                listRequestPrefix = listRequest.Prefix;
                objs = await GetS3ObjectsToDownloadAsync(listRequest, cancellationToken)
                    .ConfigureAwait(false);
            }
            catch (AmazonS3Exception ex) when (ex.StatusCode == System.Net.HttpStatusCode.NotImplemented)
            {
                var listRequestV2 = ConstructListObjectRequestV2();
                listRequestPrefix = listRequestV2.Prefix;
                objs = await GetS3ObjectsToDownloadV2Async(listRequestV2, cancellationToken)
                    .ConfigureAwait(false);
            }

            // Calculate prefix length
            int prefixLength = listRequestPrefix.Length;
            if (_request.DisableSlashCorrection && !listRequestPrefix.EndsWith("/"))
            {
                prefixLength = listRequestPrefix.LastIndexOf("/") + 1;
            }

            return (objs, prefixLength);
        }

        /// <summary>
        /// Filters out directory markers (keys ending with "/") from S3 objects list.
        /// </summary>
        private List<S3Object> FilterObjectsToDownload(List<S3Object> s3Objects)
        {
            var filtered = s3Objects
                .Where(s3o => !s3o.Key.EndsWith("/", StringComparison.Ordinal))
                .ToList();

            _logger.DebugFormat("DownloadDirectoryCommand.FilterObjectsToDownload: Filtered to {0} files to download (excluded {1} directory markers)",
                filtered.Count, s3Objects.Count - filtered.Count);

            return filtered;
        }

        /// <summary>
        /// Creates resources needed for parallel downloads with proper throttling.
        /// Throttling architecture:
        /// - Task pool pattern (ForEachWithConcurrencyAsync): Controls concurrent file downloads
        /// - HttpRequestThrottler: Controls total HTTP requests across ALL file downloads
        ///
        /// Example with ConcurrentServiceRequests = 10:
        ///   - Task pool creates max 10 concurrent file download tasks
        ///   - HttpRequestThrottler = 10: All files share 10 total HTTP request slots
        ///   - Without HTTP throttler: 10 multipart files × 10 parts = 100 concurrent HTTP requests
        ///   - With HTTP throttler: Enforces 10 total concurrent HTTP requests across all files
        ///
        /// This prevents resource exhaustion when downloading many large files with multipart downloads.
        /// </summary>
        private DownloadResources CreateDownloadResources(CancellationToken cancellationToken)
        {
            SemaphoreSlim httpRequestThrottler = null;

            // HTTP-level throttler: Shared across all downloads to control total HTTP concurrency
            // Only needed for multipart downloads where each file makes multiple HTTP requests
            if (this._useMultipartDownload)
            {
                httpRequestThrottler = new SemaphoreSlim(this._config.ConcurrentServiceRequests);
                _logger.DebugFormat("DownloadDirectoryCommand.CreateDownloadResources: Created HTTP throttler with MaxConcurrentRequests={0}",
                    this._config.ConcurrentServiceRequests);
            }

            var internalCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);

            return new DownloadResources(httpRequestThrottler, internalCts);
        }

        /// <summary>
        /// Executes parallel downloads of all S3 objects using task pool pattern.
        /// Only creates as many tasks as the concurrency limit allows (not all files up front).
        /// </summary>
        private async Task ExecuteParallelDownloadsAsync(
            List<S3Object> objectsToDownload,
            int prefixLength,
            DownloadResources resources,
            CancellationToken cancellationToken)
        {
            int concurrencyLevel = DownloadFilesConcurrently
                ? this._config.ConcurrentServiceRequests
                : 1;

            _logger.DebugFormat("DownloadDirectoryCommand.ExecuteParallelDownloadsAsync: Starting task pool with ConcurrencyLevel={0}, TotalFiles={1}",
                concurrencyLevel, objectsToDownload.Count);

            await TaskHelpers.ForEachWithConcurrencyAsync(
                objectsToDownload,
                concurrencyLevel,
                async (s3Object, ct) =>
                {
                    ct.ThrowIfCancellationRequested();

                    await DownloadSingleFileAsync(
                        s3Object,
                        prefixLength,
                        resources.HttpRequestThrottler,
                        resources.InternalCancellationTokenSource)
                    .ConfigureAwait(false);
                },
                cancellationToken)
            .ConfigureAwait(false);

            _logger.DebugFormat("DownloadDirectoryCommand.ExecuteParallelDownloadsAsync: Task pool completed - ObjectsDownloaded={0}, ObjectsFailed={1}",
                _numberOfFilesDownloaded, _errors.Count);
        }

        /// <summary>
        /// Downloads a single S3 object to local file system with validation and failure handling.
        /// </summary>
        private async Task DownloadSingleFileAsync(
            S3Object s3Object,
            int prefixLength,
            SemaphoreSlim httpRequestThrottler,
            CancellationTokenSource internalCts)
        {
            if (internalCts.IsCancellationRequested)
                return;

            this._currentFile = s3Object.Key.Substring(prefixLength);
            var downloadRequest = ConstructTransferUtilityDownloadRequest(s3Object, prefixLength);

            // Create failure callback
            Action<Exception> onFailure = (ex) =>
            {
                this._request.OnRaiseObjectDownloadFailedEvent(
                    new ObjectDownloadFailedEventArgs(
                        this._request,
                        downloadRequest,
                        ex));
            };

            // Validate file path with failure policy
            var isValid = await _failurePolicy.ExecuteAsync(
                () => ValidateDownloadPath(downloadRequest.FilePath),
                onFailure,
                internalCts
            ).ConfigureAwait(false);

            if (!isValid)
                return;

            // Execute download with failure policy
            await _failurePolicy.ExecuteAsync(
                () => ExecuteDownloadCommandAsync(downloadRequest, httpRequestThrottler, internalCts.Token),
                onFailure,
                internalCts
            ).ConfigureAwait(false);
        }

        /// <summary>
        /// Validates that the download path is within the target directory.
        /// </summary>
        private Task ValidateDownloadPath(string filePath)
        {
            if (!InternalSDKUtils.IsFilePathRootedWithDirectoryPath(filePath, _request.LocalDirectory))
            {
                throw new AmazonClientException(
                    $"The file {filePath} is not allowed outside of the target directory {_request.LocalDirectory}.");
            }
            return Task.CompletedTask;
        }

        /// <summary>
        /// Creates and executes the appropriate download command for the file.
        /// </summary>
        private async Task ExecuteDownloadCommandAsync(
            TransferUtilityDownloadRequest downloadRequest,
            SemaphoreSlim httpRequestThrottler,
            CancellationToken cancellationToken)
        {
            BaseCommand<TransferUtilityDownloadResponse> command;

            if (this._useMultipartDownload)
            {
                command = new MultipartDownloadCommand(
                    this._s3Client,
                    downloadRequest,
                    this._config,
                    httpRequestThrottler);
            }
            else
            {
                command = new DownloadCommand(this._s3Client, downloadRequest);
            }

            await command.ExecuteAsync(cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// Builds the response object based on download results.
        /// </summary>
        private TransferUtilityDownloadDirectoryResponse BuildResponse()
        {
            return new TransferUtilityDownloadDirectoryResponse
            {
                ObjectsDownloaded = _numberOfFilesDownloaded,
                ObjectsFailed = _errors.Count,
                Errors = _errors.ToList(),
                Result = _errors.Count == 0
                    ? DirectoryResult.Success
                    : (_numberOfFilesDownloaded > 0
                        ? DirectoryResult.PartialSuccess
                        : DirectoryResult.Failure)
            };
        }


        private async Task<List<S3Object>> GetS3ObjectsToDownloadAsync(ListObjectsRequest listRequest, CancellationToken cancellationToken)
        {
            _logger.DebugFormat("DownloadDirectoryCommand.GetS3ObjectsToDownloadAsync: Starting object listing");
            
            List<S3Object> objs = new List<S3Object>();
            int pageCount = 0;
            do
            {
                ListObjectsResponse listResponse = await this._s3Client.ListObjectsAsync(listRequest, cancellationToken)
                    .ConfigureAwait(continueOnCapturedContext: false);

                if (listResponse.S3Objects != null) 
                {
                    foreach (S3Object s3o in listResponse.S3Objects)
                    {
                        if (ShouldDownload(s3o))
                        {
                            this._totalBytes += s3o.Size.GetValueOrDefault();
                            objs.Add(s3o);
                        }
                    }
                }
                listRequest.Marker = listResponse.NextMarker;
                pageCount++;
                
                _logger.DebugFormat("DownloadDirectoryCommand.GetS3ObjectsToDownloadAsync: Page {0} completed - ObjectsInPage={1}, TotalObjectsSoFar={2}",
                    pageCount, listResponse.S3Objects?.Count ?? 0, objs.Count);
            } while (!string.IsNullOrEmpty(listRequest.Marker));
            
            _logger.DebugFormat("DownloadDirectoryCommand.GetS3ObjectsToDownloadAsync: Listing completed - TotalPages={0}, TotalObjects={1}",
                pageCount, objs.Count);
            
            return objs;
        }

        private async Task<List<S3Object>> GetS3ObjectsToDownloadV2Async(ListObjectsV2Request listRequestV2, CancellationToken cancellationToken)
        {
            _logger.DebugFormat("DownloadDirectoryCommand.GetS3ObjectsToDownloadV2Async: Starting object listing (V2 API)");
            
            List<S3Object> objs = new List<S3Object>();
            int pageCount = 0;
            do
            {
                ListObjectsV2Response listResponse = await this._s3Client.ListObjectsV2Async(listRequestV2, cancellationToken)
                    .ConfigureAwait(continueOnCapturedContext: false);

                if (listResponse.S3Objects != null)
                {
                    foreach (S3Object s3o in listResponse.S3Objects)
                    {
                        if (ShouldDownload(s3o))
                        {
                            this._totalBytes += s3o.Size.GetValueOrDefault();
                            objs.Add(s3o);
                        }
                    }
                }
                listRequestV2.ContinuationToken = listResponse.NextContinuationToken;
                pageCount++;
                
                _logger.DebugFormat("DownloadDirectoryCommand.GetS3ObjectsToDownloadV2Async: Page {0} completed - ObjectsInPage={1}, TotalObjectsSoFar={2}",
                    pageCount, listResponse.S3Objects?.Count ?? 0, objs.Count);
            } while (!string.IsNullOrEmpty(listRequestV2.ContinuationToken));
            
            _logger.DebugFormat("DownloadDirectoryCommand.GetS3ObjectsToDownloadV2Async: Listing completed - TotalPages={0}, TotalObjects={1}",
                pageCount, objs.Count);
            
            return objs;
        }
    }
}
