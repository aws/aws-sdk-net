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
 * Do not modify this file. This file is generated from the cloudwatchomni-2025-01-01.normal.json service model.
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
namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Additive traffic counters accumulated over an edge's observation window. Which counters
    /// are populated depends on what produced the edge.
    /// </summary>
    public partial class EdgeTrafficStats
    {
        private long? _bytes;
        private long? _flows;
        private long? _packets;
        private long? _receivedBytes;
        private long? _sentBytes;

        /// <summary>
        /// Gets and sets the property Bytes. 
        /// <para>
        /// Total bytes observed across the edge.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? Bytes
        {
            get { return this._bytes; }
            set { this._bytes = value; }
        }

        // Check to see if Bytes property is set
        internal bool IsSetBytes()
        {
            return this._bytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Flows. 
        /// <para>
        /// Total network flows observed across the edge.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? Flows
        {
            get { return this._flows; }
            set { this._flows = value; }
        }

        // Check to see if Flows property is set
        internal bool IsSetFlows()
        {
            return this._flows.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Packets. 
        /// <para>
        /// Total packets observed across the edge.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? Packets
        {
            get { return this._packets; }
            set { this._packets = value; }
        }

        // Check to see if Packets property is set
        internal bool IsSetPackets()
        {
            return this._packets.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ReceivedBytes. 
        /// <para>
        /// Total bytes received from the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? ReceivedBytes
        {
            get { return this._receivedBytes; }
            set { this._receivedBytes = value; }
        }

        // Check to see if ReceivedBytes property is set
        internal bool IsSetReceivedBytes()
        {
            return this._receivedBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property SentBytes. 
        /// <para>
        /// Total bytes sent to the destination.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? SentBytes
        {
            get { return this._sentBytes; }
            set { this._sentBytes = value; }
        }

        // Check to see if SentBytes property is set
        internal bool IsSetSentBytes()
        {
            return this._sentBytes.HasValue; 
        }

    }
}