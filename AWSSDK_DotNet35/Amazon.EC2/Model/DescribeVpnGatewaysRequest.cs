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
    /// <para> Gives you information about your VPN gateways. You can filter the results to return information only about VPN gateways that match
    /// criteria you specify. </para> <para> For example, you could ask to get information about a particular VPN gateway (or all) only if the
    /// gateway's state is pending or available. You can specify multiple filters (e.g., the VPN gateway is in a particular Availability Zone and
    /// the gateway's state is pending or available). </para> <para> The result includes information for a particular VPN gateway only if the
    /// gateway matches all your filters. If there's no match, no special message is returned; the response is simply empty. The following table
    /// shows the available filters. </para>
    /// </summary>
    public partial class DescribeVpnGatewaysRequest : AmazonEC2Request
    {
        private List<string> vpnGatewayIds = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// A list of filters used to match properties for VPN Gateways. For a complete reference to the available filter keys for this operation, see
        /// the <a href="http://docs.amazonwebservices.com/AWSEC2/latest/APIReference/">Amazon EC2 API reference</a>.
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
        /// A list of filters used to match properties for VPN Gateways. For a complete reference to the available filter keys for this operation, see
        /// the <a href="http://docs.amazonwebservices.com/AWSEC2/latest/APIReference/">Amazon EC2 API reference</a>.
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
    
