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
        SearchOption _searchOption = SearchOption.TopDirectoryOnly;
        S3CannedACL _cannedACL;
        S3StorageClass _storageClass;
        MetadataCollection metadataCollection;
        ServerSideEncryptionMethod encryption;


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
            get { return this._searchPattern; }
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
        /// 	<see cref="T:Amazon.S3.Model.S3CannedACL"/> for
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
        /// 	<see cref="T:Amazon.S3.Model.S3StorageClass"/> for
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
        /// Gets and sets the ServerSideEncryptionMethod property.
        /// Specifies the encryption used on the server to
        /// store the content.
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get { return this.encryption; }
            set { this.encryption = value; }
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
        /// Causes the UploadDirectoryProgressEvent event to be fired.
        /// </summary>
        /// <param name="numberOfFilesUploaded">The number of files uploaded.</param>
        /// <param name="totalNumberOfFiles">The total number of files.</param>
        /// <param name="currentFile">The current file.</param>
        /// <param name="transferredBytesForCurrentFile">The transferred bytes for current file.</param>
        /// <param name="totalNumberOfBytesForCurrentFile">The total number of bytes for current file.</param>
        internal void OnRaiseProgressEvent(int numberOfFilesUploaded, int totalNumberOfFiles,
            string currentFile, long transferredBytesForCurrentFile, long totalNumberOfBytesForCurrentFile)
        {
            AWSSDKUtils.InvokeInBackground(UploadDirectoryProgressEvent, new UploadDirectoryProgressArgs(numberOfFilesUploaded, totalNumberOfFiles, currentFile,
                        transferredBytesForCurrentFile, totalNumberOfBytesForCurrentFile), this);
        }
    }

    /// <summary>
    /// Encapsulates the information needed to provide
    /// transfer progress to subscribers of the <c>UploadDirectory</c>
    /// event.
    /// </summary>
    public class UploadDirectoryProgressArgs : EventArgs
    {
        int _totalNumberOfFiles;
        int _numberOfFilesUploaded;
        string _currentFile;
        long _transferredBytesForCurrentFile;
        long _totalNumberOfBytesForCurrentFile;

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
            this._numberOfFilesUploaded = numberOfFilesUploaded;
            this._totalNumberOfFiles = totalNumberOfFiles;
            this._currentFile = currentFile;
            this._transferredBytesForCurrentFile = transferredBytesForCurrentFile;
            this._totalNumberOfBytesForCurrentFile = totalNumberOfBytesForCurrentFile;
        }

        /// <summary>
        /// Gets or sets the total number of files.
        /// </summary>
        /// <value>The total number of files.</value>
        public int TotalNumberOfFiles
        {
            get { return this._totalNumberOfFiles; }
            set { this._totalNumberOfFiles = value; }
        }

        /// <summary>
        /// Gets or sets the number of files uploaded.
        /// </summary>
        /// <value>The number of files uploaded.</value>
        public int NumberOfFilesUploaded
        {
            get { return this._numberOfFilesUploaded; }
            set { this._numberOfFilesUploaded = value; }
        }

        /// <summary>
        /// Gets or sets the current file.
        /// </summary>
        /// <value>The current file.</value>
        public string CurrentFile
        {
            get { return this._currentFile; }
            set { this._currentFile = value; }
        }

        /// <summary>
        /// Gets or sets the transferred bytes for current file.
        /// </summary>
        /// <value>The transferred bytes for current file.</value>
        public long TransferredBytesForCurrentFile
        {
            get { return this._transferredBytesForCurrentFile; }
            set { this._transferredBytesForCurrentFile = value; }
        }

        /// <summary>
        /// Gets or sets the total number of bytes for current file.
        /// </summary>
        /// <value>The total number of bytes for current file.</value>
        public long TotalNumberOfBytesForCurrentFile
        {
            get { return this._totalNumberOfBytesForCurrentFile; }
            set { this._totalNumberOfBytesForCurrentFile = value; }
        }
    }

}
