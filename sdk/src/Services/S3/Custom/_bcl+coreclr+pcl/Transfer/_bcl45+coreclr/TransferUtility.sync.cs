/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

        #endregion

        #region OpenStream

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

        #endregion

        #region Download
        /// <summary>
        /// 	Downloads the content from Amazon S3 and writes it to the specified file.  
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
            try
            {
                DownloadAsync(filePath, bucketName, key).Wait();
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
            }
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
            try
            {
                DownloadAsync(request).Wait();
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
            }
        }
        #endregion

        #region DownloadDirectory
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
            try
            {
                DownloadDirectoryAsync(bucketName, s3Directory, localDirectory).Wait();
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
            }
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
            try
            {
                AbortMultipartUploadsAsync(bucketName, initiatedDate).Wait();
            }
            catch (AggregateException e)
            {
                ExceptionDispatchInfo.Capture(e.InnerException).Throw();
            }
        }

        #endregion
    }
}
