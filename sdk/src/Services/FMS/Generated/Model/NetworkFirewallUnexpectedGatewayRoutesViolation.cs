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

namespace Amazon.FMS.Model
{
    /// <summary>
    /// Violation detail for an unexpected gateway route that’s present in a route table.
    /// </summary>
    public partial class NetworkFirewallUnexpectedGatewayRoutesViolation
    {
        private string _gatewayId;
        private string _routeTableId;
        private List<Route> _violatingRoutes = new List<Route>();
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property GatewayId. 
        /// <para>
        /// Information about the gateway ID.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string GatewayId
        {
            get { return this._gatewayId; }
            set { this._gatewayId = value; }
        }

        // Check to see if GatewayId property is set
        internal bool IsSetGatewayId()
        {
            return this._gatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property RouteTableId. 
        /// <para>
        /// Information about the route table.
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
        /// </summary>
        public List<Route> ViolatingRoutes
        {
            get { return this._violatingRoutes; }
            set { this._violatingRoutes = value; }
        }

        // Check to see if ViolatingRoutes property is set
        internal bool IsSetViolatingRoutes()
        {
            return this._violatingRoutes != null && this._violatingRoutes.Count > 0; 
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