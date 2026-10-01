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
    /// Describes a core network change.
    /// </summary>
    public partial class CoreNetworkChangeValues
    {
        /// <summary>
        /// Gets and sets the property Asn. 
        /// <para>
        /// The ASN of a core network.
        /// </para>
        /// </summary>
        public long? Asn { get; set; }

        /// <summary>
        /// Checks to see if the Asn property is set.
        /// </summary>
        internal bool IsSetAsn() => this.Asn.HasValue;

        /// <summary>
        /// Gets and sets the property AttachmentId. 
        /// <para>
        /// The attachment identifier in the core network change values.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string AttachmentId { get; set; }

        /// <summary>
        /// Checks to see if the AttachmentId property is set.
        /// </summary>
        internal bool IsSetAttachmentId() => this.AttachmentId != null;

        /// <summary>
        /// Gets and sets the property Cidr. 
        /// <para>
        /// The IP addresses used for a core network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Cidr { get; set; }

        /// <summary>
        /// Checks to see if the Cidr property is set.
        /// </summary>
        internal bool IsSetCidr() => this.Cidr != null;

        /// <summary>
        /// Gets and sets the property DestinationIdentifier. 
        /// <para>
        /// The ID of the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string DestinationIdentifier { get; set; }

        /// <summary>
        /// Checks to see if the DestinationIdentifier property is set.
        /// </summary>
        internal bool IsSetDestinationIdentifier() => this.DestinationIdentifier != null;

        /// <summary>
        /// Gets and sets the property DnsSupport. 
        /// <para>
        /// Indicates whether public DNS support is supported. The default is <c>true</c>. 
        /// </para>
        /// </summary>
        public bool? DnsSupport { get; set; }

        /// <summary>
        /// Checks to see if the DnsSupport property is set.
        /// </summary>
        internal bool IsSetDnsSupport() => this.DnsSupport.HasValue;

        /// <summary>
        /// Gets and sets the property EdgeLocations. 
        /// <para>
        /// The Regions where edges are located in a core network. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> EdgeLocations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the EdgeLocations property is set.
        /// </summary>
        internal bool IsSetEdgeLocations() => this.EdgeLocations != null && (this.EdgeLocations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property InsideCidrBlocks. 
        /// <para>
        /// The inside IP addresses used for core network change values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InsideCidrBlocks { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the InsideCidrBlocks property is set.
        /// </summary>
        internal bool IsSetInsideCidrBlocks() => this.InsideCidrBlocks != null && (this.InsideCidrBlocks.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property NetworkFunctionGroupName. 
        /// <para>
        /// The network function group name if the change event is associated with a network function
        /// group.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string NetworkFunctionGroupName { get; set; }

        /// <summary>
        /// Checks to see if the NetworkFunctionGroupName property is set.
        /// </summary>
        internal bool IsSetNetworkFunctionGroupName() => this.NetworkFunctionGroupName != null;

        /// <summary>
        /// Gets and sets the property PeerEdgeLocations. 
        /// <para>
        /// The edge locations of peers in the core network change values.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> PeerEdgeLocations { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the PeerEdgeLocations property is set.
        /// </summary>
        internal bool IsSetPeerEdgeLocations() => this.PeerEdgeLocations != null && (this.PeerEdgeLocations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RoutingPolicy. 
        /// <para>
        /// The routing policy configuration in the core network change values.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000000)]
        public string RoutingPolicy { get; set; }

        /// <summary>
        /// Checks to see if the RoutingPolicy property is set.
        /// </summary>
        internal bool IsSetRoutingPolicy() => this.RoutingPolicy != null;

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
        /// Gets and sets the property SecurityGroupReferencingSupport. 
        /// <para>
        /// Indicates whether security group referencing is enabled for the core network.
        /// </para>
        /// </summary>
        public bool? SecurityGroupReferencingSupport { get; set; }

        /// <summary>
        /// Checks to see if the SecurityGroupReferencingSupport property is set.
        /// </summary>
        internal bool IsSetSecurityGroupReferencingSupport() => this.SecurityGroupReferencingSupport.HasValue;

        /// <summary>
        /// Gets and sets the property SegmentName. 
        /// <para>
        /// The names of the segments in a core network.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string SegmentName { get; set; }

        /// <summary>
        /// Checks to see if the SegmentName property is set.
        /// </summary>
        internal bool IsSetSegmentName() => this.SegmentName != null;

        /// <summary>
        /// Gets and sets the property ServiceInsertionActions. 
        /// <para>
        /// Describes the service insertion action. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ServiceInsertionAction> ServiceInsertionActions { get; set; } = AWSConfigs.InitializeCollections ? new List<ServiceInsertionAction>() : null;

        /// <summary>
        /// Checks to see if the ServiceInsertionActions property is set.
        /// </summary>
        internal bool IsSetServiceInsertionActions() => this.ServiceInsertionActions != null && (this.ServiceInsertionActions.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SharedSegments. 
        /// <para>
        /// The shared segments for a core network change value. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SharedSegments { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the SharedSegments property is set.
        /// </summary>
        internal bool IsSetSharedSegments() => this.SharedSegments != null && (this.SharedSegments.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property VpnEcmpSupport. 
        /// <para>
        /// Indicates whether Equal Cost Multipath (ECMP) is enabled for the core network.
        /// </para>
        /// </summary>
        public bool? VpnEcmpSupport { get; set; }

        /// <summary>
        /// Checks to see if the VpnEcmpSupport property is set.
        /// </summary>
        internal bool IsSetVpnEcmpSupport() => this.VpnEcmpSupport.HasValue;
    }
}
