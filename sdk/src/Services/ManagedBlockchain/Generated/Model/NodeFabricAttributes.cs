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
 * Do not modify this file. This file is generated from the managedblockchain-2018-09-24.normal.json service model.
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
namespace Amazon.ManagedBlockchain.Model
{
    /// <summary>
    /// Attributes of Hyperledger Fabric for a peer node on a Hyperledger Fabric network on
    /// Managed Blockchain.
    /// </summary>
    public partial class NodeFabricAttributes
    {
        private string _peerEndpoint;
        private string _peerEventEndpoint;

        /// <summary>
        /// Gets and sets the property PeerEndpoint. 
        /// <para>
        /// The endpoint that identifies the peer node for all services except peer channel-based
        /// event services.
        /// </para>
        /// </summary>
        public string PeerEndpoint
        {
            get { return this._peerEndpoint; }
            set { this._peerEndpoint = value; }
        }

        // Check to see if PeerEndpoint property is set
        internal bool IsSetPeerEndpoint()
        {
            return this._peerEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property PeerEventEndpoint. 
        /// <para>
        /// The endpoint that identifies the peer node for peer channel-based event services.
        /// </para>
        /// </summary>
        public string PeerEventEndpoint
        {
            get { return this._peerEventEndpoint; }
            set { this._peerEventEndpoint = value; }
        }

        // Check to see if PeerEventEndpoint property is set
        internal bool IsSetPeerEventEndpoint()
        {
            return this._peerEventEndpoint != null;
        }

    }
}