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
using System.IO;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using System.Linq;
using Amazon.S3.Model;
using Amazon.Util;
using Amazon.Runtime.Internal;
using System.Globalization;
using System.Threading;


namespace Amazon.S3.Transfer
{
    /// <summary>
    /// Request object for downloading a directory with the TransferUtility.
    /// </summary>
    public class TransferUtilityDownloadDirectoryRequest
    {
        private string bucketName;
        private string s3Directory;
        private string localDirectory;
        private bool downloadFilesConcurrently = false;
        private DateTime? modifiedSinceDate;
        private DateTime? unmodifiedSinceDate;
        private bool disableSlashCorrection = false;

        private ServerSideEncryptionCustomerMethod serverSideCustomerEncryption;
        private string serverSideEncryptionCustomerProvidedKey;
        private string serverSideEncryptionCustomerProvidedKeyMD5;

        private RequestPayer requestPayer;

        private string expectedBucketOwner;
        private string ifMatch;
        private string ifNoneMatch;
        private ResponseHeaderOverrides responseHeaders;
        private FailurePolicy failurePolicy = FailurePolicy.AbortOnFailure;

        /// <summary>
        /// Gets or sets the failure policy for the download directory operation.
        /// Determines whether the operation should abort or continue when a failure occurs during download.
        /// The default value is <see cref="FailurePolicy.AbortOnFailure"/>.
        /// </summary>
        public FailurePolicy FailurePolicy
        {
            get { return this.failurePolicy; }
            set { this.failurePolicy = value; }
        }
        
        /// <summary>
        /// Occurs when an individual object fails to download during a DownloadDirectory operation.
        /// </summary>
        /// <remarks>
        /// Subscribers will receive a <see cref="ObjectDownloadFailedEventArgs"/> instance containing
        /// the original <see cref="TransferUtilityDownloadDirectoryRequest"/>, the failed
        /// <see cref="TransferUtilityDownloadRequest"/>, and the exception that caused the failure.
        /// This event is raised on a background thread by the transfer utility.
        /// </remarks>
        /// <example>
        /// request.ObjectDownloadFailedEvent += (sender, args) =>
        /// {
        ///     // inspect args.DirectoryRequest, args.ObjectRequest, args.Exception
        /// };
        /// </example>
        public event EventHandler<ObjectDownloadFailedEventArgs> ObjectDownloadFailedEvent;

        /// <summary>
        /// Internal helper used by the transfer implementation to raise the <see cref="ObjectDownloadFailedEvent"/>.
        /// </summary>
        /// <param name="args">The details of the failed object download.</param>
        internal void OnRaiseObjectDownloadFailedEvent(ObjectDownloadFailedEventArgs args)
        {
            ObjectDownloadFailedEvent?.Invoke(this, args);
        }

        /// <summary>
        /// Occurs when the download directory operation is initiated.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The DownloadDirectoryInitiatedEvent is fired when the download directory operation begins.
        /// The DownloadDirectoryInitiatedEventArgs contains the original request information.
        /// </para>
        /// <para>
        /// Attach event handlers to this event if you are interested in receiving
        /// DownloadDirectoryInitiatedEvent notifications.
        /// </para>
        /// </remarks>
        /// <example>
        /// private void downloadStarted(object sender, DownloadDirectoryInitiatedEventArgs args)
        /// {
        ///     Console.WriteLine("Download directory started for bucket {0}", args.Request.BucketName);
        /// }
        /// </example>
        public event EventHandler<DownloadDirectoryInitiatedEventArgs> DownloadDirectoryInitiatedEvent;

        /// <summary>
        /// Occurs when the download directory operation is completed.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The DownloadDirectoryCompletedEvent is fired when the download directory operation is completed successfully.
        /// The DownloadDirectoryCompletedEventArgs contains a snapshot of the transfer state at completion.
        /// </para>
        /// <para>
        /// Attach event handlers to this event if you are interested in receiving
        /// DownloadDirectoryCompletedEvent notifications.
        /// </para>
        /// </remarks>
        /// <example>
        /// private void downloadCompleted(object sender, DownloadDirectoryCompletedEventArgs args)
        /// {
        ///     Console.WriteLine("Download directory completed with {0} files downloaded", args.TransferredFiles);
        /// }
        /// </example>
        public event EventHandler<DownloadDirectoryCompletedEventArgs> DownloadDirectoryCompletedEvent;

