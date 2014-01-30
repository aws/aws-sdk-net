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
    /// Container for the parameters to the DescribeVpnGateways operation.
    /// <para>Describes one or more of your virtual private gateways.</para> <para>For more information about virtual private gateways, see <a
    /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html" >Adding an IPsec Hardware VPN to Your VPC</a> in the <i>Amazon
    /// Virtual Private Cloud User Guide</i> .</para>
    /// </summary>
    public partial class DescribeVpnGatewaysRequest : AmazonEC2Request
    {
        private List<string> vpnGatewayIds = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// One or more virtual private gateway IDs. Default: Describes all your virtual private gateways.
        ///  
        /// </summary>
        public List<string> VpnGatewayIds
        {
            get { return this.vpnGatewayIds; }
            set { this.vpnGatewayIds = value; }
        }

        // Check to see if VpnGatewayIds property is set
        internal bool IsSetVpnGatewayIds()
        {
            return this.vpnGatewayIds.Count > 0;
        }

        /// <summary>
        /// One or more filters. <ul> <li> <c>attachment.state</c> - The current state of the attachment between the gateway and the VPC
        /// (<c>attaching</c> | <c>attached</c> | <c>detaching</c> | <c>detached</c>). </li> <li> <c>attachment.vpc-id</c> - The ID of an attached VPC.
        /// </li> <li> <c>availability-zone</c> - The Availability Zone for the virtual private gateway. </li> <li> <c>state</c> - The state of the
        /// virtual private gateway (<c>pending</c> | <c>available</c> | <c>deleting</c> | <c>deleted</c>). </li> <li>
        /// <c>tag</c>:<i>key</i>=<i>value</i> - The key/value combination of a tag assigned to the resource. </li> <li> <c>tag-key</c> - The key of a
        /// tag assigned to the resource. This filter is independent of the <c>tag-value</c> filter. For example, if you use both the filter
        /// "tag-key=Purpose" and the filter "tag-value=X", you get any resources assigned both the tag key Purpose (regardless of what the tag's value
        /// is), and the tag value X (regardless of what the tag's key is). If you want to list only resources where Purpose is X, see the
        /// <c>tag</c>:<i>key</i>=<i>value</i> filter. </li> <li> <c>tag-value</c> - The value of a tag assigned to the resource. This filter is
        /// independent of the <c>tag-key</c> filter. </li> <li> <c>type</c> - The type of virtual private gateway. Currently the only supported type is
        /// <c>ipsec.1</c>. </li> <li> <c>vpn-gateway-id</c> - The ID of the virtual private gateway. </li> </ul>
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
    
