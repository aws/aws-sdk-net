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
    /// <para> Gives you information about your VPN connections. </para> <para><b>IMPORTANT:</b> We strongly recommend you use HTTPS when calling
    /// this operation because the response contains sensitive cryptographic information for configuring your customer gateway. You can filter the
    /// results to return information only about VPN connections that match criteria you specify. For example, you could ask to get information
    /// about a particular VPN connection (or all) only if the VPN's state is pending or available. You can specify multiple filters (e.g., the VPN
    /// connection is associated with a particular VPN gateway, and the gateway's state is pending or available). The result includes information
    /// for a particular VPN connection only if the VPN connection matches all your filters. If there's no match, no special message is returned;
    /// the response is simply empty. The following table shows the available filters. </para>
    /// </summary>
    public partial class DescribeVpnConnectionsRequest : AmazonEC2Request
    {
        private List<string> vpnConnectionIds = new List<string>();
        private List<Filter> filters = new List<Filter>();


        /// <summary>
        /// A VPN connection ID. More than one may be specified per request.
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
        /// A list of filters used to match properties for VPN Connections. For a complete reference to the available filter keys for this operation,
        /// see the <a href="http://docs.amazonwebservices.com/AWSEC2/latest/APIReference/">Amazon EC2 API reference</a>.
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
    
