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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// The basic rule criteria for Network Firewall to use to inspect packet headers in stateful
    /// traffic flow inspection. Traffic flows that match the criteria are a match for the
    /// corresponding <a>StatefulRule</a>.
    /// </summary>
    public partial class Header
    {
        private string _destination;
        private string _destinationPort;
        private StatefulRuleDirection _direction;
        private StatefulRuleProtocol _protocol;
        private string _source;
        private string _sourcePort;

        /// <summary>
        /// Gets and sets the property Destination. 
        /// <para>
        /// The destination IP address or address range to inspect for, in CIDR notation. To match
        /// with any address, specify <code>ANY</code>. 
        /// </para>
        ///  
        /// <para>
        /// Specify an IP address or a block of IP addresses in Classless Inter-Domain Routing
        /// (CIDR) notation. Network Firewall supports all address ranges for IPv4 and IPv6. 
        /// </para>
        ///  
        /// <para>
        /// Examples: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To configure Network Firewall to inspect for the IP address 192.0.2.44, specify <code>192.0.2.44/32</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To configure Network Firewall to inspect for IP addresses from 192.0.2.0 to 192.0.2.255,
        /// specify <code>192.0.2.0/24</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To configure Network Firewall to inspect for the IP address 1111:0000:0000:0000:0000:0000:0000:0111,
        /// specify <code>1111:0000:0000:0000:0000:0000:0000:0111/128</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To configure Network Firewall to inspect for IP addresses from 1111:0000:0000:0000:0000:0000:0000:0000
        /// to 1111:0000:0000:0000:ffff:ffff:ffff:ffff, specify <code>1111:0000:0000:0000:0000:0000:0000:0000/64</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about CIDR notation, see the Wikipedia entry <a href="https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
        /// Inter-Domain Routing</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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
        /// The destination port to inspect for. You can specify an individual port, for example
        /// <code>1994</code> and you can specify a port range, for example <code>1990:1994</code>.
        /// To match with any port, specify <code>ANY</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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
        /// Gets and sets the property Direction. 
        /// <para>
        /// The direction of traffic flow to inspect. If set to <code>ANY</code>, the inspection
        /// matches bidirectional traffic, both from the source to the destination and from the
        /// destination to the source. If set to <code>FORWARD</code>, the inspection only matches
        /// traffic going from the source to the destination. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StatefulRuleDirection Direction
        {
            get { return this._direction; }
            set { this._direction = value; }
        }

        // Check to see if Direction property is set
        internal bool IsSetDirection()
        {
            return this._direction != null;
        }

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol to inspect for. To specify all, you can use <code>IP</code>, because
        /// all traffic on Amazon Web Services and on the internet is IP.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public StatefulRuleProtocol Protocol
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
        /// Gets and sets the property Source. 
        /// <para>
        /// The source IP address or address range to inspect for, in CIDR notation. To match
        /// with any address, specify <code>ANY</code>. 
        /// </para>
        ///  
        /// <para>
        /// Specify an IP address or a block of IP addresses in Classless Inter-Domain Routing
        /// (CIDR) notation. Network Firewall supports all address ranges for IPv4 and IPv6. 
        /// </para>
        ///  
        /// <para>
        /// Examples: 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// To configure Network Firewall to inspect for the IP address 192.0.2.44, specify <code>192.0.2.44/32</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To configure Network Firewall to inspect for IP addresses from 192.0.2.0 to 192.0.2.255,
        /// specify <code>192.0.2.0/24</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To configure Network Firewall to inspect for the IP address 1111:0000:0000:0000:0000:0000:0000:0111,
        /// specify <code>1111:0000:0000:0000:0000:0000:0000:0111/128</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// To configure Network Firewall to inspect for IP addresses from 1111:0000:0000:0000:0000:0000:0000:0000
        /// to 1111:0000:0000:0000:ffff:ffff:ffff:ffff, specify <code>1111:0000:0000:0000:0000:0000:0000:0000/64</code>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For more information about CIDR notation, see the Wikipedia entry <a href="https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing">Classless
        /// Inter-Domain Routing</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string Source
        {
            get { return this._source; }
            set { this._source = value; }
        }

        // Check to see if Source property is set
        internal bool IsSetSource()
        {
            return this._source != null;
        }

        /// <summary>
        /// Gets and sets the property SourcePort. 
        /// <para>
        /// The source port to inspect for. You can specify an individual port, for example <code>1994</code>
        /// and you can specify a port range, for example <code>1990:1994</code>. To match with
        /// any port, specify <code>ANY</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
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