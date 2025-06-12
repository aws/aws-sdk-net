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
    /// Describes a local gateway virtual interface.
    /// </summary>
    public partial class LocalGatewayVirtualInterface
    {
        private LocalGatewayVirtualInterfaceConfigurationState _configurationState;
        private string _localAddress;
        private int? _localBgpAsn;
        private string _localGatewayId;
        private string _localGatewayVirtualInterfaceArn;
        private string _localGatewayVirtualInterfaceGroupId;
        private string _localGatewayVirtualInterfaceId;
        private string _outpostLagId;
        private string _ownerId;
        private string _peerAddress;
        private int? _peerBgpAsn;
        private long? _peerBgpAsnExtended;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private int? _vlan;

        /// <summary>
        /// Gets and sets the property ConfigurationState. 
        /// <para>
        /// The current state of the local gateway virtual interface.
        /// </para>
        /// </summary>
        public LocalGatewayVirtualInterfaceConfigurationState ConfigurationState
        {
            get { return this._configurationState; }
            set { this._configurationState = value; }
        }

        // Check to see if ConfigurationState property is set
        internal bool IsSetConfigurationState()
        {
            return this._configurationState != null;
        }

        /// <summary>
        /// Gets and sets the property LocalAddress. 
        /// <para>
        /// The local address.
        /// </para>
        /// </summary>
        public string LocalAddress
        {
            get { return this._localAddress; }
            set { this._localAddress = value; }
        }

        // Check to see if LocalAddress property is set
        internal bool IsSetLocalAddress()
        {
            return this._localAddress != null;
        }

        /// <summary>
        /// Gets and sets the property LocalBgpAsn. 
        /// <para>
        /// The Border Gateway Protocol (BGP) Autonomous System Number (ASN) of the local gateway.
        /// </para>
        /// </summary>
        public int? LocalBgpAsn
        {
            get { return this._localBgpAsn; }
            set { this._localBgpAsn = value; }
        }

        // Check to see if LocalBgpAsn property is set
        internal bool IsSetLocalBgpAsn()
        {
            return this._localBgpAsn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LocalGatewayId. 
        /// <para>
        /// The ID of the local gateway.
        /// </para>
        /// </summary>
        public string LocalGatewayId
        {
            get { return this._localGatewayId; }
            set { this._localGatewayId = value; }
        }

        // Check to see if LocalGatewayId property is set
        internal bool IsSetLocalGatewayId()
        {
            return this._localGatewayId != null;
        }

        /// <summary>
        /// Gets and sets the property LocalGatewayVirtualInterfaceArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) of the local gateway virtual interface.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string LocalGatewayVirtualInterfaceArn
        {
            get { return this._localGatewayVirtualInterfaceArn; }
            set { this._localGatewayVirtualInterfaceArn = value; }
        }

        // Check to see if LocalGatewayVirtualInterfaceArn property is set
        internal bool IsSetLocalGatewayVirtualInterfaceArn()
        {
            return this._localGatewayVirtualInterfaceArn != null;
        }

        /// <summary>
        /// Gets and sets the property LocalGatewayVirtualInterfaceGroupId. 
        /// <para>
        /// The ID of the local gateway virtual interface group.
        /// </para>
        /// </summary>
        public string LocalGatewayVirtualInterfaceGroupId
        {
            get { return this._localGatewayVirtualInterfaceGroupId; }
            set { this._localGatewayVirtualInterfaceGroupId = value; }
        }

        // Check to see if LocalGatewayVirtualInterfaceGroupId property is set
        internal bool IsSetLocalGatewayVirtualInterfaceGroupId()
        {
            return this._localGatewayVirtualInterfaceGroupId != null;
        }

        /// <summary>
        /// Gets and sets the property LocalGatewayVirtualInterfaceId. 
        /// <para>
        /// The ID of the virtual interface.
        /// </para>
        /// </summary>
        public string LocalGatewayVirtualInterfaceId
        {
            get { return this._localGatewayVirtualInterfaceId; }
            set { this._localGatewayVirtualInterfaceId = value; }
        }

        // Check to see if LocalGatewayVirtualInterfaceId property is set
        internal bool IsSetLocalGatewayVirtualInterfaceId()
        {
            return this._localGatewayVirtualInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property OutpostLagId. 
        /// <para>
        /// The Outpost LAG ID.
        /// </para>
        /// </summary>
        public string OutpostLagId
        {
            get { return this._outpostLagId; }
            set { this._outpostLagId = value; }
        }

        // Check to see if OutpostLagId property is set
        internal bool IsSetOutpostLagId()
        {
            return this._outpostLagId != null;
        }

        /// <summary>
        /// Gets and sets the property OwnerId. 
        /// <para>
        /// The ID of the Amazon Web Services account that owns the local gateway virtual interface.
        /// </para>
        /// </summary>
        public string OwnerId
        {
            get { return this._ownerId; }
            set { this._ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this._ownerId != null;
        }

        /// <summary>
        /// Gets and sets the property PeerAddress. 
        /// <para>
        /// The peer address.
        /// </para>
        /// </summary>
        public string PeerAddress
        {
            get { return this._peerAddress; }
            set { this._peerAddress = value; }
        }

        // Check to see if PeerAddress property is set
        internal bool IsSetPeerAddress()
        {
            return this._peerAddress != null;
        }

        /// <summary>
        /// Gets and sets the property PeerBgpAsn. 
        /// <para>
        /// The peer BGP ASN.
        /// </para>
        /// </summary>
        public int? PeerBgpAsn
        {
            get { return this._peerBgpAsn; }
            set { this._peerBgpAsn = value; }
        }

        // Check to see if PeerBgpAsn property is set
        internal bool IsSetPeerBgpAsn()
        {
            return this._peerBgpAsn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PeerBgpAsnExtended. 
        /// <para>
        /// The extended 32-bit ASN of the BGP peer for use with larger ASN values.
        /// </para>
        /// </summary>
        public long? PeerBgpAsnExtended
        {
            get { return this._peerBgpAsnExtended; }
            set { this._peerBgpAsnExtended = value; }
        }

        // Check to see if PeerBgpAsnExtended property is set
        internal bool IsSetPeerBgpAsnExtended()
        {
            return this._peerBgpAsnExtended.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags assigned to the virtual interface.
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
        /// Gets and sets the property Vlan. 
        /// <para>
        /// The ID of the VLAN.
        /// </para>
        /// </summary>
        public int? Vlan
        {
            get { return this._vlan; }
            set { this._vlan = value; }
        }

        // Check to see if Vlan property is set
        internal bool IsSetVlan()
        {
            return this._vlan.HasValue; 
        }

    }
}