/*******************************************************************************
 * Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
    /// Gives you information about your VPN gateways.
    /// </summary>
    /// <remarks>
    /// You can filter the results to return information
    /// only about VPN gateways that match criteria you specify. For example,
    /// you could ask to get information about a particular VPN gateway (or all) only
    /// if the gateway's state is pending or available. You can specify
    /// multiple filters (e.g., the VPN gateway is in a particular
    /// Availability Zone and the gateway's state is pending or available).
    /// The result includes information for a particular VPN gateway only if
    /// the gateway matches all your filters. If there's no match, no
    /// special message is returned; the response is simply empty.
    ///
    /// The returned information consists of:
    ///
    /// 1. The VPN gateway ID - The current state of the VPN gateway
    /// (pending, available, deleting, deleted)
    /// 2. The type of VPN connection the VPN gateway supports.
    /// 3. The Availability Zone where the VPN gateway was created.
    /// 4. The VPCs the VPN gateway is attached to and the state of each
    /// attachment (attaching, attached, detaching, detached)
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class DescribeVpnGatewaysRequest
    {    
        private List<string> vpnGatewayIdField;
        private List<Filter> filterField;

        /// <summary>
        /// One or more VPN gateway IDs.
        /// </summary>
        [XmlElementAttribute(ElementName = "VpnGatewayId")]
        public List<string> VpnGatewayId
        {
            get
            {
                if (this.vpnGatewayIdField == null)
                {
                    this.vpnGatewayIdField = new List<string>();
                }
                return this.vpnGatewayIdField;
            }
            set { this.vpnGatewayIdField = value; }
        }

        /// <summary>
        /// Sets VPN gateway IDs.
        /// </summary>
        /// <param name="list">A VPN gateway ID.</param>
        /// <returns>this instance</returns>
        public DescribeVpnGatewaysRequest WithVpnGatewayId(params string[] list)
        {
            foreach (string item in list)
            {
                VpnGatewayId.Add(item);
            }
            return this;
        }

        /// <summary>
        /// Checks if VpnGatewayId property is set
        /// </summary>
        /// <returns>true if VpnGatewayId property is set</returns>
        public bool IsSetVpnGatewayId()
        {
            return (VpnGatewayId.Count > 0);
        }

        /// <summary>
        /// The filter to apply on the results of DescribeVpnGateways.
        /// Filters can be:
        /// a. state - The state of the VPN gateway. (pending, available, deleting, deleted).
        /// b. type - The type of VPN gateway. Currently the only supported type is ipsec.1.
        /// c. availabilityZone - The Availability Zone the VPN gateway is in.
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
        /// Sets the filter to apply on the results of DescribeVpnGateways.
        /// </summary>
        /// <param name="list">The filter to apply on the results of DescribeVpnGateways. Filters
        /// can be:
        /// a. state - The state of the VPN gateway. (pending, available, deleting, deleted).
        /// b. type - The type of VPN gateway. Currently the only supported type is ipsec.1.
        /// c. availabilityZone - The Availability Zone the VPN gateway is in.</param>
        /// <returns>this instance</returns>
        public DescribeVpnGatewaysRequest WithFilter(params Filter[] list)
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
