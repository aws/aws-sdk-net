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
    /// The processing guidance for an Firewall Manager rule. This is like a regular rule
    /// <a>Statement</a>, but it can only contain a single rule group reference.
    /// </summary>
    public partial class FirewallManagerStatement
    {
        private ManagedRuleGroupStatement _managedRuleGroupStatement;
        private RuleGroupReferenceStatement _ruleGroupReferenceStatement;

        /// <summary>
        /// Gets and sets the property ManagedRuleGroupStatement. 
        /// <para>
        /// A statement used by Firewall Manager to run the rules that are defined in a managed
        /// rule group. This is managed by Firewall Manager for an Firewall Manager WAF policy.
        /// </para>
        /// </summary>
        public ManagedRuleGroupStatement ManagedRuleGroupStatement
        {
            get { return this._managedRuleGroupStatement; }
            set { this._managedRuleGroupStatement = value; }
        }

        // Check to see if ManagedRuleGroupStatement property is set
        internal bool IsSetManagedRuleGroupStatement()
        {
            return this._managedRuleGroupStatement != null;
        }

        /// <summary>
        /// Gets and sets the property RuleGroupReferenceStatement. 
        /// <para>
        /// A statement used by Firewall Manager to run the rules that are defined in a rule group.
        /// This is managed by Firewall Manager for an Firewall Manager WAF policy.
        /// </para>
        /// </summary>
        public RuleGroupReferenceStatement RuleGroupReferenceStatement
        {
            get { return this._ruleGroupReferenceStatement; }
            set { this._ruleGroupReferenceStatement = value; }
        }

        // Check to see if RuleGroupReferenceStatement property is set
        internal bool IsSetRuleGroupReferenceStatement()
        {
            return this._ruleGroupReferenceStatement != null;
        }

    }
}