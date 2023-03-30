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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// This is the response object from the GetVpnTunnelReplacementStatus operation.
    /// </summary>
    public partial class GetVpnTunnelReplacementStatusResponse : AmazonWebServiceResponse
    {
        private string _customerGatewayId;
        private MaintenanceDetails _maintenanceDetails;
        private string _transitGatewayId;
        private string _vpnConnectionId;
        private string _vpnGatewayId;
        private string _vpnTunnelOutsideIpAddress;

        /// <summary>
        /// Gets and sets the property CustomerGatewayId. 
        /// <para>
        /// The ID of the customer gateway.
        /// </para>
        /// </summary>
        public string CustomerGatewayId
        {
            get { return this._customerGatewayId; }
            set { this._customerGatewayId = value; }
        }

        // Check to see if CustomerGatewayId property is set
        internal bool IsSetCustomerGatewayId()
        {
            return this._customerGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property MaintenanceDetails. 
        /// <para>
        /// Get details of pending tunnel endpoint maintenance.
        /// </para>
        /// </summary>
        public MaintenanceDetails MaintenanceDetails
        {
            get { return this._maintenanceDetails; }
            set { this._maintenanceDetails = value; }
        }

        // Check to see if MaintenanceDetails property is set
        internal bool IsSetMaintenanceDetails()
        {
            return this._maintenanceDetails != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayId. 
        /// <para>
        /// The ID of the transit gateway associated with the VPN connection.
        /// </para>
        /// </summary>
        public string TransitGatewayId
        {
            get { return this._transitGatewayId; }
            set { this._transitGatewayId = value; }
        }

        // Check to see if TransitGatewayId property is set
        internal bool IsSetTransitGatewayId()
        {
            return this._transitGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property VpnConnectionId. 
        /// <para>
        /// The ID of the Site-to-Site VPN connection. 
        /// </para>
        /// </summary>
        public string VpnConnectionId
        {
            get { return this._vpnConnectionId; }
            set { this._vpnConnectionId = value; }
        }

        // Check to see if VpnConnectionId property is set
        internal bool IsSetVpnConnectionId()
        {
            return this._vpnConnectionId != null;
        }

        /// <summary>
        /// Gets and sets the property VpnGatewayId. 
        /// <para>
        /// The ID of the virtual private gateway.
        /// </para>
        /// </summary>
        public string VpnGatewayId
        {
            get { return this._vpnGatewayId; }
            set { this._vpnGatewayId = value; }
        }

        // Check to see if VpnGatewayId property is set
        internal bool IsSetVpnGatewayId()
        {
            return this._vpnGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property VpnTunnelOutsideIpAddress. 
        /// <para>
        /// The external IP address of the VPN tunnel.
        /// </para>
        /// </summary>
        public string VpnTunnelOutsideIpAddress
        {
            get { return this._vpnTunnelOutsideIpAddress; }
            set { this._vpnTunnelOutsideIpAddress = value; }
        }

        // Check to see if VpnTunnelOutsideIpAddress property is set
        internal bool IsSetVpnTunnelOutsideIpAddress()
        {
            return this._vpnTunnelOutsideIpAddress != null;
        }

    }
}