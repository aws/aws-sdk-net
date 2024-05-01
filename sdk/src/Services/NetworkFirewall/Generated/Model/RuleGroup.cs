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
    /// The object that defines the rules in a rule group. This, along with <a>RuleGroupResponse</a>,
    /// define the rule group. You can retrieve all objects for a rule group by calling <a>DescribeRuleGroup</a>.
    /// 
    /// 
    ///  
    /// <para>
    /// Network Firewall uses a rule group to inspect and control network traffic. You define
    /// stateless rule groups to inspect individual packets and you define stateful rule groups
    /// to inspect packets in the context of their traffic flow. 
    /// </para>
    ///  
    /// <para>
    /// To use a rule group, you include it by reference in an Network Firewall firewall policy,
    /// then you use the policy in a firewall. You can reference a rule group from more than
    /// one firewall policy, and you can use a firewall policy in more than one firewall.
    /// 
    /// </para>
    /// </summary>
    public partial class RuleGroup
    {
        private ReferenceSets _referenceSets;
        private RulesSource _rulesSource;
        private RuleVariables _ruleVariables;
        private StatefulRuleOptions _statefulRuleOptions;

        /// <summary>
        /// Gets and sets the property ReferenceSets. 
        /// <para>
        /// The list of a rule group's reference sets.
        /// </para>
        /// </summary>
        public ReferenceSets ReferenceSets
        {
            get { return this._referenceSets; }
            set { this._referenceSets = value; }
        }

        // Check to see if ReferenceSets property is set
        internal bool IsSetReferenceSets()
        {
            return this._referenceSets != null;
        }

        /// <summary>
        /// Gets and sets the property RulesSource. 
        /// <para>
        /// The stateful rules or stateless rules for the rule group. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RulesSource RulesSource
        {
            get { return this._rulesSource; }
            set { this._rulesSource = value; }
        }

        // Check to see if RulesSource property is set
        internal bool IsSetRulesSource()
        {
            return this._rulesSource != null;
        }

        /// <summary>
        /// Gets and sets the property RuleVariables. 
        /// <para>
        /// Settings that are available for use in the rules in the rule group. You can only use
        /// these for stateful rule groups. 
        /// </para>
        /// </summary>
        public RuleVariables RuleVariables
        {
            get { return this._ruleVariables; }
            set { this._ruleVariables = value; }
        }

        // Check to see if RuleVariables property is set
        internal bool IsSetRuleVariables()
        {
            return this._ruleVariables != null;
        }

        /// <summary>
        /// Gets and sets the property StatefulRuleOptions. 
        /// <para>
        /// Additional options governing how Network Firewall handles stateful rules. The policies
        /// where you use your stateful rule group must have stateful rule options settings that
        /// are compatible with these settings. Some limitations apply; for more information,
        /// see <a href="https://docs.aws.amazon.com/network-firewall/latest/developerguide/suricata-limitations-caveats.html">Strict
        /// evaluation order</a> in the <i>Network Firewall Developer Guide</i>.
        /// </para>
        /// </summary>
        public StatefulRuleOptions StatefulRuleOptions
        {
            get { return this._statefulRuleOptions; }
            set { this._statefulRuleOptions = value; }
        }

        // Check to see if StatefulRuleOptions property is set
        internal bool IsSetStatefulRuleOptions()
        {
            return this._statefulRuleOptions != null;
        }

    }
}