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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes a route table.
    /// </summary>
    public partial class RouteTableIdentifier
    {
        private CoreNetworkNetworkFunctionGroupIdentifier _coreNetworkNetworkFunctionGroup;
        private CoreNetworkSegmentEdgeIdentifier _coreNetworkSegmentEdge;
        private string _transitGatewayRouteTableArn;

        /// <summary>
        /// Gets and sets the property CoreNetworkNetworkFunctionGroup. 
        /// <para>
        /// The route table identifier associated with the network function group.
        /// </para>
        /// </summary>
        public CoreNetworkNetworkFunctionGroupIdentifier CoreNetworkNetworkFunctionGroup
        {
            get { return this._coreNetworkNetworkFunctionGroup; }
            set { this._coreNetworkNetworkFunctionGroup = value; }
        }

        // Check to see if CoreNetworkNetworkFunctionGroup property is set
        internal bool IsSetCoreNetworkNetworkFunctionGroup()
        {
            return this._coreNetworkNetworkFunctionGroup != null;
        }

        /// <summary>
        /// Gets and sets the property CoreNetworkSegmentEdge. 
        /// <para>
        /// The segment edge in a core network.
        /// </para>
        /// </summary>
        public CoreNetworkSegmentEdgeIdentifier CoreNetworkSegmentEdge
        {
            get { return this._coreNetworkSegmentEdge; }
            set { this._coreNetworkSegmentEdge = value; }
        }

        // Check to see if CoreNetworkSegmentEdge property is set
        internal bool IsSetCoreNetworkSegmentEdge()
        {
            return this._coreNetworkSegmentEdge != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayRouteTableArn. 
        /// <para>
        /// The ARN of the transit gateway route table for the attachment request. For example,
        /// <c>"TransitGatewayRouteTableArn": "arn:aws:ec2:us-west-2:123456789012:transit-gateway-route-table/tgw-rtb-9876543210123456"</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string TransitGatewayRouteTableArn
        {
            get { return this._transitGatewayRouteTableArn; }
            set { this._transitGatewayRouteTableArn = value; }
        }

        // Check to see if TransitGatewayRouteTableArn property is set
        internal bool IsSetTransitGatewayRouteTableArn()
        {
            return this._transitGatewayRouteTableArn != null;
        }

    }
}