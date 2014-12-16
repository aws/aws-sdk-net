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
    /// Container for the parameters to the CopyObject operation.
    /// <para>Creates a copy of an object that is already stored in Amazon S3.</para>
    /// </summary>
    public partial class CopyObjectRequest : PutWithACLRequest
    {
        private string srcBucket;
        private string srcKey;
        private string srcVersionId;
        private string dstBucket;
        private string dstKey;

        private S3CannedACL cannedACL;

        private string etagToMatch;
        private string etagToNotMatch;
        private DateTime? modifiedSinceDate;
        private DateTime? unmodifiedSinceDate;

        private S3MetadataDirective metadataDirective;
        private S3StorageClass storageClass;
        private string websiteRedirectLocation;
        private HeadersCollection headersCollection = new HeadersCollection();
        private MetadataCollection metadataCollection = new MetadataCollection();

        private ServerSideEncryptionMethod serverSideEncryption;
        private ServerSideEncryptionCustomerMethod serverSideCustomerEncryption;
        private string serverSideEncryptionCustomerProvidedKey;
        private string serverSideEncryptionCustomerProvidedKeyMD5;
        private string serverSideEncryptionKeyManagementServiceKeyId;

        private ServerSideEncryptionCustomerMethod copySourceServerSideCustomerEncryption;
        private string copySourceServerSideEncryptionCustomerProvidedKey;
        private string copySourceServerSideEncryptionCustomerProvidedKeyMD5;


        /// <summary>
        /// The name of the bucket containing the object to copy.
        /// </summary>
        public string SourceBucket
        {
            get { return this.srcBucket; }
            set { this.srcBucket = value; }
        }


        /// <summary>
        /// Checks if SourceBucket property is set.
        /// </summary>
        /// <returns>true if SourceBucket property is set.</returns>
        internal bool IsSetSourceBucket()
        {
            return !System.String.IsNullOrEmpty(this.srcBucket);
        }


        /// <summary>
        /// The key of the object to copy.
        /// </summary>
        public string SourceKey
        {
            get { return this.srcKey; }
            set { this.srcKey = value; }
        }

        /// <summary>
        /// Checks if SourceKey property is set.
        /// </summary>
        /// <returns>true if SourceKey property is set.</returns>
        internal bool IsSetSourceKey()
        {
            return !System.String.IsNullOrEmpty(this.srcKey);
        }

        /// <summary>
        /// Specifies a particular version of the source object to copy. By default the latest version is copied.
        /// </summary>
        public string SourceVersionId
        {
            get { return this.srcVersionId; }
            set { this.srcVersionId = value; }
        }

        /// <summary>
        /// Checks if SourceVersionId property is set.
        /// </summary>
        /// <returns>true if SourceVersionId property is set.</returns>
        internal bool IsSetSourceVersionId()
        {
            return !System.String.IsNullOrEmpty(this.srcVersionId);
        }

        /// <summary>
        /// The name of the bucket to contain the copy of the source object.
        /// </summary>
        public string DestinationBucket
        {
            get { return this.dstBucket; }
            set { this.dstBucket = value; }
        }

        /// <summary>
        /// Checks if DestinationBucket property is set.
        /// </summary>
        /// <returns>true if DestinationBucket property is set.</returns>
        internal bool IsSetDestinationBucket()
        {
            return !System.String.IsNullOrEmpty(this.dstBucket);
        }

        /// <summary>
        /// The key to be given to the copy of the source object.
        /// </summary>
        public string DestinationKey
        {
            get { return this.dstKey; }
            set { this.dstKey = value; }
        }
        /// <summary>
        /// Checks if DestinationKey property is set.
        /// </summary>
        /// <returns>true if DestinationKey property is set.</returns>
        internal bool IsSetDestinationKey()
        {
            return !System.String.IsNullOrEmpty(this.dstKey);
        }


        /// <summary>
        /// A canned access control list (CACL) to apply to the object.
        /// Please refer to <see cref="T:Amazon.S3.S3CannedACL"/> for
        /// information on S3 Canned ACLs.
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
        /// ETag to be matched as a pre-condition for copying the source object
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        /// <remarks>
        /// Copies the object if its entity tag (ETag) matches 
        /// the specified tag; otherwise return a 412 (precondition failed).
        /// Constraints: This property can be used with IfUnmodifiedSince,
        /// but cannot be used with other conditional copy properties.
        /// </remarks>
        public string ETagToMatch
        {
            get { return this.etagToMatch; }
            set { this.etagToMatch = value; }
        }


        /// <summary>
        /// Checks if ETagToMatch property is set.
        /// </summary>
        /// <remarks>
        /// Copies the object if its entity tag (ETag) is different
        /// than the specified Etag; otherwise returns a 412 (failed condition).
        /// Constraints: This header can be used with IfModifiedSince, but cannot
        /// be used with other conditional copy properties.
        /// </remarks>
        /// <returns>true if ETagToMatch property is set.</returns>
        internal bool IsSetETagToMatch()
        {
            return !System.String.IsNullOrEmpty(this.etagToMatch);
        }

        /// <summary>
        /// ETag that must not be matched as a pre-condition for copying the source object,
        /// otherwise returns a PreconditionFailed.
        /// </summary>
        public string ETagToNotMatch
        {
            get { return this.etagToNotMatch; }
            set { this.etagToNotMatch = value; }
        }

        /// <summary>
        /// Checks if ETagToNotMatch property is set.
        /// </summary>
        /// <returns>true if ETagToNotMatch property is set.</returns>
        internal bool IsSetETagToNotMatch()
        {
            return !System.String.IsNullOrEmpty(this.etagToNotMatch);
        }

        /// <summary>
        /// Copies the object if it has been modified since the specified time, otherwise returns a PreconditionFailed.
        /// </summary>
        /// <remarks>
        /// Copies the object if it has been modified since the
        /// specified time; otherwise returns a 412 (failed condition).
        /// Constraints: This property can be used with ETagToNotMatch,
        /// but cannot be used with other conditional copy properties.
        /// </remarks>
        public DateTime ModifiedSinceDate
        {
            get { return this.modifiedSinceDate.GetValueOrDefault(); }
            set { this.modifiedSinceDate = value; }
        }


        /// <summary>
        /// Checks if ModifiedSinceDate property is set.
        /// </summary>
        /// <returns>true if ModifiedSinceDate property is set.</returns>
        internal bool IsSetModifiedSinceDate()
        {
            return this.modifiedSinceDate.HasValue;
        }

        /// <summary>
        /// Copies the object if it has not been modified since the specified time, otherwise returns a PreconditionFailed.
        /// </summary>
        /// <remarks>
        /// Copies the object if it hasn't been modified since the
        /// specified time; otherwise returns a 412 (precondition failed).
        /// Constraints: This property can be used with ETagToMatch,
        /// but cannot be used with other conditional copy properties.
        /// </remarks>
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
            return this.unmodifiedSinceDate.HasValue;
        }


        /// <summary>
        /// Specifies whether the metadata is copied from the source object or replaced with metadata provided in the request.
        ///  
        /// </summary>
        public S3MetadataDirective MetadataDirective
        {
            get { return this.metadataDirective; }
            set { this.metadataDirective = value; }
        }

        /// <summary>
        /// The Server-side encryption algorithm used when storing this object in S3.
        ///  
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get { return this.serverSideEncryption; }
            set { this.serverSideEncryption = value; }
        }

        // Check to see if ServerSideEncryption property is set
        internal bool IsSetServerSideEncryptionMethod()
        {
            return this.serverSideEncryption != null && this.serverSideEncryption != ServerSideEncryptionMethod.None;
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
        /// The type of storage to use for the object. Defaults to 'STANDARD'.
        ///  
        /// </summary>
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
        }

        /// <summary>
        /// This is a convenience property for Headers.ContentType.
        /// </summary>
        public string ContentType
        {
            get { return this.Headers.ContentType; }
            set { this.Headers.ContentType = value; }
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

        // Check to see if ServerSideEncryptionCustomerMethod property is set
        internal bool IsSetServerSideEncryptionCustomerMethod()
        {
            return this.serverSideCustomerEncryption != null && this.serverSideCustomerEncryption != ServerSideEncryptionCustomerMethod.None;
        }

        /// <summary>
        /// The base64-encoded encryption key for Amazon S3 to use to encrypt the object
        /// <para>
        /// Using the encryption key you provide as part of your request Amazon S3 manages both the encryption, as it writes 
        /// to disks, and decryption, when you access your objects. Therefore, you don't need to maintain any data encryption code. The only 
        /// thing you do is manage the encryption keys you provide.
        /// </para>        /// <para>
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
        /// Checks if ServerSideEncryptionCustomerProvidedKey property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionCustomerProvidedKey property is set.</returns>
        internal bool IsSetServerSideEncryptionCustomerProvidedKey()
        {
            return !System.String.IsNullOrEmpty(this.serverSideEncryptionCustomerProvidedKey);
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
        /// Checks if ServerSideEncryptionCustomerProvidedKeyMD5 property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionCustomerProvidedKey property is set.</returns>
        internal bool IsSetServerSideEncryptionCustomerProvidedKeyMD5()
        {
            return !System.String.IsNullOrEmpty(this.serverSideEncryptionCustomerProvidedKeyMD5);
        }

        /// <summary>
        /// The Server-side encryption algorithm to be used with the customer provided key.
        ///  
        /// </summary>
        public ServerSideEncryptionCustomerMethod CopySourceServerSideEncryptionCustomerMethod
        {
            get { return this.copySourceServerSideCustomerEncryption; }
            set { this.copySourceServerSideCustomerEncryption = value; }
        }

        // Check to see if CopySourceServerSideEncryptionCustomerMethod property is set
        internal bool IsSetCopySourceServerSideEncryptionCustomerMethod()
        {
            return this.copySourceServerSideCustomerEncryption != null && this.copySourceServerSideCustomerEncryption != ServerSideEncryptionCustomerMethod.None;
        }

        /// <summary>
        /// The customer provided encryption key for the source object of the copy.
        /// <para>
        /// Important: Amazon S3 does not store the encryption key you provide.
        /// </para>
        /// </summary>
        public string CopySourceServerSideEncryptionCustomerProvidedKey
        {
            get { return this.copySourceServerSideEncryptionCustomerProvidedKey; }
            set { this.copySourceServerSideEncryptionCustomerProvidedKey = value; }
        }

        /// <summary>
        /// Checks if CopySourceServerSideEncryptionCustomerProvidedKey property is set.
        /// </summary>
        /// <returns>true if CopySourceServerSideEncryptionCustomerProvidedKey property is set.</returns>
        internal bool IsSetCopySourceServerSideEncryptionCustomerProvidedKey()
        {
            return !System.String.IsNullOrEmpty(this.copySourceServerSideEncryptionCustomerProvidedKey);
        }

        /// <summary>
        /// The MD5 of the customer encryption key specified in the CopySourceServerSideEncryptionCustomerProvidedKey property. The MD5 is
        /// base 64 encoded. This field is optional, the SDK will calculate the MD5 if this is not set.
        /// </summary>
        public string CopySourceServerSideEncryptionCustomerProvidedKeyMD5
        {
            get { return this.copySourceServerSideEncryptionCustomerProvidedKeyMD5; }
            set { this.copySourceServerSideEncryptionCustomerProvidedKeyMD5 = value; }
        }

        /// <summary>
        /// Checks if CopySourceServerSideEncryptionCustomerProvidedKeyMD5 property is set.
        /// </summary>
        /// <returns>true if CopySourceServerSideEncryptionCustomerProvidedKey property is set.</returns>
        internal bool IsSetCopySourceServerSideEncryptionCustomerProvidedKeyMD5()
        {
            return !System.String.IsNullOrEmpty(this.copySourceServerSideEncryptionCustomerProvidedKeyMD5);
        }
    }
}
    
