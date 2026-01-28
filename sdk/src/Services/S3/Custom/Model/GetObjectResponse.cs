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
using System.Xml.Serialization;
using System.Text;

using Amazon.Runtime;
using Amazon.S3.Util;
using Amazon.Util;
using System.Globalization;
using Amazon.S3.Model.Internal.MarshallTransformations;
using Amazon.S3;
using Amazon.Runtime.Internal;
using Amazon.S3.Transfer;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Returns information about the  GetObject response and response metadata.
    /// </summary>
    public partial class GetObjectResponse : StreamResponse
    {
        private bool? restoreInProgress;
        private HeadersCollection headersCollection = new HeadersCollection();
        private MetadataCollection metadataCollection = new MetadataCollection();
        private string bucketName;
        private string key;

        /// <summary>
        /// The date and time at which the object is no longer cacheable.
        /// </summary>
        public string ExpiresString { get; set; }

        /// <summary>
        /// Gets and sets the BucketName property.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Gets and sets the Key property.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// The collection of headers for the request.
        /// </summary>
        public HeadersCollection Headers
        {
            get
            {
                if (this.headersCollection == null)
                    this.headersCollection = new HeadersCollection();
                return this.headersCollection;
            }
        }

        /// <summary>
        /// The collection of meta data for the request.
        /// </summary>
        public MetadataCollection Metadata
        {
            get
            {
                if (this.metadataCollection == null)
                    this.metadataCollection = new MetadataCollection();
                return this.metadataCollection;
            }
        }

        /// <summary>
        /// Gets and sets the RestoreInProgress
        /// <para>
        /// Will be <c>true</c> when the object is in the process of being restored from Amazon Glacier.
        /// </para>
        /// <para>
        /// This functionality is not supported for directory buckets. 
        /// Only the S3 Express One Zone storage class is supported by directory buckets to store objects.
        /// </para>
        /// </summary>
        public bool? RestoreInProgress
        {
            get { return this.restoreInProgress; }
            set { this.restoreInProgress = value; }
        }

        
        ServerSideEncryptionCustomerMethod CustomSSECustomerMethodGetter()
        {
            if (this._serverSideEncryptionCustomerMethod == null)
                return ServerSideEncryptionCustomerMethod.None;

            return this._serverSideEncryptionCustomerMethod;
        }

        /// <summary>
        /// Gets and sets the property ContentLanguage. 
        /// <para>
        /// The language the content is in.
        /// </para>
        /// </summary>

        public string ContentLanguage
        {
            get { return this.Headers.ContentLanguage; }
            set { this.Headers.ContentLanguage = value; }
        }
#if BCL

        /// <summary>
        /// Writes the content of the ResponseStream a file indicated by the filePath argument.
        /// </summary>
        /// <param name="filePath">The location where to write the ResponseStream</param>
        public void WriteResponseStreamToFile(string filePath)
        {
            WriteResponseStreamToFile(filePath, false);
        }

        /// <summary>
        /// Writes the content of the ResponseStream a file indicated by the filePath argument.
        /// </summary>
        /// <param name="filePath">The location where to write the ResponseStream</param>
        /// <param name="append">Whether or not to append to the file if it exists</param>
        public void WriteResponseStreamToFile(string filePath, bool append)
        {
            CreateDirectory(filePath);
            Stream downloadStream = CreateDownloadStream(filePath, append);

            using (downloadStream)
            {
                long current = 0;

                byte[] buffer = new byte[S3Constants.DefaultBufferSize];
                int bytesRead = 0;

                long totalIncrementTransferred = 0;
                while ((bytesRead = this.ResponseStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    downloadStream.Write(buffer, 0, bytesRead);
                    current += bytesRead;
                    totalIncrementTransferred += bytesRead;

                    if (totalIncrementTransferred >= AWSSDKUtils.DefaultProgressUpdateInterval)
                    {
                        this.OnRaiseProgressEvent(filePath, totalIncrementTransferred, current, this.ContentLength, completed:false);
                        totalIncrementTransferred = 0;
                    }
                }

                ValidateWrittenStreamSize(current);

                // Encrypted objects may have size smaller than the total amount of data transfered due to padding.
                // Instead of changing the file size or the total downloaded size, pass a flag that indicate that the transfer is complete.
                this.OnRaiseProgressEvent(filePath, totalIncrementTransferred, current, this.ContentLength, completed:true);
            }
        }

        private static Stream CreateDownloadStream(string filePath, bool append)
        {
            Stream downloadStream;
            if (append && File.Exists(filePath))
                downloadStream = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.Read, S3Constants.DefaultBufferSize);
            else
                downloadStream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite, FileShare.Read, S3Constants.DefaultBufferSize);
            return downloadStream;
        }

        private static void CreateDirectory(string filePath)
        {
            // Make sure the directory exists to write too.
            FileInfo fi = new FileInfo(filePath);
            Directory.CreateDirectory(fi.DirectoryName);
        }

