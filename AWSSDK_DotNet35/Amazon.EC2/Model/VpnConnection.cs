/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a VPN connection.
    /// </summary>
    public partial class VpnConnection
    {
        private string _customerGatewayConfiguration;
        private string _customerGatewayId;
        private VpnConnectionOptions _options;
        private List<VpnStaticRoute> _routes = new List<VpnStaticRoute>();
        private VpnState _state;
        private List<Tag> _tags = new List<Tag>();
        private GatewayType _type;
        private List<VgwTelemetry> _vgwTelemetry = new List<VgwTelemetry>();
        private string _vpnConnectionId;
        private string _vpnGatewayId;

        /// <summary>
        /// Gets and sets the property CustomerGatewayConfiguration. 
        /// <para>
        /// The configuration information for the VPN connection's customer gateway (in the native
        /// XML format). This element is always present in the <a>CreateVpnConnection</a> response;
        /// however, it's present in the <a>DescribeVpnConnections</a> response only if the VPN
        /// connection is in the <code>pending</code> or <code>available</code> state.
        /// </para>
        /// </summary>
        public string CustomerGatewayConfiguration
        {
            get { return this._customerGatewayConfiguration; }
            set { this._customerGatewayConfiguration = value; }
        }

        // Check to see if CustomerGatewayConfiguration property is set
        internal bool IsSetCustomerGatewayConfiguration()
        {
            return this._customerGatewayConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property CustomerGatewayId. 
        /// <para>
        /// The ID of the customer gateway at your end of the VPN connection.
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
        /// Gets and sets the property Options. 
        /// <para>
        /// The VPN connection options.
        /// </para>
        /// </summary>
        public VpnConnectionOptions Options
        {
            get { return this._options; }
            set { this._options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this._options != null;
        }

        /// <summary>
        /// Gets and sets the property Routes. 
        /// <para>
        /// The static routes associated with the VPN connection.
        /// </para>
        /// </summary>
        public List<VpnStaticRoute> Routes
        {
            get { return this._routes; }
            set { this._routes = value; }
        }

        // Check to see if Routes property is set
        internal bool IsSetRoutes()
        {
            return this._routes != null && this._routes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The current state of the VPN connection.
        /// </para>
        /// </summary>
        public VpnState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// Any tags assigned to the VPN connection.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of VPN connection.
        /// </para>
        /// </summary>
        public GatewayType Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

        /// <summary>
        /// Gets and sets the property VgwTelemetry. 
        /// <para>
        /// Information about the VPN tunnel.
        /// </para>
        /// </summary>
        public List<VgwTelemetry> VgwTelemetry
        {
            get { return this._vgwTelemetry; }
            set { this._vgwTelemetry = value; }
        }

        // Check to see if VgwTelemetry property is set
        internal bool IsSetVgwTelemetry()
        {
            return this._vgwTelemetry != null && this._vgwTelemetry.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpnConnectionId. 
        /// <para>
        /// The ID of the VPN connection.
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
        /// The ID of the virtual private gateway at the AWS side of the VPN connection.
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

    }
}