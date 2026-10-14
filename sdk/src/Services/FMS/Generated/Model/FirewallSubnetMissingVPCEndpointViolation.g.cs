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
    /// The violation details for a firewall subnet's VPC endpoint that's deleted or missing.
    /// </summary>
    public partial class FirewallSubnetMissingVPCEndpointViolation
    {
        /// <summary>
        /// Gets and sets the property FirewallSubnetId. 
        /// <para>
        /// The ID of the firewall that this VPC endpoint is associated with.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string FirewallSubnetId { get; set; }

        /// <summary>
        /// Checks to see if the FirewallSubnetId property is set.
        /// </summary>
        internal bool IsSetFirewallSubnetId() => this.FirewallSubnetId != null;

        /// <summary>
        /// Gets and sets the property SubnetAvailabilityZone. 
        /// <para>
        /// The name of the Availability Zone of the deleted VPC subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string SubnetAvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the SubnetAvailabilityZone property is set.
        /// </summary>
        internal bool IsSetSubnetAvailabilityZone() => this.SubnetAvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property SubnetAvailabilityZoneId. 
        /// <para>
        /// The ID of the Availability Zone of the deleted VPC subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string SubnetAvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetAvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetSubnetAvailabilityZoneId() => this.SubnetAvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The resource ID of the VPC associated with the deleted VPC subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
