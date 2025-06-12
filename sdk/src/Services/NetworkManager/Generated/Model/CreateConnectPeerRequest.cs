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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
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
    /// Container for the parameters to the CreateConnectPeer operation.
    /// Creates a core network Connect peer for a specified core network connect attachment
    /// between a core network and an appliance. The peer address and transit gateway address
    /// must be the same IP address family (IPv4 or IPv6).
    /// </summary>
    public partial class CreateConnectPeerRequest : AmazonNetworkManagerRequest
    {
        private BgpOptions _bgpOptions;
        private string _clientToken;
        private string _connectAttachmentId;
        private string _coreNetworkAddress;
        private List<string> _insideCidrBlocks = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _peerAddress;
        private string _subnetArn;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property BgpOptions. 
        /// <para>
        /// The Connect peer BGP options. This only applies only when the protocol is <c>GRE</c>.
        /// </para>
        /// </summary>
        public BgpOptions BgpOptions
        {
            get { return this._bgpOptions; }
            set { this._bgpOptions = value; }
        }

        // Check to see if BgpOptions property is set
        internal bool IsSetBgpOptions()
        {
            return this._bgpOptions != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token associated with the request.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property ConnectAttachmentId. 
        /// <para>
        /// The ID of the connection attachment.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=50)]
        public string ConnectAttachmentId
        {
            get { return this._connectAttachmentId; }
            set { this._connectAttachmentId = value; }
        }

        // Check to see if ConnectAttachmentId property is set
        internal bool IsSetConnectAttachmentId()
        {
            return this._connectAttachmentId != null;
        }

        /// <summary>
        /// Gets and sets the property CoreNetworkAddress. 
        /// <para>
        /// A Connect peer core network address. This only applies only when the protocol is <c>GRE</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public string CoreNetworkAddress
        {
            get { return this._coreNetworkAddress; }
            set { this._coreNetworkAddress = value; }
        }

        // Check to see if CoreNetworkAddress property is set
        internal bool IsSetCoreNetworkAddress()
        {
            return this._coreNetworkAddress != null;
        }

        /// <summary>
        /// Gets and sets the property InsideCidrBlocks. 
        /// <para>
        /// The inside IP addresses used for BGP peering.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> InsideCidrBlocks
        {
            get { return this._insideCidrBlocks; }
            set { this._insideCidrBlocks = value; }
        }

        // Check to see if InsideCidrBlocks property is set
        internal bool IsSetInsideCidrBlocks()
        {
            return this._insideCidrBlocks != null && (this._insideCidrBlocks.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property PeerAddress. 
        /// <para>
        /// The Connect peer address.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
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
        /// Gets and sets the property SubnetArn. 
        /// <para>
        /// The subnet ARN for the Connect peer. This only applies only when the protocol is NO_ENCAP.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=500)]
        public string SubnetArn
        {
            get { return this._subnetArn; }
            set { this._subnetArn = value; }
        }

        // Check to see if SubnetArn property is set
        internal bool IsSetSubnetArn()
        {
            return this._subnetArn != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the peer request.
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

    }
}