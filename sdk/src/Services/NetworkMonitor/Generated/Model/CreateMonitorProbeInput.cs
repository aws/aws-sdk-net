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
 * Do not modify this file. This file is generated from the networkmonitor-2023-08-01.normal.json service model.
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
namespace Amazon.NetworkMonitor.Model
{
    /// <summary>
    /// Creates a monitor probe.
    /// </summary>
    public partial class CreateMonitorProbeInput
    {
        private string _destination;
        private int? _destinationPort;
        private int? _packetSize;
        private Dictionary<string, string> _probeTags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private Protocol _protocol;
        private string _sourceArn;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination IP address. This must be either <c>IPV4</c> or <c>IPV6</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=255)]
        public string Destination
        {
            get { return this._destination; }
            set { this._destination = value; }
        }

        // Check to see if Destination property is set
        internal bool IsSetDestination()
        {
            return this._destination != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationPort. 
        /// <para>
        /// The port associated with the <c>destination</c>. This is required only if the <c>protocol</c>
        /// is <c>TCP</c> and must be a number between <c>1</c> and <c>65536</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=65536)]
        public int? DestinationPort
        {
            get { return this._destinationPort; }
            set { this._destinationPort = value; }
        }

        // Check to see if DestinationPort property is set
        internal bool IsSetDestinationPort()
        {
            return this._destinationPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PacketSize. 
        /// <para>
        /// The size of the packets sent between the source and destination. This must be a number
        /// between <c>56</c> and <c>8500</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=56, Max=8500)]
        public int? PacketSize
        {
            get { return this._packetSize; }
            set { this._packetSize = value; }
        }

        // Check to see if PacketSize property is set
        internal bool IsSetPacketSize()
        {
            return this._packetSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ProbeTags. 
        /// <para>
        /// The list of key-value pairs created and assigned to the monitor.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public Dictionary<string, string> ProbeTags
        {
            get { return this._probeTags; }
            set { this._probeTags = value; }
        }

        // Check to see if ProbeTags property is set
        internal bool IsSetProbeTags()
        {
            return this._probeTags != null && (this._probeTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol used for the network traffic between the <c>source</c> and <c>destination</c>.
        /// This must be either <c>TCP</c> or <c>ICMP</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Protocol Protocol
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
        /// Gets and sets the property SourceArn. 
        /// <para>
        /// The ARN of the subnet.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string SourceArn
        {
            get { return this._sourceArn; }
            set { this._sourceArn = value; }
        }

        // Check to see if SourceArn property is set
        internal bool IsSetSourceArn()
        {
            return this._sourceArn != null;
        }

    }
}