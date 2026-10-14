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
    /// The violation details for a third-party firewall that's not associated with an Firewall
    /// Manager managed route table.
    /// </summary>
    public partial class ThirdPartyFirewallMissingExpectedRouteTableViolation
    {
        /// <summary>
        /// Gets and sets the property AvailabilityZone. 
        /// <para>
        /// The Availability Zone of the firewall subnet that's causing the violation.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string AvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the AvailabilityZone property is set.
        /// </summary>
        internal bool IsSetAvailabilityZone() => this.AvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property CurrentRouteTable. 
        /// <para>
        /// The resource ID of the current route table that's associated with the subnet, if one
        /// is available.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string CurrentRouteTable { get; set; }

        /// <summary>
        /// Checks to see if the CurrentRouteTable property is set.
        /// </summary>
        internal bool IsSetCurrentRouteTable() => this.CurrentRouteTable != null;

        /// <summary>
        /// Gets and sets the property ExpectedRouteTable. 
        /// <para>
        /// The resource ID of the route table that should be associated with the subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ExpectedRouteTable { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedRouteTable property is set.
        /// </summary>
        internal bool IsSetExpectedRouteTable() => this.ExpectedRouteTable != null;

        /// <summary>
        /// Gets and sets the property VPC. 
        /// <para>
        /// The resource ID of the VPC associated with a fireawll subnet that's causing the violation.
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
        /// The ID of the third-party firewall or VPC resource that's causing the violation.
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
