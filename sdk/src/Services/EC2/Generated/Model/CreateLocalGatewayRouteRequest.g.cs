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
    /// Container for the parameters to the CreateLocalGatewayRoute operation. Creates a static
    /// route for the specified local gateway route table. You must specify one of the following
    /// targets: <ul> <li> <para> <c>LocalGatewayVirtualInterfaceGroupId</c> </para> </li>
    /// <li> <para> <c>NetworkInterfaceId</c> </para> </li> </ul>
    /// </summary>
    public partial class CreateLocalGatewayRouteRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property DestinationCidrBlock. 
        /// <para>
        /// The CIDR range used for destination matches. Routing decisions are based on the most
        /// specific match.
        /// </para>
        /// </summary>
        public string DestinationCidrBlock { get; set; }

        /// <summary>
        /// Checks to see if the DestinationCidrBlock property is set.
        /// </summary>
        internal bool IsSetDestinationCidrBlock() => this.DestinationCidrBlock != null;

        /// <summary>
        /// Gets and sets the property DestinationPrefixListId. 
        /// <para>
        ///  The ID of the prefix list. Use a prefix list in place of <c>DestinationCidrBlock</c>.
        /// You cannot use <c>DestinationPrefixListId</c> and <c>DestinationCidrBlock</c> in the
        /// same request. 
        /// </para>
        /// </summary>
        public string DestinationPrefixListId { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPrefixListId property is set.
        /// </summary>
        internal bool IsSetDestinationPrefixListId() => this.DestinationPrefixListId != null;

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
        /// Gets and sets the property LocalGatewayRouteTableId. 
        /// <para>
        /// The ID of the local gateway route table.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LocalGatewayRouteTableId { get; set; }

        /// <summary>
        /// Checks to see if the LocalGatewayRouteTableId property is set.
        /// </summary>
        internal bool IsSetLocalGatewayRouteTableId() => this.LocalGatewayRouteTableId != null;

        /// <summary>
        /// Gets and sets the property LocalGatewayVirtualInterfaceGroupId. 
        /// <para>
        /// The ID of the virtual interface group.
        /// </para>
        /// </summary>
        public string LocalGatewayVirtualInterfaceGroupId { get; set; }

        /// <summary>
        /// Checks to see if the LocalGatewayVirtualInterfaceGroupId property is set.
        /// </summary>
        internal bool IsSetLocalGatewayVirtualInterfaceGroupId() => this.LocalGatewayVirtualInterfaceGroupId != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the network interface.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceId property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceId() => this.NetworkInterfaceId != null;
    }
}
