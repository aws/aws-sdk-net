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
    /// Container for the parameters to the CreateLocalGatewayVirtualInterface operation.
    /// Create a virtual interface for a local gateway.
    /// </summary>
    public partial class CreateLocalGatewayVirtualInterfaceRequest : AmazonEC2Request
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
        /// Gets and sets the property LocalAddress. 
        /// <para>
        /// The IP address assigned to the local gateway virtual interface on the Outpost side.
        /// Only IPv4 is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LocalAddress { get; set; }

        /// <summary>
        /// Checks to see if the LocalAddress property is set.
        /// </summary>
        internal bool IsSetLocalAddress() => this.LocalAddress != null;

        /// <summary>
        /// Gets and sets the property LocalGatewayVirtualInterfaceGroupId. 
        /// <para>
        /// The ID of the local gateway virtual interface group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string LocalGatewayVirtualInterfaceGroupId { get; set; }

        /// <summary>
        /// Checks to see if the LocalGatewayVirtualInterfaceGroupId property is set.
        /// </summary>
        internal bool IsSetLocalGatewayVirtualInterfaceGroupId() => this.LocalGatewayVirtualInterfaceGroupId != null;

        /// <summary>
        /// Gets and sets the property OutpostLagId. 
        /// <para>
        /// References the Link Aggregation Group (LAG) that connects the Outpost to on-premises
        /// network devices.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string OutpostLagId { get; set; }

        /// <summary>
        /// Checks to see if the OutpostLagId property is set.
        /// </summary>
        internal bool IsSetOutpostLagId() => this.OutpostLagId != null;

        /// <summary>
        /// Gets and sets the property PeerAddress. 
        /// <para>
        /// The peer IP address for the local gateway virtual interface. Only IPv4 is supported.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string PeerAddress { get; set; }

        /// <summary>
        /// Checks to see if the PeerAddress property is set.
        /// </summary>
        internal bool IsSetPeerAddress() => this.PeerAddress != null;

        /// <summary>
        /// Gets and sets the property PeerBgpAsn. 
        /// <para>
        /// The Autonomous System Number (ASN) of the Border Gateway Protocol (BGP) peer.
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
        /// Gets and sets the property TagSpecifications. 
        /// <para>
        /// The tags to apply to a resource when the local gateway virtual interface is being
        /// created. 
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
        /// Gets and sets the property Vlan. 
        /// <para>
        /// The virtual local area network (VLAN) used for the local gateway virtual interface.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public int? Vlan { get; set; }

        /// <summary>
        /// Checks to see if the Vlan property is set.
        /// </summary>
        internal bool IsSetVlan() => this.Vlan.HasValue;
    }
}
