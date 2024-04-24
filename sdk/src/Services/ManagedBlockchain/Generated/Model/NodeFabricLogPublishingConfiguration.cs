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
    /// Configuration properties for logging events associated with a peer node owned by a
    /// member in a Managed Blockchain network.
    /// </summary>
    public partial class NodeFabricLogPublishingConfiguration
    {
        private LogConfigurations _chaincodeLogs;
        private LogConfigurations _peerLogs;

        /// <summary>
        /// Gets and sets the property ChaincodeLogs. 
        /// <para>
        /// Configuration properties for logging events associated with chaincode execution on
        /// a peer node. Chaincode logs contain the results of instantiating, invoking, and querying
        /// the chaincode. A peer can run multiple instances of chaincode. When enabled, a log
        /// stream is created for all chaincodes, with an individual log stream for each chaincode.
        /// </para>
        /// </summary>
        public LogConfigurations ChaincodeLogs
        {
            get { return this._chaincodeLogs; }
            set { this._chaincodeLogs = value; }
        }

        // Check to see if ChaincodeLogs property is set
        internal bool IsSetChaincodeLogs()
        {
            return this._chaincodeLogs != null;
        }

        /// <summary>
        /// Gets and sets the property PeerLogs. 
        /// <para>
        /// Configuration properties for a peer node log. Peer node logs contain messages generated
        /// when your client submits transaction proposals to peer nodes, requests to join channels,
        /// enrolls an admin peer, and lists the chaincode instances on a peer node. 
        /// </para>
        /// </summary>
        public LogConfigurations PeerLogs
        {
            get { return this._peerLogs; }
            set { this._peerLogs = value; }
        }

        // Check to see if PeerLogs property is set
        internal bool IsSetPeerLogs()
        {
            return this._peerLogs != null;
        }

    }
}