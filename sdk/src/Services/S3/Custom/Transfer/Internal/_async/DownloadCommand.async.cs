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
using Amazon.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.S3.Transfer.Internal
{
    internal partial class DownloadCommand : BaseCommand<TransferUtilityDownloadResponse>
    {
        public override async Task<TransferUtilityDownloadResponse> ExecuteAsync(CancellationToken cancellationToken)
        {
            ValidateRequest();
            
            FireTransferInitiatedEvent();
            
            GetObjectRequest getRequest = ConvertToGetObjectRequest(this._request);

            var maxRetries = _s3Client.Config.MaxErrorRetry;
            var retries = 0;
            bool shouldRetry = false;
            string mostRecentETag = null;
            TransferUtilityDownloadResponse lastSuccessfulMappedResponse = null;
            long? totalBytesFromResponse = null; // Track total bytes once we have response headers
            do
            {
                shouldRetry = false;

                if (retries != 0)
                {
                    ByteRange bytesRemaining = ByteRangeRemainingForDownload(this._request.FilePath);
                    getRequest.ByteRange = bytesRemaining;
                }

                try
                {
                    using (var response = await this._s3Client.GetObjectAsync(getRequest, cancellationToken)
                        .ConfigureAwait(continueOnCapturedContext: false))
                    {
                        // Capture total bytes from response headers as soon as we get them
                        totalBytesFromResponse = response.ContentLength;

                        if (!string.IsNullOrEmpty(mostRecentETag) && !string.Equals(mostRecentETag, response.ETag))
                        {
                            //if the eTag changed, we need to retry from the start of the file
                            mostRecentETag = response.ETag;
                            getRequest.ByteRange = null;
                            retries = 0;
                            Interlocked.Exchange(ref _totalTransferredBytes, 0);
                            shouldRetry = true;
                            WaitBeforeRetry(retries);
                            continue;
                        }
                        mostRecentETag = response.ETag;

                        if (retries == 0)
                        {
                            /* 
                             * Wipe the local file, if it exists, to handle edge case where:
                             * 
                             * 1. File foo exists
                             * 2. We start trying to download, but unsuccesfully write any data
                             * 3. We retry the download, with retires > 0, thus hitting the else statement below
                             * 4. We will append to file foo, instead of overwriting it
                             * 
                             * We counter it with the call below because it's the same call that would be hit
                             * in WriteResponseStreamToFile. If any exceptions are thrown, they will be the same as before
                             * to avoid any breaking changes to customers who handle that specific exception in a
                             * particular manor.
                             */
#if BCL
                            if (File.Exists(this._request.FilePath))
                            {
                                using (FileStream temp = new FileStream(this._request.FilePath, FileMode.Create, FileAccess.ReadWrite, FileShare.Read, Amazon.S3.Util.S3Constants.DefaultBufferSize))
                                {
                                    //Do nothing. Simply using the "using" statement to create and dispose of FileStream temp in the same call.
                                };
                            }
#endif

                            response.WriteObjectProgressEvent += OnWriteObjectProgressEvent;
                            await response.WriteResponseStreamToFileAsync(this._request.FilePath, false, cancellationToken)
                                .ConfigureAwait(continueOnCapturedContext: false);
                        }
                        else
                        {
                            response.WriteObjectProgressEvent += OnWriteObjectProgressEvent;
                            await response.WriteResponseStreamToFileAsync(this._request.FilePath, true, cancellationToken)
                                .ConfigureAwait(continueOnCapturedContext: false);
                        }

                        lastSuccessfulMappedResponse = ResponseMapper.MapGetObjectResponse(response);
                    }
                }
                catch (Exception exception)
                {
                    retries++;
                    shouldRetry = HandleExceptionForHttpClient(exception, retries, maxRetries);
                    if (!shouldRetry)
                    {
                        // Pass total bytes if we have them from response headers, otherwise -1 for unknown
                        FireTransferFailedEvent(this._request.FilePath, Interlocked.Read(ref _totalTransferredBytes), totalBytesFromResponse ?? -1);

                        if (exception is IOException)
                        {
                            throw;
                        }
                        else if (exception.InnerException is IOException)
                        {
                            ExceptionDispatchInfo.Capture(exception.InnerException).Throw();
                        }
                        else if (exception is AmazonServiceException ||
                            exception is AmazonClientException)
                        {
                            throw;
                        }
                        else
                        {
                            throw new AmazonServiceException(exception);
                        }
                    }
                }
                WaitBeforeRetry(retries);
            } while (shouldRetry);
            
            // This should never happen under normal logic flow since we always throw exception on error.
            if (lastSuccessfulMappedResponse == null)
            {
                throw new InvalidOperationException("Download completed without any successful response. This indicates a logical error in the retry handling.");
            }

            FireTransferCompletedEvent(lastSuccessfulMappedResponse, this._request.FilePath, Interlocked.Read(ref _totalTransferredBytes), totalBytesFromResponse ?? -1);

            return lastSuccessfulMappedResponse;
        }

        private static bool HandleExceptionForHttpClient(Exception exception, int retries, int maxRetries)
        {
            if (AWSHttpClient.IsHttpInnerException(exception))
            {
                var innerHttpException = exception.InnerException;
                if (innerHttpException is IOException
#if !NETSTANDARD
                    || innerHttpException is WebException
#endif
                    )
                {
                    return HandleException(innerHttpException, retries, maxRetries);
                }
                else
                    return false;
            }
            else
                return HandleException(exception, retries, maxRetries);
        }
    }
}
