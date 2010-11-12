/*******************************************************************************
 *  Copyright 2008-2010 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

namespace Amazon.S3.Transfer
{
    /// <summary>
    /// 	<para>
    /// 	Provides a high level utility for managing transfers to and from Amazon S3.
    /// 	</para>
    /// 	<para>
    /// 	<c>TransferUtility</c> provides a simple API for 
    /// 	uploading content to and downloading content
    /// 	from Amazon S3, and makes extensive use of Amazon S3 multipart uploads to
    /// 	achieve enhanced throughput, performance and reliability. 
    /// 	</para>
    /// 	<para>
    /// 	When uploading large files by specifing files path as opposed to a stream, <c>TransferUtility</c> uses multiple threads to upload
    /// 	multiple parts of a single upload at once. When dealing with large content
    /// 	sizes and high bandwidth, this can have a significant increase on throughput.
    /// 	</para>
    /// </summary>
    /// <remarks>
    /// 	<para>
    /// 	Transfers are stored in memory. If the application is restarted, 
    /// 	previous transfers are no longer accessible.  If needed, clean up any multipart uploads
    /// 	that are incomplete.
    /// 	</para>
    /// </remarks>
    public class TransferUtility : IDisposable
    {
        TransferUtilityConfig _config;
        AmazonS3 _s3Client;
        bool _shouldDispose;

        /// <summary>
        /// 	Constructs a new <see cref="TransferUtility"/> class.
        /// </summary>
        /// <param name="awsAccessKeyId">
        /// 	The AWS Access Key ID.
        /// </param>
        /// <param name="awsSecretAccessKey">
        /// 	The AWS Secret Access Key.
        /// </param>
        public TransferUtility(string awsAccessKeyId, string awsSecretAccessKey)
            : this(new AmazonS3Client(awsAccessKeyId, awsSecretAccessKey))
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
        /// 	The config for setting advances settings.
        /// </param>
        public TransferUtility(string awsAccessKeyId, string awsSecretAccessKey, TransferUtilityConfig config)
            : this(new AmazonS3Client(awsAccessKeyId, awsSecretAccessKey), config)
        {
            this._shouldDispose = true;
        }


        /// <summary>
        /// 	Constructs a new instance of the <see cref="TransferUtility"/> class.
        /// </summary>
        /// <param name="s3Client">
        /// 	The Amazon S3 client.
        /// </param>
        public TransferUtility(AmazonS3 s3Client)
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
        /// 	The advanced configuration settings for <see cref="TransferUtility"/>.
        /// </param>
        public TransferUtility(AmazonS3 s3Client, TransferUtilityConfig config)
        {
            this._s3Client = s3Client;
            this._config = config;
        }


        /// <summary>
        /// 	Disposes resources and performs initiates garbage collection
        /// 	for the <see cref="TransferUtility"/> class.
        /// </summary>
        public void Dispose()
        {
            if (this._shouldDispose)
            {
                this._s3Client.Dispose();
            }
        }

        /// <summary>
        /// 	Gets the Amazon S3 client used for making calls into Amazon S3.
        /// </summary>
        /// <value>
        /// 	The Amazon S3 client used for making calls into Amazon S3.
        /// </value>
        public AmazonS3 S3Client
        {
            get
            {
                return this._s3Client;
            }
        }

        /// <summary>
        /// 	Uploads the files in directory.  The object key is obtained from the file names
        /// 	inside the directory.
        /// 	For large uploads, the file will be divided and uploaded in parts using 
        /// 	Amazon S3's multipart API.  The parts will be reassembled as one object in
        /// 	Amazon S3.
        /// </summary>
        /// <param name="directory">
        /// 	The directory containing files to upload.
        /// </param>
        /// <param name="bucketName">
        /// 	The name of the bucket to upload files to.
        /// </param>
        public void UploadDirectory(string directory, string bucketName)
        {
            TransferUtilityUploadDirectoryRequest request = new TransferUtilityUploadDirectoryRequest()
                .WithBucketName(bucketName)
                .WithDirectory(directory);

            UploadDirectory(request);
        }

        /// <summary>
        /// 	Uploads the files in directory.  The object key is obtained from the file names
        /// 	inside the directory.
        /// 	For large uploads, the file will be divided and uploaded in parts using 
        /// 	Amazon S3's multipart API.  The parts will be reassembled as one object in
        /// 	Amazon S3.
        /// </summary>
        /// <param name="directory">
        /// 	The directory containing files to upload.
        /// </param>
        /// <param name="bucketName">
        /// 	The name of the bucket to upload files to.
        /// </param>
        /// <param name="searchPattern">
        /// 	The pattern used to find files to upload in the directory.
        /// </param>
        /// <param name="searchOption">
        /// 	The search option specifying whether or not to recursively search for files to upload
        /// 	in subdirectories or not.
        /// </param>
        public void UploadDirectory(string directory, string bucketName, string searchPattern, SearchOption searchOption)
        {
            TransferUtilityUploadDirectoryRequest request = new TransferUtilityUploadDirectoryRequest()
                .WithBucketName(bucketName)
                .WithDirectory(directory)
                .WithSearchPattern(searchPattern)
                .WithSearchOption(searchOption);

            UploadDirectory(request);
        }

        /// <summary>
        /// 	Uploads the files in directory.  The object key is obtained from the file names
        /// 	inside the directory.
        /// 	For large uploads, the file will be divided and uploaded in parts using 
        /// 	Amazon S3's multipart API.  The parts will be reassembled as one object in
        /// 	Amazon S3.
        /// </summary>
        /// <param name="request">
        /// 	The request that contains all the parameters to upload a directory.
        /// </param>
        public void UploadDirectory(TransferUtilityUploadDirectoryRequest request)
        {
            if (!request.IsSetDirectory())
            {
                throw new ArgumentNullException("directory");
            }
            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException("bucketName");
            }
            if (!Directory.Exists(request.Directory))
            {
                throw new ArgumentException(string.Format("The directory {0} does not exists!", request.Directory), "directory");
            }

            UploadDirectoryCommand command = new UploadDirectoryCommand(this, request);
            command.Execute();
        }

        /// <summary>
        /// 	Uploads the specified file.  
        /// 	The object key is obtained from the file's file name.
        /// 	Multiple threads are used to read the file and perform multiple uploads in parallel.  
        /// 	For large uploads, the file will be divided and uploaded in parts using 
        /// 	Amazon S3's multipart API.  The parts will be reassembled as one object in
        /// 	Amazon S3.
        /// </summary>
        /// <param name="filePath">
        /// 	The file path of the file to upload.
        /// </param>
        /// <param name="bucketName">
        /// 	The name of the bucket to upload the file to.
        /// </param>
        public void Upload(string filePath, string bucketName)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentNullException("filePath");
            }
            if (!File.Exists(filePath))
            {
                throw new ArgumentException(string.Format("The file {0} does not exists!", filePath));
            }

            TransferUtilityUploadRequest request = new TransferUtilityUploadRequest()
                .WithBucketName(bucketName)
                .WithFilePath(filePath);

            Upload(request);
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
        /// 	The name of the bucket to upload the file to.
        /// </param>
        /// <param name="key">
        /// 	The key under which the Amazon S3 object is stored.
        /// </param>
        public void Upload(string filePath, string bucketName, string key)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentNullException("filePath");
            }
            if (!File.Exists(filePath))
            {
                throw new ArgumentException(string.Format("The file {0} does not exists!", filePath));
            }

            TransferUtilityUploadRequest request = new TransferUtilityUploadRequest()
                .WithBucketName(bucketName)
                .WithKey(key)
                .WithFilePath(filePath);

            Upload(request);
        }

        /// <summary>
        /// 	Uploads the contents of the specified stream.  
        /// 	For large uploads, the file will be divided and uploaded in parts using 
        /// 	Amazon S3's multipart API.  The parts will be reassembled as one object in
        /// 	Amazon S3.
        /// </summary>
        /// <param name="stream">
        /// 	The stream to read to the content of the object.
        /// </param>
        /// <param name="bucketName">
        /// 	The name of the bucket to upload the stream to.
        /// </param>
        /// <param name="key">
        /// 	The key under which the Amazon S3 object is stored.
        /// </param>
        public void Upload(Stream stream, string bucketName, string key)
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
                .WithBucketName(bucketName)
                .WithKey(key);
            request.InputStream = stream;               

            Upload(request);
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
        /// 	Contains all the parameters used for uploading to Amazon S3.
        /// </param>
        public void Upload(TransferUtilityUploadRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException("request");
            }

            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException("bucketName");
            }

            if (!request.IsSetFilePath() &&
                !request.IsSetInputStream())
            {
                throw new ArgumentException(
                    "Please specify either a Filename or provide a Stream to PUT an object into S3.");
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
                        "The Key property must be specified when using a Stream to upload into S3.");
                }
            }

            if (request.IsSetFilePath() && !File.Exists(request.FilePath))
                throw new ArgumentException("The file indicated by the FilePath property does not exist!");


            if (request.ContentLength < this._config.MinSizeBeforePartUpload)
            {
                SimpleUploadCommand uploader = new SimpleUploadCommand(this._s3Client, this._config, request);
                uploader.Execute();
            }
            else
            {
                MultipartUploadCommand uploader = new MultipartUploadCommand(this._s3Client, this._config, request);
                uploader.Execute();
            }
        }


        /// <summary>
        /// 	Returns a stream to read the contents from Amazon S3 as 
        /// 	specified by bucket name and key.
        /// 	The caller of this method is responsible for closing the stream.
        /// </summary>
        /// <param name="bucketName">
        /// 	The name of the bucket.
        /// </param>
        /// <param name="key">
        /// 	The object key.
        /// </param>
        /// <returns>
        /// 	A stream containing contents returned from Amazon S3.
        /// </returns>
        public Stream OpenStream(string bucketName, string key)
        {
            TransferUtilityOpenStreamRequest request = new TransferUtilityOpenStreamRequest()
                .WithBucketName(bucketName)
                .WithKey(key);

            return OpenStream(request);
        }

        /// <summary>
        /// 	Returns a stream to read the contents from Amazon S3 as 
        /// 	specified by the <c>TransferUtilityOpenStreamRequest</c>.
        /// 	The caller of this method is responsible for closing the stream.
        /// </summary>
        /// <param name="request">
        /// 	Contains all the parameters used for opening a stream to an S3 object.
        /// </param>
        /// <returns>
        /// 	A stream containing contents returned from Amazon S3.
        /// </returns>
        public Stream OpenStream(TransferUtilityOpenStreamRequest request)
        {
            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException("bucketName", "The bucketName Specified is null or empty!");
            }
            if (!request.IsSetKey())
            {
                throw new ArgumentNullException("key", "The key Specified is null or empty!");
            }

            GetObjectRequest getRequest = convertToGetObjectRequest(request);
            GetObjectResponse response = this._s3Client.GetObject(getRequest);
            return response.ResponseStream;
        }

        /// <summary>
        /// 	Downloads the content from Amazon S3 and writes it to the specified file.  
        /// 	The object key is obtained from the file's file name.
        /// </summary>
        /// <param name="filePath">
        /// 	The file path where the content from Amazon S3 will be written to.
        /// </param>
        /// <param name="bucketName">
        /// 	The name of the bucket containing the Amazon S3 object to download.
        /// </param>
        /// <param name="key">
        /// 	The key under which the Amazon S3 object is stored.
        /// </param>
        public void Download(string filePath, string bucketName, string key)
        {
            TransferUtilityDownloadRequest request = new TransferUtilityDownloadRequest()
                .WithBucketName(bucketName)
                .WithKey(key)
                .WithFilePath(filePath);

            Download(request);
        }

        /// <summary>
        /// 	Downloads the content from Amazon S3 and writes it to the specified file.    
        /// 	If the key is not specified in the request parameter,
        /// 	the file name will be assumed.
        /// </summary>
        /// <param name="request">
        /// 	Contains all the parameters used to download an Amazon S3 object.
        /// </param>
        public void Download(TransferUtilityDownloadRequest request)
        {
            if (!request.IsSetBucketName())
            {
                throw new ArgumentNullException("bucketName", "The bucketName Specified is null or empty!");
            }
            if (!request.IsSetFilePath())
            {
                throw new ArgumentNullException("filePath", "The filepath Specified is null or empty!");
            }
            if (!request.IsSetKey())
            {
                throw new ArgumentNullException("key", "The Key Specified is null or empty!");
            }

            GetObjectRequest getRequest = convertToGetObjectRequest(request);
            GetObjectResponse response = this._s3Client.GetObject(getRequest);
            response.WriteObjectProgressEvent += request.EventHandler;

            response.WriteResponseStreamToFile(request.FilePath);
        }

        /// <summary>
        /// 	Aborts the multipart uploads that were initiated before the specified date.
        /// </summary>
        /// <param name="bucketName">
        /// 	The name of the bucket containing multipart uploads.
        /// </param>
        /// <param name="initiatedDate">
        /// 	The date before which the multipart uploads were initiated.
        /// </param>
        public void AbortMultipartUploads(string bucketName, DateTime initiatedDate)
        {
            if (string.IsNullOrEmpty(bucketName))
            {
                throw new ArgumentNullException("bucketName", "The bucketName Specified is null or empty!");
            }

            ListMultipartUploadsResponse listResponse = new ListMultipartUploadsResponse();
            do
            {
                ListMultipartUploadsRequest listRequest = new ListMultipartUploadsRequest()
                    .WithBucketName(bucketName)
                    .WithKeyMarker(listResponse.KeyMarker)
                    .WithUploadIdMarker(listResponse.NextUploadIdMarker);

                listResponse = this._s3Client.ListMultipartUploads(listRequest);
                foreach (MultipartUpload upload in listResponse.MultipartUploads)
                {
                    if (upload.Initiated < initiatedDate)
                    {
                        this._s3Client.AbortMultipartUpload(new AbortMultipartUploadRequest()
                            .WithBucketName(bucketName)
                            .WithKey(upload.Key)
                            .WithUploadId(upload.UploadId));
                    }
                }
            }
            while (listResponse.IsTruncated);
        }

        private GetObjectRequest convertToGetObjectRequest(BaseDownloadRequest request)
        {
            GetObjectRequest getRequest = new GetObjectRequest()
                .WithBucketName(request.BucketName)
                .WithKey(request.Key)
                .WithTimeout(request.Timeout)
                .WithVersionId(request.VersionId)
                .WithModifiedSinceDate(request.ModifiedSinceDate)
                .WithUnmodifiedSinceDate(request.UnmodifiedSinceDate);

            return getRequest;
        }
    }
}
