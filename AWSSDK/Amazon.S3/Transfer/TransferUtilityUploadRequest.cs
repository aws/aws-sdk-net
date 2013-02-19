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
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
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
    public class TransferUtilityUploadRequest : S3Request
    {
        private string bucketName;
        private string key;
        private S3CannedACL cannedACL;
        private string contentType;
        internal NameValueCollection metadata;
        private S3StorageClass storageClass;
        private long? partSize;
        private bool autoCloseStream = true;
        private ServerSideEncryptionMethod encryption;

        private string filePath;

        #region BucketName

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
        public TransferUtilityUploadRequest WithBucketName(string bucketName)
        {
            this.bucketName = bucketName;
            return this;
        }

        /// <summary>
        /// Checks if BucketName property is set.
        /// </summary>
        /// <returns>true if BucketName property is set.</returns>
        internal bool IsSetBucketName()
        {
            return !System.String.IsNullOrEmpty(this.bucketName);
        }

        #endregion

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
        /// 	Sets the key under which the Amazon S3 object is stored 
        /// 	and returns this object instance, 
        /// 	enabling additional method calls to be chained together.
        /// </summary>
        /// <param name="key">
        /// 	The key under which the Amazon S3 object is stored.
        /// </param>
        /// <returns>
        /// 	This object instance, enabling additional method calls to be chained together.
        /// </returns>
        public TransferUtilityUploadRequest WithKey(string key)
        {
            this.key = key;
            return this;
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

        #region CannedACL

        /// <summary>
        /// 	Gets or sets the canned access control list (ACL)
        /// 	for the uploaded object.
        /// 	Please refer to 
        /// 	<see cref="T:Amazon.S3.Model.S3CannedACL"/> for
        /// 	information on Amazon S3 canned ACLs.
        /// </summary>
        /// <value>
        /// 	The canned access control list (ACL)
        /// 	for the uploaded object.
        /// </value>
        public S3CannedACL CannedACL
        {
            get { return this.cannedACL; }
            set { this.cannedACL = value; }
        }

        /// <summary>
        /// 	Gets or sets the canned access control list (ACL)
        /// 	for the uploaded object.
        /// 	Please refer to 
        /// 	<see cref="T:Amazon.S3.Model.S3CannedACL"/> for
        /// 	information on Amazon S3 canned ACLs.
        /// </summary>
        /// <value>
        /// 	The canned access control list (ACL)
        /// 	for the uploaded object.
        /// </value>
        public TransferUtilityUploadRequest WithCannedACL(S3CannedACL acl)
        {
            this.cannedACL = acl;
            return this;
        }

        /// <summary>
        /// Checks if the CannedACL property is set.
        /// </summary>
        /// <returns>true if there is the CannedACL property is set.</returns>
        internal bool IsSetCannedACL()
        {
            return (cannedACL != S3CannedACL.NoACL);
        }

        /// <summary>
        /// 	Removes the cannned access control list (ACL)
        /// 	for the uploaded object.
        /// </summary>
        public void RemoveCannedACL()
        {
            this.cannedACL = S3CannedACL.NoACL;
        }

        #endregion

        #region ContentType
        /// <summary>
        /// 	Gets or sets the content type of the uploaded Amazon S3 object.
        /// </summary>
        /// <value>
        /// 	The content type of the uploaded Amazon S3 object.
        /// </value>
        public string ContentType
        {
            get { return this.contentType; }
            set { this.contentType = value; }
        }

        /// <summary>
        /// 	Sets the content type of the uploaded Amazon S3 object.
        ///   	and returns this object instance, 
        /// 	enabling additional method calls to be chained together.
        /// 	This property defaults to <c>binary/octet-stream</c>.
        /// </summary>
        /// <param name="contentType">the value the ContentType to be set to</param>
        /// <returns>
        /// 	This object instance, enabling additional method calls to be chained together.
        /// </returns>
        public TransferUtilityUploadRequest WithContentType(string contentType)
        {
            this.contentType = contentType;
            return this;
        }

        /// <summary>
        /// Checks if ContentType property is set.
        /// </summary>
        /// <returns>true if ContentType property is set.</returns>
        internal bool IsSetContentType()
        {
            return !System.String.IsNullOrEmpty(this.contentType);
        }

        #endregion

        #region Metadata

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
        public TransferUtilityUploadRequest WithMetadata(string key, string value)
        {
            if (key == null || value == null)
            {
                return this;
            }

            if (metadata == null)
            {
                metadata = new NameValueCollection(5);
            }

            metadata.Add(key, value);

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
        public TransferUtilityUploadRequest WithMetadata(NameValueCollection metaInfo)
        {
            if (metaInfo == null || metaInfo.Count == 0)
            {
                return this;
            }

            if (metadata == null)
            {
                metadata = new NameValueCollection(metaInfo.Count);
            }

            metadata.Add(metaInfo);

            return this;
        }

        /// <summary>
        /// Checks if Metadata property is set.
        /// </summary>
        /// <returns>true if Metadata property is set.</returns>
        internal bool IsSetMetadata()
        {
            return (metadata != null && metadata.Count > 0);
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
            if (metadata == null || metadata.Count == 0)
            {
                return;
            }

            metadata.Remove(key);
        }

        #endregion

        #region StorageClass

        /// <summary>
        /// 	Gets or sets the storage class for the uploaded Amazon S3 object.
        /// 	Please refer to 
        /// 	<see cref="T:Amazon.S3.Model.S3StorageClass"/> for
        /// 	information on S3 Storage Classes.
        /// </summary>
        /// <value>
        /// 	The storage class for the uploaded Amazon S3 object.
        /// </value>
        public S3StorageClass StorageClass
        {
            get { return this.storageClass; }
            set
            {
                if (value >= S3StorageClass.Standard &&
                    value <= S3StorageClass.ReducedRedundancy)
                {
                    this.storageClass = value;
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
        public TransferUtilityUploadRequest WithStorageClass(S3StorageClass sClass)
        {
            this.storageClass = sClass;
            return this;
        }

        #endregion    

        #region ServerSideEncryption

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
        public TransferUtilityUploadRequest WithServerSideEncryptionMethod(ServerSideEncryptionMethod encryption)
        {
            this.ServerSideEncryptionMethod = encryption;
            return this;
        }

        #endregion

        /// <summary>
        /// 	Gets or sets the file path
        /// 	where the Amazon S3 object will be uploaded from.
        /// </summary>
        /// <value>
        /// 	The file path where the Amazon S3 object will be uploaded from.
        /// </value>
        public string FilePath
        {
            get { return this.filePath; }
            set { this.filePath = value; }
        }

        /// <summary>
        /// 	Sets the file path location of where the
        /// 	Amazon S3 object will be uploaded from
        ///   	and returns this object instance,
        /// 	enabling additional method calls to be chained together.
        /// </summary>
        /// <param name="filePath">The value that FilePath is set to</param>
        /// <returns>
        /// 	This object instance, enabling additional method calls to be chained together.
        /// </returns>
        public TransferUtilityUploadRequest WithFilePath(string filePath)
        {
            this.filePath = filePath;
            return this;
        }

        /// <summary>
        /// Checks if FilePath property is set.
        /// </summary>
        /// <returns>true if FilePath property is set.</returns>
        internal bool IsSetFilePath()
        {
            return !string.IsNullOrEmpty(this.filePath);
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
        new public TransferUtilityUploadRequest WithTimeout(int timeout)
        {
            Timeout = timeout;
            return this;
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
        /// 	Sets the part size of the upload in bytes
        ///   	and returns this object instance, 
        /// 	enabling additional method calls to be chained together.
        /// 	The uploaded file will be divided into 
        /// 	parts the size specified and
        /// 	uploaded to Amazon S3 individually.
        /// </summary>
        /// <param name="partSize">
        /// 	The part size of the upload.
        /// </param>
        /// <returns>
        /// 	This object instance, enabling additional method calls to be chained together.
        /// </returns>
        public TransferUtilityUploadRequest WithPartSize(long partSize)
        {
            this.partSize = partSize;
            return this;
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
        /// The handler will be attached to the UploadProgressEvent which is fired as data
        /// is uploaded to S3.  The handler will be passed information detailing how much data
        /// has been uploaded as well as how much will be uploaded.
        /// </summary>
        /// <param name="handler">A method that is called when UploadProgressEvent is fired.</param>
        /// <returns>this instance of the TransferUtilityUploadRequest</returns>
        public TransferUtilityUploadRequest WithSubscriber(EventHandler<UploadProgressArgs> handler)
        {
            this.UploadProgressEvent += handler;
            return this;
        }


        /// <summary>
        /// Causes the UploadProgressEvent event to be fired.
        /// </summary>
        /// <param name="incrementTransferred">The how many bytes were transferred since last event.</param>
        /// <param name="transferred">How many bytes have been transferred.</param>
        /// <param name="total">The total number of bytes to be tranferred.</param>
        internal override void OnRaiseProgressEvent(long incrementTransferred, long transferred, long total)
        {
            AWSSDKUtils.InvokeInBackground(UploadProgressEvent, new UploadProgressArgs(incrementTransferred, transferred, total), this);
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
                if (this.IsSetFilePath())
                {
                    FileInfo fileInfo = new FileInfo(this.FilePath);
                    length = fileInfo.Length;
                }
                else
                {
                    length = this.InputStream.Length;
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
        /// <param name="incrementTransferred">The how many bytes were transferred since last event.</param>
        /// <param name="transferred">The number of bytes transferred</param>
        /// <param name="total">The total number of bytes to be transferred</param>
        public UploadProgressArgs(long incrementTransferred, long transferred, long total)
            : base(incrementTransferred, transferred, total)
        {
        }
    }
}
