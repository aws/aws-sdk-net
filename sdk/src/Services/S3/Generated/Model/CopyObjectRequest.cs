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
    /// Container for the parameters to the CopyObject operation.
    /// Creates a copy of an object that is already stored in Amazon S3.
    /// 
    ///  <important> 
    /// <para>
    /// End of support notice: As of October 1, 2025, Amazon S3 has discontinued support for
    /// Email Grantee Access Control Lists (ACLs). If you attempt to use an Email Grantee
    /// ACL in a request after October 1, 2025, the request will receive an <c>HTTP 405</c>
    /// (Method Not Allowed) error.
    /// </para>
    ///  
    /// <para>
    /// This change affects the following Amazon Web Services Regions: US East (N. Virginia),
    /// US West (N. California), US West (Oregon), Asia Pacific (Singapore), Asia Pacific
    /// (Sydney), Asia Pacific (Tokyo), Europe (Ireland), and South America (São Paulo).
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// You can store individual objects of up to 50 TB in Amazon S3. You create a copy of
    /// your object up to 5 GB in size in a single atomic action using this API. However,
    /// to copy an object greater than 5 GB, you must use the multipart upload Upload Part
    /// - Copy (UploadPartCopy) API. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/CopyingObjctsUsingRESTMPUapi.html">Copy
    /// Object Using the REST Multipart Upload API</a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// You can copy individual objects between general purpose buckets, between directory
    /// buckets, and between general purpose buckets and directory buckets.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    /// Amazon S3 supports copy operations using Multi-Region Access Points only as a destination
    /// when using the Multi-Region Access Point ARN. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory buckets </b> - For directory buckets, you must make requests for this
    /// API operation to the Zonal endpoint. These endpoints support virtual-hosted-style
    /// requests in the format <c>https://<i>amzn-s3-demo-bucket</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com/<i>key-name</i>
    /// </c>. Path-style requests are not supported. For more information about endpoints
    /// in Availability Zones, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/endpoint-directory-buckets-AZ.html">Regional
    /// and Zonal endpoints for directory buckets in Availability Zones</a> in the <i>Amazon
    /// S3 User Guide</i>. For more information about endpoints in Local Zones, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-lzs-for-directory-buckets.html">Concepts
    /// for directory buckets in Local Zones</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// VPC endpoints don't support cross-Region requests (including copies). If you're using
    /// VPC endpoints, your source and destination buckets should be in the same Amazon Web
    /// Services Region as your VPC endpoint.
    /// </para>
    ///  </li> </ul> </note> 
    /// <para>
    /// Both the Region that you want to copy the object from and the Region that you want
    /// to copy the object to must be enabled for your account. For more information about
    /// how to enable a Region for your account, see <a href="https://docs.aws.amazon.com/accounts/latest/reference/manage-acct-regions.html#manage-acct-regions-enable-standalone">Enable
    /// or disable a Region for standalone accounts</a> in the <i>Amazon Web Services Account
    /// Management Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// Amazon S3 transfer acceleration does not support cross-Region copies. If you request
    /// a cross-Region copy using a transfer acceleration endpoint, you get a <c>400 Bad Request</c>
    /// error. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/transfer-acceleration.html">Transfer
    /// Acceleration</a>.
    /// </para>
    ///  </important> <dl> <dt>Authentication and authorization</dt> <dd> 
    /// <para>
    /// All <c>CopyObject</c> requests must be authenticated and signed by using IAM credentials
    /// (access key ID and secret access key for the IAM identities). All headers with the
    /// <c>x-amz-</c> prefix, including <c>x-amz-copy-source</c>, must be signed. For more
    /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/RESTAuthentication.html">REST
    /// Authentication</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Directory buckets</b> - You must use the IAM credentials to authenticate and authorize
    /// your access to the <c>CopyObject</c> API operation, instead of using the temporary
    /// security credentials through the <c>CreateSession</c> API operation.
    /// </para>
    ///  
    /// <para>
    /// Amazon Web Services CLI or SDKs handles authentication and authorization on your behalf.
    /// </para>
    ///  </dd> <dt>Permissions</dt> <dd> 
    /// <para>
    /// You must have <i>read</i> access to the source object and <i>write</i> access to the
    /// destination bucket.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - You must have permissions in an IAM policy
    /// based on the source and destination bucket types in a <c>CopyObject</c> operation.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the source object is in a general purpose bucket, you must have <b> <c>s3:GetObject</c>
    /// </b> permission to read the source object that is being copied. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the destination bucket is a general purpose bucket, you must have <b> <c>s3:PutObject</c>
    /// </b> permission to write the object copy to the destination bucket. 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Directory bucket permissions</b> - You must have permissions in a bucket policy
    /// or an IAM identity-based policy based on the source and destination bucket types in
    /// a <c>CopyObject</c> operation.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the source object that you want to copy is in a directory bucket, you must have
    /// the <b> <c>s3express:CreateSession</c> </b> permission in the <c>Action</c> element
    /// of a policy to read the object. By default, the session is in the <c>ReadWrite</c>
    /// mode. If you want to restrict the access, you can explicitly set the <c>s3express:SessionMode</c>
    /// condition key to <c>ReadOnly</c> on the copy source bucket.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the copy destination is a directory bucket, you must have the <b> <c>s3express:CreateSession</c>
    /// </b> permission in the <c>Action</c> element of a policy to write the object to the
    /// destination. The <c>s3express:SessionMode</c> condition key can't be set to <c>ReadOnly</c>
    /// on the copy destination bucket. 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// If the object is encrypted with SSE-KMS, you must also have the <c>kms:GenerateDataKey</c>
    /// and <c>kms:Decrypt</c> permissions in IAM identity-based policies and KMS key policies
    /// for the KMS key.
    /// </para>
    ///  
    /// <para>
    /// For example policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-security-iam-example-bucket-policies.html">Example
    /// bucket policies for S3 Express One Zone</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-security-iam-identity-policies.html">Amazon
    /// Web Services Identity and Access Management (IAM) identity-based policies for S3 Express
    /// One Zone</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> </ul> </dd> <dt>Response and special errors</dt> <dd> 
    /// <para>
    /// When the request is an HTTP 1.1 request, the response is chunk encoded. When the request
    /// is not an HTTP 1.1 request, the response would not contain the <c>Content-Length</c>.
    /// You always need to read the entire response body to check if the copy succeeds. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the copy is successful, you receive a response with information about the copied
    /// object.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A copy request might return an error when Amazon S3 receives the copy request or while
    /// Amazon S3 is copying the files. A <c>200 OK</c> response can contain either a success
    /// or an error.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// If the error occurs before the copy action starts, you receive a standard Amazon S3
    /// error.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If the error occurs during the copy operation, the error response is embedded in the
    /// <c>200 OK</c> response. For example, in a cross-region copy, you may encounter throttling
    /// and receive a <c>200 OK</c> response. For more information, see <a href="https://repost.aws/knowledge-center/s3-resolve-200-internalerror">Resolve
    /// the Error 200 response when copying objects to Amazon S3</a>. The <c>200 OK</c> status
    /// code means the copy was accepted, but it doesn't mean the copy is complete. Another
    /// example is when you disconnect from Amazon S3 before the copy is complete, Amazon
    /// S3 might cancel the copy and you may receive a <c>200 OK</c> response. You must stay
    /// connected to Amazon S3 until the entire response is successfully received and processed.
    /// </para>
    ///  
    /// <para>
    /// If you call this API operation directly, make sure to design your application to parse
    /// the content of the response and handle it appropriately. If you use Amazon Web Services
    /// SDKs, SDKs handle this condition. The SDKs detect the embedded error and apply error
    /// handling per your configuration settings (including automatically retrying the request
    /// as appropriate). If the condition persists, the SDKs throw an exception (or, for the
    /// SDKs that don't use exceptions, they return an error).
    /// </para>
    ///  </li> </ul> </li> </ul> </dd> <dt>Charge</dt> <dd> 
    /// <para>
    /// The copy request charge is based on the storage class and Region that you specify
    /// for the destination object. The request can also result in a data retrieval charge
    /// for the source if the source storage class bills for data retrieval. If the copy source
    /// is in a different region, the data transfer is billed to the copy source account.
    /// For pricing information, see <a href="http://aws.amazon.com/s3/pricing/">Amazon S3
    /// pricing</a>.
    /// </para>
    ///  </dd> <dt>HTTP Host header syntax</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c> <i>Bucket-name</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Amazon S3 on Outposts</b> - When you use this action with S3 on Outposts through
    /// the REST API, you must direct requests to the S3 on Outposts hostname. The S3 on Outposts
    /// hostname takes the form <c> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</c>.
    /// The hostname isn't required when you use the Amazon Web Services CLI or SDKs.
    /// </para>
    ///  </li> </ul> </dd> </dl> 
    /// <para>
    /// The following operations are related to <c>CopyObject</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutObject.html">PutObject</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetObject.html">GetObject</a>
    /// 
    /// </para>
    ///  </li> </ul> <important> 
    /// <para>
    /// You must URL encode any signed header values that contain spaces. For example, if
    /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
    /// must URL encode this value to <c>my%20%20file.txt</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class CopyObjectRequest : PutWithACLRequest
    {
        private bool? _bucketKeyEnabled;
        private string _cacheControl;
        private S3CannedACL _cannedACL;
        private ChecksumAlgorithm _checksumAlgorithm;
        private string _contentDisposition;
        private string _contentEncoding;
        private string _contentLanguage;
        
        private ServerSideEncryptionCustomerMethod _copySourceServerSideEncryptionCustomerMethod;
        private string _copySourceServerSideEncryptionCustomerProvidedKey;
        private string _copySourceServerSideEncryptionCustomerProvidedKeyMD5;
        private string _destinationBucket;
        private string _destinationKey;
        private string _eTagToMatch;
        private string _eTagToNotMatch;
        private string _expectedBucketOwner;
        private string _expectedSourceBucketOwner;
        private string _expires;
        private string _grantFullControl;
        private string _grantRead;
        private string _grantReadACP;
        private string _grantWriteACP;
        private HeadersCollection _headers = AWSConfigs.InitializeCollections ? new HeadersCollection() : null;
        private string _ifMatch;
        private string _ifNoneMatch;
        private MetadataCollection _metadata = AWSConfigs.InitializeCollections ? new MetadataCollection() : null;
        private S3MetadataDirective _metadataDirective;
        private DateTime? _modifiedSinceDate;
        private ObjectLockLegalHoldStatus _objectLockLegalHoldStatus;
        private ObjectLockMode _objectLockMode;
        private DateTime? _objectLockRetainUntilDate;
        private RequestPayer _requestPayer;
        private ServerSideEncryptionCustomerMethod _serverSideEncryptionCustomerMethod;
        private string _serverSideEncryptionCustomerProvidedKey;
        private string _serverSideEncryptionCustomerProvidedKeyMD5;
        private string _serverSideEncryptionKeyManagementServiceEncryptionContext;
        private string _serverSideEncryptionKeyManagementServiceKeyId;
        private ServerSideEncryptionMethod _serverSideEncryptionMethod;
        private string _sourceBucket;
        private string _sourceKey;
        private string _sourceVersionId;
        private S3StorageClass _storageClass;
        private TaggingDirective _taggingDirective;
        private List<Tag> _tagSet = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private DateTime? _unmodifiedSinceDate;
        private string _websiteRedirectLocation;

        /// <summary>
        /// Gets and sets the property BucketKeyEnabled. 
        /// <para>
        /// Specifies whether Amazon S3 should use an S3 Bucket Key for object encryption with
        /// server-side encryption using Key Management Service (KMS) keys (SSE-KMS). If a target
        /// object uses SSE-KMS, you can enable an S3 Bucket Key for the object.
        /// </para>
        ///  
        /// <para>
        /// Setting this header to <c>true</c> causes Amazon S3 to use an S3 Bucket Key for object
        /// encryption with SSE-KMS. Specifying this header with a COPY action doesn’t affect
        /// bucket-level settings for S3 Bucket Key.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/bucket-key.html">Amazon
        /// S3 Bucket Keys</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets</b> - S3 Bucket Keys aren't supported, when you copy SSE-KMS
        /// encrypted objects from general purpose buckets to directory buckets, from directory
        /// buckets to general purpose buckets, or between directory buckets, through <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CopyObject.html">CopyObject</a>.
        /// In this case, Amazon S3 makes a call to KMS every time a copy request is made for
        /// a KMS-encrypted object.
        /// </para>
        ///  </note>
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
        /// Specifies the caching behavior along the request/reply chain.
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
        /// Gets and sets the property CannedACL. 
        /// <para>
        /// The canned access control list (ACL) to apply to the object.
        /// </para>
        ///  
        /// <para>
        /// When you copy an object, the ACL metadata is not preserved and is set to <c>private</c>
        /// by default. Only the owner has full access control. To override the default ACL setting,
        /// specify a new ACL when you generate a copy request. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Using
        /// ACLs</a>. 
        /// </para>
        ///  
        /// <para>
        /// If the destination bucket that you're copying objects to uses the bucket owner enforced
        /// setting for S3 Object Ownership, ACLs are disabled and no longer affect permissions.
        /// Buckets that use this setting only accept <c>PUT</c> requests that don't specify an
        /// ACL or <c>PUT</c> requests that specify bucket owner full control ACLs, such as the
        /// <c>bucket-owner-full-control</c> canned ACL or an equivalent form of this ACL expressed
        /// in the XML format. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/about-object-ownership.html">Controlling
        /// ownership of objects and disabling ACLs</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// If your destination bucket uses the bucket owner enforced setting for Object Ownership,
        /// all objects written to the bucket by any account will be owned by the bucket owner.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This functionality is not supported for Amazon S3 on Outposts.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        public S3CannedACL CannedACL
        {
            get { return this._cannedACL; }
            set { this._cannedACL = value; }
        }

        // Check to see if CannedACL property is set
        internal bool IsSetCannedACL()
        {
            return _cannedACL != null && _cannedACL != S3CannedACL.NoACL;
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm that you want Amazon S3 to use to create the checksum for
        /// the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you copy an object, if the source object has a checksum, that checksum value
        /// will be copied to the new object by default. If the <c>CopyObject</c> request does
        /// not include this <c>x-amz-checksum-algorithm</c> header, the checksum algorithm will
        /// be copied from the source object to the destination object (if it's present on the
        /// source object). You can optionally specify a different checksum algorithm to use with
        /// the <c>x-amz-checksum-algorithm</c> header. Unrecognized or unsupported values will
        /// respond with the HTTP status code <c>400 Bad Request</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// For directory buckets, when you use Amazon Web Services SDKs, <c>CRC32</c> is the
        /// default checksum algorithm that's used for performance.
        /// </para>
        ///  </note>
        /// </summary>
        public ChecksumAlgorithm ChecksumAlgorithm
        {
            get { return this._checksumAlgorithm; }
            set { this._checksumAlgorithm = value; }
        }

        // Check to see if ChecksumAlgorithm property is set
        internal bool IsSetChecksumAlgorithm()
        {
            return this._checksumAlgorithm != null;
        }

        /// <summary>
        /// Gets and sets the property ContentDisposition. 
        /// <para>
        /// Specifies presentational information for the object. Indicates whether an object should
        /// be displayed in a web browser or downloaded as a file. It allows specifying the desired
        /// filename for the downloaded file.
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
        ///  <note> 
        /// <para>
        /// For directory buckets, only the <c>aws-chunked</c> value is supported in this header
        /// field.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property ContentType. 
        /// <para>
        /// A standard MIME type that describes the format of the object data.
        /// </para>
        /// </summary>
        public string ContentType
        {
            get { return this.Headers.ContentType; }
            set { this.Headers.ContentType = value; }
        }

        /// <summary>
        /// Gets and sets the property CopySourceServerSideEncryptionCustomerMethod. 
        /// <para>
        /// Specifies the algorithm to use when decrypting the source object (for example, <c>AES256</c>).
        /// </para>
        ///  
        /// <para>
        /// If the source object for the copy is stored in Amazon S3 using SSE-C, you must provide
        /// the necessary encryption information in your request so that Amazon S3 can decrypt
        /// the object for copying.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported when the source object is in a directory bucket.
        /// </para>
        ///  </note>
        /// </summary>
        public ServerSideEncryptionCustomerMethod CopySourceServerSideEncryptionCustomerMethod
        {
            get { return this._copySourceServerSideEncryptionCustomerMethod; }
            set { this._copySourceServerSideEncryptionCustomerMethod = value; }
        }

        // Check to see if CopySourceServerSideEncryptionCustomerMethod property is set
        internal bool IsSetCopySourceServerSideEncryptionCustomerMethod()
        {
            return this._copySourceServerSideEncryptionCustomerMethod != null && this._copySourceServerSideEncryptionCustomerMethod != ServerSideEncryptionCustomerMethod.None;
        }

        /// <summary>
        /// Gets and sets the property CopySourceServerSideEncryptionCustomerProvidedKey. 
        /// <para>
        /// Specifies the customer-provided encryption key for Amazon S3 to use to decrypt the
        /// source object. The encryption key provided in this header must be the same one that
        /// was used when the source object was created.
        /// </para>
        ///  
        /// <para>
        /// If the source object for the copy is stored in Amazon S3 using SSE-C, you must provide
        /// the necessary encryption information in your request so that Amazon S3 can decrypt
        /// the object for copying.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported when the source object is in a directory bucket.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string CopySourceServerSideEncryptionCustomerProvidedKey
        {
            get { return this._copySourceServerSideEncryptionCustomerProvidedKey; }
            set { this._copySourceServerSideEncryptionCustomerProvidedKey = value; }
        }

        // Check to see if CopySourceServerSideEncryptionCustomerProvidedKey property is set
        internal bool IsSetCopySourceServerSideEncryptionCustomerProvidedKey()
        {
            return !System.String.IsNullOrEmpty(this._copySourceServerSideEncryptionCustomerProvidedKey);
        }

        /// <summary>
        /// Gets and sets the property CopySourceServerSideEncryptionCustomerProvidedKeyMD5. 
        /// <para>
        /// Specifies the 128-bit MD5 digest of the encryption key according to RFC 1321. Amazon
        /// S3 uses this header for a message integrity check to ensure that the encryption key
        /// was transmitted without error.
        /// </para>
        ///  
        /// <para>
        /// If the source object for the copy is stored in Amazon S3 using SSE-C, you must provide
        /// the necessary encryption information in your request so that Amazon S3 can decrypt
        /// the object for copying.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported when the source object is in a directory bucket.
        /// </para>
        ///  </note>
        /// </summary>
        public string CopySourceServerSideEncryptionCustomerProvidedKeyMD5
        {
            get { return this._copySourceServerSideEncryptionCustomerProvidedKeyMD5; }
            set { this._copySourceServerSideEncryptionCustomerProvidedKeyMD5 = value; }
        }

        // Check to see if CopySourceServerSideEncryptionCustomerProvidedKeyMD5 property is set
        internal bool IsSetCopySourceServerSideEncryptionCustomerProvidedKeyMD5()
        {
            return !System.String.IsNullOrEmpty(this._copySourceServerSideEncryptionCustomerProvidedKeyMD5);
        }

        /// <summary>
        /// Gets and sets the property DestinationBucket. 
        /// <para>
        /// The name of the destination bucket.
        /// </para>
        ///  
        /// <para>
        ///  <b>Directory buckets</b> - When you use this operation with a directory bucket, you
        /// must use virtual-hosted-style requests in the format <c> <i>Bucket-name</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com</c>.
        /// Path-style requests are not supported. Directory bucket names must be unique in the
        /// chosen Zone (Availability Zone or Local Zone). Bucket names must follow the format
        /// <c> <i>bucket-base-name</i>--<i>zone-id</i>--x-s3</c> (for example, <c> <i>amzn-s3-demo-bucket</i>--<i>usw2-az1</i>--x-s3</c>).
        /// For information about bucket naming restrictions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-bucket-naming-rules.html">Directory
        /// bucket naming rules</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Copying objects across different Amazon Web Services Regions isn't supported when
        /// the source or destination bucket is in Amazon Web Services Local Zones. The source
        /// and destination buckets must have the same parent Amazon Web Services Region. Otherwise,
        /// you get an HTTP <c>400 Bad Request</c> error with the error code <c>InvalidRequest</c>.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>Access points</b> - When you use this action with an access point for general
        /// purpose buckets, you must provide the alias of the access point in place of the bucket
        /// name or specify the access point ARN. When you use this action with an access point
        /// for directory buckets, you must provide the access point name in place of the bucket
        /// name. When using the access point ARN, you must direct requests to the access point
        /// hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com.
        /// When using this action with an access point through the Amazon Web Services SDKs,
        /// you provide the access point ARN in place of the bucket name. For more information
        /// about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-access-points.html">Using
        /// access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Object Lambda access points are not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>S3 on Outposts</b> - When you use this action with S3 on Outposts, you must use
        /// the Outpost bucket access point ARN or the access point alias for the destination
        /// bucket. You can only copy objects within the same Outpost bucket. It's not supported
        /// to copy objects across different Amazon Web Services Outposts, between buckets on
        /// the same Outposts, or between Outposts buckets and any other bucket types. For more
        /// information about S3 on Outposts, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">What
        /// is S3 on Outposts?</a> in the <i>S3 on Outposts guide</i>. When you use this action
        /// with S3 on Outposts through the REST API, you must direct requests to the S3 on Outposts
        /// hostname, in the format <c> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</c>.
        /// The hostname isn't required when you use the Amazon Web Services CLI or SDKs. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DestinationBucket
        {
            get { return this._destinationBucket; }
            set { this._destinationBucket = value; }
        }

        // Check to see if DestinationBucket property is set
        internal bool IsSetDestinationBucket()
        {
            return !System.String.IsNullOrEmpty(this._destinationBucket);
        }

        /// <summary>
        /// Gets and sets the property DestinationKey.
        /// </summary>
        [AWSProperty(Min=1)]
        public string DestinationKey
        {
            get { return this._destinationKey; }
            set { this._destinationKey = value; }
        }

        // Check to see if DestinationKey property is set
        internal bool IsSetDestinationKey()
        {
            return !System.String.IsNullOrEmpty(this._destinationKey);
        }

        /// <summary>
        /// Gets and sets the property ETagToMatch. 
        /// <para>
        /// Copies the object if its entity tag (ETag) matches the specified tag.
        /// </para>
        ///  
        /// <para>
        ///  If both the <c>x-amz-copy-source-if-match</c> and <c>x-amz-copy-source-if-unmodified-since</c>
        /// headers are present in the request and evaluate as follows, Amazon S3 returns <c>200
        /// OK</c> and copies the data:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>x-amz-copy-source-if-match</c> condition evaluates to true
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>x-amz-copy-source-if-unmodified-since</c> condition evaluates to false
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ETagToMatch
        {
            get { return this._eTagToMatch; }
            set { this._eTagToMatch = value; }
        }

        // Check to see if ETagToMatch property is set
        internal bool IsSetETagToMatch()
        {
            return !System.String.IsNullOrEmpty(this._eTagToMatch);
        }

        /// <summary>
        /// Gets and sets the property ETagToNotMatch. 
        /// <para>
        /// Copies the object if its entity tag (ETag) is different than the specified ETag.
        /// </para>
        ///  
        /// <para>
        /// If both the <c>x-amz-copy-source-if-none-match</c> and <c>x-amz-copy-source-if-modified-since</c>
        /// headers are present in the request and evaluate as follows, Amazon S3 returns the
        /// <c>412 Precondition Failed</c> response code:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>x-amz-copy-source-if-none-match</c> condition evaluates to false
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>x-amz-copy-source-if-modified-since</c> condition evaluates to true
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public string ETagToNotMatch
        {
            get { return this._eTagToNotMatch; }
            set { this._eTagToNotMatch = value; }
        }

        // Check to see if ETagToNotMatch property is set
        internal bool IsSetETagToNotMatch()
        {
            return !System.String.IsNullOrEmpty(this._eTagToNotMatch);
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected destination bucket owner. If the account ID that you
        /// provide does not match the actual owner of the destination bucket, the request fails
        /// with the HTTP status code <c>403 Forbidden</c> (access denied).
        /// </para>
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this._expectedBucketOwner; }
            set { this._expectedBucketOwner = value; }
        }

        // Check to see if ExpectedBucketOwner property is set
        internal bool IsSetExpectedBucketOwner()
        {
            return !System.String.IsNullOrEmpty(this._expectedBucketOwner);
        }

        /// <summary>
        /// Gets and sets the property ExpectedSourceBucketOwner. 
        /// <para>
        /// The account ID of the expected source bucket owner. If the account ID that you provide
        /// does not match the actual owner of the source bucket, the request fails with the HTTP
        /// status code <c>403 Forbidden</c> (access denied).
        /// </para>
        /// </summary>
        public string ExpectedSourceBucketOwner
        {
            get { return this._expectedSourceBucketOwner; }
            set { this._expectedSourceBucketOwner = value; }
        }

        // Check to see if ExpectedSourceBucketOwner property is set
        internal bool IsSetExpectedSourceBucketOwner()
        {
            return !System.String.IsNullOrEmpty(this._expectedSourceBucketOwner);
        }

        /// <summary>
        /// Gets and sets the property Expires. 
        /// <para>
        /// The date and time at which the object is no longer cacheable.
        /// </para>
        /// </summary>
        public string Expires
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
        /// Gets and sets the property GrantFullControl. 
        /// <para>
        /// Gives the grantee READ, READ_ACP, and WRITE_ACP permissions on the object.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This functionality is not supported for Amazon S3 on Outposts.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        public string GrantFullControl
        {
            get { return this._grantFullControl; }
            set { this._grantFullControl = value; }
        }

        // Check to see if GrantFullControl property is set
        internal bool IsSetGrantFullControl()
        {
            return this._grantFullControl != null;
        }

        /// <summary>
        /// Gets and sets the property GrantRead. 
        /// <para>
        /// Allows grantee to read the object data and its metadata.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This functionality is not supported for Amazon S3 on Outposts.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        public string GrantRead
        {
            get { return this._grantRead; }
            set { this._grantRead = value; }
        }

        // Check to see if GrantRead property is set
        internal bool IsSetGrantRead()
        {
            return this._grantRead != null;
        }

        /// <summary>
        /// Gets and sets the property GrantReadACP. 
        /// <para>
        /// Allows grantee to read the object ACL.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This functionality is not supported for Amazon S3 on Outposts.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        public string GrantReadACP
        {
            get { return this._grantReadACP; }
            set { this._grantReadACP = value; }
        }

        // Check to see if GrantReadACP property is set
        internal bool IsSetGrantReadACP()
        {
            return this._grantReadACP != null;
        }

        /// <summary>
        /// Gets and sets the property GrantWriteACP. 
        /// <para>
        /// Allows grantee to write the ACL for the applicable object.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// This functionality is not supported for Amazon S3 on Outposts.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        public string GrantWriteACP
        {
            get { return this._grantWriteACP; }
            set { this._grantWriteACP = value; }
        }

        // Check to see if GrantWriteACP property is set
        internal bool IsSetGrantWriteACP()
        {
            return this._grantWriteACP != null;
        }

        /// <summary>
        /// Gets and sets the property Headers.
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public HeadersCollection Headers
        {
            get {
                if (this._headers == null) this._headers = new HeadersCollection();
                return this._headers;
            }
            set { this._headers = value; }
        }

        /// <summary>
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// Copies the object if the entity tag (ETag) of the destination object matches the specified
        /// tag. If the ETag values do not match, the operation returns a <c>412 Precondition
        /// Failed</c> error. If a concurrent operation occurs during the upload S3 returns a
        /// <c>409 ConditionalRequestConflict</c> response. On a 409 failure you should fetch
        /// the object's ETag and retry the upload.
        /// </para>
        ///  
        /// <para>
        /// Expects the ETag value as a string.
        /// </para>
        ///  
        /// <para>
        /// For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC
        /// 7232</a>.
        /// </para>
        /// </summary>
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }

        // Check to see if IfMatch property is set
        internal bool IsSetIfMatch()
        {
            return this._ifMatch != null;
        }

        /// <summary>
        /// Gets and sets the property IfNoneMatch. 
        /// <para>
        /// Copies the object only if the object key name at the destination does not already
        /// exist in the bucket specified. Otherwise, Amazon S3 returns a <c>412 Precondition
        /// Failed</c> error. If a concurrent operation occurs during the upload S3 returns a
        /// <c>409 ConditionalRequestConflict</c> response. On a 409 failure you should retry
        /// the upload.
        /// </para>
        ///  
        /// <para>
        /// Expects the '*' (asterisk) character.
        /// </para>
        ///  
        /// <para>
        /// For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC
        /// 7232</a>.
        /// </para>
        /// </summary>
        public string IfNoneMatch
        {
            get { return this._ifNoneMatch; }
            set { this._ifNoneMatch = value; }
        }

        // Check to see if IfNoneMatch property is set
        internal bool IsSetIfNoneMatch()
        {
            return this._ifNoneMatch != null;
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
            set { this._metadata = value; }
        }

        // Check to see if Metadata property is set
        internal bool IsSetMetadata()
        {
            return this._metadata != null && (this._metadata.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property MetadataDirective. 
        /// <para>
        /// Specifies whether the metadata is copied from the source object or replaced with metadata
        /// that's provided in the request. When copying an object, you can preserve all metadata
        /// (the default) or specify new metadata. If this header isn’t specified, <c>COPY</c>
        /// is the default behavior. 
        /// </para>
        ///  
        /// <para>
        ///  <b>General purpose bucket</b> - For general purpose buckets, when you grant permissions,
        /// you can use the <c>s3:x-amz-metadata-directive</c> condition key to enforce certain
        /// metadata behavior when objects are uploaded. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/amazon-s3-policy-keys.html">Amazon
        /// S3 condition key examples</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <c>x-amz-website-redirect-location</c> is unique to each object and is not copied
        /// when using the <c>x-amz-metadata-directive</c> header. To copy the value, you must
        /// specify <c>x-amz-website-redirect-location</c> in the request header.
        /// </para>
        ///  </note>
        /// </summary>
        public S3MetadataDirective MetadataDirective
        {
            get { return this._metadataDirective; }
            set { this._metadataDirective = value; }
        }

        /// <summary>
        /// Gets and sets the property ModifiedSinceDate. 
        /// <para>
        /// Copies the object if it has been modified since the specified time.
        /// </para>
        ///  
        /// <para>
        /// If both the <c>x-amz-copy-source-if-none-match</c> and <c>x-amz-copy-source-if-modified-since</c>
        /// headers are present in the request and evaluate as follows, Amazon S3 returns the
        /// <c>412 Precondition Failed</c> response code:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>x-amz-copy-source-if-none-match</c> condition evaluates to false
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>x-amz-copy-source-if-modified-since</c> condition evaluates to true
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateTime? ModifiedSinceDate
        {
            get { return this._modifiedSinceDate ?? DateTime.SpecifyKind(default, DateTimeKind.Utc); }
            set { this._modifiedSinceDate = value; }
        }

        // Check to see if ModifiedSinceDate property is set
        internal bool IsSetModifiedSinceDate()
        {
            return this._modifiedSinceDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ObjectLockLegalHoldStatus. 
        /// <para>
        /// Specifies whether you want to apply a legal hold to the object copy.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
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
        /// The Object Lock mode that you want to apply to the object copy.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
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
        /// The date and time when you want the Object Lock of the object copy to expire.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property RequestPayer.
        /// </summary>
        public RequestPayer RequestPayer
        {
            get { return this._requestPayer; }
            set { this._requestPayer = value; }
        }

        // Check to see if RequestPayer property is set
        internal bool IsSetRequestPayer()
        {
            return this._requestPayer != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionCustomerMethod. 
        /// <para>
        /// Specifies the algorithm to use when encrypting the object (for example, <c>AES256</c>).
        /// </para>
        ///  
        /// <para>
        /// When you perform a <c>CopyObject</c> operation, if you want to use a different type
        /// of encryption setting for the target object, you can specify appropriate encryption-related
        /// headers to encrypt the target object with an Amazon S3 managed key, a KMS key, or
        /// a customer-provided key. If the encryption setting in your request is different from
        /// the default encryption configuration of the destination bucket, the encryption setting
        /// in your request takes precedence. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported when the destination bucket is a directory bucket.
        /// </para>
        ///  </note>
        /// </summary>
        public ServerSideEncryptionCustomerMethod ServerSideEncryptionCustomerMethod
        {
            get { return this._serverSideEncryptionCustomerMethod; }
            set { this._serverSideEncryptionCustomerMethod = value; }
        }

        // Check to see if ServerSideEncryptionCustomerMethod property is set
        internal bool IsSetServerSideEncryptionCustomerMethod()
        {
            return this._serverSideEncryptionCustomerMethod != null && this._serverSideEncryptionCustomerMethod != ServerSideEncryptionCustomerMethod.None;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionCustomerProvidedKey. 
        /// <para>
        /// Specifies the customer-provided encryption key for Amazon S3 to use in encrypting
        /// data. This value is used to store the object and then it is discarded. Amazon S3 does
        /// not store the encryption key. The key must be appropriate for use with the algorithm
        /// specified in the <c>x-amz-server-side-encryption-customer-algorithm</c> header.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported when the destination bucket is a directory bucket.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ServerSideEncryptionCustomerProvidedKey
        {
            get { return this._serverSideEncryptionCustomerProvidedKey; }
            set { this._serverSideEncryptionCustomerProvidedKey = value; }
        }

        // Check to see if ServerSideEncryptionCustomerProvidedKey property is set
        internal bool IsSetServerSideEncryptionCustomerProvidedKey()
        {
            return !System.String.IsNullOrEmpty(this._serverSideEncryptionCustomerProvidedKey);
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionCustomerProvidedKeyMD5. 
        /// <para>
        /// Specifies the 128-bit MD5 digest of the encryption key according to RFC 1321. Amazon
        /// S3 uses this header for a message integrity check to ensure that the encryption key
        /// was transmitted without error.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported when the destination bucket is a directory bucket.
        /// </para>
        ///  </note>
        /// </summary>
        public string ServerSideEncryptionCustomerProvidedKeyMD5
        {
            get { return this._serverSideEncryptionCustomerProvidedKeyMD5; }
            set { this._serverSideEncryptionCustomerProvidedKeyMD5 = value; }
        }

        // Check to see if ServerSideEncryptionCustomerProvidedKeyMD5 property is set
        internal bool IsSetServerSideEncryptionCustomerProvidedKeyMD5()
        {
            return !System.String.IsNullOrEmpty(this._serverSideEncryptionCustomerProvidedKeyMD5);
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionKeyManagementServiceEncryptionContext.
        /// 
        /// <para>
        /// Specifies the Amazon Web Services KMS Encryption Context as an additional encryption
        /// context to use for the destination object encryption. The value of this header is
        /// a base64-encoded UTF-8 string holding JSON with the encryption context key-value pairs.
        /// </para>
        ///  
        /// <para>
        ///  <b>General purpose buckets</b> - This value must be explicitly added to specify encryption
        /// context for <c>CopyObject</c> requests if you want an additional encryption context
        /// for your destination object. The additional encryption context of the source object
        /// won't be copied to the destination object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/UsingKMSEncryption.html#encryption-context">Encryption
        /// context</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Directory buckets</b> - You can optionally provide an explicit encryption context
        /// value. The value must match the default encryption context - the bucket Amazon Resource
        /// Name (ARN). An additional encryption context value is not supported. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ServerSideEncryptionKeyManagementServiceEncryptionContext
        {
            get { return this._serverSideEncryptionKeyManagementServiceEncryptionContext; }
            set { this._serverSideEncryptionKeyManagementServiceEncryptionContext = value; }
        }

        // Check to see if ServerSideEncryptionKeyManagementServiceEncryptionContext property is set
        internal bool IsSetServerSideEncryptionKeyManagementServiceEncryptionContext()
        {
            return !System.String.IsNullOrEmpty(this._serverSideEncryptionKeyManagementServiceEncryptionContext);
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionKeyManagementServiceKeyId. 
        /// <para>
        /// Specifies the KMS key ID (Key ID, Key ARN, or Key Alias) to use for object encryption.
        /// All GET and PUT requests for an object protected by KMS will fail if they're not made
        /// via SSL or using SigV4. For information about configuring any of the officially supported
        /// Amazon Web Services SDKs and Amazon Web Services CLI, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingAWSSDK.html#specify-signature-version">Specifying
        /// the Signature Version in Request Authentication</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Directory buckets</b> - To encrypt data using SSE-KMS, it's recommended to specify
        /// the <c>x-amz-server-side-encryption</c> header to <c>aws:kms</c>. Then, the <c>x-amz-server-side-encryption-aws-kms-key-id</c>
        /// header implicitly uses the bucket's default KMS customer managed key ID. If you want
        /// to explicitly set the <c> x-amz-server-side-encryption-aws-kms-key-id</c> header,
        /// it must match the bucket's default customer managed key (using key ID or ARN, not
        /// alias). Your SSE-KMS configuration can only support 1 <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer
        /// managed key</a> per directory bucket's lifetime. The <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon
        /// Web Services managed key</a> (<c>aws/s3</c>) isn't supported. Incorrect key specification
        /// results in an HTTP <c>400 Bad Request</c> error. 
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
            return !System.String.IsNullOrEmpty(this._serverSideEncryptionKeyManagementServiceKeyId);
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionMethod. 
        /// <para>
        /// The server-side encryption algorithm used when storing this object in Amazon S3. Unrecognized
        /// or unsupported values won’t write a destination object and will receive a <c>400 Bad
        /// Request</c> response. 
        /// </para>
        ///  
        /// <para>
        /// Amazon S3 automatically encrypts all new objects that are copied to an S3 bucket.
        /// When copying an object, if you don't specify encryption information in your copy request,
        /// the encryption setting of the target object is set to the default encryption configuration
        /// of the destination bucket. By default, all buckets have a base level of encryption
        /// configuration that uses server-side encryption with Amazon S3 managed keys (SSE-S3).
        /// If the destination bucket has a different default encryption configuration, Amazon
        /// S3 uses the corresponding encryption key to encrypt the target object copy.
        /// </para>
        ///  
        /// <para>
        /// With server-side encryption, Amazon S3 encrypts your data as it writes your data to
        /// disks in its data centers and decrypts the data when you access it. For more information
        /// about server-side encryption, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/serv-side-encryption.html">Using
        /// Server-Side Encryption</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>General purpose buckets </b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For general purpose buckets, there are the following supported options for server-side
        /// encryption: server-side encryption with Key Management Service (KMS) keys (SSE-KMS),
        /// dual-layer server-side encryption with Amazon Web Services KMS keys (DSSE-KMS), and
        /// server-side encryption with customer-provided encryption keys (SSE-C). Amazon S3 uses
        /// the corresponding KMS key, or a customer-provided key to encrypt the target object
        /// copy.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you perform a <c>CopyObject</c> operation, if you want to use a different type
        /// of encryption setting for the target object, you can specify appropriate encryption-related
        /// headers to encrypt the target object with an Amazon S3 managed key, a KMS key, or
        /// a customer-provided key. If the encryption setting in your request is different from
        /// the default encryption configuration of the destination bucket, the encryption setting
        /// in your request takes precedence. 
        /// </para>
        ///  </li> </ul> 
        /// <para>
        ///  <b>Directory buckets </b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// For directory buckets, there are only two supported options for server-side encryption:
        /// server-side encryption with Amazon S3 managed keys (SSE-S3) (<c>AES256</c>) and server-side
        /// encryption with KMS keys (SSE-KMS) (<c>aws:kms</c>). We recommend that the bucket's
        /// default encryption uses the desired encryption configuration and you don't override
        /// the bucket default encryption in your <c>CreateSession</c> requests or <c>PUT</c>
        /// object requests. Then, new objects are automatically encrypted with the desired encryption
        /// settings. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-serv-side-encryption.html">Protecting
        /// data with server-side encryption</a> in the <i>Amazon S3 User Guide</i>. For more
        /// information about the encryption overriding behaviors in directory buckets, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-specifying-kms-encryption.html">Specifying
        /// server-side encryption with KMS for new object uploads</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To encrypt new object copies to a directory bucket with SSE-KMS, we recommend you
        /// specify SSE-KMS as the directory bucket's default encryption configuration with a
        /// KMS key (specifically, a <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer
        /// managed key</a>). The <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon
        /// Web Services managed key</a> (<c>aws/s3</c>) isn't supported. Your SSE-KMS configuration
        /// can only support 1 <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer
        /// managed key</a> per directory bucket for the lifetime of the bucket. After you specify
        /// a customer managed key for SSE-KMS, you can't override the customer managed key for
        /// the bucket's SSE-KMS configuration. Then, when you perform a <c>CopyObject</c> operation
        /// and want to specify server-side encryption settings for new object copies with SSE-KMS
        /// in the encryption-related request headers, you must ensure the encryption key is the
        /// same customer managed key that you specified for the directory bucket's default encryption
        /// configuration. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>S3 access points for Amazon FSx </b> - When accessing data stored in Amazon FSx
        /// file systems using S3 access points, the only valid server side encryption option
        /// is <c>aws:fsx</c>. All Amazon FSx file systems have encryption configured by default
        /// and are encrypted at rest. Data is automatically encrypted before being written to
        /// the file system, and automatically decrypted as it is read. These processes are handled
        /// transparently by Amazon FSx.
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property SourceBucket.
        /// </summary>
        public string SourceBucket
        {
            get { return this._sourceBucket; }
            set { this._sourceBucket = value; }
        }

        // Check to see if SourceBucket property is set
        internal bool IsSetSourceBucket()
        {
            return !System.String.IsNullOrEmpty(this._sourceBucket);
        }

        /// <summary>
        /// Gets and sets the property SourceKey.
        /// </summary>
        [AWSProperty(Min=1)]
        public string SourceKey
        {
            get { return this._sourceKey; }
            set { this._sourceKey = value; }
        }

        // Check to see if SourceKey property is set
        internal bool IsSetSourceKey()
        {
            return !System.String.IsNullOrEmpty(this._sourceKey);
        }

        /// <summary>
        /// Gets and sets the property SourceVersionId.
        /// </summary>
        public string SourceVersionId
        {
            get { return this._sourceVersionId; }
            set { this._sourceVersionId = value; }
        }

        // Check to see if SourceVersionId property is set
        internal bool IsSetSourceVersionId()
        {
            return !System.String.IsNullOrEmpty(this._sourceVersionId);
        }

        /// <summary>
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// If the <c>x-amz-storage-class</c> header is not used, the copied object will be stored
        /// in the <c>STANDARD</c> Storage Class by default. The <c>STANDARD</c> storage class
        /// provides high durability and high availability. Depending on performance needs, you
        /// can specify a different Storage Class. 
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        ///  <b>Directory buckets </b> - Directory buckets only support <c>EXPRESS_ONEZONE</c>
        /// (the S3 Express One Zone storage class) in Availability Zones and <c>ONEZONE_IA</c>
        /// (the S3 One Zone-Infrequent Access storage class) in Dedicated Local Zones. Unsupported
        /// storage class values won't write a destination object and will respond with the HTTP
        /// status code <c>400 Bad Request</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Amazon S3 on Outposts </b> - S3 on Outposts only uses the <c>OUTPOSTS</c> Storage
        /// Class.
        /// </para>
        ///  </li> </ul> </note> 
        /// <para>
        /// You can use the <c>CopyObject</c> action to change the storage class of an object
        /// that is already stored in Amazon S3 by using the <c>x-amz-storage-class</c> header.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage-class-intro.html">Storage
        /// Classes</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Before using an object as a source object for the copy operation, you must restore
        /// a copy of it if it meets any of the following conditions:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The storage class of the source object is <c>GLACIER</c> or <c>DEEP_ARCHIVE</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The storage class of the source object is <c>INTELLIGENT_TIERING</c> and it's <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/intelligent-tiering-overview.html#intel-tiering-tier-definition">S3
        /// Intelligent-Tiering access tier</a> is <c>Archive Access</c> or <c>Deep Archive Access</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_RestoreObject.html">RestoreObject</a>
        /// and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/CopyingObjectsExamples.html">Copying
        /// Objects</a> in the <i>Amazon S3 User Guide</i>.
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
        /// Gets and sets the property TaggingDirective. 
        /// <para>
        /// Specifies whether the object tag-set is copied from the source object or replaced
        /// with the tag-set that's provided in the request.
        /// </para>
        ///  
        /// <para>
        /// The default value is <c>COPY</c>.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets</b> - For directory buckets in a <c>CopyObject</c> operation,
        /// only the empty tag-set is supported. Any requests that attempt to write non-empty
        /// tags into directory buckets will receive a <c>501 Not Implemented</c> status code.
        /// When the destination bucket is a directory bucket, you will receive a <c>501 Not Implemented</c>
        /// response in any of the following situations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When you attempt to <c>COPY</c> the tag-set from an S3 source object that has non-empty
        /// tags.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you attempt to <c>REPLACE</c> the tag-set of a source object and set a non-empty
        /// value to <c>x-amz-tagging</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you don't set the <c>x-amz-tagging-directive</c> header and the source object
        /// has non-empty tags. This is because the default value of <c>x-amz-tagging-directive</c>
        /// is <c>COPY</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Because only the empty tag-set is supported for directory buckets in a <c>CopyObject</c>
        /// operation, the following situations are allowed:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When you attempt to <c>COPY</c> the tag-set from a directory bucket source object
        /// that has no tags to a general purpose bucket. It copies an empty tag-set to the destination
        /// object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you attempt to <c>REPLACE</c> the tag-set of a directory bucket source object
        /// and set the <c>x-amz-tagging</c> value of the directory bucket destination object
        /// to empty.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you attempt to <c>REPLACE</c> the tag-set of a general purpose bucket source
        /// object that has non-empty tags and set the <c>x-amz-tagging</c> value of the directory
        /// bucket destination object to empty.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you attempt to <c>REPLACE</c> the tag-set of a directory bucket source object
        /// and don't set the <c>x-amz-tagging</c> value of the directory bucket destination object.
        /// This is because the default value of <c>x-amz-tagging</c> is the empty value.
        /// </para>
        ///  </li> </ul> </note>
        /// </summary>
        public TaggingDirective TaggingDirective
        {
            get { return this._taggingDirective; }
            set { this._taggingDirective = value; }
        }

        // Check to see if TaggingDirective property is set
        internal bool IsSetTaggingDirective()
        {
            return this._taggingDirective != null;
        }

        /// <summary>
        /// Gets and sets the property TagSet. 
        /// <para>
        /// The tag-set for the object copy in the destination bucket. This value must be used
        /// in conjunction with the <c>x-amz-tagging-directive</c> if you choose <c>REPLACE</c>
        /// for the <c>x-amz-tagging-directive</c>. If you choose <c>COPY</c> for the <c>x-amz-tagging-directive</c>,
        /// you don't need to set the <c>x-amz-tagging</c> header, because the tag-set will be
        /// copied from the source object directly. The tag-set must be encoded as URL Query parameters.
        /// </para>
        ///  
        /// <para>
        /// The default value is the empty value.
        /// </para>
        ///  <note> 
        /// <para>
        ///  <b>Directory buckets</b> - For directory buckets in a <c>CopyObject</c> operation,
        /// only the empty tag-set is supported. Any requests that attempt to write non-empty
        /// tags into directory buckets will receive a <c>501 Not Implemented</c> status code.
        /// When the destination bucket is a directory bucket, you will receive a <c>501 Not Implemented</c>
        /// response in any of the following situations:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When you attempt to <c>COPY</c> the tag-set from an S3 source object that has non-empty
        /// tags.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you attempt to <c>REPLACE</c> the tag-set of a source object and set a non-empty
        /// value to <c>x-amz-tagging</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you don't set the <c>x-amz-tagging-directive</c> header and the source object
        /// has non-empty tags. This is because the default value of <c>x-amz-tagging-directive</c>
        /// is <c>COPY</c>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Because only the empty tag-set is supported for directory buckets in a <c>CopyObject</c>
        /// operation, the following situations are allowed:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// When you attempt to <c>COPY</c> the tag-set from a directory bucket source object
        /// that has no tags to a general purpose bucket. It copies an empty tag-set to the destination
        /// object.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you attempt to <c>REPLACE</c> the tag-set of a directory bucket source object
        /// and set the <c>x-amz-tagging</c> value of the directory bucket destination object
        /// to empty.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you attempt to <c>REPLACE</c> the tag-set of a general purpose bucket source
        /// object that has non-empty tags and set the <c>x-amz-tagging</c> value of the directory
        /// bucket destination object to empty.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// When you attempt to <c>REPLACE</c> the tag-set of a directory bucket source object
        /// and don't set the <c>x-amz-tagging</c> value of the directory bucket destination object.
        /// This is because the default value of <c>x-amz-tagging</c> is the empty value.
        /// </para>
        ///  </li> </ul> </note>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> TagSet
        {
            get { return this._tagSet; }
            set { this._tagSet = value; }
        }

        // Check to see if TagSet property is set
        internal bool IsSetTagSet()
        {
            return this._tagSet != null && (this._tagSet.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property UnmodifiedSinceDate. 
        /// <para>
        /// Copies the object if it hasn't been modified since the specified time.
        /// </para>
        ///  
        /// <para>
        ///  If both the <c>x-amz-copy-source-if-match</c> and <c>x-amz-copy-source-if-unmodified-since</c>
        /// headers are present in the request and evaluate as follows, Amazon S3 returns <c>200
        /// OK</c> and copies the data:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>x-amz-copy-source-if-match</c> condition evaluates to true
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>x-amz-copy-source-if-unmodified-since</c> condition evaluates to false
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateTime? UnmodifiedSinceDate
        {
            get { return this._unmodifiedSinceDate ?? DateTime.SpecifyKind(default, DateTimeKind.Utc); }
            set { this._unmodifiedSinceDate = value; }
        }

        // Check to see if UnmodifiedSinceDate property is set
        internal bool IsSetUnmodifiedSinceDate()
        {
            return this._unmodifiedSinceDate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property WebsiteRedirectLocation. 
        /// <para>
        /// If the destination bucket is configured as a website, redirects requests for this
        /// object copy to another object in the same bucket or to an external URL. Amazon S3
        /// stores the value of this header in the object metadata. This value is unique to each
        /// object and is not copied when using the <c>x-amz-metadata-directive</c> header. Instead,
        /// you may opt to provide this header in combination with the <c>x-amz-metadata-directive</c>
        /// header.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string WebsiteRedirectLocation
        {
            get { return this._websiteRedirectLocation; }
            set { this._websiteRedirectLocation = value; }
        }

        // Check to see if WebsiteRedirectLocation property is set
        internal bool IsSetWebsiteRedirectLocation()
        {
            return this._websiteRedirectLocation != null;
        }

    }
}