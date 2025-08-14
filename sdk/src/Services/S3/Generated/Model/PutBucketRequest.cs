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
    /// Container for the parameters to the PutBucket operation.
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
    ///  </important> <important> 
    /// <para>
    /// End of support notice: Beginning October 1, 2025, Amazon S3 will stop returning <c>DisplayName</c>.
    /// Update your applications to use canonical IDs (unique identifier for Amazon Web Services
    /// accounts), Amazon Web Services account ID (12 digit identifier) or IAM ARNs (full
    /// resource naming) as a direct replacement of <c>DisplayName</c>. 
    /// </para>
    ///  
    /// <para>
    /// This change affects the following Amazon Web Services Regions: US East (N. Virginia)
    /// Region, US West (N. California) Region, US West (Oregon) Region, Asia Pacific (Singapore)
    /// Region, Asia Pacific (Sydney) Region, Asia Pacific (Tokyo) Region, Europe (Ireland)
    /// Region, and South America (São Paulo) Region.
    /// </para>
    ///  </important> <note> 
    /// <para>
    /// This action creates an Amazon S3 bucket. To create an Amazon S3 on Outposts bucket,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateBucket.html">
    /// <c>CreateBucket</c> </a>.
    /// </para>
    ///  </note> 
    /// <para>
    /// Creates a new S3 bucket. To create a bucket, you must set up Amazon S3 and have a
    /// valid Amazon Web Services Access Key ID to authenticate requests. Anonymous requests
    /// are never allowed to create buckets. By creating the bucket, you become the bucket
    /// owner.
    /// </para>
    ///  
    /// <para>
    /// There are two types of buckets: general purpose buckets and directory buckets. For
    /// more information about these bucket types, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/creating-buckets-s3.html">Creating,
    /// configuring, and working with Amazon S3 buckets</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <note> <ul> <li> 
    /// <para>
    ///  <b>General purpose buckets</b> - If you send your <c>CreateBucket</c> request to
    /// the <c>s3.amazonaws.com</c> global endpoint, the request goes to the <c>us-east-1</c>
    /// Region. So the signature calculations in Signature Version 4 must use <c>us-east-1</c>
    /// as the Region, even if the location constraint in the request specifies another Region
    /// where the bucket is to be created. If you create a bucket in a Region other than US
    /// East (N. Virginia), your application must be able to handle 307 redirect. For more
    /// information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/VirtualHosting.html">Virtual
    /// hosting of buckets</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </li> <li> 
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
    ///  </li> </ul> </note> <dl> <dt>Permissions</dt> <dd> <ul> <li> 
    /// <para>
    ///  <b>General purpose bucket permissions</b> - In addition to the <c>s3:CreateBucket</c>
    /// permission, the following permissions are required in a policy when your <c>CreateBucket</c>
    /// request includes specific headers: 
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>Access control lists (ACLs)</b> - In your <c>CreateBucket</c> request, if you
    /// specify an access control list (ACL) and set it to <c>public-read</c>, <c>public-read-write</c>,
    /// <c>authenticated-read</c>, or if you explicitly specify any other custom ACLs, both
    /// <c>s3:CreateBucket</c> and <c>s3:PutBucketAcl</c> permissions are required. In your
    /// <c>CreateBucket</c> request, if you set the ACL to <c>private</c>, or if you don't
    /// specify any ACLs, only the <c>s3:CreateBucket</c> permission is required. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Object Lock</b> - In your <c>CreateBucket</c> request, if you set <c>x-amz-bucket-object-lock-enabled</c>
    /// to true, the <c>s3:PutBucketObjectLockConfiguration</c> and <c>s3:PutBucketVersioning</c>
    /// permissions are required.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>S3 Object Ownership</b> - If your <c>CreateBucket</c> request includes the <c>x-amz-object-ownership</c>
    /// header, then the <c>s3:PutBucketOwnershipControls</c> permission is required.
    /// </para>
    ///  <important> 
    /// <para>
    ///  To set an ACL on a bucket as part of a <c>CreateBucket</c> request, you must explicitly
    /// set S3 Object Ownership for the bucket to a different value than the default, <c>BucketOwnerEnforced</c>.
    /// Additionally, if your desired bucket ACL grants public access, you must first create
    /// the bucket (without the bucket ACL) and then explicitly disable Block Public Access
    /// on the bucket before using <c>PutBucketAcl</c> to set the ACL. If you try to create
    /// a bucket with a public ACL, the request will fail. 
    /// </para>
    ///  
    /// <para>
    ///  For the majority of modern use cases in S3, we recommend that you keep all Block
    /// Public Access settings enabled and keep ACLs disabled. If you would like to share
    /// data with users outside of your account, you can use bucket policies as needed. For
    /// more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/about-object-ownership.html">Controlling
    /// ownership of objects and disabling ACLs for your bucket </a> and <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-control-block-public-access.html">Blocking
    /// public access to your Amazon S3 storage </a> in the <i>Amazon S3 User Guide</i>. 
    /// </para>
    ///  </important> </li> <li> 
    /// <para>
    ///  <b>S3 Block Public Access</b> - If your specific use case requires granting public
    /// access to your S3 resources, you can disable Block Public Access. Specifically, you
    /// can create a new bucket with Block Public Access enabled, then separately call the
    /// <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeletePublicAccessBlock.html">
    /// <c>DeletePublicAccessBlock</c> </a> API. To use this operation, you must have the
    /// <c>s3:PutBucketPublicAccessBlock</c> permission. For more information about S3 Block
    /// Public Access, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-control-block-public-access.html">Blocking
    /// public access to your Amazon S3 storage </a> in the <i>Amazon S3 User Guide</i>. 
    /// </para>
    ///  </li> </ul> </li> <li> 
    /// <para>
    ///  <b>Directory bucket permissions</b> - You must have the <c>s3express:CreateBucket</c>
    /// permission in an IAM identity-based policy instead of a bucket policy. Cross-account
    /// access to this API operation isn't supported. This operation can only be performed
    /// by the Amazon Web Services account that owns the resource. For more information about
    /// directory bucket policies and permissions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-security-iam.html">Amazon
    /// Web Services Identity and Access Management (IAM) for S3 Express One Zone</a> in the
    /// <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  <important> 
    /// <para>
    /// The permissions for ACLs, Object Lock, S3 Object Ownership, and S3 Block Public Access
    /// are not supported for directory buckets. For directory buckets, all Block Public Access
    /// settings are enabled at the bucket level and S3 Object Ownership is set to Bucket
    /// owner enforced (ACLs disabled). These settings can't be modified. 
    /// </para>
    ///  
    /// <para>
    /// For more information about permissions for creating and working with directory buckets,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/directory-buckets-overview.html">Directory
    /// buckets</a> in the <i>Amazon S3 User Guide</i>. For more information about supported
    /// S3 features for directory buckets, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/s3-express-one-zone.html#s3-express-features">Features
    /// of S3 Express One Zone</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </important> </li> </ul> </dd> <dt>HTTP Host header syntax</dt> <dd> 
    /// <para>
    ///  <b>Directory buckets </b> - The HTTP Host header syntax is <c>s3express-control.<i>region-code</i>.amazonaws.com</c>.
    /// </para>
    ///  </dd> </dl> 
    /// <para>
    /// The following operations are related to <c>CreateBucket</c>:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_PutObject.html">PutObject</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_DeleteBucket.html">DeleteBucket</a>
    /// 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class PutBucketRequest : PutWithACLRequest
    {
        private string _bucketName;
        private S3CannedACL _cannedACL;
        private bool? _objectLockEnabledForBucket;
        private ObjectOwnership _objectOwnership;
        private PutBucketConfiguration _putBucketConfiguration;

        /// <summary>
        /// Gets and sets the property BucketName. 
        /// <para>
        /// The name of the bucket to create.
        /// </para>
        ///  
        /// <para>
        ///  <b>General purpose buckets</b> - For information about bucket naming restrictions,
        /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/bucketnamingrules.html">Bucket
        /// naming rules</a> in the <i>Amazon S3 User Guide</i>.
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
        /// Gets and sets the property CannedACL. 
        /// <para>
        /// The canned ACL to apply to the bucket.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public S3CannedACL CannedACL
        {
            get { return this._cannedACL; }
            set { this._cannedACL = value; }
        }

        // Check to see if CannedACL property is set
        internal bool IsSetCannedACL()
        {
            return this._cannedACL != null;
        }

        /// <summary>
        /// Gets and sets the property ObjectLockEnabledForBucket. 
        /// <para>
        /// Specifies whether you want S3 Object Lock to be enabled for the new bucket.
        /// </para>
        ///  <note> 
        /// <para>
        /// This functionality is not supported for directory buckets.
        /// </para>
        ///  </note>
        /// </summary>
        public bool? ObjectLockEnabledForBucket
        {
            get { return this._objectLockEnabledForBucket; }
            set { this._objectLockEnabledForBucket = value; }
        }

        // Check to see if ObjectLockEnabledForBucket property is set
        internal bool IsSetObjectLockEnabledForBucket()
        {
            return this._objectLockEnabledForBucket.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ObjectOwnership.
        /// </summary>
        public ObjectOwnership ObjectOwnership
        {
            get { return this._objectOwnership; }
            set { this._objectOwnership = value; }
        }

        // Check to see if ObjectOwnership property is set
        internal bool IsSetObjectOwnership()
        {
            return this._objectOwnership != null;
        }

        /// <summary>
        /// Gets and sets the property PutBucketConfiguration. 
        /// <para>
        /// The configuration information for the bucket.
        /// </para>
        /// </summary>
        public PutBucketConfiguration PutBucketConfiguration
        {
            get { return this._putBucketConfiguration; }
            set { this._putBucketConfiguration = value; }
        }

        // Check to see if PutBucketConfiguration property is set
        internal bool IsSetPutBucketConfiguration()
        {
            return this._putBucketConfiguration != null;
        }

    }
}