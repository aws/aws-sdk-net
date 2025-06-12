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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a transit gateway route table announcement.
    /// </summary>
    public partial class TransitGatewayRouteTableAnnouncement
    {
        private TransitGatewayRouteTableAnnouncementDirection _announcementDirection;
        private string _coreNetworkId;
        private DateTime? _creationTime;
        private string _peerCoreNetworkId;
        private string _peeringAttachmentId;
        private string _peerTransitGatewayId;
        private TransitGatewayRouteTableAnnouncementState _state;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private string _transitGatewayId;
        private string _transitGatewayRouteTableAnnouncementId;
        private string _transitGatewayRouteTableId;

        /// <summary>
        /// Gets and sets the property AnnouncementDirection. 
        /// <para>
        /// The direction for the route table announcement.
        /// </para>
        /// </summary>
        public TransitGatewayRouteTableAnnouncementDirection AnnouncementDirection
        {
            get { return this._announcementDirection; }
            set { this._announcementDirection = value; }
        }

        // Check to see if AnnouncementDirection property is set
        internal bool IsSetAnnouncementDirection()
        {
            return this._announcementDirection != null;
        }

        /// <summary>
        /// Gets and sets the property CoreNetworkId. 
        /// <para>
        /// The ID of the core network for the transit gateway route table announcement.
        /// </para>
        /// </summary>
        public string CoreNetworkId
        {
            get { return this._coreNetworkId; }
            set { this._coreNetworkId = value; }
        }

        // Check to see if CoreNetworkId property is set
        internal bool IsSetCoreNetworkId()
        {
            return this._coreNetworkId != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// The timestamp when the transit gateway route table announcement was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PeerCoreNetworkId. 
        /// <para>
        /// The ID of the core network ID for the peer.
        /// </para>
        /// </summary>
        public string PeerCoreNetworkId
        {
            get { return this._peerCoreNetworkId; }
            set { this._peerCoreNetworkId = value; }
        }

        // Check to see if PeerCoreNetworkId property is set
        internal bool IsSetPeerCoreNetworkId()
        {
            return this._peerCoreNetworkId != null;
        }

        /// <summary>
        /// Gets and sets the property PeeringAttachmentId. 
        /// <para>
        /// The ID of the peering attachment.
        /// </para>
        /// </summary>
        public string PeeringAttachmentId
        {
            get { return this._peeringAttachmentId; }
            set { this._peeringAttachmentId = value; }
        }

        // Check to see if PeeringAttachmentId property is set
        internal bool IsSetPeeringAttachmentId()
        {
            return this._peeringAttachmentId != null;
        }

        /// <summary>
        /// Gets and sets the property PeerTransitGatewayId. 
        /// <para>
        /// The ID of the peer transit gateway.
        /// </para>
        /// </summary>
        public string PeerTransitGatewayId
        {
            get { return this._peerTransitGatewayId; }
            set { this._peerTransitGatewayId = value; }
        }

        // Check to see if PeerTransitGatewayId property is set
        internal bool IsSetPeerTransitGatewayId()
        {
            return this._peerTransitGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the transit gateway announcement.
        /// </para>
        /// </summary>
        public TransitGatewayRouteTableAnnouncementState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The key-value pairs associated with the route table announcement.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayId. 
        /// <para>
        /// The ID of the transit gateway.
        /// </para>
        /// </summary>
        public string TransitGatewayId
        {
            get { return this._transitGatewayId; }
            set { this._transitGatewayId = value; }
        }

        // Check to see if TransitGatewayId property is set
        internal bool IsSetTransitGatewayId()
        {
            return this._transitGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayRouteTableAnnouncementId. 
        /// <para>
        /// The ID of the transit gateway route table announcement.
        /// </para>
        /// </summary>
        public string TransitGatewayRouteTableAnnouncementId
        {
            get { return this._transitGatewayRouteTableAnnouncementId; }
            set { this._transitGatewayRouteTableAnnouncementId = value; }
        }

        // Check to see if TransitGatewayRouteTableAnnouncementId property is set
        internal bool IsSetTransitGatewayRouteTableAnnouncementId()
        {
            return this._transitGatewayRouteTableAnnouncementId != null;
        }

        /// <summary>
        /// Gets and sets the property TransitGatewayRouteTableId. 
        /// <para>
        /// The ID of the transit gateway route table.
        /// </para>
        /// </summary>
        public string TransitGatewayRouteTableId
        {
            get { return this._transitGatewayRouteTableId; }
            set { this._transitGatewayRouteTableId = value; }
        }

        // Check to see if TransitGatewayRouteTableId property is set
        internal bool IsSetTransitGatewayRouteTableId()
        {
            return this._transitGatewayRouteTableId != null;
        }

    }
}