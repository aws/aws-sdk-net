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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.ApplicationDiscoveryService.Model
{
    /// <summary>
    /// Details about neighboring servers.
    /// </summary>
    public partial class NeighborConnectionDetail
    {
        /// <summary>
        /// Gets and sets the property ConnectionsCount. 
        /// <para>
        /// The number of open network connections with the neighboring server.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public long? ConnectionsCount { get; set; }

        /// <summary>
        /// Checks to see if the ConnectionsCount property is set.
        /// </summary>
        internal bool IsSetConnectionsCount() => this.ConnectionsCount.HasValue;

        /// <summary>
        /// Gets and sets the property DestinationPort. 
        /// <para>
        /// The destination network port for the connection.
        /// </para>
        /// </summary>
        public int? DestinationPort { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPort property is set.
        /// </summary>
        internal bool IsSetDestinationPort() => this.DestinationPort.HasValue;

        /// <summary>
        /// Gets and sets the property DestinationServerId. 
        /// <para>
        /// The ID of the server that accepted the network connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 200)]
        public string DestinationServerId { get; set; }

        /// <summary>
        /// Checks to see if the DestinationServerId property is set.
        /// </summary>
        internal bool IsSetDestinationServerId() => this.DestinationServerId != null;

        /// <summary>
        /// Gets and sets the property SourceServerId. 
        /// <para>
        /// The ID of the server that opened the network connection.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0, Max = 200)]
        public string SourceServerId { get; set; }

        /// <summary>
        /// Checks to see if the SourceServerId property is set.
        /// </summary>
        internal bool IsSetSourceServerId() => this.SourceServerId != null;

        /// <summary>
        /// Gets and sets the property TransportProtocol. 
        /// <para>
        /// The network protocol used for the connection.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 10000)]
        public string TransportProtocol { get; set; }

        /// <summary>
        /// Checks to see if the TransportProtocol property is set.
        /// </summary>
        internal bool IsSetTransportProtocol() => this.TransportProtocol != null;
    }
}
