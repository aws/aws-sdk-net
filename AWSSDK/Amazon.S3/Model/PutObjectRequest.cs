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
using System.Xml.Serialization;
using System.Collections.Specialized;
using Amazon.Util;

namespace Amazon.S3.Model
{
    /// <summary>
    /// The parameters to add or update an object in a bucket.
    /// </summary>
    public class PutObjectRequest : S3PutWithACLRequest
    {
        #region Private Members

        private string bucketName;
        private string key;
        private string filePath;
        private S3CannedACL cannedACL;
        private string md5Digest;
        private bool fGenerateMD5Digest;
        private string contentType;
        private string contentBody;
        internal NameValueCollection metaData;
        private S3StorageClass storageClass;
        private bool autoCloseStream = true;
        private ServerSideEncryptionMethod encryption;
        private string websiteRedirectLocation;

        #endregion

        #region Progress Event

        /// <summary>
        /// The event for Put Object progress notifications. All
        /// subscribers will be notified when a new progress
        /// event is raised.
        /// </summary>
        /// <remarks>
        /// Subscribe to this event if you want to receive
        /// put object progress notifications. Here is how:<br />
        /// 1. Define a method with a signature similar to this one:
        /// <code>
        /// private void displayProgress(object sender, PutObjectProgressArgs args)
        /// {
        ///     Console.WriteLine(args);
        /// }
        /// </code>
        /// 2. Add this method to the Put Object Progress Event delegate's invocation list
        /// <code>
        /// PutObjectRequest request = new PutObjectRequest();
        /// request.PutObjectProgressEvent += displayProgress;
        /// </code>
        /// </remarks>
        public event EventHandler<PutObjectProgressArgs> PutObjectProgressEvent;

        /// <summary>
        /// The "handler" will be notified every time a put
        /// object progress event is raised.
        /// </summary>
        /// <param name="handler">A method that consumes the put object progress notification</param>
        /// <returns>this instance of the PutObjectRequest</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutObjectRequest WithSubscriber(EventHandler<PutObjectProgressArgs> handler)
        {
            this.PutObjectProgressEvent += handler;
            return this;
        }

        #endregion

        #region BucketName

        /// <summary>
        /// The name of the bucket to contain the object.
        /// </summary>
        [XmlElementAttribute(ElementName = "BucketName")]
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        /// <summary>
        /// Sets the name of the bucket to contain the object.
        /// </summary>
        /// <param name="bucketName">The bucket name</param>
        /// <returns>the request with the BucketName set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutObjectRequest WithBucketName(string bucketName)
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
        /// The key of the object to be created (or updated).
        /// </summary>
        [XmlElementAttribute(ElementName = "Key")]
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        /// <summary>
        /// Sets key of the object to be created (or updated).
        /// </summary>
        /// <param name="key">The object key</param>
        /// <returns>the request with the Key set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutObjectRequest WithKey(string key)
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

        #region FilePath
        /// <summary>
        /// The full path and name to a file to be uploaded.
        /// If this is set the request will upload the specified file to S3. 
        /// </summary>
        [XmlElementAttribute(ElementName = "FilePath")]
        public string FilePath
        {
            get { return this.filePath; }
            set { this.filePath = value; }
        }

        /// <summary>
        /// Sets the full path and name to a file to be uploaded.
        /// If this is set the request will upload the specified file to S3. 
        /// </summary>
        /// <param name="filePath">Full path and name of a file</param>
        /// <returns>the request with the FilePath set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutObjectRequest WithFilePath(string filePath)
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
            return !System.String.IsNullOrEmpty(this.filePath);
        }

        #endregion

        #region CannedACL

        /// <summary>
        /// A canned access control list (CACL) to apply to the object.
        /// Please refer to <see cref="T:Amazon.S3.Model.S3CannedACL"/> for
        /// information on S3 Canned ACLs.
        /// </summary>
        public S3CannedACL CannedACL
        {
            get { return this.cannedACL; }
            set { this.cannedACL = value; }
        }

        /// <summary>
        /// A canned access control list (CACL) to apply to the object.
        /// Please refer to <see cref="T:Amazon.S3.Model.S3CannedACL"/> for
        /// information on S3 Canned ACLs.
        /// </summary>
        /// <param name="acl">The Canned ACL to be set on the object</param>
        /// <returns>The request with the CannedACL set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutObjectRequest WithCannedACL(S3CannedACL acl)
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
        /// Resets any previous CannedACL set in this object.
        /// </summary>
        public void RemoveCannedACL()
        {
            this.cannedACL = S3CannedACL.NoACL;
        }

        #endregion

