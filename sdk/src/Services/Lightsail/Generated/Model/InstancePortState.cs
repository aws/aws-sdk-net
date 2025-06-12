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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Lightsail.Model
{
    /// <summary>
    /// Describes open ports on an instance, the IP addresses allowed to connect to the instance
    /// through the ports, and the protocol.
    /// </summary>
    public partial class InstancePortState
    {
        private List<string> _cidrListAliases = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _cidrs = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _fromPort;
        private List<string> _ipv6Cidrs = AWSConfigs.InitializeCollections ? new List<string>() : null;
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
        /// The only alias currently supported is <c>lightsail-connect</c>, which allows IP addresses
        /// of the browser-based RDP/SSH client in the Lightsail console to connect to your instance.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> CidrListAliases
        {
            get { return this._cidrListAliases; }
            set { this._cidrListAliases = value; }
        }

        // Check to see if CidrListAliases property is set
        internal bool IsSetCidrListAliases()
        {
            return this._cidrListAliases != null && (this._cidrListAliases.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Cidrs. 
        /// <para>
        /// The IPv4 address, or range of IPv4 addresses (in CIDR notation) that are allowed to
        /// connect to an instance through the ports, and the protocol.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>ipv6Cidrs</c> parameter lists the IPv6 addresses that are allowed to connect
        /// to an instance.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about CIDR block notation, see <a href="https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing#CIDR_notation">Classless
        /// Inter-Domain Routing</a> on <i>Wikipedia</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Cidrs
        {
            get { return this._cidrs; }
            set { this._cidrs = value; }
        }

        // Check to see if Cidrs property is set
        internal bool IsSetCidrs()
        {
            return this._cidrs != null && (this._cidrs.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        /// TCP and UDP - <c>0</c> to <c>65535</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ICMP - The ICMP type for IPv4 addresses. For example, specify <c>8</c> as the <c>fromPort</c>
        /// (ICMP type), and <c>-1</c> as the <c>toPort</c> (ICMP code), to enable ICMP Ping.
        /// For more information, see <a href="https://en.wikipedia.org/wiki/Internet_Control_Message_Protocol#Control_messages">Control
        /// Messages</a> on <i>Wikipedia</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ICMPv6 - The ICMP type for IPv6 addresses. For example, specify <c>128</c> as the
        /// <c>fromPort</c> (ICMPv6 type), and <c>0</c> as <c>toPort</c> (ICMPv6 code). For more
        /// information, see <a href="https://en.wikipedia.org/wiki/Internet_Control_Message_Protocol_for_IPv6">Internet
        /// Control Message Protocol for IPv6</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=-1, Max=65535)]
        public int? FromPort
        {
            get { return this._fromPort; }
            set { this._fromPort = value; }
        }

        // Check to see if FromPort property is set
        internal bool IsSetFromPort()
        {
            return this._fromPort.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Ipv6Cidrs. 
        /// <para>
        /// The IPv6 address, or range of IPv6 addresses (in CIDR notation) that are allowed to
        /// connect to an instance through the ports, and the protocol. Only devices with an IPv6
        /// address can connect to an instance through IPv6; otherwise, IPv4 should be used.
        /// </para>
        ///  <note> 
        /// <para>
        /// The <c>cidrs</c> parameter lists the IPv4 addresses that are allowed to connect to
        /// an instance.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about CIDR block notation, see <a href="https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing#CIDR_notation">Classless
        /// Inter-Domain Routing</a> on <i>Wikipedia</i>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Ipv6Cidrs
        {
            get { return this._ipv6Cidrs; }
            set { this._ipv6Cidrs = value; }
        }

        // Check to see if Ipv6Cidrs property is set
        internal bool IsSetIpv6Cidrs()
        {
            return this._ipv6Cidrs != null && (this._ipv6Cidrs.Count > 0 || !AWSConfigs.InitializeCollections); 
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
        ///  <c>tcp</c> - Transmission Control Protocol (TCP) provides reliable, ordered, and
        /// error-checked delivery of streamed data between applications running on hosts communicating
        /// by an IP network. If you have an application that doesn't require reliable data stream
        /// service, use UDP instead.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>all</c> - All transport layer protocol types. For more general information, see
        /// <a href="https://en.wikipedia.org/wiki/Transport_layer">Transport layer</a> on <i>Wikipedia</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>udp</c> - With User Datagram Protocol (UDP), computer applications can send messages
        /// (or datagrams) to other hosts on an Internet Protocol (IP) network. Prior communications
        /// are not required to set up transmission channels or data paths. Applications that
        /// don't require reliable data stream service can use UDP, which provides a connectionless
        /// datagram service that emphasizes reduced latency over reliability. If you do require
        /// reliable data stream service, use TCP instead.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>icmp</c> - Internet Control Message Protocol (ICMP) is used to send error messages
        /// and operational information indicating success or failure when communicating with
        /// an instance. For example, an error is indicated when an instance could not be reached.
        /// When you specify <c>icmp</c> as the <c>protocol</c>, you must specify the ICMP type
        /// using the <c>fromPort</c> parameter, and ICMP code using the <c>toPort</c> parameter.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>icmp6</c> - Internet Control Message Protocol (ICMP) for IPv6. When you specify
        /// <c>icmp6</c> as the <c>protocol</c>, you must specify the ICMP type using the <c>fromPort</c>
        /// parameter, and ICMP code using the <c>toPort</c> parameter.
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
        /// Specifies whether the instance port is <c>open</c> or <c>closed</c>.
        /// </para>
        ///  <note> 
        /// <para>
        /// The port state for Lightsail instances is always <c>open</c>.
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
        /// TCP and UDP - <c>0</c> to <c>65535</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ICMP - The ICMP code for IPv4 addresses. For example, specify <c>8</c> as the <c>fromPort</c>
        /// (ICMP type), and <c>-1</c> as the <c>toPort</c> (ICMP code), to enable ICMP Ping.
        /// For more information, see <a href="https://en.wikipedia.org/wiki/Internet_Control_Message_Protocol#Control_messages">Control
        /// Messages</a> on <i>Wikipedia</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// ICMPv6 - The ICMP code for IPv6 addresses. For example, specify <c>128</c> as the
        /// <c>fromPort</c> (ICMPv6 type), and <c>0</c> as <c>toPort</c> (ICMPv6 code). For more
        /// information, see <a href="https://en.wikipedia.org/wiki/Internet_Control_Message_Protocol_for_IPv6">Internet
        /// Control Message Protocol for IPv6</a>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        [AWSProperty(Min=-1, Max=65535)]
        public int? ToPort
        {
            get { return this._toPort; }
            set { this._toPort = value; }
        }

        // Check to see if ToPort property is set
        internal bool IsSetToPort()
        {
            return this._toPort.HasValue; 
        }

    }
}