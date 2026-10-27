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
    /// A rule group that's defined for an Firewall Manager WAF policy.
    /// </summary>
    public partial class FirewallManagerRuleGroup
    {
        /// <summary>
        /// Gets and sets the property FirewallManagerStatement. 
        /// <para>
        /// The processing guidance for an Firewall Manager rule. This is like a regular rule
        /// <a>Statement</a>, but it can only contain a rule group reference.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public FirewallManagerStatement FirewallManagerStatement { get; set; }

        /// <summary>
        /// Checks to see if the FirewallManagerStatement property is set.
        /// </summary>
        internal bool IsSetFirewallManagerStatement() => this.FirewallManagerStatement != null;

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the rule group. You cannot change the name of a rule group after you create
        /// it.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 128)]
        public string Name { get; set; }

        /// <summary>
        /// Checks to see if the Name property is set.
        /// </summary>
        internal bool IsSetName() => this.Name != null;

        /// <summary>
        /// Gets and sets the property OverrideAction. 
        /// <para>
        /// The action to use in the place of the action that results from the rule group evaluation.
        /// Set the override action to none to leave the result of the rule group alone. Set it
        /// to count to override the result to count only. 
        /// </para>
        ///  
        /// <para>
        /// You can only use this for rule statements that reference a rule group, like <c>RuleGroupReferenceStatement</c>
        /// and <c>ManagedRuleGroupStatement</c>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// This option is usually set to none. It does not affect how the rules in the rule group
        /// are evaluated. If you want the rules in the rule group to only count matches, do not
        /// use this and instead use the rule action override option, with <c>Count</c> action,
        /// in your rule group reference statement settings. 
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Required = true)]
        public OverrideAction OverrideAction { get; set; }

        /// <summary>
        /// Checks to see if the OverrideAction property is set.
        /// </summary>
        internal bool IsSetOverrideAction() => this.OverrideAction != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// If you define more than one rule group in the first or last Firewall Manager rule
        /// groups, WAF evaluates each request against the rule groups in order, starting from
        /// the lowest priority setting. The priorities don't need to be consecutive, but they
        /// must all be different.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 0)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property VisibilityConfig. 
        /// <para>
        /// Defines and enables Amazon CloudWatch metrics and web request sample collection. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public VisibilityConfig VisibilityConfig { get; set; }

        /// <summary>
        /// Checks to see if the VisibilityConfig property is set.
        /// </summary>
        internal bool IsSetVisibilityConfig() => this.VisibilityConfig != null;
    }
}
