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
    /// Describes a core network Connect peer configuration.
    /// </summary>
    public partial class ConnectPeerConfiguration
    {
        private List<ConnectPeerBgpConfiguration> _bgpConfigurations = new List<ConnectPeerBgpConfiguration>();
        private string _coreNetworkAddress;
        private List<string> _insideCidrBlocks = new List<string>();
        private string _peerAddress;
        private TunnelProtocol _protocol;

        /// <summary>
        /// Gets and sets the property BgpConfigurations. 
        /// <para>
        /// The Connect peer BGP configurations.
        /// </para>
        /// </summary>
        public List<ConnectPeerBgpConfiguration> BgpConfigurations
        {
            get { return this._bgpConfigurations; }
            set { this._bgpConfigurations = value; }
        }

        // Check to see if BgpConfigurations property is set
        internal bool IsSetBgpConfigurations()
        {
            return this._bgpConfigurations != null && this._bgpConfigurations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CoreNetworkAddress. 
        /// <para>
        /// The IP address of a core network.
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
        /// The inside IP addresses used for a Connect peer configuration.
        /// </para>
        /// </summary>
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
        /// The IP address of the Connect peer.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
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
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol used for a Connect peer configuration.
        /// </para>
        /// </summary>
        public TunnelProtocol Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

    }
}