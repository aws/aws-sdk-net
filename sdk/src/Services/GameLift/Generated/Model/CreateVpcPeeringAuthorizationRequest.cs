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
    /// Container for the parameters to the CreateVpcPeeringAuthorization operation.
    /// Requests authorization to create or delete a peer connection between the VPC for your
    /// Amazon GameLift fleet and a virtual private cloud (VPC) in your AWS account. VPC peering
    /// enables the game servers on your fleet to communicate directly with other AWS resources.
    /// Once you've received authorization, call <a>CreateVpcPeeringConnection</a> to establish
    /// the peering connection. For more information, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/vpc-peering.html">VPC
    /// Peering with Amazon GameLift Fleets</a>.
    /// 
    ///  
    /// <para>
    /// You can peer with VPCs that are owned by any AWS account you have access to, including
    /// the account that you use to manage your Amazon GameLift fleets. You cannot peer with
    /// VPCs that are in different regions.
    /// </para>
    ///  
    /// <para>
    /// To request authorization to create a connection, call this operation from the AWS
    /// account with the VPC that you want to peer to your Amazon GameLift fleet. For example,
    /// to enable your game servers to retrieve data from a DynamoDB table, use the account
    /// that manages that DynamoDB resource. Identify the following values: (1) The ID of
    /// the VPC that you want to peer with, and (2) the ID of the AWS account that you use
    /// to manage Amazon GameLift. If successful, VPC peering is authorized for the specified
    /// VPC. 
    /// </para>
    ///  
    /// <para>
    /// To request authorization to delete a connection, call this operation from the AWS
    /// account with the VPC that is peered with your Amazon GameLift fleet. Identify the
    /// following values: (1) VPC ID that you want to delete the peering connection for, and
    /// (2) ID of the AWS account that you use to manage Amazon GameLift. 
    /// </para>
    ///  
    /// <para>
    /// The authorization remains valid for 24 hours unless it is canceled by a call to <a>DeleteVpcPeeringAuthorization</a>.
    /// You must create or delete the peering connection while the authorization is valid.
    /// 
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
    public partial class CreateVpcPeeringAuthorizationRequest : AmazonGameLiftRequest
    {
        private string _gameLiftAwsAccountId;
        private string _peerVpcId;

        /// <summary>
        /// Gets and sets the property GameLiftAwsAccountId. 
        /// <para>
        /// Unique identifier for the AWS account that you use to manage your Amazon GameLift
        /// fleet. You can find your Account ID in the AWS Management Console under account settings.
        /// </para>
        /// </summary>
        public string GameLiftAwsAccountId
        {
            get { return this._gameLiftAwsAccountId; }
            set { this._gameLiftAwsAccountId = value; }
        }

        // Check to see if GameLiftAwsAccountId property is set
        internal bool IsSetGameLiftAwsAccountId()
        {
            return this._gameLiftAwsAccountId != null;
        }

        /// <summary>
        /// Gets and sets the property PeerVpcId. 
        /// <para>
        /// Unique identifier for a VPC with resources to be accessed by your Amazon GameLift
        /// fleet. The VPC must be in the same region where your fleet is deployed. Look up a
        /// VPC ID using the <a href="https://console.aws.amazon.com/vpc/">VPC Dashboard</a> in
        /// the AWS Management Console. Learn more about VPC peering in <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/vpc-peering.html">VPC
        /// Peering with Amazon GameLift Fleets</a>.
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