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
    /// Container for the parameters to the InitiateMultipartUpload operation.
    /// <important> 
    /// <para>
    /// End of support notice: Beginning October 1, 2025, Amazon S3 will discontinue support
    /// for creating new Email Grantee Access Control Lists (ACL). Email Grantee ACLs created
    /// prior to this date will continue to work and remain accessible through the Amazon
    /// Web Services Management Console, Command Line Interface (CLI), SDKs, and REST API.
    /// However, you will no longer be able to create new Email Grantee ACLs. 
    /// </para>
    ///  
    /// <para>
    /// This change affects the following Amazon Web Services Regions: US East (N. Virginia)
    /// Region, US West (N. California) Region, US West (Oregon) Region, Asia Pacific (Singapore)
    /// Region, Asia Pacific (Sydney) Region, Asia Pacific (Tokyo) Region, Europe (Ireland)
    /// Region, and South America (São Paulo) Region.
    /// </para>
    ///  </important> 
    /// <para>
    /// This action initiates a multipart upload and returns an upload ID. This upload ID
    /// is used to associate all of the parts in the specific multipart upload. You specify
    /// this upload ID in each of your subsequent upload part requests (see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPart.html">UploadPart</a>).
    /// You also include this upload ID in the final request to either complete or abort the
    /// multipart upload request. For more information about multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuoverview.html">Multipart
    /// Upload Overview</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <note> 
    /// <para>
    /// After you initiate a multipart upload and upload one or more parts, to stop being
    /// charged for storing the uploaded parts, you must either complete or abort the multipart
    /// upload. Amazon S3 frees up the space used to store the parts and stops charging you
    /// for storing them only after you either complete or abort a multipart upload. 
    /// </para>
    ///  </note> 
    /// <para>
    /// If you have configured a lifecycle rule to abort incomplete multipart uploads, the
    /// created multipart upload must be completed within the number of days specified in
    /// the bucket lifecycle configuration. Otherwise, the incomplete multipart upload becomes
    /// eligible for an abort action and Amazon S3 aborts the multipart upload. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuoverview.html#mpu-abort-incomplete-mpu-lifecycle-config">Aborting
    /// Incomplete Multipart Uploads Using a Bucket Lifecycle Configuration</a>.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    ///  <b>Directory buckets </b> - S3 Lifecycle is not supported by directory buckets.
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
    ///  </li> </ul> </note> <dl> <dt>Request signing</dt> <dd> 
    /// <para>
    /// For request signing, multipart upload is just a series of regular requests. You initiate
    /// a multipart upload, send one or more requests to upload parts, and then complete the
    /// multipart upload process. You sign each request individually. There is nothing special
    /// about signing multipart upload requests. For more information about signing, see <a
    /// href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">Authenticating
    /// Requests (Amazon Web Services Signature Version 4)</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </dd> <dt>Permissions</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - To perform a multipart upload with encryption
    /// using an Key Management Service (KMS) KMS key, the requester must have permission
    /// to the <c>kms:Decrypt</c> and <c>kms:GenerateDataKey</c> actions on the key. The requester
    /// must also have permissions for the <c>kms:GenerateDataKey</c> action for the <c>CreateMultipartUpload</c>
    /// API. Then, the requester needs permissions for the <c>kms:Decrypt</c> action on the
    /// <c>UploadPart</c> and <c>UploadPartCopy</c> APIs. These permissions are required because
    /// Amazon S3 must decrypt and read data from the encrypted file parts before it completes
    /// the multipart upload. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/mpuoverview.html#mpuAndPermissions">Multipart
    /// upload API and permissions</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/UsingKMSEncryption.html">Protecting
    /// data using server-side encryption with Amazon Web Services KMS</a> in the <i>Amazon
    /// S3 User Guide</i>.
    /// </para>
    ///  </li> <li> 
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
    ///  </li> </ul> </dd> <dt>Encryption</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose buckets</b> - Server-side encryption is for data encryption at
    /// rest. Amazon S3 encrypts your data as it writes it to disks in its data centers and
    /// decrypts it when you access it. Amazon S3 automatically encrypts all new objects that
    /// are uploaded to an S3 bucket. When doing a multipart upload, if you don't specify
    /// encryption information in your request, the encryption setting of the uploaded parts
    /// is set to the default encryption configuration of the destination bucket. By default,
    /// all buckets have a base level of encryption configuration that uses server-side encryption
    /// with Amazon S3 managed keys (SSE-S3). If the destination bucket has a default encryption
    /// configuration that uses server-side encryption with an Key Management Service (KMS)
    /// key (SSE-KMS), or a customer-provided encryption key (SSE-C), Amazon S3 uses the corresponding
    /// KMS key, or a customer-provided key to encrypt the uploaded parts. When you perform
    /// a CreateMultipartUpload operation, if you want to use a different type of encryption
    /// setting for the uploaded parts, you can request that Amazon S3 encrypts the object
    /// with a different encryption key (such as an Amazon S3 managed key, a KMS key, or a
    /// customer-provided key). When the encryption setting in your request is different from
    /// the default encryption configuration of the destination bucket, the encryption setting
    /// in your request takes precedence. If you choose to provide your own encryption key,
    /// the request headers you provide in <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPart.html">UploadPart</a>
    /// and <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPartCopy.html">UploadPartCopy</a>
    /// requests must match the headers you used in the <c>CreateMultipartUpload</c> request.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use KMS keys (SSE-KMS) that include the Amazon Web Services managed key (<c>aws/s3</c>)
    /// and KMS customer managed keys stored in Key Management Service (KMS) – If you want
    /// Amazon Web Services to manage the keys used to encrypt data, specify the following
    /// headers in the request.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>x-amz-server-side-encryption</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>x-amz-server-side-encryption-aws-kms-key-id</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>x-amz-server-side-encryption-context</c> 
    /// </para>
    ///  </li> </ul> <note> <ul> <li> 
    /// <para>
    /// If you specify <c>x-amz-server-side-encryption:aws:kms</c>, but don't provide <c>x-amz-server-side-encryption-aws-kms-key-id</c>,
    /// Amazon S3 uses the Amazon Web Services managed key (<c>aws/s3</c> key) in KMS to protect
    /// the data.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// To perform a multipart upload with encryption by using an Amazon Web Services KMS
    /// key, the requester must have permission to the <c>kms:Decrypt</c> and <c>kms:GenerateDataKey*</c>
    /// actions on the key. These permissions are required because Amazon S3 must decrypt
    /// and read data from the encrypted file parts before it completes the multipart upload.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/mpuoverview.html#mpuAndPermissions">Multipart
    /// upload API and permissions</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/UsingKMSEncryption.html">Protecting
    /// data using server-side encryption with Amazon Web Services KMS</a> in the <i>Amazon
    /// S3 User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If your Identity and Access Management (IAM) user or role is in the same Amazon Web
    /// Services account as the KMS key, then you must have these permissions on the key policy.
    /// If your IAM user or role is in a different account from the key, then you must have
    /// the permissions on both the key policy and your IAM user or role.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// All <c>GET</c> and <c>PUT</c> requests for an object protected by KMS fail if you
    /// don't make them by using Secure Sockets Layer (SSL), Transport Layer Security (TLS),
    /// or Signature Version 4. For information about configuring any of the officially supported
    /// Amazon Web Services SDKs and Amazon Web Services CLI, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingAWSSDK.html#specify-signature-version">Specifying
    /// the Signature Version in Request Authentication</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> </ul> </note> 
    /// <para>
    /// For more information about server-side encryption with KMS keys (SSE-KMS), see <a
    /// href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/UsingKMSEncryption.html">Protecting
    /// Data Using Server-Side Encryption with KMS keys</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use customer-provided encryption keys (SSE-C) – If you want to manage your own encryption
    /// keys, provide all the following headers in the request.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>x-amz-server-side-encryption-customer-algorithm</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>x-amz-server-side-encryption-customer-key</c> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>x-amz-server-side-encryption-customer-key-MD5</c> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about server-side encryption with customer-provided encryption
    /// keys (SSE-C), see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/ServerSideEncryptionCustomerKeys.html">
    /// Protecting data using server-side encryption with customer-provided encryption keys
    /// (SSE-C)</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Directory buckets</b> - For directory buckets, there are only two supported options
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
    ///  </note> <note> 
    /// <para>
    /// For directory buckets, when you perform a <c>CreateMultipartUpload</c> operation and
    /// an <c>UploadPartCopy</c> operation, the request headers you provide in the <c>CreateMultipartUpload</c>
    /// request must match the default encryption configuration of the destination bucket.
    /// 
    /// </para>
    ///  </note> </li> </ul> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c> <i>Bucket-name</i>.s3express-<i>zone-id</i>.<i>region-code</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following operations are related to <c>CreateMultipartUpload</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPart.html">UploadPart</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CompleteMultipartUpload.html">CompleteMultipartUpload</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_AbortMultipartUpload.html">AbortMultipartUpload</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListParts.html">ListParts</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_ListMultipartUploads.html">ListMultipartUploads</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class InitiateMultipartUploadRequest : PutWithACLRequest
    {
        private bool? _bucketKeyEnabled;
        private string _bucketName;
        private S3CannedACL _cannedACL;
        private ChecksumAlgorithm _checksumAlgorithm;
        private ChecksumType _checksumType;
        private string _expectedBucketOwner;
        private string _key;
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
        /// The name of the bucket where the multipart upload is initiated and where the object
        /// is uploaded.
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
        /// The canned ACL to apply to the object. Amazon S3 supports a set of predefined ACLs,
        /// known as <i>canned ACLs</i>. Each canned ACL has a predefined set of grantees and
        /// permissions. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#CannedACL">Canned
        /// ACL</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// By default, all objects are private. Only the owner has full access control. When
        /// uploading an object, you can grant access permissions to individual Amazon Web Services
        /// accounts or to predefined groups defined by Amazon S3. These permissions are then
        /// added to the access control list (ACL) on the new object. For more information, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Using
        /// ACLs</a>. One way to grant the permissions using the request headers is to specify
        /// a canned ACL with the <c>x-amz-acl</c> request header.
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
            return _cannedACL != null && _cannedACL != S3CannedACL.NoACL;
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm that you want Amazon S3 to use to create the checksum for
        /// the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
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
        /// Gets and sets the property ChecksumType. 
        /// <para>
        /// Indicates the checksum type that you want Amazon S3 to use to calculate the object’s
        /// checksum value. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
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
            return this._expectedBucketOwner != null;
        }

        /// <summary>
        /// Gets and sets the property Key. 
        /// <para>
        /// Object key for which the multipart upload is to be initiated.
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
        /// Gets and sets the property ObjectLockLegalHoldStatus. 
        /// <para>
        /// Specifies whether you want to apply a legal hold to the uploaded object.
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
        /// Specifies the Object Lock mode that you want to apply to the uploaded object.
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
        /// Specifies the date and time when you want the Object Lock to expire.
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
        /// Specifies the algorithm to use when encrypting the object (for example, AES256).
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
            return this._serverSideEncryptionCustomerMethod != null;
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
            return this._serverSideEncryptionCustomerProvidedKey != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionCustomerProvidedKeyMD5. 
        /// <para>
        /// Specifies the 128-bit MD5 digest of the customer-provided encryption key according
        /// to RFC 1321. Amazon S3 uses this header for a message integrity check to ensure that
        /// the encryption key was transmitted without error.
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
            return this._serverSideEncryptionCustomerProvidedKeyMD5 != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionKeyManagementServiceEncryptionContext.
        /// 
        /// <para>
        /// Specifies the Amazon Web Services KMS Encryption Context to use for object encryption.
        /// The value of this header is a Base64 encoded string of a UTF-8 encoded JSON, which
        /// contains the encryption context as key-value pairs.
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
            return this._serverSideEncryptionKeyManagementServiceEncryptionContext != null;
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
            return this._serverSideEncryptionKeyManagementServiceKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideEncryptionMethod. 
        /// <para>
        /// The server-side encryption algorithm used when you store this object in Amazon S3
        /// or Amazon FSx.
        /// </para>
        ///  <ul> <li> 
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
        /// The tag-set for the object. The tag-set must be encoded as URL Query parameters.
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