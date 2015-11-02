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
    public partial class TransferUtilityUploadRequest : BaseUploadRequest
    {
        private string bucketName;
        private string key;
        private S3CannedACL cannedACL;
        private string contentType;
        private S3StorageClass storageClass;
        private long? partSize;
        private bool autoCloseStream = true;
        private bool autoResetStreamPosition = true;
        private ServerSideEncryptionMethod encryption;
        private ServerSideEncryptionCustomerMethod serverSideCustomerEncryption;
        private string serverSideEncryptionCustomerProvidedKey;
        private string serverSideEncryptionCustomerProvidedKeyMD5;
        private string serverSideEncryptionKeyManagementServiceKeyId;

        private HeadersCollection headersCollection = new HeadersCollection();
        private MetadataCollection metadataCollection = new MetadataCollection();

        private Stream inputStream;

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
        /// 	<see cref="T:Amazon.S3.S3CannedACL"/> for
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
        /// Checks if the CannedACL property is set.
        /// </summary>
        /// <returns>true if there is the CannedACL property is set.</returns>
        internal bool IsSetCannedACL()
        {
            return (cannedACL != null);
        }

        /// <summary>
        /// 	Removes the cannned access control list (ACL)
        /// 	for the uploaded object.
        /// </summary>
        public void RemoveCannedACL()
        {
            this.cannedACL = null;
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
        /// Checks if ContentType property is set.
        /// </summary>
        /// <returns>true if ContentType property is set.</returns>
        internal bool IsSetContentType()
        {
            return !System.String.IsNullOrEmpty(this.contentType);
        }

        #endregion

        #region StorageClass

        /// <summary>
        /// 	Gets or sets the storage class for the uploaded Amazon S3 object.
        /// 	Please refer to 
        /// 	<see cref="T:Amazon.S3.S3StorageClass"/> for
        /// 	information on S3 Storage Classes.
        /// </summary>
        /// <value>
        /// 	The storage class for the uploaded Amazon S3 object.
        /// </value>
        public S3StorageClass StorageClass
        {
            get { return this.storageClass; }
            set { this.storageClass = value; }
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
        /// The Server-side encryption algorithm to be used with the customer provided key.
        ///  
        /// </summary>
        public ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod
        {
            get { return this.serverSideCustomerEncryption; }
            set { this.serverSideCustomerEncryption = value; }
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
        /// Checks if ServerSideEncryptionKeyManagementServiceKeyId property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionKeyManagementServiceKeyId property is set.</returns>
        internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
        {
            return !System.String.IsNullOrEmpty(this.serverSideEncryptionKeyManagementServiceKeyId);
        }

        /// <summary>
        /// The base64-encoded encryption key for Amazon S3 to use to encrypt the object
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
            internal set { this.headersCollection = value; }
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
#if BCL
                if (this.IsSetFilePath())
                {
                    //System.IO.
                    FileInfo fileInfo = new FileInfo(this.FilePath);
                    length = fileInfo.Length;
                }
#elif PCL
                if (this.IsSetFilePath())
                {
                    var file = PCLStorage.FileSystem.Current.GetFileFromPathAsync(this.FilePath).Result;
                    using (var stream = file.OpenAsync(PCLStorage.FileAccess.Read).Result)
                    {
                        length = stream.Length;
                    }
                }
#endif
                else
                {
                    length = this.InputStream.Length - this.InputStream.Position;
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

        /// <summary>
        /// The constructor takes the number of
        /// currently transferred bytes and the
        /// total number of bytes to be transferred
        /// </summary>
        /// <param name="incrementTransferred">The how many bytes were transferred since last event.</param>
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
        /// <param name="incrementTransferred">The how many bytes were transferred since last event.</param>
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
        /// Gets the FilePath.
        /// </summary>
        public string FilePath { get; private set; }

        internal long CompensationForRetry { get; set; }
    }
}
