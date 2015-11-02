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

using Amazon.Runtime;
using Amazon.S3.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Amazon.S3.Transfer.Internal
{
    internal partial class DownloadCommand : BaseCommand
    {
        public override async Task ExecuteAsync(CancellationToken cancellationToken)
        {
            ValidateRequest();
            GetObjectRequest getRequest = ConvertToGetObjectRequest(this._request);

            var maxRetries = ((AmazonS3Client)_s3Client).Config.MaxErrorRetry;
            var retries = 0;
            bool shouldRetry = false;
            string mostRecentETag = null;
            do
            {
                shouldRetry = false;

                if (retries != 0)
                {
#if PCL
                    ByteRange bytesRemaining = await ByteRangeRemainingForDownloadAsync(this._request.FilePath);
#else
                    ByteRange bytesRemaining = ByteRangeRemainingForDownload(this._request.FilePath);
#endif
                    getRequest.ByteRange = bytesRemaining;
                }

                try
                {
                    using (var response = await this._s3Client.GetObjectAsync(getRequest, cancellationToken)
                        .ConfigureAwait(continueOnCapturedContext: false))
                    {
                        if (!string.IsNullOrEmpty(mostRecentETag) && !string.Equals(mostRecentETag, response.ETag))
                        {
                            //if the eTag changed, we need to retry from the start of the file
                            mostRecentETag = response.ETag;
                            getRequest.ByteRange = null;
                            retries = 0;
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
#if PCL
                            var file = await PCLStorage.FileSystem.Current.GetFileFromPathAsync(this._request.FilePath).ConfigureAwait(false);
                            if (file != null)
                                await file.DeleteAsync().ConfigureAwait(false);
#endif
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
                    }
                }
                catch (Exception exception)
                {
                    retries++;
                    shouldRetry = HandleExceptionForHttpClient(exception, retries, maxRetries);
                    if (!shouldRetry)
                    {
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
        }

        private static bool HandleExceptionForHttpClient(Exception exception, int retries, int maxRetries)
        {
            var httpException = exception as HttpRequestException;
            if (httpException != null)
            {
                if (httpException.InnerException is IOException ||
                    httpException.InnerException is WebException)
                {
                    return HandleException(httpException.InnerException, retries, maxRetries);
                }
                else
                    return false;
            }
            else
                return HandleException(exception, retries, maxRetries);
        }

#if PCL
        /// <summary>
        /// Returns the amount of bytes remaining that need to be pulled down from S3.
        /// </summary>
        /// <param name="filepath">The fully qualified path of the file.</param>
        /// <returns></returns>
        static async Task<ByteRange> ByteRangeRemainingForDownloadAsync(string filepath)
        {
            /*
             * Initialize the ByteRange as the whole file.
             * long.MaxValue works regardless of the size because
             * S3 will stop sending bits if you specify beyond the
             * size of the file anyways.
             */
            ByteRange byteRange = new ByteRange(0, long.MaxValue);

            var file = await PCLStorage.FileSystem.Current.GetFileFromPathAsync(filepath).ConfigureAwait(false);
            if (file != null)
            {
                using (var stream = await file.OpenAsync(PCLStorage.FileAccess.Read).ConfigureAwait(false))
                {
                    byteRange.Start = stream.Length;
                }
            }

            return byteRange;
        }
#endif

    }
}
