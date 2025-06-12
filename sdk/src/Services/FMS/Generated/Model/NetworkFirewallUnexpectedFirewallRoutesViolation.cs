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
    /// Violation detail for an unexpected route that's present in a route table.
    /// </summary>
    public partial class NetworkFirewallUnexpectedFirewallRoutesViolation
    {
        private string _firewallEndpoint;
        private string _firewallSubnetId;
        private string _routeTableId;
        private List<Route> _violatingRoutes = AWSConfigs.InitializeCollections ? new List<Route>() : null;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property FirewallEndpoint. 
        /// <para>
        /// The endpoint of the firewall.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string FirewallEndpoint
        {
            get { return this._firewallEndpoint; }
            set { this._firewallEndpoint = value; }
        }

        // Check to see if FirewallEndpoint property is set
        internal bool IsSetFirewallEndpoint()
        {
            return this._firewallEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property FirewallSubnetId. 
        /// <para>
        /// The subnet ID for the firewall.
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
        /// Gets and sets the property ViolatingRoutes. 
        /// <para>
        /// The routes that are in violation.
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