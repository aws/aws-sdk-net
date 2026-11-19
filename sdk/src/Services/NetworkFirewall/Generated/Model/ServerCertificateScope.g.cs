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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// Settings that define the Secure Sockets Layer/Transport Layer Security (SSL/TLS) traffic
    /// that Network Firewall should decrypt for inspection by the stateful rule engine.
    /// </summary>
    public partial class ServerCertificateScope
    {
        /// <summary>
        /// Gets and sets the property DecryptionAction. 
        /// <para>
        /// Whether the firewall decrypts traffic that matches this scope. You can choose from
        /// the following values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>DECRYPT</c> - The firewall decrypts the traffic for inspection.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>BYPASS</c> - The firewall doesn't decrypt the traffic.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DecryptionAction DecryptionAction { get; set; }

        /// <summary>
        /// Checks to see if the DecryptionAction property is set.
        /// </summary>
        internal bool IsSetDecryptionAction() => this.DecryptionAction != null;

        /// <summary>
        /// Gets and sets the property DeploymentMode. 
        /// <para>
        /// The type of firewall that this scope applies to. If you don't specify a value, the
        /// scope applies to both types, the same as <c>ALL</c>. You can choose from the following
        /// values:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ALL</c> - The scope applies to both transparent firewalls and proxy mode firewalls.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>TRANSPARENT_FIREWALL_ONLY</c> - The scope applies only to transparent firewalls.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>EXPLICIT_PROXY_ONLY</c> - The scope applies only to proxy mode firewalls. A scope
        /// that specifies <c>DomainMatch</c> must use this value.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public TLSInspectionScopeDeploymentMode DeploymentMode { get; set; }

        /// <summary>
        /// Checks to see if the DeploymentMode property is set.
        /// </summary>
        internal bool IsSetDeploymentMode() => this.DeploymentMode != null;

        /// <summary>
        /// Gets and sets the property DestinationPorts. 
        /// <para>
        /// The destination ports to decrypt for inspection, in Transmission Control Protocol
        /// (TCP) format. If not specified, this matches with any destination port.
        /// </para>
        ///  
        /// <para>
        /// You can specify individual ports, for example <c>1994</c>, and you can specify port
        /// ranges, such as <c>1990:1994</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PortRange> DestinationPorts { get; set; } = AWSConfigs.InitializeCollections ? new List<PortRange>() : null;

        /// <summary>
        /// Checks to see if the DestinationPorts property is set.
        /// </summary>
        internal bool IsSetDestinationPorts() => this.DestinationPorts != null && (this.DestinationPorts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Destinations. 
        /// <para>
        /// The destination IP addresses and address ranges to decrypt for inspection, in CIDR
        /// notation. If not specified, this matches with any destination address.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Address> Destinations { get; set; } = AWSConfigs.InitializeCollections ? new List<Address>() : null;

        /// <summary>
        /// Checks to see if the Destinations property is set.
        /// </summary>
        internal bool IsSetDestinations() => this.Destinations != null && (this.Destinations.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property DomainMatch. 
        /// <para>
        /// The domains that this scope matches, based on the host name in the client's HTTP CONNECT
        /// request. Domain matching applies only to proxy mode firewalls. If you specify <c>DomainMatch</c>,
        /// you must set <c>DeploymentMode</c> to <c>EXPLICIT_PROXY_ONLY</c>. If you don't specify
        /// <c>DomainMatch</c>, the scope matches traffic by its source, destination, ports, and
        /// protocols only.
        /// </para>
        /// </summary>
        public DomainMatch DomainMatch { get; set; }

        /// <summary>
        /// Checks to see if the DomainMatch property is set.
        /// </summary>
        internal bool IsSetDomainMatch() => this.DomainMatch != null;

        /// <summary>
        /// Gets and sets the property Protocols. 
        /// <para>
        /// The protocols to inspect for, specified using the assigned internet protocol number
        /// (IANA) for each protocol. If not specified, this matches with any protocol.
        /// </para>
        ///  
        /// <para>
        /// Network Firewall currently supports only TCP.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<int> Protocols { get; set; } = AWSConfigs.InitializeCollections ? new List<int>() : null;

        /// <summary>
        /// Checks to see if the Protocols property is set.
        /// </summary>
        internal bool IsSetProtocols() => this.Protocols != null && (this.Protocols.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property SourcePorts. 
        /// <para>
        /// The source ports to decrypt for inspection, in Transmission Control Protocol (TCP)
        /// format. If not specified, this matches with any source port.
        /// </para>
        ///  
        /// <para>
        /// You can specify individual ports, for example <c>1994</c>, and you can specify port
        /// ranges, such as <c>1990:1994</c>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<PortRange> SourcePorts { get; set; } = AWSConfigs.InitializeCollections ? new List<PortRange>() : null;

        /// <summary>
        /// Checks to see if the SourcePorts property is set.
        /// </summary>
        internal bool IsSetSourcePorts() => this.SourcePorts != null && (this.SourcePorts.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property Sources. 
        /// <para>
        /// The source IP addresses and address ranges to decrypt for inspection, in CIDR notation.
        /// If not specified, this matches with any source address.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Address> Sources { get; set; } = AWSConfigs.InitializeCollections ? new List<Address>() : null;

        /// <summary>
        /// Checks to see if the Sources property is set.
        /// </summary>
        internal bool IsSetSources() => this.Sources != null && (this.Sources.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
