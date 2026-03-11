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
    /// Container for the parameters to the WriteGetObjectResponse operation.
    /// <note> 
    /// <para>
    /// This operation is not supported for directory buckets.
    /// </para>
    ///  </note> 
    /// <para>
    /// Passes transformed objects to a <c>GetObject</c> operation when using Object Lambda
    /// access points. For information about Object Lambda access points, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/transforming-objects.html">Transforming
    /// objects with Object Lambda access points</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// This operation supports metadata that can be returned by <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObject.html">GetObject</a>,
    /// in addition to <c>RequestRoute</c>, <c>RequestToken</c>, <c>StatusCode</c>, <c>ErrorCode</c>,
    /// and <c>ErrorMessage</c>. The <c>GetObject</c> response metadata is supported so that
    /// the <c>WriteGetObjectResponse</c> caller, typically an Lambda function, can provide
    /// the same metadata when it internally invokes <c>GetObject</c>. When <c>WriteGetObjectResponse</c>
    /// is called by a customer-owned Lambda function, the metadata returned to the end user
    /// <c>GetObject</c> call might differ from what Amazon S3 would normally return.
    /// </para>
    ///  
    /// <para>
    /// You can include any number of metadata headers. When including a metadata header,
    /// it should be prefaced with <c>x-amz-meta</c>. For example, <c>x-amz-meta-my-custom-header:
    /// MyCustomValue</c>. The primary use case for this is to forward <c>GetObject</c> metadata.
    /// </para>
    ///  
    /// <para>
    /// Amazon Web Services provides some prebuilt Lambda functions that you can use with
    /// S3 Object Lambda to detect and redact personally identifiable information (PII) and
    /// decompress S3 objects. These Lambda functions are available in the Amazon Web Services
    /// Serverless Application Repository, and can be selected through the Amazon Web Services
    /// Management Console when you create your Object Lambda access point.
    /// </para>
    ///  
    /// <para>
    /// Example 1: PII Access Control - This Lambda function uses Amazon Comprehend, a natural
    /// language processing (NLP) service using machine learning to find insights and relationships
    /// in text. It automatically detects personally identifiable information (PII) such as
    /// names, addresses, dates, credit card numbers, and social security numbers from documents
    /// in your Amazon S3 bucket. 
    /// </para>
    ///  
    /// <para>
    /// Example 2: PII Redaction - This Lambda function uses Amazon Comprehend, a natural
    /// language processing (NLP) service using machine learning to find insights and relationships
    /// in text. It automatically redacts personally identifiable information (PII) such as
    /// names, addresses, dates, credit card numbers, and social security numbers from documents
    /// in your Amazon S3 bucket. 
    /// </para>
    ///  
    /// <para>
    /// Example 3: Decompression - The Lambda function S3ObjectLambdaDecompression, is equipped
    /// to decompress objects stored in S3 in one of six compressed file formats including
    /// bzip2, gzip, snappy, zlib, zstandard and ZIP. 
    /// </para>
    ///  
    /// <para>
    /// For information on how to view and use these functions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/olap-examples.html">Using
    /// Amazon Web Services built Lambda functions</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// You must URL encode any signed header values that contain spaces. For example, if
    /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
    /// must URL encode this value to <c>my%20%20file.txt</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class WriteGetObjectResponseRequest : AmazonWebServiceRequest
    {
        private string _acceptRanges;
        private Stream _body;
        private bool? _bucketKeyEnabled;
        private string _cacheControl;
        private string _checksumCRC32;
        private string _checksumCRC32C;
        private string _checksumCRC64NVME;
        private string _checksumSHA1;
        private string _checksumSHA256;
        private string _contentDisposition;
        private string _contentEncoding;
        private string _contentLanguage;
        private long? _contentLength;
        private string _contentRange;
        private string _contentType;
        private bool? _deleteMarker;
        private string _errorCode;
        private string _errorMessage;
        private string _eTag;
        private string _expiration;
        private DateTime? _expires;
        private DateTime? _lastModified;
        private MetadataCollection _metadata = AWSConfigs.InitializeCollections ? new MetadataCollection() : null;
        private int? _missingMeta;
        private ObjectLockLegalHoldStatus _objectLockLegalHoldStatus;
        private ObjectLockMode _objectLockMode;
        private DateTime? _objectLockRetainUntilDate;
        private int? _partsCount;
        private ReplicationStatus _replicationStatus;
        private RequestCharged _requestCharged;
        private string _requestRoute;
        private string _requestToken;
        private string _restore;
        private ServerSideEncryptionMethod _serverSideEncryptionMethod;
        private ServerSideEncryptionCustomerMethod _sseCustomerAlgorithm;
        private string _sseCustomerKeyMD5;
        private string _ssekmsKeyId;
        private int? _statusCode;
        private S3StorageClass _storageClass;
        private int? _tagCount;
        private string _versionId;

        /// <summary>
        /// Gets and sets the property AcceptRanges. 
        /// <para>
        /// Indicates that a range of bytes was specified.
        /// </para>
        /// </summary>
        public string AcceptRanges
        {
            get { return this._acceptRanges; }
            set { this._acceptRanges = value; }
        }

        // Check to see if AcceptRanges property is set
        internal bool IsSetAcceptRanges()
        {
            return this._acceptRanges != null;
        }

        /// <summary>
        /// Gets and sets the property Body. 
        /// <para>
        /// The object data.
        /// </para>
        /// </summary>
        public Stream Body
        {
            get { return this._body; }
            set { this._body = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetBody()
        {
            return this._body != null;
        }

        /// <summary>
        /// Gets and sets the property BucketKeyEnabled. 
        /// <para>
        ///  Indicates whether the object stored in Amazon S3 uses an S3 bucket key for server-side
        /// encryption with Amazon Web Services KMS (SSE-KMS).
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
        /// Gets and sets the property CacheControl. 
        /// <para>
        /// Specifies caching behavior along the request/reply chain.
        /// </para>
        /// </summary>
        public string CacheControl
        {
            get { return this._cacheControl; }
            set { this._cacheControl = value; }
        }

        // Check to see if CacheControl property is set
        internal bool IsSetCacheControl()
        {
            return this._cacheControl != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumCRC32. 
        /// <para>
        /// This header can be used as a data integrity check to verify that the data received
        /// is the same data that was originally sent. This specifies the Base64 encoded, 32-bit
        /// <c>CRC32</c> checksum of the object returned by the Object Lambda function. This may
        /// not match the checksum for the object stored in Amazon S3. Amazon S3 will perform
        /// validation of the checksum values only when the original <c>GetObject</c> request
        /// required checksum validation. For more information about checksums, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Only one checksum header can be specified at a time. If you supply multiple checksum
        /// headers, this request will fail.
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
        /// This header can be used as a data integrity check to verify that the data received
        /// is the same data that was originally sent. This specifies the Base64 encoded, 32-bit
        /// <c>CRC32C</c> checksum of the object returned by the Object Lambda function. This
        /// may not match the checksum for the object stored in Amazon S3. Amazon S3 will perform
        /// validation of the checksum values only when the original <c>GetObject</c> request
        /// required checksum validation. For more information about checksums, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Only one checksum header can be specified at a time. If you supply multiple checksum
        /// headers, this request will fail.
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
        /// 64-bit <c>CRC64NVME</c> checksum of the part. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// This header can be used as a data integrity check to verify that the data received
        /// is the same data that was originally sent. This specifies the Base64 encoded, 160-bit
        /// <c>SHA1</c> digest of the object returned by the Object Lambda function. This may
        /// not match the checksum for the object stored in Amazon S3. Amazon S3 will perform
        /// validation of the checksum values only when the original <c>GetObject</c> request
        /// required checksum validation. For more information about checksums, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Only one checksum header can be specified at a time. If you supply multiple checksum
        /// headers, this request will fail.
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
        /// This header can be used as a data integrity check to verify that the data received
        /// is the same data that was originally sent. This specifies the Base64 encoded, 256-bit
        /// <c>SHA256</c> digest of the object returned by the Object Lambda function. This may
        /// not match the checksum for the object stored in Amazon S3. Amazon S3 will perform
        /// validation of the checksum values only when the original <c>GetObject</c> request
        /// required checksum validation. For more information about checksums, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Only one checksum header can be specified at a time. If you supply multiple checksum
        /// headers, this request will fail.
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
        /// Gets and sets the property ContentDisposition. 
        /// <para>
        /// Specifies presentational information for the object.
        /// </para>
        /// </summary>
        public string ContentDisposition
        {
            get { return this._contentDisposition; }
            set { this._contentDisposition = value; }
        }

        // Check to see if ContentDisposition property is set
        internal bool IsSetContentDisposition()
        {
            return this._contentDisposition != null;
        }

        /// <summary>
        /// Gets and sets the property ContentEncoding. 
        /// <para>
        /// Specifies what content encodings have been applied to the object and thus what decoding
        /// mechanisms must be applied to obtain the media-type referenced by the Content-Type
        /// header field.
        /// </para>
        /// </summary>
        public string ContentEncoding
        {
            get { return this._contentEncoding; }
            set { this._contentEncoding = value; }
        }

        // Check to see if ContentEncoding property is set
        internal bool IsSetContentEncoding()
        {
            return this._contentEncoding != null;
        }

        /// <summary>
        /// Gets and sets the property ContentLanguage. 
        /// <para>
        /// The language the content is in.
        /// </para>
        /// </summary>
        public string ContentLanguage
        {
            get { return this._contentLanguage; }
            set { this._contentLanguage = value; }
        }

        // Check to see if ContentLanguage property is set
        internal bool IsSetContentLanguage()
        {
            return this._contentLanguage != null;
        }

        /// <summary>
        /// Gets and sets the property ContentLength. 
        /// <para>
        /// The size of the content body in bytes.
        /// </para>
        /// </summary>
        public long? ContentLength
        {
            get { return this._contentLength; }
            set { this._contentLength = value; }
        }

        // Check to see if ContentLength property is set
        internal bool IsSetContentLength()
        {
            return this._contentLength.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ContentRange. 
        /// <para>
        /// The portion of the object returned in the response.
        /// </para>
        /// </summary>
        public string ContentRange
        {
            get { return this._contentRange; }
            set { this._contentRange = value; }
        }

        // Check to see if ContentRange property is set
        internal bool IsSetContentRange()
        {
            return this._contentRange != null;
        }

        /// <summary>
        /// Gets and sets the property ContentType. 
        /// <para>
        /// A standard MIME type describing the format of the object data.
        /// </para>
        /// </summary>
        public string ContentType
        {
            get { return this._contentType; }
            set { this._contentType = value; }
        }

        // Check to see if ContentType property is set
        internal bool IsSetContentType()
        {
            return this._contentType != null;
        }

        /// <summary>
        /// Gets and sets the property DeleteMarker. 
        /// <para>
        /// Specifies whether an object stored in Amazon S3 is (<c>true</c>) or is not (<c>false</c>)
        /// a delete marker. To learn more about delete markers, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/DeleteMarker.html">Working
        /// with delete markers</a>.
        /// </para>
        /// </summary>
        public bool? DeleteMarker
        {
            get { return this._deleteMarker; }
            set { this._deleteMarker = value; }
        }

        // Check to see if DeleteMarker property is set
        internal bool IsSetDeleteMarker()
        {
            return this._deleteMarker.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ErrorCode. 
        /// <para>
        /// A string that uniquely identifies an error condition. Returned in the &lt;Code&gt;
        /// tag of the error XML response for a corresponding <c>GetObject</c> call. Cannot be
        /// used with a successful <c>StatusCode</c> header or when the transformed object is
        /// provided in the body. All error codes from S3 are sentence-cased. The regular expression
        /// (regex) value is <c>"^[A-Z][a-zA-Z]+$"</c>.
        /// </para>
        /// </summary>
        public string ErrorCode
        {
            get { return this._errorCode; }
            set { this._errorCode = value; }
        }

        // Check to see if ErrorCode property is set
        internal bool IsSetErrorCode()
        {
            return this._errorCode != null;
        }

        /// <summary>
        /// Gets and sets the property ErrorMessage. 
        /// <para>
        /// Contains a generic description of the error condition. Returned in the &lt;Message&gt;
        /// tag of the error XML response for a corresponding <c>GetObject</c> call. Cannot be
        /// used with a successful <c>StatusCode</c> header or when the transformed object is
        /// provided in body.
        /// </para>
        /// </summary>
        public string ErrorMessage
        {
            get { return this._errorMessage; }
            set { this._errorMessage = value; }
        }

        // Check to see if ErrorMessage property is set
        internal bool IsSetErrorMessage()
        {
            return this._errorMessage != null;
        }

        /// <summary>
        /// Gets and sets the property ETag. 
        /// <para>
        /// An opaque identifier assigned by a web server to a specific version of a resource
        /// found at a URL. 
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
        /// If the object expiration is configured (see PUT Bucket lifecycle), the response includes
        /// this header. It includes the <c>expiry-date</c> and <c>rule-id</c> key-value pairs
        /// that provide the object expiration information. The value of the <c>rule-id</c> is
        /// URL-encoded. 
        /// </para>
        /// </summary>
        public string Expiration
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
        /// Gets and sets the property Expires. 
        /// <para>
        /// The date and time at which the object is no longer cacheable.
        /// </para>
        /// </summary>
        public DateTime? Expires
        {
            get { return this._expires; }
            set { this._expires = value; }
        }

        // Check to see if Expires property is set
        internal bool IsSetExpires()
        {
            return this._expires != null;
        }

        /// <summary>
        /// Gets and sets the property LastModified. 
        /// <para>
        /// The date and time that the object was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModified
        {
            get { return this._lastModified; }
            set { this._lastModified = value; }
        }

        // Check to see if LastModified property is set
        internal bool IsSetLastModified()
        {
            return this._lastModified.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Metadata. 
        /// <para>
        /// A map of metadata to store with the object in S3.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public MetadataCollection Metadata
        {
            get {
                if (this._metadata == null) this._metadata = new MetadataCollection();
                return this._metadata;
            }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null && (this._metadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MissingMeta. 
        /// <para>
        /// Set to the number of metadata entries not returned in <c>x-amz-meta</c> headers. This
        /// can happen if you create metadata using an API like SOAP that supports more flexible
        /// metadata than the REST API. For example, using SOAP, you can create metadata whose
        /// values are not legal HTTP headers.
        /// </para>
        /// </summary>
        public int? MissingMeta
        {
            get { return this._missingMeta; }
            set { this._missingMeta = value; }
        }

        // Check to see if MissingMeta property is set
        internal bool IsSetMissingMeta()
        {
            return this._missingMeta.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ObjectLockLegalHoldStatus. 
        /// <para>
        /// Indicates whether an object stored in Amazon S3 has an active legal hold.
        /// </para>
        /// </summary>
        public ObjectLockLegalHoldStatus ObjectLockLegalHoldStatus
        {
            get { return this._objectLockLegalHoldStatus; }
            set { this._objectLockLegalHoldStatus = value; }
        }

        // Check to see if ObjectLockLegalHoldStatus property is set
        internal bool IsSetObjectLockLegalHoldStatus()
        {
            return this._objectLockLegalHoldStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectLockMode. 
        /// <para>
        /// Indicates whether an object stored in Amazon S3 has Object Lock enabled. For more
        /// information about S3 Object Lock, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-lock.html">Object
        /// Lock</a>.
        /// </para>
        /// </summary>
        public ObjectLockMode ObjectLockMode
        {
            get { return this._objectLockMode; }
            set { this._objectLockMode = value; }
        }

        // Check to see if ObjectLockMode property is set
        internal bool IsSetObjectLockMode()
        {
            return this._objectLockMode != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectLockRetainUntilDate. 
        /// <para>
        /// The date and time when Object Lock is configured to expire.
        /// </para>
        /// </summary>
        public DateTime? ObjectLockRetainUntilDate
        {
            get { return this._objectLockRetainUntilDate; }
            set { this._objectLockRetainUntilDate = value; }
        }

        // Check to see if ObjectLockRetainUntilDate property is set
        internal bool IsSetObjectLockRetainUntilDate()
        {
            return this._objectLockRetainUntilDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PartsCount. 
        /// <para>
        /// The count of parts this object has.
        /// </para>
        /// </summary>
        public int? PartsCount
        {
            get { return this._partsCount; }
            set { this._partsCount = value; }
        }

        // Check to see if PartsCount property is set
        internal bool IsSetPartsCount()
        {
            return this._partsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReplicationStatus. 
        /// <para>
        /// Indicates if request involves bucket that is either a source or destination in a Replication
        /// rule. For more information about S3 Replication, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/replication.html">Replication</a>.
        /// </para>
        /// </summary>
        public ReplicationStatus ReplicationStatus
        {
            get { return this._replicationStatus; }
            set { this._replicationStatus = value; }
        }

        // Check to see if ReplicationStatus property is set
        internal bool IsSetReplicationStatus()
        {
            return this._replicationStatus != null;
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
        /// Gets and sets the property RequestRoute. 
        /// <para>
        /// Route prefix to the HTTP URL generated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RequestRoute
        {
            get { return this._requestRoute; }
            set { this._requestRoute = value; }
        }

        // Check to see if RequestRoute property is set
        internal bool IsSetRequestRoute()
        {
            return !string.IsNullOrEmpty(this._requestRoute);
        }

        /// <summary>
        /// Gets and sets the property RequestToken. 
        /// <para>
        /// A single use encrypted token that maps <c>WriteGetObjectResponse</c> to the end user
        /// <c>GetObject</c> request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RequestToken
        {
            get { return this._requestToken; }
            set { this._requestToken = value; }
        }

        // Check to see if RequestToken property is set
        internal bool IsSetRequestToken()
        {
            return !string.IsNullOrEmpty(this._requestToken);
        }

        /// <summary>
        /// Gets and sets the property Restore. 
        /// <para>
        /// Provides information about object restoration operation and expiration time of the
        /// restored object copy.
        /// </para>
        /// </summary>
        public string Restore
        {
            get { return this._restore; }
            set { this._restore = value; }
        }

        // Check to see if Restore property is set
        internal bool IsSetRestore()
        {
            return !string.IsNullOrEmpty(this._restore);
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionMethod. 
        /// <para>
        ///  The server-side encryption algorithm used when storing requested object in Amazon
        /// S3 or Amazon FSx.
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
            return this._serverSideEncryptionMethod != null && this._serverSideEncryptionMethod != ServerSideEncryptionMethod.None;
        }

        /// <summary>
        /// Gets and sets the property SSECustomerAlgorithm. 
        /// <para>
        /// Encryption algorithm used if server-side encryption with a customer-provided encryption
        /// key was specified for object stored in Amazon S3.
        /// </para>
        /// </summary>
        public ServerSideEncryptionCustomerMethod SSECustomerAlgorithm
        {
            get { return this._sseCustomerAlgorithm; }
            set { this._sseCustomerAlgorithm = value; }
        }

        // Check to see if SSECustomerAlgorithm property is set
        internal bool IsSetSSECustomerAlgorithm()
        {
            return this._sseCustomerAlgorithm != null && this._sseCustomerAlgorithm != ServerSideEncryptionCustomerMethod.None;
        }

        /// <summary>
        /// Gets and sets the property SSECustomerKeyMD5. 
        /// <para>
        ///  128-bit MD5 digest of customer-provided encryption key used in Amazon S3 to encrypt
        /// data stored in S3. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/ServerSideEncryptionCustomerKeys.html">Protecting
        /// data using server-side encryption with customer-provided encryption keys (SSE-C)</a>.
        /// </para>
        /// </summary>
        public string SSECustomerKeyMD5
        {
            get { return this._sseCustomerKeyMD5; }
            set { this._sseCustomerKeyMD5 = value; }
        }

        // Check to see if SSECustomerKeyMD5 property is set
        internal bool IsSetSSECustomerKeyMD5()
        {
            return !string.IsNullOrEmpty(this._sseCustomerKeyMD5);
        }

        /// <summary>
        /// Gets and sets the property SSEKMSKeyId. 
        /// <para>
        ///  If present, specifies the ID (Key ID, Key ARN, or Key Alias) of the Amazon Web Services
        /// Key Management Service (Amazon Web Services KMS) symmetric encryption customer managed
        /// key that was used for stored in Amazon S3 object. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string SSEKMSKeyId
        {
            get { return this._ssekmsKeyId; }
            set { this._ssekmsKeyId = value; }
        }

        // Check to see if SSEKMSKeyId property is set
        internal bool IsSetSSEKMSKeyId()
        {
            return !string.IsNullOrEmpty(this._ssekmsKeyId);
        }

        /// <summary>
        /// Gets and sets the property StatusCode. 
        /// <para>
        /// The integer status code for an HTTP response of a corresponding <c>GetObject</c> request.
        /// The following is a list of status codes.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>200 - OK</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>206 - Partial Content</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>304 - Not Modified</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>400 - Bad Request</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>401 - Unauthorized</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>403 - Forbidden</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>404 - Not Found</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>405 - Method Not Allowed</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>409 - Conflict</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>411 - Length Required</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>412 - Precondition Failed</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>416 - Range Not Satisfiable</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>500 - Internal Server Error</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>503 - Service Unavailable</c> 
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public int? StatusCode
        {
            get { return this._statusCode; }
            set { this._statusCode = value; }
        }

        // Check to see if StatusCode property is set
        internal bool IsSetStatusCode()
        {
            return this._statusCode.HasValue; 
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
        /// </summary>
        public S3StorageClass StorageClass
        {
            get { return this._storageClass; }
            set { this._storageClass = value; }
        }

        // Check to see if StorageClass property is set
        internal bool IsSetStorageClass()
        {
            return this._storageClass != null;
        }

        /// <summary>
        /// Gets and sets the property TagCount. 
        /// <para>
        /// The number of tags, if any, on the object.
        /// </para>
        /// </summary>
        public int? TagCount
        {
            get { return this._tagCount; }
            set { this._tagCount = value; }
        }

        // Check to see if TagCount property is set
        internal bool IsSetTagCount()
        {
            return this._tagCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property VersionId. 
        /// <para>
        /// An ID used to reference a specific version of the object.
        /// </para>
        /// </summary>
        public string VersionId
        {
            get { return this._versionId; }
            set { this._versionId = value; }
        }

        // Check to see if VersionId property is set
        internal bool IsSetVersionId()
        {
            return !string.IsNullOrEmpty(this._versionId);
        }

    }
}