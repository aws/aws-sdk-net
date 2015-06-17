/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.S3.Transfer.Internal
{
    internal partial class MultipartUploadCommand : BaseCommand
    {
        public SemaphoreSlim AsyncThrottler { get; set; }

        public override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            var initRequest = ConstructInitiateMultipartUploadRequest();
            var initResponse = await _s3Client.InitiateMultipartUploadAsync(initRequest, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false);
            Logger.DebugFormat("Initiated upload: {0}", initResponse.UploadId);

            var pendingUploadPartTasks = new List<Task<UploadPartResponse>>();
            
            SemaphoreSlim localThrottler = null;
            CancellationTokenSource internalCts = null;
            try
            {
                Logger.DebugFormat("Queue up the UploadPartRequests to be executed");
                long filePosition = 0;
                for (int i = 1; filePosition < this._contentLength; i++)
                {
                    cancellationToken.ThrowIfCancellationRequested();

                    var uploadRequest = ConstructUploadPartRequest(i, filePosition, initResponse);
                    this._partsToUpload.Enqueue(uploadRequest);
                    filePosition += this._partSize;
                }

                this._totalNumberOfParts = this._partsToUpload.Count;

                Logger.DebugFormat("Scheduling the {0} UploadPartRequests in the queue", this._totalNumberOfParts);

                internalCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken);
                var concurrencyLevel = CalculateConcurrentServiceRequests();
                localThrottler = this.AsyncThrottler == null ?
                    // Use local throttler if global throttler is not set.
                    // Global throttler is not set if multipart upload was not called by upload directory command
                    // or if S3EncryptionClient is used and upload directory command doesn't the global throttler
                    // so that for each file, parts are serially uploaded CalculateConcurrencyLevel() will return 1.
                    new SemaphoreSlim(concurrencyLevel) :
                    // Use the global throttler that is shared by all concurrent file uploads.                              
                    this.AsyncThrottler;

                foreach (var uploadRequest in _partsToUpload)
                {
                    await localThrottler.WaitAsync(cancellationToken)
                        .ConfigureAwait(continueOnCapturedContext: false);

                    cancellationToken.ThrowIfCancellationRequested();
                    if (internalCts.IsCancellationRequested)
                    {
                        // Operation cancelled as one of the UploadParts requests failed with an exception,
                        // don't schedule any more UploadPart tasks.
                        // Don't throw an OperationCanceledException here as we want to process the 
                        // responses and throw the original exception.
                        break;
                    }

                    var task = UploadPartAsync(uploadRequest, internalCts, localThrottler);                    
                    pendingUploadPartTasks.Add(task);
                }

                Logger.DebugFormat("Waiting for upload part requests to complete. ({0})", initResponse.UploadId);
                _uploadResponses = await WhenAllOrFirstExceptionAsync(pendingUploadPartTasks, cancellationToken)
                    .ConfigureAwait(continueOnCapturedContext: false);

                Logger.DebugFormat("Beginning completing multipart. ({0})", initResponse.UploadId);
                var compRequest = ConstructCompleteMultipartUploadRequest(initResponse);
                await this._s3Client.CompleteMultipartUploadAsync(compRequest, cancellationToken)
                    .ConfigureAwait(continueOnCapturedContext: false);
                Logger.DebugFormat("Done completing multipart. ({0})", initResponse.UploadId);

            }
            catch (Exception e)
            {
                Logger.Error(e, "Exception while uploading. ({0})", initResponse.UploadId);
                // Can't do async invocation in the catch block, doing cleanup synchronously.
                Cleanup(initResponse.UploadId, pendingUploadPartTasks);
                throw;
            }
            finally
            {                
                if (internalCts!= null)                
                    internalCts.Dispose();
                
                if (localThrottler != null && localThrottler!=this.AsyncThrottler)
                    localThrottler.Dispose();

                if (this._fileTransporterRequest.InputStream != null && !this._fileTransporterRequest.IsSetFilePath() && this._fileTransporterRequest.AutoCloseStream)
                {
                    this._fileTransporterRequest.InputStream.Dispose();
                }
                if (Logger != null)
                {
                    Logger.Flush();
                }
            }
        }

        private async Task<UploadPartResponse> UploadPartAsync(UploadPartRequest uploadRequest, CancellationTokenSource internalCts, SemaphoreSlim asyncThrottler)
        {
            try
            {
                return await _s3Client.UploadPartAsync(uploadRequest, internalCts.Token)
                    .ConfigureAwait(continueOnCapturedContext: false);
            }
            catch (Exception exception)
            {
                if (!(exception is OperationCanceledException))
                {
                    // Cancel scheduling any more tasks
                    // Cancel other UploadPart requests running in parallel.
                    internalCts.Cancel();
                }
                throw;
            }
            finally
            {
                asyncThrottler.Release();
            }
        }       

        private void Cleanup(string uploadId, List<Task<UploadPartResponse>> tasks)
        {
            try
            {
                // Make sure all tasks complete (to completion/faulted/cancelled).
                Task.WaitAll(tasks.ToArray(), 5000); 
            }
            catch(Exception exception)
            {
                Logger.InfoFormat(
                    "A timeout occured while waiting for all upload part request to complete as part of aborting the multipart upload : {0}",
                    exception.Message);
            }
            AbortMultipartUpload(uploadId);
        }

        private void AbortMultipartUpload(string uploadId)
        {
            try
            {
                this._s3Client.AbortMultipartUploadAsync(new AbortMultipartUploadRequest()
                {
                    BucketName = this._fileTransporterRequest.BucketName,
                    Key = this._fileTransporterRequest.Key,
                    UploadId = uploadId
                }).Wait();
            }
            catch (Exception e)
            {
                Logger.InfoFormat("Error attempting to abort multipart for key {0}: {1}", this._fileTransporterRequest.Key, e.Message);
            }
        }
    }
}