        /// <summary>
        /// Occurs when the download directory operation fails.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The DownloadDirectoryFailedEvent is fired when the download directory operation fails.
        /// The DownloadDirectoryFailedEventArgs contains a snapshot of the transfer state at failure.
        /// </para>
        /// <para>
        /// Attach event handlers to this event if you are interested in receiving
        /// DownloadDirectoryFailedEvent notifications.
        /// </para>
        /// </remarks>
        /// <example>
        /// private void downloadFailed(object sender, DownloadDirectoryFailedEventArgs args)
        /// {
        ///     Console.WriteLine("Download directory failed with {0} files downloaded out of {1} total", 
        ///                       args.TransferredFiles, args.TotalFiles);
        /// }
        /// </example>
        public event EventHandler<DownloadDirectoryFailedEventArgs> DownloadDirectoryFailedEvent;

        /// <summary>
        /// Raises the DownloadDirectoryInitiatedEvent.
        /// </summary>
        /// <param name="args">DownloadDirectoryInitiatedEventArgs args</param>
        internal void OnRaiseDownloadDirectoryInitiatedEvent(DownloadDirectoryInitiatedEventArgs args)
        {
            DownloadDirectoryInitiatedEvent?.Invoke(this, args);
        }

        /// <summary>
        /// Raises the DownloadDirectoryCompletedEvent.
        /// </summary>
        /// <param name="args">DownloadDirectoryCompletedEventArgs args</param>
        internal void OnRaiseDownloadDirectoryCompletedEvent(DownloadDirectoryCompletedEventArgs args)
        {
            DownloadDirectoryCompletedEvent?.Invoke(this, args);
        }

        /// <summary>
        /// Raises the DownloadDirectoryFailedEvent.
        /// </summary>
        /// <param name="args">DownloadDirectoryFailedEventArgs args</param>
        internal void OnRaiseDownloadDirectoryFailedEvent(DownloadDirectoryFailedEventArgs args)
        {
            DownloadDirectoryFailedEvent?.Invoke(this, args);
        }

        /// <summary>
        /// 	Gets or sets the name of the bucket.
        /// </summary>
        /// <value>
        /// 	The name of the bucket.
        /// </value>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Gets whether or not the bucket name is set.
        /// </summary>
        /// <returns>
        /// 	A value of <c>true</c> if the bucket name is set.
        ///    Otherwise, returns <c>false</c>.
        /// </returns>
        internal bool IsSetBucketName()
        {
            return !System.String.IsNullOrEmpty(this.bucketName);
        }


        /// <summary>
        /// 	Gets or sets the local directory where objects from Amazon S3 will be downloaded.  
		/// 	If the directory doesn't exist, it will be created.
        /// 	For some platforms like Linux, the file system is case-sensitive. The correct casing to the actual path must be used.
        /// </summary>
        /// <value>
        /// 	The local directory where objects from Amazon S3 will be downloaded.
        /// </value>
        public string LocalDirectory
        {
            get { return this.localDirectory; }
            set { this.localDirectory = value; }
        }

        /// <summary>
        /// 	Gets whether or not the LocalDirectory property is set.
        /// </summary>
        /// <returns>
        /// 	A value of <c>true</c> if LocalDirectory property is set.
        /// 	Otherwise, returns <c>false</c>.
        /// </returns>
        internal bool IsSetLocalDirectory()
        {
            return !System.String.IsNullOrEmpty(this.localDirectory);
        }