#endif
        #region Progress Event

        /// <summary>
        /// The event for Write Object progress notifications. All
        /// subscribers will be notified when a new progress
        /// event is raised.
        /// </summary>
        /// <remarks>
        /// Subscribe to this event if you want to receive
        /// put object progress notifications. Here is how:<br />
        /// 1. Define a method with a signature similar to this one:
        /// <code>
        /// private void displayProgress(object sender, WriteObjectProgressArgs args)
        /// {
        ///     Console.WriteLine(args);
        /// }
        /// </code>
        /// 2. Add this method to the Put Object Progress Event delegate's invocation list
        /// <code>
        /// GetObjectResponse response = s3Client.GetObject(request);
        /// response.WriteObjectProgressEvent += displayProgress;
        /// </code>
        /// </remarks>
        public event EventHandler<WriteObjectProgressArgs> WriteObjectProgressEvent;

        #endregion

        /// <summary>
        /// This method is called by a producer of write object progress
        /// notifications. When called, all the subscribers in the 
        /// invocation list will be called sequentially.
        /// </summary>
        /// <param name="file">The file being written.</param>
        /// <param name="incrementTransferred">The number of bytes transferred since last event</param>
        /// <param name="transferred">The number of bytes transferred</param>
        /// <param name="total">The total number of bytes to be transferred</param>
        /// <param name="completed">True if transfer is complete</param>
        internal void OnRaiseProgressEvent(string file, long incrementTransferred, long transferred, long total, bool completed)
        {
            AWSSDKUtils.InvokeInBackground(WriteObjectProgressEvent, new WriteObjectProgressArgs(this.BucketName, this.Key, file, this.VersionId, incrementTransferred, transferred, total, completed), this);
        }


        private void ValidateWrittenStreamSize(long bytesWritten)
        {
            // Check if response stream or it's base stream is a AESDecryptionStream
            var stream = Runtime.Internal.Util.WrapperStream.SearchWrappedStream(this.ResponseStream,
                (s => s is Runtime.Internal.Util.DecryptStream));

            // Don't validate length if response is an encrypted object. 
            if (stream!=null)
               return;
               
            if (bytesWritten != this.ContentLength)
            {
                string amzId2;                
                if(!this.ResponseMetadata.Metadata.TryGetValue(HeaderKeys.XAmzId2Header, out amzId2))
                    amzId2 = string.Empty;

                string amzCfId;
                if(!this.ResponseMetadata.Metadata.TryGetValue(HeaderKeys.XAmzCloudFrontIdHeader, out amzCfId))
                    amzCfId = string.Empty;

                string message = null;
                if (string.IsNullOrEmpty(amzCfId))
                {
                    message = string.Format(CultureInfo.InvariantCulture,
                    "The total bytes read {0} from response stream is not equal to the Content-Length {1} for the object {2} in bucket {3}." +
                    " Request ID = {4} , AmzId2 = {5}.",
                    bytesWritten, this.ContentLength, this.Key, this.BucketName, this.ResponseMetadata.RequestId, amzId2);
                }
                else
                {
                    message = string.Format(CultureInfo.InvariantCulture,
                    "The total bytes read {0} from response stream is not equal to the Content-Length {1} for the object {2} in bucket {3}." +
                    " Request ID = {4} , AmzId2 = {5} , AmzCfId = {6}.",
                    bytesWritten, this.ContentLength, this.Key, this.BucketName, this.ResponseMetadata.RequestId, amzId2, amzCfId);
                }
                

                throw new StreamSizeMismatchException(message, this.ContentLength, bytesWritten, this.ResponseMetadata.RequestId, amzId2, amzCfId);
            }
        }

