/*
 * Copyright 2010-2018 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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


namespace Amazon.S3.Model
{
    /// <summary>
    /// The container element for all Public Access Block configuration options. You can enable
    /// the configuration options in any combination.
    /// 
    ///  
    /// <para>
    /// Amazon S3 considers a bucket policy public unless at least one of the following conditions
    /// is true:
    /// </para>
    ///  <ol> <li> 
    /// <para>
    /// The policy limits access to a set of CIDRs using <code>aws:SourceIp</code>. For more
    /// information on CIDR, see <a href="http://www.rfc-editor.org/rfc/rfc4632.txt">http://www.rfc-editor.org/rfc/rfc4632.txt</a>
    /// 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// The policy grants permissions, not including any "bad actions," to one of the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    /// A fixed AWS principal, user, role, or service principal
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A fixed <code>aws:SourceArn</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A fixed <code>aws:SourceVpc</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A fixed <code>aws:SourceVpce</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A fixed <code>aws:SourceOwner</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A fixed <code>aws:SourceAccount</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A fixed value of <code>s3:x-amz-server-side-encryption-aws-kms-key-id</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// A fixed value of <code>aws:userid</code> outside the pattern "<code>AROLEID:*</code>"
    /// </para>
    ///  </li> </ul> </li> </ol> 
    /// <para>
    /// "Bad actions" are those that could expose the data inside a bucket to reads or writes
    /// by the public. These actions are <code>s3:Get*</code>, <code>s3:List*</code>, <code>s3:AbortMultipartUpload</code>,
    /// <code>s3:Delete*</code>, <code>s3:Put*</code>, and <code>s3:RestoreObject</code>.
    /// </para>
    ///  
    /// <para>
    /// The star notation for bad actions indicates that all matching operations are considered
    /// bad actions. For example, because <code>s3:Get*</code> is a bad action, <code>s3:GetObject</code>,
    /// <code>s3:GetObjectVersion</code>, and <code>s3:GetObjectAcl</code> are all bad actions.
    /// </para>
    /// </summary>
    public class PublicAccessBlockConfiguration
    {        
        private bool? blockPublicAcls;
        private bool? ignorePublicAcls;
        private bool? blockPublicPolicy;
        private bool? restrictPublicBuckets;

        /// <summary>
        /// Gets and sets the property BlockPublicAcls.  
        /// <para>
        /// Specifies whether Amazon S3 should block public ACLs for this bucket. Setting this
        /// element to <code>TRUE</code> causes the following behavior:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PUT Bucket acl and PUT Object acl calls will fail if the specified ACL allows public
        /// access.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PUT Object calls will fail if the request includes an object ACL.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Note that enabling this setting doesn't affect existing policies or ACLs.
        /// </para>
        /// </summary>
        public bool BlockPublicAcls
        {
            get { return this.blockPublicAcls ?? default(bool); }
            set { this.blockPublicAcls = value; }
        }

        // Check to see if BlockPublicAcls property is set
        internal bool IsSetBlockPublicAcls()
        {
            return this.blockPublicAcls.HasValue;
        }

        /// <summary>
        /// Gets and sets the property IgnorePublicAcls. 
        /// <para>
        /// Specifies whether Amazon S3 should ignore public ACLs for this bucket. Setting this
        /// element to <code>TRUE</code> causes Amazon S3 to ignore all public ACLs on this bucket
        /// and any objects that it contains. 
        /// </para>
        ///  
        /// <para>
        /// Note that enabling this setting doesn't affect the persistence of any existing ACLs
        /// and doesn't prevent new public ACLs from being set.
        /// </para>
        /// </summary>
        public bool IgnorePublicAcls
        {
            get { return this.ignorePublicAcls ?? default(bool); }
            set { this.ignorePublicAcls = value; }
        }

        // Check to see if IgnorePublicAcls property is set
        internal bool IsSetIgnorePublicAcls()
        {
            return this.ignorePublicAcls.HasValue;
        }

        /// <summary>
        /// Gets and sets the property BlockPublicPolicy. 
        /// <para>
        /// Specifies whether Amazon S3 should block public bucket policies for this bucket. Setting
        /// this element to <code>TRUE</code> causes Amazon S3 to reject calls to PUT Bucket policy
        /// if the specified bucket policy allows public access. 
        /// </para>
        ///  
        /// <para>
        /// Note that enabling this setting doesn't affect existing bucket policies.
        /// </para>
        /// </summary>
        public bool BlockPublicPolicy
        {
            get { return this.blockPublicPolicy ?? default(bool); }
            set { this.blockPublicPolicy = value; }
        }

        // Check to see if BlockPublicPolicy property is set
        internal bool IsSetBlockPublicPolicy()
        {
            return this.blockPublicPolicy.HasValue;
        }

        /// <summary>
        /// Gets and sets the property RestrictPublicBuckets. 
        /// <para>
        /// Specifies whether Amazon S3 should restrict public bucket policies for this bucket.
        /// If this element is set to <code>TRUE</code>, then only the bucket owner and AWS Services
        /// can access this bucket if it has a public policy.
        /// </para>
        ///  
        /// <para>
        /// Note that enabling this setting doesn't affect previously stored bucket policies,
        /// except that public and cross-account access within any public bucket policy, including
        /// non-public delegation to specific accounts, is blocked.
        /// </para>
        /// </summary>
        public bool RestrictPublicBuckets
        {
            get { return this.restrictPublicBuckets ?? default(bool); }
            set { this.restrictPublicBuckets = value; }
        }

        // Check to see if RestrictPublicBuckets property is set
        internal bool IsSetRestrictPublicBuckets()
        {
            return this.restrictPublicBuckets.HasValue;
        }
    }
}
