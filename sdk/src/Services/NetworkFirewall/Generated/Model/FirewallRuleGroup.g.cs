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
    /// The object that defines a firewall engine rule group, for use in a Next Generation
    /// policy. A firewall engine rule group provides access-control rules that the firewall
    /// engine evaluates at connection-state hooks. You provide the rules as a Suricata-compatible
    /// rule string, as structured firewall rules, or generated from a list of domain names.
    /// For more information, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/rule-groups-v2.html">Rule
    /// groups for a firewall using a Next Generation policy</a> in the <i>Network Firewall
    /// Developer Guide</i>.
    /// </summary>
    public partial class FirewallRuleGroup
    {
        /// <summary>
        /// Gets and sets the property ReferenceSets. 
        /// <para>
        /// The list of a rule group's reference sets. Firewall engine rule groups don't support
        /// IP set references (reference sets); this setting applies to IPS engine rule groups.
        /// To use CIDR ranges in firewall engine rules, use rule variables instead.
        /// </para>
        /// </summary>
        public ReferenceSets ReferenceSets { get; set; }

        /// <summary>
        /// Checks to see if the ReferenceSets property is set.
        /// </summary>
        internal bool IsSetReferenceSets() => this.ReferenceSets != null;

        /// <summary>
        /// Gets and sets the property RuleVariables. 
        /// <para>
        /// Settings that are available for use in the rules in the firewall engine rule group,
        /// such as IP set and port variables that the rules reference.
        /// </para>
        /// </summary>
        public RuleVariables RuleVariables { get; set; }

        /// <summary>
        /// Checks to see if the RuleVariables property is set.
        /// </summary>
        internal bool IsSetRuleVariables() => this.RuleVariables != null;

        /// <summary>
        /// Gets and sets the property RulesSource. 
        /// <para>
        /// The stateful inspection criteria for the firewall engine rule group.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FirewallRulesSource RulesSource { get; set; }

        /// <summary>
        /// Checks to see if the RulesSource property is set.
        /// </summary>
        internal bool IsSetRulesSource() => this.RulesSource != null;
    }
}
