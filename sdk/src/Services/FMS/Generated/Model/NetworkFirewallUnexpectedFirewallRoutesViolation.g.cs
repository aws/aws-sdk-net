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
    /// Violation detail for an unexpected route that's present in a route table.
    /// </summary>
    public partial class NetworkFirewallUnexpectedFirewallRoutesViolation
    {
        /// <summary>
        /// Gets and sets the property FirewallEndpoint. 
        /// <para>
        /// The endpoint of the firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string FirewallEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the FirewallEndpoint property is set.
        /// </summary>
        internal bool IsSetFirewallEndpoint() => this.FirewallEndpoint != null;

        /// <summary>
        /// Gets and sets the property FirewallSubnetId. 
        /// <para>
        /// The subnet ID for the firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string FirewallSubnetId { get; set; }

        /// <summary>
        /// Checks to see if the FirewallSubnetId property is set.
        /// </summary>
        internal bool IsSetFirewallSubnetId() => this.FirewallSubnetId != null;

        /// <summary>
        /// Gets and sets the property RouteTableId. 
        /// <para>
        /// The ID of the route table.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string RouteTableId { get; set; }

        /// <summary>
        /// Checks to see if the RouteTableId property is set.
        /// </summary>
        internal bool IsSetRouteTableId() => this.RouteTableId != null;

        /// <summary>
        /// Gets and sets the property ViolatingRoutes. 
        /// <para>
        /// The routes that are in violation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Route> ViolatingRoutes { get; set; } = AWSConfigs.InitializeCollections ? new List<Route>() : null;

        /// <summary>
        /// Checks to see if the ViolatingRoutes property is set.
        /// </summary>
        internal bool IsSetViolatingRoutes() => this.ViolatingRoutes != null && (this.ViolatingRoutes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// Information about the VPC ID.
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
