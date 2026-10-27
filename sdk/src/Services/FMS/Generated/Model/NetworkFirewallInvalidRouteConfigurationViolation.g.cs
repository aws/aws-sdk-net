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
    /// Violation detail for the improperly configured subnet route. It's possible there is
    /// a missing route table route, or a configuration that causes traffic to cross an Availability
    /// Zone boundary.
    /// </summary>
    public partial class NetworkFirewallInvalidRouteConfigurationViolation
    {
        /// <summary>
        /// Gets and sets the property ActualFirewallEndpoint. 
        /// <para>
        /// The actual firewall endpoint.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ActualFirewallEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ActualFirewallEndpoint property is set.
        /// </summary>
        internal bool IsSetActualFirewallEndpoint() => this.ActualFirewallEndpoint != null;

        /// <summary>
        /// Gets and sets the property ActualFirewallSubnetId. 
        /// <para>
        /// The actual subnet ID for the firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ActualFirewallSubnetId { get; set; }

        /// <summary>
        /// Checks to see if the ActualFirewallSubnetId property is set.
        /// </summary>
        internal bool IsSetActualFirewallSubnetId() => this.ActualFirewallSubnetId != null;

        /// <summary>
        /// Gets and sets the property ActualFirewallSubnetRoutes. 
        /// <para>
        /// The actual firewall subnet routes that are expected.
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
        /// Gets and sets the property AffectedSubnets. 
        /// <para>
        /// The subnets that are affected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AffectedSubnets { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AffectedSubnets property is set.
        /// </summary>
        internal bool IsSetAffectedSubnets() => this.AffectedSubnets != null && (this.AffectedSubnets.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property CurrentFirewallSubnetRouteTable. 
        /// <para>
        /// The subnet route table for the current firewall.
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
        /// The route table for the current internet gateway.
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
        /// The firewall endpoint that's expected.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ExpectedFirewallEndpoint { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedFirewallEndpoint property is set.
        /// </summary>
        internal bool IsSetExpectedFirewallEndpoint() => this.ExpectedFirewallEndpoint != null;

        /// <summary>
        /// Gets and sets the property ExpectedFirewallSubnetId. 
        /// <para>
        /// The expected subnet ID for the firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ExpectedFirewallSubnetId { get; set; }

        /// <summary>
        /// Checks to see if the ExpectedFirewallSubnetId property is set.
        /// </summary>
        internal bool IsSetExpectedFirewallSubnetId() => this.ExpectedFirewallSubnetId != null;

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
        /// The expected routes for the internet gateway.
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
        /// The route table ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string RouteTableId { get; set; }

        /// <summary>
        /// Checks to see if the RouteTableId property is set.
        /// </summary>
        internal bool IsSetRouteTableId() => this.RouteTableId != null;

        /// <summary>
        /// Gets and sets the property ViolatingRoute. 
        /// <para>
        /// The route that's in violation.
        /// </para>
        /// </summary>
        public Route ViolatingRoute { get; set; }

        /// <summary>
        /// Checks to see if the ViolatingRoute property is set.
        /// </summary>
        internal bool IsSetViolatingRoute() => this.ViolatingRoute != null;

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
