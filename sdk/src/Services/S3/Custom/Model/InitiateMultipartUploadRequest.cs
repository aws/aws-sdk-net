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
        private HeadersCollection headersCollection = new HeadersCollection();
        private MetadataCollection metadataCollection = new MetadataCollection();

        /// <summary>
        /// This is a convenience property for Headers.ContentType.
        /// </summary>
        public string ContentType
        {
            get { return this.Headers.ContentType; }
            set { this.Headers.ContentType = value; }
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
    }
}
    
