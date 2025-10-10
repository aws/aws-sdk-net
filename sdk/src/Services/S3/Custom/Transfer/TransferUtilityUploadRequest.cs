/*******************************************************************************
 *  Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Collections.Specialized;
using System.IO;
using System.Text;

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.S3.Model;
using Amazon.Util;

namespace Amazon.S3.Transfer
{
    /// <summary>
    /// Contains all the parameters
    /// that can be set when making a this request with the 
    /// <c>TransferUtility</c> method.
    /// </summary>
    public partial class TransferUtilityUploadRequest : BaseUploadRequest
    {
        private string key;
        private long? partSize;
        private bool autoCloseStream = true;
        private bool autoResetStreamPosition = true;
        private string _checksumCRC32;
        private string _checksumCRC32C;
        private string _checksumCRC64NVME;
        private string _checksumSHA1;
        private string _checksumSHA256;
        private string _ifNoneMatch;
        private string _ifMatch;
        private long? _mpuObjectSize;

        private Stream inputStream;

        #region Key
        /// <summary>
        /// 	Gets or sets the key under which the Amazon S3 object is to be stored.
        /// </summary>
        /// <value>
        /// 	The key under which the Amazon S3 object is to be stored. 
        /// </value>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }


        /// <summary>
        /// Checks if Key property is set.
        /// </summary>
        /// <returns>true if Key property is set.</returns>
        internal bool IsSetKey()
        {
            return !System.String.IsNullOrEmpty(this.key);
        }

        #endregion

        /// <summary>
        /// Input stream for the request; content for the request will be read from the stream.
        /// </summary>
        public Stream InputStream
        {
            get { return this.inputStream; }
            set { this.inputStream = value; }
        }

        // Check to see if InputStream property is set
        internal bool IsSetInputStream()
        {
            return this.inputStream != null;
        }

        /// <summary>
        /// <para>
        /// 	Gets or sets the file path
        /// 	where the Amazon S3 object will be uploaded from.
        /// </para>
        /// <para>
        ///     For WinRT and Windows Phone this property must be in the form of "ms-appdata:///local/file.txt".
        /// </para>
        /// </summary>
        /// <value>
        /// 	The file path where the Amazon S3 object will be uploaded from.
        /// </value>
        public string FilePath { get; set; }

        /// <summary>
        /// Checks if FilePath property is set.
        /// </summary>
        /// <returns>true if FilePath property is set.</returns>
        internal bool IsSetFilePath()
        {
            return !string.IsNullOrEmpty(this.FilePath);
        }

        /// <summary>
        /// 	Gets or sets the part size of the upload in bytes.
        /// 	The uploaded file will be divided into 
        /// 	parts the size specified and
        /// 	uploaded to Amazon S3 individually.
        /// </summary>
        /// <value>
        /// 	The part size of the upload.
        /// </value>
        public long PartSize
        {
            get { return this.partSize.GetValueOrDefault(); }
            set { this.partSize = value; }
        }


        /// <summary>
        /// Checks if PartSize property is set.
        /// </summary>
        /// <returns>true if PartSize property is set.</returns>
        internal bool IsSetPartSize()
        {
            return this.partSize.HasValue;
        }

        /// <summary>
        /// The event for UploadProgressEvent notifications. All
        /// subscribers will be notified when a new progress
        /// event is raised.
        /// <para>
        /// The UploadProgressEvent is fired as data
        /// is uploaded to S3.  The delegates attached to the event 
        /// will be passed information detailing how much data
        /// has been uploaded as well as how much will be uploaded.
        /// </para>
        /// </summary>
        /// <remarks>
        /// Subscribe to this event if you want to receive
        /// UploadProgressEvent notifications. Here is how:<br />
        /// 1. Define a method with a signature similar to this one:
        /// <code>
        /// private void displayProgress(object sender, UploadProgressArgs args)
        /// {
        ///     Console.WriteLine(args);
        /// }
        /// </code>
        /// 2. Add this method to the UploadProgressEvent delegate's invocation list
        /// <code>
        /// TransferUtilityUploadRequest request = new TransferUtilityUploadRequest();
        /// request.UploadProgressEvent += displayProgress;
        /// </code>
        /// </remarks>
        public event EventHandler<UploadProgressArgs> UploadProgressEvent;

        /// <summary>
        /// The event for UploadInitiatedEvent notifications. All
        /// subscribers will be notified when a transfer operation
        /// starts.
        /// <para>
        /// The UploadInitiatedEvent is fired exactly once when 
        /// a transfer operation begins. The delegates attached to the event 
        /// will be passed information about the upload request and 
        /// total file size, but no progress information.
        /// </para>
        /// </summary>
        /// <remarks>
        /// Subscribe to this event if you want to receive
        /// UploadInitiatedEvent notifications. Here is how:<br />
        /// 1. Define a method with a signature similar to this one:
        /// <code>
        /// private void uploadStarted(object sender, UploadInitiatedEventArgs args)
        /// {
        ///     Console.WriteLine($"Upload started: {args.FilePath}");
        ///     Console.WriteLine($"Total size: {args.TotalBytes} bytes");
        ///     Console.WriteLine($"Bucket: {args.Request.BucketName}");
        ///     Console.WriteLine($"Key: {args.Request.Key}");
        /// }
        /// </code>
        /// 2. Add this method to the UploadInitiatedEvent delegate's invocation list
        /// <code>
        /// TransferUtilityUploadRequest request = new TransferUtilityUploadRequest();
        /// request.UploadInitiatedEvent += uploadStarted;
        /// </code>
        /// </remarks>
        public event EventHandler<UploadInitiatedEventArgs> UploadInitiatedEvent;

        /// <summary>
        /// The event for UploadCompletedEvent notifications. All
        /// subscribers will be notified when a transfer operation
        /// completes successfully.
        /// <para>
        /// The UploadCompletedEvent is fired exactly once when 
        /// a transfer operation completes successfully. The delegates attached to the event 
        /// will be passed information about the completed upload including
        /// the final response from S3 with ETag, VersionId, and other metadata.
        /// </para>
        /// </summary>
        /// <remarks>
        /// Subscribe to this event if you want to receive
        /// UploadCompletedEvent notifications. Here is how:<br />
        /// 1. Define a method with a signature similar to this one:
        /// <code>
        /// private void uploadCompleted(object sender, UploadCompletedEventArgs args)
        /// {
        ///     Console.WriteLine($"Upload completed: {args.FilePath}");
        ///     Console.WriteLine($"Transferred: {args.TransferredBytes} bytes");
        ///     Console.WriteLine($"ETag: {args.Response.ETag}");
        ///     Console.WriteLine($"S3 Key: {args.Response.Key}");
        ///     Console.WriteLine($"Version ID: {args.Response.VersionId}");
        /// }
        /// </code>
        /// 2. Add this method to the UploadCompletedEvent delegate's invocation list
        /// <code>
        /// TransferUtilityUploadRequest request = new TransferUtilityUploadRequest();
        /// request.UploadCompletedEvent += uploadCompleted;
        /// </code>
        /// </remarks>
        public event EventHandler<UploadCompletedEventArgs> UploadCompletedEvent;

        /// <summary>
        /// The event for UploadFailedEvent notifications. All
        /// subscribers will be notified when a transfer operation
        /// fails.
        /// <para>
        /// The UploadFailedEvent is fired exactly once when 
        /// a transfer operation fails. The delegates attached to the event 
        /// will be passed information about the failed upload including
        /// partial progress information, but no response data since the upload failed.
        /// </para>
        /// </summary>
        /// <remarks>
        /// Subscribe to this event if you want to receive
        /// UploadFailedEvent notifications. Here is how:<br />
        /// 1. Define a method with a signature similar to this one:
        /// <code>
        /// private void uploadFailed(object sender, UploadFailedEventArgs args)
        /// {
        ///     Console.WriteLine($"Upload failed: {args.FilePath}");
        ///     Console.WriteLine($"Partial progress: {args.TransferredBytes} / {args.TotalBytes} bytes");
        ///     var percent = (double)args.TransferredBytes / args.TotalBytes * 100;
        ///     Console.WriteLine($"Completion: {percent:F1}%");
        ///     Console.WriteLine($"Bucket: {args.Request.BucketName}");
        ///     Console.WriteLine($"Key: {args.Request.Key}");
        /// }
        /// </code>
        /// 2. Add this method to the UploadFailedEvent delegate's invocation list
        /// <code>
        /// TransferUtilityUploadRequest request = new TransferUtilityUploadRequest();
        /// request.UploadFailedEvent += uploadFailed;
        /// </code>
        /// </remarks>
        public event EventHandler<UploadFailedEventArgs> UploadFailedEvent;

        /// <summary>
        /// Causes the UploadInitiatedEvent event to be fired.
        /// </summary>
        /// <param name="args">UploadInitiatedEventArgs args</param>
        internal void OnRaiseTransferInitiatedEvent(UploadInitiatedEventArgs args)
        {
            AWSSDKUtils.InvokeInBackground(UploadInitiatedEvent, args, this);
        }

        /// <summary>
        /// Causes the UploadCompletedEvent event to be fired.
        /// </summary>
        /// <param name="args">UploadCompletedEventArgs args</param>
        internal void OnRaiseTransferCompletedEvent(UploadCompletedEventArgs args)
        {
            AWSSDKUtils.InvokeInBackground(UploadCompletedEvent, args, this);
        }

        /// <summary>
        /// Causes the UploadFailedEvent event to be fired.
        /// </summary>
        /// <param name="args">UploadFailedEventArgs args</param>
        internal void OnRaiseTransferFailedEvent(UploadFailedEventArgs args)
        {
            AWSSDKUtils.InvokeInBackground(UploadFailedEvent, args, this);
        }


        /// <summary>
        /// Causes the UploadProgressEvent event to be fired.
        /// </summary>
        /// <param name="progressArgs">Progress data for the file being uploaded.</param>        
        internal void OnRaiseProgressEvent(UploadProgressArgs progressArgs)
        {
            AWSSDKUtils.InvokeInBackground(UploadProgressEvent, progressArgs, this);
        }


        /// <summary>
        /// Gets the length of the content by either checking the FileInfo.Length property or the Stream.Length property.
        /// </summary>
        /// <value>The length of the content.</value>
        internal long ContentLength
        {
            get
            {
                long length;
                try
                {
                    if (this.IsSetFilePath())
                    {
                        //System.IO.
                        FileInfo fileInfo = new FileInfo(this.FilePath);
                        length = fileInfo.Length;
                    }
                    else
                    {
                        length = this.InputStream.Length - this.InputStream.Position;
                    }
                }
                catch (NotSupportedException)
                {
                    //length is unknown
                    length = -1;
                }


                return length;
            }
        }

        #region AutoCloseStream
        /// <summary>
        /// 	Gets or sets whether or not the stream used with this request is
        /// 	automatically closed when all of the content is read from the stream.         
        /// </summary>
        /// <value>
        /// 	A value of <c>true</c> if the if the stream is
        /// 	automatically closed when all of the content is read from the stream.
        /// 	A value of <c>false</c> if otherwise. 		
        /// </value>
        public bool AutoCloseStream
        {
            get { return this.autoCloseStream; }
            set { this.autoCloseStream = value; }
        }

        /// <summary>
        /// If this value is set to true then the stream's position will be reset to the start before being read for upload.
        /// Default: true.
        /// </summary>
        public bool AutoResetStreamPosition
        {
            get { return this.autoResetStreamPosition; }
            set { this.autoResetStreamPosition = value; }
        }

        /// <summary>
        /// 	Sets whether or not the stream used with this request is
        /// 	automatically closed when all of the content is read from the stream
        ///   	and returns this object instance, 
        /// 	enabling additional method calls to be chained together.
        /// </summary>
        /// <param name="autoCloseStream">
        /// 	A value of <c>true</c> if the if the stream is
        /// 	automatically closed when all of the content is read from the stream.
        /// 	A value of <c>false</c> if otherwise. 	
        /// </param>
        /// <returns>
        /// 	This object instance, enabling additional method calls to be chained together.
        /// </returns>
        public TransferUtilityUploadRequest WithAutoCloseStream(bool autoCloseStream)
        {
            this.autoCloseStream = autoCloseStream;
            return this;
        }
        #endregion

        /// <summary>
        /// Gets and sets the property ChecksumCRC32. 
        /// <para>
        /// This specifies the Base64 encoded, 32-bit <c>CRC-32C</c> checksum of the object. 
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking object integrity</a>
        /// in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string ChecksumCRC32
        {
            get { return this._checksumCRC32; }
            set { this._checksumCRC32 = value; }
        }

        /// <summary>
        /// Checks if ChecksumCRC32 property is set.
        /// </summary>
        /// <returns>true if ChecksumCRC32 property is set.</returns>
        internal bool IsSetChecksumCRC32()
        {
            return !string.IsNullOrEmpty(this._checksumCRC32);
        }

        /// <summary>
        /// Gets and sets the property ChecksumCRC32C. 
        /// <para>
        /// This specifies the Base64 encoded, 32-bit <c>CRC-32C</c> checksum of the object. 
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking object integrity</a>
        /// in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string ChecksumCRC32C
        {
            get { return this._checksumCRC32C; }
            set { this._checksumCRC32C = value; }
        }

        /// <summary>
        /// Checks if ChecksumCRC32C property is set.
        /// </summary>
        /// <returns>true if ChecksumCRC32C property is set.</returns>
        internal bool IsSetChecksumCRC32C()
        {
            return !string.IsNullOrEmpty(this._checksumCRC32C);
        }

        /// <summary>
        /// Gets and sets the property ChecksumCRC64NVME. 
        /// <para>
        /// This specifies the Base64 encoded, 64-bit <c>CRC-64NVME</c> checksum of the object. 
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking object integrity</a>
        /// in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string ChecksumCRC64NVME
        {
            get { return this._checksumCRC64NVME; }
            set { this._checksumCRC64NVME = value; }
        }

        /// <summary>
        /// Checks if ChecksumCRC64NVME property is set.
        /// </summary>
        /// <returns>true if ChecksumCRC64NVME property is set.</returns>
        internal bool IsSetChecksumCRC64NVME()
        {
            return !string.IsNullOrEmpty(this._checksumCRC64NVME);
        }

        /// <summary>
        /// Gets and sets the property ChecksumSHA1. 
        /// <para>
        /// This specifies the Base64 encoded, 160-bit <c>SHA-1</c> digest of the object. 
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking object integrity</a>
        /// in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string ChecksumSHA1
        {
            get { return this._checksumSHA1; }
            set { this._checksumSHA1 = value; }
        }

        /// <summary>
        /// Checks if ChecksumSHA1 property is set.
        /// </summary>
        /// <returns>true if ChecksumSHA1 property is set.</returns>
        internal bool IsSetChecksumSHA1()
        {
            return !string.IsNullOrEmpty(this._checksumSHA1);
        }

        /// <summary>
        /// Gets and sets the property ChecksumSHA256. 
        /// <para>
        /// This specifies the Base64 encoded, 256-bit <c>SHA-256</c> digest of the object. 
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking object integrity</a>
        /// in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string ChecksumSHA256
        {
            get { return this._checksumSHA256; }
            set { this._checksumSHA256 = value; }
        }

        /// <summary>
        /// Checks if ChecksumSHA256 property is set.
        /// </summary>
        /// <returns>true if ChecksumSHA256 property is set.</returns>
        internal bool IsSetChecksumSHA256()
        {
            return !string.IsNullOrEmpty(this._checksumSHA256);
        }

        /// <summary>
        /// Gets and sets the property IfNoneMatch used when CompleteMultipartUploadRequest is called to 
        /// complete the multipart upload.
        /// <para>Uploads the object only if the object key name does not already exist in the bucket specified. Otherwise, 
        /// Amazon S3 returns a <c>412 Precondition Failed</c> error.</para> <para>If a conflicting operation occurs 
        /// during the upload S3 returns a <c>409 ConditionalRequestConflict</c> response. On a 409 failure you should 
        /// re-initiate the multipart upload with <c>CreateMultipartUpload</c> and re-upload each part.</para> <para>Expects 
        /// the '*' (asterisk) character.</para> <para>For more information about conditional requests, 
        /// see <a href="https://tools.ietf.org/html/rfc7232">RFC 7232</a>, or <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/conditional-requests.html">Conditional requests</a> 
        /// in the <i>Amazon S3 User Guide</i>.</para>
        /// </summary>
        public string IfNoneMatch
        {
            get { return this._ifNoneMatch; }
            set { this._ifNoneMatch = value; }
        }

        /// <summary>
        /// Checks to see if IfNoneMatch is set.
        /// </summary>
        /// <returns>true, if IfNoneMatch property is set.</returns>
        internal bool IsSetIfNoneMatch()
        {
            return !string.IsNullOrEmpty(this._ifNoneMatch);
        }

        /// <summary>
        /// Gets and sets the property IfMatch used when CompleteMultipartUploadRequest is called to 
        /// complete the multipart upload.
        /// <para>Uploads the object only if the ETag (entity tag) value provided during the WRITE operation matches the ETag of the object in S3. If the ETag values do not match, the operation returns a <c>412 Precondition Failed</c> error.</para>
        /// <para>If a conflicting operation occurs during the upload S3 returns a <c>409 ConditionalRequestConflict</c> response. On a 409 failure you should fetch the object's ETag and retry the upload.</para>
        /// <para>Expects the ETag value as a string.</para>
        /// <para>For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC 7232</a>, or <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/conditional-requests.html">Conditional requests</a> in the <i>Amazon S3 User Guide</i>.</para>
        /// </summary>
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }

        /// <summary>
        /// Checks to see if IfMatch is set.
        /// </summary>
        /// <returns>true, if IfMatch property is set.</returns>
        internal bool IsSetIfMatch()
        {
            return !string.IsNullOrEmpty(this._ifMatch);
        }
        /// <summary>
        /// Gets and sets the property MpuObjectSize. 
        /// <para>
        /// The expected total object size of the multipart upload request.
        /// If there's a mismatch between the specified object size value and the actual
        /// object size value, it results in an <c>HTTP 400 InvalidRequest</c> error.
        /// </para>
        /// </summary>
        public long MpuObjectSize
        {
            get { return this._mpuObjectSize.GetValueOrDefault(); }
            set { this._mpuObjectSize = value; }
        }

        /// <summary>
        /// Checks if MpuObjectSize property is set.
        /// </summary>
        /// <returns>true if MpuObjectSize property is set.</returns>
        internal bool IsSetMpuObjectSize()
        {
            return this._mpuObjectSize.HasValue;
        }
    }
    
    /// <summary>
    /// Encapsulates the information needed to provide
    /// transfer progress to subscribers of the Put Object
    /// Event.
    /// </summary>
    public class UploadProgressArgs : TransferProgressArgs
    {
        /// <summary>
        /// The constructor takes the number of
        /// currently transferred bytes and the
        /// total number of bytes to be transferred
        /// </summary>
        /// <param name="incrementTransferred">How many bytes were transferred since last event.</param>
        /// <param name="transferred">The number of bytes transferred</param>
        /// <param name="total">The total number of bytes to be transferred</param>
        public UploadProgressArgs(long incrementTransferred, long transferred, long total)
            : base(incrementTransferred, transferred, total)
        {
        }

        /// <summary>
        /// The constructor takes the number of
        /// currently transferred bytes and the
        /// total number of bytes to be transferred
        /// </summary>
        /// <param name="incrementTransferred">How many bytes were transferred since last event.</param>
        /// <param name="transferred">The number of bytes transferred</param>
        /// <param name="total">The total number of bytes to be transferred</param>        
        /// <param name="filePath">The file being uploaded</param>
        public UploadProgressArgs(long incrementTransferred, long transferred, long total, string filePath)
            : this(incrementTransferred, transferred, total, 0, filePath)
        {
        }

        /// <summary>
        /// The constructor takes the number of
        /// currently transferred bytes and the
        /// total number of bytes to be transferred
        /// </summary>
        /// <param name="incrementTransferred">How many bytes were transferred since last event.</param>
        /// <param name="transferred">The number of bytes transferred</param>
        /// <param name="total">The total number of bytes to be transferred</param>
        /// <param name="compensationForRetry">A compensation for any upstream aggregators if this event to correct theit totalTransferred count,
        /// in case the underlying request is retried.</param>
        /// <param name="filePath">The file being uploaded</param>
        internal UploadProgressArgs(long incrementTransferred, long transferred, long total, long compensationForRetry, string filePath)
            : base(incrementTransferred, transferred, total)
        {
            this.FilePath = filePath;
            this.CompensationForRetry = compensationForRetry;
        }

        /// <summary>
        /// Constructor for upload progress with request
        /// </summary>
        /// <param name="incrementTransferred">How many bytes were transferred since last event.</param>
        /// <param name="transferred">The number of bytes transferred</param>
        /// <param name="total">The total number of bytes to be transferred</param>
        /// <param name="compensationForRetry">A compensation for any upstream aggregators if this event to correct their totalTransferred count,
        /// in case the underlying request is retried.</param>
        /// <param name="filePath">The file being uploaded</param>
        /// <param name="request">The original TransferUtilityUploadRequest created by the user</param>
        internal UploadProgressArgs(long incrementTransferred, long transferred, long total, long compensationForRetry, string filePath, TransferUtilityUploadRequest request)
            : base(incrementTransferred, transferred, total)
        {
            this.FilePath = filePath;
            this.CompensationForRetry = compensationForRetry;
            this.Request = request;
        }

        /// <summary>
        /// Gets the FilePath.
        /// </summary>
        public string FilePath { get; private set; }

        internal long CompensationForRetry { get; set; }

        /// <summary>
        /// The original TransferUtilityUploadRequest created by the user.
        /// </summary>
        public TransferUtilityUploadRequest Request { get; internal set; }
    }

    /// <summary>
    /// Encapsulates the information needed when a transfer operation is initiated.
    /// Provides access to the original request and total file size without any progress information.
    /// </summary>
    public class UploadInitiatedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the UploadInitiatedEventArgs class.
        /// </summary>
        /// <param name="request">The original TransferUtilityUploadRequest created by the user</param>
        /// <param name="filePath">The file being uploaded</param>
        /// <param name="totalBytes">The total number of bytes to be transferred</param>
        internal UploadInitiatedEventArgs(TransferUtilityUploadRequest request, string filePath, long totalBytes)
        {
            Request = request;
            FilePath = filePath;
            TotalBytes = totalBytes;
        }

        /// <summary>
        /// The original TransferUtilityUploadRequest created by the user.
        /// Contains all the upload parameters and configuration.
        /// </summary>
        public TransferUtilityUploadRequest Request { get; private set; }

        /// <summary>
        /// Gets the file being uploaded.
        /// </summary>
        public string FilePath { get; private set; }

        /// <summary>
        /// Gets the total number of bytes to be transferred.
        /// </summary>
        public long TotalBytes { get; private set; }
    }

    /// <summary>
    /// Encapsulates the information needed when a transfer operation completes successfully.
    /// Provides access to the original request, final response, and completion details.
    /// </summary>
    public class UploadCompletedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the UploadCompletedEventArgs class.
        /// </summary>
        /// <param name="request">The original TransferUtilityUploadRequest created by the user</param>
        /// <param name="response">The unified response from Transfer Utility</param>
        /// <param name="filePath">The file being uploaded</param>
        /// <param name="transferredBytes">The total number of bytes transferred</param>
        /// <param name="totalBytes">The total number of bytes that were transferred (should equal transferredBytes for successful uploads).</param>
        internal UploadCompletedEventArgs(TransferUtilityUploadRequest request, TransferUtilityUploadResponse response, string filePath, long transferredBytes, long totalBytes)
        {
            Request = request;
            Response = response; 
            FilePath = filePath;
            TransferredBytes = transferredBytes;
            TotalBytes = totalBytes;
        }

        /// <summary>
        /// The original TransferUtilityUploadRequest created by the user.
        /// Contains all the upload parameters and configuration.
        /// </summary>
        public TransferUtilityUploadRequest Request { get; private set; }

        /// <summary>
        /// The unified response from Transfer Utility after successful upload completion.
        /// Contains mapped fields from either PutObjectResponse (simple uploads) or CompleteMultipartUploadResponse (multipart uploads).
        /// </summary>
        public TransferUtilityUploadResponse Response { get; private set; }

        /// <summary>
        /// Gets the file being uploaded.
        /// </summary>
        public string FilePath { get; private set; }

        /// <summary>
        /// Gets the total number of bytes that were successfully transferred.
        /// </summary>
        public long TransferredBytes { get; private set; }

        /// <summary>
        /// Gets the total number of bytes that were transferred (should equal TransferredBytes for successful uploads).
        /// </summary>
        public long TotalBytes { get; private set; }
    }

    /// <summary>
    /// Encapsulates the information needed when a transfer operation fails.
    /// Provides access to the original request and partial progress information.
    /// </summary>
    public class UploadFailedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the UploadFailedEventArgs class.
        /// </summary>
        /// <param name="request">The original TransferUtilityUploadRequest created by the user</param>
        /// <param name="filePath">The file being uploaded</param>
        /// <param name="transferredBytes">The number of bytes transferred before failure</param>
        /// <param name="totalBytes">The total number of bytes that should have been transferred</param>
        internal UploadFailedEventArgs(TransferUtilityUploadRequest request, string filePath, long transferredBytes, long totalBytes)
        {
            Request = request;
            FilePath = filePath;
            TransferredBytes = transferredBytes;
            TotalBytes = totalBytes;
        }

        /// <summary>
        /// The original TransferUtilityUploadRequest created by the user.
        /// Contains all the upload parameters and configuration.
        /// </summary>
        public TransferUtilityUploadRequest Request { get; private set; }

        /// <summary>
        /// Gets the file being uploaded.
        /// </summary>
        public string FilePath { get; private set; }

        /// <summary>
        /// Gets the number of bytes that were transferred before the failure occurred.
        /// </summary>
        public long TransferredBytes { get; private set; }

        /// <summary>
        /// Gets the total number of bytes that should have been transferred.
        /// </summary>
        public long TotalBytes { get; private set; }
    }
}
