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
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes open ports on an instance, the IP addresses allowed to connect to the instance
    /// through the ports, and the protocol.
    /// </summary>
    public partial class InstancePortState
    {
        private List<string> _cidrListAliases = new List<string>();
        private List<string> _cidrs = new List<string>();
        private int? _fromPort;
        private NetworkProtocol _protocol;
        private PortState _state;
        private int? _toPort;

        /// <summary>
        /// Gets and sets the property CidrListAliases. 
        /// <para>
        /// An alias that defines access for a preconfigured range of IP addresses.
        /// </para>
        ///  
        /// <para>
        /// The only alias currently supported is <code>lightsail-connect</code>, which allows
        /// IP addresses of the browser-based RDP/SSH client in the Lightsail console to connect
        /// to your instance.
        /// </para>
        /// </summary>
        public List<string> CidrListAliases
        {
            get { return this._cidrListAliases; }
            set { this._cidrListAliases = value; }
        }

        // Check to see if CidrListAliases property is set
        internal bool IsSetCidrListAliases()
        {
            return this._cidrListAliases != null && this._cidrListAliases.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Cidrs. 
        /// <para>
        /// The IP address, or range of IP addresses in CIDR notation, that are allowed to connect
        /// to an instance through the ports, and the protocol. Lightsail supports IPv4 addresses.
        /// </para>
        ///  
        /// <para>
        /// For more information about CIDR block notation, see <a href="https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing#CIDR_notation">Classless
        /// Inter-Domain Routing</a> on <i>Wikipedia</i>.
        /// </para>
        /// </summary>
        public List<string> Cidrs
        {
            get { return this._cidrs; }
            set { this._cidrs = value; }
        }

        // Check to see if Cidrs property is set
        internal bool IsSetCidrs()
        {
            return this._cidrs != null && this._cidrs.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FromPort. 
        /// <para>
        /// The first port in a range of open ports on an instance.
        /// </para>
        ///  
        /// <para>
        /// Allowed ports:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// TCP and UDP - <code>0</code> to <code>65535</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ICMP - <code>8</code> (to configure Ping)
        /// </para>
        ///  <note> 
        /// <para>
        /// Ping is the only communication supported through the ICMP protocol in Lightsail. To
        /// configure ping, specify the <code>fromPort</code> parameter as <code>8</code>, and
        /// the <code>toPort</code> parameter as <code>-1</code>.
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
        [AWSProperty(Min=-1, Max=65535)]
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
        /// The IP protocol name.
        /// </para>
        ///  
        /// <para>
        /// The name can be one of the following:
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
        /// <i>Wikipedia</i>.
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
        ///  </li> <li> 
        /// <para>
        ///  <code>icmp</code> - Internet Control Message Protocol (ICMP) is used to send error
        /// messages and operational information indicating success or failure when communicating
        /// with an instance. For example, an error is indicated when an instance could not be
        /// reached.
        /// </para>
        ///  <note> 
        /// <para>
        /// Ping is the only communication supported through the ICMP protocol in Lightsail. To
        /// configure ping, specify the <code>fromPort</code> parameter as <code>8</code>, and
        /// the <code>toPort</code> parameter as <code>-1</code>.
        /// </para>
        ///  </note> </li> </ul>
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
        ///  <note> 
        /// <para>
        /// The port state for Lightsail instances is always <code>open</code>.
        /// </para>
        ///  </note>
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
        /// The last port in a range of open ports on an instance.
        /// </para>
        ///  
        /// <para>
        /// Allowed ports:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// TCP and UDP - <code>0</code> to <code>65535</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ICMP - <code>-1</code> (to configure Ping)
        /// </para>
        ///  <note> 
        /// <para>
        /// Ping is the only communication supported through the ICMP protocol in Lightsail. To
        /// configure ping, specify the <code>fromPort</code> parameter as <code>8</code>, and
        /// the <code>toPort</code> parameter as <code>-1</code>.
        /// </para>
        ///  </note> </li> </ul>
        /// </summary>
        [AWSProperty(Min=-1, Max=65535)]
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