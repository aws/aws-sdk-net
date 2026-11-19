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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.S3Control.Model
{
    /// <summary>
    /// The <c>PublicAccessBlock</c> configuration that you want to apply to this Amazon S3
    /// account. You can enable the configuration options in any combination. For more information
    /// about when Amazon S3 considers a bucket or object public, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html#access-control-block-public-access-policy-status">The
    /// Meaning of "Public"</a> in the <i>Amazon S3 User Guide</i>.
    /// 
    ///  
    /// <para>
    /// This data type is not supported for Amazon S3 on Outposts.
    /// </para>
    /// </summary>
    public partial class PublicAccessBlockConfiguration
    {
        /// <summary>
        /// Gets and sets the property BlockPublicAcls. 
        /// <para>
        /// Specifies whether Amazon S3 should block public access control lists (ACLs) for buckets
        /// in this account. Setting this element to <c>TRUE</c> causes the following behavior:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>PutBucketAcl</c> and <c>PutObjectAcl</c> calls fail if the specified ACL is public.
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
        ///  
        /// <para>
        /// This property is not supported for Amazon S3 on Outposts.
        /// </para>
        /// </summary>
        public bool? BlockPublicAcls { get; set; }

        /// <summary>
        /// Checks to see if the BlockPublicAcls property is set.
        /// </summary>
        internal bool IsSetBlockPublicAcls() => this.BlockPublicAcls.HasValue;

        /// <summary>
        /// Gets and sets the property BlockPublicPolicy. 
        /// <para>
        /// Specifies whether Amazon S3 should block public bucket policies for buckets in this
        /// account. Setting this element to <c>TRUE</c> causes Amazon S3 to reject calls to PUT
        /// Bucket policy if the specified bucket policy allows public access. 
        /// </para>
        ///  
        /// <para>
        /// Enabling this setting doesn't affect existing bucket policies.
        /// </para>
        ///  
        /// <para>
        /// This property is not supported for Amazon S3 on Outposts.
        /// </para>
        /// </summary>
        public bool? BlockPublicPolicy { get; set; }

        /// <summary>
        /// Checks to see if the BlockPublicPolicy property is set.
        /// </summary>
        internal bool IsSetBlockPublicPolicy() => this.BlockPublicPolicy.HasValue;

        /// <summary>
        /// Gets and sets the property IgnorePublicAcls. 
        /// <para>
        /// Specifies whether Amazon S3 should ignore public ACLs for buckets in this account.
        /// Setting this element to <c>TRUE</c> causes Amazon S3 to ignore all public ACLs on
        /// buckets in this account and any objects that they contain. 
        /// </para>
        ///  
        /// <para>
        /// Enabling this setting doesn't affect the persistence of any existing ACLs and doesn't
        /// prevent new public ACLs from being set.
        /// </para>
        ///  
        /// <para>
        /// This property is not supported for Amazon S3 on Outposts.
        /// </para>
        /// </summary>
        public bool? IgnorePublicAcls { get; set; }

        /// <summary>
        /// Checks to see if the IgnorePublicAcls property is set.
        /// </summary>
        internal bool IsSetIgnorePublicAcls() => this.IgnorePublicAcls.HasValue;

        /// <summary>
        /// Gets and sets the property RestrictPublicBuckets. 
        /// <para>
        /// Specifies whether Amazon S3 should restrict public bucket policies for buckets in
        /// this account. Setting this element to <c>TRUE</c> restricts access to buckets with
        /// public policies to only Amazon Web Services service principals and authorized users
        /// within this account.
        /// </para>
        ///  
        /// <para>
        /// Enabling this setting doesn't affect previously stored bucket policies, except that
        /// public and cross-account access within any public bucket policy, including non-public
        /// delegation to specific accounts, is blocked.
        /// </para>
        ///  
        /// <para>
        /// This property is not supported for Amazon S3 on Outposts.
        /// </para>
        /// </summary>
        public bool? RestrictPublicBuckets { get; set; }

        /// <summary>
        /// Checks to see if the RestrictPublicBuckets property is set.
        /// </summary>
        internal bool IsSetRestrictPublicBuckets() => this.RestrictPublicBuckets.HasValue;
    }
}