        /// <summary>
        /// Gets or sets the Amazon S3 directory to download from.  
        /// This is translated to a key prefix; keys that have this prefix will be
        /// downloaded.
        /// 
        /// The TransferUtility will automatically add a / to the end when listing objects for 
        /// to be downloaded. This treats S3Directory field as a virtual S3 directory. In some use
        /// cases the added / slash can be undesirable. To prevent the TransferUtility from adding 
        /// the / at the end set the DisableSlashCorrection property to true.
        /// </summary>
        public string S3Directory
        {
            get { return this.s3Directory; }
            set { this.s3Directory = value; }
        }


        /// <summary>
        /// 	Gets whether or not the S3Directory property is set.
        /// </summary>
        /// <returns>
        /// 	A value of <c>true</c> if S3Directory property is set.
        /// 	Otherwise, returns <c>false</c>.
        /// </returns>
        internal bool IsSetS3Directory()
        {
            return !System.String.IsNullOrEmpty(this.s3Directory);
        }

        /// <summary>
        /// 	Gets or sets the <c>ModifiedSinceDate</c> property.  
        /// 	Only objects that have been modified since this date will be
        /// 	downloaded.
        /// </summary>
        /// <value>
        /// 	The <c>ModifiedSinceDate</c> property. 
        /// </value>
        public DateTime ModifiedSinceDate
        {
            get { return this.modifiedSinceDate.GetValueOrDefault(); }
            set { this.modifiedSinceDate = value; }
        }

        /// <summary>
        /// Checks if ModifiedSinceDate property is set.
        /// </summary>
        /// <returns>A value of <c>true</c> if ModifiedSinceDate property is set.
        /// 	Otherwise, returns <c>false</c>.</returns>
        internal bool IsSetModifiedSinceDate()
        {
            return modifiedSinceDate.HasValue;
        }

        /// <summary>
        /// 	Gets or sets the <c>UnmodifiedSinceDate</c> property.  
        /// 	Only objects that have not been modified since this date will be downloaded.
        /// </summary>
        /// <value>
        /// 	The <c>UnmodifiedSinceDate</c> property.
        /// </value>
        public DateTime UnmodifiedSinceDate
        {
            get { return this.unmodifiedSinceDate.GetValueOrDefault(); }
            set { this.unmodifiedSinceDate = value; }
        }

        /// <summary>
        /// Checks if UnmodifiedSinceDate property is set.
        /// </summary>
        /// <returns>true if UnmodifiedSinceDate property is set.</returns>
        internal bool IsSetUnmodifiedSinceDate()
        {
            return unmodifiedSinceDate.HasValue;
        }

        /// <summary>
        /// Gets or sets the DownloadFilesConcurrently property.
        /// Specifies if multiple files will be downloaded concurrently.
        /// The number of concurrent web requests used is controlled 
        /// by the TransferUtilityConfig.ConcurrencyLevel property.
        /// </summary>
#if BCL || NETSTANDARD
        public
#else
        internal
#endif
        bool DownloadFilesConcurrently
        {
            get { return this.downloadFilesConcurrently; }
            set { this.downloadFilesConcurrently = value; }
        }

        /// <summary>
        /// If this is set to true then the TransferUtility will not ensure the S3Directory property has a trailing / for a virtual S3 directory. 
        /// The default value is false.
        /// </summary>
        public bool DisableSlashCorrection
        {
            get { return this.disableSlashCorrection; }
            set { this.disableSlashCorrection = value; }
        }

        /// <summary>
        /// The Server-side encryption algorithm to be used with the customer provided key.
        /// </summary>
        public ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod
        {
            get { return this.serverSideCustomerEncryption; }
            set { this.serverSideCustomerEncryption = value; }
        }

        /// <summary>
        /// The base64-encoded encryption key for Amazon S3 to use to decrypt the object
        /// <para>
        /// Using the encryption key you provide as part of your request Amazon S3 manages both the encryption, as it writes 
        /// to disks, and decryption, when you access your objects. Therefore, you don't need to maintain any data encryption code. The only 
        /// thing you do is manage the encryption keys you provide.
        /// </para>
        /// <para>
        /// When you retrieve an object, you must provide the same encryption key as part of your request. Amazon S3 first verifies 
        /// the encryption key you provided matches, and then decrypts the object before returning the object data to you.
        /// </para>
        /// <para>
        /// Important: Amazon S3 does not store the encryption key you provide.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true)]
        public string ServerSideEncryptionCustomerProvidedKey
        {
            get { return this.serverSideEncryptionCustomerProvidedKey; }
            set { this.serverSideEncryptionCustomerProvidedKey = value; }
        }

