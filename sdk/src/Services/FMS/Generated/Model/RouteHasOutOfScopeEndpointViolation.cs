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
 * Do not modify this file. This file is generated from the fms-2018-01-01.normal.json service model.
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
        private string _currentFirewallSubnetRouteTable;
        private string _currentInternetGatewayRouteTable;
        private string _firewallSubnetId;
        private List<Route> _firewallSubnetRoutes = AWSConfigs.InitializeCollections ? new List<Route>() : null;
        private string _internetGatewayId;
        private List<Route> _internetGatewayRoutes = AWSConfigs.InitializeCollections ? new List<Route>() : null;
        private string _routeTableId;
        private string _subnetAvailabilityZone;
        private string _subnetAvailabilityZoneId;
        private string _subnetId;
        private List<Route> _violatingRoutes = AWSConfigs.InitializeCollections ? new List<Route>() : null;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property CurrentFirewallSubnetRouteTable. 
        /// <para>
        /// The route table associated with the current firewall subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string CurrentFirewallSubnetRouteTable
        {
            get { return this._currentFirewallSubnetRouteTable; }
            set { this._currentFirewallSubnetRouteTable = value; }
        }

        // Check to see if CurrentFirewallSubnetRouteTable property is set
        internal bool IsSetCurrentFirewallSubnetRouteTable()
        {
            return this._currentFirewallSubnetRouteTable != null;
        }

        /// <summary>
        /// Gets and sets the property CurrentInternetGatewayRouteTable. 
        /// <para>
        /// The current route table associated with the Internet Gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string CurrentInternetGatewayRouteTable
        {
            get { return this._currentInternetGatewayRouteTable; }
            set { this._currentInternetGatewayRouteTable = value; }
        }

        // Check to see if CurrentInternetGatewayRouteTable property is set
        internal bool IsSetCurrentInternetGatewayRouteTable()
        {
            return this._currentInternetGatewayRouteTable != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallSubnetId. 
        /// <para>
        /// The ID of the firewall subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string FirewallSubnetId
        {
            get { return this._firewallSubnetId; }
            set { this._firewallSubnetId = value; }
        }

        // Check to see if FirewallSubnetId property is set
        internal bool IsSetFirewallSubnetId()
        {
            return this._firewallSubnetId != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallSubnetRoutes. 
        /// <para>
        /// The list of firewall subnet routes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Route> FirewallSubnetRoutes
        {
            get { return this._firewallSubnetRoutes; }
            set { this._firewallSubnetRoutes = value; }
        }

        // Check to see if FirewallSubnetRoutes property is set
        internal bool IsSetFirewallSubnetRoutes()
        {
            return this._firewallSubnetRoutes != null && (this._firewallSubnetRoutes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InternetGatewayId. 
        /// <para>
        /// The ID of the Internet Gateway.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string InternetGatewayId
        {
            get { return this._internetGatewayId; }
            set { this._internetGatewayId = value; }
        }

        // Check to see if InternetGatewayId property is set
        internal bool IsSetInternetGatewayId()
        {
            return this._internetGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property InternetGatewayRoutes. 
        /// <para>
        /// The routes in the route table associated with the Internet Gateway.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Route> InternetGatewayRoutes
        {
            get { return this._internetGatewayRoutes; }
            set { this._internetGatewayRoutes = value; }
        }

        // Check to see if InternetGatewayRoutes property is set
        internal bool IsSetInternetGatewayRoutes()
        {
            return this._internetGatewayRoutes != null && (this._internetGatewayRoutes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RouteTableId. 
        /// <para>
        /// The ID of the route table.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string RouteTableId
        {
            get { return this._routeTableId; }
            set { this._routeTableId = value; }
        }

        // Check to see if RouteTableId property is set
        internal bool IsSetRouteTableId()
        {
            return this._routeTableId != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetAvailabilityZone. 
        /// <para>
        /// The subnet's Availability Zone.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string SubnetAvailabilityZone
        {
            get { return this._subnetAvailabilityZone; }
            set { this._subnetAvailabilityZone = value; }
        }

        // Check to see if SubnetAvailabilityZone property is set
        internal bool IsSetSubnetAvailabilityZone()
        {
            return this._subnetAvailabilityZone != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetAvailabilityZoneId. 
        /// <para>
        /// The ID of the subnet's Availability Zone.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string SubnetAvailabilityZoneId
        {
            get { return this._subnetAvailabilityZoneId; }
            set { this._subnetAvailabilityZoneId = value; }
        }

        // Check to see if SubnetAvailabilityZoneId property is set
        internal bool IsSetSubnetAvailabilityZoneId()
        {
            return this._subnetAvailabilityZoneId != null;
        }

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet associated with the route that violates the policy scope.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string SubnetId
        {
            get { return this._subnetId; }
            set { this._subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this._subnetId != null;
        }

        /// <summary>
        /// Gets and sets the property ViolatingRoutes. 
        /// <para>
        /// The list of routes that violate the route table.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Route> ViolatingRoutes
        {
            get { return this._violatingRoutes; }
            set { this._violatingRoutes = value; }
        }

        // Check to see if ViolatingRoutes property is set
        internal bool IsSetViolatingRoutes()
        {
            return this._violatingRoutes != null && (this._violatingRoutes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The VPC ID of the route that violates the policy scope.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}