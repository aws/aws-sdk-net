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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the DescribeVpnConnections operation.
    /// Describes one or more of your VPN connections.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">Amazon
    /// Web Services Site-to-Site VPN</a> in the <i>Amazon Web Services Site-to-Site VPN User
    /// Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeVpnConnectionsRequest : AmazonEC2Request
    {
        private bool? _dryRun;
        private List<Filter> _filters = AWSConfigs.InitializeCollections ? new List<Filter>() : null;
        private List<string> _vpnConnectionIds = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun
        {
            get { return this._dryRun; }
            set { this._dryRun = value; }
        }

        // Check to see if DryRun property is set
        internal bool IsSetDryRun()
        {
            return this._dryRun.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>customer-gateway-configuration</c> - The configuration information for the customer
        /// gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>customer-gateway-id</c> - The ID of a customer gateway associated with the VPN
        /// connection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>state</c> - The state of the VPN connection (<c>pending</c> | <c>available</c>
        /// | <c>deleting</c> | <c>deleted</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>option.static-routes-only</c> - Indicates whether the connection has static routes
        /// only. Used for devices that do not support Border Gateway Protocol (BGP).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>route.destination-cidr-block</c> - The destination CIDR block. This corresponds
        /// to the subnet used in a customer data center.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>bgp-asn</c> - The BGP Autonomous System Number (ASN) associated with a BGP device.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag</c>:&lt;key&gt; - The key/value combination of a tag assigned to the resource.
        /// Use the tag key in the filter name and the tag value as the filter value. For example,
        /// to find all resources that have a tag with the key <c>Owner</c> and the value <c>TeamA</c>,
        /// specify <c>tag:Owner</c> for the filter name and <c>TeamA</c> for the filter value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>tag-key</c> - The key of a tag assigned to the resource. Use this filter to find
        /// all resources assigned a tag with a specific key, regardless of the tag value.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>type</c> - The type of VPN connection. Currently the only supported type is <c>ipsec.1</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>vpn-connection-id</c> - The ID of the VPN connection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>vpn-gateway-id</c> - The ID of a virtual private gateway associated with the VPN
        /// connection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>transit-gateway-id</c> - The ID of a transit gateway associated with the VPN connection.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters
        {
            get { return this._filters; }
            set { this._filters = value; }
        }

        // Check to see if Filters property is set
        internal bool IsSetFilters()
        {
            return this._filters != null && (this._filters.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpnConnectionIds
        {
            get { return this._vpnConnectionIds; }
            set { this._vpnConnectionIds = value; }
        }

        // Check to see if VpnConnectionIds property is set
        internal bool IsSetVpnConnectionIds()
        {
            return this._vpnConnectionIds != null && (this._vpnConnectionIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}