        #region MD5Digest
        /// <summary>
        /// An MD5 digest for the content.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The base64 encoded 128-bit MD5 digest of the message
        /// (without the headers) according to RFC 1864. This header
        /// can be used as a message integrity check to verify that
        /// the data is the same data that was originally sent.
        /// </para>
        /// <para>
        /// If supplied, after the file has been uploaded to S3,
        /// S3 checks to ensure that the MD5 hash of the uploaded file
        /// matches the hash supplied.
        /// </para>
        /// <para>
        /// Although it is optional, we recommend using the
        /// Content-MD5 mechanism as an end-to-end integrity check.
        /// </para>
        /// </remarks>
        [XmlElementAttribute(ElementName = "MD5Digest")]
        public string MD5Digest
        {
            get { return this.md5Digest; }
            set { this.md5Digest = value; }
        }

        /// <summary>
        /// Sets an MD5 digest for the content. 
        /// </summary>
        /// <remarks>
        /// <para>
        /// The base64 encoded 128-bit MD5 digest of the message
        /// (without the headers) according to RFC 1864. This header
        /// can be used as a message integrity check to verify that
        /// the data is the same data that was originally sent.
        /// </para>
        /// <para>
        /// If supplied, after the file has been uploaded to S3,
        /// S3 checks to ensure that the MD5 hash of the uploaded file
        /// matches the hash supplied.
        /// </para>
        /// <para>
        /// Although it is optional, we recommend using the
        /// Content-MD5 mechanism as an end-to-end integrity check.
        /// </para>
        /// </remarks>
        /// <param name="digest">Computed MD5 digest value</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutObjectRequest WithMD5Digest(string digest)
        {
            this.md5Digest = digest;
            return this;
        }

        /// <summary>
        /// Checks if MD5Digest property is set.
        /// </summary>
        /// <returns>true if MD5Digest property is set.</returns>
        internal bool IsSetMD5Digest()
        {
            return !System.String.IsNullOrEmpty(this.md5Digest);
        }

        #endregion

        #region GenerateMD5Digest
        /// <summary>
        /// If set, an MD5 digest is automatically computed for the content being uploaded.
        /// </summary>
        /// <remarks>
        /// This is a computationally expensive operation, and will add to the total time it will take to upload
        /// data to S3. Please use this option judicially.
        /// </remarks>
        [XmlElementAttribute(ElementName = "GenerateMD5Digest")]
        public bool GenerateMD5Digest
        {
            get { return this.fGenerateMD5Digest; }
            set { this.fGenerateMD5Digest = value; }
        }

        /// <summary>
        /// If set, an MD5 digest is automatically computed for the content being uploaded.
        /// </summary>
        /// <param name="fGenerateMD5Digest">True to auto-generate a digest</param>
        /// <returns>this instance</returns>
        /// <remarks>
        /// This is a computationally expensive operation, and will add to the total time it will take to upload
        /// data to S3. Please use this option judicially.
        /// </remarks>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutObjectRequest WithGenerateChecksum(bool fGenerateMD5Digest)
        {
            this.fGenerateMD5Digest = fGenerateMD5Digest;
            return this;
        }

        #endregion

        #region ContentType
        /// <summary>
        /// A standard MIME type describing the format of the object data.
        /// </summary>
        /// <remarks>
        /// The content type for the content being uploaded. This property defaults to "binary/octet-stream".
        /// For more information, refer to: <see href="http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.17"/>
        /// </remarks>
        [XmlElementAttribute(ElementName = "ContentType")]
        public string ContentType
        {
            get { return this.contentType; }
            set { this.contentType = value; }
        }

        /// <summary>
        /// Sets a standard MIME type describing the format of the object data.
        /// </summary>
        /// <remarks>
        /// The content type for the content being uploaded. This property defaults to "binary/octet-stream".
        /// For more information, refer to: <see href="http://www.w3.org/Protocols/rfc2616/rfc2616-sec14.html#sec14.17"/>
        /// </remarks>
        /// <param name="contentType">The content type</param>
        /// <returns>The request with the ContentType set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutObjectRequest WithContentType(string contentType)
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

        #region ContentBody
        /// <summary>
        /// Text content to be uploaded. Use this property if you want to upload plaintext to S3. 
        /// The content type will be set to 'text/plain'.
        /// </summary>
        [XmlElementAttribute(ElementName = "ContentBody")]
        public string ContentBody
        {
            get { return this.contentBody; }
            set
            {
                this.contentBody = value;
                if (value != null)
                {
                    this.contentType = "text/plain";
                }
            }
        }

        /// <summary>
        /// Text content to be uploaded. Use this property if you want to upload plaintext to S3. 
        /// The content type will be set to 'text/plain'.
        /// </summary>
        /// <param name="contentBody">The content to upload</param>
        /// <returns>The request with the ContentBody set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutObjectRequest WithContentBody(string contentBody)
        {
            this.contentBody = contentBody;
            this.contentType = "text/plain";
            return this;
        }

