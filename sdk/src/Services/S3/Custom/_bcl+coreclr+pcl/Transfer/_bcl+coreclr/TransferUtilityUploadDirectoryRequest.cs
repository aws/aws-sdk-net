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
using System.IO;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;

using Amazon.S3.Model;
using Amazon.Util;
using System.Globalization;

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
        string _bucketname;
        string _searchPattern = "*";
        string _keyPrefix;
        private bool _uploadFilesConcurrently = false;
        SearchOption _searchOption = SearchOption.TopDirectoryOnly;
        S3CannedACL _cannedACL;
        S3StorageClass _storageClass;
        MetadataCollection metadataCollection;
        ServerSideEncryptionMethod encryption;
        string serverSideEncryptionKeyManagementServiceKeyId;


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
        /// 	Gets or sets the name of the bucket.
        /// </summary>
        /// <value>
        /// 	The name of the bucket.
        /// </value>
        public string BucketName
        {
            get { return this._bucketname; }
            set { this._bucketname = value; }
        }

        /// <summary>
        /// Checks if BucketName property is set.
        /// </summary>
        /// <returns>true if BucketName property is set.</returns>
        internal bool IsSetBucketName()
        {
            return !System.String.IsNullOrEmpty(this._bucketname);
        }


        /// <summary>
        /// 	Gets or sets the canned access control list (ACL)
        /// 	for the uploaded objects.
        /// 	Please refer to 
        /// 	<see cref="T:Amazon.S3.S3CannedACL"/> for
        /// 	information on Amazon S3 canned ACLs.
        /// </summary>
        /// <value>
        /// 	The canned access control list (ACL)
        /// 	for the uploaded objects.
        /// </value>
        public S3CannedACL CannedACL
        {
            get { return this._cannedACL; }
            set { this._cannedACL = value; }
        }


        /// <summary>
        /// Checks if the CannedACL property is set.
        /// </summary>
        /// <returns>true if there is the CannedACL property is set.</returns>
        internal bool IsSetCannedACL()
        {
            return (_cannedACL != null &&_cannedACL != S3CannedACL.NoACL);
        }

        /// <summary>
        /// 	Gets or sets the storage class for the uploaded Amazon S3 objects.
        /// 	Please refer to 
        /// 	<see cref="T:Amazon.S3.S3StorageClass"/> for
        /// 	information on S3 Storage Classes.
        /// </summary>
        /// <value>
        /// 	The storage class for the uploaded Amazon S3 objects.
        /// </value>
        public S3StorageClass StorageClass
        {
            get { return this._storageClass; }
            set
            {
                this._storageClass = value;
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
            internal set { this.metadataCollection = value; }
        }


        /// <summary>
        /// Gets or sets the ServerSideEncryptionMethod property.
        /// Specifies the encryption used on the server to
        /// store the content.
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get { return this.encryption; }
            set { this.encryption = value; }
        }

        /// <summary>
        /// The id of the AWS Key Management Service key that Amazon S3 should use to encrypt and decrypt the object.
        /// If a key id is not specified, the default key will be used for encryption and decryption.
        /// </summary>
        public string ServerSideEncryptionKeyManagementServiceKeyId
        {
            get { return this.serverSideEncryptionKeyManagementServiceKeyId; }
            set { this.serverSideEncryptionKeyManagementServiceKeyId = value; }
        }


        /// <summary>
        /// Gets or sets the UploadFilesConcurrently property.
        /// Specifies if multiple files will be uploaded concurrently.
        /// The number of concurrent web requests used is controlled 
        /// by the TransferUtilityConfig.ConcurrencyLevel property.
        /// </summary>
#if BCL45
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

#if BCL45
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

        
#if BCL45
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

#if BCL45
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
}
