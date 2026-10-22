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

namespace Amazon.Drs.Model
{
    /// <summary>
    /// Properties of the cloud environment where this Source Server originated from.
    /// </summary>
    public partial class SourceCloudProperties
    {
        /// <summary>
        /// Gets and sets the property OriginAccountID. 
        /// <para>
        /// AWS Account ID for an EC2-originated Source Server.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 12, Max = 12)]
        public string OriginAccountID { get; set; }

        /// <summary>
        /// Checks to see if the OriginAccountID property is set.
        /// </summary>
        internal bool IsSetOriginAccountID() => this.OriginAccountID != null;

        /// <summary>
        /// Gets and sets the property OriginAvailabilityZone. 
        /// <para>
        /// AWS Availability Zone for an EC2-originated Source Server.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string OriginAvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the OriginAvailabilityZone property is set.
        /// </summary>
        internal bool IsSetOriginAvailabilityZone() => this.OriginAvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property OriginRegion. 
        /// <para>
        /// AWS Region for an EC2-originated Source Server.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 255)]
        public string OriginRegion { get; set; }

        /// <summary>
        /// Checks to see if the OriginRegion property is set.
        /// </summary>
        internal bool IsSetOriginRegion() => this.OriginRegion != null;

        /// <summary>
        /// Gets and sets the property SourceOutpostArn. 
        /// <para>
        /// The ARN of the source Outpost
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 255)]
        public string SourceOutpostArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceOutpostArn property is set.
        /// </summary>
        internal bool IsSetSourceOutpostArn() => this.SourceOutpostArn != null;
    }
}
