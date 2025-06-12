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
    /// Describes the service link virtual interfaces that establish connectivity between
    /// Amazon Web Services Outpost and on-premises networks.
    /// </summary>
    public partial class ServiceLinkVirtualInterface
    {
        private ServiceLinkVirtualInterfaceConfigurationState _configurationState;
        private string _localAddress;
        private string _outpostArn;
        private string _outpostId;
        private string _outpostLagId;
        private string _ownerId;
        private string _peerAddress;
        private long? _peerBgpAsn;
        private string _serviceLinkVirtualInterfaceArn;
        private string _serviceLinkVirtualInterfaceId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private int? _vlan;

        /// <summary>
        /// Gets and sets the property ConfigurationState. 
        /// <para>
        /// The current state of the service link virtual interface.
        /// </para>
        /// </summary>
        public ServiceLinkVirtualInterfaceConfigurationState ConfigurationState
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
        /// The IPv4 address assigned to the local gateway virtual interface on the Outpost side.
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
        /// Gets and sets the property OutpostArn. 
        /// <para>
        /// The Outpost Amazon Resource Number (ARN) for the service link virtual interface.
        /// </para>
        /// </summary>
        public string OutpostArn
        {
            get { return this._outpostArn; }
            set { this._outpostArn = value; }
        }

        // Check to see if OutpostArn property is set
        internal bool IsSetOutpostArn()
        {
            return this._outpostArn != null;
        }

        /// <summary>
        /// Gets and sets the property OutpostId. 
        /// <para>
        /// The Outpost ID for the service link virtual interface.
        /// </para>
        /// </summary>
        public string OutpostId
        {
            get { return this._outpostId; }
            set { this._outpostId = value; }
        }

        // Check to see if OutpostId property is set
        internal bool IsSetOutpostId()
        {
            return this._outpostId != null;
        }

        /// <summary>
        /// Gets and sets the property OutpostLagId. 
        /// <para>
        /// The link aggregation group (LAG) ID for the service link virtual interface.
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
        /// The ID of the Amazon Web Services account that owns the service link virtual interface..
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
        /// The IPv4 peer address for the service link virtual interface.
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
        /// The ASN for the Border Gateway Protocol (BGP) associated with the service link virtual
        /// interface.
        /// </para>
        /// </summary>
        public long? PeerBgpAsn
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
        /// Gets and sets the property ServiceLinkVirtualInterfaceArn. 
        /// <para>
        /// The Amazon Resource Number (ARN) for the service link virtual interface. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string ServiceLinkVirtualInterfaceArn
        {
            get { return this._serviceLinkVirtualInterfaceArn; }
            set { this._serviceLinkVirtualInterfaceArn = value; }
        }

        // Check to see if ServiceLinkVirtualInterfaceArn property is set
        internal bool IsSetServiceLinkVirtualInterfaceArn()
        {
            return this._serviceLinkVirtualInterfaceArn != null;
        }

        /// <summary>
        /// Gets and sets the property ServiceLinkVirtualInterfaceId. 
        /// <para>
        /// The ID of the service link virtual interface.
        /// </para>
        /// </summary>
        public string ServiceLinkVirtualInterfaceId
        {
            get { return this._serviceLinkVirtualInterfaceId; }
            set { this._serviceLinkVirtualInterfaceId = value; }
        }

        // Check to see if ServiceLinkVirtualInterfaceId property is set
        internal bool IsSetServiceLinkVirtualInterfaceId()
        {
            return this._serviceLinkVirtualInterfaceId != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the service link virtual interface.
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
        /// The virtual local area network for the service link virtual interface.
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