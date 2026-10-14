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

namespace Amazon.CloudWatchOmni.Model
{
    /// <summary>
    /// Additive traffic counters accumulated over an edge's observation window. Which counters
    /// are populated depends on what produced the edge.
    /// </summary>
    public partial class EdgeTrafficStats
    {
        /// <summary>
        /// Gets and sets the property Bytes. Total bytes observed across the edge.
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? Bytes { get; set; }

        /// <summary>
        /// Checks to see if the Bytes property is set.
        /// </summary>
        internal bool IsSetBytes() => this.Bytes.HasValue;

        /// <summary>
        /// Gets and sets the property Flows. Total network flows observed across the edge.
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? Flows { get; set; }

        /// <summary>
        /// Checks to see if the Flows property is set.
        /// </summary>
        internal bool IsSetFlows() => this.Flows.HasValue;

        /// <summary>
        /// Gets and sets the property Packets. Total packets observed across the edge.
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? Packets { get; set; }

        /// <summary>
        /// Checks to see if the Packets property is set.
        /// </summary>
        internal bool IsSetPackets() => this.Packets.HasValue;

        /// <summary>
        /// Gets and sets the property ReceivedBytes. Total bytes received from the destination.
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ReceivedBytes { get; set; }

        /// <summary>
        /// Checks to see if the ReceivedBytes property is set.
        /// </summary>
        internal bool IsSetReceivedBytes() => this.ReceivedBytes.HasValue;

        /// <summary>
        /// Gets and sets the property SentBytes. Total bytes sent to the destination.
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? SentBytes { get; set; }

        /// <summary>
        /// Checks to see if the SentBytes property is set.
        /// </summary>
        internal bool IsSetSentBytes() => this.SentBytes.HasValue;
    }
}
