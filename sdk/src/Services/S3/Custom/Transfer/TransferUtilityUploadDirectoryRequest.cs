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

using Amazon.S3.Model;
using Amazon.Util;
using System.Globalization;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Transfer
{
    /// <summary>
    /// Contains all the parameters
    /// that can be set when making a this request with the 
    /// <c>TransferUtility</c> method.
    /// </summary>
    public class TransferUtilityUploadDirectoryRequest : BaseUploadRequest
    {
        string _directory;
        string _searchPattern = "*";
        string _keyPrefix;
        private bool _uploadFilesConcurrently = false;
        SearchOption _searchOption = SearchOption.TopDirectoryOnly;
        private FailurePolicy failurePolicy = FailurePolicy.AbortOnFailure;

        /// <summary>
        /// Gets or sets the failure policy for the upload directory operation.
        /// Determines whether the operation should abort or continue when a failure occurs during upload.
        /// The default value is <see cref="FailurePolicy.AbortOnFailure"/>.
        /// </summary>
        public FailurePolicy FailurePolicy
        {
            get { return this.failurePolicy; }
            set { this.failurePolicy = value; }
        }
        
        /// <summary>
        /// Occurs when the upload directory operation is initiated.
        /// </summary>
        /// <remarks>
        /// This event is raised before any files are uploaded, providing information about
        /// the total number of files and bytes that will be uploaded.
        /// </remarks>
        public event EventHandler<UploadDirectoryInitiatedEventArgs> UploadDirectoryInitiatedEvent;

        /// <summary>
        /// Occurs when the upload directory operation completes successfully.
        /// </summary>
        /// <remarks>
        /// This event is raised after all files have been processed (successfully or with failures),
        /// providing the final response and statistics.
        /// </remarks>
        public event EventHandler<UploadDirectoryCompletedEventArgs> UploadDirectoryCompletedEvent;

        /// <summary>
        /// Occurs when the upload directory operation fails.
        /// </summary>
        /// <remarks>
        /// This event is raised when the entire operation fails (not individual file failures).
        /// Individual file failures are reported through <see cref="ObjectUploadFailedEvent"/>.
        /// </remarks>
        public event EventHandler<UploadDirectoryFailedEventArgs> UploadDirectoryFailedEvent;

        /// <summary>
        /// Occurs when an individual object fails to upload during an UploadDirectory operation.
        /// </summary>
        /// <remarks>
        /// Subscribers will receive a <see cref="ObjectUploadFailedEventArgs"/> instance containing
        /// the original <see cref="TransferUtilityUploadDirectoryRequest"/>, the failed
        /// <see cref="TransferUtilityUploadRequest"/>, and the exception that caused the failure.
        /// This event is raised on a background thread by the transfer utility.
        /// </remarks>
        /// <example>
        /// request.ObjectUploadFailedEvent += (sender, args) =>
        /// {
        ///     // inspect args.DirectoryRequest, args.ObjectRequest, args.Exception
        /// };
        /// </example>
        public event EventHandler<ObjectUploadFailedEventArgs> ObjectUploadFailedEvent;

        /// <summary>
        /// Internal helper used by the transfer implementation to raise the <see cref="UploadDirectoryInitiatedEvent"/>.
        /// </summary>
        /// <param name="args">The event args.</param>
        internal void OnRaiseUploadDirectoryInitiatedEvent(UploadDirectoryInitiatedEventArgs args)
        {
            UploadDirectoryInitiatedEvent?.Invoke(this, args);
        }

        /// <summary>
        /// Internal helper used by the transfer implementation to raise the <see cref="UploadDirectoryCompletedEvent"/>.
        /// </summary>
        /// <param name="args">The event args.</param>
        internal void OnRaiseUploadDirectoryCompletedEvent(UploadDirectoryCompletedEventArgs args)
        {
            UploadDirectoryCompletedEvent?.Invoke(this, args);
        }

        /// <summary>
        /// Internal helper used by the transfer implementation to raise the <see cref="UploadDirectoryFailedEvent"/>.
        /// </summary>
        /// <param name="args">The event args.</param>
        internal void OnRaiseUploadDirectoryFailedEvent(UploadDirectoryFailedEventArgs args)
        {
            UploadDirectoryFailedEvent?.Invoke(this, args);
        }

        /// <summary>
        /// Internal helper used by the transfer implementation to raise the <see cref="ObjectUploadFailedEvent"/>.
        /// </summary>
        /// <param name="args">The details of the failed object upload.</param>
        internal void OnRaiseObjectUploadFailedEvent(ObjectUploadFailedEventArgs args)
        {
            ObjectUploadFailedEvent?.Invoke(this, args);
        }

        /// <summary>
        /// 	Gets or sets the directory where files are uploaded from.
        /// </summary>
        /// <value>
        /// 	The directory where files are uploaded from.
        /// </value>
        public string Directory
        {
            get { return this._directory; }
            set { this._directory = value; }
        }

        /// <summary>
        /// Checks if Directory property is set.
        /// </summary>
        /// <returns>true if Directory property is set.</returns>
        internal bool IsSetDirectory()
        {
            return !System.String.IsNullOrEmpty(this._directory);
        }

        /// <summary>
        /// 	Gets or sets the KeyPrefix property.  As object keys are generated for the
        /// 	files being uploaded this value will prefix the key.  This is useful when a directory
        /// 	needs to be uploaded into sub directory in the S3 Bucket.
        /// </summary>
        /// <value>
        /// 	The directory where files are uploaded from.
        /// </value>
        public string KeyPrefix
        {
            get { return this._keyPrefix; }
            set { this._keyPrefix = value; }
        }

        /// <summary>
        /// Checks if KeyPrefix property is set.
        /// </summary>
        /// <returns>true if KeyPrefix property is set.</returns>
        internal bool IsSetKeyPrefix()
        {
            return !System.String.IsNullOrEmpty(this._keyPrefix);
        }

        /// <summary>
        /// 	Gets and sets the search pattern used to determine which
        /// 	files in the directory are uploaded.    
        /// </summary>
        /// <value>
        /// 	The search pattern used to deterimine which
        /// 	files in the directory are uploaded.
        /// 	The default value is "*", specifying that all files
        /// 	in the directory will be uploaded.  
        /// </value>
        public string SearchPattern
        {
            get { return string.IsNullOrEmpty(this._searchPattern) ? "*" : this._searchPattern; }
            set { this._searchPattern = value; }
        }

        /// <summary>
        /// Checks if SearchPattern property is set.
        /// </summary>
        /// <returns>true if SearchPattern property is set.</returns>
        internal bool IsSetSearchPattern()
        {
            return !System.String.IsNullOrEmpty(this._searchPattern);
        }


        /// <summary>
        /// 	Gets or sets the recursive options for the directory upload.
        /// </summary>
        /// <value>
        /// 	The recursive options for the directory upload.
        /// 	Set by default to <c>TopDirectoryOnly</c>,
        /// 	specifying that files will be uploaded from the root directory only.
        /// </value>
        public SearchOption SearchOption
        {
            get { return this._searchOption; }
            set { this._searchOption = value; }
        }

        /// <summary>
        /// Gets or sets the UploadFilesConcurrently property.
        /// Specifies if multiple files will be uploaded concurrently.
        /// The number of concurrent web requests used is controlled 
        /// by the TransferUtilityConfig.ConcurrencyLevel property.
        /// </summary>
#if BCL || NETSTANDARD
        public
#else
        internal 
#endif
            bool UploadFilesConcurrently
        {
            get { return _uploadFilesConcurrently; }
            set { _uploadFilesConcurrently = value; }
        }
        


        /// <summary>
        /// The event for UploadDirectoryProgressEvent notifications. All
        /// subscribers will be notified when a new progress
        /// event is raised.
        /// <para>
        /// The UploadDirectoryProgressEvent is fired as data
        /// is uploaded to S3.  The delegates attached to the event 
        /// will be passed information detailing how much data
        /// has been uploaded as well as how much will be uploaded.
        /// </para>
        /// </summary>
        /// <remarks>
        /// Subscribe to this event if you want to receive
        /// UploadDirectoryProgressEvent notifications. Here is how:<br />
        /// 1. Define a method with a signature similar to this one:
        /// <code>
        /// private void displayProgress(object sender, UploadDirectoryProgressArgs args)
        /// {
        ///     Console.WriteLine(args);
        /// }
        /// </code>
        /// 2. Add this method to the UploadDirectoryProgressEvent delegate's invocation list
        /// <code>
        /// TransferUtilityUploadDirectoryRequest request = new TransferUtilityUploadDirectoryRequest();
        /// request.UploadDirectoryProgressEvent += displayProgress;
        /// </code>
        /// </remarks>
        public event EventHandler<UploadDirectoryProgressArgs> UploadDirectoryProgressEvent;

        /// <summary>
        /// The event for modifying individual TransferUtilityUploadRequest for each file
        /// being uploaded.
        /// </summary>
        public event EventHandler<UploadDirectoryFileRequestArgs> UploadDirectoryFileRequestEvent;

        /// <summary>
        /// Causes the UploadDirectoryProgressEvent event to be fired.
        /// </summary>
        /// <param name="uploadDirectoryProgress">Progress data for files currently being uploaded.</param>
        internal void OnRaiseProgressEvent(UploadDirectoryProgressArgs uploadDirectoryProgress)
        {
            AWSSDKUtils.InvokeInBackground(UploadDirectoryProgressEvent, uploadDirectoryProgress, this);
        }

        internal void RaiseUploadDirectoryFileRequestEvent(TransferUtilityUploadRequest request)
        {
            var targetEvent = UploadDirectoryFileRequestEvent;
            if (targetEvent != null)
            {
                var args = new UploadDirectoryFileRequestArgs(request);
                targetEvent(this, args);
            }
        }
    }

    /// <summary>
    /// Encapsulates the information needed to provide
    /// transfer progress to subscribers of the <c>UploadDirectory</c>
    /// event.
    /// </summary>
    public class UploadDirectoryProgressArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new instance of <c>UploadDirectoryProgressArgs</c>.
        /// </summary>
        /// <param name="numberOfFilesUploaded">
        /// The number of files uploaded.
        /// </param>
        /// <param name="totalNumberOfFiles">
        /// The total number of files to upload.
        /// </param>
        /// <param name="currentFile">
        /// The current file 
        /// </param>
        /// <param name="transferredBytesForCurrentFile">
        /// The number of transferred bytes for current file.
        /// </param>
        /// <param name="totalNumberOfBytesForCurrentFile">
        /// The size of the current file in bytes.
        /// </param>
        public UploadDirectoryProgressArgs(int numberOfFilesUploaded, int totalNumberOfFiles, 
            string currentFile, long transferredBytesForCurrentFile, long totalNumberOfBytesForCurrentFile)
        {
            this.NumberOfFilesUploaded = numberOfFilesUploaded;
            this.TotalNumberOfFiles = totalNumberOfFiles;
            this.CurrentFile = currentFile;
            this.TransferredBytesForCurrentFile = transferredBytesForCurrentFile;
            this.TotalNumberOfBytesForCurrentFile = totalNumberOfBytesForCurrentFile;
        }

        /// <summary>
        /// Constructs a new instance of <c>UploadDirectoryProgressArgs</c>.
        /// </summary>
        /// <param name="numberOfFilesUploaded">
        /// The number of files uploaded.
        /// </param>
        /// <param name="totalNumberOfFiles">
        /// The total number of files to upload.
        /// </param>
        /// <param name="transferredBytes">
        /// The bytes transferred across all files being uploaded.
        /// </param>
        /// <param name="totalBytes">
        /// The total number of bytes across all files being uploaded.
        /// </param>
        /// <param name="currentFile">
        /// The current file being uploaded.
        /// </param>
        /// <param name="transferredBytesForCurrentFile">
        /// The number of transferred bytes for current file.
        /// </param>
        /// <param name="totalNumberOfBytesForCurrentFile">
        /// The size of the current file in bytes.
        /// </param>
        public UploadDirectoryProgressArgs(int numberOfFilesUploaded, int totalNumberOfFiles, long transferredBytes, long totalBytes,
            string currentFile, long transferredBytesForCurrentFile, long totalNumberOfBytesForCurrentFile)
        {
            this.NumberOfFilesUploaded = numberOfFilesUploaded;
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
        /// Gets or sets the number of files uploaded.
        /// </summary>
        /// <value>The number of files uploaded.</value>
        public int NumberOfFilesUploaded { get; set; }

        /// <summary>
        /// Gets or sets the total number of bytes across all files being uploaded.
        /// </summary>
        /// <value>The total number of bytes across all files being uploaded.</value>
        public long TotalBytes { get; set; }

        /// <summary>
        /// Gets or sets the bytes transferred across all files being uploaded.
        /// </summary>
        /// <value>The bytes transferred across all files being uploaded.</value>
        public long TransferredBytes { get; set; }

#if BCL || NETSTANDARD
        /// <summary>
        /// Gets or sets the current file.
        /// </summary>
        /// <remarks>
        /// This property is only valid if UploadDirectory is used without enabling concurrent file uploads (by default concurrent upload is disabled).
        /// If concurrent file uploads are enabled by setting TransferUtilityUploadDirectoryRequest.UploadFilesConcurrently to true, this property
        /// will return null.
        /// </remarks>
        /// <value>The current file.</value>
#else
        /// <summary>
        /// Gets or sets the current file.
        /// </summary>
        /// <value>The current file.</value>
#endif
        public string CurrentFile { get; set; }

#if BCL || NETSTANDARD
        /// <summary>
        /// Gets or sets the transferred bytes for current file.
        /// </summary>
        /// <remarks>
        /// This property is only valid if UploadDirectory is used without enabling concurrent file uploads (by default concurrent upload is disabled).
        /// If concurrent file uploads are enabled by setting TransferUtilityUploadDirectoryRequest.UploadFilesConcurrently to true, this property
        /// will return 0.
        /// </remarks>
        /// <value>The transferred bytes for current file.</value>
#else
        /// <summary>
        /// Gets or sets the transferred bytes for current file.
        /// </summary>
        /// <value>The transferred bytes for current file.</value>
#endif
        public long TransferredBytesForCurrentFile { get; set; }

#if BCL || NETSTANDARD
        /// <summary>
        /// Gets or sets the total number of bytes for current file.
        /// </summary>
        /// <remarks>
        /// This property is only valid if UploadDirectory is used without enabling concurrent file uploads (by default concurrent upload is disabled).
        /// If concurrent file uploads are enabled by setting TransferUtilityUploadDirectoryRequest.UploadFilesConcurrently to true, this property
        /// will return 0.
        /// </remarks>
        /// <value>The total number of bytes for current file.</value>
#else
        /// <summary>
        /// Gets or sets the total number of bytes for current file.
        /// </summary>
        /// <value>The total number of bytes for current file.</value>
#endif
        public long TotalNumberOfBytesForCurrentFile { get; set; }

        /// <summary>
        /// The string representation of this instance of UploadDirectoryProgressArgs.
        /// </summary>
        /// <returns>The string representation of this instance of UploadDirectoryProgressArgs.</returns>
        public override string ToString()
        {
            return string.Format(CultureInfo.InvariantCulture, "Total Files: {0}, Uploaded Files {1}, Total Bytes: {2}, Transferred Bytes: {3}",
                this.TotalNumberOfFiles, this.NumberOfFilesUploaded, this.TotalBytes, this.TransferredBytes);
        }
    }

    /// <summary>
    /// Contains a single TransferUtilityUploadRequest corresponding
    /// to a single file about to be uploaded, allowing changes to
    /// the request before it is executed.
    /// </summary>
    public class UploadDirectoryFileRequestArgs : EventArgs
    {
        /// <summary>
        /// Constructs a new UploadDirectoryFileRequestArgs instance.
        /// </summary>
        /// <param name="request">Request being processed.</param>
        public UploadDirectoryFileRequestArgs(TransferUtilityUploadRequest request)
        {
            UploadRequest = request;
        }

        /// <summary>
        /// Gets and sets the UploadRequest property.
        /// </summary>
        public TransferUtilityUploadRequest UploadRequest { get; set; }
    }
    
    /// <summary>
    /// Provides data for <see cref="TransferUtilityUploadDirectoryRequest.UploadDirectoryInitiatedEvent"/>.
    /// </summary>
    public class UploadDirectoryInitiatedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDirectoryInitiatedEventArgs"/> class.
        /// </summary>
        /// <param name="request">The upload directory request.</param>
        /// <param name="totalFiles">The total number of files to upload.</param>
        /// <param name="totalBytes">The total number of bytes to upload.</param>
        internal UploadDirectoryInitiatedEventArgs(
            TransferUtilityUploadDirectoryRequest request,
            long totalFiles,
            long totalBytes)
        {
            Request = request;
            TotalFiles = totalFiles;
            TotalBytes = totalBytes;
        }

        /// <summary>
        /// Gets the upload directory request.
        /// </summary>
        public TransferUtilityUploadDirectoryRequest Request { get; private set; }

        /// <summary>
        /// Gets the total number of files to upload.
        /// </summary>
        public long TotalFiles { get; private set; }

        /// <summary>
        /// Gets the total number of bytes to upload.
        /// </summary>
        public long TotalBytes { get; private set; }
    }

    /// <summary>
    /// Provides data for <see cref="TransferUtilityUploadDirectoryRequest.UploadDirectoryCompletedEvent"/>.
    /// </summary>
    public class UploadDirectoryCompletedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDirectoryCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="request">The upload directory request.</param>
        /// <param name="response">The upload directory response.</param>
        /// <param name="transferredFiles">The number of files successfully uploaded.</param>
        /// <param name="totalFiles">The total number of files attempted.</param>
        /// <param name="transferredBytes">The number of bytes transferred.</param>
        /// <param name="totalBytes">The total number of bytes.</param>
        internal UploadDirectoryCompletedEventArgs(
            TransferUtilityUploadDirectoryRequest request,
            TransferUtilityUploadDirectoryResponse response,
            long transferredFiles,
            long totalFiles,
            long transferredBytes,
            long totalBytes)
        {
            Request = request;
            Response = response;
            TransferredFiles = transferredFiles;
            TotalFiles = totalFiles;
            TransferredBytes = transferredBytes;
            TotalBytes = totalBytes;
        }

        /// <summary>
        /// Gets the upload directory request.
        /// </summary>
        public TransferUtilityUploadDirectoryRequest Request { get; private set; }

        /// <summary>
        /// Gets the upload directory response.
        /// </summary>
        public TransferUtilityUploadDirectoryResponse Response { get; private set; }

        /// <summary>
        /// Gets the number of files successfully uploaded.
        /// </summary>
        public long TransferredFiles { get; private set; }

        /// <summary>
        /// Gets the total number of files attempted.
        /// </summary>
        public long TotalFiles { get; private set; }

        /// <summary>
        /// Gets the number of bytes transferred.
        /// </summary>
        public long TransferredBytes { get; private set; }

        /// <summary>
        /// Gets the total number of bytes.
        /// </summary>
        public long TotalBytes { get; private set; }
    }

    /// <summary>
    /// Provides data for <see cref="TransferUtilityUploadDirectoryRequest.UploadDirectoryFailedEvent"/>.
    /// </summary>
    public class UploadDirectoryFailedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadDirectoryFailedEventArgs"/> class.
        /// </summary>
        /// <param name="request">The upload directory request.</param>
        /// <param name="transferredFiles">The number of files successfully uploaded before failure.</param>
        /// <param name="totalFiles">The total number of files attempted.</param>
        /// <param name="transferredBytes">The number of bytes transferred before failure.</param>
        /// <param name="totalBytes">The total number of bytes.</param>
        internal UploadDirectoryFailedEventArgs(
            TransferUtilityUploadDirectoryRequest request,
            long transferredFiles,
            long totalFiles,
            long transferredBytes,
            long totalBytes)
        {
            Request = request;
            TransferredFiles = transferredFiles;
            TotalFiles = totalFiles;
            TransferredBytes = transferredBytes;
            TotalBytes = totalBytes;
        }

        /// <summary>
        /// Gets the upload directory request.
        /// </summary>
        public TransferUtilityUploadDirectoryRequest Request { get; private set; }

        /// <summary>
        /// Gets the number of files successfully uploaded before failure.
        /// </summary>
        public long TransferredFiles { get; private set; }

        /// <summary>
        /// Gets the total number of files attempted.
        /// </summary>
        public long TotalFiles { get; private set; }

        /// <summary>
        /// Gets the number of bytes transferred before failure.
        /// </summary>
        public long TransferredBytes { get; private set; }

        /// <summary>
        /// Gets the total number of bytes.
        /// </summary>
        public long TotalBytes { get; private set; }
    }

    /// <summary>
    /// Provides data for <see cref="TransferUtilityUploadDirectoryRequest.ObjectUploadFailedEvent"/>
    /// which is raised when an individual object fails to upload during an
    /// UploadDirectory operation.
    /// </summary>
    /// <remarks>
    /// Instances of this class are created by the transfer implementation and
    /// passed to event subscribers. The instance contains the original directory
    /// upload request (<see cref="TransferUtilityUploadDirectoryRequest"/>),
    /// the per-object upload request that failed (<see cref="TransferUtilityUploadRequest"/>),
    /// and the exception that caused the failure.
    /// </remarks>
    /// <example>
    /// <code>
    /// var request = new TransferUtilityUploadDirectoryRequest { /* ... */ };
    /// request.ObjectUploadFailedEvent += (sender, args) =>
    /// {
    ///     // args.DirectoryRequest: original directory request
    ///     // args.ObjectRequest: upload request for the failed object
    ///     // args.Exception: exception thrown during the object upload
    ///     Console.WriteLine($"Failed to upload {args.ObjectRequest.Key}: {args.Exception}");
    /// };
    /// </code>
    /// </example>
    public class ObjectUploadFailedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectUploadFailedEventArgs"/> class.
        /// </summary>
        /// <param name="directoryRequest">The original <see cref="TransferUtilityUploadDirectoryRequest"/> that initiated the directory upload.</param>
        /// <param name="objectRequest">The <see cref="TransferUtilityUploadRequest"/> representing the individual object upload that failed.</param>
        /// <param name="exception">The <see cref="Exception"/> that caused the object upload to fail.</param>
        internal ObjectUploadFailedEventArgs(
            TransferUtilityUploadDirectoryRequest directoryRequest,
            TransferUtilityUploadRequest objectRequest,
            Exception exception)
        {
            DirectoryRequest = directoryRequest;
            ObjectRequest = objectRequest;
            Exception = exception;
        }

        /// <summary>
        /// Gets the original <see cref="TransferUtilityUploadDirectoryRequest"/> that initiated the directory upload.
        /// </summary>
        /// <value>
        /// The directory-level request that configured the overall UploadDirectory operation.
        /// </value>
        public TransferUtilityUploadDirectoryRequest DirectoryRequest { get; private set; }

        /// <summary>
        /// Gets the <see cref="TransferUtilityUploadRequest"/> for the individual object that failed to upload.
        /// </summary>
        /// <value>
        /// Contains per-object parameters such as the S3 key and version id (if set).
        /// </value>
        public TransferUtilityUploadRequest ObjectRequest { get; private set; }

        /// <summary>
        /// Gets the <see cref="Exception"/> that caused the object upload to fail.
        /// </summary>
        /// <value>
        /// The exception thrown by the underlying upload operation. Can be an <see cref="Amazon.S3.AmazonS3Exception"/>,
        /// <see cref="Amazon.Runtime.AmazonClientException"/>, <see cref="IOException"/>, or other exception type depending
        /// on the failure mode.
        /// </value>
        public Exception Exception { get; private set; }
    }
}
