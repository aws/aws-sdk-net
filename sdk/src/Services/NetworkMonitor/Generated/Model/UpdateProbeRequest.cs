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
    /// Container for the parameters to the UpdateProbe operation.
    /// Updates a monitor probe. This action requires both the <c>monitorName</c> and <c>probeId</c>
    /// parameters. Run <c>ListMonitors</c> to get a list of monitor names. Run <c>GetMonitor</c>
    /// to get a list of probes and probe IDs. 
    /// 
    ///  
    /// <para>
    /// You can update the following para create a monitor with probes using this command.
    /// For each probe, you define the following:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <c>state</c>—The state of the probe.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>destination</c>— The target destination IP address for the probe.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>destinationPort</c>—Required only if the protocol is <c>TCP</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>protocol</c>—The communication protocol between the source and destination. This
    /// will be either <c>TCP</c> or <c>ICMP</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <c>packetSize</c>—The size of the packets. This must be a number between <c>56</c>
    /// and <c>8500</c>.
    /// </para>
    ///  </li> <li> 
    /// <para>
    /// (Optional) <c>tags</c> —Key-value pairs created and assigned to the probe.
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class UpdateProbeRequest : AmazonNetworkMonitorRequest
    {
        private string _destination;
        private int? _destinationPort;
        private string _monitorName;
        private int? _packetSize;
        private string _probeId;
        private Protocol _protocol;
        private ProbeState _state;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The updated IP address for the probe destination. This must be either an IPv4 or IPv6
        /// address.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=255)]
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
        /// The updated port for the probe destination. This is required only if the <c>protocol</c>
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
        /// Gets and sets the property MonitorName. 
        /// <para>
        /// The name of the monitor that the probe was updated for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
        public string MonitorName
        {
            get { return this._monitorName; }
            set { this._monitorName = value; }
        }

        // Check to see if MonitorName property is set
        internal bool IsSetMonitorName()
        {
            return this._monitorName != null;
        }

        /// <summary>
        /// Gets and sets the property PacketSize. 
        /// <para>
        /// he updated packets size for network traffic between the source and destination. This
        /// must be a number between <c>56</c> and <c>8500</c>.
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
        /// Gets and sets the property ProbeId. 
        /// <para>
        /// The ID of the probe to update.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ProbeId
        {
            get { return this._probeId; }
            set { this._probeId = value; }
        }

        // Check to see if ProbeId property is set
        internal bool IsSetProbeId()
        {
            return this._probeId != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The updated network protocol for the destination. This can be either <c>TCP</c> or
        /// <c>ICMP</c>. If the protocol is <c>TCP</c>, then <c>port</c> is also required.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the probe update.
        /// </para>
        /// </summary>
        public ProbeState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

    }
}