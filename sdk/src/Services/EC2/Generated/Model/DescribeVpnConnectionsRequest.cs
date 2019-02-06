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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
    /// Container for the parameters to the DescribeVpnConnections operation.
    /// Describes one or more of your VPN connections.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">AWS
    /// Site-to-Site VPN</a> in the <i>AWS Site-to-Site VPN User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeVpnConnectionsRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private List<string> _vpnConnectionIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>customer-gateway-configuration</code> - The configuration information for the
        /// customer gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>customer-gateway-id</code> - The ID of a customer gateway associated with the
        /// VPN connection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>state</code> - The state of the VPN connection (<code>pending</code> | <code>available</code>
        /// | <code>deleting</code> | <code>deleted</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>option.static-routes-only</code> - Indicates whether the connection has static
        /// routes only. Used for devices that do not support Border Gateway Protocol (BGP).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>route.destination-cidr-block</code> - The destination CIDR block. This corresponds
        /// to the subnet used in a customer data center.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>bgp-asn</code> - The BGP Autonomous System Number (ASN) associated with a BGP
        /// device.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag</code>:&lt;key&gt; - The key/value combination of a tag assigned to the
        /// resource. Use the tag key in the filter name and the tag value as the filter value.
        /// For example, to find all resources that have a tag with the key <code>Owner</code>
        /// and the value <code>TeamA</code>, specify <code>tag:Owner</code> for the filter name
        /// and <code>TeamA</code> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>tag-key</code> - The key of a tag assigned to the resource. Use this filter
        /// to find all resources assigned a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>type</code> - The type of VPN connection. Currently the only supported type
        /// is <code>ipsec.1</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpn-connection-id</code> - The ID of the VPN connection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpn-gateway-id</code> - The ID of a virtual private gateway associated with
        /// the VPN connection.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && this._filters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpnConnectionIds. 
        /// <para>
        /// One or more VPN connection IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes your VPN connections.
        /// </para>
        /// </summary>
        public List<string> VpnConnectionIds
        {
            get { return this._vpnConnectionIds; }
            set { this._vpnConnectionIds = value; }
        }

        // Check to see if VpnConnectionIds property is set
        internal bool IsSetVpnConnectionIds()
        {
            return this._vpnConnectionIds != null && this._vpnConnectionIds.Count > 0; 
        }

    }
}