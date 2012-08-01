/*******************************************************************************
 * Copyright 2008-2012 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * Licensed under the Apache License, Version 2.0 (the "License"). You may not use
 * this file except in compliance with the License. A copy of the License is located at
 *
 * http://aws.amazon.com/apache2.0
 *
 * or in the "license" file accompanying this file. This file is distributed on
 * an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express
 * or implied. See the License for the specific language governing permissions and
 * limitations under the License.
 * *****************************************************************************
 *    __  _    _  ___
 *   (  )( \/\/ )/ __)
 *   /__\ \    / \__ \
 *  (_)(_) \/\/  (___/
 *
 *  AWS SDK for .NET
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Gives you information about your VPN connections.
    ///
    /// Important - we strongly recommend you use HTTPS when calling this
    /// operation because the response contains sensitive cryptographic
    /// information for configuring your customer gateway.
    ///
    /// You can filter the results to return information only about VPN
    /// connections that match criteria you specify.
    ///
    /// For example, you could ask to get information about a particular VPN
    /// connection (or all) only if the VPN's state is pending or available.
    ///
    /// You can specify multiple filters (e.g., the VPN connection is
    /// associated with a particular VPN gateway, and
    /// the gateway's state is pending or available).
    ///
    /// The result includes information for a particular VPN connection
    /// only if the VPN connection matches all your filters.
    ///
    /// If there's no match, no special message is returned; the response is
    /// simply empty.
    ///
    /// The returned information consists of:
    /// 1. The VPN connection ID.
    /// 2. The type of connection.
    /// 3. Customer gateway ID.
    /// 4. VPN gateway ID.
    /// 5. The current state of the VPN connection (pending, available,
    /// deleting, deleted).
    /// 6. The customer gateway configuration information in the
    /// native XML format.
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeVpnConnectionsRequest
    {    
        private List<string> vpnConnectionIdField;
        private List<Filter> filterField;

        /// <summary>
        /// Gets and sets the VpnConnectionId property.
        /// A VPN connection ID
        /// </summary>
        [XmlElementAttribute(ElementName = "VpnConnectionId")]
        public List<string> VpnConnectionId
        {
            get
            {
                if (this.vpnConnectionIdField == null)
                {
                    this.vpnConnectionIdField = new List<string>();
                }
                return this.vpnConnectionIdField;
            }
            set { this.vpnConnectionIdField = value; }
        }

        /// <summary>
        /// Sets the VpnConnectionId property
        /// </summary>
        /// <param name="list">A VPN connection ID</param>
        /// <returns>this instance</returns>
        public DescribeVpnConnectionsRequest WithVpnConnectionId(params string[] list)
        {
            foreach (string item in list)
            {
                VpnConnectionId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if VpnConnectionId property is set
        /// </summary>
        /// <returns>true if VpnConnectionId property is set</returns>
        public bool IsSetVpnConnectionId()
        {
            return (VpnConnectionId.Count > 0);
        }

        /// <summary>
        /// Gets and sets the Filter property.
        /// The filter to apply on the results of DescribeVpnConnections.
        /// Filters can be:
        /// a. state - The state of the VPN connection. (pending, available,
        /// deleting, deleted).
        /// b. type - The type of VPN connection. Currently the only
        /// supported type is ipsec.1.
        /// c. customerGatewayId - The ID of a customer gateway associated
        /// with the VPN connection.
        /// d. vpnGatewayId - The ID of a VPN gateway associated with the VPN
        /// connection.
        /// </summary>
        [XmlElementAttribute(ElementName = "Filter")]
        public List<Filter> Filter
        {
            get
            {
                if (this.filterField == null)
                {
                    this.filterField = new List<Filter>();
                }
                return this.filterField;
            }
            set { this.filterField = value; }
        }

        /// <summary>
        /// Sets the Filter property
        /// </summary>
        /// <param name="list">The filter to apply on the results of DescribeVpnConnections.
        /// Filters can be:
        /// a. state - The state of the VPN connection. (pending, available,
        /// deleting, deleted).
        /// b. type - The type of VPN connection. Currently the only
        /// supported type is ipsec.1.
        /// c. customerGatewayId - The ID of a customer gateway associated
        /// with the VPN connection.
        /// d. vpnGatewayId - The ID of a VPN gateway associated with the VPN
        /// connection.</param>
        /// <returns>this instance</returns>
        public DescribeVpnConnectionsRequest WithFilter(params Filter[] list)
        {
            foreach (Filter item in list)
            {
                Filter.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if Filter property is set
        /// </summary>
        /// <returns>true if Filter property is set</returns>
        public bool IsSetFilter()
        {
            return (Filter.Count > 0);
        }

    }
}
