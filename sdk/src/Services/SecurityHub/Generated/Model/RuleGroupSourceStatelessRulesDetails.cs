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
    /// A stateless rule in the rule group.
    /// </summary>
    public partial class RuleGroupSourceStatelessRulesDetails
    {
        private int? _priority;
        private RuleGroupSourceStatelessRuleDefinition _ruleDefinition;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// Indicates the order in which to run this rule relative to all of the rules in the
        /// stateless rule group.
        /// </para>
        /// </summary>
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
        /// Provides the definition of the stateless rule.
        /// </para>
        /// </summary>
        public RuleGroupSourceStatelessRuleDefinition RuleDefinition
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