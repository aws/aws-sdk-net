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
    /// Container for the parameters to the CreateAutomationRule operation.
    /// Creates an automation rule based on input parameters.
    /// </summary>
    public partial class CreateAutomationRuleRequest : AmazonSecurityHubRequest
    {
        private List<AutomationRulesAction> _actions = new List<AutomationRulesAction>();
        private AutomationRulesFindingFilters _criteria;
        private string _description;
        private bool? _isTerminal;
        private string _ruleName;
        private int? _ruleOrder;
        private RuleStatus _ruleStatus;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property Actions. 
        /// <para>
        ///  One or more actions to update finding fields if a finding matches the conditions
        /// specified in <code>Criteria</code>. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1)]
        public List<AutomationRulesAction> Actions
        {
            get { return this._actions; }
            set { this._actions = value; }
        }

        // Check to see if Actions property is set
        internal bool IsSetActions()
        {
            return this._actions != null && this._actions.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property Criteria. 
        /// <para>
        ///  A set of ASFF finding field attributes and corresponding expected values that Security
        /// Hub uses to filter findings. If a finding matches the conditions specified in this
        /// parameter, Security Hub applies the rule action to the finding. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutomationRulesFindingFilters Criteria
        {
            get { return this._criteria; }
            set { this._criteria = value; }
        }

        // Check to see if Criteria property is set
        internal bool IsSetCriteria()
        {
            return this._criteria != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  A description of the rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property IsTerminal. 
        /// <para>
        /// Specifies whether a rule is the last to be applied with respect to a finding that
        /// matches the rule criteria. This is useful when a finding matches the criteria for
        /// multiple rules, and each rule has different actions. If the value of this field is
        /// set to <code>true</code> for a rule, Security Hub applies the rule action to a finding
        /// that matches the rule criteria and won't evaluate other rules for the finding. The
        /// default value of this field is <code>false</code>. 
        /// </para>
        /// </summary>
        public bool IsTerminal
        {
            get { return this._isTerminal.GetValueOrDefault(); }
            set { this._isTerminal = value; }
        }

        // Check to see if IsTerminal property is set
        internal bool IsSetIsTerminal()
        {
            return this._isTerminal.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleName. 
        /// <para>
        ///  The name of the rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string RuleName
        {
            get { return this._ruleName; }
            set { this._ruleName = value; }
        }

        // Check to see if RuleName property is set
        internal bool IsSetRuleName()
        {
            return this._ruleName != null;
        }

        /// <summary>
        /// Gets and sets the property RuleOrder. 
        /// <para>
        /// An integer ranging from 1 to 1000 that represents the order in which the rule action
        /// is applied to findings. Security Hub applies rules with lower values for this parameter
        /// first. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1000)]
        public int RuleOrder
        {
            get { return this._ruleOrder.GetValueOrDefault(); }
            set { this._ruleOrder = value; }
        }

        // Check to see if RuleOrder property is set
        internal bool IsSetRuleOrder()
        {
            return this._ruleOrder.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleStatus. 
        /// <para>
        ///  Whether the rule is active after it is created. If this parameter is equal to <code>Enabled</code>,
        /// Security Hub will apply the rule to findings and finding updates after the rule is
        /// created. To change the value of this parameter after creating a rule, use <code>BatchUpdateAutomationRules</code>.
        /// 
        /// </para>
        /// </summary>
        public RuleStatus RuleStatus
        {
            get { return this._ruleStatus; }
            set { this._ruleStatus = value; }
        }

        // Check to see if RuleStatus property is set
        internal bool IsSetRuleStatus()
        {
            return this._ruleStatus != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        ///  User-defined tags that help you label the purpose of a rule. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && this._tags.Count > 0; 
        }

    }
}