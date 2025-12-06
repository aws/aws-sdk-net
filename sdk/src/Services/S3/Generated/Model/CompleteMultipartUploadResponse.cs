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

/*
 * Do not modify this file. This file is generated from the s3-2006-03-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.S3.Model
{
    /// <summary>
    /// This is the response object from the CompleteMultipartUpload operation.
    /// </summary>
    public partial class CompleteMultipartUploadResponse : AmazonWebServiceResponse
    {
        private bool? _bucketKeyEnabled;
        private string _bucketName;
        private string _checksumCRC32;
        private string _checksumCRC32C;
        private string _checksumCRC64NVME;
        private string _checksumSHA1;
        private string _checksumSHA256;
        private ChecksumType _checksumType;
        private string _eTag;
        private Expiration _expiration;
        private string _key;
        private string _location;
        private RequestCharged _requestCharged;
        private string _serverSideEncryptionKeyManagementServiceKeyId;
        private ServerSideEncryptionMethod _serverSideEncryptionMethod;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property BucketKeyEnabled. 
        /// <para>
        /// Indicates whether the multipart upload uses an S3 Bucket Key for server-side encryption
        /// with Key Management Service (KMS) keys (SSE-KMS).
        /// </para>
        /// </summary>
        public bool? BucketKeyEnabled
        {
            get { return this._bucketKeyEnabled; }
            set { this._bucketKeyEnabled = value; }
        }

        // Check to see if BucketKeyEnabled property is set
        internal bool IsSetBucketKeyEnabled()
        {
            return this._bucketKeyEnabled.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket that contains the newly created object. Does not return the
        /// access point ARN or access point alias if used.
        /// </para>
        ///  <note> 
        /// <para>
        /// Access points are not supported by directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string BucketName
        {
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        // Check to see if BucketName property is set
        internal bool IsSetBucketName()
        {
            return this._bucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumCRC32. 
        /// <para>
        /// The Base64 encoded, 32-bit <c>CRC32 checksum</c> of the object. This checksum is only
        /// present if the checksum was uploaded with the object. When you use an API operation
        /// on an object that was uploaded using multipart uploads, this value may not be a direct
        /// checksum value of the full object. Instead, it's a calculation based on the checksum
        /// values of each individual part. For more information about how checksums are calculated
        /// with multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html#large-object-checksums">
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
        /// The Base64 encoded, 32-bit <c>CRC32C</c> checksum of the object. This checksum is
        /// only present if the checksum was uploaded with the object. When you use an API operation
        /// on an object that was uploaded using multipart uploads, this value may not be a direct
        /// checksum value of the full object. Instead, it's a calculation based on the checksum
        /// values of each individual part. For more information about how checksums are calculated
        /// with multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html#large-object-checksums">
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
        /// This header can be used as a data integrity check to verify that the data received
        /// is the same data that was originally sent. This header specifies the Base64 encoded,
        /// 64-bit <c>CRC64NVME</c> checksum of the object. The <c>CRC64NVME</c> checksum is always
        /// a full object checksum. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity in the Amazon S3 User Guide</a>. 
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
        /// The Base64 encoded, 160-bit <c>SHA1</c> digest of the object. This checksum is only
        /// present if the checksum was uploaded with the object. When you use the API operation
        /// on an object that was uploaded using multipart uploads, this value may not be a direct
        /// checksum value of the full object. Instead, it's a calculation based on the checksum
        /// values of each individual part. For more information about how checksums are calculated
        /// with multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html#large-object-checksums">
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
        /// The Base64 encoded, 256-bit <c>SHA256</c> digest of the object. This checksum is only
        /// present if the checksum was uploaded with the object. When you use an API operation
        /// on an object that was uploaded using multipart uploads, this value may not be a direct
        /// checksum value of the full object. Instead, it's a calculation based on the checksum
        /// values of each individual part. For more information about how checksums are calculated
        /// with multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html#large-object-checksums">
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
        /// The checksum type, which determines how part-level checksums are combined to create
        /// an object-level checksum for multipart objects. You can use this header as a data
        /// integrity check to verify that the checksum type that is received is the same checksum
        /// type that was specified during the <c>CreateMultipartUpload</c> request. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity in the Amazon S3 User Guide</a>.
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

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// Entity tag that identifies the newly created object's data. Objects with different
        /// object data will have different entity tags. The entity tag is an opaque string. The
        /// entity tag may or may not be an MD5 digest of the object data. If the entity tag is
        /// not an MD5 digest of the object data, it will contain one or more nonhexadecimal characters
        /// and/or will consist of less than 32 or more than 32 hexadecimal digits. For more information
        /// about how the entity tag is calculated, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string ETag
        {
            get { return this._eTag; }
            set { this._eTag = value; }
        }

        // Check to see if ETag property is set
        internal bool IsSetETag()
        {
            return this._eTag != null;
        }

        /// <summary>
        /// Gets and sets the property Expiration. 
        /// <para>
        /// If the object expiration is configured, this will contain the expiration date (<c>expiry-date</c>)
        /// and rule ID (<c>rule-id</c>). The value of <c>rule-id</c> is URL-encoded.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public Expiration Expiration
        {
            get { return this._expiration; }
            set { this._expiration = value; }
        }

        // Check to see if Expiration property is set
        internal bool IsSetExpiration()
        {
            return this._expiration != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The object key of the newly created object.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        // Check to see if Key property is set
        internal bool IsSetKey()
        {
            return this._key != null;
        }

        /// <summary>
        /// Gets and sets the property Location. 
        /// <para>
        /// The URI that identifies the newly created object.
        /// </para>
        /// </summary>
        public string Location
        {
            get { return this._location; }
            set { this._location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this._location != null;
        }

        /// <summary>
        /// Gets and sets the property RequestCharged.
        /// </summary>
        public RequestCharged RequestCharged
        {
            get { return this._requestCharged; }
            set { this._requestCharged = value; }
        }

        // Check to see if RequestCharged property is set
        internal bool IsSetRequestCharged()
        {
            return this._requestCharged != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionKeyManagementServiceKeyId. 
        /// <para>
        /// If present, indicates the ID of the KMS key that was used for object encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ServerSideEncryptionKeyManagementServiceKeyId
        {
            get { return this._serverSideEncryptionKeyManagementServiceKeyId; }
            set { this._serverSideEncryptionKeyManagementServiceKeyId = value; }
        }

        // Check to see if ServerSideEncryptionKeyManagementServiceKeyId property is set
        internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
        {
            return this._serverSideEncryptionKeyManagementServiceKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionMethod. 
        /// <para>
        /// The server-side encryption algorithm used when storing this object in Amazon S3.
        /// </para>
        ///  <note> 
        /// <para>
        /// When accessing data stored in Amazon FSx file systems using S3 access points, the
        /// only valid server side encryption option is <c>aws:fsx</c>.
        /// </para>
        ///  </note>
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get { return this._serverSideEncryptionMethod; }
            set { this._serverSideEncryptionMethod = value; }
        }

        // Check to see if ServerSideEncryptionMethod property is set
        internal bool IsSetServerSideEncryptionMethod()
        {
            return this._serverSideEncryptionMethod != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Version ID of the newly created object, in case the bucket has versioning turned on.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return this._versionId != null;
        }

    }
}