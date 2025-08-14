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
    /// Container for the parameters to the DeleteBucketPolicy operation.
    /// Deletes the policy of a specified bucket.
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
    ///  </note> <dl> <dt>Permissions</dt> <dd> 
    /// <para>
    /// If you are using an identity other than the root user of the Amazon Web Services account
    /// that owns the bucket, the calling identity must both have the <c>DeleteBucketPolicy</c>
    /// permissions on the specified bucket and belong to the bucket owner's account in order
    /// to use this operation.
    /// </para>
    ///  
    /// <para>
    /// If you don't have <c>DeleteBucketPolicy</c> permissions, Amazon S3 returns a <c>403
    /// Access Denied</c> error. If you have the correct permissions, but you're not using
    /// an identity that belongs to the bucket owner's account, Amazon S3 returns a <c>405
    /// Method Not Allowed</c> error.
    /// </para>
    ///  <important> 
    /// <para>
    /// To ensure that bucket owners don't inadvertently lock themselves out of their own
    /// buckets, the root principal in a bucket owner's Amazon Web Services account can perform
    /// the <c>GetBucketPolicy</c>, <c>PutBucketPolicy</c>, and <c>DeleteBucketPolicy</c>
    /// API actions, even if their bucket policy explicitly denies the root principal's access.
    /// Bucket owner root principals can only be blocked from performing these API actions
    /// by VPC endpoint policies and Amazon Web Services Organizations policies.
    /// </para>
    ///  </important> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - The <c>s3:DeleteBucketPolicy</c> permission
    /// is required in a policy. For more information about general purpose buckets bucket
    /// policies, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/using-iam-policies.html">Using
    /// Bucket Policies and User Policies</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Directory bucket permissions</b> - To grant access to this API operation, you
    /// must have the <c>s3express:DeleteBucketPolicy</c> permission in an IAM identity-based
    /// policy instead of a bucket policy. Cross-account access to this API operation isn't
    /// supported. This operation can only be performed by the Amazon Web Services account
    /// that owns the resource. For more information about directory bucket policies and permissions,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-security-iam.html">Amazon
    /// Web Services Identity and Access Management (IAM) for S3 Express One Zone</a> in the
    /// <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> </ul> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c>s3express-control.<i>region-code</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following operations are related to <c>DeleteBucketPolicy</c> 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_CreateBucket.html">CreateBucket</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteObject.html">DeleteObject</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class DeleteBucketPolicyRequest : AmazonWebServiceRequest
    {
        private string _bucketName;
        private string _expectedBucketOwner;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The bucket name.
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

    }
}