        /// <summary>
        /// The MD5 of the customer encryption key specified in the ServerSideEncryptionCustomerProvidedKey property. The MD5 is
        /// base 64 encoded. This field is optional, the SDK will calculate the MD5 if this is not set.
        /// </summary>
        public string ServerSideEncryptionCustomerProvidedKeyMD5
        {
            get { return this.serverSideEncryptionCustomerProvidedKeyMD5; }
            set { this.serverSideEncryptionCustomerProvidedKeyMD5 = value; }
        }

        /// <summary>
        /// Confirms that the requester knows that they will be charged for the request. 
        /// Bucket owners need not specify this parameter in their requests.
        /// </summary>
        public RequestPayer RequestPayer
        {
            get { return this.requestPayer; }
            set { this.requestPayer = value; }
        }
        
        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected bucket owner. If the account ID that you provide does
        /// not match the actual owner of the bucket, the request fails with the HTTP status code
        /// <c>403 Forbidden</c> (access denied).
        /// </para>
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this.expectedBucketOwner; }
            set { this.expectedBucketOwner = value; }
        }

        /// <summary>
        /// Checks to see if ExpectedBucketOwner is set.
        /// </summary>
        /// <returns>true, if ExpectedBucketOwner property is set.</returns>
        internal bool IsSetExpectedBucketOwner()
        {
            return !String.IsNullOrEmpty(this.expectedBucketOwner);
        }
        
        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// Return the object only if its entity tag (ETag) is the same as the one specified in this header;
        /// otherwise, return a <c>412 Precondition Failed</c> error.
        /// </para>
        /// <para>
        /// If both of the <c>If-Match</c> and <c>If-Unmodified-Since</c> headers are present in the request as follows:
        /// <c>If-Match</c> condition evaluates to <c>true</c>, and; <c>If-Unmodified-Since</c> condition evaluates to <c>false</c>;
        /// then, S3 returns <c>200 OK</c> and the data requested.
        /// </para>
        /// <para>
        /// For more information about conditional requests, see <see href="https://tools.ietf.org/html/rfc7232">RFC 7232</see>.
        /// </para>
        /// </summary>
        public string IfMatch
        {
            get { return this.ifMatch; }
            set { this.ifMatch = value; }
        }

        /// <summary>
        /// Checks to see if IfMatch is set.
        /// </summary>
        /// <returns>true, if IfMatch property is set.</returns>
        internal bool IsSetIfMatch()
        {
            return !String.IsNullOrEmpty(this.ifMatch);
        }
        
        /// <summary>
        /// Gets and sets the property IfNoneMatch. 
        /// <para>
        /// Return the object only if its entity tag (ETag) is different from the one specified in this header;
        /// otherwise, return a <c>304 Not Modified</c> error.
        /// </para>
        /// <para>
        /// If both of the <c>If-None-Match</c> and <c>If-Modified-Since</c> headers are present in the request as follows:
        /// <c> If-None-Match</c> condition evaluates to <c>false</c>, and; <c>If-Modified-Since</c> condition evaluates to <c>true</c>;
        /// then, S3 returns <c>304 Not Modified</c> HTTP status code.
        /// </para>
        /// <para>
        /// For more information about conditional requests, see <see href="https://tools.ietf.org/html/rfc7232">RFC 7232</see>.
        /// </para>
        /// </summary>
        public string IfNoneMatch
        {
            get { return this.ifNoneMatch; }
            set { this.ifNoneMatch = value; }
        }

        /// <summary>
        /// Checks to see if IfNoneMatch is set.
        /// </summary>
        /// <returns>true, if IfNoneMatch property is set.</returns>
        internal bool IsSetIfNoneMatch()
        {
            return !String.IsNullOrEmpty(this.ifNoneMatch);
        }

        /// <summary>
        /// A set of response headers that should be returned with the object.
        /// </summary>
        public ResponseHeaderOverrides ResponseHeaderOverrides
        {
            get
            {
                if (this.responseHeaders == null)
                {
                    this.responseHeaders = new ResponseHeaderOverrides();
                }
                return this.responseHeaders;
            }
            set
            {
                this.responseHeaders = value;
            }
        }

        /// <summary>
        /// The event for DownloadedDirectoryProgressEvent notifications. All
        /// subscribers will be notified when a new progress
        /// event is raised.
        /// <para>
        /// The DownloadedDirectoryProgressEvent is fired as data
        /// is downloaded from Amazon S3.  The delegates attached to the event 
        /// will be passed information detailing how much data
        /// has been downloaded as well as how much will be downloaded.
        /// </para>
        /// </summary>
        /// <remarks>
        /// Subscribe to this event if you want to receive
        /// DownloadedDirectoryProgressEvent notifications. Here is how:<br />
        /// 1. Define a method with a signature similar to this one:
        /// <code>
        /// private void displayProgress(object sender, DownloadDirectoryProgressArgs args)
        /// {
        ///     Console.WriteLine(args);
        /// }
        /// </code>
        /// 2. Add this method to the DownloadedDirectoryProgressEvent delegate's invocation list
        /// <code>
        /// TransferUtilityDownloadDirectoryRequest request = new TransferUtilityDownloadDirectoryRequest();
        /// request.DownloadedDirectoryProgressEvent += displayProgress;
        /// </code>
        /// </remarks>
        public event EventHandler<DownloadDirectoryProgressArgs> DownloadedDirectoryProgressEvent;


        internal void OnRaiseProgressEvent(DownloadDirectoryProgressArgs downloadDirectoryProgress)
        {
            AWSSDKUtils.InvokeInBackground(DownloadedDirectoryProgressEvent, downloadDirectoryProgress, this);
        }
    }

    /// <summary>
    /// Encapsulates the information needed to provide
    /// transfer progress to subscribers of the <c>DownloadDirectory</c>
    /// event.
    /// </summary>
    public class DownloadDirectoryProgressArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of <c>DownloadDirectoryProgressArgs</c>.
        /// </summary>
        /// <param name="numberOfFilesDownloaded">
        /// The number of files downloaded.
        /// </param>
        /// <param name="totalNumberOfFiles">
        /// The total number of files to download.
        /// </param>
        /// <param name="currentFile">
        /// The current file being downloaded
        /// </param>
        /// <param name="transferredBytesForCurrentFile">
        /// The number of transferred bytes for the current file.
        /// </param>
        /// <param name="totalNumberOfBytesForCurrentFile">
        /// The size of the current file in bytes.
        /// </param>
        public DownloadDirectoryProgressArgs(int numberOfFilesDownloaded, int totalNumberOfFiles,
            string currentFile, long transferredBytesForCurrentFile, long totalNumberOfBytesForCurrentFile)
        {
            this.NumberOfFilesDownloaded = numberOfFilesDownloaded;
            this.TotalNumberOfFiles = totalNumberOfFiles;
            this.CurrentFile = currentFile;
            this.TransferredBytesForCurrentFile = transferredBytesForCurrentFile;
            this.TotalNumberOfBytesForCurrentFile = totalNumberOfBytesForCurrentFile;
        }

        /// <summary>
        /// Constructs a new instance of <c>DownloadDirectoryProgressArgs</c>.
        /// </summary>
        /// <param name="numberOfFilesDownloaded">
        /// The number of files downloaded.
        /// </param>
        /// <param name="totalNumberOfFiles">
        /// The total number of files to download.
        /// </param>
        /// <param name="transferredBytes">
        /// The bytes transferred across all files being downloaded.
        /// </param>
        /// <param name="totalBytes">
        /// The total number of bytes across all files being downloaded.
        /// </param>
        /// <param name="currentFile">
        /// The current file being downloaded.
        /// </param>
        /// <param name="transferredBytesForCurrentFile">
        /// The number of transferred bytes for the current file.
        /// </param>
        /// <param name="totalNumberOfBytesForCurrentFile">
        /// The size of the current file in bytes.
        /// </param>
        public DownloadDirectoryProgressArgs(int numberOfFilesDownloaded, int totalNumberOfFiles, long transferredBytes, long totalBytes,
            string currentFile, long transferredBytesForCurrentFile, long totalNumberOfBytesForCurrentFile)
        {
            this.NumberOfFilesDownloaded = numberOfFilesDownloaded;
            this.TotalNumberOfFiles = totalNumberOfFiles;
            this.TransferredBytes = transferredBytes;
            this.TotalBytes = totalBytes;
            this.CurrentFile = currentFile;
            this.TransferredBytesForCurrentFile = transferredBytesForCurrentFile;
            this.TotalNumberOfBytesForCurrentFile = totalNumberOfBytesForCurrentFile;
        }

        /// <summary>
        /// Gets or sets the total number of files.
        /// </summary>
        /// <value>The total number of files.</value>
        public int TotalNumberOfFiles { get; set; }

        /// <summary>
        /// Gets or sets the number of files downloaded so far.
        /// </summary>
        /// <value>The number of files downloaded.</value>
        public int NumberOfFilesDownloaded { get; set; }

        /// <summary>
        /// Gets or sets the total number of bytes across all files being downloaded.
        /// </summary>
        /// <value>The total number of bytes across all files being downloaded.</value>
        public long TotalBytes { get; set; }

        /// <summary>
        /// Gets or sets the bytes transferred across all files being downloaded.
        /// </summary>
        /// <value>The bytes transferred across all files being downloaded.</value>
        public long TransferredBytes { get; set; }


