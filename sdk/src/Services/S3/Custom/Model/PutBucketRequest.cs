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
    /// Container for the parameters to the PutBucket operation.
    /// Creates a new S3 bucket. To create a bucket, you must register with Amazon S3 and
    /// have a valid Amazon Web Services Access Key ID to authenticate requests. Anonymous
    /// requests are never allowed to create buckets. By creating the bucket, you become the
    /// bucket owner.
    /// 
    ///  
    /// <para>
    /// Not every string is an acceptable bucket name. For information about bucket naming
    /// restrictions, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/bucketnamingrules.html">Bucket
    /// naming rules</a>.
    /// </para>
    ///  
    /// <para>
    /// If you want to create an Amazon S3 on Outposts bucket, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/API/API_control_CreateBucket.html">Create
    /// Bucket</a>. 
    /// </para>
    ///  
    /// <para>
    /// By default, the bucket is created in the US East (N. Virginia) Region. You can optionally
    /// specify a Region in the request body. You might choose a Region to optimize latency,
    /// minimize costs, or address regulatory requirements. For example, if you reside in
    /// Europe, you will probably find it advantageous to create buckets in the Europe (Ireland)
    /// Region. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/UsingBucket.html#access-bucket-intro">Accessing
    /// a bucket</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// If you send your create bucket request to the <code>s3.amazonaws.com</code> endpoint,
    /// the request goes to the us-east-1 Region. Accordingly, the signature calculations
    /// in Signature Version 4 must use us-east-1 as the Region, even if the location constraint
    /// in the request specifies another Region where the bucket is to be created. If you
    /// create a bucket in a Region other than US East (N. Virginia), your application must
    /// be able to handle 307 redirect. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/VirtualHosting.html">Virtual
    /// hosting of buckets</a>.
    /// </para>
    ///  </note> <dl> <dt>Access control lists (ACLs)</dt> <dd> 
    ///  
    /// <para>
    /// When creating a bucket using this operation, you can optionally configure the bucket
    /// ACL to specify the accounts or groups that should be granted specific permissions
    /// on the bucket.
    /// </para>
    ///  <important> 
    /// <para>
    /// If your CreateBucket request includes the <code>BucketOwnerEnforced</code> value for
    /// the <code>x-amz-object-ownership</code> header, your request can either not specify
    /// an ACL or specify bucket owner full control ACLs, such as the <code>bucket-owner-full-control</code>
    /// canned ACL or an equivalent ACL expressed in the XML format. For more information,
    /// see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/about-object-ownership.html">Controlling
    /// object ownership</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    ///  </important> 
    /// <para>
    /// There are two ways to grant the appropriate permissions using the request headers.
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// Specify a canned ACL using the <code>x-amz-acl</code> request header. Amazon S3 supports
    /// a set of predefined ACLs, known as <i>canned ACLs</i>. Each canned ACL has a predefined
    /// set of grantees and permissions. For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/acl-overview.html#CannedACL">Canned
    /// ACL</a>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// Specify access permissions explicitly using the <code>x-amz-grant-read</code>, <code>x-amz-grant-write</code>,
    /// <code>x-amz-grant-read-acp</code>, <code>x-amz-grant-write-acp</code>, and <code>x-amz-grant-full-control</code>
    /// headers. These headers map to the set of permissions Amazon S3 supports in an ACL.
    /// For more information, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/acl-overview.html">Access
    /// control list (ACL) overview</a>.
    /// </para>
    ///  
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
    ///  </li> </ul> <note> 
    /// <para>
    /// You can use either a canned ACL or specify access permissions explicitly. You cannot
    /// do both.
    /// </para>
    ///  </note> </dd> <dt>Permissions</dt> <dd> 
    ///  
    /// <para>
    /// In addition to <code>s3:CreateBucket</code>, the following permissions are required
    /// when your CreateBucket includes specific headers:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <b>ACLs</b> - If your <code>CreateBucket</code> request specifies ACL permissions
    /// and the ACL is public-read, public-read-write, authenticated-read, or if you specify
    /// access permissions explicitly through any other ACL, both <code>s3:CreateBucket</code>
    /// and <code>s3:PutBucketAcl</code> permissions are needed. If the ACL the <code>CreateBucket</code>
    /// request is private or doesn't specify any ACLs, only <code>s3:CreateBucket</code>
    /// permission is needed. 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>Object Lock</b> - If <code>ObjectLockEnabledForBucket</code> is set to true in
    /// your <code>CreateBucket</code> request, <code>s3:PutBucketObjectLockConfiguration</code>
    /// and <code>s3:PutBucketVersioning</code> permissions are required.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <b>S3 Object Ownership</b> - If your CreateBucket request includes the the <code>x-amz-object-ownership</code>
    /// header, <code>s3:PutBucketOwnershipControls</code> permission is required.
    /// </para>
    ///  </li> </ul> </dd> </dl> 
    /// <para>
    /// The following operations are related to <code>CreateBucket</code>:
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
        private string bucketName;
        private S3Region bucketRegion;
        private string bucketRegionName;
        private bool useClientRegion = true;
        private S3CannedACL cannedAcl;
        private bool? _objectLockEnabledForBucket;
        private ObjectOwnership _objectOwnership;


        /// <summary>
        /// The canned ACL to apply to the bucket.
        ///  
        /// </summary>
        public S3CannedACL CannedACL
        {
            get { return this.cannedAcl; }
            set { this.cannedAcl = value; }
        }

        // Check to see if ACL property is set
        internal bool IsSetCannedACL()
        {
            return cannedAcl != null && cannedAcl != S3CannedACL.NoACL;
        }

        /// <summary>
        /// If set to true the bucket will be created in the same region
        /// as the configuration of the AmazonS3 client.
        /// If PutBucketRequest.BucketRegion or PutBucketRequest.BucketRegionName are set they take precedence over
        /// this property.
        /// Default: true.
        /// </summary>
        public bool UseClientRegion
        {
            get { return this.useClientRegion; }
            set
            {
                this.useClientRegion = value;
            }
        }

        /// <summary>
        /// The name of the bucket to be created.
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
        /// The region locality for the bucket.
        /// </summary>
        /// <remarks>
        /// When set, this will determine where your data will
        /// reside in S3. Refer <see cref="T:Amazon.S3.S3Region"/>
        /// for a list of possible values.
        /// </remarks>
        public S3Region BucketRegion
        {
            get { return this.bucketRegion; }
            set { this.bucketRegion = value; }
        }

        // Check to see if BucketRegion property is set
        internal bool IsSetBucketRegion()
        {
            return this.bucketRegion != null;
        }

        /// <summary>
        /// The bucket region locality expressed using the name of the region.
        /// When set, this will determine where your data will reside in S3.
        /// Valid values: us-east-1, us-west-1, us-west-2, eu-west-1, ap-southeast-1, ap-southeast-2, ap-northeast-1, sa-east-1
        /// </summary>
        public string BucketRegionName
        {
            get { return this.bucketRegionName; }
            set
            {
                this.bucketRegionName = value;
            }
        }

        // Check to see if BucketRegionName property is set
        internal bool IsSetBucketRegionName()
        {
            return !string.IsNullOrEmpty(this.bucketRegionName);
        }

        /// <summary>
        /// Gets and sets the property ObjectLockEnabledForBucket. 
        /// <para>
        /// Specifies whether you want S3 Object Lock to be enabled for the new bucket.
        /// </para>
        /// </summary>
        public bool ObjectLockEnabledForBucket
        {
            get { return this._objectLockEnabledForBucket.GetValueOrDefault(); }
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
    }
}
    
