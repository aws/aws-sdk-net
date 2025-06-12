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
    /// Details for a rule in an WAF web ACL.
    /// </summary>
    public partial class AwsWafWebAclRule
    {
        private WafAction _action;
        private List<WafExcludedRule> _excludedRules = AWSConfigs.InitializeCollections ? new List<WafExcludedRule>() : null;
        private WafOverrideAction _overrideAction;
        private int? _priority;
        private string _ruleId;
        private string _type;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Specifies the action that CloudFront or WAF takes when a web request matches the conditions
        /// in the rule. 
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
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<WafExcludedRule> ExcludedRules
        {
            get { return this._excludedRules; }
            set { this._excludedRules = value; }
        }

        // Check to see if ExcludedRules property is set
        internal bool IsSetExcludedRules()
        {
            return this._excludedRules != null && (this._excludedRules.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OverrideAction. 
        /// <para>
        /// Use the <c>OverrideAction</c> to test your <c>RuleGroup</c>.
        /// </para>
        ///  
        /// <para>
        /// Any rule in a <c>RuleGroup</c> can potentially block a request. If you set the <c>OverrideAction</c>
        /// to <c>None</c>, the <c>RuleGroup</c> blocks a request if any individual rule in the
        /// <c>RuleGroup</c> matches the request and is configured to block that request.
        /// </para>
        ///  
        /// <para>
        /// However, if you first want to test the <c>RuleGroup</c>, set the <c>OverrideAction</c>
        /// to <c>Count</c>. The <c>RuleGroup</c> then overrides any block action specified by
        /// individual rules contained within the group. Instead of blocking matching requests,
        /// those requests are counted.
        /// </para>
        ///  
        /// <para>
        ///  <c>ActivatedRule</c>|<c>OverrideAction</c> applies only when updating or adding a
        /// <c>RuleGroup</c> to a web ACL. In this case you don't use <c>ActivatedRule</c> <c>Action</c>.
        /// For all other update requests, <c>ActivatedRule</c> <c>Action</c> is used instead
        /// of <c>ActivatedRule</c> <c>OverrideAction</c>.
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
        /// Specifies the order in which the rules in a web ACL are evaluated. Rules with a lower
        /// value for <c>Priority</c> are evaluated before rules with a higher value. The value
        /// must be a unique integer. If you add multiple rules to a web ACL, the values don't
        /// need to be consecutive.
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
        /// Gets and sets the property RuleId. 
        /// <para>
        /// The identifier for a rule.
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
        /// Valid values: <c>REGULAR</c> | <c>RATE_BASED</c> | <c>GROUP</c> 
        /// </para>
        ///  
        /// <para>
        /// The default is <c>REGULAR</c>.
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