#if BCL
        /// <summary>
        /// Gets or sets the current file being downloaded.
        /// </summary>
        /// <remarks>
        /// This property is only valid if DownloadDirectory is used without enabling concurrent file downloads (by default concurrent download is disabled).
        /// If concurrent file downloads are enabled by setting TransferUtilityDownloadDirectoryRequest.DownloadFilesConcurrently to true, this property
        /// will return null.
        /// </remarks>
        /// <value>The current file being downloaded.</value>
#else
        /// <summary>
        /// Gets or sets the current file being downloaded.
        /// </summary>
        /// <value>The current file being downloaded.</value>
#endif
        public string CurrentFile { get; set; }

#if BCL
        /// <summary>
        /// Gets or sets the transferred bytes for the current file.
        /// </summary>
        /// <remarks>
        /// This property is only valid if DownloadDirectory is used without enabling concurrent file downloads (by default concurrent download is disabled).
        /// If concurrent file downloads are enabled by setting TransferUtilityDownloadDirectoryRequest.DownloadFilesConcurrently to true, this property
        /// will return 0.
        /// </remarks>
        /// <value>The transferred bytes for the current file.</value>
#else
        /// <summary>
        /// Gets or sets the transferred bytes for the current file.
        /// </summary>       
        /// <value>The transferred bytes for the current file.</value>
