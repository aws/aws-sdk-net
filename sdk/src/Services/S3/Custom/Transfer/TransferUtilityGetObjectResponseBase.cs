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
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.S3.Model;

namespace Amazon.S3.Transfer
{
    /// <summary>
    /// Base response object for Transfer Utility operations that retrieve S3 object metadata.
    /// Contains response metadata from S3 GetObject operations.
    /// </summary>
    public abstract class TransferUtilityGetObjectResponseBase
    {
        /// <summary>
        /// Gets and sets the AcceptRanges property.
        /// </summary>
        public string AcceptRanges { get; set; }

        /// <summary>
        /// Gets and sets the property BucketKeyEnabled. 
        /// <para>
        /// Indicates whether the object uses an S3 Bucket Key for server-side encryption with
        /// Amazon Web Services KMS (SSE-KMS).
        /// </para>
        /// </summary>
        public bool? BucketKeyEnabled { get; set; }

        /// <summary>
        /// The collection of headers for the response.
        /// </summary>
        public HeadersCollection Headers { get; set; }

        /// <summary>
        /// Gets and sets the property ChecksumCRC32. 
        /// <para>
        /// The Base64 encoded, 32-bit CRC-32 checksum of the object.
        /// </para>
        /// </summary>
        public string ChecksumCRC32 { get; set; }

        /// <summary>
        /// Gets and sets the property ChecksumCRC32C. 
        /// <para>
        /// The Base64 encoded, 32-bit CRC-32C checksum of the object.
        /// </para>
        /// </summary>
        public string ChecksumCRC32C { get; set; }

        /// <summary>
        /// Gets and sets the property ChecksumCRC64NVME. 
        /// <para>
        /// The Base64 encoded, 64-bit CRC-64NVME checksum of the object.
        /// </para>
        /// </summary>
        public string ChecksumCRC64NVME { get; set; }

        /// <summary>
        /// Gets and sets the property ChecksumSHA1. 
        /// <para>
        /// The Base64 encoded, 160-bit SHA-1 digest of the object.
        /// </para>
        /// </summary>
        public string ChecksumSHA1 { get; set; }

        /// <summary>
        /// Gets and sets the property ChecksumSHA256. 
        /// <para>
        /// The Base64 encoded, 256-bit SHA-256 checksum of the object.
        /// </para>
        /// </summary>
        public string ChecksumSHA256 { get; set; }

        /// <summary>
        /// Gets and sets the property ChecksumType. 
        /// <para>
        /// The checksum type used to calculate the object-level checksum.
        /// </para>
        /// </summary>
        public ChecksumType ChecksumType { get; set; }

        /// <summary>
        /// Gets and sets the ContentRange property.
        /// </summary>
        public string ContentRange { get; set; }

        /// <summary>
        /// Gets and sets the DeleteMarker property.
        /// <para>
        /// Specifies whether the object retrieved was (true) or was not (false) a Delete Marker.
        /// </para>
        /// </summary>
        public string DeleteMarker { get; set; }

        /// <summary>
        /// Gets and sets the ETag property.
        /// <para>
        /// An ETag is an opaque identifier assigned by a web server to a specific version of a resource found at a URL.
        /// </para>
        /// </summary>
        public string ETag { get; set; }

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// If the object expiration is configured, this will contain the expiration date and rule ID.
        /// </para>
        /// </summary>
        public Expiration Expiration { get; set; }

        /// <summary>
        /// Gets and sets the ExpiresString property.
        /// <para>
        /// The date and time at which the object is no longer cacheable (string format).
        /// </para>
        /// </summary>
        public string ExpiresString { get; set; }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// Date and time when the object was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModified { get; set; }

        /// <summary>
        /// Gets and sets the Metadata property.
        /// <para>
        /// The collection of metadata for the object.
        /// </para>
        /// </summary>
        public MetadataCollection Metadata { get; set; }

