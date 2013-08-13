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
    /// Creates a new route in a route table within a VPC.
    /// The route's target can be either a gateway attached
    /// to the VPC or a NAT instance in the VPC.
    /// </summary>
    /// <remarks>
    /// When determining how to route traffic, we use the route
    /// with the most specific match. For example, let's say the
    /// traffic is destined for 192.0.2.3, and the route table
    /// includes the following two routes:
    /// 192.0.2.0/24 (goes to some target A)
    /// 192.0.2.0/28 (goes to some target B)
    /// 
    /// Both routes apply to the traffic destined for 192.0.2.3.
    /// However, the second route in the list is more specific,
    /// so we use that route to determine where to target the traffic.
    /// 
    /// For more information about route tables, go to Route
    /// Tables in the Amazon Virtual Private Cloud User Guide.
    /// </remarks>
    [XmlRootAttribute(IsNullable = false)]
    public class CreateRouteRequest : EC2Request
    {    
        private string routeTableIdField;
        private string destinationCidrBlockField;
        private string gatewayIdField;
        private string instanceIdField;
        private string networkInterfaceIdField;

        /// <summary>
        /// The ID of the route table where the route will be added.
        /// </summary>
        [XmlElementAttribute(ElementName = "RouteTableId")]
        public string RouteTableId
        {
            get { return this.routeTableIdField; }
            set { this.routeTableIdField = value; }
        }

        /// <summary>
        /// Sets the ID of the route table where the route will be added.
        /// </summary>
        /// <param name="routeTableId">The ID of the route table where the route will 
        /// be added.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateRouteRequest WithRouteTableId(string routeTableId)
        {
            this.routeTableIdField = routeTableId;
            return this;
        }

        /// <summary>
        /// Checks if RouteTableId property is set
        /// </summary>
        /// <returns>true if RouteTableId property is set</returns>
        public bool IsSetRouteTableId()
        {
            return this.routeTableIdField != null;
        }

        /// <summary>
        /// The CIDR address block used for the destination match.
        /// </summary>
        /// <remarks>
        /// For example: 0.0.0.0/0.
        /// Routing decisions are based on the most specific match.
        /// </remarks>
        [XmlElementAttribute(ElementName = "DestinationCidrBlock")]
        public string DestinationCidrBlock
        {
            get { return this.destinationCidrBlockField; }
            set { this.destinationCidrBlockField = value; }
        }

        /// <summary>
        /// Sets the CIDR address block used for the destination match.
        /// </summary>
        /// <param name="destinationCidrBlock">The CIDR address block used for the 
        /// destination match. For example: 0.0.0.0/0.
        /// Routing decisions are based on the most
        /// specific match.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateRouteRequest WithDestinationCidrBlock(string destinationCidrBlock)
        {
            this.destinationCidrBlockField = destinationCidrBlock;
            return this;
        }

        /// <summary>
        /// Checks if DestinationCidrBlock property is set
        /// </summary>
        /// <returns>true if DestinationCidrBlock property is set</returns>
        public bool IsSetDestinationCidrBlock()
        {
            return this.destinationCidrBlockField != null;
        }

        /// <summary>
        /// The ID of a gateway attached to your VPC.
        /// </summary>
        [XmlElementAttribute(ElementName = "GatewayId")]
        public string GatewayId
        {
            get { return this.gatewayIdField; }
            set { this.gatewayIdField = value; }
        }

        /// <summary>
        /// Sets the ID of a gateway attached to your VPC.
        /// </summary>
        /// <param name="gatewayId">The ID of a gateway attached to your VPC.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateRouteRequest WithGatewayId(string gatewayId)
        {
            this.gatewayIdField = gatewayId;
            return this;
        }

        /// <summary>
        /// Checks if GatewayId property is set
        /// </summary>
        /// <returns>true if GatewayId property is set</returns>
        public bool IsSetGatewayId()
        {
            return this.gatewayIdField != null;
        }

        /// <summary>
        /// The ID of a NAT instance in your VPC.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the ID of a NAT instance in your VPC.
        /// </summary>
        /// <param name="instanceId">The ID of a NAT instance in your VPC.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateRouteRequest WithInstanceId(string instanceId)
        {
            this.instanceIdField = instanceId;
            return this;
        }

        /// <summary>
        /// Checks if InstanceId property is set
        /// </summary>
        /// <returns>true if InstanceId property is set</returns>
        public bool IsSetInstanceId()
        {
            return this.instanceIdField != null;
        }

        /// <summary>
        /// Allows the routing of network interface IDs.
        /// <remarks>
        /// Exactly one interface must be attached when specifying an instance ID or it fails.
        /// Value provided must be one of the following: GatewayID, InstanceID, or NetworkdInterfaceId.
        /// </remarks>
        /// </summary>
        [XmlElementAttribute(ElementName = "NetworkInterfaceId")]
        public string NetworkInterfaceId
        {
            get { return this.networkInterfaceIdField; }
            set { this.networkInterfaceIdField = value; }
        }

        /// <summary>
        /// Sets the network interface id.
        /// </summary>
        /// <param name="networkInterfaceId">Network interface ID</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public CreateRouteRequest WithNetworkInterfaceId(string networkInterfaceId)
        {
            this.networkInterfaceIdField = networkInterfaceId;
            return this;
        }

        /// <summary>
        /// Checks if the NetworkInterfaceId property is set
        /// </summary>
        /// <returns>true if the NetworkInterfaceId property is set</returns>
        public bool IsSetNetworkInterfaceId()
        {
            return !string.IsNullOrEmpty(this.networkInterfaceIdField);
        }

    }
}
