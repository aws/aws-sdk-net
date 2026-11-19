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
    /// Describes the service link virtual interfaces that establish connectivity between
    /// Amazon Web Services Outpost and on-premises networks.
    /// </summary>
    public partial class ServiceLinkVirtualInterface
    {
        /// <summary>
        /// Gets and sets the property ConfigurationState. 
        /// <para>
        /// The current state of the service link virtual interface.
        /// </para>
        /// </summary>
        public ServiceLinkVirtualInterfaceConfigurationState ConfigurationState { get; set; }

        /// <summary>
        /// Checks to see if the ConfigurationState property is set.
        /// </summary>
        internal bool IsSetConfigurationState() => this.ConfigurationState != null;

        /// <summary>
        /// Gets and sets the property LocalAddress. 
        /// <para>
        /// The IPv4 address assigned to the local gateway virtual interface on the Outpost side.
        /// </para>
        /// </summary>
        public string LocalAddress { get; set; }

        /// <summary>
        /// Checks to see if the LocalAddress property is set.
        /// </summary>
        internal bool IsSetLocalAddress() => this.LocalAddress != null;

        /// <summary>
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The Outpost Amazon Resource Number (ARN) for the service link virtual interface.
        /// </para>
        /// </summary>
        public string OutpostArn { get; set; }

        /// <summary>
        /// Checks to see if the OutpostArn property is set.
        /// </summary>
        internal bool IsSetOutpostArn() => this.OutpostArn != null;

        /// <summary>
        /// Gets and sets the property OutpostId. 
        /// <para>
        /// The Outpost ID for the service link virtual interface.
        /// </para>
        /// </summary>
        public string OutpostId { get; set; }

        /// <summary>
        /// Checks to see if the OutpostId property is set.
        /// </summary>
        internal bool IsSetOutpostId() => this.OutpostId != null;

        /// <summary>
        /// Gets and sets the property OutpostLagId. 
        /// <para>
        /// The link aggregation group (LAG) ID for the service link virtual interface.
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
        /// The ID of the Amazon Web Services account that owns the service link virtual interface..
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
        /// The IPv4 peer address for the service link virtual interface.
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
        /// The ASN for the Border Gateway Protocol (BGP) associated with the service link virtual
        /// interface.
        /// </para>
        /// </summary>
        public long? PeerBgpAsn { get; set; }

        /// <summary>
        /// Checks to see if the PeerBgpAsn property is set.
        /// </summary>
        internal bool IsSetPeerBgpAsn() => this.PeerBgpAsn.HasValue;

        /// <summary>
        /// Gets and sets the property ServiceLinkVirtualInterfaceArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) for the service link virtual interface. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1283)]
        public string ServiceLinkVirtualInterfaceArn { get; set; }

        /// <summary>
        /// Checks to see if the ServiceLinkVirtualInterfaceArn property is set.
        /// </summary>
        internal bool IsSetServiceLinkVirtualInterfaceArn() => this.ServiceLinkVirtualInterfaceArn != null;

        /// <summary>
        /// Gets and sets the property ServiceLinkVirtualInterfaceId. 
        /// <para>
        /// The ID of the service link virtual interface.
        /// </para>
        /// </summary>
        public string ServiceLinkVirtualInterfaceId { get; set; }

        /// <summary>
        /// Checks to see if the ServiceLinkVirtualInterfaceId property is set.
        /// </summary>
        internal bool IsSetServiceLinkVirtualInterfaceId() => this.ServiceLinkVirtualInterfaceId != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the service link virtual interface.
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
        /// The virtual local area network for the service link virtual interface.
        /// </para>
        /// </summary>
        public int? Vlan { get; set; }

        /// <summary>
        /// Checks to see if the Vlan property is set.
        /// </summary>
        internal bool IsSetVlan() => this.Vlan.HasValue;
    }
}
