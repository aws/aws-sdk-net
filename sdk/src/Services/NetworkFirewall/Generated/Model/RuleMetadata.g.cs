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
    /// Metadata for a single firewall engine rule. Use it to disable a rule without removing
    /// it and to attach a description. When you describe a rule group in <c>RULES_STRING</c>
    /// format, Network Firewall renders a disabled rule and its description as <c>#</c> comment
    /// lines above the rule.
    /// </summary>
    public partial class RuleMetadata
    {
        /// <summary>
        /// Gets and sets the property RuleDescription. 
        /// <para>
        /// A description of the rule, up to 512 characters. The description can span multiple
        /// lines. A description line can't itself look like a firewall rule; to disable a rule,
        /// set <c>RuleEnabled</c> to <c>FALSE</c> instead.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 512)]
        public string RuleDescription { get; set; }

        /// <summary>
        /// Checks to see if the RuleDescription property is set.
        /// </summary>
        internal bool IsSetRuleDescription() => this.RuleDescription != null;

        /// <summary>
        /// Gets and sets the property RuleEnabled. 
        /// <para>
        /// Specifies whether the rule is active. The default is <c>TRUE</c>. When you set this
        /// to <c>FALSE</c>, Network Firewall keeps the rule in the rule group but doesn't evaluate
        /// it against traffic and doesn't count it toward the rule group's consumed capacity.
        /// </para>
        /// </summary>
        public bool? RuleEnabled { get; set; }

        /// <summary>
        /// Checks to see if the RuleEnabled property is set.
        /// </summary>
        internal bool IsSetRuleEnabled() => this.RuleEnabled.HasValue;
    }
}