        /// <summary>
        /// Checks if ContentBody property is set.
        /// </summary>
        /// <returns>true if ContentBody property is set.</returns>
        internal bool IsSetContentBody()
        {
            return this.contentBody != null;
        }

        #endregion

        #region Metadata

        /// <summary>
        /// Adds a key/value metadata pair to the object when uploaded.
        /// </summary>
        /// <param name="key">The key to associate with the object</param>
        /// <param name="value">The value for the key</param>
        /// <returns>The response with Metadata set.</returns>
        public PutObjectRequest WithMetaData(string key, string value)
        {
            if (key == null || value == null)
            {
                return this;
            }

            if (metaData == null)
            {
                metaData = new NameValueCollection(5);
            }

            metaData.Add(key, value);

            return this;
        }

        /// <summary>
        /// Adds a set of key-value metadata pairs to the object when uploaded.
        /// </summary>
        /// <param name="metaInfo">The set of key-value pairs that will eventually be
        /// associated with the S3 Object</param>
        /// <returns></returns>
        public PutObjectRequest WithMetaData(NameValueCollection metaInfo)
        {
            if (metaInfo == null || metaInfo.Count == 0)
            {
                return this;
            }

            if (metaData == null)
            {
                metaData = new NameValueCollection(metaInfo.Count);
            }

            metaData.Add(metaInfo);

            return this;
        }

        /// <summary>
        /// Checks if Metadata property is set.
        /// </summary>
        /// <returns>true if Metadata property is set.</returns>
        internal bool IsSetMetaData()
        {
            return (metaData != null && metaData.Count > 0);
        }

        /// <summary>
        /// Removes a key from the Metadata list if it was
        /// added previously to this object.
        /// </summary>
        /// <param name="key">The key to remove</param>
        public void RemoveMetaData(string key)
        {
            if (metaData == null || metaData.Count == 0)
            {
                return;
            }

            metaData.Remove(key);
        }

        #endregion

        #region Timeout

