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

namespace Amazon.AccessAnalyzer.Model
{
    /// <summary>
    /// The <c>PublicAccessBlock</c> configuration to apply to this Amazon S3 bucket. If the
    /// proposed configuration is for an existing Amazon S3 bucket and the configuration is
    /// not specified, the access preview uses the existing setting. If the proposed configuration
    /// is for a new bucket and the configuration is not specified, the access preview uses
    /// <c>false</c>. If the proposed configuration is for a new access point or multi-region
    /// access point and the access point BPA configuration is not specified, the access preview
    /// uses <c>true</c>. For more information, see <a href="https://docs.aws.amazon.com/AWSCloudFormation/latest/UserGuide/aws-properties-s3-bucket-publicaccessblockconfiguration.html">PublicAccessBlockConfiguration</a>.
    /// </summary>
    public partial class S3PublicAccessBlockConfiguration
    {
        /// <summary>
        /// Gets and sets the property IgnorePublicAcls. 
        /// <para>
        ///  Specifies whether Amazon S3 should ignore public ACLs for this bucket and objects
        /// in this bucket. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? IgnorePublicAcls { get; set; }

        /// <summary>
        /// Checks to see if the IgnorePublicAcls property is set.
        /// </summary>
        internal bool IsSetIgnorePublicAcls() => this.IgnorePublicAcls.HasValue;

        /// <summary>
        /// Gets and sets the property RestrictPublicBuckets. 
        /// <para>
        ///  Specifies whether Amazon S3 should restrict public bucket policies for this bucket.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public bool? RestrictPublicBuckets { get; set; }

        /// <summary>
        /// Checks to see if the RestrictPublicBuckets property is set.
        /// </summary>
        internal bool IsSetRestrictPublicBuckets() => this.RestrictPublicBuckets.HasValue;
    }
}
