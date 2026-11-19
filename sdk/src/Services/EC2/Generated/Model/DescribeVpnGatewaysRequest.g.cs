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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
    /// Container for the parameters to the DescribeVpnGateways operation. Describes one or
    /// more of your virtual private gateways. <para> For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">Amazon
    /// Web Services Site-to-Site VPN</a> in the <i>Amazon Web Services Site-to-Site VPN User
    /// Guide</i>. </para>
    /// </summary>
    public partial class DescribeVpnGatewaysRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

        /// <summary>
        /// Gets and sets the property Filters. 
        /// <para>
        /// One or more filters.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>amazon-side-asn</c> - The Autonomous System Number (ASN) for the Amazon side of
        /// the gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>attachment.state</c> - The current state of the attachment between the gateway
        /// and the VPC (<c>attaching</c> | <c>attached</c> | <c>detaching</c> | <c>detached</c>).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>attachment.vpc-id</c> - The ID of an attached VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>availability-zone</c> - The Availability Zone for the virtual private gateway
        /// (if applicable).
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>state</c> - The state of the virtual private gateway (<c>pending</c> | <c>available</c>
        /// | <c>deleting</c> | <c>deleted</c>).
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
        ///  <c>type</c> - The type of virtual private gateway. Currently the only supported type
        /// is <c>ipsec.1</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>vpn-gateway-id</c> - The ID of the virtual private gateway.
        /// </para>
        ///  </li> </ul>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Filter> Filters { get; set; } = AWSConfigs.InitializeCollections ? new List<Filter>() : null;

        /// <summary>
        /// Checks to see if the Filters property is set.
        /// </summary>
        internal bool IsSetFilters() => this.Filters != null && (this.Filters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpnGatewayIds. 
        /// <para>
        /// One or more virtual private gateway IDs.
        /// </para>
        ///  
        /// <para>
        /// Default: Describes all your virtual private gateways.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> VpnGatewayIds { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the VpnGatewayIds property is set.
        /// </summary>
        internal bool IsSetVpnGatewayIds() => this.VpnGatewayIds != null && (this.VpnGatewayIds.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
