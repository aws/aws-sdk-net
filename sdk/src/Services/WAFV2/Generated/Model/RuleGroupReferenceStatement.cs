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
 * Do not modify this file. This file is generated from the wafv2-2019-07-29.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// A rule statement used to run the rules that are defined in a <a>RuleGroup</a>. To
    /// use this, create a rule group with your rules, then provide the ARN of the rule group
    /// in this statement.
    /// 
    ///  
    /// <para>
    /// You cannot nest a <code>RuleGroupReferenceStatement</code>, for example for use inside
    /// a <code>NotStatement</code> or <code>OrStatement</code>. You can only use a rule group
    /// reference statement at the top level inside a web ACL. 
    /// </para>
    /// </summary>
    public partial class RuleGroupReferenceStatement
    {
        private string _arn;
        private List<ExcludedRule> _excludedRules = new List<ExcludedRule>();
        private List<RuleActionOverride> _ruleActionOverrides = new List<RuleActionOverride>();

        /// <summary>
        /// Gets and sets the property ARN. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the entity.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
        public string ARN
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if ARN property is set
        internal bool IsSetARN()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ExcludedRules. 
        /// <para>
        /// Rules in the referenced rule group whose actions are set to <code>Count</code>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// Instead of this option, use <code>RuleActionOverrides</code>. It accepts any valid
        /// action setting, including <code>Count</code>.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=100)]
        public List<ExcludedRule> ExcludedRules
        {
            get { return this._excludedRules; }
            set { this._excludedRules = value; }
        }

        // Check to see if ExcludedRules property is set
        internal bool IsSetExcludedRules()
        {
            return this._excludedRules != null && this._excludedRules.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property RuleActionOverrides. 
        /// <para>
        /// Action settings to use in the place of the rule actions that are configured inside
        /// the rule group. You specify one override for each rule whose action you want to change.
        /// 
        /// </para>
        ///  
        /// <para>
        /// You can use overrides for testing, for example you can override all of rule actions
        /// to <code>Count</code> and then monitor the resulting count metrics to understand how
        /// the rule group would handle your web traffic. You can also permanently override some
        /// or all actions, to modify how the rule group manages your web traffic.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=100)]
        public List<RuleActionOverride> RuleActionOverrides
        {
            get { return this._ruleActionOverrides; }
            set { this._ruleActionOverrides = value; }
        }

        // Check to see if RuleActionOverrides property is set
        internal bool IsSetRuleActionOverrides()
        {
            return this._ruleActionOverrides != null && this._ruleActionOverrides.Count > 0; 
        }

    }
}