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
 * Do not modify this file. This file is generated from the ec2-2014-10-01.normal.json service model.
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
    /// Container for the parameters to the CreateVpcPeeringConnection operation.
    /// Requests a VPC peering connection between two VPCs: a requester VPC that you own and
    /// a peer VPC with which to create the connection. The peer VPC can belong to another
    /// AWS account. The requester VPC and peer VPC cannot have overlapping CIDR blocks.
    /// 
    ///  
    /// <para>
    /// The owner of the peer VPC must accept the peering request to activate the peering
    /// connection. The VPC peering connection request expires after 7 days, after which it
    /// cannot be accepted or rejected.
    /// </para>
    ///  
    /// <para>
    /// A <code>CreateVpcPeeringConnection</code> request between VPCs with overlapping CIDR
    /// blocks results in the VPC peering connection having a status of <code>failed</code>.
    /// </para>
    /// </summary>
    public partial class CreateVpcPeeringConnectionRequest : AmazonEC2Request
    {
        private string _peerOwnerId;
        private string _peerVpcId;
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property PeerOwnerId. 
        /// <para>
        /// The AWS account ID of the owner of the peer VPC.
        /// </para>
        ///  
        /// <para>
        /// Default: Your AWS account ID
        /// </para>
        /// </summary>
        public string PeerOwnerId
        {
            get { return this._peerOwnerId; }
            set { this._peerOwnerId = value; }
        }

        // Check to see if PeerOwnerId property is set
        internal bool IsSetPeerOwnerId()
        {
            return this._peerOwnerId != null;
        }

        /// <summary>
        /// Gets and sets the property PeerVpcId. 
        /// <para>
        /// The ID of the VPC with which you are creating the VPC peering connection.
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
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the requester VPC.
        /// </para>
        /// </summary>
        public string VpcId
        {
            get { return this._vpcId; }
            set { this._vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this._vpcId != null;
        }

    }
}