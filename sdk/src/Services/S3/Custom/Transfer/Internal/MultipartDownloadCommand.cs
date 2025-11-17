/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using Amazon.Runtime.Internal.Util;
using Amazon.S3.Model;
using Amazon.S3.Util;

namespace Amazon.S3.Transfer.Internal
{
    /// <summary>
    /// Command for downloading files using multipart download strategy.
    /// Orchestrates the <see cref="MultipartDownloadManager"/> and <see cref="FilePartDataHandler"/>
    /// to perform concurrent part downloads with SEP compliance.
    /// </summary>
    internal partial class MultipartDownloadCommand : BaseCommand<TransferUtilityDownloadResponse>
    {
        private readonly IAmazonS3 _s3Client;
        private readonly TransferUtilityDownloadRequest _request;
        private readonly TransferUtilityConfig _config;

        private static Logger Logger
        {
            get
            {
                return Logger.GetLogger(typeof(TransferUtility));
            }
        }

        /// <summary>
        /// Initializes a new instance of the MultipartDownloadCommand class.
        /// </summary>
        /// <param name="s3Client">The S3 client to use for downloads.</param>
        /// <param name="request">The download request containing configuration.</param>
        /// <param name="config">The TransferUtility configuration.</param>
        internal MultipartDownloadCommand(IAmazonS3 s3Client, TransferUtilityDownloadRequest request, TransferUtilityConfig config)
        {
            _s3Client = s3Client ?? throw new ArgumentNullException(nameof(s3Client));
            _request = request ?? throw new ArgumentNullException(nameof(request));
            _config = config ?? throw new ArgumentNullException(nameof(config));
        }

        /// <summary>
        /// Validates the download request to ensure all required parameters are set.
        /// </summary>
        /// <exception cref="InvalidOperationException">Thrown when required parameters are missing.</exception>
        private void ValidateRequest()
        {
            if (!_request.IsSetBucketName())
            {
                throw new InvalidOperationException("The BucketName specified is null or empty!");
            }
            
            if (!_request.IsSetKey())
            {
                throw new InvalidOperationException("The Key specified is null or empty!");
            }
            
#if BCL
            if (!_request.IsSetFilePath())
            {
                throw new InvalidOperationException("The FilePath specified is null or empty!");
            }
#endif
        }

        /// <summary>
        /// Creates a FileDownloadConfiguration from the request and S3 client configuration.
        /// </summary>
        /// <returns>A configured FileDownloadConfiguration instance.</returns>
        private FileDownloadConfiguration CreateConfiguration()
        {
            // Use concurrent service requests from config
            int concurrentRequests = _config.ConcurrentServiceRequests;

            // Determine target part size
            // Use request setting if available, otherwise use 8MB default (matching BufferedMultipartStream)
            long targetPartSize = _request.IsSetPartSize() 
                ? _request.PartSize 
                : S3Constants.DefaultPartSize; // 8MB default

            // Use S3 client buffer size for I/O operations
            int bufferSize = _s3Client.Config.BufferSize;

            Logger.DebugFormat("MultipartDownloadCommand: Creating configuration - PartSizeFromRequest={0}, UsingDefaultPartSize={1}",
                _request.IsSetPartSize() ? _request.PartSize.ToString() : "Not Set",
                !_request.IsSetPartSize());

            return new FileDownloadConfiguration(
                concurrentRequests,
                bufferSize,
                targetPartSize,
                _request.FilePath
            );
        }
    }
}
