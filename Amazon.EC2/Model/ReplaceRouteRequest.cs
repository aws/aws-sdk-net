/*******************************************************************************
 * Copyright 2008-2011 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 *  API Version: 2011-05-15
 */

using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Replaces an existing route within a route table in a VPC. For more information about route tables, go to
    /// Route Tables in the Amazon Virtual Private Cloud User Guide.
    /// </summary>
    [XmlRootAttribute(Namespace = "http://ec2.amazonaws.com/doc/2011-05-15/", IsNullable = false)]
    public class ReplaceRouteRequest
    {    
        private string routeTableIdField;
        private string destinationCidrBlockField;
        private string gatewayIdField;
        private string instanceIdField;

        /// <summary>
        /// Gets and sets the RouteTableId property.
        /// The ID of the route table where the route will 
        /// be replaced.
        /// </summary>
        [XmlElementAttribute(ElementName = "RouteTableId")]
        public string RouteTableId
        {
            get { return this.routeTableIdField; }
            set { this.routeTableIdField = value; }
        }

        /// <summary>
        /// Sets the RouteTableId property
        /// </summary>
        /// <param name="routeTableId">The ID of the route table where the route will 
        /// be replaced.</param>
        /// <returns>this instance</returns>
        public ReplaceRouteRequest WithRouteTableId(string routeTableId)
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
        /// Gets and sets the DestinationCidrBlock property.
        /// The CIDR address block used for the 
        /// destination match. For example: 0.0.0.0/0.The
        /// value you provide must match the CIDR of an
        /// existing route in the table.
        /// </summary>
        [XmlElementAttribute(ElementName = "DestinationCidrBlock")]
        public string DestinationCidrBlock
        {
            get { return this.destinationCidrBlockField; }
            set { this.destinationCidrBlockField = value; }
        }

        /// <summary>
        /// Sets the DestinationCidrBlock property
        /// </summary>
        /// <param name="destinationCidrBlock">The CIDR address block used for the 
        /// destination match. For example: 0.0.0.0/0.The
        /// value you provide must match the CIDR of an
        /// existing route in the table.</param>
        /// <returns>this instance</returns>
        public ReplaceRouteRequest WithDestinationCidrBlock(string destinationCidrBlock)
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
        /// Gets and sets the GatewayId property.
        /// The ID of a gateway attached to your VPC.
        /// </summary>
        [XmlElementAttribute(ElementName = "GatewayId")]
        public string GatewayId
        {
            get { return this.gatewayIdField; }
            set { this.gatewayIdField = value; }
        }

        /// <summary>
        /// Sets the GatewayId property
        /// </summary>
        /// <param name="gatewayId">The ID of a gateway attached to your VPC.</param>
        /// <returns>this instance</returns>
        public ReplaceRouteRequest WithGatewayId(string gatewayId)
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
        /// Gets and sets the InstanceId property.
        /// The ID of a NAT instance in your VPC.
        /// </summary>
        [XmlElementAttribute(ElementName = "InstanceId")]
        public string InstanceId
        {
            get { return this.instanceIdField; }
            set { this.instanceIdField = value; }
        }

        /// <summary>
        /// Sets the InstanceId property
        /// </summary>
        /// <param name="instanceId">The ID of a NAT instance in your VPC.</param>
        /// <returns>this instance</returns>
        public ReplaceRouteRequest WithInstanceId(string instanceId)
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

    }
}
