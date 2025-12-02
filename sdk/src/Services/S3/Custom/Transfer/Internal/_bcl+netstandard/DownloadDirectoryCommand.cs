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

        private Logger Logger
        {
            get { return Logger.GetLogger(typeof(DownloadDirectoryCommand)); }
        }

        internal DownloadDirectoryCommand(IAmazonS3 s3Client, TransferUtilityDownloadDirectoryRequest request, TransferUtilityConfig config)
        : this(s3Client, request, config, useMultipartDownload: false)
        {
        }


        public override async Task<TransferUtilityDownloadDirectoryResponse> ExecuteAsync(CancellationToken cancellationToken)
        {
            Logger.DebugFormat("DownloadDirectoryCommand.ExecuteAsync: Starting - DownloadFilesConcurrently={0}, UseMultipartDownload={1}, ConcurrentServiceRequests={2}",
                DownloadFilesConcurrently, this._useMultipartDownload, this._config.ConcurrentServiceRequests);

            ValidateRequest();
            EnsureDirectoryExists(new DirectoryInfo(this._request.LocalDirectory));

            List<S3Object> objs;
            string listRequestPrefix;
            try
            {
                ListObjectsRequest listRequest = ConstructListObjectRequest();
                listRequestPrefix = listRequest.Prefix;
                objs = await GetS3ObjectsToDownloadAsync(listRequest, cancellationToken).ConfigureAwait(false);
            }
            catch (AmazonS3Exception ex)
            {
                if (ex.StatusCode != System.Net.HttpStatusCode.NotImplemented)
                    throw;

                ListObjectsV2Request listRequestV2 = ConstructListObjectRequestV2();
                listRequestPrefix = listRequestV2.Prefix;
                objs = await GetS3ObjectsToDownloadV2Async(listRequestV2, cancellationToken).ConfigureAwait(false);
            }

            this._totalNumberOfFilesToDownload = objs.Count;
            
            Logger.DebugFormat("DownloadDirectoryCommand.ExecuteAsync: Found {0} total objects, TotalBytes={1}",
                objs.Count, this._totalBytes);

            // Throttling architecture:
            // - Task pool pattern (ForEachWithConcurrencyAsync): Controls concurrent file downloads
            // - sharedHttpRequestThrottler: Controls total HTTP requests across ALL file downloads
            //
            // Example with ConcurrentServiceRequests = 10:
            //   - Task pool creates max 10 concurrent file download tasks
            //   - sharedHttpRequestThrottler = 10: All files share 10 total HTTP request slots
            //   - Without HTTP throttler: 10 multipart files × 10 parts = 100 concurrent HTTP requests
            //   - With HTTP throttler: Enforces 10 total concurrent HTTP requests across all files
            //
            // This prevents resource exhaustion when downloading many large files with multipart downloads.
            SemaphoreSlim sharedHttpRequestThrottler = null;
            CancellationTokenSource internalCts = null;

            try
            {
                // HTTP-level throttler: Shared across all downloads to control total HTTP concurrency
                // Only needed for multipart downloads where each file makes multiple HTTP requests
                if (this._useMultipartDownload)
                {
                    sharedHttpRequestThrottler = new SemaphoreSlim(this._config.ConcurrentServiceRequests);
                    Logger.DebugFormat("DownloadDirectoryCommand.ExecuteAsync: Created HTTP throttler with MaxConcurrentRequests={0}",
                        this._config.ConcurrentServiceRequests);
                }

                internalCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
                
                // Calculate prefix length once for all downloads
                int prefixLength = listRequestPrefix.Length;
                if (_request.DisableSlashCorrection && !listRequestPrefix.EndsWith("/"))
                {
                    prefixLength = listRequestPrefix.LastIndexOf("/") + 1;
                }

                // Filter out directory markers (keys ending with "/")
                var objectsToDownload = objs.Where(s3o => !s3o.Key.EndsWith("/", StringComparison.Ordinal)).ToList();

                Logger.DebugFormat("DownloadDirectoryCommand.ExecuteAsync: Filtered to {0} files to download (excluded {1} directory markers)",
                    objectsToDownload.Count, objs.Count - objectsToDownload.Count);

                // Determine concurrency level based on DownloadFilesConcurrently setting
                int concurrencyLevel = DownloadFilesConcurrently ? 
                    this._config.ConcurrentServiceRequests : 
                    1;

                Logger.DebugFormat("DownloadDirectoryCommand.ExecuteAsync: Starting task pool with ConcurrencyLevel={0}, TotalFiles={1}",
                    concurrencyLevel, objectsToDownload.Count);

                // Use task pool pattern to limit concurrent task creation
                // Only creates as many tasks as the concurrency limit allows (not all x number of files in directory up front)
                await TaskHelpers.ForEachWithConcurrencyAsync(
                    objectsToDownload,
                    concurrencyLevel,
                    async (s3Object, ct) =>
                    {
                        ct.ThrowIfCancellationRequested();
                        if (internalCts.IsCancellationRequested)
                        {
                            return;
                        }

                        this._currentFile = s3Object.Key.Substring(prefixLength);
                        TransferUtilityDownloadRequest downloadRequest = ConstructTransferUtilityDownloadRequest(s3Object, prefixLength);

                        // Create failure callback that has access to downloadRequest
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
                            () =>
                            {
                                if (!InternalSDKUtils.IsFilePathRootedWithDirectoryPath(downloadRequest.FilePath, _request.LocalDirectory))
                                {
                                    throw new AmazonClientException($"The file {downloadRequest.FilePath} is not allowed outside of the target directory {_request.LocalDirectory}.");
                                }
                                return Task.CompletedTask;
                            },
                            onFailure,
                            internalCts
                        ).ConfigureAwait(false);

                        if (!isValid) return;

                        // Execute download with failure policy
                        await _failurePolicy.ExecuteAsync(
                            async () =>
                            {
                                BaseCommand<TransferUtilityDownloadResponse> command;
                                if (this._useMultipartDownload)
                                {
                                    command = new MultipartDownloadCommand(this._s3Client, downloadRequest, this._config, sharedHttpRequestThrottler);
                                }
                                else
                                {
                                    command = new DownloadCommand(this._s3Client, downloadRequest);
                                }
                                await command.ExecuteAsync(internalCts.Token)
                                    .ConfigureAwait(false);
                            },
                            onFailure,
                            internalCts
                        ).ConfigureAwait(false);
                    },
                    cancellationToken)
                    .ConfigureAwait(continueOnCapturedContext: false);

                Logger.DebugFormat("DownloadDirectoryCommand.ExecuteAsync: Task pool completed - ObjectsDownloaded={0}, ObjectsFailed={1}",
                    _numberOfFilesDownloaded, _errors.Count);

                return new TransferUtilityDownloadDirectoryResponse
                {
                    ObjectsDownloaded = _numberOfFilesDownloaded,
                    ObjectsFailed = _errors.Count,
                    Errors = _errors.ToList(),
                    Result = _errors.Count == 0 ?
                        DirectoryResult.Success :
                        (_numberOfFilesDownloaded > 0 ?
                            DirectoryResult.PartialSuccess :
                            DirectoryResult.Failure)
                };
            }
            finally
            {
                internalCts?.Dispose();
                sharedHttpRequestThrottler?.Dispose();
            }
        }


        private async Task<List<S3Object>> GetS3ObjectsToDownloadAsync(ListObjectsRequest listRequest, CancellationToken cancellationToken)
        {
            Logger.DebugFormat("DownloadDirectoryCommand.GetS3ObjectsToDownloadAsync: Starting object listing");
            
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
                
                Logger.DebugFormat("DownloadDirectoryCommand.GetS3ObjectsToDownloadAsync: Page {0} completed - ObjectsInPage={1}, TotalObjectsSoFar={2}",
                    pageCount, listResponse.S3Objects?.Count ?? 0, objs.Count);
            } while (!string.IsNullOrEmpty(listRequest.Marker));
            
            Logger.DebugFormat("DownloadDirectoryCommand.GetS3ObjectsToDownloadAsync: Listing completed - TotalPages={0}, TotalObjects={1}",
                pageCount, objs.Count);
            
            return objs;
        }

        private async Task<List<S3Object>> GetS3ObjectsToDownloadV2Async(ListObjectsV2Request listRequestV2, CancellationToken cancellationToken)
        {
            Logger.DebugFormat("DownloadDirectoryCommand.GetS3ObjectsToDownloadV2Async: Starting object listing (V2 API)");
            
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
                
                Logger.DebugFormat("DownloadDirectoryCommand.GetS3ObjectsToDownloadV2Async: Page {0} completed - ObjectsInPage={1}, TotalObjectsSoFar={2}",
                    pageCount, listResponse.S3Objects?.Count ?? 0, objs.Count);
            } while (!string.IsNullOrEmpty(listRequestV2.ContinuationToken));
            
            Logger.DebugFormat("DownloadDirectoryCommand.GetS3ObjectsToDownloadV2Async: Listing completed - TotalPages={0}, TotalObjects={1}",
                pageCount, objs.Count);
            
            return objs;
        }
    }
}
