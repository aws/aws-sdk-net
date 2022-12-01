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
    /// Container for the parameters to the CreateVpcPeeringConnection operation.
    /// Establishes a VPC peering connection between a virtual private cloud (VPC) in an Amazon
    /// Web Services account with the VPC for your Amazon GameLift fleet. VPC peering enables
    /// the game servers on your fleet to communicate directly with other Amazon Web Services
    /// resources. You can peer with VPCs in any Amazon Web Services account that you have
    /// access to, including the account that you use to manage your Amazon GameLift fleets.
    /// You cannot peer with VPCs that are in different Regions. For more information, see
    /// <a href="https://docs.aws.amazon.com/gamelift/latest/developerguide/vpc-peering.html">VPC
    /// Peering with Amazon GameLift Fleets</a>.
    /// 
    ///  
    /// <para>
    /// Before calling this operation to establish the peering connection, you first need
    /// to use <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_CreateVpcPeeringAuthorization.html">CreateVpcPeeringAuthorization</a>
    /// and identify the VPC you want to peer with. Once the authorization for the specified
    /// VPC is issued, you have 24 hours to establish the connection. These two operations
    /// handle all tasks necessary to peer the two VPCs, including acceptance, updating routing
    /// tables, etc. 
    /// </para>
    ///  
    /// <para>
    /// To establish the connection, call this operation from the Amazon Web Services account
    /// that is used to manage the Amazon GameLift fleets. Identify the following values:
    /// (1) The ID of the fleet you want to be enable a VPC peering connection for; (2) The
    /// Amazon Web Services account with the VPC that you want to peer with; and (3) The ID
    /// of the VPC you want to peer with. This operation is asynchronous. If successful, a
    /// connection request is created. You can use continuous polling to track the request's
    /// status using <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeVpcPeeringConnections.html">DescribeVpcPeeringConnections</a>
    /// , or by monitoring fleet events for success or failure using <a href="https://docs.aws.amazon.com/gamelift/latest/apireference/API_DescribeFleetEvents.html">DescribeFleetEvents</a>
    /// . 
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
    public partial class CreateVpcPeeringConnectionRequest : AmazonGameLiftRequest
    {
        private string _fleetId;
        private string _peerVpcAwsAccountId;
        private string _peerVpcId;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// A unique identifier for the fleet. You can use either the fleet ID or ARN value. This
        /// tells Amazon GameLift which GameLift VPC to peer with. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// A unique identifier for the Amazon Web Services account with the VPC that you want
        /// to peer your Amazon GameLift fleet with. You can find your Account ID in the Amazon
        /// Web Services Management Console under account settings.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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