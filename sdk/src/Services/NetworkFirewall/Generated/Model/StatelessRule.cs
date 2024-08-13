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
    /// A single stateless rule. This is used in <a>StatelessRulesAndCustomActions</a>.
    /// </summary>
    public partial class StatelessRule
    {
        private int? _priority;
        private RuleDefinition _ruleDefinition;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// Indicates the order in which to run this rule relative to all of the rules that are
        /// defined for a stateless rule group. Network Firewall evaluates the rules in a rule
        /// group starting with the lowest priority setting. You must ensure that the priority
        /// settings are unique for the rule group. 
        /// </para>
        ///  
        /// <para>
        /// Each stateless rule group uses exactly one <c>StatelessRulesAndCustomActions</c> object,
        /// and each <c>StatelessRulesAndCustomActions</c> contains exactly one <c>StatelessRules</c>
        /// object. To ensure unique priority settings for your rule groups, set unique priorities
        /// for the stateless rules that you define inside any single <c>StatelessRules</c> object.
        /// </para>
        ///  
        /// <para>
        /// You can change the priority settings of your rules at any time. To make it easier
        /// to insert rules later, number them so there's a wide range in between, for example
        /// use 100, 200, and so on. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=65535)]
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
        /// Gets and sets the property RuleDefinition. 
        /// <para>
        /// Defines the stateless 5-tuple packet inspection criteria and the action to take on
        /// a packet that matches the criteria. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RuleDefinition RuleDefinition
        {
            get { return this._ruleDefinition; }
            set { this._ruleDefinition = value; }
        }

        // Check to see if RuleDefinition property is set
        internal bool IsSetRuleDefinition()
        {
            return this._ruleDefinition != null;
        }

    }
}