        /// <summary>
        /// Sets a custom Timeout property (in milliseconds).
        /// </summary>
        /// <remarks>
        /// <para>
        /// The value of this property is assigned to the
        /// Timeout property of the HTTPWebRequest object used
        /// for S3 PUT Object requests.
        /// </para>
        /// <para>
        /// Please set the timeout only if you are certain that
        /// the file will not be transferred within the default intervals
        /// for an HttpWebRequest.
        /// </para>
        /// <para>
        /// A value less than or equal to 0 will be silently ignored
        /// </para>
        /// </remarks>
        /// <param name="timeout">Timeout value</param>
        /// <returns>this instance</returns>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
        /// <seealso cref="P:System.Net.HttpWebRequest.Timeout"/>
 [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        new public PutObjectRequest WithTimeout(int timeout)
        {
            Timeout = timeout;
            return this;
        }

        #endregion

        #region ReadWriteTimeout

        /// <summary>
        /// Sets a custom ReadWriteTimeout property (in milliseconds). 
        /// </summary>
        /// <remarks>
        /// <para>
        /// The value of this property is assigned to the
        /// ReadWriteTimeout property of the HTTPWebRequest object
        /// used for S3 PUT Object requests.
        /// </para>
        /// <para>
        /// A value less than or equal to 0 will be silently ignored
        /// </para>
        /// </remarks>
        /// <param name="readWriteTimeout">ReadWriteTimeout value</param>
        /// <returns>this instance</returns>
        /// <seealso cref="P:System.Net.HttpWebRequest.ReadWriteTimeout"/>
 [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        new public PutObjectRequest WithReadWriteTimeout(int readWriteTimeout)
        {
            ReadWriteTimeout = readWriteTimeout;
            return this;
        }

        #endregion


        #region StorageClass

        /// <summary>
        /// StorageClass value to apply to the S3 object.
        /// Default: S3StorageClass.Standard. 
        /// </summary>
        /// <remarks>
        /// Set this property only if you want reduced redundancy for this object.
        /// Please refer to <see cref="T:Amazon.S3.Model.S3StorageClass"/> for
        /// information on S3 Storage Classes.
        /// </remarks>
        public S3StorageClass StorageClass
        {
            get { return this.storageClass; }
            set
            {
                    this.storageClass = value;
                }
            }

        /// <summary>
        /// Sets a StorageClass for the S3 object.
        /// Default: S3StorageClass.Standard. 
        /// </summary>
        /// <remarks>
        /// Set this property only if you want reduced redundancy for this object.
        /// Please refer to <see cref="T:Amazon.S3.Model.S3StorageClass"/> for
        /// information on S3 Storage Classes.
        /// </remarks>
        /// <param name="sClass">The Storage Class to be set on the object</param>
        /// <returns>The request with the StorageClass set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutObjectRequest WithStorageClass(S3StorageClass sClass)
        {
            this.storageClass = sClass;
            return this;
        }

        #endregion

        #region Grants

        /// <summary>
        /// Adds custom access control lists (ACLs) to the object.
        /// Please refer to <see cref="T:Amazon.S3.Model.S3Grant"/> for information on
        /// S3 Grants.
        /// </summary>
        /// <param name="grants">One or more S3 Grants.</param>
        /// <returns>The request with the Grants set.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutObjectRequest WithGrants(params S3Grant[] grants)
        {
            this.Grants.AddRange(grants);
            return this;
        }

        #endregion

        #region ServerSideEncryption

        /// <summary>
        /// Specifies the encryption used on the server to store the content.
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get { return this.encryption; }
            set { this.encryption = value; }
        }

        /// <summary>
        /// Specifies the encryption used on the server to store the content.
        /// </summary>
        /// <param name="encryption">Encryption method to use</param>
        /// <returns>The response with the ServerSideEncryptionMethod set.</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutObjectRequest WithServerSideEncryptionMethod(ServerSideEncryptionMethod encryption)
        {
            this.ServerSideEncryptionMethod = encryption;
            return this;
        }

        #endregion

        #region Website Redirect Location
        /// <summary>
        /// If this is set then when a GET request is made from the S3 website endpoint a 301 HTTP status code
        /// will be returned indicating a redirect with this value as the redirect location.
        /// </summary>
        public string WebsiteRedirectLocation
        {
            get { return this.websiteRedirectLocation; }
            set { this.websiteRedirectLocation = value; }
        }

        /// <summary>
        /// If this is set then when a GET request is made from the S3 website endpoint a 301 HTTP status code
        /// will be returned indicating a redirect with this value as the redirect location.
        /// </summary>
        /// <param name="websiteRedirectLocation">The redirect location to be returned on a GET request to this object</param>
        /// <returns>the request with the WebsiteRedirectLocation set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutObjectRequest WithWebsiteRedirectLocation(string websiteRedirectLocation)
        {
            this.websiteRedirectLocation = websiteRedirectLocation;
            return this;
        }

        /// <summary>
        /// Checks if WebsiteRedirectLocation property is set.
        /// </summary>
        /// <returns>true if WebsiteRedirectLocation property is set.</returns>
        internal bool IsSetWebsiteRedirectLocation()
        {
            return !System.String.IsNullOrEmpty(this.websiteRedirectLocation);
        }

        #endregion

        /// <summary>
        /// This method is called by a producer of put object progress
        /// notifications. When called, all the subscribers in the 
        /// invocation list will be called sequentially.
        /// </summary>
        /// <param name="incrementTransferred">The number of bytes transferred since last event</param>
        /// <param name="transferred">The number of bytes transferred</param>
        /// <param name="total">The total number of bytes to be transferred</param>
        internal override void OnRaiseProgressEvent(long incrementTransferred, long transferred, long total)
        {
            AWSSDKUtils.InvokeInBackground(PutObjectProgressEvent, new PutObjectProgressArgs(incrementTransferred, transferred, total), this);
        }

        #region AutoCloseStream
        /// <summary>
        /// If this value is set to true then the stream used with this request will be closed when all the content 
        /// is read from the stream.  
        /// Default: true.
        /// </summary>
        public bool AutoCloseStream
        {
            get { return this.autoCloseStream; }
            set { this.autoCloseStream = value; }
        }

        /// <summary>
        /// If this value is set to true then the stream used with this request will be closed when all the content 
        /// is read from the stream.  
        /// Default: true.
        /// </summary>
        /// <param name="autoCloseStream">the value the AutoCloseStream to be set to</param>
        /// <returns>The request with the AutoCloseStream set</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public PutObjectRequest WithAutoCloseStream(bool autoCloseStream)
        {
            this.autoCloseStream = autoCloseStream;
            return this;
        }
        #endregion

        internal override bool Expect100Continue
        {
            get { return true; }
        }
    }

    /// <summary>
    /// Encapsulates the information needed to provide
    /// transfer progress to subscribers of the Put Object
    /// Event.
    /// </summary>
    public class PutObjectProgressArgs : TransferProgressArgs
    {
        /// <summary>
        /// The constructor takes the number of
        /// currently transferred bytes and the
        /// total number of bytes to be transferred
        /// </summary>
        /// <param name="incrementTransferred">The number of bytes transferred since last event</param>
        /// <param name="transferred">The number of bytes transferred</param>
        /// <param name="total">The total number of bytes to be transferred</param>
        public PutObjectProgressArgs(long incrementTransferred, long transferred, long total)
            : base(incrementTransferred, transferred, total)
        {
        }
    }
}
