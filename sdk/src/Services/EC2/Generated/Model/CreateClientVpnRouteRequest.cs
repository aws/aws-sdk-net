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
    /// Container for the parameters to the CreateClientVpnRoute operation.
    /// Adds a route to a network to a Client VPN endpoint. Each Client VPN endpoint has a
    /// route table that describes the available destination network routes. Each route in
    /// the route table specifies the path for traﬃc to speciﬁc resources or networks.
    /// </summary>
    public partial class CreateClientVpnRouteRequest : AmazonEC2Request
    {
        private string _clientVpnEndpointId;
        private string _description;
        private string _destinationCidrBlock;
        private string _targetVpcSubnetId;

        /// <summary>
        /// Gets and sets the property ClientVpnEndpointId. 
        /// <para>
        /// The ID of the Client VPN endpoint to which to add the route.
        /// </para>
        /// </summary>
        public string ClientVpnEndpointId
        {
            get { return this._clientVpnEndpointId; }
            set { this._clientVpnEndpointId = value; }
        }

        // Check to see if ClientVpnEndpointId property is set
        internal bool IsSetClientVpnEndpointId()
        {
            return this._clientVpnEndpointId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A brief description of the route.
        /// </para>
        /// </summary>
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationCidrBlock. 
        /// <para>
        /// The IPv4 address range, in CIDR notation, of the route destination. For example:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To add a route for Internet access, enter <code>0.0.0.0/0</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To add a route for a peered VPC, enter the peered VPC's IPv4 CIDR range
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To add a route for an on-premises network, enter the AWS Site-to-Site VPN connection's
        /// IPv4 CIDR range
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Route address ranges cannot overlap with the CIDR range specified for client allocation.
        /// </para>
        /// </summary>
        public string DestinationCidrBlock
        {
            get { return this._destinationCidrBlock; }
            set { this._destinationCidrBlock = value; }
        }

        // Check to see if DestinationCidrBlock property is set
        internal bool IsSetDestinationCidrBlock()
        {
            return this._destinationCidrBlock != null;
        }

        /// <summary>
        /// Gets and sets the property TargetVpcSubnetId. 
        /// <para>
        /// The ID of the subnet through which you want to route traffic. The specified subnet
        /// must be an existing target network of the Client VPN endpoint.
        /// </para>
        /// </summary>
        public string TargetVpcSubnetId
        {
            get { return this._targetVpcSubnetId; }
            set { this._targetVpcSubnetId = value; }
        }

        // Check to see if TargetVpcSubnetId property is set
        internal bool IsSetTargetVpcSubnetId()
        {
            return this._targetVpcSubnetId != null;
        }

    }
}