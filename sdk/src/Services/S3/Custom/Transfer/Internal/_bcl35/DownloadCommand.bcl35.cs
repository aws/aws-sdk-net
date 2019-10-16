/*******************************************************************************
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 *  this file except in compliance with the License. A copy of the License is located at
 *
 *  http://aws.amazon.com/apache2.0
 *
 *  or in the "license" file accompanying this file.
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the
 *  specific language governing permissions and limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 *  API Version: 2006-03-01
 *
 */

using System;
using System.IO;
using Amazon.Runtime;
using Amazon.S3.Model;

namespace Amazon.S3.Transfer.Internal
{
    internal partial class DownloadCommand
    {
        public override void Execute()
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
                    ByteRange bytesRemaining = ByteRangeRemainingForDownload(this._request.FilePath);
                    getRequest.ByteRange = bytesRemaining;
                }

                try
                {
                    using (var response = this._s3Client.GetObject(getRequest))
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
                            if (File.Exists(this._request.FilePath))
                            {
                                using (FileStream temp = new FileStream(this._request.FilePath, FileMode.Create, FileAccess.ReadWrite, FileShare.Read, Amazon.S3.Util.S3Constants.DefaultBufferSize))
                                {
                                    //Do nothing. Simply using the "using" statement to create and dispose of FileStream temp in the same call.
                                };
                            }

                            response.WriteObjectProgressEvent += OnWriteObjectProgressEvent;
                            response.WriteResponseStreamToFile(this._request.FilePath);
                        }
                        else
                        {
                            response.WriteObjectProgressEvent += OnWriteObjectProgressEvent;
                            response.WriteResponseStreamToFile(this._request.FilePath, true);
                        }
                    }
                }
                catch (Exception exception)
                {
                    retries++;
                    shouldRetry = HandleException(exception, retries, maxRetries);
                    if (!shouldRetry)
                    {
                        if (exception is IOException)
                        {
                            throw;
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
    }
}
