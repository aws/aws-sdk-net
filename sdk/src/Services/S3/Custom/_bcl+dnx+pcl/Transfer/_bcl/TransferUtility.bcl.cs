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
using System.IO;
using System.Text;
using System.Threading;

using Amazon.Runtime.Internal.Util;
using Amazon.S3.Model;
using Amazon.S3.Transfer.Internal;
using Amazon.Util;
using System.Globalization;

namespace Amazon.S3.Transfer
{
    /// <summary>
    /// 	<para>
    /// 	Provides a high level utility for managing transfers to and from Amazon S3.
    /// 	</para>
    /// 	<para>
    /// 	<c>TransferUtility</c> provides a simple API for 
    /// 	uploading content to and downloading content
    /// 	from Amazon S3. It makes extensive use of Amazon S3 multipart uploads to
    /// 	achieve enhanced throughput, performance, and reliability. 
    /// 	</para>
    /// 	<para>
    /// 	When uploading large files by specifying file paths instead of a stream, 
    /// 	<c>TransferUtility</c> uses multiple threads to upload
    /// 	multiple parts of a single upload at once. When dealing with large content
    /// 	sizes and high bandwidth, this can increase throughput significantly.
    /// 	</para>
    /// </summary>
    /// <remarks>
    /// 	<para>
    /// 	Transfers are stored in memory. If the application is restarted, 
    /// 	previous transfers are no longer accessible. In this situation, if necessary, 
    /// 	you should clean up any multipart uploads that are incomplete.
    /// 	</para>
    /// </remarks>
    public partial class TransferUtility : ITransferUtility
    {
        #region Constructors

        /// <summary>
        /// 	Constructs a new <see cref="TransferUtility"/> class.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If a Timeout needs to be specified, use the constructor which takes an <see cref="Amazon.S3.AmazonS3Client"/> as a paramater.
        /// Use an instance of <see cref="Amazon.S3.AmazonS3Client"/> constructed with an <see cref="Amazon.S3.AmazonS3Config"/> object with the Timeout specified. 
        /// </para>        
        /// </remarks>
        public TransferUtility()
            : this(new AmazonS3Client())
        {
            this._shouldDispose = true;
        }

        /// <summary>
        /// 	Constructs a new <see cref="TransferUtility"/> class.
        /// </summary>
        /// <param name="region">
        ///     The region to configure the transfer utility for.
        /// </param>
        /// <remarks>
        /// <para>
        /// If a Timeout needs to be specified, use the constructor which takes an <see cref="Amazon.S3.AmazonS3Client"/> as a paramater.
        /// Use an instance of <see cref="Amazon.S3.AmazonS3Client"/> constructed with an <see cref="Amazon.S3.AmazonS3Config"/> object with the Timeout specified. 
        /// </para>        
        /// </remarks>
        public TransferUtility(RegionEndpoint region)
            : this(new AmazonS3Client(region))
        {
            this._shouldDispose = true;
        }

        /// <summary>
        /// 	Constructs a new <see cref="TransferUtility"/> class.
        /// </summary>
        /// <param name="config">
        /// 	Specifies advanced configuration settings for <see cref="TransferUtility"/>.
        /// </param>
        /// <remarks>
        /// </remarks>
        public TransferUtility(TransferUtilityConfig config)
            : this(new AmazonS3Client(), config)
        {
            this._config = config;
        }

        #endregion 

        private static TransferUtilityDownloadRequest ConstructDownloadRequest(string filePath, string bucketName, string key)
        {
            return new TransferUtilityDownloadRequest()
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath
            };
        }

        private static TransferUtilityDownloadDirectoryRequest ConstructDownloadDirectoryRequest(string bucketName, string s3Directory, string localDirectory)
        {
            return new TransferUtilityDownloadDirectoryRequest()
            {
                BucketName = bucketName,
                S3Directory = s3Directory,
                LocalDirectory = localDirectory
            };
        }

        static void validate(TransferUtilityUploadDirectoryRequest request)
        {
            if (!request.IsSetDirectory())
            {
                throw new InvalidOperationException("Directory not specified");
            }
            if (!request.IsSetBucketName())
            {
                throw new InvalidOperationException("BucketName not specified");
            }
            if (!Directory.Exists(request.Directory))
            {
                throw new InvalidOperationException(string.Format(CultureInfo.InvariantCulture, "The directory {0} does not exists!",
                    request.Directory));
            }
        }

        private static TransferUtilityUploadDirectoryRequest ConstructUploadDirectoryRequest(string directory, string bucketName)
        {
            return new TransferUtilityUploadDirectoryRequest()
            {
                BucketName = bucketName,
                Directory = directory
            };
        }

        private static TransferUtilityUploadDirectoryRequest ConstructUploadDirectoryRequest(string directory, string bucketName, string searchPattern, SearchOption searchOption)
        {
            return new TransferUtilityUploadDirectoryRequest()
            {
                BucketName = bucketName,
                Directory = directory,
                SearchPattern = searchPattern,
                SearchOption = searchOption
            };
        }
    }
}
