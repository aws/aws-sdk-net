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
    /// This is the response object from the GetVpnTunnelReplacementStatus operation.
    /// </summary>
    public partial class GetVpnTunnelReplacementStatusResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property CustomerGatewayId. 
        /// <para>
        /// The ID of the customer gateway.
        /// </para>
        /// </summary>
        public string CustomerGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the CustomerGatewayId property is set.
        /// </summary>
        internal bool IsSetCustomerGatewayId() => this.CustomerGatewayId != null;

        /// <summary>
        /// Gets and sets the property MaintenanceDetails. 
        /// <para>
        /// Get details of pending tunnel endpoint maintenance.
        /// </para>
        /// </summary>
        public MaintenanceDetails MaintenanceDetails { get; set; }

        /// <summary>
        /// Checks to see if the MaintenanceDetails property is set.
        /// </summary>
        internal bool IsSetMaintenanceDetails() => this.MaintenanceDetails != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayId. 
        /// <para>
        /// The ID of the transit gateway associated with the VPN connection.
        /// </para>
        /// </summary>
        public string TransitGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayId() => this.TransitGatewayId != null;

        /// <summary>
        /// Gets and sets the property VpnConnectionId. 
        /// <para>
        /// The ID of the Site-to-Site VPN connection. 
        /// </para>
        /// </summary>
        public string VpnConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the VpnConnectionId property is set.
        /// </summary>
        internal bool IsSetVpnConnectionId() => this.VpnConnectionId != null;

        /// <summary>
        /// Gets and sets the property VpnGatewayId. 
        /// <para>
        /// The ID of the virtual private gateway.
        /// </para>
        /// </summary>
        public string VpnGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the VpnGatewayId property is set.
        /// </summary>
        internal bool IsSetVpnGatewayId() => this.VpnGatewayId != null;

        /// <summary>
        /// Gets and sets the property VpnTunnelOutsideIpAddress. 
        /// <para>
        /// The external IP address of the VPN tunnel.
        /// </para>
        /// </summary>
        public string VpnTunnelOutsideIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the VpnTunnelOutsideIpAddress property is set.
        /// </summary>
        internal bool IsSetVpnTunnelOutsideIpAddress() => this.VpnTunnelOutsideIpAddress != null;
    }
}
