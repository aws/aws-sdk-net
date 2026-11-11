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
 * Do not modify this file. This file is generated from the smithy.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;
using Amazon.Runtime;
using Amazon.Runtime.Internal;

#pragma warning disable CS0612,CS0618,CS1570

namespace Amazon.EC2.Model
{
    /// <summary>
    /// Container for the parameters to the CreateVpcPeeringConnection operation. Requests
    /// a VPC peering connection between two VPCs: a requester VPC that you own and an accepter
    /// VPC with which to create the connection. The accepter VPC can belong to another Amazon
    /// Web Services account and can be in a different Region to the requester VPC. The requester
    /// VPC and accepter VPC cannot have overlapping CIDR blocks. <note> <para> Limitations
    /// and rules apply to a VPC peering connection. For more information, see the <a href="https://docs.aws.amazon.com/vpc/latest/peering/vpc-peering-basics.html#vpc-peering-limitations">VPC
    /// peering limitations</a> in the <i>VPC Peering Guide</i>. </para> </note> <para> The
    /// owner of the accepter VPC must accept the peering request to activate the peering
    /// connection. The VPC peering connection request expires after 7 days, after which it
    /// cannot be accepted or rejected. </para> <para> If you create a VPC peering connection
    /// request between VPCs with overlapping CIDR blocks, the VPC peering connection has
    /// a status of <c>failed</c>. </para>
    /// </summary>
    public partial class CreateVpcPeeringConnectionRequest : AmazonEC2Request
    {
        /// <summary>
        /// Gets and sets the property DryRun. 
        /// <para>
        /// Checks whether you have the required permissions for the action, without actually
        /// making the request, and provides an error response. If you have the required permissions,
        /// the error response is <c>DryRunOperation</c>. Otherwise, it is <c>UnauthorizedOperation</c>.
        /// </para>
        /// </summary>
        public bool? DryRun { get; set; }

        /// <summary>
        /// Checks to see if the DryRun property is set.
        /// </summary>
        internal bool IsSetDryRun() => this.DryRun.HasValue;

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
        public string PeerOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the PeerOwnerId property is set.
        /// </summary>
        internal bool IsSetPeerOwnerId() => this.PeerOwnerId != null;

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
        public string PeerRegion { get; set; }

        /// <summary>
        /// Checks to see if the PeerRegion property is set.
        /// </summary>
        internal bool IsSetPeerRegion() => this.PeerRegion != null;

        /// <summary>
        /// Gets and sets the property PeerVpcId. 
        /// <para>
        /// The ID of the VPC with which you are creating the VPC peering connection. You must
        /// specify this parameter in the request.
        /// </para>
        /// </summary>
        public string PeerVpcId { get; set; }

        /// <summary>
        /// Checks to see if the PeerVpcId property is set.
        /// </summary>
        internal bool IsSetPeerVpcId() => this.PeerVpcId != null;

        /// <summary>
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to assign to the peering connection.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TagSpecification> TagSpecifications { get; set; } = AWSConfigs.InitializeCollections ? new List<TagSpecification>() : null;

        /// <summary>
        /// Checks to see if the TagSpecifications property is set.
        /// </summary>
        internal bool IsSetTagSpecifications() => this.TagSpecifications != null && (this.TagSpecifications.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpcId. 
        /// <para>
        /// The ID of the requester VPC. You must specify this parameter in the request.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string VpcId { get; set; }

        /// <summary>
        /// Checks to see if the VpcId property is set.
        /// </summary>
        internal bool IsSetVpcId() => this.VpcId != null;
    }
}
