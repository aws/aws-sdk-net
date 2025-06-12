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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
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
namespace Amazon.EC2.Model
{
    /// <summary>
    /// Describes a stateless rule.
    /// </summary>
    public partial class FirewallStatelessRule
    {
        private List<PortRange> _destinationPorts = AWSConfigs.InitializeCollections ? new List<PortRange>() : null;
        private List<string> _destinations = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private int? _priority;
        private List<int> _protocols = AWSConfigs.InitializeCollections ? new List<int>() : null;
        private string _ruleAction;
        private string _ruleGroupArn;
        private List<PortRange> _sourcePorts = AWSConfigs.InitializeCollections ? new List<PortRange>() : null;
        private List<string> _sources = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Gets and sets the property DestinationPorts. 
        /// <para>
        /// The destination ports.
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
        /// The destination IP addresses, in CIDR notation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Destinations
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
        /// Gets and sets the property Priority. 
        /// <para>
        /// The rule priority.
        /// </para>
        /// </summary>
        [AWSProperty(Min=-1, Max=65535)]
        public int? Priority
        {
            get { return this._priority; }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Protocols. 
        /// <para>
        /// The protocols.
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
        /// Gets and sets the property RuleAction. 
        /// <para>
        /// The rule action. The possible values are <c>pass</c>, <c>drop</c>, and <c>forward_to_site</c>.
        /// </para>
        /// </summary>
        public string RuleAction
        {
            get { return this._ruleAction; }
            set { this._ruleAction = value; }
        }

        // Check to see if RuleAction property is set
        internal bool IsSetRuleAction()
        {
            return this._ruleAction != null;
        }

        /// <summary>
        /// Gets and sets the property RuleGroupArn. 
        /// <para>
        /// The ARN of the stateless rule group.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1283)]
        public string RuleGroupArn
        {
            get { return this._ruleGroupArn; }
            set { this._ruleGroupArn = value; }
        }

        // Check to see if RuleGroupArn property is set
        internal bool IsSetRuleGroupArn()
        {
            return this._ruleGroupArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourcePorts. 
        /// <para>
        /// The source ports.
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
        /// The source IP addresses, in CIDR notation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Sources
        {
            get { return this._sources; }
            set { this._sources = value; }
        }

        // Check to see if Sources property is set
        internal bool IsSetSources()
        {
            return this._sources != null && (this._sources.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}