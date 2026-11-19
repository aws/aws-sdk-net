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

namespace Amazon.NetworkFirewall.Model
{
    /// <summary>
    /// A single entry in the firewall section of a Next Generation policy. An entry either
    /// references an existing firewall engine rule group by ARN or embeds a rule group directly
    /// in the policy, and it carries the priority that sets the rule group's evaluation order
    /// within the firewall section.
    /// </summary>
    public partial class FirewallRuleGroupEntry
    {
        /// <summary>
        /// Gets and sets the property InlineRuleGroup. 
        /// <para>
        /// A firewall engine rule group defined directly in the policy, instead of referenced
        /// by ARN. Provide either <c>InlineRuleGroup</c> to embed a rule group or <c>ResourceArn</c>
        /// to reference an existing rule group. An embedded rule group can't use a domain list
        /// rules source; to filter on a domain list, reference a standalone rule group by ARN
        /// instead.
        /// </para>
        /// </summary>
        public FirewallRuleGroup InlineRuleGroup { get; set; }

        /// <summary>
        /// Checks to see if the InlineRuleGroup property is set.
        /// </summary>
        internal bool IsSetInlineRuleGroup() => this.InlineRuleGroup != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// The priority of the rule group entry within the firewall section. Network Firewall
        /// evaluates the firewall section's entries in order of increasing priority value. Each
        /// entry in the firewall section must have a unique priority.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 65535)]
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an existing firewall engine rule group to reference
        /// in this entry. Provide either <c>ResourceArn</c> to reference an existing rule group
        /// or <c>InlineRuleGroup</c> to embed a rule group in the policy.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ResourceArn { get; set; }

        /// <summary>
        /// Checks to see if the ResourceArn property is set.
        /// </summary>
        internal bool IsSetResourceArn() => this.ResourceArn != null;
    }
}
