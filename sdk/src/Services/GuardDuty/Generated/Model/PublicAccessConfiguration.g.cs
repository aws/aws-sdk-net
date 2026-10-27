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

namespace Amazon.GuardDuty.Model
{
    /// <summary>
    /// Describes public access policies that apply to the Amazon S3 bucket.
    /// 
    ///  
    /// <para>
    /// For information about each of the following settings, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-control-block-public-access.html">Blocking
    /// public access to your Amazon S3 storage</a> in the <i>Amazon S3 User Guide</i>.
    /// </para>
    /// </summary>
    public partial class PublicAccessConfiguration
    {
        /// <summary>
        /// Gets and sets the property PublicAclAccess. 
        /// <para>
        /// Indicates whether or not there is a setting that allows public access to the Amazon
        /// S3 buckets through access control lists (ACLs).
        /// </para>
        /// </summary>
        public PublicAccessStatus PublicAclAccess { get; set; }

        /// <summary>
        /// Checks to see if the PublicAclAccess property is set.
        /// </summary>
        internal bool IsSetPublicAclAccess() => this.PublicAclAccess != null;

        /// <summary>
        /// Gets and sets the property PublicAclIgnoreBehavior. 
        /// <para>
        /// Indicates whether or not there is a setting that ignores all public access control
        /// lists (ACLs) on the Amazon S3 bucket and the objects that it contains.
        /// </para>
        /// </summary>
        public PublicAclIgnoreBehavior PublicAclIgnoreBehavior { get; set; }

        /// <summary>
        /// Checks to see if the PublicAclIgnoreBehavior property is set.
        /// </summary>
        internal bool IsSetPublicAclIgnoreBehavior() => this.PublicAclIgnoreBehavior != null;

        /// <summary>
        /// Gets and sets the property PublicBucketRestrictBehavior. 
        /// <para>
        /// Indicates whether or not there is a setting that restricts access to the bucket with
        /// specified policies.
        /// </para>
        /// </summary>
        public PublicBucketRestrictBehavior PublicBucketRestrictBehavior { get; set; }

        /// <summary>
        /// Checks to see if the PublicBucketRestrictBehavior property is set.
        /// </summary>
        internal bool IsSetPublicBucketRestrictBehavior() => this.PublicBucketRestrictBehavior != null;

        /// <summary>
        /// Gets and sets the property PublicPolicyAccess. 
        /// <para>
        /// Indicates whether or not there is a setting that allows public access to the Amazon
        /// S3 bucket policy.
        /// </para>
        /// </summary>
        public PublicAccessStatus PublicPolicyAccess { get; set; }

        /// <summary>
        /// Checks to see if the PublicPolicyAccess property is set.
        /// </summary>
        internal bool IsSetPublicPolicyAccess() => this.PublicPolicyAccess != null;
    }
}
