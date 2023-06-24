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
    /// Settings that define the Secure Sockets Layer/Transport Layer Security (SSL/TLS) traffic
    /// that Network Firewall should decrypt for inspection by the stateful rule engine.
    /// </summary>
    public partial class ServerCertificateScope
    {
        private List<PortRange> _destinationPorts = new List<PortRange>();
        private List<Address> _destinations = new List<Address>();
        private List<int> _protocols = new List<int>();
        private List<PortRange> _sourcePorts = new List<PortRange>();
        private List<Address> _sources = new List<Address>();

        /// <summary>
        /// Gets and sets the property DestinationPorts. 
        /// <para>
        /// The destination ports to decrypt for inspection, in Transmission Control Protocol
        /// (TCP) format. If not specified, this matches with any destination port.
        /// </para>
        ///  
        /// <para>
        /// You can specify individual ports, for example <code>1994</code>, and you can specify
        /// port ranges, such as <code>1990:1994</code>.
        /// </para>
        /// </summary>
        public List<PortRange> DestinationPorts
        {
            get { return this._destinationPorts; }
            set { this._destinationPorts = value; }
        }

        // Check to see if DestinationPorts property is set
        internal bool IsSetDestinationPorts()
        {
            return this._destinationPorts != null && this._destinationPorts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// The destination IP addresses and address ranges to decrypt for inspection, in CIDR
        /// notation. If not specified, this matches with any destination address.
        /// </para>
        /// </summary>
        public List<Address> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && this._destinations.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Protocols. 
        /// <para>
        /// The protocols to decrypt for inspection, specified using each protocol's assigned
        /// internet protocol number (IANA). Network Firewall currently supports only TCP.
        /// </para>
        /// </summary>
        public List<int> Protocols
        {
            get { return this._protocols; }
            set { this._protocols = value; }
        }

        // Check to see if Protocols property is set
        internal bool IsSetProtocols()
        {
            return this._protocols != null && this._protocols.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property SourcePorts. 
        /// <para>
        /// The source ports to decrypt for inspection, in Transmission Control Protocol (TCP)
        /// format. If not specified, this matches with any source port.
        /// </para>
        ///  
        /// <para>
        /// You can specify individual ports, for example <code>1994</code>, and you can specify
        /// port ranges, such as <code>1990:1994</code>.
        /// </para>
        /// </summary>
        public List<PortRange> SourcePorts
        {
            get { return this._sourcePorts; }
            set { this._sourcePorts = value; }
        }

        // Check to see if SourcePorts property is set
        internal bool IsSetSourcePorts()
        {
            return this._sourcePorts != null && this._sourcePorts.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// The source IP addresses and address ranges to decrypt for inspection, in CIDR notation.
        /// If not specified, this matches with any source address.
        /// </para>
        /// </summary>
        public List<Address> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && this._sources.Count > 0; 
        }

    }
}