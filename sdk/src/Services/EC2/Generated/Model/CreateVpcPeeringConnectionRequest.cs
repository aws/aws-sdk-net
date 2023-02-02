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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVpcPeeringConnection operation.
    /// Requests a VPC peering connection between two VPCs: a requester VPC that you own and
    /// an accepter VPC with which to create the connection. The accepter VPC can belong to
    /// another Amazon Web Services account and can be in a different Region to the requester
    /// VPC. The requester VPC and accepter VPC cannot have overlapping CIDR blocks.
    /// 
    ///  <note> 
    /// <para>
    /// Limitations and rules apply to a VPC peering connection. For more information, see
    /// the <a href="https://docs.aws.amazon.com/vpc/latest/peering/vpc-peering-basics.html#vpc-peering-limitations">limitations</a>
    /// section in the <i>VPC Peering Guide</i>.
    /// </para>
    ///  </note> 
    /// <para>
    /// The owner of the accepter VPC must accept the peering request to activate the peering
    /// connection. The VPC peering connection request expires after 7 days, after which it
    /// cannot be accepted or rejected.
    /// </para>
    ///  
    /// <para>
    /// If you create a VPC peering connection request between VPCs with overlapping CIDR
    /// blocks, the VPC peering connection has a status of <code>failed</code>.
    /// </para>
    /// </summary>
    public partial class CreateVpcPeeringConnectionRequest : AmazonEC2Request
    {
        private string _peerOwnerId;
        private string _peerRegion;
        private string _peerVpcId;
        private List<TagSpecification> _tagSpecifications = new List<TagSpecification>();
        private string _vpcId;

        /// <summary>
        /// Gets and sets the property PeerOwnerId. 
        /// <para>
        /// The Amazon Web Services account ID of the owner of the accepter VPC.
        /// </para>
        ///  
        /// <para>
        /// Default: Your Amazon Web Services account ID
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
        /// Gets and sets the property PeerRegion. 
        /// <para>
        /// The Region code for the accepter VPC, if the accepter VPC is located in a Region other
        /// than the Region in which you make the request.
        /// </para>
        ///  
        /// <para>
        /// Default: The Region in which you make the request.
        /// </para>
        /// </summary>
        public string PeerRegion
        {
            get { return this._peerRegion; }
            set { this._peerRegion = value; }
        }

        // Check to see if PeerRegion property is set
        internal bool IsSetPeerRegion()
        {
            return this._peerRegion != null;
        }

        /// <summary>
        /// Gets and sets the property PeerVpcId. 
        /// <para>
        /// The ID of the VPC with which you are creating the VPC peering connection. You must
        /// specify this parameter in the request.
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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the peering connection.
        /// </para>
        /// </summary>
        public List<TagSpecification> TagSpecifications
        {
            get { return this._tagSpecifications; }
            set { this._tagSpecifications = value; }
        }

        // Check to see if TagSpecifications property is set
        internal bool IsSetTagSpecifications()
        {
            return this._tagSpecifications != null && this._tagSpecifications.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the requester VPC. You must specify this parameter in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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