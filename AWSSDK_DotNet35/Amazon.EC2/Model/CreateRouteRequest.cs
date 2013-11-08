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
    /// Container for the parameters to the CreateRoute operation.
    /// <para> Creates a new route in a route table within a VPC. The route's target can be either a gateway attached to the VPC or a NAT instance
    /// in the VPC. </para> <para> When determining how to route traffic, we use the route with the most specific match. For example, let's say the
    /// traffic is destined for <c>192.0.2.3</c> , and the route table includes the following two routes: </para>
    /// <ul>
    /// <li> <c>192.0.2.0/24</c> (goes to some target A) </li>
    /// <li> <c>192.0.2.0/28</c> (goes to some target B) </li>
    /// 
    /// </ul>
    /// <para> Both routes apply to the traffic destined for <c>192.0.2.3</c> . However, the second route in the list is more specific, so we use
    /// that route to determine where to target the traffic. </para> <para> For more information about route tables, go to <a
    /// href="http://docs.amazonwebservices.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a> in the Amazon Virtual Private
    /// Cloud User Guide. </para>
    /// </summary>
    public partial class CreateRouteRequest : AmazonEC2Request
    {
        private string routeTableId;
        private string destinationCidrBlock;
        private string gatewayId;
        private string instanceId;
        private string networkInterfaceId;


        /// <summary>
        /// The ID of the route table where the route will be added.
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
        /// The CIDR address block used for the destination match. For example: <c>0.0.0.0/0</c>. Routing decisions are based on the most specific
        /// match.
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
        /// The ID of a VPN or Internet gateway attached to your VPC. You must provide either <c>GatewayId</c> or <c>InstanceId</c>, but not both.
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
        /// The ID of a NAT instance in your VPC. You must provide either <c>GatewayId</c> or <c>InstanceId</c>, but not both.
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
    
