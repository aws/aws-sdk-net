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
    /// Container for the parameters to the PutBucketEncryption operation.
    /// This operation configures default encryption and Amazon S3 Bucket Keys for an existing
    /// bucket.
    /// 
    ///  <note> 
    /// <para>
    ///  <b>Directory buckets </b> - For directory buckets, you must make requests for this
    /// API operation to the Regional endpoint. These endpoints support path-style requests
    /// in the format <c>https://s3express-control.<i>region-code</i>.amazonaws.com/<i>bucket-name</i>
    /// </c>. Virtual-hosted-style requests aren't supported. For more information about endpoints
    /// in Availability Zones, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/endpoint-directory-buckets-AZ.html">Regional
    /// and Zonal endpoints for directory buckets in Availability Zones</a> in the <i>Amazon
    /// S3 User Guide</i>. For more information about endpoints in Local Zones, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-lzs-for-directory-buckets.html">Concepts
    /// for directory buckets in Local Zones</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// By default, all buckets have a default encryption configuration that uses server-side
    /// encryption with Amazon S3 managed keys (SSE-S3).
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    ///  <b>General purpose buckets</b> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// You can optionally configure default encryption for a bucket by using server-side
    /// encryption with Key Management Service (KMS) keys (SSE-KMS) or dual-layer server-side
    /// encryption with Amazon Web Services KMS keys (DSSE-KMS). If you specify default encryption
    /// by using SSE-KMS, you can also configure <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/bucket-key.html">Amazon
    /// S3 Bucket Keys</a>. For information about the bucket default encryption feature, see
    /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/bucket-encryption.html">Amazon
    /// S3 Bucket Default Encryption</a> in the <i>Amazon S3 User Guide</i>. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// If you use PutBucketEncryption to set your <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/bucket-encryption.html">default
    /// bucket encryption</a> to SSE-KMS, you should verify that your KMS key ID is correct.
    /// Amazon S3 doesn't validate the KMS key ID provided in PutBucketEncryption requests.
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Directory buckets </b> - You can optionally configure default encryption for a
    /// bucket by using server-side encryption with Key Management Service (KMS) keys (SSE-KMS).
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// We recommend that the bucket's default encryption uses the desired encryption configuration
    /// and you don't override the bucket default encryption in your <c>CreateSession</c>
    /// requests or <c>PUT</c> object requests. Then, new objects are automatically encrypted
    /// with the desired encryption settings. For more information about the encryption overriding
    /// behaviors in directory buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-specifying-kms-encryption.html">Specifying
    /// server-side encryption with KMS for new object uploads</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Your SSE-KMS configuration can only support 1 <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">customer
    /// managed key</a> per directory bucket's lifetime. The <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#aws-managed-cmk">Amazon
    /// Web Services managed key</a> (<c>aws/s3</c>) isn't supported. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// S3 Bucket Keys are always enabled for <c>GET</c> and <c>PUT</c> operations in a directory
    /// bucket and can’t be disabled. S3 Bucket Keys aren't supported, when you copy SSE-KMS
    /// encrypted objects from general purpose buckets to directory buckets, from directory
    /// buckets to general purpose buckets, or between directory buckets, through <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CopyObject.html">CopyObject</a>,
    /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_UploadPartCopy.html">UploadPartCopy</a>,
    /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-objects-Batch-Ops">the
    /// Copy operation in Batch Operations</a>, or <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/create-import-job">the
    /// import jobs</a>. In this case, Amazon S3 makes a call to KMS every time a copy request
    /// is made for a KMS-encrypted object.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// When you specify an <a href="https://docs.aws.amazon.com/kms/latest/developerguide/concepts.html#customer-cmk">KMS
    /// customer managed key</a> for encryption in your directory bucket, only use the key
    /// ID or key ARN. The key alias format of the KMS key isn't supported.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// For directory buckets, if you use PutBucketEncryption to set your <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/bucket-encryption.html">default
    /// bucket encryption</a> to SSE-KMS, Amazon S3 validates the KMS key ID provided in PutBucketEncryption
    /// requests.
    /// </para>
    ///  </li> </ul> </li> </ul> </note> <important> 
    /// <para>
    /// If you're specifying a customer managed KMS key, we recommend using a fully qualified
    /// KMS key ARN. If you use a KMS key alias instead, then KMS resolves the key within
    /// the requester’s account. This behavior can result in data that's encrypted with a
    /// KMS key that belongs to the requester, and not the bucket owner.
    /// </para>
    ///  
    /// <para>
    /// Also, this action requires Amazon Web Services Signature Version 4. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/sig-v4-authenticating-requests.html">
    /// Authenticating Requests (Amazon Web Services Signature Version 4)</a>. 
    /// </para>
    ///  </important> <dl> <dt>Permissions</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - The <c>s3:PutEncryptionConfiguration</c>
    /// permission is required in a policy. The bucket owner has this permission by default.
    /// The bucket owner can grant this permission to others. For more information about permissions,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/using-with-s3-actions.html#using-with-s3-actions-related-to-bucket-subresources">Permissions
    /// Related to Bucket Operations</a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-access-control.html">Managing
    /// Access Permissions to Your Amazon S3 Resources</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory bucket permissions</b> - To grant access to this API operation, you
    /// must have the <c>s3express:PutEncryptionConfiguration</c> permission in an IAM identity-based
    /// policy instead of a bucket policy. Cross-account access to this API operation isn't
    /// supported. This operation can only be performed by the Amazon Web Services account
    /// that owns the resource. For more information about directory bucket policies and permissions,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-security-iam.html">Amazon
    /// Web Services Identity and Access Management (IAM) for S3 Express One Zone</a> in the
    /// <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    /// To set a directory bucket default encryption with SSE-KMS, you must also have the
    /// <c>kms:GenerateDataKey</c> and the <c>kms:Decrypt</c> permissions in IAM identity-based
    /// policies and KMS key policies for the target KMS key.
    /// </para>
    ///  </li> </ul> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c>s3express-control.<i>region-code</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following operations are related to <c>PutBucketEncryption</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_GetBucketEncryption.html">GetBucketEncryption</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucketEncryption.html">DeleteBucketEncryption</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutBucketEncryptionRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private ChecksumAlgorithm _checksumAlgorithm;
        private string _contentMD5;
        private string _expectedBucketOwner;
        private ServerSideEncryptionConfiguration _serverSideEncryptionConfiguration;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// Specifies default encryption for a bucket using server-side encryption with different
        /// key options.
        /// </para>
        ///  
        /// <para>
        ///  <b>Directory buckets </b> - When you use this operation with a directory bucket,
        /// you must use path-style requests in the format <c>https://s3express-control.<i>region-code</i>.amazonaws.com/<i>bucket-name</i>
        /// </c>. Virtual-hosted-style requests aren't supported. Directory bucket names must
        /// be unique in the chosen Zone (Availability Zone or Local Zone). Bucket names must
        /// also follow the format <c> <i>bucket-base-name</i>--<i>zone-id</i>--x-s3</c> (for
        /// example, <c> <i>DOC-EXAMPLE-BUCKET</i>--<i>usw2-az1</i>--x-s3</c>). For information
        /// about bucket naming restrictions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-bucket-naming-rules.html">Directory
        /// bucket naming rules</a> in the <i>Amazon S3 User Guide</i> 
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
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm used to create the checksum for the request when you use the
        /// SDK. This header will not provide any additional functionality if you don't use the
        /// SDK. When you send this header, there must be a corresponding <c>x-amz-checksum</c>
        /// or <c>x-amz-trailer</c> header sent. Otherwise, Amazon S3 fails the request with the
        /// HTTP status code <c>400 Bad Request</c>. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If you provide an individual checksum, Amazon S3 ignores any provided <c>ChecksumAlgorithm</c>
        /// parameter.
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
        /// Gets and sets the property ContentMD5. 
        /// <para>
        /// The Base64 encoded 128-bit <c>MD5</c> digest of the server-side encryption configuration.
        /// </para>
        ///  
        /// <para>
        /// For requests made using the Amazon Web Services Command Line Interface (CLI) or Amazon
        /// Web Services SDKs, this field is calculated automatically.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public string ContentMD5
        {
            get { return this._contentMD5; }
            set { this._contentMD5 = value; }
        }

        // Check to see if ContentMD5 property is set
        internal bool IsSetContentMD5()
        {
            return this._contentMD5 != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected bucket owner. If the account ID that you provide does
        /// not match the actual owner of the bucket, the request fails with the HTTP status code
        /// <c>403 Forbidden</c> (access denied).
        /// </para>
        ///  <note> 
        /// <para>
        /// For directory buckets, this header is not supported in this API operation. If you
        /// specify this header, the request fails with the HTTP status code <c>501 Not Implemented</c>.
        /// </para>
        ///  </note>
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
        /// Gets and sets the property ServerSideEncryptionConfiguration.
        /// </summary>
        [AWSProperty(Required=true)]
        public ServerSideEncryptionConfiguration ServerSideEncryptionConfiguration
        {
            get { return this._serverSideEncryptionConfiguration; }
            set { this._serverSideEncryptionConfiguration = value; }
        }

        // Check to see if ServerSideEncryptionConfiguration property is set
        internal bool IsSetServerSideEncryptionConfiguration()
        {
            return this._serverSideEncryptionConfiguration != null;
        }

    }
}