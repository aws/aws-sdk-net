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
    public partial class TransferUtility : IDisposable
    {
        TransferUtilityConfig _config;
        IAmazonS3 _s3Client;
        bool _shouldDispose = false;
        bool _isDisposed;

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
        /// <param name="awsAccessKeyId">
        /// 	The AWS Access Key ID.
        /// </param>
        /// <param name="awsSecretAccessKey">
        /// 	The AWS Secret Access Key.
        /// </param>
        /// <remarks>
        /// <para>
        /// If a Timeout needs to be specified, use the constructor which takes an <see cref="Amazon.S3.AmazonS3Client"/> as a paramater.
        /// Use an instance of <see cref="Amazon.S3.AmazonS3Client"/> constructed with an <see cref="Amazon.S3.AmazonS3Config"/> object with the Timeout specified. 
        /// </para>        
        /// </remarks>
        public TransferUtility(string awsAccessKeyId, string awsSecretAccessKey)
            : this(new AmazonS3Client(awsAccessKeyId, awsSecretAccessKey))
        {
            this._shouldDispose = true;
        }

        /// <summary>
        /// 	Constructs a new <see cref="TransferUtility"/> class.
        /// </summary>
        /// <param name="awsAccessKeyId">
        /// 	The AWS Access Key ID.
        /// </param>
        /// <param name="awsSecretAccessKey">
        /// 	The AWS Secret Access Key.
        /// </param>
        /// <param name="region">
        ///     The region to configure the transfer utility for.
        /// </param>
        /// <remarks>
        /// <para>
        /// If a Timeout needs to be specified, use the constructor which takes an <see cref="Amazon.S3.AmazonS3Client"/> as a paramater.
        /// Use an instance of <see cref="Amazon.S3.AmazonS3Client"/> constructed with an <see cref="Amazon.S3.AmazonS3Config"/> object with the Timeout specified. 
        /// </para>        
        /// </remarks>
        public TransferUtility(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(new AmazonS3Client(awsAccessKeyId, awsSecretAccessKey, region))
        {
            this._shouldDispose = true;
        }

        /// <summary>
        /// 	Constructs a new instance of the <see cref="TransferUtility"/> class.
        /// </summary>
        /// <param name="awsAccessKeyId">
        /// 	The AWS Access Key ID.
        /// </param>
        /// <param name="awsSecretAccessKey">
        /// 	The AWS Secret Access Key.
        /// </param>
        /// <param name="config">
        /// 	Specifies advanced settings.
        /// </param>
        /// <remarks>
        /// <para>
        /// If a Timeout needs to be specified, use the constructor which takes an <see cref="Amazon.S3.AmazonS3Client"/> as a paramater.
        /// Use an instance of <see cref="Amazon.S3.AmazonS3Client"/> constructed with an <see cref="Amazon.S3.AmazonS3Config"/> object with the Timeout specified. 
        /// </para>        
        /// </remarks>
        public TransferUtility(string awsAccessKeyId, string awsSecretAccessKey, TransferUtilityConfig config)
            : this(new AmazonS3Client(awsAccessKeyId, awsSecretAccessKey), config)
        {
            this._shouldDispose = true;
        }

        /// <summary>
        /// 	Constructs a new instance of the <see cref="TransferUtility"/> class.
        /// </summary>
        /// <param name="awsAccessKeyId">
        /// 	The AWS Access Key ID.
        /// </param>
        /// <param name="awsSecretAccessKey">
        /// 	The AWS Secret Access Key.
        /// </param>
        /// <param name="region">
        ///     The region to configure the transfer utility for.
        /// </param>
        /// <param name="config">
        /// 	Specifies advanced settings.
        /// </param>
        /// <remarks>
        /// <para>
        /// If a Timeout needs to be specified, use the constructor which takes an <see cref="Amazon.S3.AmazonS3Client"/> as a paramater.
        /// Use an instance of <see cref="Amazon.S3.AmazonS3Client"/> constructed with an <see cref="Amazon.S3.AmazonS3Config"/> object with the Timeout specified. 
        /// </para>        
        /// </remarks>
        public TransferUtility(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region, TransferUtilityConfig config)
            : this(new AmazonS3Client(awsAccessKeyId, awsSecretAccessKey, region), config)
        {
            this._shouldDispose = true;
        }


        /// <summary>
        /// 	Constructs a new instance of the <see cref="TransferUtility"/> class.
        /// </summary>
        /// <param name="s3Client">
        /// 	The Amazon S3 client.
        /// </param>
        /// <remarks>
        /// <para>
        /// If a Timeout needs to be specified, use the constructor which takes an <see cref="Amazon.S3.AmazonS3Client"/> as a paramater.
        /// Use an instance of <see cref="Amazon.S3.AmazonS3Client"/> constructed with an <see cref="Amazon.S3.AmazonS3Config"/> object with the Timeout specified. 
        /// </para>        
        /// </remarks>
        public TransferUtility(IAmazonS3 s3Client)
            : this(s3Client, new TransferUtilityConfig())
        {
        }

        /// <summary>
        /// 	Initializes a new instance of the <see cref="TransferUtility"/> class.
        /// </summary>
        /// <param name="s3Client">
        /// 	The Amazon S3 client.
        /// </param>
        /// <param name="config">
        /// 	Specifies advanced configuration settings for <see cref="TransferUtility"/>.
        /// </param>
        /// <remarks>
        /// <para>
        /// If a Timeout needs to be specified, use the constructor which takes an <see cref="Amazon.S3.AmazonS3Client"/> as a paramater.
        /// Use an instance of <see cref="Amazon.S3.AmazonS3Client"/> constructed with an <see cref="Amazon.S3.AmazonS3Config"/> object with the Timeout specified. 
        /// </para>        
        /// </remarks>
        public TransferUtility(IAmazonS3 s3Client, TransferUtilityConfig config)
        {
            this._s3Client = s3Client;
            this._config = config;
        }

        #endregion

        #region Properties

        /// <summary>
        /// 	Gets the Amazon S3 client used for making calls into Amazon S3.
        /// </summary>
        /// <value>
        /// 	The Amazon S3 client used for making calls into Amazon S3.
        /// </value>
        public IAmazonS3 S3Client
        {
            get
            {
                return this._s3Client;
            }
        }

        #endregion

        #region Dispose Pattern Implementation

        /// <summary>
        /// Implements the Dispose pattern for the AmazonWebServiceClient
        /// </summary>
        /// <param name="disposing">Whether this object is being disposed via a call to Dispose
        /// or garbage collected.</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this._isDisposed)
            {
                if (disposing && _s3Client != null && _shouldDispose)
                {
                    _s3Client.Dispose();
                    _s3Client = null;
                }
                this._isDisposed = true;
            }
        }

        /// <summary>
        /// Disposes of all managed and unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion

        #region UploadDirectory


        private void UploadDirectoryHelper(string directory, string bucketName)
        {
            TransferUtilityUploadDirectoryRequest request = new TransferUtilityUploadDirectoryRequest()
            {
                BucketName = bucketName,
                Directory = directory
            };
            UploadDirectoryHelper(request);
        }

        private void UploadDirectoryHelper(string directory, string bucketName, string searchPattern, SearchOption searchOption)
        {
            TransferUtilityUploadDirectoryRequest request = new TransferUtilityUploadDirectoryRequest()
            {
                BucketName = bucketName,
                Directory = directory,
                SearchPattern = searchPattern,
                SearchOption = searchOption
            };
            UploadDirectoryHelper(request);
        }

        private void UploadDirectoryHelper(TransferUtilityUploadDirectoryRequest request)
        {
            validate(request);
            UploadDirectoryCommand command = new UploadDirectoryCommand(this, this._config, request);
            command.Execute();
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
        #endregion

        #region Upload

        private void UploadHelper(string filePath, string bucketName)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentNullException("filePath");
            }
            if (!File.Exists(filePath))
            {
                throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "The file {0} does not exists!", filePath));
            }

            TransferUtilityUploadRequest request = new TransferUtilityUploadRequest()
            {
                BucketName = bucketName,
                FilePath = filePath
            };

            UploadHelper(request);
        }

        /// <summary>
        /// 	Uploads the specified file.  
        /// 	Multiple threads are used to read the file and perform multiple uploads in parallel.  
        /// 	For large uploads, the file will be divided and uploaded in parts using 
        /// 	Amazon S3's multipart API.  The parts will be reassembled as one object in
        /// 	Amazon S3.
        /// </summary>
        /// <param name="filePath">
        /// 	The file path of the file to upload.
        /// </param>
        /// <param name="bucketName">
        /// 	The target Amazon S3 bucket, that is, the name of the bucket to upload the file to.
        /// </param>
        /// <param name="key">
        /// 	The key under which the Amazon S3 object is stored.
        /// </param>
        private void UploadHelper(string filePath, string bucketName, string key)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentNullException("filePath");
            }
            if (!File.Exists(filePath))
            {
                throw new ArgumentException(string.Format(CultureInfo.InvariantCulture, "The file {0} does not exists!", filePath));
            }

            TransferUtilityUploadRequest request = new TransferUtilityUploadRequest()
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath
            };

            UploadHelper(request);
        }


        /// <summary>
        /// 	Uploads the contents of the specified stream.  
        /// 	For large uploads, the file will be divided and uploaded in parts using 
        /// 	Amazon S3's multipart API.  The parts will be reassembled as one object in
        /// 	Amazon S3.
        /// </summary>
        /// <param name="stream">
        /// 	The stream to read to obtain the content to upload.
        /// </param>
        /// <param name="bucketName">
        /// 	The target Amazon S3 bucket, that is, the name of the bucket to upload the stream to.
        /// </param>
        /// <param name="key">
        /// 	The key under which the Amazon S3 object is stored.
        /// </param>
        private void UploadHelper(Stream stream, string bucketName, string key)
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException("key");
            }

            TransferUtilityUploadRequest request = new TransferUtilityUploadRequest()
            {
                BucketName = bucketName,
                Key = key,
                InputStream = stream
            };

            UploadHelper(request);
        }

        /// <summary>
        /// 	Uploads the file or stream specified by the request.  
        /// 	To track the progress of the upload,
        /// 	add an event listener to the request's <c>UploadProgressEvent</c>.
        /// 	For large uploads, the file will be divided and uploaded in parts using 
        /// 	Amazon S3's multipart API.  The parts will be reassembled as one object in
        /// 	Amazon S3.
        /// </summary>
        /// <param name="request">
        /// 	Contains all the parameters required to upload to Amazon S3.
        /// </param>
        private void UploadHelper(TransferUtilityUploadRequest request)
        {
            validate(request);
            BaseCommand command;
            if (request.ContentLength < this._config.MinSizeBeforePartUpload)
            {
                command = new SimpleUploadCommand(this._s3Client, this._config, request);
            }
            else
            {
                command = new MultipartUploadCommand(this._s3Client, this._config, request);
            }

            command.Execute();
        }

        static void validate(TransferUtilityUploadRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            if (!request.IsSetBucketName())
            {
                throw new InvalidOperationException("Please specify BucketName to PUT an object into Amazon S3.");
            }

            if (!request.IsSetFilePath() &&
                !request.IsSetInputStream())
            {
                throw new InvalidOperationException(
                    "Please specify either a Filename or provide a Stream to PUT an object into Amazon S3.");
            }
            if (!request.IsSetKey())
            {
                if (request.IsSetFilePath())
                {
                    request.Key = new FileInfo(request.FilePath).Name;
                }
                else
                {
                    throw new ArgumentException(
                        "The Key property must be specified when using a Stream to upload into Amazon S3.");
                }
            }

            if (request.IsSetFilePath() && !File.Exists(request.FilePath))
                throw new ArgumentException("The file indicated by the FilePath property does not exist!");
        }
        #endregion

        #region OpenStream

        private Stream OpenStreamHelper(string bucketName, string key)
        {
            TransferUtilityOpenStreamRequest request = new TransferUtilityOpenStreamRequest()
            {
                BucketName = bucketName,
                Key = key
            };

            return OpenStreamHelper(request);
        }


        private Stream OpenStreamHelper(TransferUtilityOpenStreamRequest request)
        {
            OpenStreamCommand command = new OpenStreamCommand(this._s3Client, request);
            command.Execute();
            return command.ResponseStream;
        }
        #endregion

        #region Download

        private void DownloadHelper(string filePath, string bucketName, string key)
        {
            TransferUtilityDownloadRequest request = new TransferUtilityDownloadRequest()
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath
            };

            DownloadHelper(request);
        }

        private void DownloadHelper(TransferUtilityDownloadRequest request)
        {
            BaseCommand command = new DownloadCommand(this._s3Client, request);
            command.Execute();
        }
        #endregion

        #region DownloadDirectory

        private void DownloadDirectoryHelper(string bucketName, string s3Directory, string localDirectory)
        {
            TransferUtilityDownloadDirectoryRequest request = new TransferUtilityDownloadDirectoryRequest()
            {
                BucketName = bucketName,
                S3Directory = s3Directory,
                LocalDirectory = localDirectory
            };


            DownloadDirectoryHelper(request);
        }

        private void DownloadDirectoryHelper(TransferUtilityDownloadDirectoryRequest request)
        {
            BaseCommand command = new DownloadDirectoryCommand(this._s3Client, request);
            command.Execute();
        }
        #endregion

        #region AbortMultipartUploads

        private void AbortMultipartUploadsHelper(string bucketName, DateTime initiatedDate)
        {
            BaseCommand command = new AbortMultipartUploadsCommand(this._s3Client, bucketName, initiatedDate);
            command.Execute();
        }

        #endregion
    }
}
