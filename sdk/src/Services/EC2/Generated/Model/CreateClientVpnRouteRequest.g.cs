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
    /// Container for the parameters to the CreateClientVpnRoute operation. Adds a route to
    /// a network to a Client VPN endpoint. Each Client VPN endpoint has a route table that
    /// describes the available destination network routes. Each route in the route table
    /// specifies the path for traﬃc to speciﬁc resources or networks.
    /// </summary>
    public partial class CreateClientVpnRouteRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// Unique, case-sensitive identifier that you provide to ensure the idempotency of the
        /// request. For more information, see <a href="https://docs.aws.amazon.com/ec2/latest/devguide/ec2-api-idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property ClientVpnEndpointId. 
        /// <para>
        /// The ID of the Client VPN endpoint to which to add the route.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string ClientVpnEndpointId { get; set; }

        /// <summary>
        /// Checks to see if the ClientVpnEndpointId property is set.
        /// </summary>
        internal bool IsSetClientVpnEndpointId() => this.ClientVpnEndpointId != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of the route.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property DestinationCidrBlock. 
        /// <para>
        /// The IPv4 address range, in CIDR notation, of the route destination. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To add a route for Internet access, enter <c>0.0.0.0/0</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To add a route for a peered VPC, enter the peered VPC's IPv4 CIDR range
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To add a route for an on-premises network, enter the Amazon Web Services Site-to-Site
        /// VPN connection's IPv4 CIDR range
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To add a route for the local network, enter the client CIDR range
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Required = true)]
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// Checks to see if the DestinationCidrBlock property is set.
        /// </summary>
        internal bool IsSetDestinationCidrBlock() => this.DestinationCidrBlock != null;

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
        /// Gets and sets the property TargetVpcSubnetId. 
        /// <para>
        /// The ID of the subnet through which you want to route traffic. The specified subnet
        /// must be an existing target network of the Client VPN endpoint.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, if you're adding a route for the local network, specify <c>local</c>.
        /// </para>
        ///  
        /// <para>
        /// This parameter is required for VPC-based Client VPN endpoints. For Transit Gateway-based
        /// endpoints, this parameter is not required.
        /// </para>
        /// </summary>
        public string TargetVpcSubnetId { get; set; }

        /// <summary>
        /// Checks to see if the TargetVpcSubnetId property is set.
        /// </summary>
        internal bool IsSetTargetVpcSubnetId() => this.TargetVpcSubnetId != null;
    }
}
