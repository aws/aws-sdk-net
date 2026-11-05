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
    /// Contains information on how the bucker owner's S3 Block Public Access settings are
    /// being applied to the S3 bucket. See <a href="https://docs.aws.amazon.com/AmazonS3/latest/dev/access-control-block-public-access.html">S3
    /// Block Public Access</a> for more information.
    /// </summary>
    public partial class BlockPublicAccess
    {
        /// <summary>
        /// Gets and sets the property BlockPublicAcls. 
        /// <para>
        /// Indicates if S3 Block Public Access is set to <c>BlockPublicAcls</c>.
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
        /// Indicates if S3 Block Public Access is set to <c>BlockPublicPolicy</c>.
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
        /// Indicates if S3 Block Public Access is set to <c>IgnorePublicAcls</c>.
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
        /// Indicates if S3 Block Public Access is set to <c>RestrictPublicBuckets</c>.
        /// </para>
        /// </summary>
        public bool? RestrictPublicBuckets { get; set; }

        /// <summary>
        /// Checks to see if the RestrictPublicBuckets property is set.
        /// </summary>
        internal bool IsSetRestrictPublicBuckets() => this.RestrictPublicBuckets.HasValue;
    }
}
