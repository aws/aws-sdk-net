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
    /// Container for the parameters to the DescribeCustomerGateways operation.
    /// Describes one or more of your VPN customer gateways.
    /// 
    ///  
    /// <para>
    /// For more information about VPN customer gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">AWS
    /// Managed VPN Connections</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
    /// </para>
    /// </summary>
    public partial class DescribeCustomerGatewaysRequest : AmazonEC2Request
    {
        private List<string> _customerGatewayIds = new List<string>();
        private List<Filter> _filters = new List<Filter>();

        /// <summary>
        /// Gets and sets the property CustomerGatewayIds. 
        /// <para>
        /// One or more customer gateway IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your customer gateways.
        /// </para>
        /// </summary>
        public List<string> CustomerGatewayIds
        {
            get { return this._customerGatewayIds; }
            set { this._customerGatewayIds = value; }
        }

        // Check to see if CustomerGatewayIds property is set
        internal bool IsSetCustomerGatewayIds()
        {
            return this._customerGatewayIds != null && this._customerGatewayIds.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>bgp-asn</code> - The customer gateway's Border Gateway Protocol (BGP) Autonomous
        /// System Number (ASN).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>customer-gateway-id</code> - The ID of the customer gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ip-address</code> - The IP address of the customer gateway's Internet-routable
        /// external interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>state</code> - The state of the customer gateway (<code>pending</code> | <code>available</code>
        /// | <code>deleting</code> | <code>deleted</code>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>type</code> - The type of customer gateway. Currently, the only supported type
        /// is <code>ipsec.1</code>.
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

    }
}