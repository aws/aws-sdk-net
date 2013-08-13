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
    /// Route description
    /// </summary>
    [XmlRootAttribute(IsNullable = false)]
    public class Route
    {    
        private string destinationCidrBlockField;
        private string gatewayIdField;
        private string instanceIdField;
        private string stateField;
        private string instanceOwnerIdField;
        private string networkInterfaceIdField;

        /// <summary>
        /// The CIDR address block used for the destination match.
        /// For example: 0.0.0.0/0.
        /// </summary>
        [XmlElementAttribute(ElementName = "DestinationCidrBlock")]
        public string DestinationCidrBlock
        {
            get { return this.destinationCidrBlockField; }
            set { this.destinationCidrBlockField = value; }
        }

        /// <summary>
        /// Sets the CIDR address block used for the destination match.
        /// </summary>
        /// <param name="destinationCidrBlock">The CIDR address block used for the destination match.
        /// For example: 0.0.0.0/0.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Route WithDestinationCidrBlock(string destinationCidrBlock)
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
        public Route WithGatewayId(string gatewayId)
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
        public Route WithInstanceId(string instanceId)
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
        /// The state of the route.
        /// The blackhole state indicates that the route's
        /// target isn't available (e.g., the specified gateway isn't attached to the
        /// VPC, the specified NAT instance has been terminated, etc.).
        /// </summary>
        [XmlElementAttribute(ElementName = "State")]
        public string State
        {
            get { return this.stateField; }
            set { this.stateField = value; }
        }

        /// <summary>
        /// Sets the state of the route.
        /// </summary>
        /// <param name="state">The state of the route.The blackhole state indicates that the route's
        /// target isn't available (e.g., the specified gateway isn't attached to the
        /// VPC, the specified NAT instance has been terminated, etc.).</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Route WithState(string state)
        {
            this.stateField = state;
            return this;
        }

        /// <summary>
        /// Checks if State property is set
        /// </summary>
        /// <returns>true if State property is set</returns>
        public bool IsSetState()
        {
            return this.stateField != null;
        }

        /// <summary>
        /// The owner of the instance.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceOwnerId")]
        public string InstanceOwnerId
        {
            get { return this.instanceOwnerIdField; }
            set { this.instanceOwnerIdField = value; }
        }

        /// <summary>
        /// Sets the owner of the instance.
        /// </summary>
        /// <param name="instanceOwnerId">The owner of the instance.</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Route WithInstanceOwnerId(string instanceOwnerId)
        {
            this.instanceOwnerIdField = instanceOwnerId;
            return this;
        }

        /// <summary>
        /// Checks if the InstanceOwnerId property is set
        /// </summary>
        /// <returns>true if the InstanceOwnerId property is set</returns>
        public bool IsSetInstanceOwnerId()
        {
            return !string.IsNullOrEmpty(this.instanceOwnerIdField);
        }

        /// <summary>
        /// The network interface ID.
        /// </summary>
        [XmlElementAttribute(ElementName = "NetworkInterfaceId")]
        public string NetworkInterfaceId
        {
            get { return this.networkInterfaceIdField; }
            set { this.networkInterfaceIdField = value; }
        }

        /// <summary>
        /// Sets the network interface ID.
        /// </summary>
        /// <param name="networkInterfaceId">Network interface ID</param>
        /// <returns>this instance</returns>
        [Obsolete("The With methods are obsolete and will be removed in version 2 of the AWS SDK for .NET. See http://aws.amazon.com/sdkfornet/#version2 for more information.")]
        public Route WithNetworkInterfaceId(string networkInterfaceId)
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
