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
    /// Container for the parameters to the InitiateMultipartUpload operation.
    /// This action initiates a multipart upload and returns an upload ID. This upload ID
    /// is used to associate all of the parts in the specific multipart upload. You specify
    /// this upload ID in each of your subsequent upload part requests (see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPart.html">UploadPart</a>).
    /// You also include this upload ID in the final request to either complete or abort the
    /// multipart upload request.
    /// 
    ///  
    /// <para>
    /// For more information about multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuoverview.html">Multipart
    /// Upload Overview</a>.
    /// </para>
    ///  
    /// <para>
    /// If you have configured a lifecycle rule to abort incomplete multipart uploads, the
    /// upload must complete within the number of days specified in the bucket lifecycle configuration.
    /// Otherwise, the incomplete multipart upload becomes eligible for an abort action and
    /// Amazon S3 aborts the multipart upload. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuoverview.html#mpu-abort-incomplete-mpu-lifecycle-config">Aborting
    /// Incomplete Multipart Uploads Using a Bucket Lifecycle Policy</a>.
    /// </para>
    ///  
    /// <para>
    /// For information about the permissions required to use the multipart upload API, see
    /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
    /// Upload and Permissions</a>.
    /// </para>
    ///  
    /// <para>
    /// For request signing, multipart upload is just a series of regular requests. You initiate
    /// a multipart upload, send one or more requests to upload parts, and then complete the
    /// multipart upload process. You sign each request individually. There is nothing special
    /// about signing multipart upload requests. For more information about signing, see <a
    /// href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">Authenticating
    /// Requests (Amazon Web Services Signature Version 4)</a>.
    /// </para>
    ///  <note> 
    /// <para>
    ///  After you initiate a multipart upload and upload one or more parts, to stop being
    /// charged for storing the uploaded parts, you must either complete or abort the multipart
    /// upload. Amazon S3 frees up the space used to store the parts and stop charging you
    /// for storing them only after you either complete or abort a multipart upload. 
    /// </para>
    ///  </note> 
    /// <para>
    /// You can optionally request server-side encryption. For server-side encryption, Amazon
    /// S3 encrypts your data as it writes it to disks in its data centers and decrypts it
    /// when you access it. You can provide your own encryption key, or use Amazon Web Services
    /// Key Management Service (Amazon Web Services KMS) customer master keys (CMKs) or Amazon
    /// S3-managed encryption keys. If you choose to provide your own encryption key, the
    /// request headers you provide in <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPart.html">UploadPart</a>
    /// and <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPartCopy.html">UploadPartCopy</a>
    /// requests must match the headers you used in the request to initiate the upload by
    /// using <code>CreateMultipartUpload</code>. 
    /// </para>
    ///  
    /// <para>
    /// To perform a multipart upload with encryption using an Amazon Web Services KMS CMK,
    /// the requester must have permission to the <code>kms:Decrypt</code> and <code>kms:GenerateDataKey*</code>
    /// actions on the key. These permissions are required because Amazon S3 must decrypt
    /// and read data from the encrypted file parts before it completes the multipart upload.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/mpuoverview.html#mpuAndPermissions">Multipart
    /// upload API and permissions</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// If your Identity and Access Management (IAM) user or role is in the same Amazon Web
    /// Services account as the Amazon Web Services KMS CMK, then you must have these permissions
    /// on the key policy. If your IAM user or role belongs to a different account than the
    /// key, then you must have the permissions on both the key policy and your IAM user or
    /// role.
    /// </para>
    ///  
    /// <para>
    ///  For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/serv-side-encryption.html">Protecting
    /// Data Using Server-Side Encryption</a>.
    /// </para>
    ///  <dl> <dt>Access Permissions</dt> <dd> 
    /// <para>
    /// When copying an object, you can optionally specify the accounts or groups that should
    /// be granted specific permissions on the new object. There are two ways to grant the
    /// permissions using the request headers:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Specify a canned ACL with the <code>x-amz-acl</code> request header. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#CannedACL">Canned
    /// ACL</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Specify access permissions explicitly with the <code>x-amz-grant-read</code>, <code>x-amz-grant-read-acp</code>,
    /// <code>x-amz-grant-write-acp</code>, and <code>x-amz-grant-full-control</code> headers.
    /// These parameters map to the set of permissions that Amazon S3 supports in an ACL.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
    /// Control List (ACL) Overview</a>.
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You can use either a canned ACL or specify access permissions explicitly. You cannot
    /// do both.
    /// </para>
    ///  </dd> <dt>Server-Side- Encryption-Specific Request Headers</dt> <dd> 
    /// <para>
    /// You can optionally tell Amazon S3 to encrypt data at rest using server-side encryption.
    /// Server-side encryption is for data encryption at rest. Amazon S3 encrypts your data
    /// as it writes it to disks in its data centers and decrypts it when you access it. The
    /// option you use depends on whether you want to use Amazon Web Services managed encryption
    /// keys or provide your own encryption key. 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Use encryption keys managed by Amazon S3 or customer master keys (CMKs) stored in
    /// Amazon Web Services Key Management Service (Amazon Web Services KMS) – If you want
    /// Amazon Web Services to manage the keys used to encrypt data, specify the following
    /// headers in the request.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// x-amz-server-side-encryption
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// x-amz-server-side-encryption-aws-kms-key-id
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// x-amz-server-side-encryption-context
    /// </para>
    ///  </li> </ul> <note> 
    /// <para>
    /// If you specify <code>x-amz-server-side-encryption:aws:kms</code>, but don't provide
    /// <code>x-amz-server-side-encryption-aws-kms-key-id</code>, Amazon S3 uses the Amazon
    /// Web Services managed CMK in Amazon Web Services KMS to protect the data.
    /// </para>
    ///  </note> <important> 
    /// <para>
    /// All GET and PUT requests for an object protected by Amazon Web Services KMS fail if
    /// you don't make them with SSL or by using SigV4.
    /// </para>
    ///  </important> 
    /// <para>
    /// For more information about server-side encryption with CMKs stored in Amazon Web Services
    /// KMS (SSE-KMS), see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingKMSEncryption.html">Protecting
    /// Data Using Server-Side Encryption with CMKs stored in Amazon Web Services KMS</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Use customer-provided encryption keys – If you want to manage your own encryption
    /// keys, provide all the following headers in the request.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// x-amz-server-side-encryption-customer-algorithm
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// x-amz-server-side-encryption-customer-key
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// x-amz-server-side-encryption-customer-key-MD5
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For more information about server-side encryption with CMKs stored in Amazon Web Services
    /// KMS (SSE-KMS), see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingKMSEncryption.html">Protecting
    /// Data Using Server-Side Encryption with CMKs stored in Amazon Web Services KMS</a>.
    /// </para>
    ///  </li> </ul> </dd> <dt>Access-Control-List (ACL)-Specific Request Headers</dt> <dd>
    /// 
    /// <para>
    /// You also can use the following access control–related headers with this operation.
    /// By default, all objects are private. Only the owner has full access control. When
    /// adding a new object, you can grant permissions to individual Amazon Web Services accounts
    /// or to predefined groups defined by Amazon S3. These permissions are then added to
    /// the access control list (ACL) on the object. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/S3_ACLs_UsingACLs.html">Using
    /// ACLs</a>. With this operation, you can grant access permissions using one of the following
    /// two methods:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Specify a canned ACL (<code>x-amz-acl</code>) — Amazon S3 supports a set of predefined
    /// ACLs, known as <i>canned ACLs</i>. Each canned ACL has a predefined set of grantees
    /// and permissions. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#CannedACL">Canned
    /// ACL</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Specify access permissions explicitly — To explicitly grant access permissions to
    /// specific Amazon Web Services accounts or groups, use the following headers. Each header
    /// maps to specific permissions that Amazon S3 supports in an ACL. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html">Access
    /// Control List (ACL) Overview</a>. In the header, you specify a list of grantees who
    /// get the specific permission. To grant permissions explicitly, use:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// x-amz-grant-read
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// x-amz-grant-write
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// x-amz-grant-read-acp
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// x-amz-grant-write-acp
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// x-amz-grant-full-control
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// You specify each grantee as a type=value pair, where the type is one of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>id</code> – if the value specified is the canonical user ID of an Amazon Web
    /// Services account
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>uri</code> – if you are granting permissions to a predefined group
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>emailAddress</code> – if the value specified is the email address of an Amazon
    /// Web Services account
    /// </para>
    ///  <note> 
    /// <para>
    /// Using email addresses to specify a grantee is only supported in the following Amazon
    /// Web Services Regions: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// US East (N. Virginia)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// US West (N. California)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  US West (Oregon)
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  Asia Pacific (Singapore)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Asia Pacific (Sydney)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Asia Pacific (Tokyo)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Europe (Ireland)
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// South America (São Paulo)
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// For a list of all the Amazon S3 supported Regions and endpoints, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#s3_region">Regions
    /// and Endpoints</a> in the Amazon Web Services General Reference.
    /// </para>
    ///  </note> </li> </ul> 
    /// <para>
    /// For example, the following <code>x-amz-grant-read</code> header grants the Amazon
    /// Web Services accounts identified by account IDs permissions to read object data and
    /// its metadata:
    /// </para>
    ///  
    /// <para>
    ///  <code>x-amz-grant-read: id="11112222333", id="444455556666" </code> 
    /// </para>
    ///  </li> </ul> </dd> </dl> 
    /// <para>
    /// The following operations are related to <code>CreateMultipartUpload</code>:
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
        private S3CannedACL cannedACL;
        private bool? bucketKeyEnabled;
        private string bucketName;
        private string expectedBucketOwner;
        private string key;
        private HeadersCollection headersCollection = new HeadersCollection();
        private MetadataCollection metadataCollection = new MetadataCollection();
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
        private List<Tag> tagset = new List<Tag>();
        private string websiteRedirectLocation;
        private ChecksumAlgorithm _checksumAlgorithm;

        /// <summary>
        /// A canned access control list (ACL) to apply to the object.
        /// Please refer to <see cref="T:Amazon.S3.S3CannedACL"/> for information on S3 Canned ACLs.
        /// <para>This action is not supported by Amazon S3 on Outposts.</para>
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
        /// server-side encryption using AWS KMS (SSE-KMS). Setting this header to <code>true</code>
        /// causes Amazon S3 to use an S3 Bucket Key for object encryption with SSE-KMS.
        /// </para>
        ///  
        /// <para>
        /// Specifying this header with an object action doesn't affect bucket-level settings
        /// for S3 Bucket Key.
        /// </para>
        /// </summary>
        public bool BucketKeyEnabled
        {
            get { return this.bucketKeyEnabled.GetValueOrDefault(); }
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
        /// The name of the bucket to which to initiate the upload
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
        /// When using this action with Amazon S3 on Outposts, you must direct requests to the
        /// S3 on Outposts hostname. The S3 on Outposts hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com.
        /// When using this action using S3 on Outposts through the Amazon Web Services SDKs,
        /// you provide the Outposts bucket ARN in place of the bucket name. For more information
        /// about S3 on Outposts ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/S3onOutposts.html">Using
        /// S3 on Outposts</a> in the <i>Amazon S3 User Guide</i>.
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
        /// The account ID of the expected bucket owner. If the bucket is owned by a different
        /// account, the request will fail with an HTTP <code>403 (Access Denied)</code> error.
        /// </para>
        /// </summary>
        public string ExpectedBucketOwner
        {
            get { return this.expectedBucketOwner; }
            set { this.expectedBucketOwner = value; }
        }

        // Check to see if ExpectedBucketOwner property is set
        internal bool IsSetExpectedBucketOwner()
        {
            return !String.IsNullOrEmpty(this.expectedBucketOwner);
        }

        /// <summary>
        /// The key of the object to create or update.
        /// </summary>
        /// <remarks>
        /// This property will be used as part of the resource path of the HTTP request. In .NET the System.Uri class
        /// is used to construct the uri for the request. The System.Uri class will canonicalize the uri string by compacting characters like "..". /// For example an object key of "foo/../bar/file.txt" will be transformed into "bar/file.txt" because the ".." 
        /// is interpreted as use parent directory. For further information view the documentation for 
        /// the Uri class: https://docs.microsoft.com/en-us/dotnet/api/system.uri
        /// </remarks>
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
            internal set { this.metadataCollection = value; }
        }

        /// <summary>
        /// Gets and sets the property ObjectLockLegalHoldStatus. 
        /// <para>
        /// Specifies whether you want to apply a Legal Hold to the uploaded object.
        /// </para>
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
        /// Specifies the Object Lock mode that you want to apply to the uploaded object.
        /// </para>
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
        /// Specifies the date and time when you want the Object Lock to expire.
        /// </para>
        /// </summary>
        public DateTime ObjectLockRetainUntilDate
        {
            get { return this.objectLockRetainUntilDate.GetValueOrDefault(); }
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
        /// <para>
        /// Specifies the encryption to be used on the server for the new object.
        /// </para>
        /// </summary>
        public ServerSideEncryptionMethod ServerSideEncryptionMethod
        {
            get { return this.serverSideEncryption; }
            set { this.serverSideEncryption = value; }
        }

        // Check to see if ServerSideEncryptionMethod property is set
        internal bool IsSetServerSideEncryptionMethod()
        {
            return this.serverSideEncryption != null && this.serverSideEncryption != ServerSideEncryptionMethod.None;
        }

        /// <summary>
        /// The id of the AWS Key Management Service key that Amazon S3 should use to encrypt and decrypt the object.
        /// If a key id is not specified, the default key will be used for encryption and decryption.
        /// <para>
        /// Specifies the ID of the symmetric customer managed key to use for object encryption.
        /// All GET and PUT requests for an object protected by Amazon Web Services KMS will fail
        /// if not made via SSL or using SigV4. For information about configuring using any of
        /// the officially supported Amazon Web Services SDKs and Amazon Web Services CLI, see
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingAWSSDK.html#specify-signature-version">
        /// Specifying the Signature Version in Request Authentication</a> in the <i>Amazon S3 User Guide</i>.
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
        /// The Server-side encryption algorithm to be used with the customer provided key.
        ///  
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
        /// The base64-encoded encryption key for Amazon S3 to use to encrypt the object
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
        /// Specifies the AWS KMS Encryption Context to use for object encryption.
        /// The value of this header is a base64-encoded UTF-8 string holding JSON with the encryption context key-value pairs.
        /// <para>
        /// Specifies the Amazon Web Services KMS Encryption Context to use for object encryption.
        /// The value of this header is a base64-encoded UTF-8 string holding JSON with the encryption
        /// context key-value pairs.
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
        /// Gets and sets the property StorageClass. 
        /// <para>
        /// By default, Amazon S3 uses the STANDARD Storage Class to store newly created objects.
        /// The STANDARD storage class provides high durability and high availability. Depending
        /// on performance needs, you can specify a different Storage Class. Amazon S3 on Outposts
        /// only uses the OUTPOSTS Storage Class. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/storage-class-intro.html">Storage
        /// Classes</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
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
            return (this.tagset != null) && (this.tagset.Count > 0);
        }

        /// <summary>
        /// Gets and sets the property WebsiteRedirectLocation. 
        /// <para>
        /// If the bucket is configured as a website, redirects requests for this object to another
        /// object in the same bucket or to an external URL. Amazon S3 stores the value of this
        /// header in the object metadata.
        /// </para>
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
            internal set { this.headersCollection = value; }
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm you want Amazon S3 to use to create the checksum for the object.
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
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
        /// Envelope Key to Encrypt data
        /// </summary>
        internal byte[] EnvelopeKey { get; set; }

        /// <summary>
        /// Encrypted Envelope Key to Encrypt data
        /// </summary>
        internal byte[] EncryptedEnvelopeKey { get; set; }

        /// <summary>
        /// Initialization Vector for encryption
        /// </summary>
        internal byte[] IV { get; set; }

        /// <summary>
        /// Storage mode for encryption information.
        /// </summary>
        internal Amazon.S3.Encryption.CryptoStorageMode StorageMode { get; set; }
    }
}
    
