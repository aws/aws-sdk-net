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
    /// The PublicAccessBlock configuration that you want to apply to this Amazon S3 bucket.
    /// You can enable the configuration options in any combination. For more information
    /// about when Amazon S3 considers a bucket or object public, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html#access-control-block-public-access-policy-status">The
    /// Meaning of "Public"</a> in the <i>Amazon S3 User Guide</i>.
    /// </summary>
    public partial class PublicAccessBlockConfiguration
    {
        private bool? _blockPublicAcls;
        private bool? _blockPublicPolicy;
        private bool? _ignorePublicAcls;
        private bool? _restrictPublicBuckets;

        /// <summary>
        /// Gets and sets the property BlockPublicAcls. 
        /// <para>
        /// Specifies whether Amazon S3 should block public access control lists (ACLs) for this
        /// bucket and objects in this bucket. Setting this element to <c>TRUE</c> causes the
        /// following behavior:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// PUT Bucket ACL and PUT Object ACL calls fail if the specified ACL is public.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PUT Object calls fail if the request includes a public ACL.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// PUT Bucket calls fail if the request includes a public ACL.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Enabling this setting doesn't affect existing policies or ACLs.
        /// </para>
        /// </summary>
        public bool? BlockPublicAcls
        {
            get { return this._blockPublicAcls; }
            set { this._blockPublicAcls = value; }
        }

        // Check to see if BlockPublicAcls property is set
        internal bool IsSetBlockPublicAcls()
        {
            return this._blockPublicAcls.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property BlockPublicPolicy. 
        /// <para>
        /// Specifies whether Amazon S3 should block public bucket policies for this bucket. Setting
        /// this element to <c>TRUE</c> causes Amazon S3 to reject calls to PUT Bucket policy
        /// if the specified bucket policy allows public access. 
        /// </para>
        ///  
        /// <para>
        /// Enabling this setting doesn't affect existing bucket policies.
        /// </para>
        /// </summary>
        public bool? BlockPublicPolicy
        {
            get { return this._blockPublicPolicy; }
            set { this._blockPublicPolicy = value; }
        }

        // Check to see if BlockPublicPolicy property is set
        internal bool IsSetBlockPublicPolicy()
        {
            return this._blockPublicPolicy.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property IgnorePublicAcls. 
        /// <para>
        /// Specifies whether Amazon S3 should ignore public ACLs for this bucket and objects
        /// in this bucket. Setting this element to <c>TRUE</c> causes Amazon S3 to ignore all
        /// public ACLs on this bucket and objects in this bucket.
        /// </para>
        ///  
        /// <para>
        /// Enabling this setting doesn't affect the persistence of any existing ACLs and doesn't
        /// prevent new public ACLs from being set.
        /// </para>
        /// </summary>
        public bool? IgnorePublicAcls
        {
            get { return this._ignorePublicAcls; }
            set { this._ignorePublicAcls = value; }
        }

        // Check to see if IgnorePublicAcls property is set
        internal bool IsSetIgnorePublicAcls()
        {
            return this._ignorePublicAcls.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RestrictPublicBuckets. 
        /// <para>
        /// Specifies whether Amazon S3 should restrict public bucket policies for this bucket.
        /// Setting this element to <c>TRUE</c> restricts access to this bucket to only Amazon
        /// Web Services service principals and authorized users within this account if the bucket
        /// has a public policy.
        /// </para>
        ///  
        /// <para>
        /// Enabling this setting doesn't affect previously stored bucket policies, except that
        /// public and cross-account access within any public bucket policy, including non-public
        /// delegation to specific accounts, is blocked.
        /// </para>
        /// </summary>
        public bool? RestrictPublicBuckets
        {
            get { return this._restrictPublicBuckets; }
            set { this._restrictPublicBuckets = value; }
        }

        // Check to see if RestrictPublicBuckets property is set
        internal bool IsSetRestrictPublicBuckets()
        {
            return this._restrictPublicBuckets.HasValue; 
        }

    }
}