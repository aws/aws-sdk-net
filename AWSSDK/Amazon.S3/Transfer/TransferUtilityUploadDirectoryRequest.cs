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
    public class TransferUtilityUploadDirectoryRequest
    {
        string _directory;
        string _bucketname;
        string _searchPattern = "*";
        string _keyPrefix;
        SearchOption _searchOption = SearchOption.TopDirectoryOnly;
        S3CannedACL _cannedACL;
        S3StorageClass _storageClass;
        int _timeout = 0;
        NameValueCollection _metadata;
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
        /// Sets the Directory property for this request.
        /// This is the location where files are uploaded from.
        /// </summary>
        /// <param name="directory">The value that Directory is set to</param>
        /// <returns>The request with the Directory set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TransferUtilityUploadDirectoryRequest WithDirectory(string directory)
        {
            this._directory = directory;
            return this;
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
        /// Sets the KeyPrefix property for this request.
        /// This value prefixed the generated object keys.
        /// </summary>
        /// <param name="keyPrefix">The value that KeyPrefix is set to</param>
        /// <returns>The request with the KeyPrefix set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TransferUtilityUploadDirectoryRequest WithKeyPrefix(string keyPrefix)
        {
            this._keyPrefix = keyPrefix;
            return this;
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
        /// 	Sets the search pattern used to determine which
        ///  	files in the directory are uploaded
        /// 	and returns this object instance, 
        /// 	enabling additional method calls to be chained together.
        /// 	The SearchPattern is used for searching files in the directory.
        /// 	The default is "*" which returns back all files.
        /// </summary>
        /// <param name="searchPattern">
        /// 	The search pattern used to deterimine which
        /// 	files in the directory are uploaded.
        /// 	The default value is "*", specifying that all files
        /// 	in the directory will be uploaded.  
        /// </param>
        /// <returns>
        /// 	This object instance, enabling additional method calls to be chained together.
        /// </returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TransferUtilityUploadDirectoryRequest WithSearchPattern(string searchPattern)
        {
            this._searchPattern = searchPattern;
            return this;
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
        ///	 	Sets the recursive options for the directory upload.
        /// 	and returns this object instance, 
        /// 	enabling additional method calls to be chained together.
        /// </summary>
        /// <param name="searchOption">
        /// 	The recursive option for the directory upload.
        /// 	Set by default to <c>TopDirectoryOnly</c>,
        /// 	specifying that files will be uploaded from the root directory only.
        /// </param>
        /// <returns>
        /// 	This object instance, enabling additional method calls to be chained together.
        /// </returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TransferUtilityUploadDirectoryRequest WithSearchOption(SearchOption searchOption)
        {
            this._searchOption = searchOption;
            return this;
        }

        #region BucketName

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
        ///	Sets the name of the bucket 
        ///   	and returns this object instance, 
        /// 	enabling additional method calls to be chained together.
        /// </summary>
        /// <param name="bucketName">
        /// 	The name of the bucket.
        /// </param>
        /// <returns>
        /// 	This object instance, enabling additional method calls to be chained together.
        /// </returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TransferUtilityUploadDirectoryRequest WithBucketName(string bucketName)
        {
            this._bucketname = bucketName;
            return this;
        }

        /// <summary>
        /// Checks if BucketName property is set.
        /// </summary>
        /// <returns>true if BucketName property is set.</returns>
        internal bool IsSetBucketName()
        {
            return !System.String.IsNullOrEmpty(this._bucketname);
        }

        #endregion

        #region CannedACL

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
        /// 	Sets the canned access control list (ACL)
        ///  	for the uploaded objects
        ///    and returns this object instance, 
        /// 	enabling additional method calls to be chained together.
        /// 	Please refer to 
        /// 	<see cref="T:Amazon.S3.Model.S3CannedACL"/> for
        /// 	information on Amazon S3 canned ACLs.
        /// </summary>
        /// <param name="acl">
        /// 	The canned access control list (ACL)
        /// 	for the uploaded objects.
        /// </param>
        /// <returns>
        /// 	This object instance, enabling additional method calls to be chained together.
        /// </returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TransferUtilityUploadDirectoryRequest WithCannedACL(S3CannedACL acl)
        {
            this._cannedACL = acl;
            return this;
        }

        /// <summary>
        /// Checks if the CannedACL property is set.
        /// </summary>
        /// <returns>true if there is the CannedACL property is set.</returns>
        internal bool IsSetCannedACL()
        {
            return (_cannedACL != S3CannedACL.NoACL);
        }

        /// <summary>
        /// 	Removes the cannned access control list (ACL)
        /// 	for the uploaded object.
        /// </summary>
        public void RemoveCannedACL()
        {
            this._cannedACL = S3CannedACL.NoACL;
        }

        #endregion

        #region Metadata

        /// <summary>
        /// This is exposed so we can copy the collection to the PUT object request
        /// created from this.
        /// </summary>
        internal NameValueCollection Metadata
        {
            get
            {
                if (this._metadata == null)
                    this._metadata = new NameValueCollection();
                return this._metadata;
            }
            set { this._metadata = value; }
        }

        /// <summary>
        /// 	Adds a set of key-value pairs to the request
        ///   	and returns this object instance, 
        /// 	enabling additional method calls to be chained together.
        /// </summary>
        /// <param name="key">
        /// 	The key to associate with the Amazon S3 object.
        /// </param>
        /// <param name="value">
        /// 	The value for the key.
        /// </param>
        /// <returns>
        /// 	This object instance, enabling additional method calls to be chained together.
        /// </returns>
        public TransferUtilityUploadDirectoryRequest WithMetadata(string key, string value)
        {
            if (key == null || value == null)
            {
                return this;
            }

            if (this._metadata == null)
            {
                this._metadata = new NameValueCollection(5);
            }

            this._metadata.Add(key, value);

            return this;
        }

        /// <summary>
        /// 	Adds a set of key-value pairs to the request
        ///   	and returns this object instance, 
        /// 	enabling additional method calls to be chained together.
        /// </summary>
        /// <param name="metaInfo">
        /// 	The set of key-value pairs 
        /// 	associated with the Amazon S3 object.
        /// </param>
        /// <returns>
        /// 	This object instance, enabling additional method calls to be chained together.
        /// </returns>
        public TransferUtilityUploadDirectoryRequest WithMetadata(NameValueCollection metaInfo)
        {
            if (metaInfo == null || metaInfo.Count == 0)
            {
                return this;
            }

            if (this._metadata == null)
            {
                this._metadata = new NameValueCollection(metaInfo.Count);
            }

            this._metadata.Add(metaInfo);

            return this;
        }

        /// <summary>
        /// Checks if Metadata property is set.
        /// </summary>
        /// <returns>true if Metadata property is set.</returns>
        internal bool IsSetMetadata()
        {
            return (this._metadata != null && this._metadata.Count > 0);
        }

        /// <summary>
        /// 	Removes a key from the metadata list if it was
        /// 	added previously.
        /// </summary>
        /// <param name="key">
        /// 	The key to remove.
        /// </param>
        public void RemoveMetadata(string key)
        {
            if (this._metadata == null || this._metadata.Count == 0)
            {
                return;
            }

            this._metadata.Remove(key);
        }

        #endregion

        #region StorageClass

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
                if (value >= S3StorageClass.Standard &&
                    value <= S3StorageClass.ReducedRedundancy)
                {
                    this._storageClass = value;
                }
            }
        }

        /// <summary>
        /// 	Sets the storage class for the uploaded Amazon S3 object.
        ///   	and returns this object instance, 
        /// 	enabling additional method calls to be chained together.
        /// 	Please refer to 
        /// 	<see cref="T:Amazon.S3.Model.S3StorageClass"/> for
        ///	 	information on S3 Storage Classes.
        /// </summary>
        /// <param name="sClass">
        /// 	The storage class for the uploaded Amazon S3 object.
        /// </param>
        /// <returns>
        /// 	This object instance, enabling additional method calls to be chained together.
        /// </returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TransferUtilityUploadDirectoryRequest WithStorageClass(S3StorageClass sClass)
        {
            this._storageClass = sClass;
            return this;
        }

        #endregion

        #region ServerSideEncryptionMethod

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
        /// Sets the ServerSideEncryptionMethod property for this request.
        /// Specifies the encryption used on the server to
        /// store the content.
        /// Default is None.
        /// </summary>
        /// <param name="encryption">
        /// The value of the ServerSideEncryptionMethod to set.
        /// </param>
        /// <returns>
        /// The response with the ServerSideEncryptionMethod set.
        /// </returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TransferUtilityUploadDirectoryRequest WithServerSideEncryptionMethod(ServerSideEncryptionMethod encryption)
        {
            this.ServerSideEncryptionMethod = encryption;
            return this;
        }

        #endregion


        /// <summary>
        /// 	Gets or sets the timeout property in milliseconds.
        /// 	The value of this property is assigned to the
        /// 	<c>ReadWriteTimeout</c> and <c>Timeout</c> properties of the
        /// 	<c>HTTPWebRequest</c> object used for Amazon S3 GET Object requests.
        /// </summary>
        /// <remarks>
        /// 	A value less than or equal to 0 will be silently ignored.
        /// </remarks>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
        /// <seealso cref="P:System.Net.HttpWebRequest.Timeout"/>
        public int Timeout
        {
            get { return this._timeout; }
            set
            {
                if (value > 0)
                {
                    this._timeout = value;
                }
            }
        }

        /// <summary>
        /// 	Sets the sets the timeout property in milliseconds
        /// 	and returns this object instance, 
        /// 	enabling additional method calls to be chained together.
        /// 	Set the timeout only if certain that
        /// 	the file will not be transferred within the default intervals
        /// 	for an HttpWebRequest.
        /// </summary>
        /// <param name="timeout">
        /// 	The timeout in milliseconds.
        /// </param>
        /// <remarks>
        /// 	A value less than or equal to 0 will be silently ignored.
        /// </remarks>
        /// <returns>
        /// 	This object instance, enabling additional method calls to be chained together.
        /// </returns>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
        /// <seealso cref="P:System.Net.HttpWebRequest.Timeout"/>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TransferUtilityUploadDirectoryRequest WithTimeout(int timeout)
        {
            Timeout = _timeout;
            return this;
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
        /// The handler will be attached to the UploadDirectoryProgressEvent which is fired as data
        /// is uploaded to S3.  The handler will be passed information detailing how much data
        /// has been uploaded as well as how much will be uploaded.
        /// </summary>
        /// <param name="handler">A method that is called when UploadDirectoryProgressEvent is fired.</param>
        /// <returns>this instance of the TransferUtilityUploadDirectoryRequest</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public TransferUtilityUploadDirectoryRequest WithSubscriber(EventHandler<UploadDirectoryProgressArgs> handler)
        {
            this.UploadDirectoryProgressEvent += handler;
            return this;
        }

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
