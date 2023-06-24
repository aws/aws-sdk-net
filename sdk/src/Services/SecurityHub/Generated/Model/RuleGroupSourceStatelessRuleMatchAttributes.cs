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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Criteria for the stateless rule.
    /// </summary>
    public partial class RuleGroupSourceStatelessRuleMatchAttributes
    {
        private List<RuleGroupSourceStatelessRuleMatchAttributesDestinationPorts> _destinationPorts = new List<RuleGroupSourceStatelessRuleMatchAttributesDestinationPorts>();
        private List<RuleGroupSourceStatelessRuleMatchAttributesDestinations> _destinations = new List<RuleGroupSourceStatelessRuleMatchAttributesDestinations>();
        private List<int> _protocols = new List<int>();
        private List<RuleGroupSourceStatelessRuleMatchAttributesSourcePorts> _sourcePorts = new List<RuleGroupSourceStatelessRuleMatchAttributesSourcePorts>();
        private List<RuleGroupSourceStatelessRuleMatchAttributesSources> _sources = new List<RuleGroupSourceStatelessRuleMatchAttributesSources>();
        private List<RuleGroupSourceStatelessRuleMatchAttributesTcpFlags> _tcpFlags = new List<RuleGroupSourceStatelessRuleMatchAttributesTcpFlags>();

        /// <summary>
        /// Gets and sets the property DestinationPorts. 
        /// <para>
        /// A list of port ranges to specify the destination ports to inspect for.
        /// </para>
        /// </summary>
        public List<RuleGroupSourceStatelessRuleMatchAttributesDestinationPorts> DestinationPorts
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
        /// The destination IP addresses and address ranges to inspect for, in CIDR notation.
        /// </para>
        /// </summary>
        public List<RuleGroupSourceStatelessRuleMatchAttributesDestinations> Destinations
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
        /// The protocols to inspect for.
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
        /// A list of port ranges to specify the source ports to inspect for.
        /// </para>
        /// </summary>
        public List<RuleGroupSourceStatelessRuleMatchAttributesSourcePorts> SourcePorts
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
        /// The source IP addresses and address ranges to inspect for, in CIDR notation.
        /// </para>
        /// </summary>
        public List<RuleGroupSourceStatelessRuleMatchAttributesSources> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && this._sources.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property TcpFlags. 
        /// <para>
        /// The TCP flags and masks to inspect for.
        /// </para>
        /// </summary>
        public List<RuleGroupSourceStatelessRuleMatchAttributesTcpFlags> TcpFlags
        {
            get { return this._tcpFlags; }
            set { this._tcpFlags = value; }
        }

        // Check to see if TcpFlags property is set
        internal bool IsSetTcpFlags()
        {
            return this._tcpFlags != null && this._tcpFlags.Count > 0; 
        }

    }
}