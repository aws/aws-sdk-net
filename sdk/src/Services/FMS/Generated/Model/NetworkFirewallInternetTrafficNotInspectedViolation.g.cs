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
    /// Violation detail for the subnet for which internet traffic that hasn't been inspected.
    /// </summary>
    public partial class NetworkFirewallInternetTrafficNotInspectedViolation
    {
        /// <summary>
        /// Gets and sets the property ActualFirewallSubnetRoutes. 
        /// <para>
        /// The actual firewall subnet routes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Route> ActualFirewallSubnetRoutes { get; set; } = AWSConfigs.InitializeCollections ? new List<Route>() : null;

        /// <summary>
        /// Checks to see if the ActualFirewallSubnetRoutes property is set.
        /// </summary>
        internal bool IsSetActualFirewallSubnetRoutes() => this.ActualFirewallSubnetRoutes != null && (this.ActualFirewallSubnetRoutes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ActualInternetGatewayRoutes. 
        /// <para>
        /// The actual internet gateway routes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Route> ActualInternetGatewayRoutes { get; set; } = AWSConfigs.InitializeCollections ? new List<Route>() : null;

        /// <summary>
        /// Checks to see if the ActualInternetGatewayRoutes property is set.
        /// </summary>
        internal bool IsSetActualInternetGatewayRoutes() => this.ActualInternetGatewayRoutes != null && (this.ActualInternetGatewayRoutes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CurrentFirewallSubnetRouteTable. 
        /// <para>
        /// Information about the subnet route table for the current firewall.
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
        /// The current route table for the internet gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string CurrentInternetGatewayRouteTable { get; set; }

        /// <summary>
        /// Checks to see if the CurrentInternetGatewayRouteTable property is set.
        /// </summary>
        internal bool IsSetCurrentInternetGatewayRouteTable() => this.CurrentInternetGatewayRouteTable != null;

        /// <summary>
        /// Gets and sets the property ExpectedFirewallEndpoint. 
        /// <para>
        /// The expected endpoint for the current firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ExpectedFirewallEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedFirewallEndpoint property is set.
        /// </summary>
        internal bool IsSetExpectedFirewallEndpoint() => this.ExpectedFirewallEndpoint != null;

        /// <summary>
        /// Gets and sets the property ExpectedFirewallSubnetRoutes. 
        /// <para>
        /// The firewall subnet routes that are expected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExpectedRoute> ExpectedFirewallSubnetRoutes { get; set; } = AWSConfigs.InitializeCollections ? new List<ExpectedRoute>() : null;

        /// <summary>
        /// Checks to see if the ExpectedFirewallSubnetRoutes property is set.
        /// </summary>
        internal bool IsSetExpectedFirewallSubnetRoutes() => this.ExpectedFirewallSubnetRoutes != null && (this.ExpectedFirewallSubnetRoutes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property ExpectedInternetGatewayRoutes. 
        /// <para>
        /// The internet gateway routes that are expected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExpectedRoute> ExpectedInternetGatewayRoutes { get; set; } = AWSConfigs.InitializeCollections ? new List<ExpectedRoute>() : null;

        /// <summary>
        /// Checks to see if the ExpectedInternetGatewayRoutes property is set.
        /// </summary>
        internal bool IsSetExpectedInternetGatewayRoutes() => this.ExpectedInternetGatewayRoutes != null && (this.ExpectedInternetGatewayRoutes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property FirewallSubnetId. 
        /// <para>
        /// The firewall subnet ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string FirewallSubnetId { get; set; }

        /// <summary>
        /// Checks to see if the FirewallSubnetId property is set.
        /// </summary>
        internal bool IsSetFirewallSubnetId() => this.FirewallSubnetId != null;

        /// <summary>
        /// Gets and sets the property InternetGatewayId. 
        /// <para>
        /// The internet gateway ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string InternetGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the InternetGatewayId property is set.
        /// </summary>
        internal bool IsSetInternetGatewayId() => this.InternetGatewayId != null;

        /// <summary>
        /// Gets and sets the property IsRouteTableUsedInDifferentAZ. 
        /// <para>
        /// Information about whether the route table is used in another Availability Zone.
        /// </para>
        /// </summary>
        public bool? IsRouteTableUsedInDifferentAZ { get; set; }

        /// <summary>
        /// Checks to see if the IsRouteTableUsedInDifferentAZ property is set.
        /// </summary>
        internal bool IsSetIsRouteTableUsedInDifferentAZ() => this.IsRouteTableUsedInDifferentAZ.HasValue;

        /// <summary>
        /// Gets and sets the property RouteTableId. 
        /// <para>
        /// Information about the route table ID.
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
        /// The subnet Availability Zone.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 1024)]
        public string SubnetAvailabilityZone { get; set; }

        /// <summary>
        /// Checks to see if the SubnetAvailabilityZone property is set.
        /// </summary>
        internal bool IsSetSubnetAvailabilityZone() => this.SubnetAvailabilityZone != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The subnet ID.
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
        /// The route or routes that are in violation.
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
