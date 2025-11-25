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
    public partial interface ITransferUtility
    {
        #region UploadDirectory
        /// <summary>
        /// 	Uploads files from a specified directory.  
        /// 	The object key is derived from the file names
        /// 	inside the directory.
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
        /// you should manually invoke TransferUtility.AbortMultipartUploads() to abort the incomplete multipart uploads.
        /// </para>
        /// </remarks>
        /// <param name="directory">
        /// 	The source directory, that is, the directory containing the files to upload.
        /// </param>
        /// <param name="bucketName">
        /// 	The target Amazon S3 bucket, that is, the name of the bucket to upload the files to.
        /// </param>
        void UploadDirectory(string directory, string bucketName);


        /// <summary>
        /// 	Uploads files from a specified directory.  
        /// 	The object key is derived from the file names
        /// 	inside the directory.
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
        void UploadDirectory(string directory, string bucketName, string searchPattern, SearchOption searchOption);

        /// <summary>
        /// 	Uploads files from a specified directory.  
        /// 	The object key is derived from the file names
        /// 	inside the directory.
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
        /// you should manually invoke TransferUtility.AbortMultipartUploads() to abort the incomplete multipart uploads.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// 	The request that contains all the parameters required to upload a directory.
        /// </param>
        void UploadDirectory(TransferUtilityUploadDirectoryRequest request);
        #endregion

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
        /// you should manually invoke TransferUtility.AbortMultipartUploads() to abort the incomplete multipart uploads.
        /// </para>
        /// </remarks>
        /// <param name="filePath">
        /// 	The file path of the file to upload.
        /// </param>
        /// <param name="bucketName">
        /// 	The target Amazon S3 bucket, that is, the name of the bucket to upload the file to.
        /// </param>
        void Upload(string filePath, string bucketName);

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
        void Upload(string filePath, string bucketName, string key);


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
        void Upload(Stream stream, string bucketName, string key);

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
        /// you should manually invoke TransferUtility.AbortMultipartUploads() to abort the incomplete multipart uploads.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// 	Contains all the parameters required to upload to Amazon S3.
        /// </param>
        void Upload(TransferUtilityUploadRequest request);

        #endregion

        #region OpenStream

        /// <summary>
        /// 	Returns a stream from which the caller can read the content from the specified
        /// 	Amazon S3  bucket and key.
        /// 	The caller of this method is responsible for closing the stream.
        /// </summary>
        /// <remarks>
        /// 	<para>
        /// 	<b>Note:</b> Consider using <see cref="OpenStreamWithResponse(string, string)"/> 
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
        /// <returns>
        /// 	A stream of the contents from the specified Amazon S3 and key.
        /// </returns>
        Stream OpenStream(string bucketName, string key);

        /// <summary>
        /// 	Returns a stream to read the contents from Amazon S3 as 
        /// 	specified by the <c>TransferUtilityOpenStreamRequest</c>.
        /// 	The caller of this method is responsible for closing the stream.
        /// </summary>
        /// <remarks>
        /// 	<para>
        /// 	<b>Note:</b> Consider using <see cref="OpenStreamWithResponse(TransferUtilityOpenStreamRequest)"/> 
        /// 	instead. The newer operation uses parallel downloads from S3 and memory buffering to improve performance, 
        /// 	and also returns response metadata along with the stream.
        /// 	</para>
        /// </remarks>
        /// <param name="request">
        /// 	Contains all the parameters required to open a stream to an S3 object.
        /// </param>
        /// <returns>
        /// 	A stream of the contents from Amazon S3.
        /// </returns>
        Stream OpenStream(TransferUtilityOpenStreamRequest request);

        /// <summary>
        /// 	Returns a stream from which the caller can read the content from the specified
        /// 	Amazon S3 bucket and key, along with response metadata.
        /// 	The caller of this method is responsible for closing the stream.
        /// </summary>
        /// <remarks>
        /// 	<para>
        /// 	This method uses parallel downloads and intelligent buffering to significantly improve 
        /// 	throughput compared to the standard <see cref="OpenStream(string, string)"/> method.
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
        /// 	    ConcurrentServiceRequests = 20
        /// 	};
        /// 	var transferUtility = new TransferUtility(s3Client, config);
        /// 	</code>
        /// 	<para>
        /// 	Use <see cref="TransferUtilityConfig.ConcurrentServiceRequests"/> to control parallel download threads.
        /// 	Use <see cref="TransferUtilityOpenStreamRequest.MaxInMemoryParts"/> to limit memory consumption by capping the number 
        /// 	of buffered parts in memory.
        /// 	</para>
        /// 	<para>
        /// 	<b>Memory Considerations:</b> The buffering mechanism uses memory to store downloaded parts. 
        /// 	Adjust <see cref="TransferUtilityOpenStreamRequest.MaxInMemoryParts"/> if you need to limit memory usage, 
        /// 	especially when downloading very large files or multiple files concurrently.
        /// 	</para>
        /// </remarks>
        /// <param name="bucketName">
        /// 	The name of the bucket.
        /// </param>
        /// <param name="key">
        /// 	The object key.
        /// </param>
        /// <returns>
        /// 	A response containing the stream and metadata from the specified Amazon S3 bucket and key.
        /// </returns>
        TransferUtilityOpenStreamResponse OpenStreamWithResponse(string bucketName, string key);

        /// <summary>
        /// 	Returns a stream to read the contents from Amazon S3 as 
        /// 	specified by the <c>TransferUtilityOpenStreamRequest</c>, along with response metadata.
        /// 	The caller of this method is responsible for closing the stream.
        /// </summary>
        /// <remarks>
        /// 	<para>
        /// 	This method uses parallel downloads and intelligent buffering to significantly improve 
        /// 	throughput compared to the standard <see cref="OpenStream(TransferUtilityOpenStreamRequest)"/> method.
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
        /// 	    ConcurrentServiceRequests = 20
        /// 	};
        /// 	var transferUtility = new TransferUtility(s3Client, config);
        /// 	</code>
        /// 	<para>
        /// 	Use <see cref="TransferUtilityConfig.ConcurrentServiceRequests"/> to control parallel download threads.
        /// 	Use <see cref="TransferUtilityOpenStreamRequest.MaxInMemoryParts"/> to limit memory consumption by capping the number 
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
        /// 	var response = transferUtility.OpenStreamWithResponse(request);
        /// 	</code>
        /// 	<para>
        /// 	<b>Memory Considerations:</b> The buffering mechanism uses memory to store downloaded parts. 
        /// 	Adjust <see cref="TransferUtilityOpenStreamRequest.MaxInMemoryParts"/> if you need to limit memory usage, 
        /// 	especially when downloading very large files or multiple files concurrently.
        /// 	</para>
        /// </remarks>
        /// <param name="request">
        /// 	Contains all the parameters required for the OpenStreamWithResponse operation.
        /// </param>
        /// <returns>
        /// 	A response containing the stream and metadata from Amazon S3.
        /// </returns>
        TransferUtilityOpenStreamResponse OpenStreamWithResponse(TransferUtilityOpenStreamRequest request);

        #endregion

        #region Download
        /// <summary>
        /// 	Downloads the content from Amazon S3 and writes it to the specified file.  
        /// </summary>
        /// <remarks>
        /// 	<para>
        /// 	<b>Note:</b> Consider using <see cref="DownloadWithResponse(string, string, string)"/> 
        /// 	instead. The newer operation uses parallel downloads to improve performance 
        /// 	and returns response metadata.
        /// 	</para>
        /// </remarks>
        /// <param name="filePath">
        /// 	The file path where the content from Amazon S3 will be written to.
        /// </param>
        /// <param name="bucketName">
        /// 	The name of the bucket containing the Amazon S3 object to download.
        /// </param>
        /// <param name="key">
        /// 	The key under which the Amazon S3 object is stored.
        /// </param>
        void Download(string filePath, string bucketName, string key);

        /// <summary>
        /// 	Downloads the content from Amazon S3 and writes it to the specified file.    
        /// 	If the key is not specified in the request parameter,
        /// 	the file name will used as the key name.
        /// </summary>
        /// <remarks>
        /// 	<para>
        /// 	<b>Note:</b> Consider using <see cref="DownloadWithResponse(TransferUtilityDownloadRequest)"/> 
        /// 	instead. The newer operation uses parallel downloads to improve performance 
        /// 	and returns response metadata.
        /// 	</para>
        /// </remarks>
        /// <param name="request">
        /// 	Contains all the parameters required to download an Amazon S3 object.
        /// </param>
        void Download(TransferUtilityDownloadRequest request);

        /// <summary>
        /// 	Downloads the content from Amazon S3 and writes it to the specified file, returning response metadata.
        /// </summary>
        /// <remarks>
        /// 	<para>
        /// 	This method uses parallel downloads to significantly improve throughput compared to 
        /// 	the standard <see cref="Download(string, string, string)"/> method.
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
        /// <returns>Response metadata including headers and version information from the download.</returns>
        TransferUtilityDownloadResponse DownloadWithResponse(string filePath, string bucketName, string key);

        /// <summary>
        /// 	Downloads the content from Amazon S3 based on the request and returns response metadata.
        /// 	To track the progress of the download, add an event listener to the request's <c>WriteObjectProgressEvent</c>.
        /// </summary>
        /// <remarks>
        /// 	<para>
        /// 	This method uses parallel downloads to significantly improve throughput compared to 
        /// 	the standard <see cref="Download(TransferUtilityDownloadRequest)"/> method.
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
        /// 	    PartSize = 16 * 1024 * 1024  // Use 16MB parts instead of default 8MB
        /// 	};
        /// 	var response = transferUtility.DownloadWithResponse(request);
        /// 	</code>
        /// </remarks>
        /// <param name="request">
        /// 	Contains all the parameters required to download an Amazon S3 object.
        /// </param>
        /// <returns>Response metadata including headers and version information from the download.</returns>
        TransferUtilityDownloadResponse DownloadWithResponse(TransferUtilityDownloadRequest request);
        #endregion

        #region DownloadDirectory
        /// <summary>
        /// 	Downloads the objects in Amazon S3 that have a key that starts with the value 
        /// 	specified by <c>s3Directory</c>.
        /// </summary>
        /// <remarks>
        /// 	<para>
        /// 	<b>Note:</b> Consider using <see cref="DownloadDirectoryWithResponse(string, string, string)"/> 
        /// 	instead. The newer operation uses enhanced multipart download with concurrent part downloads 
        /// 	for improved performance and returns response metadata including the total number of objects downloaded.
        /// 	</para>
        /// </remarks>
        /// <param name="bucketName">
        /// 	The name of the bucket containing the Amazon S3 objects to download.
        /// </param>
        /// <param name="s3Directory">
        /// 	The directory in Amazon S3 to download.
        /// </param>
        /// <param name="localDirectory">
        /// 	The local directory to download the objects to.
        /// </param>
        void DownloadDirectory(string bucketName, string s3Directory, string localDirectory);

        /// <summary>
        /// 	Downloads the objects in Amazon S3 that have a key that starts with the value 
        /// 	specified by the <c>S3Directory</c>
        /// 	property of the passed in <c>TransferUtilityDownloadDirectoryRequest</c> object.
        /// </summary>
        /// <remarks>
        /// 	<para>
        /// 	<b>Note:</b> Consider using <see cref="DownloadDirectoryWithResponse(TransferUtilityDownloadDirectoryRequest)"/> 
        /// 	instead. The newer operation uses enhanced multipart download with concurrent part downloads 
        /// 	for improved performance and returns response metadata including the total number of objects downloaded.
        /// 	</para>
        /// </remarks>
        /// <param name="request">
        /// 	Contains all the parameters required to download objects from Amazon S3 
        /// 	into a local directory.
        /// </param>
        void DownloadDirectory(TransferUtilityDownloadDirectoryRequest request);

        /// <summary>
        /// 	Downloads the objects in Amazon S3 that have a key that starts with the value 
        /// 	specified by <c>s3Directory</c>, returning response metadata.
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
        /// <returns>Response metadata including the number of objects downloaded.</returns>
        TransferUtilityDownloadDirectoryResponse DownloadDirectoryWithResponse(string bucketName, string s3Directory, string localDirectory);

        /// <summary>
        /// 	Downloads the objects in Amazon S3 that have a key that starts with the value 
        /// 	specified by the <c>S3Directory</c> property of the passed in 
        /// 	<c>TransferUtilityDownloadDirectoryRequest</c> object, returning response metadata.
        /// 	Uses enhanced multipart download with concurrent part downloads for improved performance.
        /// </summary>
        /// <param name="request">
        /// 	Contains all the parameters required to download objects from Amazon S3 
        /// 	into a local directory.
        /// </param>
        /// <returns>Response metadata including the number of objects downloaded.</returns>
        TransferUtilityDownloadDirectoryResponse DownloadDirectoryWithResponse(TransferUtilityDownloadDirectoryRequest request);
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
        void AbortMultipartUploads(string bucketName, DateTime initiatedDate);

        #endregion

        #region UploadWithResponse

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
        /// you should manually invoke TransferUtility.AbortMultipartUploads() to abort the incomplete multipart uploads.
        /// </para>
        /// </remarks>
        /// <param name="filePath">
        /// 	The file path of the file to upload.
        /// </param>
        /// <param name="bucketName">
        /// 	The target Amazon S3 bucket, that is, the name of the bucket to upload the file to.
        /// </param>
        /// <returns>The upload response metadata.</returns>
        TransferUtilityUploadResponse UploadWithResponse(string filePath, string bucketName);

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
        /// <returns>The upload response metadata.</returns>
        TransferUtilityUploadResponse UploadWithResponse(string filePath, string bucketName, string key);

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
        /// <returns>The upload response metadata.</returns>
        TransferUtilityUploadResponse UploadWithResponse(Stream stream, string bucketName, string key);

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
        /// you should manually invoke TransferUtility.AbortMultipartUploads() to abort the incomplete multipart uploads.
        /// </para>
        /// </remarks>
        /// <param name="request">
        /// 	Contains all the parameters required to upload to Amazon S3.
        /// </param>
        /// <returns>The upload response metadata.</returns>
        TransferUtilityUploadResponse UploadWithResponse(TransferUtilityUploadRequest request);

        #endregion
    }
}