#if BCL || NETSTANDARD
        /// <summary>
        /// Copies data from ResponseStream to destination stream with progress tracking and validation.
        /// Internal method to enable reuse across different download scenarios.
        /// </summary>
        /// <param name="destinationStream">Stream to write data to</param>
        /// <param name="filePath">File path for progress event reporting (can be null)</param>
        /// <param name="bufferSize">Buffer size for reading/writing operations</param>
        /// <param name="cancellationToken">Cancellation token</param>
        /// <param name="validateSize">Whether to validate copied bytes match ContentLength</param>
        internal async System.Threading.Tasks.Task WriteResponseStreamAsync(
            Stream destinationStream,
            string filePath,
            int bufferSize,
            System.Threading.CancellationToken cancellationToken,
            bool validateSize = true)
        {
            long current = 0;
#if NETSTANDARD
            Stream stream = this.ResponseStream;
#else
            Stream stream = new BufferedStream(this.ResponseStream);
#endif
            byte[] buffer = new byte[bufferSize];
            int bytesRead = 0;
            long totalIncrementTransferred = 0;
            
            while ((bytesRead = await stream.ReadAsync(buffer, 0, buffer.Length, cancellationToken)
                .ConfigureAwait(continueOnCapturedContext: false)) > 0)
            {
                cancellationToken.ThrowIfCancellationRequested();

                await destinationStream.WriteAsync(buffer, 0, bytesRead, cancellationToken)
                    .ConfigureAwait(continueOnCapturedContext: false);
                current += bytesRead;
                totalIncrementTransferred += bytesRead;

                if (totalIncrementTransferred >= AWSSDKUtils.DefaultProgressUpdateInterval)
                {
                    this.OnRaiseProgressEvent(filePath, totalIncrementTransferred, current, this.ContentLength, completed: false);
                    totalIncrementTransferred = 0;
                }
            }

            if (validateSize)
            {
                ValidateWrittenStreamSize(current);
            }

            // Encrypted objects may have size smaller than the total amount of data transferred due to padding.
            // Instead of changing the file size or the total downloaded size, pass a flag that indicates transfer is complete.
            this.OnRaiseProgressEvent(filePath, totalIncrementTransferred, current, this.ContentLength, completed: true);
        }

        /// <summary>
        /// Writes the content of the ResponseStream a file indicated by the filePath argument.
        /// </summary>
        /// <param name="filePath">The location where to write the ResponseStream</param>
        /// <param name="append">Whether or not to append to the file if it exists</param>
        /// <param name="cancellationToken">Cancellation token which can be used to cancel this operation.</param>
        public async System.Threading.Tasks.Task WriteResponseStreamToFileAsync(string filePath, bool append, System.Threading.CancellationToken cancellationToken)
        {
            // Make sure the directory exists to write too.
            FileInfo fi = new FileInfo(filePath);
            Directory.CreateDirectory(fi.DirectoryName);

            Stream downloadStream;
            if (append && File.Exists(filePath))
                downloadStream = new FileStream(filePath, FileMode.Append, FileAccess.Write, FileShare.Read, S3Constants.DefaultBufferSize);
            else
                downloadStream = new FileStream(filePath, FileMode.Create, FileAccess.ReadWrite, FileShare.Read, S3Constants.DefaultBufferSize);

            try
            {
                await WriteResponseStreamAsync(downloadStream, filePath, S3Constants.DefaultBufferSize, cancellationToken, validateSize: true)
                    .ConfigureAwait(continueOnCapturedContext: false);
            }
            finally
            {
                downloadStream.Dispose();
            }
        }
#endif
    }
    /// <summary>
    /// Encapsulates the information needed to provide
    /// download progress for the Write Object Event.
    /// </summary>
    public class WriteObjectProgressArgs : TransferProgressArgs
    {
        /// <summary>
        /// The constructor takes the number of
        /// currently transferred bytes and the
        /// total number of bytes to be transferred
        /// </summary>
        /// <param name="bucketName">The bucket name for the S3 object being written.</param>
        /// <param name="key">The object key for the S3 object being written.</param>
        /// <param name="versionId">The version-id of the S3 object.</param>
        /// <param name="incrementTransferred">The number of bytes transferred since last event</param>
        /// <param name="transferred">The number of bytes transferred</param>
        /// <param name="total">The total number of bytes to be transferred</param>
        /// <param name="completed">True if finished writing</param>
        internal WriteObjectProgressArgs(string bucketName, string key, string versionId, long incrementTransferred, long transferred, long total, bool completed)
            : base(incrementTransferred, transferred, total)
        {
            this.BucketName = bucketName;
            this.Key = key;
            this.VersionId = versionId;
            this.IsCompleted = completed;
        }

        /// <summary>
        /// The constructor takes the number of
        /// currently transferred bytes and the
        /// total number of bytes to be transferred
        /// </summary>
        /// <param name="bucketName">The bucket name for the S3 object being written.</param>
        /// <param name="key">The object key for the S3 object being written.</param>
        /// <param name="filePath">The file for the S3 object being written.</param>
        /// <param name="versionId">The version-id of the S3 object.</param>
        /// <param name="incrementTransferred">The number of bytes transferred since last event</param>
        /// <param name="transferred">The number of bytes transferred</param>
        /// <param name="total">The total number of bytes to be transferred</param>
        /// <param name="completed">True if finished writing</param>
        internal WriteObjectProgressArgs(string bucketName, string key, string filePath, string versionId, long incrementTransferred, long transferred, long total, bool completed)
            : base(incrementTransferred, transferred, total)
        {
            this.BucketName = bucketName;
            this.Key = key;
            this.VersionId = versionId;
            this.FilePath = filePath;
            this.IsCompleted = completed;
        }

        /// <summary>
        /// Gets the bucket name for the S3 object being written.
        /// </summary>
        public string BucketName { get; private set; }

        /// <summary>
        /// Gets the object key for the S3 object being written.
        /// </summary>
        public string Key { get; private set; }

        /// <summary>
        /// Gets the version-id of the S3 object.
        /// </summary>
        public string VersionId { get; private set; }

        /// <summary>
        /// The file for the S3 object being written.
        /// </summary>
        public string FilePath { get; private set; }

        /// <summary>
        /// True if writing is complete
        /// </summary>
        public bool IsCompleted { get; private set; }

        /// <summary>
        /// The original TransferUtilityDownloadRequest created by the user.
        /// </summary>
        public TransferUtilityDownloadRequest Request { get; internal set; }
    }  
}
