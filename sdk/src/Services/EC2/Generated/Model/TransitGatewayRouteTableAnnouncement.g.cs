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
    /// Describes a transit gateway route table announcement.
    /// </summary>
    public partial class TransitGatewayRouteTableAnnouncement
    {
        /// <summary>
        /// Gets and sets the property AnnouncementDirection. 
        /// <para>
        /// The direction for the route table announcement.
        /// </para>
        /// </summary>
        public TransitGatewayRouteTableAnnouncementDirection AnnouncementDirection { get; set; }

        /// <summary>
        /// Checks to see if the AnnouncementDirection property is set.
        /// </summary>
        internal bool IsSetAnnouncementDirection() => this.AnnouncementDirection != null;

        /// <summary>
        /// Gets and sets the property CoreNetworkId. 
        /// <para>
        /// The ID of the core network for the transit gateway route table announcement.
        /// </para>
        /// </summary>
        public string CoreNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the CoreNetworkId property is set.
        /// </summary>
        internal bool IsSetCoreNetworkId() => this.CoreNetworkId != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when the transit gateway route table announcement was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property PeerCoreNetworkId. 
        /// <para>
        /// The ID of the core network ID for the peer.
        /// </para>
        /// </summary>
        public string PeerCoreNetworkId { get; set; }

        /// <summary>
        /// Checks to see if the PeerCoreNetworkId property is set.
        /// </summary>
        internal bool IsSetPeerCoreNetworkId() => this.PeerCoreNetworkId != null;

        /// <summary>
        /// Gets and sets the property PeerTransitGatewayId. 
        /// <para>
        /// The ID of the peer transit gateway.
        /// </para>
        /// </summary>
        public string PeerTransitGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the PeerTransitGatewayId property is set.
        /// </summary>
        internal bool IsSetPeerTransitGatewayId() => this.PeerTransitGatewayId != null;

        /// <summary>
        /// Gets and sets the property PeeringAttachmentId. 
        /// <para>
        /// The ID of the peering attachment.
        /// </para>
        /// </summary>
        public string PeeringAttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the PeeringAttachmentId property is set.
        /// </summary>
        internal bool IsSetPeeringAttachmentId() => this.PeeringAttachmentId != null;

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the transit gateway announcement.
        /// </para>
        /// </summary>
        public TransitGatewayRouteTableAnnouncementState State { get; set; }

        /// <summary>
        /// Checks to see if the State property is set.
        /// </summary>
        internal bool IsSetState() => this.State != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value pairs associated with the route table announcement.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags { get; set; } = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property TransitGatewayId. 
        /// <para>
        /// The ID of the transit gateway.
        /// </para>
        /// </summary>
        public string TransitGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayId() => this.TransitGatewayId != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayRouteTableAnnouncementId. 
        /// <para>
        /// The ID of the transit gateway route table announcement.
        /// </para>
        /// </summary>
        public string TransitGatewayRouteTableAnnouncementId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayRouteTableAnnouncementId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayRouteTableAnnouncementId() => this.TransitGatewayRouteTableAnnouncementId != null;

        /// <summary>
        /// Gets and sets the property TransitGatewayRouteTableId. 
        /// <para>
        /// The ID of the transit gateway route table.
        /// </para>
        /// </summary>
        public string TransitGatewayRouteTableId { get; set; }

        /// <summary>
        /// Checks to see if the TransitGatewayRouteTableId property is set.
        /// </summary>
        internal bool IsSetTransitGatewayRouteTableId() => this.TransitGatewayRouteTableId != null;
    }
}
