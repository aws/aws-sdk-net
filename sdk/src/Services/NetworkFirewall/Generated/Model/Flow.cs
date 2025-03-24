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
 * Do not modify this file. This file is generated from the network-firewall-2020-11-12.normal.json service model.
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
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Any number of arrays, where each array is a single flow identified in the scope of
    /// the operation. If multiple flows were in the scope of the operation, multiple <c>Flows</c>
    /// arrays are returned.
    /// </summary>
    public partial class Flow
    {
        private int? _age;
        private long? _byteCount;
        private Address _destinationAddress;
        private string _destinationPort;
        private int? _packetCount;
        private string _protocol;
        private Address _sourceAddress;
        private string _sourcePort;

        /// <summary>
        /// Gets and sets the property Age. 
        /// <para>
        /// Returned as info about age of the flows identified by the flow operation.
        /// </para>
        /// </summary>
        public int? Age
        {
            get { return this._age; }
            set { this._age = value; }
        }

        // Check to see if Age property is set
        internal bool IsSetAge()
        {
            return this._age.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ByteCount. 
        /// <para>
        /// Returns the number of bytes received or transmitted in a specific flow.
        /// </para>
        /// </summary>
        public long? ByteCount
        {
            get { return this._byteCount; }
            set { this._byteCount = value; }
        }

        // Check to see if ByteCount property is set
        internal bool IsSetByteCount()
        {
            return this._byteCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DestinationAddress.
        /// </summary>
        public Address DestinationAddress
        {
            get { return this._destinationAddress; }
            set { this._destinationAddress = value; }
        }

        // Check to see if DestinationAddress property is set
        internal bool IsSetDestinationAddress()
        {
            return this._destinationAddress != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationPort. 
        /// <para>
        /// The destination port to inspect for. You can specify an individual port, for example
        /// <c>1994</c> and you can specify a port range, for example <c>1990:1994</c>. To match
        /// with any port, specify <c>ANY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string DestinationPort
        {
            get { return this._destinationPort; }
            set { this._destinationPort = value; }
        }

        // Check to see if DestinationPort property is set
        internal bool IsSetDestinationPort()
        {
            return this._destinationPort != null;
        }

        /// <summary>
        /// Gets and sets the property PacketCount. 
        /// <para>
        /// Returns the total number of data packets received or transmitted in a flow.
        /// </para>
        /// </summary>
        public int? PacketCount
        {
            get { return this._packetCount; }
            set { this._packetCount = value; }
        }

        // Check to see if PacketCount property is set
        internal bool IsSetPacketCount()
        {
            return this._packetCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocols to inspect for, specified using the assigned internet protocol number
        /// (IANA) for each protocol. If not specified, this matches with any protocol.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=12)]
        public string Protocol
        {
            get { return this._protocol; }
            set { this._protocol = value; }
        }

        // Check to see if Protocol property is set
        internal bool IsSetProtocol()
        {
            return this._protocol != null;
        }

        /// <summary>
        /// Gets and sets the property SourceAddress.
        /// </summary>
        public Address SourceAddress
        {
            get { return this._sourceAddress; }
            set { this._sourceAddress = value; }
        }

        // Check to see if SourceAddress property is set
        internal bool IsSetSourceAddress()
        {
            return this._sourceAddress != null;
        }

        /// <summary>
        /// Gets and sets the property SourcePort. 
        /// <para>
        /// The source port to inspect for. You can specify an individual port, for example <c>1994</c>
        /// and you can specify a port range, for example <c>1990:1994</c>. To match with any
        /// port, specify <c>ANY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string SourcePort
        {
            get { return this._sourcePort; }
            set { this._sourcePort = value; }
        }

        // Check to see if SourcePort property is set
        internal bool IsSetSourcePort()
        {
            return this._sourcePort != null;
        }

    }
}