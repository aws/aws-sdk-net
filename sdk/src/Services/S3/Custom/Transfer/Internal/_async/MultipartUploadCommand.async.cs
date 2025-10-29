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

using Amazon.Runtime;
using Amazon.S3.Model;
using Amazon.S3.Util;
using Amazon.Util;
using Amazon.Runtime.Internal.UserAgent;
using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Buffers;

namespace Amazon.S3.Transfer.Internal
{
    internal partial class MultipartUploadCommand : BaseCommand<TransferUtilityUploadResponse>
    {
        public SemaphoreSlim AsyncThrottler { get; set; }

        Dictionary<int, ExpectedUploadPart> _expectedUploadParts = new Dictionary<int, ExpectedUploadPart>();

        public override async Task<TransferUtilityUploadResponse> ExecuteAsync(CancellationToken cancellationToken)
        {
            // Fire transfer initiated event FIRST, before choosing path
            FireTransferInitiatedEvent();

            if ( (this._fileTransporterRequest.InputStream != null && !this._fileTransporterRequest.InputStream.CanSeek) || this._fileTransporterRequest.ContentLength == -1)
            {
                return await UploadUnseekableStreamAsync(this._fileTransporterRequest, cancellationToken).ConfigureAwait(false);
            }
            else
            {
                InitiateMultipartUploadResponse initResponse = null;
                try
                {
                    var initRequest = ConstructInitiateMultipartUploadRequest();
                    initResponse = await _s3Client.InitiateMultipartUploadAsync(initRequest, cancellationToken)
                    .ConfigureAwait(continueOnCapturedContext: false);
                    Logger.DebugFormat("Initiated upload: {0}", initResponse.UploadId);
                }
                catch (Exception)
                {
                    FireTransferFailedEvent();
                    throw;
                }

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

                        var expectedFileOffset = (i - 1) * this._partSize;
                        // Calculating how many bytes are remaining to be uploaded from the current part.
                        // This is mainly used for the last part scenario.
                        var remainingBytes = this._contentLength - expectedFileOffset;
                        // We then check based on the remaining bytes and the content length if this is the last part.
                        var isLastPart = calculateIsLastPart(remainingBytes);
                        // To maintain the same behavior as the ConstructUploadPartRequest.
                        // We are setting the remainingBytes/partSize when using the IAmazonS3Encryption client to 0.
                        if (isLastPart
                            && _s3Client is Amazon.S3.Internal.IAmazonS3Encryption)
                        {
                            remainingBytes = 0;
                        }
                        this._expectedUploadParts.Add(i, new ExpectedUploadPart {
                            PartNumber = i,
                            ExpectedContentLength =
                                isLastPart ?
                                    remainingBytes : 
                                    this._partSize,
                            ExpectedFileOffset = expectedFileOffset,
                            IsLastPart = isLastPart
                        });
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
                    var completeResponse = await this._s3Client.CompleteMultipartUploadAsync(compRequest, cancellationToken)
                        .ConfigureAwait(continueOnCapturedContext: false);
                    Logger.DebugFormat("Done completing multipart. ({0})", initResponse.UploadId);

                    var mappedResponse = ResponseMapper.MapCompleteMultipartUploadResponse(completeResponse);
                    FireTransferCompletedEvent(mappedResponse);
                    return mappedResponse;
                }
                catch (Exception e)
                {
                    Logger.Error(e, "Exception while uploading. ({0})", initResponse?.UploadId ?? "unknown");

                    FireTransferFailedEvent();
                    
                    // Can't do async invocation in the catch block, doing cleanup synchronously.
                    Cleanup(initResponse.UploadId, pendingUploadPartTasks);
                    throw;
                }
                finally
                {
                    if (internalCts != null)
                        internalCts.Dispose();

                    if (localThrottler != null && localThrottler != this.AsyncThrottler)
                        localThrottler.Dispose();

                    if (this._fileTransporterRequest.InputStream != null && !this._fileTransporterRequest.IsSetFilePath() && this._fileTransporterRequest.AutoCloseStream)
                    {
                        this._fileTransporterRequest.InputStream.Dispose();
                    }
                } 
            }
        }

