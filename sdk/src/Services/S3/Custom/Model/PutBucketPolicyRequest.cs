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
    /// Container for the parameters to the PutBucketPolicy operation.
    /// Applies an Amazon S3 bucket policy to an Amazon S3 bucket.
    /// 
    ///  <note> 
    /// <para>
    ///  <b>Directory buckets </b> - For directory buckets, you must make requests for this
    /// API operation to the Regional endpoint. These endpoints support path-style requests
    /// in the format <code>https://s3express-control.<i>region_code</i>.amazonaws.com/<i>bucket-name</i>
    /// </code>. Virtual-hosted-style requests aren't supported. For more information, see
    /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-Regions-and-Zones.html">Regional
    /// and Zonal endpoints</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </note> <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// If you are using an identity other than the root user of the Amazon Web Services account
    /// that owns the bucket, the calling identity must both have the <code>PutBucketPolicy</code>
    /// permissions on the specified bucket and belong to the bucket owner's account in order
    /// to use this operation.
    /// </para>
    ///  
    /// <para>
    /// If you don't have <code>PutBucketPolicy</code> permissions, Amazon S3 returns a <code>403
    /// Access Denied</code> error. If you have the correct permissions, but you're not using
    /// an identity that belongs to the bucket owner's account, Amazon S3 returns a <code>405
    /// Method Not Allowed</code> error.
    /// </para>
    ///  <important> 
    /// <para>
    /// To ensure that bucket owners don't inadvertently lock themselves out of their own
    /// buckets, the root principal in a bucket owner's Amazon Web Services account can perform
    /// the <code>GetBucketPolicy</code>, <code>PutBucketPolicy</code>, and <code>DeleteBucketPolicy</code>
    /// API actions, even if their bucket policy explicitly denies the root principal's access.
    /// Bucket owner root principals can only be blocked from performing these API actions
    /// by VPC endpoint policies and Amazon Web Services Organizations policies.
    /// </para>
    ///  </important> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - The <code>s3:PutBucketPolicy</code> permission
    /// is required in a policy. For more information about general purpose buckets bucket
    /// policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
    /// Bucket Policies and User Policies</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory bucket permissions</b> - To grant access to this API operation, you
    /// must have the <code>s3express:PutBucketPolicy</code> permission in an IAM identity-based
    /// policy instead of a bucket policy. Cross-account access to this API operation isn't
    /// supported. This operation can only be performed by the Amazon Web Services account
    /// that owns the resource. For more information about directory bucket policies and permissions,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-security-iam.html">Amazon
    /// Web Services Identity and Access Management (IAM) for S3 Express One Zone</a> in the
    /// <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> </ul> </dd> <dt>Example bucket policies</dt> <dd> 
    /// <para>
    ///  <b>General purpose buckets example bucket policies</b> - See <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/example-bucket-policies.html">Bucket
    /// policy examples</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  
    /// <para>
    ///  <b>Directory bucket example bucket policies</b> - See <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-security-iam-example-bucket-policies.html">Example
    /// bucket policies for S3 Express One Zone</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <code>s3express-control.<i>region</i>.amazonaws.com</code>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following operations are related to <code>PutBucketPolicy</code>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucket.html">CreateBucket</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucket.html">DeleteBucket</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutBucketPolicyRequest : AmazonWebServiceRequest
    {
        private ChecksumAlgorithm _checksumAlgorithm;
        private bool? confirmRemoveSelfBucketAccess;
        private string expectedBucketOwner;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket.
        /// </para>
        ///  
        /// <para>
        ///  <b>Directory buckets </b> - When you use this operation with a directory bucket,
        /// you must use path-style requests in the format <code>https://s3express-control.<i>region_code</i>.amazonaws.com/<i>bucket-name</i>
        /// </code>. Virtual-hosted-style requests aren't supported. Directory bucket names must
        /// be unique in the chosen Availability Zone. Bucket names must also follow the format
        /// <code> <i>bucket_base_name</i>--<i>az_id</i>--x-s3</code> (for example, <code> <i>DOC-EXAMPLE-BUCKET</i>--<i>usw2-az2</i>--x-s3</code>).
        /// For information about bucket naming restrictions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-bucket-naming-rules.html">Directory
        /// bucket naming rules</a> in the <i>Amazon S3 User Guide</i> 
        /// </para>
        /// </summary>
        public string BucketName { get; set; }

        // Check to see if BucketName property is set
        internal bool IsSetBucket()
        {
            return this.BucketName != null;
        }

        /// <summary>
        /// Gets and sets the property ChecksumAlgorithm. 
        /// <para>
        /// Indicates the algorithm used to create the checksum for the object when you use the
        /// SDK. This header will not provide any additional functionality if you don't use the
        /// SDK. When you send this header, there must be a corresponding <code>x-amz-checksum-<i>algorithm</i>
        /// </code> or <code>x-amz-trailer</code> header sent. Otherwise, Amazon S3 fails the
        /// request with the HTTP status code <code>400 Bad Request</code>.
        /// </para>
        ///  
        /// <para>
        /// For the <code>x-amz-checksum-<i>algorithm</i> </code> header, replace <code> <i>algorithm</i>
        /// </code> with the supported algorithm from the following list: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// CRC32
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// CRC32C
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SHA1
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// SHA256
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/checking-object-integrity.html">Checking
        /// object integrity</a> in the <i>Amazon S3 User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If the individual checksum value you provide through <code>x-amz-checksum-<i>algorithm</i>
        /// </code> doesn't match the checksum algorithm you set through <code>x-amz-sdk-checksum-algorithm</code>,
        /// Amazon S3 ignores any provided <code>ChecksumAlgorithm</code> parameter and uses the
        /// checksum algorithm that matches the provided value in <code>x-amz-checksum-<i>algorithm</i>
        /// </code>.
        /// </para>
        ///  <note> 
        /// <para>
        /// For directory buckets, when you use Amazon Web Services SDKs, <code>CRC32</code> is
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
        /// Gets and sets the property ContentMD5. 
        /// <para>
        /// The MD5 hash of the request body.
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
        public string ContentMD5 { get; set; }

        // Check to see if ContentMD5 property is set
        internal bool IsSetContentMD5()
        {
            return this.ContentMD5 != null;
        }

        /// <summary>
        /// Gets and sets the property Policy. 
        /// <para>
        /// The bucket policy as a JSON document.
        /// </para>
        ///  
        /// <para>
        /// For directory buckets, the only IAM action supported in the bucket policy is <code>s3express:CreateSession</code>.
        /// </para>
        /// </summary>
        public string Policy { get; set; }

        // Check to see if Policy property is set
        internal bool IsSetPolicy()
        {
            return this.Policy != null;
        }

        /// <summary>
        /// Gets and sets the property ConfirmRemoveSelfBucketAccess. 
        /// <para>
        /// Set this parameter to true to confirm that you want to remove your permissions to
        /// change this bucket policy in the future.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? ConfirmRemoveSelfBucketAccess
        {
            get
            {
                return this.confirmRemoveSelfBucketAccess;
            }
            set
            {
                this.confirmRemoveSelfBucketAccess = value;
            }
        }
        // Check to see if ConfirmRemoveSelfBucketAccess property is set
        internal bool IsSetConfirmRemoveSelfBucketAccess()
        {
            return this.confirmRemoveSelfBucketAccess.HasValue;
        }

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
        /// Gets and sets the property ExpectedBucketOwner. 
        /// <para>
        /// The account ID of the expected bucket owner. If the account ID that you provide does
        /// not match the actual owner of the bucket, the request fails with the HTTP status code
        /// <code>403 Forbidden</code> (access denied).
        /// </para>
        ///  <note> 
        /// <para>
        /// For directory buckets, this header is not supported in this API operation. If you
        /// specify this header, the request fails with the HTTP status code <code>501 Not Implemented</code>.
        /// </para>
        ///  </note>
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
    }
}
    
