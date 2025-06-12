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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Criteria for Network Firewall to use to inspect an individual packet in stateless
    /// rule inspection. Each match attributes set can include one or more items such as IP
    /// address, CIDR range, port number, protocol, and TCP flags.
    /// </summary>
    public partial class MatchAttributes
    {
        private List<PortRange> _destinationPorts = AWSConfigs.InitializeCollections ? new List<PortRange>() : null;
        private List<Address> _destinations = AWSConfigs.InitializeCollections ? new List<Address>() : null;
        private List<int> _protocols = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private List<PortRange> _sourcePorts = AWSConfigs.InitializeCollections ? new List<PortRange>() : null;
        private List<Address> _sources = AWSConfigs.InitializeCollections ? new List<Address>() : null;
        private List<TCPFlagField> _tcpFlags = AWSConfigs.InitializeCollections ? new List<TCPFlagField>() : null;

        /// <summary>
        /// Gets and sets the property DestinationPorts. 
        /// <para>
        /// The destination port to inspect for. You can specify an individual port, for example
        /// <c>1994</c> and you can specify a port range, for example <c>1990:1994</c>. To match
        /// with any port, specify <c>ANY</c>.
        /// </para>
        ///  
        /// <para>
        /// This setting is only used for protocols 6 (TCP) and 17 (UDP). 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PortRange> DestinationPorts
        {
            get { return this._destinationPorts; }
            set { this._destinationPorts = value; }
        }

        // Check to see if DestinationPorts property is set
        internal bool IsSetDestinationPorts()
        {
            return this._destinationPorts != null && (this._destinationPorts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// The destination IP addresses and address ranges to inspect for, in CIDR notation.
        /// If not specified, this matches with any destination address. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Address> Destinations
        {
            get { return this._destinations; }
            set { this._destinations = value; }
        }

        // Check to see if Destinations property is set
        internal bool IsSetDestinations()
        {
            return this._destinations != null && (this._destinations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Protocols. 
        /// <para>
        /// The protocols to inspect for, specified using the assigned internet protocol number
        /// (IANA) for each protocol. If not specified, this matches with any protocol.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Protocols
        {
            get { return this._protocols; }
            set { this._protocols = value; }
        }

        // Check to see if Protocols property is set
        internal bool IsSetProtocols()
        {
            return this._protocols != null && (this._protocols.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property SourcePorts. 
        /// <para>
        /// The source port to inspect for. You can specify an individual port, for example <c>1994</c>
        /// and you can specify a port range, for example <c>1990:1994</c>. To match with any
        /// port, specify <c>ANY</c>.
        /// </para>
        ///  
        /// <para>
        ///  If not specified, this matches with any source port.
        /// </para>
        ///  
        /// <para>
        /// This setting is only used for protocols 6 (TCP) and 17 (UDP).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PortRange> SourcePorts
        {
            get { return this._sourcePorts; }
            set { this._sourcePorts = value; }
        }

        // Check to see if SourcePorts property is set
        internal bool IsSetSourcePorts()
        {
            return this._sourcePorts != null && (this._sourcePorts.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// The source IP addresses and address ranges to inspect for, in CIDR notation. If not
        /// specified, this matches with any source address. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Address> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && (this._sources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TCPFlags. 
        /// <para>
        /// The TCP flags and masks to inspect for. If not specified, this matches with any settings.
        /// This setting is only used for protocol 6 (TCP).
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<TCPFlagField> TCPFlags
        {
            get { return this._tcpFlags; }
            set { this._tcpFlags = value; }
        }

        // Check to see if TCPFlags property is set
        internal bool IsSetTCPFlags()
        {
            return this._tcpFlags != null && (this._tcpFlags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}