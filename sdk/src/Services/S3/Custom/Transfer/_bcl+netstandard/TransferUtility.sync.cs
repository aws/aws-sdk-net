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

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using Amazon.Runtime.Internal.Util;
using Amazon.S3.Model;
using Amazon.S3.Transfer.Internal;
using Amazon.Util;
using System.Runtime.ExceptionServices;

namespace Amazon.S3.Transfer
{
    public partial class TransferUtility : ITransferUtility
    {
        #region UploadDirectory
        /// <inheritdoc/>
        public void UploadDirectory(string directory, string bucketName)
        {
            try
            {
                UploadDirectoryAsync(directory, bucketName).Wait();
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
            }
        }


        /// <inheritdoc/>
        public void UploadDirectory(string directory, string bucketName, string searchPattern, SearchOption searchOption)
        {
            try
            {
                UploadDirectoryAsync(directory, bucketName, searchPattern, searchOption).Wait();
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
            }
        }

        /// <inheritdoc/>
        public void UploadDirectory(TransferUtilityUploadDirectoryRequest request)
        {
            try
            {
                UploadDirectoryAsync(request).Wait();
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
            }
        }
        #endregion

        #region Upload

        /// <inheritdoc/>
        public void Upload(string filePath, string bucketName)
        {
            try
            {
                UploadAsync(filePath, bucketName).Wait();
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
            }
        }

        /// <inheritdoc/>
        public void Upload(string filePath, string bucketName, string key)
        {
            try
            {
                UploadAsync(filePath, bucketName, key).Wait();
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
            }
        }


        /// <inheritdoc/>
        public void Upload(Stream stream, string bucketName, string key)
        {
            try
            {
                UploadAsync(stream, bucketName, key).Wait();
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
            }
        }

        /// <inheritdoc/>
        public void Upload(TransferUtilityUploadRequest request)
        {
            try
            {
                UploadAsync(request).Wait();
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
            }
        }

        /// <inheritdoc/>
        public TransferUtilityUploadResponse UploadWithResponse(string filePath, string bucketName)
        {
            try
            {
                return UploadWithResponseAsync(filePath, bucketName).Result;
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <inheritdoc/>
        public TransferUtilityUploadResponse UploadWithResponse(string filePath, string bucketName, string key)
        {
            try
            {
                return UploadWithResponseAsync(filePath, bucketName, key).Result;
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <inheritdoc/>
        public TransferUtilityUploadResponse UploadWithResponse(Stream stream, string bucketName, string key)
        {
            try
            {
                return UploadWithResponseAsync(stream, bucketName, key).Result;
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <inheritdoc/>
        public TransferUtilityUploadResponse UploadWithResponse(TransferUtilityUploadRequest request)
        {
            try
            {
                return UploadWithResponseAsync(request).Result;
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        #endregion

        #region OpenStream

        /// <inheritdoc/>
        public Stream OpenStream(string bucketName, string key)
        {
            try
            {
                return OpenStreamAsync(bucketName, key).Result;
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <inheritdoc/>
        public Stream OpenStream(TransferUtilityOpenStreamRequest request)
        {
            try
            {
                return OpenStreamAsync(request).Result;
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <inheritdoc/>
        public TransferUtilityOpenStreamResponse OpenStreamWithResponse(string bucketName, string key)
        {
            try
            {
                return OpenStreamWithResponseAsync(bucketName, key).Result;
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <inheritdoc/>
        public TransferUtilityOpenStreamResponse OpenStreamWithResponse(TransferUtilityOpenStreamRequest request)
        {
            try
            {
                return OpenStreamWithResponseAsync(request).Result;
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        #endregion

        #region Download
        /// <inheritdoc/>
        public void Download(string filePath, string bucketName, string key)
        {
            try
            {
                DownloadAsync(filePath, bucketName, key).Wait();
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
            }
        }

        /// <inheritdoc/>
        public void Download(TransferUtilityDownloadRequest request)
        {
            try
            {
                DownloadAsync(request).Wait();
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
            }
        }

        /// <inheritdoc/>
        public TransferUtilityDownloadResponse DownloadWithResponse(string filePath, string bucketName, string key)
        {
            try
            {
                return DownloadWithResponseAsync(filePath, bucketName, key).Result;
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }

        /// <inheritdoc/>
        public TransferUtilityDownloadResponse DownloadWithResponse(TransferUtilityDownloadRequest request)
        {
            try
            {
                return DownloadWithResponseAsync(request).Result;
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
                return null;
            }
        }
        #endregion

        #region DownloadDirectory
        /// <inheritdoc/>
        public void DownloadDirectory(string bucketName, string s3Directory, string localDirectory)
        {
            try
            {
                DownloadDirectoryAsync(bucketName, s3Directory, localDirectory).Wait();
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
            }
        }

        /// <inheritdoc/>
        public void DownloadDirectory(TransferUtilityDownloadDirectoryRequest request)
        {
            try
            {
                DownloadDirectoryAsync(request).Wait();
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
            }
        }
        #endregion

        #region AbortMultipartUploads

        /// <inheritdoc/>
        public void AbortMultipartUploads(string bucketName, DateTime initiatedDate)
        {
            try
            {
                AbortMultipartUploadsAsync(bucketName, initiatedDate).Wait();
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
            }
        }

        /// <inheritdoc/>
        public void AbortMultipartUploads(TransferUtilityAbortMultipartUploadRequest request)
        {
            try
            {
                AbortMultipartUploadsAsync(request).Wait();
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
            }
        }

        #endregion
    }
}
