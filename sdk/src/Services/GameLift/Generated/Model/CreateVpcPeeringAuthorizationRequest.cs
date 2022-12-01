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
 * Do not modify this file. This file is generated from the gamelift-2015-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.GameLift.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVpcPeeringAuthorization operation.
    /// Requests authorization to create or delete a peer connection between the VPC for your
    /// Amazon GameLift fleet and a virtual private cloud (VPC) in your Amazon Web Services
    /// account. VPC peering enables the game servers on your fleet to communicate directly
    /// with other Amazon Web Services resources. After you've received authorization, use
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateVpcPeeringConnection.html">CreateVpcPeeringConnection</a>
    /// to establish the peering connection. For more information, see <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/vpc-peering.html">VPC
    /// Peering with Amazon GameLift Fleets</a>.
    /// 
    ///  
    /// <para>
    /// You can peer with VPCs that are owned by any Amazon Web Services account you have
    /// access to, including the account that you use to manage your Amazon GameLift fleets.
    /// You cannot peer with VPCs that are in different Regions.
    /// </para>
    ///  
    /// <para>
    /// To request authorization to create a connection, call this operation from the Amazon
    /// Web Services account with the VPC that you want to peer to your Amazon GameLift fleet.
    /// For example, to enable your game servers to retrieve data from a DynamoDB table, use
    /// the account that manages that DynamoDB resource. Identify the following values: (1)
    /// The ID of the VPC that you want to peer with, and (2) the ID of the Amazon Web Services
    /// account that you use to manage Amazon GameLift. If successful, VPC peering is authorized
    /// for the specified VPC. 
    /// </para>
    ///  
    /// <para>
    /// To request authorization to delete a connection, call this operation from the Amazon
    /// Web Services account with the VPC that is peered with your Amazon GameLift fleet.
    /// Identify the following values: (1) VPC ID that you want to delete the peering connection
    /// for, and (2) ID of the Amazon Web Services account that you use to manage Amazon GameLift.
    /// 
    /// </para>
    ///  
    /// <para>
    /// The authorization remains valid for 24 hours unless it is canceled. You must create
    /// or delete the peering connection while the authorization is valid. 
    /// </para>
    ///  
    /// <para>
    ///  <b>Related actions</b> 
    /// </para>
    ///  
    /// <para>
    ///  <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/reference-awssdk.html#reference-awssdk-resources-fleets">All
    /// APIs by task</a> 
    /// </para>
    /// </summary>
    public partial class CreateVpcPeeringAuthorizationRequest : AmazonGameLiftRequest
    {
        private string _gameLiftAwsAccountId;
        private string _peerVpcId;

        /// <summary>
        /// Gets and sets the property GameLiftAwsAccountId. 
        /// <para>
        /// A unique identifier for the Amazon Web Services account that you use to manage your
        /// GameLift fleet. You can find your Account ID in the Amazon Web Services Management
        /// Console under account settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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
        /// A unique identifier for a VPC with resources to be accessed by your GameLift fleet.
        /// The VPC must be in the same Region as your fleet. To look up a VPC ID, use the <a
        /// href="https://console.aws.amazon.com/vpc/">VPC Dashboard</a> in the Amazon Web Services
        /// Management Console. Learn more about VPC peering in <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/vpc-peering.html">VPC
        /// Peering with GameLift Fleets</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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