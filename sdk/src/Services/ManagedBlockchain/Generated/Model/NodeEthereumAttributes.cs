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
    /// Attributes of an Ethereum node.
    /// </summary>
    public partial class NodeEthereumAttributes
    {
        private string _httpEndpoint;
        private string _webSocketEndpoint;

        /// <summary>
        /// Gets and sets the property HttpEndpoint. 
        /// <para>
        /// The endpoint on which the Ethereum node listens to run Ethereum API methods over HTTP
        /// connections from a client. Use this endpoint in client code for smart contracts when
        /// using an HTTP connection. Connections to this endpoint are authenticated using <a
        /// href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>.
        /// </para>
        /// </summary>
        public string HttpEndpoint
        {
            get { return this._httpEndpoint; }
            set { this._httpEndpoint = value; }
        }

        // Check to see if HttpEndpoint property is set
        internal bool IsSetHttpEndpoint()
        {
            return this._httpEndpoint != null;
        }

        /// <summary>
        /// Gets and sets the property WebSocketEndpoint. 
        /// <para>
        /// The endpoint on which the Ethereum node listens to run Ethereum JSON-RPC methods over
        /// WebSocket connections from a client. Use this endpoint in client code for smart contracts
        /// when using a WebSocket connection. Connections to this endpoint are authenticated
        /// using <a href="https://docs.aws.amazon.com/general/latest/gr/signature-version-4.html">Signature
        /// Version 4</a>.
        /// </para>
        /// </summary>
        public string WebSocketEndpoint
        {
            get { return this._webSocketEndpoint; }
            set { this._webSocketEndpoint = value; }
        }

        // Check to see if WebSocketEndpoint property is set
        internal bool IsSetWebSocketEndpoint()
        {
            return this._webSocketEndpoint != null;
        }

    }
}