        /// <summary>
        /// Gets and sets the property MissingMeta. 
        /// <para>
        /// This is set to the number of metadata entries not returned in the headers that are
        /// prefixed with x-amz-meta-.
        /// </para>
        /// </summary>
        public int? MissingMeta { get; set; }

        /// <summary>
        /// Gets and sets the property ObjectLockLegalHoldStatus. 
        /// <para>
        /// Indicates whether this object has an active legal hold.
        /// </para>
        /// </summary>
        public ObjectLockLegalHoldStatus ObjectLockLegalHoldStatus { get; set; }

        /// <summary>
        /// Gets and sets the property ObjectLockMode. 
        /// <para>
        /// The Object Lock mode that's currently in place for this object.
        /// </para>
        /// </summary>
        public ObjectLockMode ObjectLockMode { get; set; }

        /// <summary>
        /// Gets and sets the property ObjectLockRetainUntilDate. 
        /// <para>
        /// The date and time when this object's Object Lock will expire.
        /// </para>
        /// </summary>
        public DateTime? ObjectLockRetainUntilDate { get; set; }

        /// <summary>
        /// Gets and sets the PartsCount property.
        /// <para>
        /// The number of parts this object has.
        /// </para>
        /// </summary>
        public int? PartsCount { get; set; }

        /// <summary>
        /// Gets and sets the property ReplicationStatus. 
        /// <para>
        /// Amazon S3 can return this if your request involves a bucket that is either a source
        /// or destination in a replication rule.
        /// </para>
        /// </summary>
        public ReplicationStatus ReplicationStatus { get; set; }

        /// <summary>
        /// Gets and sets the RequestCharged property.
        /// <para>
        /// If present, indicates that the requester was successfully charged for the request.
        /// </para>
        /// </summary>
        public RequestCharged RequestCharged { get; set; }

        /// <summary>
        /// Gets and sets the RestoreExpiration property.
        /// <para>
        /// RestoreExpiration will be set for objects that have been restored from Amazon Glacier.
        /// It indicates for those objects how long the restored object will exist.
        /// </para>
        /// </summary>
        public DateTime? RestoreExpiration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool? RestoreInProgress { get; set; }

        /// <summary>
        /// Gets and sets the ServerSideEncryptionCustomerMethod property.
        /// <para>
        /// The server-side encryption algorithm to be used with the customer provided key.
        /// </para>
        /// </summary>
        public ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod { get; set; }

        /// <summary>
        /// Gets and sets the ServerSideEncryptionCustomerProvidedKeyMD5 property.
        /// <para>
        /// The MD5 server-side encryption of the customer-provided encryption key.
        /// </para>
        /// </summary>
        public string ServerSideEncryptionCustomerProvidedKeyMD5 { get; set; }

        /// <summary>
        /// Gets and sets the ServerSideEncryptionKeyManagementServiceKeyId property.
        /// <para>
        /// If present, indicates the ID of the KMS key that was used for object encryption.
        /// </para>
        /// </summary>
        public string ServerSideEncryptionKeyManagementServiceKeyId { get; set; }

        /// <summary>
        /// Gets and sets the ServerSideEncryptionMethod property.
        /// <para>
        /// The server-side encryption algorithm used when you store this object in Amazon S3.
        /// </para>
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod { get; set; }

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// Provides storage class information of the object.
        /// </para>
        /// </summary>
        public S3StorageClass StorageClass { get; set; }

        /// <summary>
        /// Gets and sets the property TagCount. 
        /// <para>
        /// The number of tags, if any, on the object.
        /// </para>
        /// </summary>
        public int? TagCount { get; set; }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Version ID of the object.
        /// </para>
        /// </summary>
        public string VersionId { get; set; }

        /// <summary>
        /// Gets and sets the property WebsiteRedirectLocation. 
        /// <para>
        /// If the bucket is configured as a website, redirects requests for this object to another
        /// object in the same bucket or to an external URL.
        /// </para>
        /// </summary>
        public string WebsiteRedirectLocation { get; set; }
    }
}
