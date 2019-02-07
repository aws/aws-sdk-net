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
    /// Represents a peering connection between a VPC on one of your AWS accounts and the
    /// VPC for your Amazon GameLift fleets. This record may be for an active peering connection
    /// or a pending connection that has not yet been established.
    /// 
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
    public partial class VpcPeeringConnection
    {
        private string _fleetId;
        private string _gameLiftVpcId;
        private string _ipV4CidrBlock;
        private string _peerVpcId;
        private VpcPeeringConnectionStatus _status;
        private string _vpcPeeringConnectionId;

        /// <summary>
        /// Gets and sets the property FleetId. 
        /// <para>
        /// Unique identifier for a fleet. This ID determines the ID of the Amazon GameLift VPC
        /// for your fleet.
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
        /// Gets and sets the property GameLiftVpcId. 
        /// <para>
        /// Unique identifier for the VPC that contains the Amazon GameLift fleet for this connection.
        /// This VPC is managed by Amazon GameLift and does not appear in your AWS account. 
        /// </para>
        /// </summary>
        public string GameLiftVpcId
        {
            get { return this._gameLiftVpcId; }
            set { this._gameLiftVpcId = value; }
        }

        // Check to see if GameLiftVpcId property is set
        internal bool IsSetGameLiftVpcId()
        {
            return this._gameLiftVpcId != null;
        }

        /// <summary>
        /// Gets and sets the property IpV4CidrBlock. 
        /// <para>
        /// CIDR block of IPv4 addresses assigned to the VPC peering connection for the GameLift
        /// VPC. The peered VPC also has an IPv4 CIDR block associated with it; these blocks cannot
        /// overlap or the peering connection cannot be created. 
        /// </para>
        /// </summary>
        public string IpV4CidrBlock
        {
            get { return this._ipV4CidrBlock; }
            set { this._ipV4CidrBlock = value; }
        }

        // Check to see if IpV4CidrBlock property is set
        internal bool IsSetIpV4CidrBlock()
        {
            return this._ipV4CidrBlock != null;
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

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Object that contains status information about the connection. Status indicates if
        /// a connection is pending, successful, or failed.
        /// </para>
        /// </summary>
        public VpcPeeringConnectionStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property VpcPeeringConnectionId. 
        /// <para>
        /// Unique identifier that is automatically assigned to the connection record. This ID
        /// is referenced in VPC peering connection events, and is used when deleting a connection
        /// with <a>DeleteVpcPeeringConnection</a>. 
        /// </para>
        /// </summary>
        public string VpcPeeringConnectionId
        {
            get { return this._vpcPeeringConnectionId; }
            set { this._vpcPeeringConnectionId = value; }
        }

        // Check to see if VpcPeeringConnectionId property is set
        internal bool IsSetVpcPeeringConnectionId()
        {
            return this._vpcPeeringConnectionId != null;
        }

    }
}