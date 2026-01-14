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
    /// Container for the parameters to the PutObject operation.
    /// <important> 
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
    ///  </important> 
    /// <para>
    /// Adds an object to a bucket.
    /// </para>
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
    /// requests in the format <c>https://<i>amzn-s3-demo-bucket</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com/<i>key-name</i>
    /// </c>. Path-style requests are not supported. For more information about endpoints
    /// in Availability Zones, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/endpoint-directory-buckets-AZ.html">Regional
    /// and Zonal endpoints for directory buckets in Availability Zones</a> in the <i>Amazon
    /// S3 User Guide</i>. For more information about endpoints in Local Zones, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-lzs-for-directory-buckets.html">Concepts
    /// for directory buckets in Local Zones</a> in the <i>Amazon S3 User Guide</i>.
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
    ///  <b>If-None-Match</b> - Uploads the object only if the object key name does not already
    /// exist in the specified bucket. Otherwise, Amazon S3 returns a <c>412 Precondition
    /// Failed</c> error. If a conflicting operation occurs during the upload, S3 returns
    /// a <c>409 ConditionalRequestConflict</c> response. On a 409 failure, retry the upload.
    /// </para>
    ///  
    /// <para>
    /// Expects the * character (asterisk).
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/conditional-requests.html">Add
    /// preconditions to S3 operations with conditional requests</a> in the <i>Amazon S3 User
    /// Guide</i> or <a href="https://datatracker.ietf.org/doc/rfc7232/">RFC 7232</a>. 
    /// </para>
    ///  <note> 
    /// <para>
    /// This functionality is not supported for S3 on Outposts.
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
    ///  
    /// <para>
    /// If the object is encrypted with SSE-KMS, you must also have the <c>kms:GenerateDataKey</c>
    /// and <c>kms:Decrypt</c> permissions in IAM identity-based policies and KMS key policies
    /// for the KMS key.
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
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c> <i>Bucket-name</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com</c>.
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
    ///  </li> </ul> <important> 
    /// <para>
    /// You must URL encode any signed header values that contain spaces. For example, if
    /// your header value is <c>my file.txt</c>, containing two spaces after <c>my</c>, you
    /// must URL encode this value to <c>my%20%20file.txt</c>.
    /// </para>
    ///  </important>
    /// </summary>
    public partial class PutObjectRequest : PutWithACLRequest
    {
        private bool? _bucketKeyEnabled;
        private string _bucketName;
        private S3CannedACL _cannedACL;
        private ChecksumAlgorithm _checksumAlgorithm;
        private string _checksumCRC32;
        private string _checksumCRC32C;
        private string _checksumCRC64NVME;
        private string _checksumSHA1;
        private string _checksumSHA256;
        
        private string _expectedBucketOwner;
        private string _expires;
        private string _ifMatch;
        private string _ifNoneMatch;
        private Stream _inputStream;
        private string _key;
        private string _md5Digest;
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
        private S3StorageClass _storageClass;
        private List<Tag> _tagSet = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _websiteRedirectLocation;
        private long? _writeOffsetBytes;

        /// <summary>
        /// Gets and sets the property BucketKeyEnabled. 
        /// <para>
        /// Specifies whether Amazon S3 should use an S3 Bucket Key for object encryption with
        /// server-side encryption using Key Management Service (KMS) keys (SSE-KMS).
        /// </para>
        ///  
        /// <para>
        ///  <b>General purpose buckets</b> - Setting this header to <c>true</c> causes Amazon
        /// S3 to use an S3 Bucket Key for object encryption with SSE-KMS. Also, specifying this
        /// header with a PUT action doesn't affect bucket-level settings for S3 Bucket Key.
        /// </para>
        ///  
        /// <para>
        ///  <b>Directory buckets</b> - S3 Bucket Keys are always enabled for <c>GET</c> and <c>PUT</c>
        /// operations in a directory bucket and can’t be disabled. S3 Bucket Keys aren't supported,
        /// when you copy SSE-KMS encrypted objects from general purpose buckets to directory
        /// buckets, from directory buckets to general purpose buckets, or between directory buckets,
        /// through <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CopyObject.html">CopyObject</a>,
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPartCopy.html">UploadPartCopy</a>,
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-objects-Batch-Ops">the
        /// Copy operation in Batch Operations</a>, or <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/create-import-job">the
        /// import jobs</a>. In this case, Amazon S3 makes a call to KMS every time a copy request
        /// is made for a KMS-encrypted object.
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
        /// The bucket name to which the PUT action was initiated. 
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
        ///  
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
        ///  <b>S3 on Outposts</b> - When you use this action with S3 on Outposts, you must direct
        /// requests to the S3 on Outposts hostname. The S3 on Outposts hostname takes the form
        /// <c> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</c>.
        /// When you use this action with S3 on Outposts, the destination bucket must be the Outposts
        /// access point ARN or the access point alias. For more information about S3 on Outposts,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">What
        /// is S3 on Outposts?</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
            get { return this._cannedACL; }
            set { this._cannedACL = value; }
        }

        // Check to see if CannedACL property is set
        internal bool IsSetCannedACL()
        {
            return this._cannedACL != null && this._cannedACL != S3CannedACL.NoACL;
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm used to create the checksum for the object when you use the
        /// SDK. This header will not provide any additional functionality if you don't use the
        /// SDK. When you send this header, there must be a corresponding <c>x-amz-checksum-<i>algorithm</i>
        /// </c> or <c>x-amz-trailer</c> header sent. Otherwise, Amazon S3 fails the request with
        /// the HTTP status code <c>400 Bad Request</c>.
        /// </para>
        ///  
        /// <para>
        /// For the <c>x-amz-checksum-<i>algorithm</i> </c> header, replace <c> <i>algorithm</i>
        /// </c> with the supported algorithm from the following list: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CRC32</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CRC32C</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CRC64NVME</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SHA1</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>SHA256</c> 
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
        /// The <c>Content-MD5</c> or <c>x-amz-sdk-checksum-algorithm</c> header is required for
        /// any request to upload an object with a retention period configured using Amazon S3
        /// Object Lock. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-lock-managing.html#object-lock-put-object">Uploading
        /// objects to an Object Lock enabled bucket </a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// For directory buckets, when you use Amazon Web Services SDKs, <c>CRC32</c> is the
        /// default checksum algorithm that's used for performance.
        /// </para>
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
        /// is the same data that was originally sent. This header specifies the Base64 encoded,
        /// 32-bit <c>CRC32</c> checksum of the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// is the same data that was originally sent. This header specifies the Base64 encoded,
        /// 32-bit <c>CRC32C</c> checksum of the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// This header can be used as a data integrity check to verify that the data received
        /// is the same data that was originally sent. This header specifies the Base64 encoded,
        /// 160-bit <c>SHA1</c> digest of the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// is the same data that was originally sent. This header specifies the Base64 encoded,
        /// 256-bit <c>SHA256</c> digest of the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// Gets and sets the property ContentType. 
        /// <para>
        /// A standard MIME type describing the format of the contents. For more information,
        /// see <a href="https://www.rfc-editor.org/rfc/rfc9110.html#name-content-type">https://www.rfc-editor.org/rfc/rfc9110.html#name-content-type</a>.
        /// </para>
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
            get { return this._expectedBucketOwner; }
            set { this._expectedBucketOwner = value; }
        }

        // Check to see if ExpectedBucketOwner property is set
        internal bool IsSetExpectedBucketOwner()
        {
            return !String.IsNullOrEmpty(this._expectedBucketOwner);
        }

        /// <summary>
        /// Gets and sets the property Expires. 
        /// <para>
        /// The date and time at which the object is no longer cacheable. For more information,
        /// see <a href="https://www.rfc-editor.org/rfc/rfc7234#section-5.3">https://www.rfc-editor.org/rfc/rfc7234#section-5.3</a>.
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
        /// Gets and sets the property IfMatch. 
        /// <para>
        /// Uploads the object only if the ETag (entity tag) value provided during the WRITE operation
        /// matches the ETag of the object in S3. If the ETag values do not match, the operation
        /// returns a <c>412 Precondition Failed</c> error.
        /// </para>
        ///  
        /// <para>
        /// If a conflicting operation occurs during the upload S3 returns a <c>409 ConditionalRequestConflict</c>
        /// response. On a 409 failure you should fetch the object's ETag and retry the upload.
        /// </para>
        ///  
        /// <para>
        /// Expects the ETag value as a string.
        /// </para>
        ///  
        /// <para>
        /// For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC
        /// 7232</a>, or <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/conditional-requests.html">Conditional
        /// requests</a> in the <i>Amazon S3 User Guide</i>.
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
            return !String.IsNullOrEmpty(this._ifMatch);
        }

        /// <summary>
        /// Gets and sets the property IfNoneMatch. 
        /// <para>
        /// Uploads the object only if the object key name does not already exist in the bucket
        /// specified. Otherwise, Amazon S3 returns a <c>412 Precondition Failed</c> error.
        /// </para>
        ///  
        /// <para>
        /// If a conflicting operation occurs during the upload S3 returns a <c>409 ConditionalRequestConflict</c>
        /// response. On a 409 failure you should retry the upload.
        /// </para>
        ///  
        /// <para>
        /// Expects the '*' (asterisk) character.
        /// </para>
        ///  
        /// <para>
        /// For more information about conditional requests, see <a href="https://tools.ietf.org/html/rfc7232">RFC
        /// 7232</a>, or <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/conditional-requests.html">Conditional
        /// requests</a> in the <i>Amazon S3 User Guide</i>.
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
            return !String.IsNullOrEmpty(this._ifNoneMatch);
        }

        /// <summary>
        /// Gets and sets the property InputStream. 
        /// <para>
        /// Object data.
        /// </para>
        /// </summary>
        /// <para>Input stream for the request; content for the request will be read from the stream.</para>
        public Stream InputStream
        {
            get { return this._inputStream; }
            set { this._inputStream = value; }
        }

        // Check to see if InputStream property is set
        internal bool IsSetInputStream()
        {
            return this._inputStream != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Object key for which the PUT action was initiated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
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
        /// Gets and sets the property MD5Digest. 
        /// <para>
        /// The Base64 encoded 128-bit <c>MD5</c> digest of the message (without the headers)
        /// according to RFC 1864. This header can be used as a message integrity check to verify
        /// that the data is the same data that was originally sent. Although it is optional,
        /// we recommend using the Content-MD5 mechanism as an end-to-end integrity check. For
        /// more information about REST request authentication, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/RESTAuthentication.html">REST
        /// Authentication</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>Content-MD5</c> or <c>x-amz-sdk-checksum-algorithm</c> header is required for
        /// any request to upload an object with a retention period configured using Amazon S3
        /// Object Lock. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/object-lock-managing.html#object-lock-put-object">Uploading
        /// objects to an Object Lock enabled bucket </a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string MD5Digest
        {
            get { return this._md5Digest; }
            set { this._md5Digest = value; }
        }

        // Check to see if MD5Digest property is set
        internal bool IsSetMD5Digest()
        {
            return !String.IsNullOrEmpty(this._md5Digest);
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

        // Check to see if ServerSideEncryptionCustomerMethod property is set
        internal bool IsSetServerSideEncryptionCustomerMethod()
        {
            return this._serverSideEncryptionCustomerMethod != null && this._serverSideEncryptionCustomerMethod != Amazon.S3.ServerSideEncryptionCustomerMethod.None;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionCustomerProvidedKey. 
        /// <para>
        /// Specifies the customer-provided encryption key for Amazon S3 to use in encrypting
        /// data. This value is used to store the object and then it is discarded; Amazon S3 does
        /// not store the encryption key. The key must be appropriate for use with the algorithm
        /// specified in the <c>x-amz-server-side-encryption-customer-algorithm</c> header.
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
            get { return this._serverSideEncryptionCustomerProvidedKey; }
            set { this._serverSideEncryptionCustomerProvidedKey = value; }
        }

        // Check to see if ServerSideEncryptionCustomerProvidedKey property is set
        internal bool IsSetServerSideEncryptionCustomerProvidedKey()
        {
            return !String.IsNullOrEmpty(this._serverSideEncryptionCustomerProvidedKey);
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
        /// This functionality is not supported for directory buckets.
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
            return !String.IsNullOrEmpty(this._serverSideEncryptionCustomerProvidedKeyMD5);
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionKeyManagementServiceEncryptionContext.
        /// 
        /// <para>
        /// Specifies the Amazon Web Services KMS Encryption Context as an additional encryption
        /// context to use for object encryption. The value of this header is a Base64 encoded
        /// string of a UTF-8 encoded JSON, which contains the encryption context as key-value
        /// pairs. This value is stored as object metadata and automatically gets passed on to
        /// Amazon Web Services KMS for future <c>GetObject</c> operations on this object.
        /// </para>
        ///  
        /// <para>
        ///  <b>General purpose buckets</b> - This value must be explicitly added during <c>CopyObject</c>
        /// operations if you want an additional encryption context for your object. For more
        /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/UsingKMSEncryption.html#encryption-context">Encryption
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
            return !String.IsNullOrEmpty(this._serverSideEncryptionKeyManagementServiceEncryptionContext);
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionKeyManagementServiceKeyId. 
        /// <para>
        /// Specifies the KMS key ID (Key ID, Key ARN, or Key Alias) to use for object encryption.
        /// If the KMS key doesn't exist in the same account that's issuing the command, you must
        /// use the full Key ARN not the Key ID.
        /// </para>
        ///  
        /// <para>
        ///  <b>General purpose buckets</b> - If you specify <c>x-amz-server-side-encryption</c>
        /// with <c>aws:kms</c> or <c>aws:kms:dsse</c>, this header specifies the ID (Key ID,
        /// Key ARN, or Key Alias) of the KMS key to use. If you specify <c>x-amz-server-side-encryption:aws:kms</c>
        /// or <c>x-amz-server-side-encryption:aws:kms:dsse</c>, but do not provide <c>x-amz-server-side-encryption-aws-kms-key-id</c>,
        /// Amazon S3 uses the Amazon Web Services managed key (<c>aws/s3</c>) to protect the
        /// data.
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
            return !String.IsNullOrEmpty(this._serverSideEncryptionKeyManagementServiceKeyId);
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionMethod. 
        /// <para>
        /// The server-side encryption algorithm that was used when you store this object in Amazon
        /// S3 or Amazon FSx.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>General purpose buckets </b> - You have four mutually exclusive options to protect
        /// data using server-side encryption in Amazon S3, depending on how you choose to manage
        /// the encryption keys. Specifically, the encryption key options are Amazon S3 managed
        /// keys (SSE-S3), Amazon Web Services KMS keys (SSE-KMS or DSSE-KMS), and customer-provided
        /// keys (SSE-C). Amazon S3 encrypts data with server-side encryption by using Amazon
        /// S3 managed keys (SSE-S3) by default. You can optionally tell Amazon S3 to encrypt
        /// data at rest by using server-side encryption with other key options. For more information,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingServerSideEncryption.html">Using
        /// Server-Side Encryption</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Directory buckets </b> - For directory buckets, there are only two supported options
        /// for server-side encryption: server-side encryption with Amazon S3 managed keys (SSE-S3)
        /// (<c>AES256</c>) and server-side encryption with KMS keys (SSE-KMS) (<c>aws:kms</c>).
        /// We recommend that the bucket's default encryption uses the desired encryption configuration
        /// and you don't override the bucket default encryption in your <c>CreateSession</c>
        /// requests or <c>PUT</c> object requests. Then, new objects are automatically encrypted
        /// with the desired encryption settings. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-serv-side-encryption.html">Protecting
        /// data with server-side encryption</a> in the <i>Amazon S3 User Guide</i>. For more
        /// information about the encryption overriding behaviors in directory buckets, see <a
        /// href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-specifying-kms-encryption.html">Specifying
        /// server-side encryption with KMS for new object uploads</a>. 
        /// </para>
        ///  
        /// <para>
        /// In the Zonal endpoint API calls (except <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CopyObject.html">CopyObject</a>
        /// and <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPartCopy.html">UploadPartCopy</a>)
        /// using the REST API, the encryption request headers must match the encryption settings
        /// that are specified in the <c>CreateSession</c> request. You can't override the values
        /// of the encryption settings (<c>x-amz-server-side-encryption</c>, <c>x-amz-server-side-encryption-aws-kms-key-id</c>,
        /// <c>x-amz-server-side-encryption-context</c>, and <c>x-amz-server-side-encryption-bucket-key-enabled</c>)
        /// that are specified in the <c>CreateSession</c> request. You don't need to explicitly
        /// specify these encryption settings values in Zonal endpoint API calls, and Amazon S3
        /// will use the encryption settings values from the <c>CreateSession</c> request to protect
        /// new objects in the directory bucket. 
        /// </para>
        ///  <note> 
        /// <para>
        /// When you use the CLI or the Amazon Web Services SDKs, for <c>CreateSession</c>, the
        /// session token refreshes automatically to avoid service interruptions when a session
        /// expires. The CLI or the Amazon Web Services SDKs use the bucket's default encryption
        /// configuration for the <c>CreateSession</c> request. It's not supported to override
        /// the encryption settings values in the <c>CreateSession</c> request. So in the Zonal
        /// endpoint API calls (except <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CopyObject.html">CopyObject</a>
        /// and <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPartCopy.html">UploadPartCopy</a>),
        /// the encryption request headers must match the default encryption configuration of
        /// the directory bucket. 
        /// </para>
        ///  </note> </li> <li> 
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
        /// Directory buckets only support <c>EXPRESS_ONEZONE</c> (the S3 Express One Zone storage
        /// class) in Availability Zones and <c>ONEZONE_IA</c> (the S3 One Zone-Infrequent Access
        /// storage class) in Dedicated Local Zones.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Amazon S3 on Outposts only uses the OUTPOSTS Storage Class.
        /// </para>
        ///  </li> </ul> </note>
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
        /// Gets and sets the property TagSet. 
        /// <para>
        /// The tag-set for the object. The tag-set must be encoded as URL Query parameters. (For
        /// example, "Key1=Value1")
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
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
            get { return this._websiteRedirectLocation; }
            set { this._websiteRedirectLocation = value; }
        }

        // Check to see if WebsiteRedirectLocation property is set
        internal bool IsSetWebsiteRedirectLocation()
        {
            return this._websiteRedirectLocation != null;
        }

        /// <summary>
        /// Gets and sets the property WriteOffsetBytes. 
        /// <para>
        ///  Specifies the offset for appending data to existing objects in bytes. The offset
        /// must be equal to the size of the existing object being appended to. If no object exists,
        /// setting this header to 0 will create a new object. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is only supported for objects in the Amazon S3 Express One Zone
        /// storage class in directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public long? WriteOffsetBytes
        {
            get { return this._writeOffsetBytes; }
            set { this._writeOffsetBytes = value; }
        }

        // Check to see if WriteOffsetBytes property is set
        internal bool IsSetWriteOffsetBytes()
        {
            return this._writeOffsetBytes.HasValue; 
        }

    }
}