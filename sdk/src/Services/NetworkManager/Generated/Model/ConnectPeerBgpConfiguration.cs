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
    /// Describes a core network BGP configuration.
    /// </summary>
    public partial class ConnectPeerBgpConfiguration
    {
        private string _coreNetworkAddress;
        private long? _coreNetworkAsn;
        private string _peerAddress;
        private long? _peerAsn;

        /// <summary>
        /// Gets and sets the property CoreNetworkAddress. 
        /// <para>
        /// The address of a core network.
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
        /// Gets and sets the property CoreNetworkAsn. 
        /// <para>
        /// The ASN of the Coret Network.
        /// </para>
        /// </summary>
        public long? CoreNetworkAsn
        {
            get { return this._coreNetworkAsn; }
            set { this._coreNetworkAsn = value; }
        }

        // Check to see if CoreNetworkAsn property is set
        internal bool IsSetCoreNetworkAsn()
        {
            return this._coreNetworkAsn.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PeerAddress. 
        /// <para>
        /// The address of a core network Connect peer.
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
        /// Gets and sets the property PeerAsn. 
        /// <para>
        /// The ASN of the Connect peer.
        /// </para>
        /// </summary>
        public long? PeerAsn
        {
            get { return this._peerAsn; }
            set { this._peerAsn = value; }
        }

        // Check to see if PeerAsn property is set
        internal bool IsSetPeerAsn()
        {
            return this._peerAsn.HasValue; 
        }

    }
}