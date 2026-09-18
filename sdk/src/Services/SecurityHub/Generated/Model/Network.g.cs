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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// The details of network-related information about a finding.
    /// </summary>
    public partial class Network
    {
        /// <summary>
        /// Gets and sets the property DestinationDomain. 
        /// <para>
        /// The destination domain of network-related information about a finding.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum of 1. Maximum of 128.
        /// </para>
        /// </summary>
        public string DestinationDomain { get; set; }

        /// <summary>
        /// Checks to see if the DestinationDomain property is set.
        /// </summary>
        internal bool IsSetDestinationDomain() => this.DestinationDomain != null;

        /// <summary>
        /// Gets and sets the property DestinationIpV4. 
        /// <para>
        /// The destination IPv4 address of network-related information about a finding.
        /// </para>
        /// </summary>
        public string DestinationIpV4 { get; set; }

        /// <summary>
        /// Checks to see if the DestinationIpV4 property is set.
        /// </summary>
        internal bool IsSetDestinationIpV4() => this.DestinationIpV4 != null;

        /// <summary>
        /// Gets and sets the property DestinationIpV6. 
        /// <para>
        /// The destination IPv6 address of network-related information about a finding.
        /// </para>
        /// </summary>
        public string DestinationIpV6 { get; set; }

        /// <summary>
        /// Checks to see if the DestinationIpV6 property is set.
        /// </summary>
        internal bool IsSetDestinationIpV6() => this.DestinationIpV6 != null;

        /// <summary>
        /// Gets and sets the property DestinationPort. 
        /// <para>
        /// The destination port of network-related information about a finding.
        /// </para>
        /// </summary>
        public int? DestinationPort { get; set; }

        /// <summary>
        /// Checks to see if the DestinationPort property is set.
        /// </summary>
        internal bool IsSetDestinationPort() => this.DestinationPort.HasValue;

        /// <summary>
        /// Gets and sets the property Direction. 
        /// <para>
        /// The direction of network traffic associated with a finding.
        /// </para>
        /// </summary>
        public NetworkDirection Direction { get; set; }

        /// <summary>
        /// Checks to see if the Direction property is set.
        /// </summary>
        internal bool IsSetDirection() => this.Direction != null;

        /// <summary>
        /// Gets and sets the property OpenPortRange. 
        /// <para>
        /// The range of open ports that is present on the network.
        /// </para>
        /// </summary>
        public PortRange OpenPortRange { get; set; }

        /// <summary>
        /// Checks to see if the OpenPortRange property is set.
        /// </summary>
        internal bool IsSetOpenPortRange() => this.OpenPortRange != null;

        /// <summary>
        /// Gets and sets the property Protocol. 
        /// <para>
        /// The protocol of network-related information about a finding.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum of 1. Maximum of 16.
        /// </para>
        /// </summary>
        public string Protocol { get; set; }

        /// <summary>
        /// Checks to see if the Protocol property is set.
        /// </summary>
        internal bool IsSetProtocol() => this.Protocol != null;

        /// <summary>
        /// Gets and sets the property SourceDomain. 
        /// <para>
        /// The source domain of network-related information about a finding.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum of 1. Maximum of 128.
        /// </para>
        /// </summary>
        public string SourceDomain { get; set; }

        /// <summary>
        /// Checks to see if the SourceDomain property is set.
        /// </summary>
        internal bool IsSetSourceDomain() => this.SourceDomain != null;

        /// <summary>
        /// Gets and sets the property SourceIpV4. 
        /// <para>
        /// The source IPv4 address of network-related information about a finding.
        /// </para>
        /// </summary>
        public string SourceIpV4 { get; set; }

        /// <summary>
        /// Checks to see if the SourceIpV4 property is set.
        /// </summary>
        internal bool IsSetSourceIpV4() => this.SourceIpV4 != null;

        /// <summary>
        /// Gets and sets the property SourceIpV6. 
        /// <para>
        /// The source IPv6 address of network-related information about a finding.
        /// </para>
        /// </summary>
        public string SourceIpV6 { get; set; }

        /// <summary>
        /// Checks to see if the SourceIpV6 property is set.
        /// </summary>
        internal bool IsSetSourceIpV6() => this.SourceIpV6 != null;

        /// <summary>
        /// Gets and sets the property SourceMac. 
        /// <para>
        /// The source media access control (MAC) address of network-related information about
        /// a finding.
        /// </para>
        /// </summary>
        public string SourceMac { get; set; }

        /// <summary>
        /// Checks to see if the SourceMac property is set.
        /// </summary>
        internal bool IsSetSourceMac() => this.SourceMac != null;

        /// <summary>
        /// Gets and sets the property SourcePort. 
        /// <para>
        /// The source port of network-related information about a finding.
        /// </para>
        /// </summary>
        public int? SourcePort { get; set; }

        /// <summary>
        /// Checks to see if the SourcePort property is set.
        /// </summary>
        internal bool IsSetSourcePort() => this.SourcePort.HasValue;
    }
}
