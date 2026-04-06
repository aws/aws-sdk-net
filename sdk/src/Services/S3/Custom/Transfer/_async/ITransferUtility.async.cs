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
        /// <remarks>
        /// 	<para>
        /// 	<b>Note:</b> Consider using <see cref="DownloadWithResponseAsync(TransferUtilityDownloadRequest, CancellationToken)"/> 
        /// 	instead. The newer operation uses parallel downloads to improve performance 
        /// 	and returns response metadata.
        /// 	</para>
        /// </remarks>
        /// <param name="request">
        /// 	Contains all the parameters required to download an Amazon S3 object.
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        Task DownloadAsync(TransferUtilityDownloadRequest request, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 	Downloads the content from Amazon S3 and writes it to the specified file, returning response metadata.
        /// </summary>
        /// <remarks>
        /// 	<para>
        /// 	This method uses parallel downloads to significantly improve throughput compared to 
        /// 	the standard <see cref="DownloadAsync(TransferUtilityDownloadRequest, CancellationToken)"/> method.
        /// 	</para>
        /// 	<para>
        /// 	<b>How it works:</b>
        /// 	</para>
        /// 	<list type="bullet">
        /// 	<item><description>For large objects, the download is automatically split into parts (default 8MB per part)</description></item>
        /// 	<item><description>Multiple parts are downloaded concurrently using parallel requests to S3</description></item>
        /// 	<item><description>Downloaded parts are written directly to the file as they arrive</description></item>
        /// 	</list>
        /// 	<para>
        /// 	<b>Multipart Download Strategy:</b>
        /// 	</para>
        /// 	<para>
        /// 	The <see cref="BaseDownloadRequest.MultipartDownloadType"/> property controls how parts are downloaded (default: <c>MultipartDownloadType.PART</c>):
        /// 	</para>
        /// 	<list type="bullet">
        /// 	<item><description><b>PART (default)</b>: Uses the original part boundaries from when the object was uploaded with multipart upload. 
        /// 	This is more efficient as it aligns with S3's internal part structure, but <b>requires that the object was uploaded using multipart upload</b>. 
        /// 	The <see cref="BaseDownloadRequest.PartSize"/> property is ignored in this mode.</description></item>
        /// 	<item><description><b>RANGE</b>: Uses range-based downloads with configurable part sizes via the <see cref="BaseDownloadRequest.PartSize"/> property. 
        /// 	This works with any object (whether uploaded as single-part or multipart) and provides more flexibility in controlling download part sizes.</description></item>
        /// 	</list>
        /// 	<para>
        /// 	<b>When to use PART vs RANGE:</b>
        /// 	</para>
        /// 	<list type="bullet">
        /// 	<item><description>Use <b>PART</b> mode (default) when you know the object was uploaded using multipart upload and want optimal performance.</description></item>
        /// 	<item><description>Use <b>RANGE</b> mode when the object's upload method is unknown, when you need specific part sizes, or when downloading objects that were uploaded as a single part.</description></item>
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
        /// 	    ConcurrentServiceRequests = 20
        /// 	};
        /// 	var transferUtility = new TransferUtility(s3Client, config);
        /// 	</code>
        /// 	<para>
        /// 	Use <see cref="TransferUtilityConfig.ConcurrentServiceRequests"/> to control parallel download threads.
        /// 	</para>
        /// 	<para>
        /// 	<b>Additional Performance Settings:</b>
        /// 	</para>
        /// 	<para>
        /// 	You can also tune the S3 client's <see cref="Amazon.Runtime.ClientConfig.BufferSize"/> property to control 
        /// 	the buffer size used when reading from S3 response streams and writing to the local file. The default buffer size 
        /// 	is 8KB. Increasing this value may improve throughput for large downloads at the cost of increased memory usage.
        /// 	</para>
        /// 	<code>
        /// 	var s3Config = new AmazonS3Config
        /// 	{
        /// 	    BufferSize = 64 * 1024  // Use 64KB buffer instead of default 8KB
        /// 	};
        /// 	var s3Client = new AmazonS3Client(s3Config);
        /// 	var transferUtility = new TransferUtility(s3Client);
        /// 	</code>
        /// </remarks>
        /// <param name="filePath">
        /// 	The file path where the downloaded content will be written.
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
        /// <returns>The task object representing the asynchronous operation with download response metadata.</returns>
        Task<TransferUtilityDownloadResponse> DownloadWithResponseAsync(string filePath, string bucketName, string key, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 	Downloads the content from Amazon S3 based on the request and returns response metadata.
        /// 	To track the progress of the download, add an event listener to the request's <c>WriteObjectProgressEvent</c>.
        /// </summary>
        /// <remarks>
        /// 	<para>
        /// 	This method uses parallel downloads to significantly improve throughput compared to 
        /// 	the standard <see cref="DownloadAsync(TransferUtilityDownloadRequest, CancellationToken)"/> method.
        /// 	</para>
        /// 	<para>
        /// 	<b>How it works:</b>
        /// 	</para>
        /// 	<list type="bullet">
        /// 	<item><description>For large objects, the download is automatically split into parts (default 8MB per part)</description></item>
        /// 	<item><description>Multiple parts are downloaded concurrently using parallel requests to S3</description></item>
        /// 	<item><description>Downloaded parts are written directly to the file as they arrive</description></item>
        /// 	</list>
        /// 	<para>
        /// 	<b>Multipart Download Strategy:</b>
        /// 	</para>
        /// 	<para>
        /// 	The <see cref="BaseDownloadRequest.MultipartDownloadType"/> property controls how parts are downloaded (default: <c>MultipartDownloadType.PART</c>):
        /// 	</para>
        /// 	<list type="bullet">
        /// 	<item><description><b>PART (default)</b>: Uses the original part boundaries from when the object was uploaded with multipart upload. 
        /// 	This is more efficient as it aligns with S3's internal part structure, but <b>requires that the object was uploaded using multipart upload</b>. 
        /// 	The <see cref="BaseDownloadRequest.PartSize"/> property is ignored in this mode.</description></item>
        /// 	<item><description><b>RANGE</b>: Uses range-based downloads with configurable part sizes via the <see cref="BaseDownloadRequest.PartSize"/> property. 
        /// 	This works with any object (whether uploaded as single-part or multipart) and provides more flexibility in controlling download part sizes.</description></item>
        /// 	</list>
        /// 	<para>
        /// 	<b>When to use PART vs RANGE:</b>
        /// 	</para>
        /// 	<list type="bullet">
        /// 	<item><description>Use <b>PART</b> mode (default) when you know the object was uploaded using multipart upload and want optimal performance.</description></item>
        /// 	<item><description>Use <b>RANGE</b> mode when the object's upload method is unknown, when you need specific part sizes, or when downloading objects that were uploaded as a single part.</description></item>
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
        /// 	    ConcurrentServiceRequests = 20
        /// 	};
        /// 	var transferUtility = new TransferUtility(s3Client, config);
        /// 	</code>
        /// 	<para>
        /// 	Use <see cref="TransferUtilityConfig.ConcurrentServiceRequests"/> to control parallel download threads.
        /// 	</para>
        /// 	<para>
        /// 	You can also customize the part size per request using <see cref="BaseDownloadRequest.PartSize"/>:
        /// 	</para>
        /// 	<code>
        /// 	var request = new TransferUtilityDownloadRequest
        /// 	{
        /// 	    BucketName = "my-bucket",
        /// 	    Key = "my-key",
        /// 	    FilePath = "local-file.txt",
        /// 	    PartSize = 16 * 1024 * 1024,  // Use 16MB parts instead of default 8MB
        /// 	    MultipartDownloadType = MultipartDownloadType.RANGE  // Enable RANGE mode to use custom PartSize
        /// 	};
        /// 	var response = await transferUtility.DownloadWithResponseAsync(request);
        /// 	</code>
        /// 	<para>
        /// 	<b>Additional Performance Settings:</b>
        /// 	</para>
        /// 	<para>
        /// 	You can also tune the S3 client's <see cref="Amazon.Runtime.ClientConfig.BufferSize"/> property to control 
        /// 	the buffer size used when reading from S3 response streams and writing to the local file. The default buffer size 
        /// 	is 8KB. Increasing this value may improve throughput for large downloads at the cost of increased memory usage.
        /// 	</para>
        /// 	<code>
        /// 	var s3Config = new AmazonS3Config
        /// 	{
        /// 	    BufferSize = 64 * 1024  // Use 64KB buffer instead of default 8KB
        /// 	};
        /// 	var s3Client = new AmazonS3Client(s3Config);
        /// 	var transferUtility = new TransferUtility(s3Client);
        /// 	</code>
        /// </remarks>
        /// <param name="request">
        /// 	Contains all the parameters required to download an Amazon S3 object.
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation with download response metadata.</returns>
        Task<TransferUtilityDownloadResponse> DownloadWithResponseAsync(TransferUtilityDownloadRequest request, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 	Downloads the objects in Amazon S3 that have a key that starts with the value 
        /// 	specified by <c>s3Directory</c> and returns response metadata.
        /// 	Uses enhanced multipart download with concurrent part downloads for improved performance.
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
        /// <returns>The task object representing the asynchronous operation with download response metadata.</returns>
        Task<TransferUtilityDownloadDirectoryResponse> DownloadDirectoryWithResponseAsync(string bucketName, string s3Directory, string localDirectory, CancellationToken cancellationToken = default(CancellationToken));

        /// <summary>
        /// 	Downloads the objects in Amazon S3 that have a key that starts with the value 
        /// 	specified by the <c>S3Directory</c> property and returns response metadata.
        /// 	Uses enhanced multipart download with concurrent part downloads for improved performance.
        /// </summary>
        /// <param name="request">
        /// 	Contains all the parameters required to download objects from Amazon S3 
        /// 	into a local directory.
        /// </param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation with download response metadata.</returns>
        Task<TransferUtilityDownloadDirectoryResponse> DownloadDirectoryWithResponseAsync(TransferUtilityDownloadDirectoryRequest request, CancellationToken cancellationToken = default(CancellationToken));

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
        /// 	<b>Multipart Download Strategy:</b>
        /// 	</para>
        /// 	<para>
        /// 	The <see cref="BaseDownloadRequest.MultipartDownloadType"/> property controls how parts are downloaded (default: <c>MultipartDownloadType.PART</c>):
        /// 	</para>
        /// 	<list type="bullet">
        /// 	<item><description><b>PART (default)</b>: Uses the original part boundaries from when the object was uploaded with multipart upload. 
        /// 	This is more efficient as it aligns with S3's internal part structure, but <b>requires that the object was uploaded using multipart upload</b>. 
        /// 	The <see cref="BaseDownloadRequest.PartSize"/> property is ignored in this mode.</description></item>
        /// 	<item><description><b>RANGE</b>: Uses range-based downloads with configurable part sizes via the <see cref="BaseDownloadRequest.PartSize"/> property. 
        /// 	This works with any object (whether uploaded as single-part or multipart) and provides more flexibility in controlling download part sizes.</description></item>
        /// 	</list>
        /// 	<para>
        /// 	<b>When to use PART vs RANGE:</b>
        /// 	</para>
        /// 	<list type="bullet">
        /// 	<item><description>Use <b>PART</b> mode (default) when you know the object was uploaded using multipart upload and want optimal performance.</description></item>
        /// 	<item><description>Use <b>RANGE</b> mode when the object's upload method is unknown, when you need specific part sizes, or when downloading objects that were uploaded as a single part.</description></item>
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
        /// 	    ConcurrentServiceRequests = 20
        /// 	};
        /// 	var transferUtility = new TransferUtility(s3Client, config);
        /// 	</code>
        /// 	<para>
        /// 	Use <see cref="TransferUtilityConfig.ConcurrentServiceRequests"/> to control parallel download threads.
        /// 	Use <see cref="TransferUtilityOpenStreamRequest.MaxInMemoryParts"/> to limit memory consumption by capping the number 
        /// 	of buffered parts in memory.
        /// 	Use <see cref="TransferUtilityOpenStreamRequest.ChunkBufferSize"/> to control the size of individual memory chunks 
        /// 	allocated from the ArrayPool when buffering downloaded parts. The default is 64KB, chosen to avoid Large Object Heap allocations. 
        /// 	Larger chunks may improve throughput but can increase memory fragmentation.
        /// 	</para>
        /// 	<para>
        /// 	<b>Additional Performance Settings:</b>
        /// 	</para>
        /// 	<para>
        /// 	You can also tune the S3 client's <see cref="Amazon.Runtime.ClientConfig.BufferSize"/> property to control 
        /// 	the buffer size used when reading from S3 response streams and writing to the buffered stream. The default buffer size 
        /// 	is 8KB. Increasing this value may improve throughput for large downloads at the cost of increased memory usage.
        /// 	</para>
        /// 	<code>
        /// 	var s3Config = new AmazonS3Config
        /// 	{
        /// 	    BufferSize = 64 * 1024  // Use 64KB buffer instead of default 8KB
        /// 	};
        /// 	var s3Client = new AmazonS3Client(s3Config);
        /// 	var transferUtility = new TransferUtility(s3Client);
        /// 	</code>
        /// 	<para>
        /// 	<b>Memory Considerations:</b> The buffering mechanism uses memory to store downloaded parts. 
        /// 	Adjust <see cref="TransferUtilityOpenStreamRequest.MaxInMemoryParts"/> if you need to limit memory usage, 
        /// 	especially when downloading very large files or multiple files concurrently.
        /// 	</para>
        /// 	<para>
        /// 	<b>Performance Tip - Using Smaller Part Sizes:</b>
        /// 	</para>
        /// 	<para>
        /// 	When downloading objects that were uploaded with large part sizes (e.g., 5GB parts), consider using 
        /// 	<see cref="BaseDownloadRequest.MultipartDownloadType"/> set to <c>MultipartDownloadType.RANGE</c> with 
        /// 	smaller part sizes (e.g., 8MB-64MB) via <see cref="BaseDownloadRequest.PartSize"/>. Smaller part sizes 
        /// 	can improve download throughput by enabling more efficient parallel downloads.
        /// 	</para>
        /// 	<para>
        /// 	<b>Note:</b> When using RANGE mode with custom part sizes, downloads will not use the original S3 multipart 
        /// 	upload boundaries, which means S3's part-level integrity verification is not available.
        /// 	</para>
        /// 	<para>
        /// 	<b>Linux Memory Map Limits:</b>
        /// 	</para>
        /// 	<para>
        /// 	On Linux systems, downloading large objects with large parts may result in a 
        /// 	"Fatal error. Failed to create RW mapping for RX memory" error. This occurs when the number of 
        /// 	memory-mapped regions exceeds the system's <c>vm.max_map_count</c> limit (default: 65,530).
        /// 	</para>
        /// 	<para>
        /// 	If you encounter this error, use RANGE mode with smaller part sizes as described above, and consider 
        /// 	reducing <see cref="TransferUtilityOpenStreamRequest.MaxInMemoryParts"/> to limit concurrent memory allocations.
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
        /// 	<b>Multipart Download Strategy:</b>
        /// 	</para>
        /// 	<para>
        /// 	The <see cref="BaseDownloadRequest.MultipartDownloadType"/> property controls how parts are downloaded (default: <c>MultipartDownloadType.PART</c>):
        /// 	</para>
        /// 	<list type="bullet">
        /// 	<item><description><b>PART (default)</b>: Uses the original part boundaries from when the object was uploaded with multipart upload. 
        /// 	This is more efficient as it aligns with S3's internal part structure, but <b>requires that the object was uploaded using multipart upload</b>. 
        /// 	The <see cref="BaseDownloadRequest.PartSize"/> property is ignored in this mode.</description></item>
        /// 	<item><description><b>RANGE</b>: Uses range-based downloads with configurable part sizes via the <see cref="BaseDownloadRequest.PartSize"/> property. 
        /// 	This works with any object (whether uploaded as single-part or multipart) and provides more flexibility in controlling download part sizes.</description></item>
        /// 	</list>
        /// 	<para>
        /// 	<b>When to use PART vs RANGE:</b>
        /// 	</para>
        /// 	<list type="bullet">
        /// 	<item><description>Use <b>PART</b> mode (default) when you know the object was uploaded using multipart upload and want optimal performance.</description></item>
        /// 	<item><description>Use <b>RANGE</b> mode when the object's upload method is unknown, when you need specific part sizes, or when downloading objects that were uploaded as a single part.</description></item>
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
        /// 	    ConcurrentServiceRequests = 20
        /// 	};
        /// 	var transferUtility = new TransferUtility(s3Client, config);
        /// 	</code>
        /// 	<para>
        /// 	Use <see cref="TransferUtilityConfig.ConcurrentServiceRequests"/> to control parallel download threads.
        /// 	Use <see cref="TransferUtilityOpenStreamRequest.MaxInMemoryParts"/> to limit memory consumption by capping the number 
        /// 	of buffered parts in memory.
        /// 	Use <see cref="TransferUtilityOpenStreamRequest.ChunkBufferSize"/> to control the size of individual memory chunks 
        /// 	allocated from the ArrayPool when buffering downloaded parts. The default is 64KB, chosen to avoid Large Object Heap allocations. 
        /// 	Larger chunks may improve throughput but can increase memory fragmentation.
        /// 	</para>
        /// 	<para>
        /// 	You can also customize the part size per request using <see cref="BaseDownloadRequest.PartSize"/>:
        /// 	</para>
        /// 	<code>
        /// 	var request = new TransferUtilityOpenStreamRequest
        /// 	{
        /// 	    BucketName = "my-bucket",
        /// 	    Key = "my-key",
        /// 	    PartSize = 16 * 1024 * 1024,  // Use 16MB parts instead of default 8MB
        /// 	    MultipartDownloadType = MultipartDownloadType.RANGE  // Enable RANGE mode to use custom PartSize
        /// 	};
        /// 	var response = await transferUtility.OpenStreamWithResponseAsync(request);
        /// 	</code>
        /// 	<para>
        /// 	<b>Additional Performance Settings:</b>
        /// 	</para>
        /// 	<para>
        /// 	You can also tune the S3 client's <see cref="Amazon.Runtime.ClientConfig.BufferSize"/> property to control 
        /// 	the buffer size used when reading from S3 response streams and writing to the buffered stream. The default buffer size 
        /// 	is 8KB. Increasing this value may improve throughput for large downloads at the cost of increased memory usage.
        /// 	</para>
        /// 	<code>
        /// 	var s3Config = new AmazonS3Config
        /// 	{
        /// 	    BufferSize = 64 * 1024  // Use 64KB buffer instead of default 8KB
        /// 	};
        /// 	var s3Client = new AmazonS3Client(s3Config);
        /// 	var transferUtility = new TransferUtility(s3Client);
        /// 	</code>
        /// 	<para>
        /// 	<b>Memory Considerations:</b> The buffering mechanism uses memory to store downloaded parts. 
        /// 	Adjust <see cref="TransferUtilityOpenStreamRequest.MaxInMemoryParts"/> if you need to limit memory usage, 
        /// 	especially when downloading very large files or multiple files concurrently.
        /// 	</para>
        /// 	<para>
        /// 	<b>Performance Tip - Using Smaller Part Sizes:</b>
        /// 	</para>
        /// 	<para>
        /// 	When downloading objects that were uploaded with large part sizes (e.g., 5GB parts), consider using 
        /// 	<see cref="BaseDownloadRequest.MultipartDownloadType"/> set to <c>MultipartDownloadType.RANGE</c> with 
        /// 	smaller part sizes (e.g., 8MB-64MB) via <see cref="BaseDownloadRequest.PartSize"/>. Smaller part sizes 
        /// 	can improve download throughput by enabling more efficient parallel downloads.
        /// 	</para>
        /// 	<para>
        /// 	<b>Note:</b> When using RANGE mode with custom part sizes, downloads will not use the original S3 multipart 
        /// 	upload boundaries, which means S3's part-level integrity verification is not available.
        /// 	</para>
        /// 	<para>
        /// 	<b>Linux Memory Map Limits:</b>
        /// 	</para>
        /// 	<para>
        /// 	On Linux systems, downloading large objects with large parts may result in a 
        /// 	"Fatal error. Failed to create RW mapping for RX memory" error. This occurs when the number of 
        /// 	memory-mapped regions exceeds the system's <c>vm.max_map_count</c> limit (default: 65,530).
        /// 	</para>
        /// 	<para>
        /// 	If you encounter this error, use RANGE mode with smaller part sizes as described above, and consider 
        /// 	reducing <see cref="TransferUtilityOpenStreamRequest.MaxInMemoryParts"/> to limit concurrent memory allocations.
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
