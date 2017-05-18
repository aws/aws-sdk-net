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
 * Do not modify this file. This file is generated from the lightsail-2016-11-28.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes the port state.
    /// </summary>
    public partial class InstancePortState
    {
        private int? _fromPort;
        private NetworkProtocol _protocol;
        private PortState _state;
        private int? _toPort;

        /// <summary>
        /// Gets and sets the property FromPort. 
        /// <para>
        /// The first port in the range.
        /// </para>
        /// </summary>
        public int FromPort
        {
            get { return this._fromPort.GetValueOrDefault(); }
            set { this._fromPort = value; }
        }

        // Check to see if FromPort property is set
        internal bool IsSetFromPort()
        {
            return this._fromPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol being used. Can be one of the following.
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>tcp</code> - Transmission Control Protocol (TCP) provides reliable, ordered,
        /// and error-checked delivery of streamed data between applications running on hosts
        /// communicating by an IP network. If you have an application that doesn't require reliable
        /// data stream service, use UDP instead.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>all</code> - All transport layer protocol types. For more general information,
        /// see <a href="https://en.wikipedia.org/wiki/Transport_layer">Transport layer</a> on
        /// Wikipedia.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>udp</code> - With User Datagram Protocol (UDP), computer applications can send
        /// messages (or datagrams) to other hosts on an Internet Protocol (IP) network. Prior
        /// communications are not required to set up transmission channels or data paths. Applications
        /// that don't require reliable data stream service can use UDP, which provides a connectionless
        /// datagram service that emphasizes reduced latency over reliability. If you do require
        /// reliable data stream service, use TCP instead.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public NetworkProtocol Protocol
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
        /// Specifies whether the instance port is <code>open</code> or <code>closed</code>.
        /// </para>
        /// </summary>
        public PortState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property ToPort. 
        /// <para>
        /// The last port in the range.
        /// </para>
        /// </summary>
        public int ToPort
        {
            get { return this._toPort.GetValueOrDefault(); }
            set { this._toPort = value; }
        }

        // Check to see if ToPort property is set
        internal bool IsSetToPort()
        {
            return this._toPort.HasValue; 
        }

    }
}