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
    public partial interface ITransferUtility : IDisposable
    {
        #region Upload
        /// <summary>
        /// 	Uploads the specified file.  
        /// 	The object key is derived from the file's name.
        /// 	Multiple threads are used to read the file and perform multiple uploads in parallel.  
        /// 	For large uploads, the file will be divided and uploaded in parts using 
        /// 	Amazon S3's multipart API.  The parts will be reassembled as one object in
        /// 	Amazon S3.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If you are uploading large files, TransferUtility will use multipart upload to fulfill the request. 
        /// If a multipart upload is interrupted, TransferUtility will attempt to abort the multipart upload. 
        /// Under certain circumstances (network outage, power failure, etc.), TransferUtility will not be able 
        /// to abort the multipart upload. In this case, in order to stop getting charged for the storage of uploaded parts,
        /// you should manually invoke TransferUtility.AbortMultipartUploadsAsync() to abort the incomplete multipart uploads.
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
        Task UploadAsync(string filePath, string bucketName, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 	Uploads the specified file.  
        /// 	Multiple threads are used to read the file and perform multiple uploads in parallel.  
        /// 	For large uploads, the file will be divided and uploaded in parts using 
        /// 	Amazon S3's multipart API.  The parts will be reassembled as one object in
        /// 	Amazon S3.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If you are uploading large files, TransferUtility will use multipart upload to fulfill the request. 
        /// If a multipart upload is interrupted, TransferUtility will attempt to abort the multipart upload. 
        /// Under certain circumstances (network outage, power failure, etc.), TransferUtility will not be able 
        /// to abort the multipart upload. In this case, in order to stop getting charged for the storage of uploaded parts,
        /// you should manually invoke TransferUtility.AbortMultipartUploadsAsync() to abort the incomplete multipart uploads.
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
        Task UploadAsync(string filePath, string bucketName, string key, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 	Uploads the contents of the specified stream.  
        /// 	For large uploads, the file will be divided and uploaded in parts using 
        /// 	Amazon S3's multipart API.  The parts will be reassembled as one object in
        /// 	Amazon S3.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If you are uploading large files, TransferUtility will use multipart upload to fulfill the request. 
        /// If a multipart upload is interrupted, TransferUtility will attempt to abort the multipart upload. 
        /// Under certain circumstances (network outage, power failure, etc.), TransferUtility will not be able 
        /// to abort the multipart upload. In this case, in order to stop getting charged for the storage of uploaded parts,
        /// you should manually invoke TransferUtility.AbortMultipartUploadsAsync() to abort the incomplete multipart uploads.
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
        Task UploadAsync(Stream stream, string bucketName, string key, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 	Uploads the file or stream specified by the request.  
        /// 	To track the progress of the upload,
        /// 	add an event listener to the request's <c>UploadProgressEvent</c>.
        /// 	For large uploads, the file will be divided and uploaded in parts using 
        /// 	Amazon S3's multipart API.  The parts will be reassembled as one object in
        /// 	Amazon S3.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If you are uploading large files, TransferUtility will use multipart upload to fulfill the request. 
        /// If a multipart upload is interrupted, TransferUtility will attempt to abort the multipart upload. 
        /// Under certain circumstances (network outage, power failure, etc.), TransferUtility will not be able 
        /// to abort the multipart upload. In this case, in order to stop getting charged for the storage of uploaded parts,
        /// you should manually invoke TransferUtility.AbortMultipartUploadsAsync() to abort the incomplete multipart uploads.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// 	Contains all the parameters required to upload to Amazon S3.
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task UploadAsync(TransferUtilityUploadRequest request, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 	Uploads the specified file and returns response metadata.  
        /// 	The object key is derived from the file's name.
        /// 	Multiple threads are used to read the file and perform multiple uploads in parallel.  
        /// 	For large uploads, the file will be divided and uploaded in parts using 
        /// 	Amazon S3's multipart API.  The parts will be reassembled as one object in
        /// 	Amazon S3.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If you are uploading large files, TransferUtility will use multipart upload to fulfill the request. 
        /// If a multipart upload is interrupted, TransferUtility will attempt to abort the multipart upload. 
        /// Under certain circumstances (network outage, power failure, etc.), TransferUtility will not be able 
        /// to abort the multipart upload. In this case, in order to stop getting charged for the storage of uploaded parts,
        /// you should manually invoke TransferUtility.AbortMultipartUploadsAsync() to abort the incomplete multipart uploads.
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
        /// <returns>The task object representing the asynchronous operation with upload response metadata.</returns>
        Task<TransferUtilityUploadResponse> UploadWithResponseAsync(string filePath, string bucketName, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 	Uploads the specified file and returns response metadata.  
        /// 	Multiple threads are used to read the file and perform multiple uploads in parallel.  
        /// 	For large uploads, the file will be divided and uploaded in parts using 
        /// 	Amazon S3's multipart API.  The parts will be reassembled as one object in
        /// 	Amazon S3.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If you are uploading large files, TransferUtility will use multipart upload to fulfill the request. 
        /// If a multipart upload is interrupted, TransferUtility will attempt to abort the multipart upload. 
        /// Under certain circumstances (network outage, power failure, etc.), TransferUtility will not be able 
        /// to abort the multipart upload. In this case, in order to stop getting charged for the storage of uploaded parts,
        /// you should manually invoke TransferUtility.AbortMultipartUploadsAsync() to abort the incomplete multipart uploads.
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
        /// <returns>The task object representing the asynchronous operation with upload response metadata.</returns>
        Task<TransferUtilityUploadResponse> UploadWithResponseAsync(string filePath, string bucketName, string key, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 	Uploads the contents of the specified stream and returns response metadata.  
        /// 	For large uploads, the file will be divided and uploaded in parts using 
        /// 	Amazon S3's multipart API.  The parts will be reassembled as one object in
        /// 	Amazon S3.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If you are uploading large files, TransferUtility will use multipart upload to fulfill the request. 
        /// If a multipart upload is interrupted, TransferUtility will attempt to abort the multipart upload. 
        /// Under certain circumstances (network outage, power failure, etc.), TransferUtility will not be able 
        /// to abort the multipart upload. In this case, in order to stop getting charged for the storage of uploaded parts,
        /// you should manually invoke TransferUtility.AbortMultipartUploadsAsync() to abort the incomplete multipart uploads.
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
        /// <returns>The task object representing the asynchronous operation with upload response metadata.</returns>
        Task<TransferUtilityUploadResponse> UploadWithResponseAsync(Stream stream, string bucketName, string key, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 	Uploads the file or stream specified by the request and returns response metadata.  
        /// 	To track the progress of the upload,
        /// 	add an event listener to the request's <c>UploadProgressEvent</c>.
        /// 	For large uploads, the file will be divided and uploaded in parts using 
        /// 	Amazon S3's multipart API.  The parts will be reassembled as one object in
        /// 	Amazon S3.
        /// </summary>
        /// <remarks>
        /// <para>
        /// If you are uploading large files, TransferUtility will use multipart upload to fulfill the request. 
        /// If a multipart upload is interrupted, TransferUtility will attempt to abort the multipart upload. 
        /// Under certain circumstances (network outage, power failure, etc.), TransferUtility will not be able 
        /// to abort the multipart upload. In this case, in order to stop getting charged for the storage of uploaded parts,
        /// you should manually invoke TransferUtility.AbortMultipartUploadsAsync() to abort the incomplete multipart uploads.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// 	Contains all the parameters required to upload to Amazon S3.
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation with upload response metadata.</returns>
        Task<TransferUtilityUploadResponse> UploadWithResponseAsync(TransferUtilityUploadRequest request, CancellationToken cancellationToken = default(CancellationToken));
        #endregion

        #region AbortMultipartUploads
        /// <summary>
        /// 	Aborts the multipart uploads that were initiated before the specified date.
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
        Task AbortMultipartUploadsAsync(string bucketName, DateTime initiatedDate, CancellationToken cancellationToken = default(CancellationToken));
        #endregion

        #region Download

        /// <summary>
        /// 	Downloads the content from Amazon S3 and writes it to the specified file.    
        /// 	If the key is not specified in the request parameter,
        /// 	the file name will used as the key name.
        /// </summary>
        /// <param name="request">
        /// 	Contains all the parameters required to download an Amazon S3 object.
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task DownloadAsync(TransferUtilityDownloadRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion

        #region OpenStream
        /// <summary>
        /// 	Returns a stream from which the caller can read the content from the specified
        /// 	Amazon S3  bucket and key.
        /// 	The caller of this method is responsible for closing the stream.
        /// </summary>
        /// <remarks>
        /// 	<para>
        /// 	<b>Note:</b> Consider using <see cref="OpenStreamWithResponseAsync(string, string, CancellationToken)"/> 
        /// 	instead. The newer operation uses parallel downloads from S3 and memory buffering to improve performance, 
        /// 	and also returns response metadata along with the stream.
        /// 	</para>
        /// </remarks>
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
        Task<Stream> OpenStreamAsync(string bucketName, string key, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 	Returns a stream to read the contents from Amazon S3 as 
        /// 	specified by the <c>TransferUtilityOpenStreamRequest</c>.
        /// 	The caller of this method is responsible for closing the stream.
        /// </summary>
        /// <remarks>
        /// 	<para>
        /// 	<b>Note:</b> Consider using <see cref="OpenStreamWithResponseAsync(TransferUtilityOpenStreamRequest, CancellationToken)"/> 
        /// 	instead. The newer operation uses parallel downloads from S3 and memory buffering to improve performance, 
        /// 	and also returns response metadata along with the stream.
        /// 	</para>
        /// </remarks>
        /// <param name="request">
        /// 	Contains all the parameters required for the OpenStream operation.
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task<Stream> OpenStreamAsync(TransferUtilityOpenStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 	Returns a stream from which the caller can read the content from the specified
        /// 	Amazon S3 bucket and key, along with response metadata.
        /// 	The caller of this method is responsible for closing the stream.
        /// </summary>
        /// <remarks>
        /// 	<para>
        /// 	This method uses parallel downloads and intelligent buffering to significantly improve 
        /// 	throughput compared to the standard <see cref="OpenStreamAsync(string, string, CancellationToken)"/> method.
        /// 	</para>
        /// 	<para>
        /// 	<b>How it works:</b>
        /// 	</para>
        /// 	<list type="bullet">
        /// 	<item><description>For large objects, the download is automatically split into parts (default 8MB per part)</description></item>
        /// 	<item><description>Multiple parts are downloaded concurrently using parallel requests to S3</description></item>
        /// 	<item><description>Downloaded parts are buffered in memory and served to your application as you read from the stream</description></item>
        /// 	</list>
        /// 	<para>
        /// 	<b>Configuration Options:</b>
        /// 	</para>
        /// 	<para>
        /// 	You can customize the download behavior using <see cref="TransferUtilityConfig"/>:
        /// 	</para>
        /// 	<code>
        /// 	var config = new TransferUtilityConfig
        /// 	{
        /// 	    // Control how many parts download in parallel (default: 10)
        /// 	    ConcurrentServiceRequests = 20,
        /// 	    
        /// 	    // Limit memory usage by capping buffered parts (default: 1024)
        /// 	    // With 8MB parts, 1024 parts = 8GB max memory
        /// 	    MaxInMemoryParts = 512
        /// 	};
        /// 	var transferUtility = new TransferUtility(s3Client, config);
        /// 	</code>
        /// 	<para>
        /// 	Use <see cref="TransferUtilityConfig.ConcurrentServiceRequests"/> to control parallel download threads.
        /// 	Use <see cref="TransferUtilityConfig.MaxInMemoryParts"/> to limit memory consumption by capping the number 
        /// 	of buffered parts in memory.
        /// 	</para>
        /// 	<para>
        /// 	<b>Memory Considerations:</b> The buffering mechanism uses memory to store downloaded parts. 
        /// 	Adjust <see cref="TransferUtilityConfig.MaxInMemoryParts"/> if you need to limit memory usage, 
        /// 	especially when downloading very large files or multiple files concurrently.
        /// 	</para>
        /// </remarks>
        /// <param name="bucketName">
        /// 	The name of the bucket.
        /// </param>
        /// <param name="key">
        /// 	The object key.
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation with response metadata.</returns>
        Task<TransferUtilityOpenStreamResponse> OpenStreamWithResponseAsync(string bucketName, string key, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 	Returns a stream to read the contents from Amazon S3 as 
        /// 	specified by the <c>TransferUtilityOpenStreamRequest</c>, along with response metadata.
        /// 	The caller of this method is responsible for closing the stream.
        /// </summary>
        /// <remarks>
        /// 	<para>
        /// 	This method uses parallel downloads and intelligent buffering to significantly improve 
        /// 	throughput compared to the standard <see cref="OpenStreamAsync(TransferUtilityOpenStreamRequest, CancellationToken)"/> method.
        /// 	</para>
        /// 	<para>
        /// 	<b>How it works:</b>
        /// 	</para>
        /// 	<list type="bullet">
        /// 	<item><description>For large objects, the download is automatically split into parts (default 8MB per part)</description></item>
        /// 	<item><description>Multiple parts are downloaded concurrently using parallel requests to S3</description></item>
        /// 	<item><description>Downloaded parts are buffered in memory and served to your application as you read from the stream</description></item>
        /// 	</list>
        /// 	<para>
        /// 	<b>Configuration Options:</b>
        /// 	</para>
        /// 	<para>
        /// 	You can customize the download behavior using <see cref="TransferUtilityConfig"/>:
        /// 	</para>
        /// 	<code>
        /// 	var config = new TransferUtilityConfig
        /// 	{
        /// 	    // Control how many parts download in parallel (default: 10)
        /// 	    ConcurrentServiceRequests = 20,
        /// 	    
        /// 	    // Limit memory usage by capping buffered parts (default: 1024)
        /// 	    // With 8MB parts, 1024 parts = 8GB max memory
        /// 	    MaxInMemoryParts = 512
        /// 	};
        /// 	var transferUtility = new TransferUtility(s3Client, config);
        /// 	</code>
        /// 	<para>
        /// 	Use <see cref="TransferUtilityConfig.ConcurrentServiceRequests"/> to control parallel download threads.
        /// 	Use <see cref="TransferUtilityConfig.MaxInMemoryParts"/> to limit memory consumption by capping the number 
        /// 	of buffered parts in memory.
        /// 	</para>
        /// 	<para>
        /// 	You can also customize the part size per request using <see cref="BaseDownloadRequest.PartSize"/>:
        /// 	</para>
        /// 	<code>
        /// 	var request = new TransferUtilityOpenStreamRequest
        /// 	{
        /// 	    BucketName = "my-bucket",
        /// 	    Key = "my-key",
        /// 	    PartSize = 16 * 1024 * 1024  // Use 16MB parts instead of default 8MB
        /// 	};
        /// 	var response = await transferUtility.OpenStreamWithResponseAsync(request);
        /// 	</code>
        /// 	<para>
        /// 	<b>Memory Considerations:</b> The buffering mechanism uses memory to store downloaded parts. 
        /// 	Adjust <see cref="TransferUtilityConfig.MaxInMemoryParts"/> if you need to limit memory usage, 
        /// 	especially when downloading very large files or multiple files concurrently.
        /// 	</para>
        /// </remarks>
        /// <param name="request">
        /// 	Contains all the parameters required for the OpenStreamWithResponse operation.
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation with response metadata.</returns>
        Task<TransferUtilityOpenStreamResponse> OpenStreamWithResponseAsync(TransferUtilityOpenStreamRequest request, CancellationToken cancellationToken = default(CancellationToken));

        #endregion
    }
}
