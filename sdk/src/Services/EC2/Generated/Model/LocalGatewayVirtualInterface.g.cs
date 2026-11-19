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
    /// Describes a local gateway virtual interface.
    /// </summary>
    public partial class LocalGatewayVirtualInterface
    {
        /// <summary>
        /// Gets and sets the property ConfigurationState. 
        /// <para>
        /// The current state of the local gateway virtual interface.
        /// </para>
        /// </summary>
        public LocalGatewayVirtualInterfaceConfigurationState ConfigurationState { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationState property is set.
        /// </summary>
        internal bool IsSetConfigurationState() => this.ConfigurationState != null;

        /// <summary>
        /// Gets and sets the property LocalAddress. 
        /// <para>
        /// The local address.
        /// </para>
        /// </summary>
        public string LocalAddress { get; set; }

        /// <summary>
        /// Checks to see if the LocalAddress property is set.
        /// </summary>
        internal bool IsSetLocalAddress() => this.LocalAddress != null;

        /// <summary>
        /// Gets and sets the property LocalBgpAsn. 
        /// <para>
        /// The Border Gateway Protocol (BGP) Autonomous System Number (ASN) of the local gateway.
        /// </para>
        /// </summary>
        public int? LocalBgpAsn { get; set; }

        /// <summary>
        /// Checks to see if the LocalBgpAsn property is set.
        /// </summary>
        internal bool IsSetLocalBgpAsn() => this.LocalBgpAsn.HasValue;

        /// <summary>
        /// Gets and sets the property LocalGatewayId. 
        /// <para>
        /// The ID of the local gateway.
        /// </para>
        /// </summary>
        public string LocalGatewayId { get; set; }

        /// <summary>
        /// Checks to see if the LocalGatewayId property is set.
        /// </summary>
        internal bool IsSetLocalGatewayId() => this.LocalGatewayId != null;

        /// <summary>
        /// Gets and sets the property LocalGatewayVirtualInterfaceArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the local gateway virtual interface.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1283)]
        public string LocalGatewayVirtualInterfaceArn { get; set; }

        /// <summary>
        /// Checks to see if the LocalGatewayVirtualInterfaceArn property is set.
        /// </summary>
        internal bool IsSetLocalGatewayVirtualInterfaceArn() => this.LocalGatewayVirtualInterfaceArn != null;

        /// <summary>
        /// Gets and sets the property LocalGatewayVirtualInterfaceGroupId. 
        /// <para>
        /// The ID of the local gateway virtual interface group.
        /// </para>
        /// </summary>
        public string LocalGatewayVirtualInterfaceGroupId { get; set; }

        /// <summary>
        /// Checks to see if the LocalGatewayVirtualInterfaceGroupId property is set.
        /// </summary>
        internal bool IsSetLocalGatewayVirtualInterfaceGroupId() => this.LocalGatewayVirtualInterfaceGroupId != null;

        /// <summary>
        /// Gets and sets the property LocalGatewayVirtualInterfaceId. 
        /// <para>
        /// The ID of the virtual interface.
        /// </para>
        /// </summary>
        public string LocalGatewayVirtualInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the LocalGatewayVirtualInterfaceId property is set.
        /// </summary>
        internal bool IsSetLocalGatewayVirtualInterfaceId() => this.LocalGatewayVirtualInterfaceId != null;

        /// <summary>
        /// Gets and sets the property OutpostLagId. 
        /// <para>
        /// The Outpost LAG ID.
        /// </para>
        /// </summary>
        public string OutpostLagId { get; set; }

        /// <summary>
        /// Checks to see if the OutpostLagId property is set.
        /// </summary>
        internal bool IsSetOutpostLagId() => this.OutpostLagId != null;

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the local gateway virtual interface.
        /// </para>
        /// </summary>
        public string OwnerId { get; set; }

        /// <summary>
        /// Checks to see if the OwnerId property is set.
        /// </summary>
        internal bool IsSetOwnerId() => this.OwnerId != null;

        /// <summary>
        /// Gets and sets the property PeerAddress. 
        /// <para>
        /// The peer address.
        /// </para>
        /// </summary>
        public string PeerAddress { get; set; }

        /// <summary>
        /// Checks to see if the PeerAddress property is set.
        /// </summary>
        internal bool IsSetPeerAddress() => this.PeerAddress != null;

        /// <summary>
        /// Gets and sets the property PeerBgpAsn. 
        /// <para>
        /// The peer BGP ASN.
        /// </para>
        /// </summary>
        public int? PeerBgpAsn { get; set; }

        /// <summary>
        /// Checks to see if the PeerBgpAsn property is set.
        /// </summary>
        internal bool IsSetPeerBgpAsn() => this.PeerBgpAsn.HasValue;

        /// <summary>
        /// Gets and sets the property PeerBgpAsnExtended. 
        /// <para>
        /// The extended 32-bit ASN of the BGP peer for use with larger ASN values.
        /// </para>
        /// </summary>
        public long? PeerBgpAsnExtended { get; set; }

        /// <summary>
        /// Checks to see if the PeerBgpAsnExtended property is set.
        /// </summary>
        internal bool IsSetPeerBgpAsnExtended() => this.PeerBgpAsnExtended.HasValue;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the virtual interface.
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
        /// Gets and sets the property Vlan. 
        /// <para>
        /// The ID of the VLAN.
        /// </para>
        /// </summary>
        public int? Vlan { get; set; }

        /// <summary>
        /// Checks to see if the Vlan property is set.
        /// </summary>
        internal bool IsSetVlan() => this.Vlan.HasValue;
    }
}
