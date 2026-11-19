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

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Information about a Client VPN endpoint route.
    /// </summary>
    public partial class ClientVpnRoute
    {
        /// <summary>
        /// Gets and sets the property ClientVpnEndpointId. 
        /// <para>
        /// The ID of the Client VPN endpoint with which the route is associated.
        /// </para>
        /// </summary>
        public string ClientVpnEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the ClientVpnEndpointId property is set.
        /// </summary>
        internal bool IsSetClientVpnEndpointId() => this.ClientVpnEndpointId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of the route.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DestinationCidr. 
        /// <para>
        /// The IPv4 address range, in CIDR notation, of the route destination.
        /// </para>
        /// </summary>
        public string DestinationCidr { get; set; }

        /// <summary>
        /// Checks to see if the DestinationCidr property is set.
        /// </summary>
        internal bool IsSetDestinationCidr() => this.DestinationCidr != null;

        /// <summary>
        /// Gets and sets the property Origin. 
        /// <para>
        /// Indicates how the route was associated with the Client VPN endpoint. <c>associate</c>
        /// indicates that the route was automatically added when the target network was associated
        /// with the Client VPN endpoint. <c>add-route</c> indicates that the route was manually
        /// added using the <b>CreateClientVpnRoute</b> action.
        /// </para>
        /// </summary>
        public string Origin { get; set; }

        /// <summary>
        /// Checks to see if the Origin property is set.
        /// </summary>
        internal bool IsSetOrigin() => this.Origin != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current state of the route.
        /// </para>
        /// </summary>
        public ClientVpnRouteStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TargetSubnet. 
        /// <para>
        /// The ID of the subnet through which traffic is routed.
        /// </para>
        /// </summary>
        public string TargetSubnet { get; set; }

        /// <summary>
        /// Checks to see if the TargetSubnet property is set.
        /// </summary>
        internal bool IsSetTargetSubnet() => this.TargetSubnet != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayAttachmentId. 
        /// <para>
        /// The ID of the Transit Gateway attachment, if the route targets a Transit Gateway.
        /// </para>
        /// </summary>
        public string TransitGatewayAttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayAttachmentId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayAttachmentId() => this.TransitGatewayAttachmentId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The route type.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
