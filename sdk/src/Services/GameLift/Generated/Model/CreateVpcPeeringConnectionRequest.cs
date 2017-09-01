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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVpcPeeringConnection operation.
    /// Establishes a VPC peering connection between a virtual private cloud (VPC) in an AWS
    /// account with the VPC for your Amazon GameLift fleet. VPC peering enables the game
    /// servers on your fleet to communicate directly with other AWS resources. You can peer
    /// with VPCs in any AWS account that you have access to, including the account that you
    /// use to manage your Amazon GameLift fleets. You cannot peer with VPCs that are in different
    /// regions. For more information, see <a href="http://docs.aws.amazon.com/gamelift/latest/developerguide/vpc-peering.html">VPC
    /// Peering with Amazon GameLift Fleets</a>.
    /// 
    ///  
    /// <para>
    /// Before calling this operation to establish the peering connection, you first need
    /// to call <a>CreateVpcPeeringAuthorization</a> and identify the VPC you want to peer
    /// with. Once the authorization for the specified VPC is issued, you have 24 hours to
    /// establish the connection. These two operations handle all tasks necessary to peer
    /// the two VPCs, including acceptance, updating routing tables, etc. 
    /// </para>
    ///  
    /// <para>
    /// To establish the connection, call this operation from the AWS account that is used
    /// to manage the Amazon GameLift fleets. Identify the following values: (1) The ID of
    /// the fleet you want to be enable a VPC peering connection for; (2) The AWS account
    /// with the VPC that you want to peer with; and (3) The ID of the VPC you want to peer
    /// with. This operation is asynchronous. If successful, a <a>VpcPeeringConnection</a>
    /// request is created. You can use continuous polling to track the request's status using
    /// <a>DescribeVpcPeeringConnections</a>, or by monitoring fleet events for success or
    /// failure using <a>DescribeFleetEvents</a>. 
    /// </para>
    ///  
    /// <para>
    /// VPC peering connection operations include:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a>CreateVpcPeeringAuthorization</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeVpcPeeringAuthorizations</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteVpcPeeringAuthorization</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>CreateVpcPeeringConnection</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DescribeVpcPeeringConnections</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a>DeleteVpcPeeringConnection</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class CreateVpcPeeringConnectionRequest : AmazonGameLiftRequest
    {
        private string _fleetId;
        private string _peerVpcAwsAccountId;
        private string _peerVpcId;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// Unique identifier for a fleet. This tells Amazon GameLift which GameLift VPC to peer
        /// with. 
        /// </para>
        /// </summary>
        public string FleetId
        {
            get { return this._fleetId; }
            set { this._fleetId = value; }
        }

        // Check to see if FleetId property is set
        internal bool IsSetFleetId()
        {
            return this._fleetId != null;
        }

        /// <summary>
        /// Gets and sets the property PeerVpcAwsAccountId. 
        /// <para>
        /// Unique identifier for the AWS account with the VPC that you want to peer your Amazon
        /// GameLift fleet with. You can find your Account ID in the AWS Management Console under
        /// account settings.
        /// </para>
        /// </summary>
        public string PeerVpcAwsAccountId
        {
            get { return this._peerVpcAwsAccountId; }
            set { this._peerVpcAwsAccountId = value; }
        }

        // Check to see if PeerVpcAwsAccountId property is set
        internal bool IsSetPeerVpcAwsAccountId()
        {
            return this._peerVpcAwsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property PeerVpcId. 
        /// <para>
        /// Unique identifier for a VPC with resources to be accessed by your Amazon GameLift
        /// fleet. The VPC must be in the same region where your fleet is deployed. To get VPC
        /// information, including IDs, use the Virtual Private Cloud service tools, including
        /// the VPC Dashboard in the AWS Management Console.
        /// </para>
        /// </summary>
        public string PeerVpcId
        {
            get { return this._peerVpcId; }
            set { this._peerVpcId = value; }
        }

        // Check to see if PeerVpcId property is set
        internal bool IsSetPeerVpcId()
        {
            return this._peerVpcId != null;
        }

    }
}