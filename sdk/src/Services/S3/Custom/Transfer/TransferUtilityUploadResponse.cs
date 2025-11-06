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
using Amazon.Runtime;
using Amazon.S3.Model;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Transfer
{
    /// <summary>
    /// Response object for Transfer Utility upload operations.
    /// Contains unified response fields from both simple uploads (PutObjectResponse) 
    /// and multipart uploads (CompleteMultipartUploadResponse).
    /// </summary>
    public class TransferUtilityUploadResponse
    {
        private bool? _bucketKeyEnabled;
        private string _bucketName;
        private string _checksumCRC32;
        private string _checksumCRC32C;
        private string _checksumCRC64NVME;
        private string _checksumSHA1;
        private string _checksumSHA256;
        private ChecksumType _checksumType;
        private string _etag;
        private Expiration _expiration;
        private string _key;
        private string _location;
        private RequestCharged _requestCharged;
        private ServerSideEncryptionCustomerMethod _serverSideEncryptionCustomerMethod;
        private long? _size;
        private string _sseCustomerKeyMD5;
        private string _sseKmsEncryptionContext;
        private string _sseKmsKeyId;
        private ServerSideEncryptionMethod _serverSideEncryption;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property BucketKeyEnabled. 
        /// <para>
        /// Indicates whether the uploaded object uses an S3 Bucket Key for server-side encryption
        /// with Key Management Service (KMS) keys (SSE-KMS).
        /// </para>
        /// </summary>
        public bool? BucketKeyEnabled
        {
            get { return this._bucketKeyEnabled; }
            set { this._bucketKeyEnabled = value; }
        }

        /// <summary>
        /// Checks if BucketKeyEnabled property is set.
        /// </summary>
        /// <returns>true if BucketKeyEnabled property is set.</returns>
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
            get { return this._bucketName; }
            set { this._bucketName = value; }
        }

        /// <summary>
        /// Checks if BucketName property is set.
        /// </summary>
        /// <returns>true if BucketName property is set.</returns>
        internal bool IsSetBucketName()
        {
            return !string.IsNullOrEmpty(this._bucketName);
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// The object key of the newly created object.
        /// </para>
        /// </summary>
        public string Key
        {
            get { return this._key; }
            set { this._key = value; }
        }

        /// <summary>
        /// Checks if Key property is set.
        /// </summary>
        /// <returns>true if Key property is set.</returns>
        internal bool IsSetKey()
        {
            return !string.IsNullOrEmpty(this._key);
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

        /// <summary>
        /// Checks if Location property is set.
        /// </summary>
        /// <returns>true if Location property is set.</returns>
        internal bool IsSetLocation()
        {
            return !string.IsNullOrEmpty(this._location);
        }

        /// <summary>
        /// Gets and sets the property Size. 
        /// <para>
        /// The size of the object in bytes. This will only be present if you append to an object.
        /// </para>
        /// <note><para>This functionality is only supported for objects in the S3 Express One Zone storage class in directory buckets.</para></note>
        /// </summary>
        public long? Size
        {
            get { return this._size; }
            set { this._size = value; }
        }

        /// <summary>
        /// Checks if Size property is set.
        /// </summary>
        /// <returns>true if Size property is set.</returns>
        internal bool IsSetSize()
        {
            return this._size.HasValue;
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

        /// <summary>
        /// Checks if ChecksumCRC32 property is set.
        /// </summary>
        /// <returns>true if ChecksumCRC32 property is set.</returns>
        internal bool IsSetChecksumCRC32()
        {
            return !string.IsNullOrEmpty(this._checksumCRC32);
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

        /// <summary>
        /// Checks if ChecksumCRC32C property is set.
        /// </summary>
        /// <returns>true if ChecksumCRC32C property is set.</returns>
        internal bool IsSetChecksumCRC32C()
        {
            return !string.IsNullOrEmpty(this._checksumCRC32C);
        }

        /// <summary>
        /// Gets and sets the property ChecksumCRC64NVME. 
        /// <para>
        /// The Base64 encoded, 64-bit <c>CRC-64NVME</c> checksum of the object. This header is present
        /// if it was uploaded with the <c>CRC-64NVME</c> checksum algorithm, or if it was uploaded 
        /// without a checksum (and Amazon S3 added the default checksum, <c>CRC-64NVME</c>, to the uploaded object).
        /// For more information about how checksums are calculated with multipart
        /// uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html#large-object-checksums">
        /// Checking object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string ChecksumCRC64NVME
        {
            get { return this._checksumCRC64NVME; }
            set { this._checksumCRC64NVME = value; }
        }

        /// <summary>
        /// Checks if ChecksumCRC64NVME property is set.
        /// </summary>
        /// <returns>true if ChecksumCRC64NVME property is set.</returns>
        internal bool IsSetChecksumCRC64NVME()
        {
            return !string.IsNullOrEmpty(this._checksumCRC64NVME);
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

        /// <summary>
        /// Checks if ChecksumSHA1 property is set.
        /// </summary>
        /// <returns>true if ChecksumSHA1 property is set.</returns>
        internal bool IsSetChecksumSHA1()
        {
            return !string.IsNullOrEmpty(this._checksumSHA1);
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

        /// <summary>
        /// Checks if ChecksumSHA256 property is set.
        /// </summary>
        /// <returns>true if ChecksumSHA256 property is set.</returns>
        internal bool IsSetChecksumSHA256()
        {
            return !string.IsNullOrEmpty(this._checksumSHA256);
        }

        /// <summary>
        /// Gets and sets the property ChecksumType. 
        /// <para>
        /// This header specifies the checksum type of the object, which determines how part-level 
        /// checksums are combined to create an object-level checksum for multipart objects. For 
        /// <c>PutObject</c> uploads, the checksum type is always <c>FULL_OBJECT</c>. You can use 
        /// this header as a data integrity check to verify that the checksum type that is received 
        /// is the same checksum that was specified. For more information, 
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
        /// Checking object integrity in the Amazon S3 User Guide</a>.
        /// </para>
        /// </summary>
        public ChecksumType ChecksumType
        {
            get { return this._checksumType; }
            set { this._checksumType = value; }
        }

        /// <summary>
        /// Checks if ChecksumType property is set.
        /// </summary>
        /// <returns>true if ChecksumType property is set.</returns>
        internal bool IsSetChecksumType()
        {
            return this._checksumType != null;
        }

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// Entity tag for the uploaded object.
        /// </para>
        ///  
        /// <para>
        ///  <b>General purpose buckets </b> - To ensure that data is not corrupted traversing
        /// the network, for objects where the ETag is the MD5 digest of the object, you can calculate
        /// the MD5 while putting an object to Amazon S3 and compare the returned ETag to the
        /// calculated MD5 value.
        /// </para>
        ///  
        /// <para>
        ///  <b>Directory buckets </b> - The ETag for the object in a directory bucket isn't the
        /// MD5 digest of the object.
        /// </para>
        /// </summary>
        public string ETag
        {
            get { return this._etag; }
            set { this._etag = value; }
        }

        /// <summary>
        /// Checks if ETag property is set.
        /// </summary>
        /// <returns>true if ETag property is set.</returns>
        internal bool IsSetETag()
        {
            return !string.IsNullOrEmpty(this._etag);
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
            get { return this._expiration; }
            set { this._expiration = value; }
        }

        /// <summary>
        /// Checks if Expiration property is set.
        /// </summary>
        /// <returns>true if Expiration property is set.</returns>
        internal bool IsSetExpiration()
        {
            return this._expiration != null;
        }

        /// <summary>
        /// Gets and sets the property RequestCharged.
        /// <para>
        /// If present, indicates that the requester was successfully charged for the request.
        /// </para>
        /// </summary>
        public RequestCharged RequestCharged
        {
            get { return this._requestCharged; }
            set { this._requestCharged = value; }
        }

        /// <summary>
        /// Checks if RequestCharged property is set.
        /// </summary>
        /// <returns>true if RequestCharged property is set.</returns>
        internal bool IsSetRequestCharged()
        {
            return this._requestCharged != null;
        }

        /// <summary>
        /// The Server-side encryption algorithm to be used with the customer provided key.
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod
        {
            get { return this._serverSideEncryptionCustomerMethod; }
            set { this._serverSideEncryptionCustomerMethod = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionCustomerMethod property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionCustomerMethod property is set.</returns>
        internal bool IsSetServerSideEncryptionCustomerMethod()
        {
            return this._serverSideEncryptionCustomerMethod != null;
        }

        /// <summary>
        /// The MD5 of the customer encryption key specified in the ServerSideEncryptionCustomerProvidedKey property. The MD5 is
        /// base 64 encoded. This field is optional, the SDK will calculate the MD5 if this is not set.
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string ServerSideEncryptionCustomerProvidedKeyMD5
        {
            get { return this._sseCustomerKeyMD5; }
            set { this._sseCustomerKeyMD5 = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionCustomerProvidedKeyMD5 property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionCustomerProvidedKeyMD5 property is set.</returns>
        internal bool IsSetServerSideEncryptionCustomerProvidedKeyMD5()
        {
            return !string.IsNullOrEmpty(this._sseCustomerKeyMD5);
        }

        /// <summary>
        /// <para>
        /// If present, indicates the Amazon Web Services KMS Encryption Context to use for object encryption. 
        /// The value of this header is a Base64 encoded string of a UTF-8 encoded JSON, which contains the encryption context as key-value pairs. 
        /// This value is stored as object metadata and automatically gets passed on to Amazon Web Services KMS for future <c>GetObject</c> operations on this object.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ServerSideEncryptionKeyManagementServiceEncryptionContext
        {
            get { return this._sseKmsEncryptionContext; }
            set { this._sseKmsEncryptionContext = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionKeyManagementServiceEncryptionContext property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionKeyManagementServiceEncryptionContext property is set.</returns>
        internal bool IsSetServerSideEncryptionKeyManagementServiceEncryptionContext()
        {
            return !string.IsNullOrEmpty(this._sseKmsEncryptionContext);
        }

        /// <summary>
        /// <para>
        /// If present, indicates the ID of the KMS key that was used for object encryption.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ServerSideEncryptionKeyManagementServiceKeyId
        {
            get { return this._sseKmsKeyId; }
            set { this._sseKmsKeyId = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionKeyManagementServiceKeyId property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionKeyManagementServiceKeyId property is set.</returns>
        internal bool IsSetServerSideEncryptionKeyManagementServiceKeyId()
        {
            return !string.IsNullOrEmpty(this._sseKmsKeyId);
        }

        /// <summary>
        /// <para>
        /// The server-side encryption algorithm used when you store this object in Amazon S3 or Amazon FSx.
        /// </para>
        /// <note>
        /// <para>
        /// When accessing data stored in Amazon FSx file systems using S3 access points, the only valid server side encryption option is <c>aws:fsx</c>.
        /// </para>
        /// </note>
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get { return this._serverSideEncryption; }
            set { this._serverSideEncryption = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionMethod property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionMethod property is set.</returns>
        internal bool IsSetServerSideEncryptionMethod()
        {
            return this._serverSideEncryption != null;
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// Version ID of the object.
        /// </para>
        ///  
        /// <para>
        /// If you enable versioning for a bucket, Amazon S3 automatically generates a unique
        /// version ID for the object being stored. Amazon S3 returns this ID in the response.
        /// When you enable versioning for a bucket, if Amazon S3 receives multiple write requests
        /// for the same object simultaneously, it stores all of the objects. For more information
        /// about versioning, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/AddingObjectstoVersioningEnabledBuckets.html">Adding
        /// Objects to Versioning-Enabled Buckets</a> in the <i>Amazon S3 User Guide</i>. For
        /// information about returning the versioning state of a bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketVersioning.html">GetBucketVersioning</a>.
        /// 
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

        /// <summary>
        /// Checks if VersionId property is set.
        /// </summary>
        /// <returns>true if VersionId property is set.</returns>
        internal bool IsSetVersionId()
        {
            return !string.IsNullOrEmpty(this._versionId);
        }
    }
}
