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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// The violation details about a third-party firewall's subnet that doesn't have a Firewall
    /// Manager managed firewall in its VPC.
    /// </summary>
    public partial class ThirdPartyFirewallMissingFirewallViolation
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the third-party firewall that's causing the violation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property TargetViolationReason. 
        /// <para>
        /// The reason the resource is causing this violation, if a reason is available.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string TargetViolationReason { get; set; }

        /// <summary>
        /// Checks to see if the TargetViolationReason property is set.
        /// </summary>
        internal bool IsSetTargetViolationReason() => this.TargetViolationReason != null;

        /// <summary>
        /// Gets and sets the property VPC. 
        /// <para>
        /// The resource ID of the VPC associated with a third-party firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string VPC { get; set; }

        /// <summary>
        /// Checks to see if the VPC property is set.
        /// </summary>
        internal bool IsSetVPC() => this.VPC != null;

        /// <summary>
        /// Gets and sets the property ViolationTarget. 
        /// <para>
        /// The ID of the third-party firewall that's causing the violation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string ViolationTarget { get; set; }

        /// <summary>
        /// Checks to see if the ViolationTarget property is set.
        /// </summary>
        internal bool IsSetViolationTarget() => this.ViolationTarget != null;
    }
}
