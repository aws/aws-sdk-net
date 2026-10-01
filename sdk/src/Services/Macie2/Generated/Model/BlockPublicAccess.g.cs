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

namespace Amazon.Macie2.Model
{
    /// <summary>
    /// Provides information about the block public access settings for an S3 bucket. These
    /// settings can apply to a bucket at the account or bucket level. For detailed information
    /// about each setting, see <a href="https://docs.aws.amazon.com/AmazonS3/latest/userguide/access-control-block-public-access.html">Blocking
    /// public access to your Amazon S3 storage</a> in the <i>Amazon Simple Storage Service
    /// User Guide</i>.
    /// </summary>
    public partial class BlockPublicAccess
    {
        /// <summary>
        /// Gets and sets the property BlockPublicAcls. 
        /// <para>
        /// Specifies whether Amazon S3 blocks public access control lists (ACLs) for the bucket
        /// and objects in the bucket.
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
        /// Specifies whether Amazon S3 blocks public bucket policies for the bucket.
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
        /// Specifies whether Amazon S3 ignores public ACLs for the bucket and objects in the
        /// bucket.
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
        /// Specifies whether Amazon S3 restricts public bucket policies for the bucket.
        /// </para>
        /// </summary>
        public bool? RestrictPublicBuckets { get; set; }

        /// <summary>
        /// Checks to see if the RestrictPublicBuckets property is set.
        /// </summary>
        internal bool IsSetRestrictPublicBuckets() => this.RestrictPublicBuckets.HasValue;
    }
}
