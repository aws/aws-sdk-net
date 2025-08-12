/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.S3.Util;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Returns information about the  HeadObject response and response metadata.
    /// </summary>
    public class GetObjectMetadataResponse : AmazonWebServiceResponse
    {
        private string deleteMarker;
        private string acceptRanges;
        private string contentRange;
        private Expiration expiration;
        private DateTime? restoreExpiration;
        private bool? restoreInProgress;
        private DateTime? lastModified;
        private string eTag;
        private int? missingMeta;
        private string versionId;
        private string websiteRedirectLocation;
        private string serverSideEncryptionKeyManagementServiceKeyId;
        private ServerSideEncryptionMethod serverSideEncryption;
        private ServerSideEncryptionCustomerMethod serverSideEncryptionCustomerMethod;
        private HeadersCollection headersCollection = new HeadersCollection();
        private MetadataCollection metadataCollection = new MetadataCollection();
        private ReplicationStatus replicationStatus;
        private ArchiveStatus archiveStatus;
        private int? partsCount;
        private int? tagsCount;
        private ObjectLockLegalHoldStatus objectLockLegalHoldStatus;
        private ObjectLockMode objectLockMode;
        private DateTime? objectLockRetainUntilDate;
        private S3StorageClass storageClass;
        private RequestCharged requestCharged;
        private bool? bucketKeyEnabled;
        private string _checksumCRC32;
        private string _checksumCRC32C;
        private string _checksumCRC64NVME;
        private string _checksumSHA1;
        private string _checksumSHA256;
        private ChecksumType _checksumType;

        /// <summary>
        /// The date and time at which the object is no longer cacheable.
        /// </summary>
        public string ExpiresString { get; set; }

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
        /// Gets and sets the property DeleteMarker. 
        /// <para>
        /// Specifies whether the object retrieved was (true) or was not (false) a Delete Marker.
        /// If false, this response header does not appear in the response.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string DeleteMarker
        {
            get { return this.deleteMarker; }
            set { this.deleteMarker = value; }
        }

        // Check to see if DeleteMarker property is set
        internal bool IsSetDeleteMarker()
        {
            return this.deleteMarker != null;
        }

        /// <summary>
        /// Gets and sets the AcceptRanges.
        /// </summary>
        public string AcceptRanges
        {
            get { return this.acceptRanges; }
            set { this.acceptRanges = value; }
        }

        // Check to see if AcceptRanges property is set
        internal bool IsSetAcceptRanges()
        {
            return this.acceptRanges != null;
        }

        /// <summary>
        /// Gets and sets the ContentRange.
        /// </summary>
        public string ContentRange
        {
            get { return this.contentRange; }
            set { this.contentRange = value; }
        }

        // Check to see if ContentRange property is set
        internal bool IsSetContentRange()
        {
            return this.contentRange != null;
        }

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// If the object expiration is configured, this will contain the expiration date (<c>expiry-date</c>)
        /// and rule ID (<c>rule-id</c>). The value of <c>rule-id</c> is URL encoded.
        /// </para>
        /// <para>
        /// Object expiration information is not returned for directory buckets (for those, the
        /// response header will contain the value <c>"NotImplemented"</c>).
        /// </para>
        /// </summary>
        public Expiration Expiration
        {
            get { return this.expiration; }
            set { this.expiration = value; }
        }

        // Check to see if Expiration property is set
        internal bool IsSetExpiration()
        {
            return this.expiration != null;
        }

        /// <summary>
        /// Gets and sets the RestoreExpiration property.
        /// <para>
        /// RestoreExpiration will be set for objects that have been restored from Amazon Glacier.
        /// It indicates for those objects how long the restored object will exist.
        /// </para>
        /// <para>
        /// This functionality is not supported for directory buckets. 
        /// Only the S3 Express One Zone storage class is supported by directory buckets to store objects.
        /// </para>
        /// </summary>
        public DateTime? RestoreExpiration
        {
            get { return this.restoreExpiration; }
            set { this.restoreExpiration = value; }
        }

        /// <summary>
        /// Gets and sets the RestoreInProgress
        /// <para>
        /// Will be <c>true</c> when the object is in the process of being restored from Amazon Glacier.
        /// </para>
        /// <para>
        /// This functionality is not supported for directory buckets. 
        /// Only the S3 Express One Zone storage class is supported by directory buckets to store objects.
        /// </para>
        /// </summary>
        public bool? RestoreInProgress
        {
            get { return this.restoreInProgress; }
            set { this.restoreInProgress = value; }
        }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// Date and time when the object was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModified
        {
            get { return this.lastModified; }
            set { this.lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this.lastModified.HasValue;
        }

        /// <summary>
        /// An ETag is an opaque identifier assigned by a web server to a specific version of a resource found at a URL
        ///  
        /// </summary>
        public string ETag
        {
            get { return this.eTag; }
            set { this.eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this.eTag != null;
        }

        /// <summary>
        /// Gets and sets the property MissingMeta. 
        /// <para>
        /// This is set to the number of metadata entries not returned in <code>x-amz-meta</code>
        /// headers. This can happen if you create metadata using an API like SOAP that supports
        /// more flexible metadata than the REST API. For example, using SOAP, you can create
        /// metadata whose values are not legal HTTP headers.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public int? MissingMeta
        {
            get { return this.missingMeta; }
            set { this.missingMeta = value; }
        }

        // Check to see if MissingMeta property is set
        internal bool IsSetMissingMeta()
        {
            return this.missingMeta.HasValue;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Version ID of the object.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string VersionId
        {
            get { return this.versionId; }
            set { this.versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this.versionId != null;
        }

        /// <summary>
        /// Gets and sets the property WebsiteRedirectLocation. 
        /// <para>
        /// If the bucket is configured as a website, redirects requests for this object to another
        /// object in the same bucket or to an external URL. Amazon S3 stores the value of this
        /// header in the object metadata.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
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
        /// The server-side encryption algorithm used when storing this object in Amazon S3 or Amazon FSx.
        /// <para>
        /// The server-side encryption algorithm used when you store this object in Amazon S3 or Amazon FSx.
        /// </para>
        /// <note>
        /// <para>When accessing data stored in Amazon FSx file systems using S3 access points, the only valid server side encryption option is <c>aws:fsx</c>.
        /// </para>
        /// </note>
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get 
            {
                if (this.serverSideEncryption == null)
                    return ServerSideEncryptionMethod.None;

                return this.serverSideEncryption; 
            }
            set { this.serverSideEncryption = value; }
        }

        // Check to see if ServerSideEncryptionCustomerMethod property is set
        internal bool IsSetServerSideEncryptionMethod()
        {
            return this.serverSideEncryptionCustomerMethod != null;
        }

        /// <summary>
        /// The Server-side encryption algorithm to be used with the customer provided key.
        ///  
        ///  <note> 
        /// <para>
        /// For directory buckets, only server-side encryption with Amazon S3 managed keys (SSE-S3)
        /// (<code>AES256</code>) is supported.
        /// </para>
        ///  </note>
        /// </summary>
        public ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod 
        { 
            get
            {
                if (this.serverSideEncryptionCustomerMethod == null)
                    return ServerSideEncryptionCustomerMethod.None;

                return this.serverSideEncryptionCustomerMethod;
            }
            set { this.serverSideEncryptionCustomerMethod = value; } 
        }


        // Check to see if ServerSideEncryptionCustomerMethod property is set
        internal bool IsSetServerSideEncryptionCustomerMethod()
        {
            return this.serverSideEncryptionCustomerMethod != null;
        }

        /// <summary>
        /// <para>
        /// If present, indicates the ID of the KMS key that was used for object encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        /// <p>Amazon S3 can return this header if your request involves a 
        /// bucket that is either a source or a destination in a replication rule.</p> <p>In replication,
        /// you have a source bucket on which you configure replication and destination bucket or buckets 
        /// where Amazon S3 stores object replicas. When you request an object (<code>GetObject</code>) or
        /// object metadata (<code>HeadObject</code>) from these buckets, Amazon S3 will 
        /// return the <code>x-amz-replication-status</code> header in the response as follows:</p> 
        /// <ul> <li> <p>If requesting an object from the source bucket, Amazon S3 will return the 
        /// <code>x-amz-replication-status</code> header if the object in your request is eligible for 
        /// replication.</p> <p> For example, suppose that in your replication configuration, you specify 
        /// object prefix <code>TaxDocs</code> requesting Amazon S3 to replicate objects with key 
        /// prefix <code>TaxDocs</code>. Any objects you upload with this key name prefix, for example 
        /// <code>TaxDocs/document1.pdf</code>, are eligible for replication. For any object request with 
        /// this key name prefix, Amazon S3 will return the <code>x-amz-replication-status</code> header 
        /// with value PENDING, COMPLETED or FAILED indicating object replication status.</p> </li> <li> <p>If 
        /// requesting an object from a destination bucket, Amazon S3 will return the 
        /// <code>x-amz-replication-status</code> header with value REPLICA if the object in your 
        /// request is a replica that Amazon S3 created.</p> </li> <li> <p>When replicating objects 
        /// to multiple destination buckets the <code>x-amz-replication-status</code> header acts differently. 
        /// The header of the source object will only return a value of COMPLETED when replication is 
        /// successful to all destinations. The header will remain at value PENDING until replication has 
        /// completed for all destinations. If one or more destinations fails replication the header will 
        /// return FAILED. </p> </li> </ul> <p>For more information, 
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/NotificationHowTo.html\">Replication</a>.</p>
        /// </summary>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        public ReplicationStatus ReplicationStatus
        {
            get { return this.replicationStatus; }
            set { this.replicationStatus = value; }
        }

        /// <summary>
        /// Gets and sets the property ArchiveStatus. 
        /// <para>
        /// The archive state of the head object.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public ArchiveStatus ArchiveStatus
        {
            get { return this.archiveStatus; }
            set { this.archiveStatus = value; }
        }

        /// <summary>
        /// Checks if ReplicationStatus property is set.
        /// </summary>
        /// <returns>true if ReplicationStatus property is set.</returns>
        internal bool IsSetReplicationStatus()
        {
            return ReplicationStatus != null;
        }

        /// <summary>
        /// The count of parts this object has.
        /// </summary>
        public int? PartsCount
        {
            get { return this.partsCount; }
            set { this.partsCount = value; }
        }

        // Check to see if PartsCount property is set
        internal bool IsSetPartsCount()
        {
            return this.partsCount.HasValue;
        }

        /// <summary>
        /// The count of tags this object has.
        /// <para>
        /// The number of tags, if any, on the object, when you have the relevant permission 
        /// to read object tags.
        /// </para>
        ///  
        /// <para>
        /// You can use <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObjectTagging.html">GetObjectTagging</a>
        /// to retrieve the tag set associated with an object.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public int? TagsCount
        {
            get { return this.tagsCount; }
            set { this.tagsCount = value; }
        }

        // Check to see if TagsCount property is set
        internal bool IsSetTagsCount()
        {
            return this.tagsCount.HasValue;
        }

        /// <summary>
        /// Gets and sets the property ObjectLockLegalHoldStatus. 
        /// <para>
        /// Specifies whether a legal hold is in effect for this object. This header is only returned
        /// if the requester has the <code>s3:GetObjectLegalHold</code> permission. This header
        /// is not returned if the specified version of this object has never had a legal hold
        /// applied. For more information about S3 Object Lock, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lock.html">Object
        /// Lock</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public ObjectLockLegalHoldStatus ObjectLockLegalHoldStatus
        {
            get { return this.objectLockLegalHoldStatus; }
            set { this.objectLockLegalHoldStatus = value; }
        }

        // Check to see if ObjectLockLegalHoldStatus property is set
        internal bool IsSetObjectLockLegalHoldStatus()
        {
            return this.objectLockLegalHoldStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectLockMode. 
        /// <para>
        /// The Object Lock mode, if any, that's in effect for this object. This header is only
        /// returned if the requester has the <code>s3:GetObjectRetention</code> permission. For
        /// more information about S3 Object Lock, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lock.html">Object
        /// Lock</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public ObjectLockMode ObjectLockMode
        {
            get { return this.objectLockMode; }
            set { this.objectLockMode = value; }
        }

        // Check to see if ObjectLockMode property is set
        internal bool IsSetObjectLockMode()
        {
            return this.objectLockMode != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectLockRetainUntilDate. 
        /// <para>
        /// The date and time when the Object Lock retention period expires. This header is only
        /// returned if the requester has the <code>s3:GetObjectRetention</code> permission.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public DateTime? ObjectLockRetainUntilDate
        {
            get { return this.objectLockRetainUntilDate; }
            set { this.objectLockRetainUntilDate = value; }
        }

        // Check to see if ObjectLockRetainUntilDate property is set
        internal bool IsSetObjectLockRetainUntilDate()
        {
            return this.objectLockRetainUntilDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// Provides storage class information of the object. Amazon S3 returns this header for
        /// all objects except for S3 Standard storage class objects.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage-class-intro.html">Storage
        /// Classes</a>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets </b> - Only the S3 Express One Zone storage class is supported
        /// by directory buckets to store objects.
        /// </para>
        ///  </note>
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
        /// If present, indicates that the requester was successfully charged for the request.
        /// </summary>
        public RequestCharged RequestCharged
        {
            get { return this.requestCharged; }
            set { this.requestCharged = value; }
        }

        /// <summary>
        /// Checks to see if RequestCharged is set.
        /// </summary>
        /// <returns>true, if RequestCharged property is set.</returns>
        internal bool IsSetRequestCharged()
        {
            return requestCharged != null;
        }

        /// <summary>
        /// Gets and sets the property BucketKeyEnabled. 
        /// <para>
        /// Indicates whether the object uses an S3 Bucket Key for server-side encryption with 
        /// Key Management Service (KMS) keys (SSE-KMS).
        /// </para>
        /// </summary>
        public bool? BucketKeyEnabled
        {
            get { return this.bucketKeyEnabled; }
            set { this.bucketKeyEnabled = value; }
        }

        internal bool IsSetBucketKeyEnabled()
        {
            return bucketKeyEnabled.HasValue;
        }

        /// <summary>
        /// Gets and sets the property ChecksumCRC32. 
        /// <para>
        /// The Base64 encoded, 32-bit <c>CRC-32</c> checksum of the object. This checksum is only present
        /// if the checksum was uploaded with the object. When you use an API operation on an object that
        /// was uploaded using multipart uploads, this value may not be a direct checksum value
        /// of the full object. Instead, it's a calculation based on the checksum values of each
        /// individual part. For more information about how checksums are calculated with multipart
        /// uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html#large-object-checksums">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string ChecksumCRC32
        {
            get { return this._checksumCRC32; }
            set { this._checksumCRC32 = value; }
        }

        // Check to see if ChecksumCRC32 property is set
        internal bool IsSetChecksumCRC32()
        {
            return this._checksumCRC32 != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumCRC32C. 
        /// <para>
        /// The Base64 encoded, 32-bit <c>CRC-32C</c> checksum of the object. This checksum is only present
        /// if the checksum was uploaded with the object. When you use an API operation on an object that
        /// was uploaded using multipart uploads, this value may not be a direct checksum value
        /// of the full object. Instead, it's a calculation based on the checksum values of each
        /// individual part. For more information about how checksums are calculated with multipart
        /// uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html#large-object-checksums">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string ChecksumCRC32C
        {
            get { return this._checksumCRC32C; }
            set { this._checksumCRC32C = value; }
        }

        // Check to see if ChecksumCRC32C property is set
        internal bool IsSetChecksumCRC32C()
        {
            return this._checksumCRC32C != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumCRC64NVME. 
        /// <para>
        /// The Base64 encoded, 64-bit <c>CRC-64NVME</c> checksum of the object. This checksum is only present
        /// if the checksum was uploaded with the object. When you use an API operation on an object that
        /// was uploaded using multipart uploads, this value may not be a direct checksum value
        /// of the full object. Instead, it's a calculation based on the checksum values of each
        /// individual part. For more information about how checksums are calculated with multipart
        /// uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html#large-object-checksums">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string ChecksumCRC64NVME
        {
            get { return this._checksumCRC64NVME; }
            set { this._checksumCRC64NVME = value; }
        }

        // Check to see if ChecksumCRC64NVME property is set
        internal bool IsSetChecksumCRC64NVME()
        {
            return this._checksumCRC64NVME != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumSHA1. 
        /// <para>
        /// The Base64 encoded, 160-bit <c>SHA-1</c> digest of the object. This will only be present
        /// if it was uploaded with the object. When you use the API operation on an object that
        /// was uploaded using multipart uploads, this value may not be a direct checksum value
        /// of the full object. Instead, it's a calculation based on the checksum values of each
        /// individual part. For more information about how checksums are calculated with multipart
        /// uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html#large-object-checksums">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string ChecksumSHA1
        {
            get { return this._checksumSHA1; }
            set { this._checksumSHA1 = value; }
        }

        // Check to see if ChecksumSHA1 property is set
        internal bool IsSetChecksumSHA1()
        {
            return this._checksumSHA1 != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumSHA256. 
        /// <para>
        /// The Base64 encoded, 256-bit <c>SHA-256</c> digest of the object. This will only be present
        /// if it was uploaded with the object. When you use an API operation on an object that
        /// was uploaded using multipart uploads, this value may not be a direct checksum value
        /// of the full object. Instead, it's a calculation based on the checksum values of each
        /// individual part. For more information about how checksums are calculated with multipart
        /// uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html#large-object-checksums">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string ChecksumSHA256
        {
            get { return this._checksumSHA256; }
            set { this._checksumSHA256 = value; }
        }

        // Check to see if ChecksumSHA256 property is set
        internal bool IsSetChecksumSHA256()
        {
            return this._checksumSHA256 != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumType. 
        /// <para>
        /// The checksum type, which determines how part-level checksums are combined to 
        /// create an object-level checksum for multipart objects. You can use this header 
        /// response to verify that the checksum type that is received is the same checksum 
        /// type that was specified in the <c>CreateMultipartUpload</c> request.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity in the Amazon S3 User Guide</a>.
        /// </para>
        /// </summary>
        public ChecksumType ChecksumType
        {
            get { return this._checksumType; }
            set { this._checksumType = value; }
        }

        // Check to see if ChecksumType property is set
        internal bool IsSetChecksumType()
        {
            return this._checksumType != null;
        }
    }
}

