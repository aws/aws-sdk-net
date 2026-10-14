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
    /// Contains details about the route endpoint that violates the policy scope.
    /// </summary>
    public partial class RouteHasOutOfScopeEndpointViolation
    {
        /// <summary>
        /// Gets and sets the property CurrentFirewallSubnetRouteTable. 
        /// <para>
        /// The route table associated with the current firewall subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string CurrentFirewallSubnetRouteTable { get; set; }

        /// <summary>
        /// Checks to see if the CurrentFirewallSubnetRouteTable property is set.
        /// </summary>
        internal bool IsSetCurrentFirewallSubnetRouteTable() => this.CurrentFirewallSubnetRouteTable != null;

        /// <summary>
        /// Gets and sets the property CurrentInternetGatewayRouteTable. 
        /// <para>
        /// The current route table associated with the Internet Gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string CurrentInternetGatewayRouteTable { get; set; }

        /// <summary>
        /// Checks to see if the CurrentInternetGatewayRouteTable property is set.
        /// </summary>
        internal bool IsSetCurrentInternetGatewayRouteTable() => this.CurrentInternetGatewayRouteTable != null;

        /// <summary>
        /// Gets and sets the property FirewallSubnetId. 
        /// <para>
        /// The ID of the firewall subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string FirewallSubnetId { get; set; }

        /// <summary>
        /// Checks to see if the FirewallSubnetId property is set.
        /// </summary>
        internal bool IsSetFirewallSubnetId() => this.FirewallSubnetId != null;

        /// <summary>
        /// Gets and sets the property FirewallSubnetRoutes. 
        /// <para>
        /// The list of firewall subnet routes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Route> FirewallSubnetRoutes { get; set; } = AWSConfigs.InitializeCollections ? new List<Route>() : null;

        /// <summary>
        /// Checks to see if the FirewallSubnetRoutes property is set.
        /// </summary>
        internal bool IsSetFirewallSubnetRoutes() => this.FirewallSubnetRoutes != null && (this.FirewallSubnetRoutes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InternetGatewayId. 
        /// <para>
        /// The ID of the Internet Gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string InternetGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the InternetGatewayId property is set.
        /// </summary>
        internal bool IsSetInternetGatewayId() => this.InternetGatewayId != null;

        /// <summary>
        /// Gets and sets the property InternetGatewayRoutes. 
        /// <para>
        /// The routes in the route table associated with the Internet Gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Route> InternetGatewayRoutes { get; set; } = AWSConfigs.InitializeCollections ? new List<Route>() : null;

        /// <summary>
        /// Checks to see if the InternetGatewayRoutes property is set.
        /// </summary>
        internal bool IsSetInternetGatewayRoutes() => this.InternetGatewayRoutes != null && (this.InternetGatewayRoutes.Count > 0 || !AWSConfigs.InitializeCollections);

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
        /// Gets and sets the property SubnetAvailabilityZone. 
        /// <para>
        /// The subnet's Availability Zone.
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
        /// The ID of the subnet's Availability Zone.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string SubnetAvailabilityZoneId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetAvailabilityZoneId property is set.
        /// </summary>
        internal bool IsSetSubnetAvailabilityZoneId() => this.SubnetAvailabilityZoneId != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet associated with the route that violates the policy scope.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property ViolatingRoutes. 
        /// <para>
        /// The list of routes that violate the route table.
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
        /// The VPC ID of the route that violates the policy scope.
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
