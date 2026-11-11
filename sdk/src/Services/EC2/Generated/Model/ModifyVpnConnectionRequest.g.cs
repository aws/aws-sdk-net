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
    /// Container for the parameters to the ModifyVpnConnection operation. Modifies the customer
    /// gateway or the target gateway of an Amazon Web Services Site-to-Site VPN connection.
    /// To modify the target gateway, the following migration options are available: <ul>
    /// <li> <para> An existing virtual private gateway to a new virtual private gateway </para>
    /// </li> <li> <para> An existing virtual private gateway to a transit gateway </para>
    /// </li> <li> <para> An existing transit gateway to a new transit gateway </para> </li>
    /// <li> <para> An existing transit gateway to a virtual private gateway </para> </li>
    /// </ul> <para> Before you perform the migration to the new gateway, you must configure
    /// the new gateway. Use <a>CreateVpnGateway</a> to create a virtual private gateway,
    /// or <a>CreateTransitGateway</a> to create a transit gateway. </para> <para> This step
    /// is required when you migrate from a virtual private gateway with static routes to
    /// a transit gateway. </para> <para> You must delete the static routes before you migrate
    /// to the new gateway. </para> <para> Keep a copy of the static route before you delete
    /// it. You will need to add back these routes to the transit gateway after the VPN connection
    /// migration is complete. </para> <para> After you migrate to the new gateway, you might
    /// need to modify your VPC route table. Use <a>CreateRoute</a> and <a>DeleteRoute</a>
    /// to make the changes described in <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/modify-vpn-target.html#step-update-routing">Update
    /// VPC route tables</a> in the <i>Amazon Web Services Site-to-Site VPN User Guide</i>.
    /// </para> <para> When the new gateway is a transit gateway, modify the transit gateway
    /// route table to allow traffic between the VPC and the Amazon Web Services Site-to-Site
    /// VPN connection. Use <a>CreateTransitGatewayRoute</a> to add the routes. </para> <para>
    /// If you deleted VPN static routes, you must add the static routes to the transit gateway
    /// route table. </para> <para> After you perform this operation, the VPN endpoint's IP
    /// addresses on the Amazon Web Services side and the tunnel options remain intact. Your
    /// Amazon Web Services Site-to-Site VPN connection will be temporarily unavailable for
    /// a brief period while we provision the new endpoints. </para>
    /// </summary>
    public partial class ModifyVpnConnectionRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property CustomerGatewayId. 
        /// <para>
        /// The ID of the customer gateway at your end of the VPN connection.
        /// </para>
        /// </summary>
        public string CustomerGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the CustomerGatewayId property is set.
        /// </summary>
        internal bool IsSetCustomerGatewayId() => this.CustomerGatewayId != null;

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
        /// Gets and sets the property TransitGatewayId. 
        /// <para>
        /// The ID of the transit gateway.
        /// </para>
        /// </summary>
        public string TransitGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayId() => this.TransitGatewayId != null;

        /// <summary>
        /// Gets and sets the property VpnConnectionId. 
        /// <para>
        /// The ID of the VPN connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VpnConnectionId { get; set; }

        /// <summary>
        /// Checks to see if the VpnConnectionId property is set.
        /// </summary>
        internal bool IsSetVpnConnectionId() => this.VpnConnectionId != null;

        /// <summary>
        /// Gets and sets the property VpnGatewayId. 
        /// <para>
        /// The ID of the virtual private gateway at the Amazon Web Services side of the VPN connection.
        /// </para>
        /// </summary>
        public string VpnGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the VpnGatewayId property is set.
        /// </summary>
        internal bool IsSetVpnGatewayId() => this.VpnGatewayId != null;
    }
}