        private async Task<UploadPartResponse> UploadPartAsync(UploadPartRequest uploadRequest, CancellationTokenSource internalCts, SemaphoreSlim asyncThrottler)
        {
            try
            {
                var response = await _s3Client.UploadPartAsync(uploadRequest, internalCts.Token)
                    .ConfigureAwait(continueOnCapturedContext: false);

                if (response.PartNumber is null)
                {
                    throw new ArgumentNullException(nameof(response.PartNumber));
                }
                else
                {
                    if (this._expectedUploadParts.TryGetValue((int) response.PartNumber, out var expectedUploadPart))
                    {
                        var actualContentLength = uploadRequest.PartSize;
                        if (actualContentLength != expectedUploadPart.ExpectedContentLength)
                        {
                            throw new InvalidOperationException($"Cannot complete multipart upload request. The expected content length of part {expectedUploadPart.PartNumber} " +
                                $"does not equal the actual content length.");
                        }

                        if (expectedUploadPart.IsLastPart)
                        {
                            if (actualContentLength < 0 ||
                                actualContentLength > expectedUploadPart.ExpectedContentLength)
                            {
                                throw new InvalidOperationException($"Cannot complete multipart upload request. The last part " +
                                    $"has an invalid content length.");
                            }
                        }

                        var actualFileOsset = uploadRequest.FilePosition;
                        if (uploadRequest.IsSetFilePath() && 
                            actualFileOsset != expectedUploadPart.ExpectedFileOffset)
                        {
                            throw new InvalidOperationException($"Cannot complete multipart upload request. The expected file offset of part {expectedUploadPart.PartNumber} " +
                                $"does not equal the actual file offset.");
                        }
                    }
                    else
                    {
                        throw new InvalidOperationException("Multipart upload request part was unexpected.");
                    }
                }


                return response;
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

        internal AbortMultipartUploadRequest ConstructAbortMultipartUploadRequest(string uploadId)
        {
            return new AbortMultipartUploadRequest()
            {
                BucketName = this._fileTransporterRequest.BucketName,
                ExpectedBucketOwner = this._fileTransporterRequest.ExpectedBucketOwner,
                Key = this._fileTransporterRequest.Key,
                RequestPayer = this._fileTransporterRequest.RequestPayer,
                UploadId = uploadId
            };
        }

        private void AbortMultipartUpload(string uploadId)
        {
            try
            {
                this._s3Client.AbortMultipartUploadAsync(ConstructAbortMultipartUploadRequest(uploadId)).Wait();
            }
            catch (Exception e)
            {
                Logger.InfoFormat("Error attempting to abort multipart for key {0}: {1}", this._fileTransporterRequest.Key, e.Message);
            }
        }
        private async Task<TransferUtilityUploadResponse> UploadUnseekableStreamAsync(TransferUtilityUploadRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();

            int READ_BUFFER_SIZE = this._s3Client.Config.BufferSize;

            RequestEventHandler requestEventHandler = (o, args) =>
            {
                WebServiceRequestEventArgs wsArgs = args as WebServiceRequestEventArgs;
                if (wsArgs != null)
                {
                    ((Runtime.Internal.IAmazonWebServiceRequest)wsArgs.Request).UserAgentDetails.AddFeature(UserAgentFeatureId.S3_TRANSFER);
                    ((Runtime.Internal.IAmazonWebServiceRequest)wsArgs.Request).UserAgentDetails.AddUserAgentComponent("md/UploadNonSeekableStream");
                }
            };

            InitiateMultipartUploadResponse initiateResponse = null;
            
            try
            {
                var initiateRequest = ConstructInitiateMultipartUploadRequest(requestEventHandler);
                initiateResponse = await _s3Client.InitiateMultipartUploadAsync(initiateRequest, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception ex)
            {
                FireTransferFailedEvent();
                Logger.Error(ex, "Failed to initiate multipart upload for unseekable stream");
                throw;
            }

            try
            {
                // if partSize is not specified on the request, the default value is 0
                long minPartSize = request?.PartSize != 0 ? request.PartSize : S3Constants.MinPartSize;
                var uploadPartResponses = new List<UploadPartResponse>();
                var readBuffer = ArrayPool<byte>.Shared.Rent(READ_BUFFER_SIZE);
                var partBuffer = ArrayPool<byte>.Shared.Rent((int)minPartSize + readBuffer.Length);
                
                MemoryStream nextUploadBuffer = new MemoryStream(partBuffer);
                using (var stream = request.InputStream)
                {
                    try
                    {
                        int partNumber = 1;
                        int readBytesCount, readAheadBytesCount = 0;

                        readBytesCount = await stream.ReadAsync(readBuffer, 0, readBuffer.Length, cancellationToken).ConfigureAwait(false);

                        do
                        {
                            await nextUploadBuffer.WriteAsync(readBuffer, 0, readBytesCount, cancellationToken).ConfigureAwait(false);
                            // read the stream ahead and process it in the next iteration.
                            // this is used to set isLastPart when there is no data left in the stream.
                            readAheadBytesCount = await stream.ReadAsync(readBuffer, 0, readBuffer.Length, cancellationToken).ConfigureAwait(false);
                            if ((nextUploadBuffer.Position > minPartSize || readAheadBytesCount == 0))
                            {
                                if (nextUploadBuffer.Position == 0)
                                {
                                    if (partNumber == 1)
                                    {
                                        // if the input stream is empty then upload empty MemoryStream.
                                        // without doing this the UploadPart call will use the length of the
                                        // nextUploadBuffer as the pastSize. The length will be incorrectly computed
                                        // for the part as (int)minPartSize + (READ_BUFFER_SIZE) as defined above for partBuffer.
                                        nextUploadBuffer.Dispose();
                                        nextUploadBuffer = new MemoryStream();
                                    }
                                }
                                bool isLastPart = readAheadBytesCount == 0;

                                var partSize = nextUploadBuffer.Position;
                                nextUploadBuffer.Position = 0;
                                UploadPartRequest uploadPartRequest = ConstructUploadPartRequestForNonSeekableStream(nextUploadBuffer, partNumber, partSize, isLastPart, initiateResponse);

                                var partResponse = await _s3Client.UploadPartAsync(uploadPartRequest, cancellationToken).ConfigureAwait(false);
                                Logger.DebugFormat("Uploaded part {0}. (Last part = {1}, Part size = {2}, Upload Id: {3})", partNumber, isLastPart, partSize, initiateResponse.UploadId);
                                uploadPartResponses.Add(partResponse);
                                partNumber++;

                                nextUploadBuffer.Dispose();
                                nextUploadBuffer = new MemoryStream(partBuffer);
                            }
                            readBytesCount = readAheadBytesCount;
                        }
                        while (readAheadBytesCount > 0);
                    }
                    finally
                    {
                        ArrayPool<byte>.Shared.Return(partBuffer);
                        ArrayPool<byte>.Shared.Return(readBuffer);

                        nextUploadBuffer.Dispose();
                    }

                    this._uploadResponses = uploadPartResponses;
                    CompleteMultipartUploadRequest compRequest = ConstructCompleteMultipartUploadRequest(initiateResponse, true, requestEventHandler);
                    var completeResponse = await _s3Client.CompleteMultipartUploadAsync(compRequest, cancellationToken).ConfigureAwait(false);
                    Logger.DebugFormat("Completed multi part upload. (Part count: {0}, Upload Id: {1})", uploadPartResponses.Count, initiateResponse.UploadId);

                    var mappedResponse = ResponseMapper.MapCompleteMultipartUploadResponse(completeResponse);
                    FireTransferCompletedEvent(mappedResponse);
                    return mappedResponse;
                }
            }
            catch (Exception ex)
            {
                FireTransferFailedEvent();

                await _s3Client.AbortMultipartUploadAsync(new AbortMultipartUploadRequest()
                {
                    BucketName = request.BucketName,
                    Key = request.Key,
                    RequestPayer = request.RequestPayer,
                    UploadId = initiateResponse.UploadId
                }).ConfigureAwait(false);
                Logger.Error(ex, ex.Message);
                throw;
            }
        }
        
        private class ExpectedUploadPart
        {
            public int PartNumber { get; set; }
            public long? ExpectedContentLength { get; set; }
            public long? ExpectedFileOffset { get; set; }
            public bool IsLastPart { get; set; }
        }
    }
}
