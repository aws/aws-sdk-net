/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// <para>Describes a VPN connection.</para>
    /// </summary>
    public class VpnConnection
    {
        
        private string vpnConnectionId;
        private VpnState state;
        private string customerGatewayConfiguration;
        private GatewayType type;
        private string customerGatewayId;
        private string vpnGatewayId;
        private List<Tag> tags = new List<Tag>();
        private List<VgwTelemetry> vgwTelemetry = new List<VgwTelemetry>();
        private VpnConnectionOptions options;
        private List<VpnStaticRoute> routes = new List<VpnStaticRoute>();


        /// <summary>
        /// The ID of the VPN connection.
        ///  
        /// </summary>
        public string VpnConnectionId
        {
            get { return this.vpnConnectionId; }
            set { this.vpnConnectionId = value; }
        }

        // Check to see if VpnConnectionId property is set
        internal bool IsSetVpnConnectionId()
        {
            return this.vpnConnectionId != null;
        }

        /// <summary>
        /// The current state of the VPN connection.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>pending, available, deleting, deleted</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public VpnState State
        {
            get { return this.state; }
            set { this.state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this.state != null;
        }

        /// <summary>
        /// The configuration information for the VPN connection's customer gateway (in the native XML format). This element is always present in the
        /// <a>CreateVpnConnection</a> response; however, it's present in the <a>DescribeVpnConnections</a> response only if the VPN connection is in
        /// the <c>pending</c> or <c>available</c> state.
        ///  
        /// </summary>
        public string CustomerGatewayConfiguration
        {
            get { return this.customerGatewayConfiguration; }
            set { this.customerGatewayConfiguration = value; }
        }

        // Check to see if CustomerGatewayConfiguration property is set
        internal bool IsSetCustomerGatewayConfiguration()
        {
            return this.customerGatewayConfiguration != null;
        }

        /// <summary>
        /// The type of VPN connection.
        ///  
        /// <para>
        /// <b>Constraints:</b>
        /// <list type="definition">
        ///     <item>
        ///         <term>Allowed Values</term>
        ///         <description>ipsec.1</description>
        ///     </item>
        /// </list>
        /// </para>
        /// </summary>
        public GatewayType Type
        {
            get { return this.type; }
            set { this.type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this.type != null;
        }

        /// <summary>
        /// The ID of the customer gateway at your end of the VPN connection.
        ///  
        /// </summary>
        public string CustomerGatewayId
        {
            get { return this.customerGatewayId; }
            set { this.customerGatewayId = value; }
        }

        // Check to see if CustomerGatewayId property is set
        internal bool IsSetCustomerGatewayId()
        {
            return this.customerGatewayId != null;
        }

        /// <summary>
        /// The ID of the virtual private gateway at the AWS side of the VPN connection.
        ///  
        /// </summary>
        public string VpnGatewayId
        {
            get { return this.vpnGatewayId; }
            set { this.vpnGatewayId = value; }
        }

        // Check to see if VpnGatewayId property is set
        internal bool IsSetVpnGatewayId()
        {
            return this.vpnGatewayId != null;
        }

        /// <summary>
        /// Any tags assigned to the VPN connection.
        ///  
        /// </summary>
        public List<Tag> Tags
        {
            get { return this.tags; }
            set { this.tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this.tags.Count > 0;
        }

        /// <summary>
        /// Information about the VPN tunnel.
        ///  
        /// </summary>
        public List<VgwTelemetry> VgwTelemetry
        {
            get { return this.vgwTelemetry; }
            set { this.vgwTelemetry = value; }
        }

        // Check to see if VgwTelemetry property is set
        internal bool IsSetVgwTelemetry()
        {
            return this.vgwTelemetry.Count > 0;
        }

        /// <summary>
        /// The VPN connection options.
        ///  
        /// </summary>
        public VpnConnectionOptions Options
        {
            get { return this.options; }
            set { this.options = value; }
        }

        // Check to see if Options property is set
        internal bool IsSetOptions()
        {
            return this.options != null;
        }

        /// <summary>
        /// The static routes assoicated with the VPN connection.
        ///  
        /// </summary>
        public List<VpnStaticRoute> Routes
        {
            get { return this.routes; }
            set { this.routes = value; }
        }

        // Check to see if Routes property is set
        internal bool IsSetRoutes()
        {
            return this.routes.Count > 0;
        }
    }
}
