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
    /// 	previous transfers are no longer accessible.  In this situation, if necessary, 
    /// 	you should clean up any multipart uploads	that are incomplete.
    /// 	</para>
    /// </remarks>
    public class TransferUtility : IDisposable
    {
        TransferUtilityConfig _config;
        AmazonS3 _s3Client;
        bool _shouldDispose;

        #region Constructors
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
            : this(new AmazonS3Client(awsAccessKeyId, awsSecretAccessKey, RegionEndpoint.USEast1))
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
        public TransferUtility(string awsAccessKeyId, string awsSecretAccessKey, TransferUtilityConfig config)
            : this(awsAccessKeyId, awsSecretAccessKey, RegionEndpoint.USEast1, config)
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
        /// 	Specifies advanced configuration settings for <see cref="TransferUtility"/>.
        /// </param>
        public TransferUtility(AmazonS3 s3Client, TransferUtilityConfig config)
        {
            this._s3Client = s3Client;
            this._config = config;
        }


        /// <summary>
        /// 	Disposes of resources and initiates garbage collection
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
        #endregion

        #region UploadDirectory

        /// <summary>
        /// Initiates the asynchronous execution of the UploadDirectory operation. 
        /// <seealso cref="M:Amazon.S3.Transfer.TransferUtility.UploadDirectory"/>
        /// </summary>
        /// <param name="directory">
        /// 	The source directory, that is, the directory containing the files to upload.
        /// </param>
        /// <param name="bucketName">
        /// 	The target Amazon S3 bucket, that is, the name of the bucket to upload the files to.
        /// </param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. 
				/// Retrieve this object from within the callback procedure using the AsyncState property.
				/// </param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll, or wait for results, or both. 
        /// This value is also needed when invoking EndUploadDirectory.</returns>
        public IAsyncResult BeginUploadDirectory(string directory, string bucketName, AsyncCallback callback, object state)
        {
            TransferUtilityUploadDirectoryRequest request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
                Directory = directory
            };
            return BeginUploadDirectory(request, callback, state);
        }

        /// <summary>
        /// 	Uploads files from a specified directory.  
				/// 	The object key is derived from the file names
        /// 	inside the directory.
        /// 	For large uploads, the file will be divided and uploaded in parts using 
        /// 	Amazon S3's multipart API.  The parts will be reassembled as one object in
        /// 	Amazon S3.
        /// </summary>
        /// <param name="directory">
        /// 	The source directory, that is, the directory containing the files to upload.
        /// </param>
        /// <param name="bucketName">
        /// 	The target Amazon S3 bucket, that is, the name of the bucket to upload the files to.
        /// </param>
        public void UploadDirectory(string directory, string bucketName)
        {
            TransferUtilityUploadDirectoryRequest request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
                Directory = directory
            };
            UploadDirectory(request);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UploadDirectory operation. 
        /// <seealso cref="M:Amazon.S3.Transfer.TransferUtility.UploadDirectory"/>
        /// </summary>
        /// <param name="directory">
        /// 	The source directory, that is, the directory containing the files to upload.
        /// </param>
        /// <param name="bucketName">
        /// 	The target Amazon S3 bucket, that is, the name of the bucket to upload the files to.
        /// </param>
        /// <param name="searchPattern">
        /// 	A pattern used to identify the files from the source directory to upload.
        /// </param>
        /// <param name="searchOption">
        /// 	A search option that specifies whether to recursively search for files to upload
        /// 	in subdirectories.
        /// </param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll, or wait for results, or both. 
        /// This value is also needed when invoking EndUploadDirectory.</returns>
        public IAsyncResult BeginUploadDirectory(string directory, string bucketName, string searchPattern, SearchOption searchOption, AsyncCallback callback, object state)
        {
            TransferUtilityUploadDirectoryRequest request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
                Directory = directory,
                SearchPattern = searchPattern,
                SearchOption = searchOption
            };

            return BeginUploadDirectory(request, callback, state);
        }

        /// <summary>
        /// 	Uploads files from a specified directory.  
				/// 	The object key is derived from the file names
        /// 	inside the directory.
        /// 	For large uploads, the file will be divided and uploaded in parts using 
        /// 	Amazon S3's multipart API.  The parts will be reassembled as one object in
        /// 	Amazon S3.
        /// </summary>
        /// <param name="directory">
        /// 	The source directory, that is, the directory containing the files to upload.
        /// </param>
        /// <param name="bucketName">
        /// 	The target Amazon S3 bucket, that is, the name of the bucket to upload the files to.
        /// </param>
        /// <param name="searchPattern">
        /// 	A pattern used to identify the files from the source directory to upload.
        /// </param>                                                                 
        /// <param name="searchOption">
        /// 	A search option that specifies whether to recursively search for files to upload
        /// 	in subdirectories.
        /// </param>
        public void UploadDirectory(string directory, string bucketName, string searchPattern, SearchOption searchOption)
        {
            TransferUtilityUploadDirectoryRequest request = new TransferUtilityUploadDirectoryRequest
            {
                BucketName = bucketName,
                Directory = directory,
                SearchPattern = searchPattern,
                SearchOption = searchOption
            };
            UploadDirectory(request);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UploadDirectory operation. 
        /// <seealso cref="M:Amazon.S3.Transfer.TransferUtility.UploadDirectory"/>
        /// </summary>
        /// <param name="request">
        /// 	The request that contains all the parameters required to upload a directory.
        /// </param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll, or wait for results, or both. 
        /// This value is also needed when invoking EndUploadDirectory.</returns>
        public IAsyncResult BeginUploadDirectory(TransferUtilityUploadDirectoryRequest request, AsyncCallback callback, object state)
        {
            validate(request);
            UploadDirectoryCommand command = new UploadDirectoryCommand(this, request);
            return beginOperation(command, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the UploadDirectory operation.
        /// <seealso cref="M:Amazon.S3.Transfer.TransferUtility.UploadDirectory"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUploadDirectory.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public void EndUploadDirectory(IAsyncResult asyncResult)
        {
            endOperation(asyncResult);
        }

        /// <summary>
        /// 	Uploads files from a specified directory.  
				/// 	The object key is derived from the file names
        /// 	inside the directory.
        /// 	For large uploads, the file will be divided and uploaded in parts using 
        /// 	Amazon S3's multipart API.  The parts will be reassembled as one object in
        /// 	Amazon S3.
        /// </summary>
        /// <param name="request">
        /// 	The request that contains all the parameters required to upload a directory.
        /// </param>
        public void UploadDirectory(TransferUtilityUploadDirectoryRequest request)
        {
            validate(request);
            UploadDirectoryCommand command = new UploadDirectoryCommand(this, request);
            command.Execute();
        }

        void validate(TransferUtilityUploadDirectoryRequest request)
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
        }

        #endregion

        #region Upload

        /// <summary>
        /// Initiates the asynchronous execution of the Upload operation. 
        /// <seealso cref="M:Amazon.S3.Transfer.TransferUtility.Upload"/>
        /// </summary>
        /// <param name="filePath">
        /// 	The file path of the file to upload.
        /// </param>
        /// <param name="bucketName">
        /// 	The target Amazon S3 bucket, that is, the name of the bucket to upload the file to.
        /// </param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll, or wait for results, or both. 
        /// This values is also needed when invoking EndUpload.</returns>
        public IAsyncResult BeginUpload(string filePath, string bucketName, AsyncCallback callback, object state)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentNullException("filePath");
            }
            if (!File.Exists(filePath))
            {
                throw new ArgumentException(string.Format("The file {0} does not exists!", filePath));
            }

            TransferUtilityUploadRequest request = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                FilePath = filePath
            };

            return BeginUpload(request, callback, state);
        }

        /// <summary>
        /// 	Uploads the specified file.  
        /// 	The object key is derived from the file's name.
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

            TransferUtilityUploadRequest request = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                FilePath = filePath
            };

            Upload(request);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Upload operation. 
        /// <seealso cref="M:Amazon.S3.Transfer.TransferUtility.Upload"/>
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
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll, or wait for results, or both. 
        /// This values is also needed when invoking EndUpload.</returns>
        public IAsyncResult BeginUpload(string filePath, string bucketName, string key, AsyncCallback callback, object state)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                throw new ArgumentNullException("filePath");
            }
            if (!File.Exists(filePath))
            {
                throw new ArgumentException(string.Format("The file {0} does not exists!", filePath));
            }

            TransferUtilityUploadRequest request = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath
            };

            return BeginUpload(request, callback, state);
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

            TransferUtilityUploadRequest request = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath
            };

            Upload(request);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Upload operation. 
        /// <seealso cref="M:Amazon.S3.Transfer.TransferUtility.Upload"/>
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
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll, or wait for results, or both. 
        /// This values is also needed when invoking EndUpload.</returns>
        public IAsyncResult BeginUpload(Stream stream, string bucketName, string key, AsyncCallback callback, object state)
        {
            if (stream == null)
            {
                throw new ArgumentNullException("stream");
            }
            if (string.IsNullOrEmpty(key))
            {
                throw new ArgumentNullException("key");
            }

            TransferUtilityUploadRequest request = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = key
            };
            request.InputStream = stream;

            return BeginUpload(request, callback, state);
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

            TransferUtilityUploadRequest request = new TransferUtilityUploadRequest
            {
                BucketName = bucketName,
                Key = key
            };
            request.InputStream = stream;               

            Upload(request);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Upload operation. 
        /// <seealso cref="M:Amazon.S3.Transfer.TransferUtility.Upload"/>
        /// </summary>
        /// <param name="request">
        /// 	Contains all the parameters required to upload to Amazon S3.
        /// </param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll, or wait for results, or both. 
        /// This values is also needed when invoking EndUpload.</returns>
        public IAsyncResult BeginUpload(TransferUtilityUploadRequest request, AsyncCallback callback, object state)
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

            return beginOperation(command, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the Upload operation.
        /// <seealso cref="M:Amazon.S3.Transfer.TransferUtility.UploadDirectory"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpload.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public void EndUpload(IAsyncResult asyncResult)
        {
            endOperation(asyncResult);
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
        public void Upload(TransferUtilityUploadRequest request)
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

        void validate(TransferUtilityUploadRequest request)
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

        /// <summary>
        /// Initiates the asynchronous execution of the OpenStream operation. 
        /// <seealso cref="M:Amazon.S3.Transfer.TransferUtility.Upload"/>
        /// </summary>
        /// <param name="bucketName">
        /// 	The name of the bucket.
        /// </param>
        /// <param name="key">
        /// 	The object key.
        /// </param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll, or wait for results, or both. 
        /// This values is also needed when invoking EndOpenStream.</returns>
        public IAsyncResult BeginOpenStream(string bucketName, string key, AsyncCallback callback, object state)
        {
            TransferUtilityOpenStreamRequest request = new TransferUtilityOpenStreamRequest
            {
                BucketName = bucketName,
                Key = key
            };

            return BeginOpenStream(request, callback, state);
        }

        /// <summary>
        /// 	Returns a stream from which the caller can read the content from the specified
				/// 	Amazon S3  bucket and key.
        /// 	The caller of this method is responsible for closing the stream.
        /// </summary>
        /// <param name="bucketName">
        /// 	The name of the bucket.
        /// </param>
        /// <param name="key">
        /// 	The object key.
        /// </param>
        /// <returns>
        /// 	A stream of the contents from the specified Amazon S3 and key.
        /// </returns>
        public Stream OpenStream(string bucketName, string key)
        {
            TransferUtilityOpenStreamRequest request = new TransferUtilityOpenStreamRequest
            {
                BucketName = bucketName,
                Key = key
            };

            return OpenStream(request);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the OpenStream operation. 
        /// <seealso cref="M:Amazon.S3.Transfer.TransferUtility.Upload"/>
        /// </summary>
        /// <param name="request">
        /// 	Contains all the parameters required to open a stream to an Amazon S3 object.
        /// </param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll, or wait for results, or both. 
        /// This values is also needed when invoking EndOpenStream.</returns>
        public IAsyncResult BeginOpenStream(TransferUtilityOpenStreamRequest request, AsyncCallback callback, object state)
        {
            OpenStreamCommand command = new OpenStreamCommand(this._s3Client, request);
            return beginOperation(command, callback, state);
        }

        /// <summary>
        /// 	Returns a stream to read the contents from Amazon S3 as 
        /// 	specified by the <c>TransferUtilityOpenStreamRequest</c>.
        /// 	The caller of this method is responsible for closing the stream.
        /// </summary>
        /// <param name="request">
        /// 	Contains all the parameters required to open a stream to an S3 object.
        /// </param>
        /// <returns>
        /// 	A stream of the contents from Amazon S3.
        /// </returns>
        public Stream OpenStream(TransferUtilityOpenStreamRequest request)
        {
            OpenStreamCommand command = new OpenStreamCommand(this._s3Client, request);
            command.Execute();
            return command.ResponseStream;
        }

        public Stream EndOpenStream(IAsyncResult result)
        {
            return endOperation(result) as Stream;
        }

        #endregion

        #region Download

        /// <summary>
        /// Initiates the asynchronous execution of the Download operation. 
        /// <seealso cref="M:Amazon.S3.Transfer.TransferUtility.Download"/>
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
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll, or wait for results, or both. 
        /// This values is also needed when invoking EndDownload.</returns>
        public IAsyncResult BeginDownload(string filePath, string bucketName, string key, AsyncCallback callback, object state)
        {
            TransferUtilityDownloadRequest request = new TransferUtilityDownloadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath
            };

            return BeginDownload(request, callback, state);
        }

        /// <summary>
        /// 	Downloads the content from Amazon S3 and writes it to the specified file.  
        /// 	The object key is derived from the file name.
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
            TransferUtilityDownloadRequest request = new TransferUtilityDownloadRequest
            {
                BucketName = bucketName,
                Key = key,
                FilePath = filePath
            };

            Download(request);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Download operation. 
        /// <seealso cref="M:Amazon.S3.Transfer.TransferUtility.Download"/>
        /// </summary>
        /// <param name="request">
        /// 	Contains all the parameters required to download an Amazon S3 object.
        /// </param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll, or wait for results, or both. 
        /// This values is also needed when invoking EndDownload.</returns>
        public IAsyncResult BeginDownload(TransferUtilityDownloadRequest request, AsyncCallback callback, object state)
        {
            BaseCommand command = new DownloadCommand(this._s3Client, request);
            return beginOperation(command, callback, state);

        }

        /// <summary>
        /// 	Downloads the content from Amazon S3 and writes it to the specified file.    
        /// 	If the key is not specified in the request parameter,
        /// 	the file name will used as the key name.
        /// </summary>
        /// <param name="request">
        /// 	Contains all the parameters required to download an Amazon S3 object.
        /// </param>
        public void Download(TransferUtilityDownloadRequest request)
        {
            BaseCommand command = new DownloadCommand(this._s3Client, request);
            command.Execute();
        }

        /// <summary>
        /// Finishes the asynchronous execution of the Download operation.
        /// <seealso cref="M:Amazon.S3.Transfer.TransferUtility.Download"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDownload.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public void EndDownload(IAsyncResult asyncResult)
        {
            endOperation(asyncResult);
        }



        #endregion

        #region Download Directory
        /// <summary>
        /// Initiates the asynchronous execution of the DownloadDirectory operation. 
        /// <seealso cref="M:Amazon.S3.Transfer.TransferUtility.DownloadDirectory"/>
        /// </summary>
        /// <param name="bucketName">
        /// 	The name of the bucket containing the Amazon S3 objects to download.
        /// </param>
        /// <param name="s3Directory">
        /// 	The directory in Amazon S3 to download.
        /// </param>
        /// <param name="localDirectory">
        /// 	The local directory to download the objects to.
        /// </param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll, or wait for results, or both. 
        /// This values is also needed when invoking EndDownloadDirectory.</returns>
        public IAsyncResult BeginDownloadDirectory(string bucketName, string s3Directory, string localDirectory, AsyncCallback callback, object state)
        {
            TransferUtilityDownloadDirectoryRequest request = new TransferUtilityDownloadDirectoryRequest
            {
                BucketName = bucketName,
                S3Directory = s3Directory,
                LocalDirectory = localDirectory
            };

            return BeginDownloadDirectory(request, callback, state);
        }

        /// <summary>
        /// 	Downloads the objects in Amazon S3 that have a key that starts with the value 
				/// 	specified by <c>s3Directory</c>.
        /// </summary>
        /// <param name="bucketName">
        /// 	The name of the bucket containing the Amazon S3 objects to download.
        /// </param>
        /// <param name="s3Directory">
        /// 	The directory in Amazon S3 to download.
        /// </param>
        /// <param name="localDirectory">
        /// 	The local directory to download the objects to.
        /// </param>
        public void DownloadDirectory(string bucketName, string s3Directory, string localDirectory)
        {
            TransferUtilityDownloadDirectoryRequest request = new TransferUtilityDownloadDirectoryRequest
            {
                BucketName = bucketName,
                S3Directory = s3Directory,
                LocalDirectory = localDirectory
            };


            DownloadDirectory(request);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DownloadDirectory operation. 
        /// <seealso cref="M:Amazon.S3.Transfer.TransferUtility.DownloadDirectory"/>
        /// </summary>
        /// <param name="request">
        /// 	Contains all the parameters required to download objects from a directory in Amazon S3 
				/// 	to a local directory.
        /// </param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll, or wait for results, or both. 
        /// This values is also needed when invoking EndDownload.</returns>
        public IAsyncResult BeginDownloadDirectory(TransferUtilityDownloadDirectoryRequest request, AsyncCallback callback, object state)
        {
            BaseCommand command = new DownloadDirectoryCommand(this._s3Client, request);
            return beginOperation(command, callback, state);

        }

        /// <summary>
        /// 	Downloads the objects in Amazon S3 that have a key that starts with the value 
		/// 	specified by the <c>S3Directory</c>
        /// 	property of the passed in <c>TransferUtilityDownloadDirectoryRequest</c> object.
        /// </summary>
        /// <param name="request">
        /// 	Contains all the parameters required to download objects from Amazon S3 
		/// 	into a local directory.
        /// </param>
        public void DownloadDirectory(TransferUtilityDownloadDirectoryRequest request)
        {
            BaseCommand command = new DownloadDirectoryCommand(this._s3Client, request);
            command.Execute();
        }

        /// <summary>
        /// Finishes the asynchronous execution of the DownloadDirectory operation.
        /// <seealso cref="M:Amazon.S3.Transfer.TransferUtility.Download"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDownloadDirectory.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public void EndDownloadDirectory(IAsyncResult asyncResult)
        {
            endOperation(asyncResult);
        }
        #endregion

        #region AbortMultipartUploads

        /// <summary>
        /// Initiates the asynchronous execution of the AbortMultipartUploads operation. 
        /// <seealso cref="M:Amazon.S3.Transfer.TransferUtility.AbortMultipartUploads"/>
        /// </summary>
        /// <param name="bucketName">
        /// 	The name of the bucket containing multipart uploads.
        /// </param>
        /// <param name="initiatedDate">
        /// 	The date before which the multipart uploads were initiated.
        /// </param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback procedure using the AsyncState property.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        /// <returns>An IAsyncResult that can be used to poll, or wait for results, or both. 
        /// This values is also needed when invoking EndAbortMultipartUploads.</returns>
        public IAsyncResult BeginAbortMultipartUploads(string bucketName, DateTime initiatedDate, AsyncCallback callback, object state)
        {
            BaseCommand command = new AbortMultipartUploadsCommand(this._s3Client, bucketName, initiatedDate);
            return beginOperation(command, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the AbortMultipartUploads operation.
        /// <seealso cref="M:Amazon.S3.Transfer.TransferUtility.AbortMultipartUploads"/>
        /// </summary>
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAbortMultipartUploads.</param>
        /// <exception cref="T:System.ArgumentNullException"></exception>
        /// <exception cref="T:System.Net.WebException"></exception>
        /// <exception cref="T:Amazon.S3.AmazonS3Exception"></exception>
        public void EndAbortMultipartUploads(IAsyncResult asyncResult)
        {
            endOperation(asyncResult);
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
            BaseCommand command = new AbortMultipartUploadsCommand(this._s3Client, bucketName, initiatedDate);
            command.Execute();
        }

        #endregion

        #region Private Methods

        IAsyncResult beginOperation(BaseCommand command, AsyncCallback callback, object state)
        {
            TransferAsyncResult result = new TransferAsyncResult(callback, state);

            Executer exe = new Executer(result, command);
            ThreadPool.QueueUserWorkItem(s => exe.Execute());

            return result;
        }

        object endOperation(IAsyncResult result)
        {
            TransferAsyncResult transferAsyncResult = result as TransferAsyncResult;
            if (transferAsyncResult == null)
                return null;

            if (!transferAsyncResult.CompletedSynchronously)
            {
                WaitHandle.WaitAll(new WaitHandle[] { transferAsyncResult.AsyncWaitHandle });
            }

            if (transferAsyncResult.LastException != null)
            {
                AWSSDKUtils.PreserveStackTrace(transferAsyncResult.LastException);
                throw transferAsyncResult.LastException;
            }

            return transferAsyncResult.Return;
        }

        #endregion
    }
}
