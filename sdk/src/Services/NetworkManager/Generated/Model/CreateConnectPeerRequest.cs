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

namespace Amazon.NetworkManager.Model
{
    /// <summary>
    /// Container for the parameters to the CreateConnectPeer operation.
    /// Creates a core network connect peer for a specified core network connect attachment
    /// between a core network and an appliance. The peer address and transit gateway address
    /// must be the same IP address family (IPv4 or IPv6).
    /// </summary>
    public partial class CreateConnectPeerRequest : AmazonNetworkManagerRequest
    {
        private BgpOptions _bgpOptions;
        private string _clientToken;
        private string _connectAttachmentId;
        private string _coreNetworkAddress;
        private List<string> _insideCidrBlocks = new List<string>();
        private string _peerAddress;
        private List<Tag> _tags = new List<Tag>();

        /// <summary>
        /// Gets and sets the property BgpOptions. 
        /// <para>
        /// The Connect peer BGP options.
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
        /// A Connect peer core network address.
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
        /// </summary>
        [AWSProperty(Required=true)]
        public List<string> InsideCidrBlocks
        {
            get { return this._insideCidrBlocks; }
            set { this._insideCidrBlocks = value; }
        }

        // Check to see if InsideCidrBlocks property is set
        internal bool IsSetInsideCidrBlocks()
        {
            return this._insideCidrBlocks != null && this._insideCidrBlocks.Count > 0; 
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
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the peer request.
        /// </para>
        /// </summary>
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}