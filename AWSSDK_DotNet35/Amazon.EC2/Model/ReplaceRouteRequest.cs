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
    /// Container for the parameters to the ReplaceRoute operation.
    /// <para>Replaces an existing route within a route table in a VPC. You must provide only one of the following: Internet gateway, NAT instance,
    /// or network interface.</para> <para>For more information about route tables, see <a
    /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a> in the <i>Amazon Virtual Private Cloud
    /// User Guide</i> .</para>
    /// </summary>
    public partial class ReplaceRouteRequest : AmazonEC2Request
    {
        private string routeTableId;
        private string destinationCidrBlock;
        private string gatewayId;
        private string instanceId;
        private string networkInterfaceId;


        /// <summary>
        /// The ID of the route table.
        ///  
        /// </summary>
        public string RouteTableId
        {
            get { return this.routeTableId; }
            set { this.routeTableId = value; }
        }

        // Check to see if RouteTableId property is set
        internal bool IsSetRouteTableId()
        {
            return this.routeTableId != null;
        }

        /// <summary>
        /// The CIDR address block used for the destination match. The value you provide must match the CIDR of an existing route in the table.
        ///  
        /// </summary>
        public string DestinationCidrBlock
        {
            get { return this.destinationCidrBlock; }
            set { this.destinationCidrBlock = value; }
        }

        // Check to see if DestinationCidrBlock property is set
        internal bool IsSetDestinationCidrBlock()
        {
            return this.destinationCidrBlock != null;
        }

        /// <summary>
        /// The ID of an Internet gateway attached to your VPC.
        ///  
        /// </summary>
        public string GatewayId
        {
            get { return this.gatewayId; }
            set { this.gatewayId = value; }
        }

        // Check to see if GatewayId property is set
        internal bool IsSetGatewayId()
        {
            return this.gatewayId != null;
        }

        /// <summary>
        /// The ID of a NAT instance in your VPC.
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

        /// <summary>
        /// The ID of a network interface.
        ///  
        /// </summary>
        public string NetworkInterfaceId
        {
            get { return this.networkInterfaceId; }
            set { this.networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this.networkInterfaceId != null;
        }

    }
}
    
