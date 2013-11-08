/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the InitiateMultipartUpload operation.
    /// <para>Initiates a multipart upload and returns an upload ID.</para>
    /// </summary>
    public partial class InitiateMultipartUploadRequest : PutWithACLRequest
    {
        private S3CannedACL cannedACL;
        private string bucketName;
        private string key;
        private ServerSideEncryptionMethod serverSideEncryptionMethod;
        private S3StorageClass storageClass;
        private string websiteRedirectLocation;
        private HeadersCollection headersCollection = new HeadersCollection();
        private MetadataCollection metadataCollection = new MetadataCollection();

        private byte[] envelopeKey;
        private byte[] iv;

        /// <summary>
        /// Symmetric Envelope Key to Encrypt data
        /// </summary>
        internal byte[] EnvelopeKey
        {
            get { return this.envelopeKey; }
            set { this.envelopeKey = value; }
        }

        /// <summary>
        /// Initialization Vector for encryption
        /// </summary>
        internal byte[] IV
        {
            get { return this.iv; }
            set { this.iv = value; }
        }

        /// <summary>
        /// A canned access control list (ACL) to apply to the object.
        /// Please refer to <see cref="T:Amazon.S3.Model.S3CannedACL"/> for information on S3 Canned ACLs.
        /// </summary>
        public S3CannedACL CannedACL
        {
            get { return this.cannedACL; }
            set { this.cannedACL = value; }
        }

        // Check to see if CannedACL property is set
        internal bool IsSetCannedACL()
        {
            return cannedACL != null && cannedACL != S3CannedACL.NoACL;
        }

        /// <summary>
        /// The name of the bucketName where the new object will be created, or existing object updated.
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// The key of the object to create or update.
        /// </summary>
        public string Key
        {
            get { return this.key; }
            set { this.key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this.key != null;
        }

        /// <summary>
        /// <para>
        /// Specifies the encryption to be used on the server for the new object.
        /// </para>
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get { return this.serverSideEncryptionMethod; }
            set { this.serverSideEncryptionMethod = value; }
        }

        // Check to see if ServerSideEncryptionMethod property is set
        internal bool IsSetServerSideEncryptionMethod()
        {
            return this.serverSideEncryptionMethod != null && this.serverSideEncryptionMethod != ServerSideEncryptionMethod.None;
        }

        /// <summary>
        /// StorageClass property for the object.
        /// </summary>
        /// <remarks>
        /// Default: S3StorageClass.Standard. Set this property
        /// only if you want reduced redundancy for this object.
        /// Please refer to 
        /// <see cref="T:Amazon.S3.S3StorageClass"/> for
        /// information on S3 Storage Classes.
        /// </remarks>
        public S3StorageClass StorageClass
        {
            get { return this.storageClass; }
            set { this.storageClass = value; }
        }

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this.storageClass != null;
        }

        /// <summary>
        /// If the bucketName is configured as a website, redirects requests for this object to another object in the same bucketName or to an external URL.
        /// Amazon S3 stores the value of this header in the object metadata.
        ///  
        /// </summary>
        public string WebsiteRedirectLocation
        {
            get { return this.websiteRedirectLocation; }
            set { this.websiteRedirectLocation = value; }
        }

        // Check to see if WebsiteRedirectLocation property is set
        internal bool IsSetWebsiteRedirectLocation()
        {
            return this.websiteRedirectLocation != null;
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
        /// This is a convenience property for Headers.ContentType.
        /// </summary>
        public string ContentType
        {
            get { return this.Headers.ContentType; }
            set { this.Headers.ContentType = value; }
        }

    }
}
    
