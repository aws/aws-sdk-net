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
using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
	/// <summary>
	/// Returns information about the  CompleteMultipartUpload response and response metadata.
	/// </summary>
	public class CompleteMultipartUploadResponse : AmazonWebServiceResponse
    {
        private string location;
        private string bucketName;
        private string _checksumCRC32;
        private string _checksumCRC32C;
        private string _checksumCRC64NVME;
        private string _checksumSHA1;
        private string _checksumSHA256;
        private string key;
        private string eTag;
        private string versionId;
        private ChecksumType checksumType;
        private Expiration expiration;
        private ServerSideEncryptionMethod serverSideEncryption;
        private string serverSideEncryptionKeyManagementServiceKeyId;
        private RequestCharged requestCharged;
        private bool? bucketKeyEnabled;

        /// <summary>
        /// Gets and sets the property BucketKeyEnabled. 
        /// <para>
        /// Indicates whether the multipart upload uses an S3 Bucket Key for server-side encryption 
        /// with Key Management Service (KMS) keys (SSE-KMS).
        /// </para>
        /// </summary>
        public bool? BucketKeyEnabled
        {
            get { return this.bucketKeyEnabled; }
            set { this.bucketKeyEnabled = value; }
        }

        // Check to see if BucketKeyEnabled property is set
        internal bool IsSetBucketKeyEnabled()
        {
            return bucketKeyEnabled.HasValue;
        }

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket that contains the newly created object. Does not return the
        /// access point ARN or access point alias if used.
        /// </para>
        ///  
        /// <para>
        /// When using this action with an access point, you must direct requests to the access
        /// point hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com.
        /// When using this action with an access point through the Amazon Web Services SDKs,
        /// you provide the access point ARN in place of the bucket name. For more information
        /// about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-access-points.html">Using
        /// access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you use this action with Amazon S3 on Outposts, you must direct requests to the
        /// S3 on Outposts hostname. The S3 on Outposts hostname takes the form <code> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</code>.
        /// When you use this action with S3 on Outposts through the Amazon Web Services SDKs,
        /// you provide the Outposts access point ARN in place of the bucket name. For more information
        /// about S3 on Outposts ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">What
        /// is S3 on Outposts?</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
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
        /// Gets and sets the property ETag. 
        /// <para>
        /// Entity tag that identifies the newly created object's data. Objects with different
        /// object data will have different entity tags. The entity tag is an opaque string. The
        /// entity tag may or may not be an MD5 digest of the object data. If the entity tag is
        /// not an MD5 digest of the object data, it will contain one or more nonhexadecimal characters
        /// and/or will consist of less than 32 or more than 32 hexadecimal digits.
        /// </para>
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

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The object key of the newly created object.
        /// </para>
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
        /// Gets and sets the property Location. 
        /// <para>
        /// The URI that identifies the newly created object.
        /// </para>
        /// </summary>
        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        // Check to see if Location property is set
        internal bool IsSetLocation()
        {
            return this.location != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumType.
        /// <para>
        /// This header specifies the checksum type of the object, which determines how part-level checksums
        /// are combined to create an object-level checksum for multipart objects.You can use this header as
        /// a data integrity check to verify that the checksum type that is received is the same checksum that
        /// was specified. If the checksum type doesn't match the checksum type that was specified for the object
        /// during the<c> CreateMultipartUpload</c> request, it'll result in a<c> BadDigest</c> error.For more information,
        /// see Checking object integrity in the Amazon S3 User Guide.
        /// </para>
        /// </summary>
        public ChecksumType ChecksumType
        {
            get { return this.checksumType; }
            set { this.checksumType = value; }
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
        /// <para>
        /// The server-side encryption algorithm used when storing this object in Amazon S3.
        /// </para>
        /// <note> 
        /// <para>
        /// When accessing data stored in Amazon FSx file systems using S3 access points, the
        /// only valid server side encryption option is <c>aws:fsx</c>.
        /// </para>
        /// </note>
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get { return this.serverSideEncryption; }
            set { this.serverSideEncryption = value; }
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
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Version ID of the newly created object, in case the bucket has versioning turned on.
        /// </para>
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

        

    }
}
    
