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
    /// Describes the transit gateway multicast group resources.
    /// </summary>
    public partial class TransitGatewayMulticastGroup
    {
        /// <summary>
        /// Gets and sets the property GroupIpAddress. 
        /// <para>
        /// The IP address assigned to the transit gateway multicast group.
        /// </para>
        /// </summary>
        public string GroupIpAddress { get; set; }

        /// <summary>
        /// Checks to see if the GroupIpAddress property is set.
        /// </summary>
        internal bool IsSetGroupIpAddress() => this.GroupIpAddress != null;

        /// <summary>
        /// Gets and sets the property GroupMember. 
        /// <para>
        /// Indicates that the resource is a transit gateway multicast group member.
        /// </para>
        /// </summary>
        public bool? GroupMember { get; set; }

        /// <summary>
        /// Checks to see if the GroupMember property is set.
        /// </summary>
        internal bool IsSetGroupMember() => this.GroupMember.HasValue;

        /// <summary>
        /// Gets and sets the property GroupSource. 
        /// <para>
        /// Indicates that the resource is a transit gateway multicast group member.
        /// </para>
        /// </summary>
        public bool? GroupSource { get; set; }

        /// <summary>
        /// Checks to see if the GroupSource property is set.
        /// </summary>
        internal bool IsSetGroupSource() => this.GroupSource.HasValue;

        /// <summary>
        /// Gets and sets the property MemberType. 
        /// <para>
        /// The member type (for example, <c>static</c>).
        /// </para>
        /// </summary>
        public MembershipType MemberType { get; set; }

        /// <summary>
        /// Checks to see if the MemberType property is set.
        /// </summary>
        internal bool IsSetMemberType() => this.MemberType != null;

        /// <summary>
        /// Gets and sets the property NetworkInterfaceId. 
        /// <para>
        /// The ID of the transit gateway attachment.
        /// </para>
        /// </summary>
        public string NetworkInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the NetworkInterfaceId property is set.
        /// </summary>
        internal bool IsSetNetworkInterfaceId() => this.NetworkInterfaceId != null;

        /// <summary>
        /// Gets and sets the property ResourceId. 
        /// <para>
        /// The ID of the resource.
        /// </para>
        /// </summary>
        public string ResourceId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceId property is set.
        /// </summary>
        internal bool IsSetResourceId() => this.ResourceId != null;

        /// <summary>
        /// Gets and sets the property ResourceOwnerId. 
        /// <para>
        ///  The ID of the Amazon Web Services account that owns the transit gateway multicast
        /// domain group resource.
        /// </para>
        /// </summary>
        public string ResourceOwnerId { get; set; }

        /// <summary>
        /// Checks to see if the ResourceOwnerId property is set.
        /// </summary>
        internal bool IsSetResourceOwnerId() => this.ResourceOwnerId != null;

        /// <summary>
        /// Gets and sets the property ResourceType. 
        /// <para>
        /// The type of resource, for example a VPC attachment.
        /// </para>
        /// </summary>
        public TransitGatewayAttachmentResourceType ResourceType { get; set; }

        /// <summary>
        /// Checks to see if the ResourceType property is set.
        /// </summary>
        internal bool IsSetResourceType() => this.ResourceType != null;

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// The source type.
        /// </para>
        /// </summary>
        public MembershipType SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;

        /// <summary>
        /// Gets and sets the property SubnetId. 
        /// <para>
        /// The ID of the subnet.
        /// </para>
        /// </summary>
        public string SubnetId { get; set; }

        /// <summary>
        /// Checks to see if the SubnetId property is set.
        /// </summary>
        internal bool IsSetSubnetId() => this.SubnetId != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayAttachmentId. 
        /// <para>
        /// The ID of the transit gateway attachment.
        /// </para>
        /// </summary>
        public string TransitGatewayAttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayAttachmentId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayAttachmentId() => this.TransitGatewayAttachmentId != null;
    }
}
