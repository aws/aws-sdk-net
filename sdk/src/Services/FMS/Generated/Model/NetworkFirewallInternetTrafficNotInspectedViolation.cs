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
    /// Violation detail for the subnet for which internet traffic that hasn't been inspected.
    /// </summary>
    public partial class NetworkFirewallInternetTrafficNotInspectedViolation
    {
        private List<Route> _actualFirewallSubnetRoutes = AWSConfigs.InitializeCollections ? new List<Route>() : null;
        private List<Route> _actualInternetGatewayRoutes = AWSConfigs.InitializeCollections ? new List<Route>() : null;
        private string _currentFirewallSubnetRouteTable;
        private string _currentInternetGatewayRouteTable;
        private string _expectedFirewallEndpoint;
        private List<ExpectedRoute> _expectedFirewallSubnetRoutes = AWSConfigs.InitializeCollections ? new List<ExpectedRoute>() : null;
        private List<ExpectedRoute> _expectedInternetGatewayRoutes = AWSConfigs.InitializeCollections ? new List<ExpectedRoute>() : null;
        private string _firewallSubnetId;
        private string _internetGatewayId;
        private bool? _isRouteTableUsedInDifferentAZ;
        private string _routeTableId;
        private string _subnetAvailabilityZone;
        private string _subnetId;
        private List<Route> _violatingRoutes = AWSConfigs.InitializeCollections ? new List<Route>() : null;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property ActualFirewallSubnetRoutes. 
        /// <para>
        /// The actual firewall subnet routes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Route> ActualFirewallSubnetRoutes
        {
            get { return this._actualFirewallSubnetRoutes; }
            set { this._actualFirewallSubnetRoutes = value; }
        }

        // Check to see if ActualFirewallSubnetRoutes property is set
        internal bool IsSetActualFirewallSubnetRoutes()
        {
            return this._actualFirewallSubnetRoutes != null && (this._actualFirewallSubnetRoutes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ActualInternetGatewayRoutes. 
        /// <para>
        /// The actual internet gateway routes.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Route> ActualInternetGatewayRoutes
        {
            get { return this._actualInternetGatewayRoutes; }
            set { this._actualInternetGatewayRoutes = value; }
        }

        // Check to see if ActualInternetGatewayRoutes property is set
        internal bool IsSetActualInternetGatewayRoutes()
        {
            return this._actualInternetGatewayRoutes != null && (this._actualInternetGatewayRoutes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CurrentFirewallSubnetRouteTable. 
        /// <para>
        /// Information about the subnet route table for the current firewall.
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
        /// The current route table for the internet gateway.
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
        /// Gets and sets the property ExpectedFirewallEndpoint. 
        /// <para>
        /// The expected endpoint for the current firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ExpectedFirewallEndpoint
        {
            get { return this._expectedFirewallEndpoint; }
            set { this._expectedFirewallEndpoint = value; }
        }

        // Check to see if ExpectedFirewallEndpoint property is set
        internal bool IsSetExpectedFirewallEndpoint()
        {
            return this._expectedFirewallEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property ExpectedFirewallSubnetRoutes. 
        /// <para>
        /// The firewall subnet routes that are expected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExpectedRoute> ExpectedFirewallSubnetRoutes
        {
            get { return this._expectedFirewallSubnetRoutes; }
            set { this._expectedFirewallSubnetRoutes = value; }
        }

        // Check to see if ExpectedFirewallSubnetRoutes property is set
        internal bool IsSetExpectedFirewallSubnetRoutes()
        {
            return this._expectedFirewallSubnetRoutes != null && (this._expectedFirewallSubnetRoutes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property ExpectedInternetGatewayRoutes. 
        /// <para>
        /// The internet gateway routes that are expected.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ExpectedRoute> ExpectedInternetGatewayRoutes
        {
            get { return this._expectedInternetGatewayRoutes; }
            set { this._expectedInternetGatewayRoutes = value; }
        }

        // Check to see if ExpectedInternetGatewayRoutes property is set
        internal bool IsSetExpectedInternetGatewayRoutes()
        {
            return this._expectedInternetGatewayRoutes != null && (this._expectedInternetGatewayRoutes.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FirewallSubnetId. 
        /// <para>
        /// The firewall subnet ID.
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
        /// Gets and sets the property InternetGatewayId. 
        /// <para>
        /// The internet gateway ID.
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
        /// Gets and sets the property IsRouteTableUsedInDifferentAZ. 
        /// <para>
        /// Information about whether the route table is used in another Availability Zone.
        /// </para>
        /// </summary>
        public bool? IsRouteTableUsedInDifferentAZ
        {
            get { return this._isRouteTableUsedInDifferentAZ; }
            set { this._isRouteTableUsedInDifferentAZ = value; }
        }

        // Check to see if IsRouteTableUsedInDifferentAZ property is set
        internal bool IsSetIsRouteTableUsedInDifferentAZ()
        {
            return this._isRouteTableUsedInDifferentAZ.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RouteTableId. 
        /// <para>
        /// Information about the route table ID.
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
        /// The subnet Availability Zone.
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
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The subnet ID.
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
        /// The route or routes that are in violation.
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
        /// Information about the VPC ID.
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