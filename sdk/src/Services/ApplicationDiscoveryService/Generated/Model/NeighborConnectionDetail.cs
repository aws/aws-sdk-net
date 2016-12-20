/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the discovery-2015-11-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Details about neighboring servers.
    /// </summary>
    public partial class NeighborConnectionDetail
    {
        private long? _connectionsCount;
        private int? _destinationPort;
        private string _destinationServerId;
        private string _sourceServerId;
        private string _transportProtocol;

        /// <summary>
        /// Gets and sets the property ConnectionsCount. 
        /// <para>
        /// Number of open network connections with the neighboring server.
        /// </para>
        /// </summary>
        public long ConnectionsCount
        {
            get { return this._connectionsCount.GetValueOrDefault(); }
            set { this._connectionsCount = value; }
        }

        // Check to see if ConnectionsCount property is set
        internal bool IsSetConnectionsCount()
        {
            return this._connectionsCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DestinationPort. 
        /// <para>
        /// Destination network port for the connection.
        /// </para>
        /// </summary>
        public int DestinationPort
        {
            get { return this._destinationPort.GetValueOrDefault(); }
            set { this._destinationPort = value; }
        }

        // Check to see if DestinationPort property is set
        internal bool IsSetDestinationPort()
        {
            return this._destinationPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DestinationServerId. 
        /// <para>
        /// ID of the server that accepted the networker connection.
        /// </para>
        /// </summary>
        public string DestinationServerId
        {
            get { return this._destinationServerId; }
            set { this._destinationServerId = value; }
        }

        // Check to see if DestinationServerId property is set
        internal bool IsSetDestinationServerId()
        {
            return this._destinationServerId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceServerId. 
        /// <para>
        /// ID of server that opened the network connection.
        /// </para>
        /// </summary>
        public string SourceServerId
        {
            get { return this._sourceServerId; }
            set { this._sourceServerId = value; }
        }

        // Check to see if SourceServerId property is set
        internal bool IsSetSourceServerId()
        {
            return this._sourceServerId != null;
        }

        /// <summary>
        /// Gets and sets the property TransportProtocol. 
        /// <para>
        /// Network protocol used for the connection.
        /// </para>
        /// </summary>
        public string TransportProtocol
        {
            get { return this._transportProtocol; }
            set { this._transportProtocol = value; }
        }

        // Check to see if TransportProtocol property is set
        internal bool IsSetTransportProtocol()
        {
            return this._transportProtocol != null;
        }

    }
}