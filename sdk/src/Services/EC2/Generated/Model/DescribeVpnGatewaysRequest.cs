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
    /// Container for the parameters to the DescribeVpnGateways operation.
    /// Describes one or more of your virtual private gateways.
    /// 
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">AWS
    /// Site-to-Site VPN</a> in the <i>AWS Site-to-Site VPN User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeVpnGatewaysRequest : AmazonEC2Request
    {
        private List<Filter> _filters = new List<Filter>();
        private List<string> _vpnGatewayIds = new List<string>();

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>amazon-side-asn</code> - The Autonomous System Number (ASN) for the Amazon
        /// side of the gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>attachment.state</code> - The current state of the attachment between the gateway
        /// and the VPC (<code>attaching</code> | <code>attached</code> | <code>detaching</code>
        /// | <code>detached</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>attachment.vpc-id</code> - The ID of an attached VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>availability-zone</code> - The Availability Zone for the virtual private gateway
        /// (if applicable).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>state</code> - The state of the virtual private gateway (<code>pending</code>
        /// | <code>available</code> | <code>deleting</code> | <code>deleted</code>).
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
        ///  <code>type</code> - The type of virtual private gateway. Currently the only supported
        /// type is <code>ipsec.1</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpn-gateway-id</code> - The ID of the virtual private gateway.
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
        /// Gets and sets the property VpnGatewayIds. 
        /// <para>
        /// One or more virtual private gateway IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your virtual private gateways.
        /// </para>
        /// </summary>
        public List<string> VpnGatewayIds
        {
            get { return this._vpnGatewayIds; }
            set { this._vpnGatewayIds = value; }
        }

        // Check to see if VpnGatewayIds property is set
        internal bool IsSetVpnGatewayIds()
        {
            return this._vpnGatewayIds != null && this._vpnGatewayIds.Count > 0; 
        }

    }
}