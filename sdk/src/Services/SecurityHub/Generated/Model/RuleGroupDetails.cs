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
    /// Details about the rule group.
    /// </summary>
    public partial class RuleGroupDetails
    {
        private RuleGroupSource _rulesSource;
        private RuleGroupVariables _ruleVariables;

        /// <summary>
        /// Gets and sets the property RulesSource. 
        /// <para>
        /// The rules and actions for the rule group.
        /// </para>
        ///  
        /// <para>
        /// For stateful rule groups, can contain <c>RulesString</c>, <c>RulesSourceList</c>,
        /// or <c>StatefulRules</c>.
        /// </para>
        ///  
        /// <para>
        /// For stateless rule groups, contains <c>StatelessRulesAndCustomActions</c>.
        /// </para>
        /// </summary>
        public RuleGroupSource RulesSource
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
        /// Additional settings to use in the specified rules.
        /// </para>
        /// </summary>
        public RuleGroupVariables RuleVariables
        {
            get { return this._ruleVariables; }
            set { this._ruleVariables = value; }
        }

        // Check to see if RuleVariables property is set
        internal bool IsSetRuleVariables()
        {
            return this._ruleVariables != null;
        }

    }
}