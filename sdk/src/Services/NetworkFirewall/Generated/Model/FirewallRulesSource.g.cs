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
    /// The source of the rules for a firewall engine rule group. You provide the rules as
    /// a single Suricata-compatible rule string, as a list of structured firewall rules,
    /// or as a list of domain names to generate rules from.
    /// </summary>
    public partial class FirewallRulesSource
    {
        /// <summary>
        /// Gets and sets the property FirewallRules. 
        /// <para>
        /// An array of individual firewall engine rules, provided as structured rules rather
        /// than as a rule string.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<FirewallRule> FirewallRules { get; set; } = AWSConfigs.InitializeCollections ? new List<FirewallRule>() : null;

        /// <summary>
        /// Checks to see if the FirewallRules property is set.
        /// </summary>
        internal bool IsSetFirewallRules() => this.FirewallRules != null && (this.FirewallRules.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property RulesSourceList. 
        /// <para>
        /// Stateful inspection criteria for a domain list, specified as the list of domain names
        /// that Network Firewall generates firewall engine rules from.
        /// </para>
        /// </summary>
        public RulesSourceList RulesSourceList { get; set; }

        /// <summary>
        /// Checks to see if the RulesSourceList property is set.
        /// </summary>
        internal bool IsSetRulesSourceList() => this.RulesSourceList != null;

        /// <summary>
        /// Gets and sets the property RulesString. 
        /// <para>
        /// Firewall engine rules, provided as a single Suricata-compatible rule string in firewall
        /// mode. Use this to provide rules that you've already written in the Suricata firewall-mode
        /// format. For the rule format, see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/rule-groups-v2.html">Rule
        /// groups for a firewall using a Next Generation policy</a> in the <i>Network Firewall
        /// Developer Guide</i>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 2000000)]
        public string RulesString { get; set; }

        /// <summary>
        /// Checks to see if the RulesString property is set.
        /// </summary>
        internal bool IsSetRulesString() => this.RulesString != null;
    }
}
