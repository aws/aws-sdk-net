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
using System.Threading.Tasks;

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
    public partial class TransferUtility : IDisposable
    {

        #region UploadDirectory
        /// <summary>
        /// Initiates the asynchronous execution of the UploadDirectory operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.AbortMultipartUpload"/>
        /// </summary>
        /// <remarks>
        /// <para>
        /// If you are uploading large files, TransferUtility will use multipart upload to fulfill the request. 
        /// If a multipart upload is interrupted, TransferUtility will attempt to abort the multipart upload. 
        /// Under certain circumstances (network outage, power failure, etc.), TransferUtility will not be able 
        /// to abort the multipart upload. In this case, in order to stop getting charged for the storage of uploaded parts,
        /// you should manually invoke TransferUtility.AbortMultipartUploads() to abort the incomplete multipart uploads.
        /// </para>
        /// </remarks>
        /// <param name="directory">
        /// 	The source directory, that is, the directory containing the files to upload.
        /// </param>
        /// <param name="bucketName">
        /// 	The target Amazon S3 bucket, that is, the name of the bucket to upload the files to.
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task UploadDirectoryAsync(string directory, string bucketName, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ExecuteAsync(() => UploadDirectoryHelper(directory, bucketName), cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UploadDirectory operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.AbortMultipartUpload"/>
        /// </summary>
        /// <remarks>
        /// <para>
        /// If you are uploading large files, TransferUtility will use multipart upload to fulfill the request. 
        /// If a multipart upload is interrupted, TransferUtility will attempt to abort the multipart upload. 
        /// Under certain circumstances (network outage, power failure, etc.), TransferUtility will not be able 
        /// to abort the multipart upload. In this case, in order to stop getting charged for the storage of uploaded parts,
        /// you should manually invoke TransferUtility.AbortMultipartUploads() to abort the incomplete multipart uploads.
        /// </para>
        /// </remarks>
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task UploadDirectoryAsync(string directory, string bucketName, string searchPattern, SearchOption searchOption, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ExecuteAsync(() => UploadDirectoryHelper(directory, bucketName, searchPattern, searchOption), cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UploadDirectory operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.AbortMultipartUpload"/>
        /// </summary>
        /// <remarks>
        /// <para>
        /// If you are uploading large files, TransferUtility will use multipart upload to fulfill the request. 
        /// If a multipart upload is interrupted, TransferUtility will attempt to abort the multipart upload. 
        /// Under certain circumstances (network outage, power failure, etc.), TransferUtility will not be able 
        /// to abort the multipart upload. In this case, in order to stop getting charged for the storage of uploaded parts,
        /// you should manually invoke TransferUtility.AbortMultipartUploads() to abort the incomplete multipart uploads.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// 	The request that contains all the parameters required to upload a directory.
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task UploadDirectoryAsync(TransferUtilityUploadDirectoryRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ExecuteAsync(() => UploadDirectoryHelper(request), cancellationToken);
        }

        #endregion

        #region Upload
        /// <summary>
        /// Initiates the asynchronous execution of the Upload operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.AbortMultipartUpload"/>
        /// </summary>
        /// <remarks>
        /// <para>
        /// If you are uploading large files, TransferUtility will use multipart upload to fulfill the request. 
        /// If a multipart upload is interrupted, TransferUtility will attempt to abort the multipart upload. 
        /// Under certain circumstances (network outage, power failure, etc.), TransferUtility will not be able 
        /// to abort the multipart upload. In this case, in order to stop getting charged for the storage of uploaded parts,
        /// you should manually invoke TransferUtility.AbortMultipartUploads() to abort the incomplete multipart uploads.
        /// </para>
        /// </remarks>
        /// <param name="filePath">
        /// 	The file path of the file to upload.
        /// </param>
        /// <param name="bucketName">
        /// 	The target Amazon S3 bucket, that is, the name of the bucket to upload the file to.
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task UploadAsync(string filePath, string bucketName, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ExecuteAsync(() => UploadHelper(filePath, bucketName), cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Upload operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.AbortMultipartUpload"/>
        /// </summary>
        /// <remarks>
        /// <para>
        /// If you are uploading large files, TransferUtility will use multipart upload to fulfill the request. 
        /// If a multipart upload is interrupted, TransferUtility will attempt to abort the multipart upload. 
        /// Under certain circumstances (network outage, power failure, etc.), TransferUtility will not be able 
        /// to abort the multipart upload. In this case, in order to stop getting charged for the storage of uploaded parts,
        /// you should manually invoke TransferUtility.AbortMultipartUploads() to abort the incomplete multipart uploads.
        /// </para>
        /// </remarks>
        /// <param name="filePath">
        /// 	The file path of the file to upload.
        /// </param>
        /// <param name="bucketName">
        /// 	The target Amazon S3 bucket, that is, the name of the bucket to upload the file to.
        /// </param>
        /// <param name="key">
        /// 	The key under which the Amazon S3 object is stored.
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task UploadAsync(string filePath, string bucketName, string key, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ExecuteAsync(() => UploadHelper(filePath, bucketName, key), cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Upload operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.AbortMultipartUpload"/>
        /// </summary>
        /// <remarks>
        /// <para>
        /// If you are uploading large files, TransferUtility will use multipart upload to fulfill the request. 
        /// If a multipart upload is interrupted, TransferUtility will attempt to abort the multipart upload. 
        /// Under certain circumstances (network outage, power failure, etc.), TransferUtility will not be able 
        /// to abort the multipart upload. In this case, in order to stop getting charged for the storage of uploaded parts,
        /// you should manually invoke TransferUtility.AbortMultipartUploads() to abort the incomplete multipart uploads.
        /// </para>
        /// </remarks>
        /// <param name="stream">
        /// 	The stream to read to obtain the content to upload.
        /// </param>
        /// <param name="bucketName">
        /// 	The target Amazon S3 bucket, that is, the name of the bucket to upload the stream to.
        /// </param>
        /// <param name="key">
        /// 	The key under which the Amazon S3 object is stored.
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task UploadAsync(Stream stream, string bucketName, string key, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ExecuteAsync(() => UploadHelper(stream, bucketName, key), cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Upload operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.AbortMultipartUpload"/>
        /// </summary>
        /// <remarks>
        /// <para>
        /// If you are uploading large files, TransferUtility will use multipart upload to fulfill the request. 
        /// If a multipart upload is interrupted, TransferUtility will attempt to abort the multipart upload. 
        /// Under certain circumstances (network outage, power failure, etc.), TransferUtility will not be able 
        /// to abort the multipart upload. In this case, in order to stop getting charged for the storage of uploaded parts,
        /// you should manually invoke TransferUtility.AbortMultipartUploads() to abort the incomplete multipart uploads.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// 	Contains all the parameters required to upload to Amazon S3.
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task UploadAsync(TransferUtilityUploadRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ExecuteAsync(() => UploadHelper(request), cancellationToken);
        }
        #endregion

        #region OpenStream
        /// <summary>
        /// Initiates the asynchronous execution of the OpenStream operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.AbortMultipartUpload"/>
        /// </summary>
        /// <param name="bucketName">
        /// 	The name of the bucket.
        /// </param>
        /// <param name="key">
        /// 	The object key.
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<Stream> OpenStreamAsync(string bucketName, string key, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ExecuteAsync<Stream>(() => OpenStreamHelper(bucketName, key), cancellationToken);
        }

        #endregion

        #region Download
        /// <summary>
        /// Initiates the asynchronous execution of the Download operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.AbortMultipartUpload"/>
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task DownloadAsync(string filePath, string bucketName, string key, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ExecuteAsync(() => DownloadHelper(filePath, bucketName, key), cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the Download operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.AbortMultipartUpload"/>
        /// </summary>
        /// <param name="request">
        /// 	Contains all the parameters required to download an Amazon S3 object.
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task DownloadAsync(TransferUtilityDownloadRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ExecuteAsync(() => DownloadHelper(request), cancellationToken);
        }

        #endregion

        #region DownloadDirectory
        /// <summary>
        /// Initiates the asynchronous execution of the DownloadDirectory operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.AbortMultipartUpload"/>
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task DownloadDirectoryAsync(string bucketName, string s3Directory, string localDirectory, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ExecuteAsync(() => DownloadDirectoryHelper(bucketName, s3Directory, localDirectory), cancellationToken);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DownloadDirectory operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.AbortMultipartUpload"/>
        /// </summary>
        /// <param name="request">
        /// 	Contains all the parameters required to download objects from Amazon S3 
        /// 	into a local directory.
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task DownloadDirectoryAsync(TransferUtilityDownloadDirectoryRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ExecuteAsync(() => DownloadDirectoryHelper(request), cancellationToken);
        }
        #endregion

        #region AbortMultipartUploads
        /// <summary>
        /// Initiates the asynchronous execution of the AbortMultipartUploads operation.
        /// <seealso cref="Amazon.S3.IAmazonS3.AbortMultipartUpload"/>
        /// </summary>
        /// <param name="bucketName">
        /// 	The name of the bucket containing multipart uploads.
        /// </param>
        /// <param name="initiatedDate">
        /// 	The date before which the multipart uploads were initiated.
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task AbortMultipartUploadsAsync(string bucketName, DateTime initiatedDate, CancellationToken cancellationToken = default(CancellationToken))
        {
            return ExecuteAsync(() => AbortMultipartUploadsHelper(bucketName, initiatedDate), cancellationToken);
        }
        #endregion

        #region Private methods

        private static Task ExecuteAsync(Action action, CancellationToken cancellationToken)
        {
            return ExecuteAsync<object>(() =>
            {
                action();
                return null;
            }, cancellationToken);
        }

        private static Task<T> ExecuteAsync<T>(Func<T> action, CancellationToken cancellationToken)
        {
            return Task<T>.Run(() =>
            {
                Exception exception = null;
                T result = default(T);
                Thread thread = new Thread(() => 
                    {
                        try
                        {
                            result = action();
                        }
                        catch (Exception e)
                        {
                            exception = e;
                        }
                    });
                if (cancellationToken != null)
                {
                    cancellationToken.Register(() =>
                    {
                        if (thread.IsAlive)
                            thread.Abort();
                    });
                }

                thread.Start();
                thread.Join();

                if (exception != null)
                {
                    cancellationToken.ThrowIfCancellationRequested();
                    throw exception;
                }

                return result;
            }, cancellationToken);
        }

        #endregion
    }
}
