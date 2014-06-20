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
using System.Collections.Generic;
using System.Text;

using Amazon.S3;
using Amazon.S3.Model;
using System.Threading;
using Amazon.Runtime.Internal.Util;
using System.Net;
using Amazon.Util;
using System.IO;

namespace Amazon.S3.Transfer.Internal
{
    internal partial class DownloadCommand : BaseCommand
    {
        static int MAX_BACKOFF_IN_MILLISECONDS = (int)TimeSpan.FromSeconds(30).TotalMilliseconds;

        // Set of status codes to retry on.
        static ICollection<WebExceptionStatus> WebExceptionStatusesToRetryOn = new HashSet<WebExceptionStatus>
        {
            WebExceptionStatus.ConnectFailure,

#if (!WIN_RT) // These statuses are not available on WinRT
            WebExceptionStatus.ConnectionClosed,
            WebExceptionStatus.KeepAliveFailure,
            WebExceptionStatus.NameResolutionFailure,            
#endif
        };

        static Logger _logger = Logger.GetLogger(typeof(TransferUtility));

        IAmazonS3 _s3Client;
        TransferUtilityDownloadRequest _request;

        internal DownloadCommand(IAmazonS3 s3Client, TransferUtilityDownloadRequest request)
        {
            this._s3Client = s3Client;
            this._request = request;
        }

        private void ValidateRequest()
        {
            if (!this._request.IsSetBucketName())
            {
                throw new InvalidOperationException("The BucketName specified is null or empty!");
            }
#if BCL
            if (!this._request.IsSetFilePath())
            {
                throw new InvalidOperationException("The filepath specified is null or empty!");
            }
#elif WIN_RT || WINDOWS_PHONE
            if (!this._request.IsSetStorageFile())
            {
                throw new InvalidOperationException("The StorageFile specified is null or empty!");
            }
#endif
            if (!this._request.IsSetKey())
            {
                throw new InvalidOperationException("The Key specified is null or empty!");
            }
            }

        void OnWriteObjectProgressEvent(object sender, WriteObjectProgressArgs e)
            {
            this._request.OnRaiseProgressEvent(e);
        }

        private static bool HandleException(Exception exception, int retries, int maxRetries)
        {
            var canRetry = true;
            if (exception is IOException)
            {
#if (!WIN_RT)
                while (exception.InnerException != null)
                {
                    if (exception.InnerException is ThreadAbortException)
                    {
                        _logger.Error(exception, "Encountered a IOException caused by a ThreadAbortException.");
                        return false;
                    }
                    exception = exception.InnerException;
                }
#endif
                if (retries < maxRetries)
                {
                    _logger.InfoFormat("Encountered an IOException. Retrying, retry {0} of {1}.",
                        retries, maxRetries);
                    return true;
                }
                else
                    canRetry = false;
            }

            var webException = exception as WebException;
            if (webException != null)
            {
                _logger.Error(exception, "Encountered a WebException ({1}).", webException.GetType().Name, webException.Status);
                if (WebExceptionStatusesToRetryOn.Contains(webException.Status) && retries < maxRetries)
                {

                    _logger.InfoFormat("Encountered a WebException ({0}). Retrying, retry {1} of {2}.",
                        webException.Status, retries, maxRetries);
                    return true;
                }
                else
                    canRetry = false;
            }

            if (!canRetry)
            {
                _logger.Error(exception, "Encountered a {0}. Reached maximum retries {1} of {2}.", exception.GetType().Name, retries, maxRetries);
                return false;
            }

            _logger.Error(exception, "Encountered a non retryable {0}, rethrowing exception.", exception.GetType().Name);
            return false;
        }

        static void WaitBeforeRetry(int retries)
        {
            int delay = (int)(Math.Pow(4, retries) * 100);
            delay = Math.Min(delay, MAX_BACKOFF_IN_MILLISECONDS);
            AWSSDKUtils.Sleep(delay);
        }
    }
}

