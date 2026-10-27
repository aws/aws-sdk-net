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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Any number of arrays, where each array is a single flow identified in the scope of
    /// the operation. If multiple flows were in the scope of the operation, multiple <c>Flows</c>
    /// arrays are returned.
    /// </summary>
    public partial class Flow
    {
        /// <summary>
        /// Gets and sets the property Age. 
        /// <para>
        /// Returned as info about age of the flows identified by the flow operation.
        /// </para>
        /// </summary>
        public int? Age { get; set; }

        /// <summary>
        /// Checks to see if the Age property is set.
        /// </summary>
        internal bool IsSetAge() => this.Age.HasValue;

        /// <summary>
        /// Gets and sets the property ByteCount. 
        /// <para>
        /// Returns the number of bytes received or transmitted in a specific flow.
        /// </para>
        /// </summary>
        public long? ByteCount { get; set; }

        /// <summary>
        /// Checks to see if the ByteCount property is set.
        /// </summary>
        internal bool IsSetByteCount() => this.ByteCount.HasValue;

        /// <summary>
        /// Gets and sets the property DestinationAddress.
        /// </summary>
        public Address DestinationAddress { get; set; }

        /// <summary>
        /// Checks to see if the DestinationAddress property is set.
        /// </summary>
        internal bool IsSetDestinationAddress() => this.DestinationAddress != null;

        /// <summary>
        /// Gets and sets the property DestinationPort. 
        /// <para>
        /// The destination port to inspect for. You can specify an individual port, for example
        /// <c>1994</c> and you can specify a port range, for example <c>1990:1994</c>. To match
        /// with any port, specify <c>ANY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string DestinationPort { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPort property is set.
        /// </summary>
        internal bool IsSetDestinationPort() => this.DestinationPort != null;

        /// <summary>
        /// Gets and sets the property PacketCount. 
        /// <para>
        /// Returns the total number of data packets received or transmitted in a flow.
        /// </para>
        /// </summary>
        public int? PacketCount { get; set; }

        /// <summary>
        /// Checks to see if the PacketCount property is set.
        /// </summary>
        internal bool IsSetPacketCount() => this.PacketCount.HasValue;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocols to inspect for, specified using the assigned internet protocol number
        /// (IANA) for each protocol. If not specified, this matches with any protocol.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 12)]
        public string Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property SourceAddress.
        /// </summary>
        public Address SourceAddress { get; set; }

        /// <summary>
        /// Checks to see if the SourceAddress property is set.
        /// </summary>
        internal bool IsSetSourceAddress() => this.SourceAddress != null;

        /// <summary>
        /// Gets and sets the property SourcePort. 
        /// <para>
        /// The source port to inspect for. You can specify an individual port, for example <c>1994</c>
        /// and you can specify a port range, for example <c>1990:1994</c>. To match with any
        /// port, specify <c>ANY</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string SourcePort { get; set; }

        /// <summary>
        /// Checks to see if the SourcePort property is set.
        /// </summary>
        internal bool IsSetSourcePort() => this.SourcePort != null;
    }
}