#endif
        public long TransferredBytesForCurrentFile { get; set; }

#if BCL
        /// <summary>
        /// Gets or sets the total number of bytes for the current file.
        /// </summary>
        /// <remarks>
        /// This property is only valid if DownloadDirectory is used without enabling concurrent file downloads (by default concurrent download is disabled).
        /// If concurrent file downloads are enabled by setting TransferUtilityDownloadDirectoryRequest.DownloadFilesConcurrently to true, this property
        /// will return 0.
        /// </remarks>
        /// <value>The total number of bytes for the current file.</value>
#else
        /// <summary>
        /// Gets or sets the total number of bytes for the current file.
        /// </summary>      
        /// <value>The total number of bytes for the current file.</value>
#endif
        public long TotalNumberOfBytesForCurrentFile { get; set; }

        /// <summary>
        /// The string representation of this instance of DownloadDirectoryProgressArgs.
        /// </summary>
        /// <returns>The string representation of this instance of DownloadDirectoryProgressArgs.</returns>
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "Total Files: {0}, Downloaded Files {1}, Total Bytes: {2}, Transferred Bytes: {3}",
                this.TotalNumberOfFiles, this.NumberOfFilesDownloaded, this.TotalBytes, this.TransferredBytes);
        }
    }
    
    /// <summary>
    /// Provides data for <see cref="TransferUtilityDownloadDirectoryRequest.ObjectDownloadFailedEvent"/>
    /// which is raised when an individual object fails to download during a
    /// DownloadDirectory operation.
    /// </summary>
    /// <remarks>
    /// Instances of this class are created by the transfer implementation and
    /// passed to event subscribers. The instance contains the original directory
    /// download request (<see cref="TransferUtilityDownloadDirectoryRequest"/>),
    /// the per-object download request that failed (<see cref="TransferUtilityDownloadRequest"/>),
    /// and the exception that caused the failure.
    /// </remarks>
    /// <example>
    /// <code>
    /// var request = new TransferUtilityDownloadDirectoryRequest { /* ... */ };
    /// request.ObjectDownloadFailedEvent += (sender, args) =>
    /// {
    ///     // args.DirectoryRequest: original directory request
    ///     // args.ObjectRequest: download request for the failed object
    ///     // args.Exception: exception thrown during the object download
    ///     Console.WriteLine($"Failed to download {args.ObjectRequest.Key}: {args.Exception}");
    /// };
    /// </code>
    /// </example>
    public class ObjectDownloadFailedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectDownloadFailedEventArgs"/> class.
        /// </summary>
        /// <param name="directoryRequest">The original <see cref="TransferUtilityDownloadDirectoryRequest"/> that initiated the directory download.</param>
        /// <param name="objectRequest">The <see cref="TransferUtilityDownloadRequest"/> representing the individual object download that failed.</param>
        /// <param name="exception">The <see cref="Exception"/> that caused the object download to fail.</param>
        internal ObjectDownloadFailedEventArgs(
            TransferUtilityDownloadDirectoryRequest directoryRequest,
            TransferUtilityDownloadRequest objectRequest,
            Exception exception)
        {
            DirectoryRequest = directoryRequest;
            ObjectRequest = objectRequest;
            Exception = exception;
        }

        /// <summary>
        /// Gets the original <see cref="TransferUtilityDownloadDirectoryRequest"/> that initiated the directory download.
        /// </summary>
        /// <value>
        /// The directory-level request that configured the overall DownloadDirectory operation
        /// (bucket, prefix, local directory, options, etc.).
        /// </value>
        public TransferUtilityDownloadDirectoryRequest DirectoryRequest { get; private set; }

        /// <summary>
        /// Gets the <see cref="TransferUtilityDownloadRequest"/> for the individual object that failed to download.
        /// </summary>
        /// <value>
        /// Contains per-object parameters such as the S3 key, version id (if set), and the local file path.
        /// </value>
        public TransferUtilityDownloadRequest ObjectRequest { get; private set; }

        /// <summary>
        /// Gets the <see cref="Exception"/> that caused the object download to fail.
        /// </summary>
        /// <value>
        /// The exception thrown by the underlying download operation. Can be an <see cref="Amazon.S3.AmazonS3Exception"/>,
        /// <see cref="Amazon.Runtime.AmazonClientException"/>, <see cref="IOException"/>, or other exception type depending
        /// on the failure mode.
        /// </value>
        public Exception Exception { get; private set; }
    }

    /// <summary>
    /// Provides data for <see cref="TransferUtilityDownloadDirectoryRequest.DownloadDirectoryInitiatedEvent"/>
    /// which is raised when a download directory operation is initiated.
    /// </summary>
    public class DownloadDirectoryInitiatedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the DownloadDirectoryInitiatedEventArgs class.
        /// </summary>
        /// <param name="request">The transfer request</param>
        internal DownloadDirectoryInitiatedEventArgs(TransferUtilityDownloadDirectoryRequest request)
        {
            Request = request;
        }

        /// <summary>
        /// Gets the request associated with this transfer operation.
        /// </summary>
        public TransferUtilityDownloadDirectoryRequest Request { get; private set; }
    }

    /// <summary>
    /// Provides data for <see cref="TransferUtilityDownloadDirectoryRequest.DownloadDirectoryCompletedEvent"/>
    /// which is raised when a download directory operation is completed successfully.
    /// </summary>
    public class DownloadDirectoryCompletedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the DownloadDirectoryCompletedEventArgs class.
        /// </summary>
        /// <param name="request">The transfer request</param>
        /// <param name="response">The transfer response</param>
        /// <param name="transferredBytes">The total number of bytes that have been transferred so far</param>
        /// <param name="totalBytes">The total size for all objects</param>
        /// <param name="transferredFiles">The total number of files that have been transferred so far</param>
        /// <param name="totalFiles">The total number of files</param>
        internal DownloadDirectoryCompletedEventArgs(TransferUtilityDownloadDirectoryRequest request, 
            TransferUtilityDownloadDirectoryResponse response, long transferredBytes, long totalBytes, 
            long transferredFiles, long totalFiles)
        {
            Request = request;
            Response = response;
            TransferredBytes = transferredBytes;
            TotalBytes = totalBytes;
            TransferredFiles = transferredFiles;
            TotalFiles = totalFiles;
        }

        /// <summary>
        /// Gets the request associated with this transfer operation.
        /// </summary>
        public TransferUtilityDownloadDirectoryRequest Request { get; private set; }

        /// <summary>
        /// Gets the response from the transfer operation.
        /// </summary>
        public TransferUtilityDownloadDirectoryResponse Response { get; private set; }

        /// <summary>
        /// Gets the total number of bytes that have been transferred so far.
        /// </summary>
        public long TransferredBytes { get; private set; }

        /// <summary>
        /// Gets the total size for all objects. Returns -1 if unknown.
        /// </summary>
        public long TotalBytes { get; private set; }

        /// <summary>
        /// Gets the total number of files that have been transferred so far.
        /// </summary>
        public long TransferredFiles { get; private set; }

        /// <summary>
        /// Gets the total number of files. Returns -1 if unknown.
        /// </summary>
        public long TotalFiles { get; private set; }
    }

    /// <summary>
    /// Provides data for <see cref="TransferUtilityDownloadDirectoryRequest.DownloadDirectoryFailedEvent"/>
    /// which is raised when a download directory operation fails.
    /// </summary>
    public class DownloadDirectoryFailedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the DownloadDirectoryFailedEventArgs class.
        /// </summary>
        /// <param name="request">The transfer request</param>
        /// <param name="transferredBytes">The total number of bytes that have been transferred so far</param>
        /// <param name="totalBytes">The total size for all objects</param>
        /// <param name="transferredFiles">The total number of files that have been transferred so far</param>
        /// <param name="totalFiles">The total number of files</param>
        internal DownloadDirectoryFailedEventArgs(TransferUtilityDownloadDirectoryRequest request, 
            long transferredBytes, long totalBytes, long transferredFiles, long totalFiles)
        {
            Request = request;
            TransferredBytes = transferredBytes;
            TotalBytes = totalBytes;
            TransferredFiles = transferredFiles;
            TotalFiles = totalFiles;
        }

        /// <summary>
        /// Gets the request associated with this transfer operation.
        /// </summary>
        public TransferUtilityDownloadDirectoryRequest Request { get; private set; }

        /// <summary>
        /// Gets the total number of bytes that have been transferred so far.
        /// </summary>
        public long TransferredBytes { get; private set; }

        /// <summary>
        /// Gets the total size for all objects. Returns -1 if unknown.
        /// </summary>
        public long TotalBytes { get; private set; }

        /// <summary>
        /// Gets the total number of files that have been transferred so far.
        /// </summary>
        public long TransferredFiles { get; private set; }

        /// <summary>
        /// Gets the total number of files. Returns -1 if unknown.
        /// </summary>
        public long TotalFiles { get; private set; }
    }
}
