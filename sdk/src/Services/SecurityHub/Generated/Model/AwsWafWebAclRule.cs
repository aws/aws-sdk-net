/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Details for a rule in a WAF WebACL.
    /// </summary>
    public partial class AwsWafWebAclRule
    {
        private WafAction _action;
        private List<WafExcludedRule> _excludedRules = new List<WafExcludedRule>();
        private WafOverrideAction _overrideAction;
        private int? _priority;
        private string _ruleId;
        private string _type;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies the action that CloudFront or AWS WAF takes when a web request matches the
        /// conditions in the Rule. 
        /// </para>
        /// </summary>
        public WafAction Action
        {
            get { return this._action; }
            set { this._action = value; }
        }

        // Check to see if Action property is set
        internal bool IsSetAction()
        {
            return this._action != null;
        }

        /// <summary>
        /// Gets and sets the property ExcludedRules. 
        /// <para>
        /// Rules to exclude from a rule group.
        /// </para>
        /// </summary>
        public List<WafExcludedRule> ExcludedRules
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
        /// Gets and sets the property OverrideAction. 
        /// <para>
        /// Use the <code>OverrideAction</code> to test your RuleGroup.
        /// </para>
        ///  
        /// <para>
        /// Any rule in a RuleGroup can potentially block a request. If you set the <code>OverrideAction</code>
        /// to <code>None</code>, the RuleGroup blocks a request if any individual rule in the
        /// RuleGroup matches the request and is configured to block that request.
        /// </para>
        ///  
        /// <para>
        /// However, if you first want to test the RuleGroup, set the <code>OverrideAction</code>
        /// to <code>Count</code>. The RuleGroup then overrides any block action specified by
        /// individual rules contained within the group. Instead of blocking matching requests,
        /// those requests are counted.
        /// </para>
        ///  
        /// <para>
        ///  <code>ActivatedRule</code>|<code>OverrideAction</code> applies only when updating
        /// or adding a RuleGroup to a WebACL. In this case you do not use <code>ActivatedRule</code>|<code>Action</code>.
        /// For all other update requests, <code>ActivatedRule</code>|<code>Action</code> is used
        /// instead of <code>ActivatedRule</code>|<code>OverrideAction</code>. 
        /// </para>
        /// </summary>
        public WafOverrideAction OverrideAction
        {
            get { return this._overrideAction; }
            set { this._overrideAction = value; }
        }

        // Check to see if OverrideAction property is set
        internal bool IsSetOverrideAction()
        {
            return this._overrideAction != null;
        }

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// Specifies the order in which the Rules in a WebACL are evaluated. Rules with a lower
        /// value for Priority are evaluated before Rules with a higher value. The value must
        /// be a unique integer. If you add multiple Rules to a WebACL, the values do not need
        /// to be consecutive.
        /// </para>
        /// </summary>
        public int Priority
        {
            get { return this._priority.GetValueOrDefault(); }
            set { this._priority = value; }
        }

        // Check to see if Priority property is set
        internal bool IsSetPriority()
        {
            return this._priority.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RuleId. 
        /// <para>
        /// The identifier for a Rule.
        /// </para>
        /// </summary>
        public string RuleId
        {
            get { return this._ruleId; }
            set { this._ruleId = value; }
        }

        // Check to see if RuleId property is set
        internal bool IsSetRuleId()
        {
            return this._ruleId != null;
        }

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The rule type.
        /// </para>
        ///  
        /// <para>
        /// Valid values: <code>REGULAR</code> | <code>RATE_BASED</code> | <code>GROUP</code>
        /// 
        /// </para>
        ///  
        /// <para>
        /// The default is <code>REGULAR</code>.
        /// </para>
        /// </summary>
        public string Type
        {
            get { return this._type; }
            set { this._type = value; }
        }

        // Check to see if Type property is set
        internal bool IsSetType()
        {
            return this._type != null;
        }

    }
}