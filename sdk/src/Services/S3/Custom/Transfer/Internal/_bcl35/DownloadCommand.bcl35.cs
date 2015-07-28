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
            do
            {
                shouldRetry = false;

                if (retries != 0)
                {
                    ByteRange bytesRemaining = ByteRangeRemainingForDownload(this._request.FilePath);
                    getRequest.ByteRange = bytesRemaining;
                }

                using (var response = this._s3Client.GetObject(getRequest))
                {
                    try
                    {
                        if (retries == 0)
                        {
                            response.WriteObjectProgressEvent += OnWriteObjectProgressEvent;
                            response.WriteResponseStreamToFile(this._request.FilePath);
                        }
                        else
                        {
                            response.WriteObjectProgressEvent += OnWriteObjectProgressEvent;
                            response.WriteResponseStreamToFile(this._request.FilePath, true);
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
                }
                WaitBeforeRetry(retries);
            } while (shouldRetry);
        }
        
        /// <summary>
        /// Returns the amount of bytes remaining that need to be pulled down from S3.
        /// </summary>
        /// <param name="filepath">The fully qualified path of the file.</param>
        /// <returns></returns>
        internal ByteRange ByteRangeRemainingForDownload(string filepath)
        {
            /*
             * Initialize the ByteRange as the whole file.
             * long.MaxValue works regardless of the size because
             * S3 will stop sending bits if you specify beyond the
             * size of the file anyways.
             */
            ByteRange byteRange = new ByteRange(0, long.MaxValue);

            if (!File.Exists(filepath))
                return byteRange;

            FileInfo info = new FileInfo(filepath);
            byteRange.Start = info.Length;

            return byteRange;
        }
    }
}
