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
    /// A combination of <c>ByteMatchSet</c>, <c>IPSet</c>, and/or <c>SqlInjectionMatchSet</c>
    /// objects that identify the web requests that you want to allow, block, or count.
    /// </summary>
    public partial class AwsWafRegionalWebAclRulesListDetails
    {
        private AwsWafRegionalWebAclRulesListActionDetails _action;
        private AwsWafRegionalWebAclRulesListOverrideActionDetails _overrideAction;
        private int? _priority;
        private string _ruleId;
        private string _type;

        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// The action that WAF takes when a web request matches all conditions in the rule, such
        /// as allow, block, or count the request. 
        /// </para>
        /// </summary>
        public AwsWafRegionalWebAclRulesListActionDetails Action
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
        /// Gets and sets the property OverrideAction. 
        /// <para>
        /// Overrides the rule evaluation result in the rule group. 
        /// </para>
        /// </summary>
        public AwsWafRegionalWebAclRulesListOverrideActionDetails OverrideAction
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
        /// The order in which WAF evaluates the rules in a web ACL. 
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
        /// The ID of an WAF Regional rule to associate with a web ACL. 
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
        /// For actions that are associated with a rule, the action that WAF takes when a web
        /// request matches all conditions in a rule. 
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