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
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.S3.Model
{
    /// <summary>
    /// Container for the parameters to the PutObject operation.
    /// Adds an object to a bucket.
    /// 
    ///  <note> <ul> <li> 
    /// <para>
    /// Amazon S3 never adds partial objects; if you receive a success response, Amazon S3
    /// added the entire object to the bucket. You cannot use <c>PutObject</c> to only update
    /// a single piece of metadata for an existing object. You must put the entire object
    /// with updated metadata if you want to update some values.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If your bucket uses the bucket owner enforced setting for Object Ownership, ACLs are
    /// disabled and no longer affect permissions. All objects written to the bucket by any
    /// account will be owned by the bucket owner.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory buckets</b> - For directory buckets, you must make requests for this
    /// API operation to the Zonal endpoint. These endpoints support virtual-hosted-style
    /// requests in the format <c>https://<i>bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com/<i>key-name</i>
    /// </c>. Path-style requests are not supported. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-Regions-and-Zones.html">Regional
    /// and Zonal endpoints</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> </ul> </note> 
    /// <para>
    /// Amazon S3 is a distributed system. If it receives multiple write requests for the
    /// same object simultaneously, it overwrites all but the last object written. However,
    /// Amazon S3 provides features that can modify this behavior:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>S3 Object Lock</b> - To prevent objects from being deleted or overwritten, you
    /// can use <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-lock.html">Amazon
    /// S3 Object Lock</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// This functionality is not supported for directory buckets.
    /// </para>
    ///  </note> </li> <li> 
    /// <para>
    ///  <b>S3 Versioning</b> - When you enable versioning for a bucket, if Amazon S3 receives
    /// multiple write requests for the same object simultaneously, it stores all versions
    /// of the objects. For each write request that is made to the same object, Amazon S3
    /// automatically generates a unique version ID of that object being stored in Amazon
    /// S3. You can retrieve, replace, or delete any version of the object. For more information
    /// about versioning, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/AddingObjectstoVersioningEnabledBuckets.html">Adding
    /// Objects to Versioning-Enabled Buckets</a> in the <i>Amazon S3 User Guide</i>. For
    /// information about returning the versioning state of a bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketVersioning.html">GetBucketVersioning</a>.
    /// 
    /// </para>
    ///  <note> 
    /// <para>
    /// This functionality is not supported for directory buckets.
    /// </para>
    ///  </note> </li> </ul> <dl> <dt>Permissions</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - The following permissions are required
    /// in your policies when your <c>PutObject</c> request includes specific headers.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b> <c>s3:PutObject</c> </b> - To successfully complete the <c>PutObject</c> request,
    /// you must always have the <c>s3:PutObject</c> permission on a bucket to add an object
    /// to it.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b> <c>s3:PutObjectAcl</c> </b> - To successfully change the objects ACL of your
    /// <c>PutObject</c> request, you must have the <c>s3:PutObjectAcl</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b> <c>s3:PutObjectTagging</c> </b> - To successfully set the tag-set with your <c>PutObject</c>
    /// request, you must have the <c>s3:PutObjectTagging</c>.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Directory bucket permissions</b> - To grant access to this API operation on a
    /// directory bucket, we recommend that you use the <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateSession.html">
    /// <c>CreateSession</c> </a> API operation for session-based authorization. Specifically,
    /// you grant the <c>s3express:CreateSession</c> permission to the directory bucket in
    /// a bucket policy or an IAM identity-based policy. Then, you make the <c>CreateSession</c>
    /// API call on the bucket to obtain a session token. With the session token in your request
    /// header, you can make API requests to this operation. After the session token expires,
    /// you make another <c>CreateSession</c> API call to generate a new session token for
    /// use. Amazon Web Services CLI or SDKs create session and refresh the session token
    /// automatically to avoid service interruptions when a session expires. For more information
    /// about authorization, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateSession.html">
    /// <c>CreateSession</c> </a>.
    /// </para>
    ///  </li> </ul> </dd> <dt>Data integrity with Content-MD5</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket</b> - To ensure that data is not corrupted traversing the
    /// network, use the <c>Content-MD5</c> header. When you use this header, Amazon S3 checks
    /// the object against the provided MD5 value and, if they do not match, Amazon S3 returns
    /// an error. Alternatively, when the object's ETag is its MD5 digest, you can calculate
    /// the MD5 while putting the object to Amazon S3 and compare the returned ETag to the
    /// calculated MD5 value.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory bucket</b> - This functionality is not supported for directory buckets.
    /// </para>
    ///  </li> </ul> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c> <i>Bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// For more information about related Amazon S3 APIs, see the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CopyObject.html">CopyObject</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteObject.html">DeleteObject</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutObjectRequest : PutWithACLRequest
    {
        private S3CannedACL cannedACL;
        private bool? bucketKeyEnabled;
        private string bucketName;
        private string contentBody;
        private string expectedBucketOwner;
        private string key;
        private long? _writeOffsetBytes; 
        private Stream inputStream;
        private string filePath;
        private bool autoCloseStream = true;
        private bool autoResetStreamPosition = true;
        private bool useChunkEncoding = true;
        private HeadersCollection headersCollection = new HeadersCollection();
        private MetadataCollection metadataCollection = new MetadataCollection();
        private string md5Digest;
        private ObjectLockLegalHoldStatus objectLockLegalHoldStatus;
        private ObjectLockMode objectLockMode;
        private DateTime? objectLockRetainUntilDate;
        private RequestPayer requestPayer;
        private ServerSideEncryptionMethod serverSideEncryption;
        private ServerSideEncryptionCustomerMethod serverSideCustomerEncryption;
        private string serverSideEncryptionCustomerProvidedKey;
        private string serverSideEncryptionCustomerProvidedKeyMD5;
        private string serverSideEncryptionKeyManagementServiceKeyId;
        private string serverSideEncryptionKeyManagementServiceEncryptionContext;
        private S3StorageClass storageClass;
        private List<Tag> tagset = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string websiteRedirectLocation;
        private ChecksumAlgorithm _checksumAlgorithm;
        private string _checksumCRC32;
        private string _checksumCRC32C;
        private string _checksumCRC64NVME;
        private string _checksumSHA1;
        private string _checksumSHA256;
        private string _ifNoneMatch;

        private string _ifMatch;

        /// <summary>
        /// Overriden to turn off sending SHA256 header.
        /// </summary>
        protected override bool IncludeSHA256Header
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Overriden to turn on expect 100 continue.
        /// </summary>
        protected override bool Expect100Continue
        {
            get
            {
                return true;
            }
        }

        /// <summary>
        /// Gets and sets the property CannedACL. 
        /// <para>
        /// The canned ACL to apply to the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#CannedACL">Canned
        /// ACL</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When adding a new object, you can use headers to grant ACL-based permissions to individual
        /// Amazon Web Services accounts or to predefined groups defined by Amazon S3. These permissions
        /// are then added to the ACL on the object. By default, all objects are private. Only
        /// the owner has full access control. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
        /// Control List (ACL) Overview</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-using-rest-api.html">Managing
        /// ACLs Using the REST API</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the bucket that you're uploading objects to uses the bucket owner enforced setting
        /// for S3 Object Ownership, ACLs are disabled and no longer affect permissions. Buckets
        /// that use this setting only accept PUT requests that don't specify an ACL or PUT requests
        /// that specify bucket owner full control ACLs, such as the <c>bucket-owner-full-control</c>
        /// canned ACL or an equivalent form of this ACL expressed in the XML format. PUT requests
        /// that contain other ACLs (for example, custom grants to certain Amazon Web Services
        /// accounts) fail and return a <c>400</c> error with the error code <c>AccessControlListNotSupported</c>.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/about-object-ownership.html">
        /// Controlling ownership of objects and disabling ACLs</a> in the <i>Amazon S3 User Guide</i>.
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
        /// Gets and sets the property BucketKeyEnabled. 
        /// <para>
        /// Specifies whether Amazon S3 should use an S3 Bucket Key for object encryption with
        /// server-side encryption using Key Management Service (KMS) keys (SSE-KMS).
        /// </para>
        ///  
        /// <para>
        /// <b>General purpose buckets</b> - Setting this header to <c>true</c> causes Amazon S3 to use an 
        /// S3 Bucket Key for object encryption with SSE-KMS. 
        /// Also, specifying this header with a PUT action doesn't affect bucket-level settings for S3 Bucket Key.
        /// </para>
        /// 
        /// <para>
        /// <b>Directory buckets</b> - S3 Bucket Keys are always enabled for <c>GET</c> and <c>PUT</c> operations in a directory bucket and can't be disabled. 
        /// S3 Bucket Keys aren't supported, when you copy SSE-KMS encrypted objects from general purpose buckets to directory buckets, 
        /// from directory buckets to general purpose buckets, or between directory buckets, through 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CopyObject.html">CopyObject</a>, 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPartCopy.html">UploadPartCopy</a>, 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-objects-Batch-Ops">the Copy operation in Batch Operations</a>, 
        /// or <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/create-import-job">the import jobs</a>. 
        /// 
        /// In this case, Amazon S3 makes a call to KMS every time a copy request is made for a KMS-encrypted object.
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
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The bucket name to which the PUT action was initiated. 
        /// </para> 
        /// <para> 
        /// <b>Directory buckets</b> - When you use this operation with a directory bucket, you must use virtual-hosted-style requests in the 
        /// format <c> <i>Bucket-name</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com</c>. Path-style requests are not supported. Directory 
        /// bucket names must be unique in the chosen Zone (Availability Zone or Local Zone). Bucket names must follow the 
        /// format <c> <i>bucket-base-name</i>--<i>zone-id</i>--x-s3</c> (for example, <c> <i>amzn-s3-demo-bucket</i>--<i>usw2-az1</i>--x-s3</c>). For information 
        /// about bucket naming restrictions, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-bucket-naming-rules.html">Directory bucket naming rules</a> in 
        /// the <i>Amazon S3 User Guide</i>.
        /// </para> 
        /// <para> 
        /// <b>Access points</b> - When you use this action with an access point for general purpose buckets, you must provide the alias of the access 
        /// point in place of the bucket name or specify the access point ARN. When you use this action with an access point for directory buckets, you 
        /// must provide the access point name in place of the bucket name. When using the access point ARN, you must direct requests to the access point 
        /// hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com. When 
        /// using this action with an access point through the Amazon Web Services SDKs, you provide the access point ARN in place of the bucket name. For 
        /// more information about access point ARNs, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-access-points.html">Using access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para> 
        /// <note> 
        /// <para>
        /// Object Lambda access points are not supported by directory buckets.
        /// </para> 
        /// </note> 
        /// <para> 
        /// <b>S3 on Outposts</b> - When you use this action with S3 on Outposts, you must direct requests to the S3 on Outposts hostname. The S3 on Outposts 
        /// hostname takes the form <c> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</c>. When you use this 
        /// action with S3 on Outposts, the destination bucket must be the Outposts access point ARN or the access point alias. For more information about S3 
        /// on Outposts, see 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">What is S3 on Outposts?</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        public string BucketName
        {
            get { return this.bucketName; }
            set { this.bucketName = value; }
        }

        // Check to see if Bucket property is set
        internal bool IsSetBucket()
        {
            return this.bucketName != null;
        }

        /// <summary>
        /// An MD5 digest for the content.
        /// </summary>
        /// <remarks>
        /// <para>
        /// The Base64 encoded 128-bit <c>MD5</c> digest of the message 
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
        public string MD5Digest
        {
            get { return this.md5Digest; }
            set { this.md5Digest = value; }
        }

        /// <summary>
        /// Checks if MD5Digest property is set.
        /// </summary>
        /// <returns>true if MD5Digest property is set.</returns>
        internal bool IsSetMD5Digest()
        {
            return !System.String.IsNullOrEmpty(this.md5Digest);
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
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected bucket owner. If the account ID that you provide does
        /// not match the actual owner of the bucket, the request fails with the HTTP status code
        /// <c>403 Forbidden</c> (access denied).
        /// </para>
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this.expectedBucketOwner; }
            set { this.expectedBucketOwner = value; }
        }

        /// <summary>
        /// Checks to see if ExpectedBucketOwner is set.
        /// </summary>
        /// <returns>true, if ExpectedBucketOwner property is set.</returns>
        internal bool IsSetExpectedBucketOwner()
        {
            return !String.IsNullOrEmpty(this.expectedBucketOwner);
        }

        /// <summary>
        /// <para>Uploads the object only if the object key name does not already exist in the bucket specified. Otherwise, 
        /// Amazon S3 returns a <c>412 Precondition Failed</c> error.</para> <para>If a conflicting operation occurs 
        /// during the upload S3 returns a <c>409 ConditionalRequestConflict</c> response. On a 409 failure you should 
        /// re-initiate the multipart upload with <c>CreateMultipartUpload</c> and re-upload each part.</para> <para>Expects 
        /// the '*' (asterisk) character.</para> <para>For more information about conditional requests, 
        /// see <a href="https://tools.ietf.org/html/rfc7232">RFC 7232</a>, or <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/conditional-requests.html">Conditional requests</a> 
        /// in the <i>Amazon S3 User Guide</i>.</para>
        /// </summary>
        public string IfNoneMatch
        {
            get { return this._ifNoneMatch; }
            set { this._ifNoneMatch = value; }
        }

        /// <summary>
        /// Checks to see if IfNoneMatch is set.
        /// </summary>
        /// <returns>true, if IfNoneMatch property is set.</returns>
        internal bool IsSetIfNoneMatch()
        {
            return !string.IsNullOrEmpty(this._ifNoneMatch);
        }

        /// <summary>
        /// Gets and sets Key property. This key is used to identify the object in S3.
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
        /// Gets and sets the property WriteOffsetBytes. 
        /// <p>
        /// Specifies the offset for appending data to existing objects in bytes.
        /// The offset must be equal to the size of the existing object being appended to.
        /// If no object exists, setting this header to 0 will create a new object.
        /// </p>
        /// <note>
        /// <p>This functionality is only supported for objects in the Amazon S3 Express One Zone storage class in directory buckets.</p>
        /// </note>
        /// </summary>
        public long WriteOffsetBytes
        {
            get { return this._writeOffsetBytes.GetValueOrDefault(); }
            set { this._writeOffsetBytes = value; }
        }

        // Check to see if WriteOffsetBytes property is set
        internal bool IsSetWriteOffsetBytes()
        {
            return this._writeOffsetBytes.HasValue;
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
            internal set
            {
                this.metadataCollection = value;
            }
        }

        /// <summary>
        /// Gets and sets the property ObjectLockLegalHoldStatus. 
        /// <para>
        /// Specifies whether a legal hold will be applied to this object. For more information
        /// about S3 Object Lock, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/object-lock.html">Object
        /// Lock</a> in the <i>Amazon S3 User Guide</i>.
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
        /// The Object Lock mode that you want to apply to this object.
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
        /// The date and time when you want this object's Object Lock to expire. Must be formatted
        /// as a timestamp parameter.
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
        /// Confirms that the requester knows that she or he will be charged for the request.
        /// Bucket owners need not specify this parameter in their requests.
        /// </summary>
        public RequestPayer RequestPayer
        {
            get { return this.requestPayer; }
            set { this.requestPayer = value; }
        }

        /// <summary>
        /// Checks to see if RequetsPayer is set.
        /// </summary>
        /// <returns>true, if RequestPayer property is set.</returns>
        internal bool IsSetRequestPayer()
        {
            return requestPayer != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionMethod. 
        /// <para>
        /// The server-side encryption algorithm that was used when you store this object in Amazon S3 or Amazon FSx.
        /// </para>
        /// 
        /// <ul>
        /// <li>
        /// <para>
        /// <b>General purpose buckets </b> - You have four mutually exclusive options to protect data using server-side encryption in Amazon S3, 
        /// depending on how you choose to manage the encryption keys. Specifically, the encryption key options are Amazon S3 managed keys (SSE-S3), 
        /// Amazon Web Services KMS keys (SSE-KMS or DSSE-KMS), and customer-provided keys (SSE-C). 
        /// 
        /// Amazon S3 encrypts data with server-side encryption by using Amazon S3 managed keys (SSE-S3) by default. 
        /// You can optionally tell Amazon S3 to encrypt data at rest by using server-side encryption with other key options. For more information, 
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingServerSideEncryption.html">Using Server-Side Encryption</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </li>
        /// 
        /// <li>
        /// <para>
        /// <b>Directory buckets </b> - For directory buckets, there are only two supported options for server-side encryption: server-side encryption with Amazon S3 
        /// managed keys (SSE-S3) (<c>AES256</c>) and server-side encryption with KMS keys (SSE-KMS) (<c>aws:kms</c>). 
        /// 
        /// We recommend that the bucket's default encryption uses the desired encryption configuration and you don't override the bucket default encryption in your <c>CreateSession</c> requests 
        /// or <c>PUT</c> object requests. Then, new objects are automatically encrypted with the desired encryption settings. 
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-serv-side-encryption.html">Protecting data with server-side encryption</a> in 
        /// the <i>Amazon S3 User Guide</i>. 
        /// For more information about the encryption overriding behaviors in directory buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-specifying-kms-encryption.html">Specifying server-side encryption with KMS for 
        /// new object uploads</a>.
        /// </para>
        /// 
        /// <para>In the Zonal endpoint API calls (except <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CopyObject.html">CopyObject</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPartCopy.html">UploadPartCopy</a>) 
        /// using the REST API, the encryption request headers must match the encryption settings that are specified in the <c>CreateSession</c> request. 
        /// You can't override the values of the encryption settings (<c>x-amz-server-side-encryption</c>, <c>x-amz-server-side-encryption-aws-kms-key-id</c>, <c>x-amz-server-side-encryption-context</c>, and <c>x-amz-server-side-encryption-bucket-key-enabled</c>) 
        /// that are specified in the <c>CreateSession</c> request. 
        /// 
        /// You don't need to explicitly specify these encryption settings values in Zonal endpoint API calls, and Amazon S3 will use the encryption settings values from the <c>CreateSession</c> request to
        /// protect new objects in the directory bucket.
        /// </para>
        /// 
        /// <note>
        /// <para>
        /// When you use the CLI or the Amazon Web Services SDKs, for <c>CreateSession</c>, the session token refreshes automatically to avoid service interruptions when a session expires. 
        /// The CLI or the Amazon Web Services SDKs use the bucket's default encryption configuration for the <c>CreateSession</c> request. 
        /// It's not supported to override the encryption settings values in the <c>CreateSession</c> request. 
        /// So in the Zonal endpoint API calls (except <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CopyObject.html">CopyObject</a> and 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPartCopy.html">UploadPartCopy</a>), the encryption request headers must match the default encryption configuration of 
        /// the directory bucket.
        /// </para>
        /// </note>
        /// </li>
        /// <li>
        /// <para>
        /// <b>S3 access points for Amazon FSx </b> - When accessing data stored in Amazon FSx file systems using S3 access points, the only valid server side encryption option is <c>aws:fsx</c>. All Amazon FSx file systems have encryption configured by default 
        /// and are encrypted at rest. Data is automatically encrypted before being written to the file system, and automatically decrypted as it is read. These processes are handled transparently by Amazon FSx.
        /// </para>
        /// </li>
        /// </ul>
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
        /// The Server-side encryption algorithm to be used with the customer provided key.
        ///  
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
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
        /// The Base64 encoded encryption key for Amazon S3 to use to encrypt the object
        /// <para>
        /// Using the encryption key you provide as part of your request Amazon S3 manages both the encryption, as it writes 
        /// to disks, and decryption, when you access your objects. Therefore, you don't need to maintain any data encryption code. The only 
        /// thing you do is manage the encryption keys you provide.
        /// </para>
        /// <para>
        /// When you retrieve an object, you must provide the same encryption key as part of your request. Amazon S3 first verifies 
        /// the encryption key you provided matches, and then decrypts the object before returning the object data to you.
        /// </para>
        /// <para>
        /// Important: Amazon S3 does not store the encryption key you provide.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Sensitive=true)]
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
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property ServerSideEncryptionKeyManagementServiceEncryptionContext. 
        /// <para>
        /// Specifies the Amazon Web Services KMS Encryption Context as an additional encryption context to use for object encryption. 
        /// The value of this header is a Base64 encoded string of a UTF-8 encoded JSON, which contains the encryption context as key-value pairs. 
        /// This value is stored as object metadata and automatically gets passed on to Amazon Web Services KMS for future <c>GetObject</c> operations on this object.
        /// </para>
        /// <para>
        /// <b>General purpose buckets</b> - This value must be explicitly added during <c>CopyObject</c> operations if you want an additional encryption context for your object. 
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/UsingKMSEncryption.html#encryption-context">Encryption context</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// <para>
        /// <b>Directory buckets</b> - You can optionally provide an explicit encryption context value. The value must match the default encryption context - the bucket Amazon Resource Name (ARN). 
        /// An additional encryption context value is not supported.
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true)]
        public string ServerSideEncryptionKeyManagementServiceEncryptionContext
        {
            get { return this.serverSideEncryptionKeyManagementServiceEncryptionContext; }
            set { this.serverSideEncryptionKeyManagementServiceEncryptionContext = value; }
        }

        /// <summary>
        /// Checks if ServerSideEncryptionKeyManagementServiceEncryptionContext property is set.
        /// </summary>
        /// <returns>true if ServerSideEncryptionKeyManagementServiceEncryptionContext property is set.</returns>
        internal bool IsSetServerSideEncryptionKeyManagementServiceEncryptionContext()
        {
            return !System.String.IsNullOrEmpty(this.serverSideEncryptionKeyManagementServiceEncryptionContext);
        }

        /// <summary>
        /// <para>
        /// Specifies the KMS key ID (Key ID, Key ARN, or Key Alias) to use for object encryption. 
        /// If the KMS key doesn't exist in the same account that's issuing the command, you must use the full Key ARN not the Key ID.
        /// </para> 
        /// 
        /// <para> 
        /// <b>General purpose buckets</b> - If you specify <c>x-amz-server-side-encryption</c> with <c>aws:kms</c> or <c>aws:kms:dsse</c>, this header specifies 
        /// the ID (Key ID, Key ARN, or Key Alias) of the KMS key to use. If you specify <c>x-amz-server-side-encryption:aws:kms</c> or <c>x-amz-server-side-encryption:aws:kms:dsse</c>, 
        /// but do not provide <c>x-amz-server-side-encryption-aws-kms-key-id</c>, Amazon S3 uses the Amazon Web Services managed key (<c>aws/s3</c>) to protect the data.
        /// </para>
        /// 
        /// <para>
        /// <b>Directory buckets</b> - If you specify <c>x-amz-server-side-encryption</c> with <c>aws:kms</c>, you must specify 
        /// the <c> x-amz-server-side-encryption-aws-kms-key-id</c> header with the ID (Key ID or Key ARN) of the KMS symmetric encryption customer managed key to use. 
        /// Otherwise, you get an HTTP <c>400 Bad Request</c> error. 
        /// 
        /// Only use the key ID or key ARN. The key alias format of the KMS key isn't supported. 
        /// Your SSE-KMS configuration can only support 1 <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer managed key</a> per directory bucket 
        /// for the lifetime of the bucket. 
        /// 
        /// <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon Web Services managed key</a> (<c>aws/s3</c>) isn't supported.
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
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// By default, Amazon S3 uses the STANDARD Storage Class to store newly created objects.
        /// The STANDARD storage class provides high durability and high availability. Depending
        /// on performance needs, you can specify a different Storage Class. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage-class-intro.html">Storage
        /// Classes</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  <note> <ul> <li> 
        /// <para>
        /// For directory buckets, only the S3 Express One Zone storage class is supported to
        /// store newly created objects.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon S3 on Outposts only uses the OUTPOSTS Storage Class.
        /// </para>
        ///  </li> </ul> </note>
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
        /// The tag-set for the object. The tag-set must be encoded as URL Query parameters.
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public List<Tag> TagSet
        {
            get { return this.tagset; }
            set { this.tagset = value; }
        }

        /// <summary>
        /// Checks if Tagging property is set
        /// </summary>
        /// <returns>true if Tagging is set.</returns>
        internal bool IsSetTagSet()
        {
            return this.tagset != null && (this.tagset.Count > 0 || !AWSConfigs.InitializeCollections);
        }

        /// <summary>
        /// Gets and sets the property WebsiteRedirectLocation. 
        /// <para>
        /// If the bucket is configured as a website, redirects requests for this object to another
        /// object in the same bucket or to an external URL. Amazon S3 stores the value of this
        /// header in the object metadata. For information about object metadata, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingMetadata.html">Object
        /// Key and Metadata</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// In the following example, the request header sets the redirect to an object (anotherPage.html)
        /// in the same bucket:
        /// </para>
        ///  
        /// <para>
        ///  <c>x-amz-website-redirect-location: /anotherPage.html</c> 
        /// </para>
        ///  
        /// <para>
        /// In the following example, the request header sets the object redirect to another website:
        /// </para>
        ///  
        /// <para>
        ///  <c>x-amz-website-redirect-location: http://www.example.com/</c> 
        /// </para>
        ///  
        /// <para>
        /// For more information about website hosting in Amazon S3, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/WebsiteHosting.html">Hosting
        /// Websites on Amazon S3</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/how-to-page-redirect.html">How
        /// to Configure Website Page Redirects</a> in the <i>Amazon S3 User Guide</i>. 
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
        /// Input stream for the request; content for the request will be read from the stream.
        /// </summary>
        public Stream InputStream
        {
            get { return this.inputStream; }
            set { this.inputStream = value; }
        }

        // Check to see if Body property is set
        internal bool IsSetInputStream()
        {
            return this.inputStream != null;
        }

        /// <summary>
        /// <para>
        /// The full path and name to a file to be uploaded.
        /// If this is set the request will upload the specified file to S3. 
        /// </para>
        /// <para>
        /// For WinRT and Windows Phone this property must be in the form of "ms-appdata:///local/file.txt".
        /// </para>
        /// </summary>
        public string FilePath
        {
            get { return this.filePath; }
            set { this.filePath = value; }
        }

        /// <summary>
        /// Text content to be uploaded. Use this property if you want to upload plaintext to S3. 
        /// The content type will be set to 'text/plain'.
        /// </summary>
        public string ContentBody
        {
            get { return this.contentBody; }
            set { this.contentBody = value; }
        }

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
        /// If this value is set to true then the stream will be seeked back to the start before being read for upload.
        /// Default: true.
        /// </summary>
        public bool AutoResetStreamPosition
        {
            get { return this.autoResetStreamPosition; }
            set { this.autoResetStreamPosition = value; }
        }

        /// <summary>
        /// <para><b>WARNING: Setting DisableDefaultChecksumValidation to true disables the default data 
        /// integrity check on upload requests.</b></para>
        /// <para>When true, checksum verification will not be used in upload requests. This may increase upload 
        /// performance under high CPU loads. Setting DisableDefaultChecksumValidation sets the deprecated property
        /// DisableMD5Stream to the same value. The default value is false.</para>
        /// <para>Checksums, SigV4 payload signing, and HTTPS each provide some data integrity 
        /// verification. If DisableDefaultChecksumValidation is true and DisablePayloadSigning is true, then the 
        /// possibility of data corruption is completely dependent on HTTPS being the only remaining 
        /// source of data integrity verification.</para>
        /// </summary>
        public bool? DisableDefaultChecksumValidation { get; set; }

        /// <summary>
        /// If this value is set to true then a chunked encoding upload will be used for the request.
        /// Default: true.
        /// </summary>
        public bool UseChunkEncoding
        {
            get { return this.useChunkEncoding; }
            set { this.useChunkEncoding = value; }
        }

        /// <summary>      
        /// <para><b>WARNING: Setting DisablePayloadSigning to true disables the SigV4 payload signing 
        /// data integrity check on this request.</b></para>  
        /// <para>If using SigV4, the DisablePayloadSigning flag controls if the payload should be 
        /// signed on a request by request basis. By default this flag is null which will use the 
        /// default client behavior. The default client behavior is to sign the payload. When 
        /// DisablePayloadSigning is true, the request will be signed with an UNSIGNED-PAYLOAD value. 
        /// Setting DisablePayloadSigning to true requires that the request is sent over a HTTPS 
        /// connection.</para>        
        /// <para>Under certain circumstances, such as uploading to S3 while using MD5 hashing, it may 
        /// be desireable to use UNSIGNED-PAYLOAD to decrease signing CPU usage. This flag only applies 
        /// to Amazon S3 PutObject and UploadPart requests.</para>
        /// <para>MD5Stream, SigV4 payload signing, and HTTPS each provide some data integrity 
        /// verification. If DisableMD5Stream is true and DisablePayloadSigning is true, then the 
        /// possibility of data corruption is completely dependant on HTTPS being the only remaining 
        /// source of data integrity verification.</para>
        /// </summary>
        public bool? DisablePayloadSigning { get; set; }

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
            internal set
            {
                this.headersCollection = value;
            }
        }

        /// <summary>
        /// Attach a callback that will be called as data is being sent to the AWS Service.
        /// </summary>
        public EventHandler<Amazon.Runtime.StreamTransferProgressArgs> StreamTransferProgress
        {
            get
            {
                return ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)this).StreamUploadProgressCallback;
            }
            set
            {
                ((Amazon.Runtime.Internal.IAmazonWebServiceRequest)this).StreamUploadProgressCallback = value;
            }
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm used to create the checksum for the object when you use the
        /// SDK. This header will not provide any additional functionality if you don't use the
        /// SDK. When you send this header, there must be a corresponding <c>x-amz-checksum-<i>algorithm</i>
        /// </c> or <c>x-amz-trailer</c> header sent. Otherwise, Amazon S3 fails the
        /// request with the HTTP status code <c>400 Bad Request</c>.
        /// </para>
        ///  
        /// <para>
        /// For the <c>x-amz-checksum-<i>algorithm</i> </c> header, replace <c> <i>algorithm</i>
        /// </c> with the supported algorithm from the following list: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CRC-32
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CRC-32C
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CRC-64NVME
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SHA-1
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SHA-256
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the individual checksum value you provide through <c>x-amz-checksum-<i>algorithm</i>
        /// </c> doesn't match the checksum algorithm you set through <c>x-amz-sdk-checksum-algorithm</c>,
        /// Amazon S3 fails the request with a <c>BadDigest</c> error.
        /// </para>
        ///  <note> 
        /// <para>
        /// For directory buckets, when you use Amazon Web Services SDKs, <c>CRC32</c> is
        /// the default checksum algorithm that's used for performance.
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
        /// Gets and sets the property ChecksumCRC32. 
        /// <para>
        /// This header can be used as a data integrity check to verify that the data received
        /// is the same data that was originally sent. This specifies the Base64 encoded, 32-bit
        /// <c>CRC-32</c> checksum of the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
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
        /// This header can be used as a data integrity check to verify that the data received
        /// is the same data that was originally sent. This specifies the Base64 encoded, 32-bit
        /// <c>CRC-32C</c> checksum of the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
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
        /// is the same data that was originally sent. This specifies the Base64 encoded, 32-bit
        /// <c>CRC-64NVME</c> checksum of the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
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
        /// This header can be used as a data integrity check to verify that the data received
        /// is the same data that was originally sent. This specifies the Base64 encoded, 160-bit
        /// <c>SHA-1</c> digest of the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
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
        /// This header can be used as a data integrity check to verify that the data received
        /// is the same data that was originally sent. This specifies the Base64 encoded, 256-bit
        /// <c>SHA-256</c> digest of the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">
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
        /// <para>Uploads the object only if the ETag (entity tag) value provided during the WRITE operation matches the ETag of the object in S3. If the ETag values do not match, the operation returns a <code>412 Precondition Failed</code> error.</para>
        /// <para>If a conflicting operation occurs during the upload S3 returns a <code>409 ConditionalRequestConflict</code> response. On a 409 failure you should fetch the object's ETag and retry the upload.</para>
        /// <para>Expects the ETag value as a string.</para>
        /// <para>For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC 7232</a>, or <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/conditional-requests.html">Conditional requests</a> in the <i>Amazon S3 User Guide</i>.</para>
        /// </summary>
        public string IfMatch
        {
            get { return this._ifMatch; }
            set { this._ifMatch = value; }
        }

        /// <summary>
        /// Checks if the IfMatch property is set.
        /// </summary>
        internal bool IsSetIfMatch()
        {
            return !string.IsNullOrEmpty(this._ifMatch);
        }
    }
}
