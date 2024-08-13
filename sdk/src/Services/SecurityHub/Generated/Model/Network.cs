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
 * Do not modify this file. This file is generated from the securityhub-2018-10-26.normal.json service model.
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
        private string _destinationDomain;
        private string _destinationIpV4;
        private string _destinationIpV6;
        private int? _destinationPort;
        private NetworkDirection _direction;
        private PortRange _openPortRange;
        private string _protocol;
        private string _sourceDomain;
        private string _sourceIpV4;
        private string _sourceIpV6;
        private string _sourceMac;
        private int? _sourcePort;

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
        public string DestinationDomain
        {
            get { return this._destinationDomain; }
            set { this._destinationDomain = value; }
        }

        // Check to see if DestinationDomain property is set
        internal bool IsSetDestinationDomain()
        {
            return this._destinationDomain != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationIpV4. 
        /// <para>
        /// The destination IPv4 address of network-related information about a finding.
        /// </para>
        /// </summary>
        public string DestinationIpV4
        {
            get { return this._destinationIpV4; }
            set { this._destinationIpV4 = value; }
        }

        // Check to see if DestinationIpV4 property is set
        internal bool IsSetDestinationIpV4()
        {
            return this._destinationIpV4 != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationIpV6. 
        /// <para>
        /// The destination IPv6 address of network-related information about a finding.
        /// </para>
        /// </summary>
        public string DestinationIpV6
        {
            get { return this._destinationIpV6; }
            set { this._destinationIpV6 = value; }
        }

        // Check to see if DestinationIpV6 property is set
        internal bool IsSetDestinationIpV6()
        {
            return this._destinationIpV6 != null;
        }

        /// <summary>
        /// Gets and sets the property DestinationPort. 
        /// <para>
        /// The destination port of network-related information about a finding.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Direction. 
        /// <para>
        /// The direction of network traffic associated with a finding.
        /// </para>
        /// </summary>
        public NetworkDirection Direction
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
        /// Gets and sets the property OpenPortRange. 
        /// <para>
        /// The range of open ports that is present on the network.
        /// </para>
        /// </summary>
        public PortRange OpenPortRange
        {
            get { return this._openPortRange; }
            set { this._openPortRange = value; }
        }

        // Check to see if OpenPortRange property is set
        internal bool IsSetOpenPortRange()
        {
            return this._openPortRange != null;
        }

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
        public string Protocol
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
        /// Gets and sets the property SourceDomain. 
        /// <para>
        /// The source domain of network-related information about a finding.
        /// </para>
        ///  
        /// <para>
        /// Length Constraints: Minimum of 1. Maximum of 128.
        /// </para>
        /// </summary>
        public string SourceDomain
        {
            get { return this._sourceDomain; }
            set { this._sourceDomain = value; }
        }

        // Check to see if SourceDomain property is set
        internal bool IsSetSourceDomain()
        {
            return this._sourceDomain != null;
        }

        /// <summary>
        /// Gets and sets the property SourceIpV4. 
        /// <para>
        /// The source IPv4 address of network-related information about a finding.
        /// </para>
        /// </summary>
        public string SourceIpV4
        {
            get { return this._sourceIpV4; }
            set { this._sourceIpV4 = value; }
        }

        // Check to see if SourceIpV4 property is set
        internal bool IsSetSourceIpV4()
        {
            return this._sourceIpV4 != null;
        }

        /// <summary>
        /// Gets and sets the property SourceIpV6. 
        /// <para>
        /// The source IPv6 address of network-related information about a finding.
        /// </para>
        /// </summary>
        public string SourceIpV6
        {
            get { return this._sourceIpV6; }
            set { this._sourceIpV6 = value; }
        }

        // Check to see if SourceIpV6 property is set
        internal bool IsSetSourceIpV6()
        {
            return this._sourceIpV6 != null;
        }

        /// <summary>
        /// Gets and sets the property SourceMac. 
        /// <para>
        /// The source media access control (MAC) address of network-related information about
        /// a finding.
        /// </para>
        /// </summary>
        public string SourceMac
        {
            get { return this._sourceMac; }
            set { this._sourceMac = value; }
        }

        // Check to see if SourceMac property is set
        internal bool IsSetSourceMac()
        {
            return this._sourceMac != null;
        }

        /// <summary>
        /// Gets and sets the property SourcePort. 
        /// <para>
        /// The source port of network-related information about a finding.
        /// </para>
        /// </summary>
        public int? SourcePort
        {
            get { return this._sourcePort; }
            set { this._sourcePort = value; }
        }

        // Check to see if SourcePort property is set
        internal bool IsSetSourcePort()
        {
            return this._sourcePort.HasValue; 
        }

    }
}