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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Describes a core network change event.
    /// </summary>
    public partial class CoreNetworkChangeEventValues
    {
        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// The ID of the attachment if the change event is associated with an attachment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public string AttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentId property is set.
        /// </summary>
        internal bool IsSetAttachmentId() => this.AttachmentId != null;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// For a <c>STATIC_ROUTE</c> event, this is the IP address.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Cidr { get; set; }

        /// <summary>
        /// Checks to see if the Cidr property is set.
        /// </summary>
        internal bool IsSetCidr() => this.Cidr != null;

        /// <summary>
        /// Gets and sets the property EdgeLocation. 
        /// <para>
        /// The edge location for the core network change event.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string EdgeLocation { get; set; }

        /// <summary>
        /// Checks to see if the EdgeLocation property is set.
        /// </summary>
        internal bool IsSetEdgeLocation() => this.EdgeLocation != null;

        /// <summary>
        /// Gets and sets the property NetworkFunctionGroupName. 
        /// <para>
        /// The changed network function group name.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string NetworkFunctionGroupName { get; set; }

        /// <summary>
        /// Checks to see if the NetworkFunctionGroupName property is set.
        /// </summary>
        internal bool IsSetNetworkFunctionGroupName() => this.NetworkFunctionGroupName != null;

        /// <summary>
        /// Gets and sets the property PeerEdgeLocation. 
        /// <para>
        /// The edge location of the peer in a core network change event.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string PeerEdgeLocation { get; set; }

        /// <summary>
        /// Checks to see if the PeerEdgeLocation property is set.
        /// </summary>
        internal bool IsSetPeerEdgeLocation() => this.PeerEdgeLocation != null;

        /// <summary>
        /// Gets and sets the property RoutingPolicyAssociationDetails. 
        /// <para>
        /// The names of the routing policies and other association details in the core network
        /// change values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<RoutingPolicyAssociationDetail> RoutingPolicyAssociationDetails { get; set; } = AWSConfigs.InitializeCollections ? new List<RoutingPolicyAssociationDetail>() : null;

        /// <summary>
        /// Checks to see if the RoutingPolicyAssociationDetails property is set.
        /// </summary>
        internal bool IsSetRoutingPolicyAssociationDetails() => this.RoutingPolicyAssociationDetails != null && (this.RoutingPolicyAssociationDetails.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoutingPolicyDirection. 
        /// <para>
        /// The routing policy direction (inbound/outbound) in a core network change event.
        /// </para>
        /// </summary>
        public RoutingPolicyDirection RoutingPolicyDirection { get; set; }

        /// <summary>
        /// Checks to see if the RoutingPolicyDirection property is set.
        /// </summary>
        internal bool IsSetRoutingPolicyDirection() => this.RoutingPolicyDirection != null;

        /// <summary>
        /// Gets and sets the property SegmentName. 
        /// <para>
        /// The segment name if the change event is associated with a segment.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SegmentName { get; set; }

        /// <summary>
        /// Checks to see if the SegmentName property is set.
        /// </summary>
        internal bool IsSetSegmentName() => this.SegmentName != null;
    }
}
