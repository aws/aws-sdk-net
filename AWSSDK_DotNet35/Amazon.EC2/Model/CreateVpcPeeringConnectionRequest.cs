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
    /// <para>Requests a VPC peering connection between two VPCs: a requester VPC that you own and a peer VPC with which to create the connection.
    /// The peer VPC can belong to another AWS account. The requester VPC and peer VPC cannot have overlapping CIDR blocks.</para> <para>The owner
    /// of the peer VPC must accept the peering request to activate the peering connection. The VPC peering connection request expires after 7 days,
    /// after which it cannot be accepted or rejected.</para> <para>A <c>CreateVpcPeeringConnection</c> request between VPCs with overlapping CIDR
    /// blocks results in the VPC peering connection having a status of <c>failed</c> .</para>
    /// </summary>
    public partial class CreateVpcPeeringConnectionRequest : AmazonEC2Request
    {
        private string vpcId;
        private string peerVpcId;
        private string peerOwnerId;


        /// <summary>
        /// The ID of the requester VPC.
        ///  
        /// </summary>
        public string VpcId
        {
            get { return this.vpcId; }
            set { this.vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
        }

        /// <summary>
        /// The ID of the VPC with which you are creating the VPC peering connection.
        ///  
        /// </summary>
        public string PeerVpcId
        {
            get { return this.peerVpcId; }
            set { this.peerVpcId = value; }
        }

        // Check to see if PeerVpcId property is set
        internal bool IsSetPeerVpcId()
        {
            return this.peerVpcId != null;
        }

        /// <summary>
        /// The AWS account ID of the owner of the peer VPC. Default: Your AWS account ID
        ///  
        /// </summary>
        public string PeerOwnerId
        {
            get { return this.peerOwnerId; }
            set { this.peerOwnerId = value; }
        }

        // Check to see if PeerOwnerId property is set
        internal bool IsSetPeerOwnerId()
        {
            return this.peerOwnerId != null;
        }

    }
}
    
