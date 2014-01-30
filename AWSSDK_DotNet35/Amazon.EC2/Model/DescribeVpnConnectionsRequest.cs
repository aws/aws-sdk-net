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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeVpnConnections operation.
    /// <para>Describes one or more of your VPN connections.</para> <para>For more information about VPN connections, see <a
    /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html" >Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
    /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
    /// </summary>
    public partial class DescribeVpnConnectionsRequest : AmazonEC2Request
    {
        private List<string> vpnConnectionIds = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// One or more VPN connection IDs. Default: Describes your VPN connections.
        ///  
        /// </summary>
        public List<string> VpnConnectionIds
        {
            get { return this.vpnConnectionIds; }
            set { this.vpnConnectionIds = value; }
        }

        // Check to see if VpnConnectionIds property is set
        internal bool IsSetVpnConnectionIds()
        {
            return this.vpnConnectionIds.Count > 0;
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>customer-gateway-configuration</c> - The configuration information for the customer gateway. </li> <li>
        /// <c>customer-gateway-id</c> - The ID of a customer gateway associated with the VPN connection. </li> <li> <c>state</c> - The state of the VPN
        /// connection (<c>pending</c> | <c>available</c> | <c>deleting</c> | <c>deleted</c>). </li> <li> <c>option.static-routes-only</c> - Indicates
        /// whether the connection has static routes only. Used for devices that do not support Border Gateway Protocol (BGP). </li> <li>
        /// <c>route.destination-cidr-block</c> - The destination CIDR block. This corresponds to the subnet used in a customer data center. </li> <li>
        /// <c>bgp-asn</c> - The BGP Autonomous System Number (ASN) associated with a BGP device. </li> <li> <c>tag</c>:<i>key</i>=<i>value</i> - The
        /// key/value combination of a tag assigned to the resource. </li> <li> <c>tag-key</c> - The key of a tag assigned to the resource. This filter
        /// is independent of the <c>tag-value</c> filter. For example, if you use both the filter "tag-key=Purpose" and the filter "tag-value=X", you
        /// get any resources assigned both the tag key Purpose (regardless of what the tag's value is), and the tag value X (regardless of what the
        /// tag's key is). If you want to list only resources where Purpose is X, see the <c>tag</c>:<i>key</i>=<i>value</i> filter. </li> <li>
        /// <c>tag-value</c> - The value of a tag assigned to the resource. This filter is independent of the <c>tag-key</c> filter. </li> <li>
        /// <c>type</c> - The type of VPN connection. Currently the only supported type is <c>ipsec.1</c>. </li> <li> <c>vpn-connection-id</c> - The ID
        /// of the VPN connection. </li> <li> <c>vpn-gateway-id</c> - The ID of a virtual private gateway associated with the VPN connection. </li>
        /// </ul>
        ///  
        /// </summary>
        public List<Filter> Filters
        {
            get { return this.filters; }
            set { this.filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this.filters.Count > 0;
        }

    }
}
    
