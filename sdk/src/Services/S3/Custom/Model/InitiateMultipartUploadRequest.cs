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
    /// multipart upload request. For more information about multipart uploads, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuoverview.html">Multipart
    /// Upload Overview</a> in the <i>Amazon S3 User Guide</i>.
    /// 
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
    /// requests in the format <c>https://<i>bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com/<i>key-name</i>
    /// </c>. Path-style requests are not supported. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-Regions-and-Zones.html">Regional
    /// and Zonal endpoints</a> in the <i>Amazon S3 User Guide</i>.
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
    ///  <b>General purpose bucket permissions</b> - For information about the permissions
    /// required to use the multipart upload API, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/mpuAndPermissions.html">Multipart
    /// upload and permissions</a> in the <i>Amazon S3 User Guide</i>. 
    /// </para>
    ///  
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
    ///  <b>Directory buckets</b> -For directory buckets, only server-side encryption with
    /// Amazon S3 managed keys (SSE-S3) (<c>AES256</c>) is supported.
    /// </para>
    ///  </li> </ul> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c> <i>Bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com</c>.
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
        private List<Tag> tagset = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string websiteRedirectLocation;
        private ChecksumAlgorithm _checksumAlgorithm;

        /// <summary>
        /// A canned access control list (ACL) to apply to the object.
        /// Please refer to <see cref="T:Amazon.S3.S3CannedACL"/> for information on S3 Canned ACLs.
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
        /// server-side encryption using AWS KMS (SSE-KMS).
        /// </para>
        ///  
        /// <para>
        /// <b>General purpose buckets</b> - Setting this header to <c>true</c> causes Amazon S3 to use an 
        /// S3 Bucket Key for object encryption with SSE-KMS. 
        /// Also, specifying this header with a PUT action doesn't affect bucket-level settings for S3 Bucket Key.
        /// </para>
        /// 
        /// <para> 
        /// <b>Directory buckets</b> - S3 Bucket Keys are always enabled for <c>GET</c> and <c>PUT</c> operations 
        /// in a directory bucket and can’t be disabled.
        /// 
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
        /// The name of the bucket where the multipart upload is initiated and where the object
        /// is uploaded.
        /// </para>
        ///  
        /// <para>
        ///  <b>Directory buckets</b> - When you use this operation with a directory bucket, you
        /// must use virtual-hosted-style requests in the format <c> <i>Bucket_name</i>.s3express-<i>az_id</i>.<i>region</i>.amazonaws.com</c>.
        /// Path-style requests are not supported. Directory bucket names must be unique in the
        /// chosen Availability Zone. Bucket names must follow the format <c> <i>bucket_base_name</i>--<i>az-id</i>--x-s3</c>
        /// (for example, <c> <i>DOC-EXAMPLE-BUCKET</i>--<i>usw2-az1</i>--x-s3</c>). For information
        /// about bucket naming restrictions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-bucket-naming-rules.html">Directory
        /// bucket naming rules</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        ///  <b>Access points</b> - When you use this action with an access point, you must provide
        /// the alias of the access point in place of the bucket name or specify the access point
        /// ARN. When using the access point ARN, you must direct requests to the access point
        /// hostname. The access point hostname takes the form <i>AccessPointName</i>-<i>AccountId</i>.s3-accesspoint.<i>Region</i>.amazonaws.com.
        /// When using this action with an access point through the Amazon Web Services SDKs,
        /// you provide the access point ARN in place of the bucket name. For more information
        /// about access point ARNs, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-access-points.html">Using
        /// access points</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Access points and Object Lambda access points are not supported by directory buckets.
        /// </para>
        ///  </note> 
        /// <para>
        ///  <b>S3 on Outposts</b> - When you use this action with Amazon S3 on Outposts, you
        /// must direct requests to the S3 on Outposts hostname. The S3 on Outposts hostname takes
        /// the form <c> <i>AccessPointName</i>-<i>AccountId</i>.<i>outpostID</i>.s3-outposts.<i>Region</i>.amazonaws.com</c>.
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

        // Check to see if ExpectedBucketOwner property is set
        internal bool IsSetExpectedBucketOwner()
        {
            return !String.IsNullOrEmpty(this.expectedBucketOwner);
        }

        /// <summary>
        /// The key of the object to create or update.
        /// </summary>
        /// <remarks>
        /// <para>
        /// This property will be used as part of the resource path of the HTTP request. In .NET the System.Uri class
        /// is used to construct the uri for the request. The System.Uri class will canonicalize the uri string by compacting characters like "..". 
        /// For example an object key of "foo/../bar/file.txt" will be transformed into "bar/file.txt" because the ".." 
        /// is interpreted as use parent directory.
        /// </para>
        /// <para>
        /// Starting with .NET 8, the AWS .NET SDK disables System.Uri's feature of canonicalizing the resource path. This allows S3 keys like
        /// "foo/../bar/file.txt" to work correctly with the AWS .NET SDK.
        /// </para>
        /// <para>
        /// For further information view the documentation for the Uri class: https://docs.microsoft.com/en-us/dotnet/api/system.uri
        /// </para>
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
        /// Specifies the date and time when you want the Object Lock to expire.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property ServerSideEncryptionMethod. 
        /// <para>
        /// The server-side encryption algorithm used when you store this object in Amazon S3 (for example, <c>AES256</c>, <c>aws:kms</c>).
        /// </para>
        /// 
        /// <ul>
        /// 
        /// <li>
        /// <para>
        /// <b>Directory buckets </b> - For directory buckets, there are only two supported options for server-side encryption: server-side encryption with Amazon S3 managed keys (SSE-S3) (<c>AES256</c>) 
        /// and server-side encryption with KMS keys (SSE-KMS) (<c>aws:kms</c>). 
        /// We recommend that the bucket's default encryption uses the desired encryption configuration and you don't override the bucket default encryption in your <c>CreateSession</c> requests or 
        /// <c>PUT</c> object requests. 
        /// 
        /// Then, new objects are automatically encrypted with the desired encryption settings. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-serv-side-encryption.html">Protecting 
        /// data with server-side encryption</a> in the <i>Amazon S3 User Guide</i>. 
        /// 
        /// For more information about the encryption overriding behaviors in directory buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-specifying-kms-encryption.html">Specifying server-side 
        /// encryption with KMS for new object uploads</a>. 
        /// </para> 
        /// 
        /// <para>
        /// In the Zonal endpoint API calls (except <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CopyObject.html">CopyObject</a> and 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPartCopy.html">UploadPartCopy</a>) using the REST API, the encryption request headers must match the encryption settings 
        /// that are specified in the <c>CreateSession</c> request. 
        /// You can't override the values of the encryption settings (<c>x-amz-server-side-encryption</c>, <c>x-amz-server-side-encryption-aws-kms-key-id</c>, <c>x-amz-server-side-encryption-context</c>, 
        /// and <c>x-amz-server-side-encryption-bucket-key-enabled</c>) that are specified in the <c>CreateSession</c> request. 
        /// 
        /// You don't need to explicitly specify these encryption settings values in Zonal endpoint API calls, and Amazon S3 will use the encryption settings values from the <c>CreateSession</c> request 
        /// to protect new objects in the directory bucket. 
        /// </para>
        /// 
        /// <note>
        /// <para>
        /// When you use the CLI or the Amazon Web Services SDKs, for <c>CreateSession</c>, the session token refreshes automatically to avoid service interruptions when a session expires. 
        /// The CLI or the Amazon Web Services SDKs use the bucket's default encryption configuration for the <c>CreateSession</c> request. 
        /// It's not supported to override the encryption settings values in the <c>CreateSession</c> request. 
        /// 
        /// So in the Zonal endpoint API calls (except <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CopyObject.html">CopyObject</a> and 
        /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPartCopy.html">UploadPartCopy</a>), the encryption request headers must match the default encryption 
        /// configuration of the directory bucket. 
        /// </para>
        /// </note>
        /// </li>
        /// 
        /// </ul>
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
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        /// <returns>true if ServerSideEncryptionCustomerProvidedKey property is set.</returns>
        internal bool IsSetServerSideEncryptionCustomerProvidedKeyMD5()
        {
            return !System.String.IsNullOrEmpty(this.serverSideEncryptionCustomerProvidedKeyMD5);
        }

        /// <summary>
        /// <para>
        /// Specifies the Amazon Web Services KMS Encryption Context to use for object encryption.
        /// The value of this header is a Base64-encoded string of a UTF-8 encoded JSON, which contains the encryption context as key-value pairs.
        /// </para>
        /// 
        /// <para>
        /// <b>Directory buckets</b> - You can optionally provide an explicit encryption context value. 
        /// The value must match the default encryption context - the bucket Amazon Resource Name (ARN). 
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
    
