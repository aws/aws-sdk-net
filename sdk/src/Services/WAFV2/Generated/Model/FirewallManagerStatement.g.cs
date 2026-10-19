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
 * Do not modify this file. This file is generated from the smithy.json service model.
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

namespace Amazon.WAFV2.Model
{
    /// <summary>
    /// The processing guidance for an Firewall Manager rule. This is like a regular rule
    /// <a>Statement</a>, but it can only contain a single rule group reference.
    /// </summary>
    public partial class FirewallManagerStatement
    {
        /// <summary>
        /// Gets and sets the property ManagedRuleGroupStatement. 
        /// <para>
        /// A statement used by Firewall Manager to run the rules that are defined in a managed
        /// rule group. This is managed by Firewall Manager for an Firewall Manager WAF policy.
        /// </para>
        /// </summary>
        public ManagedRuleGroupStatement ManagedRuleGroupStatement { get; set; }

        /// <summary>
        /// Checks to see if the ManagedRuleGroupStatement property is set.
        /// </summary>
        internal bool IsSetManagedRuleGroupStatement() => this.ManagedRuleGroupStatement != null;

        /// <summary>
        /// Gets and sets the property RuleGroupReferenceStatement. 
        /// <para>
        /// A statement used by Firewall Manager to run the rules that are defined in a rule group.
        /// This is managed by Firewall Manager for an Firewall Manager WAF policy.
        /// </para>
        /// </summary>
        public RuleGroupReferenceStatement RuleGroupReferenceStatement { get; set; }

        /// <summary>
        /// Checks to see if the RuleGroupReferenceStatement property is set.
        /// </summary>
        internal bool IsSetRuleGroupReferenceStatement() => this.RuleGroupReferenceStatement != null;
    }
}
