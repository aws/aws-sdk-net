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

namespace Amazon.SecurityHub.Model
{
    /// <summary>
    /// Provides information about the rules attached to the rule group. These rules identify
    /// the web requests that you want to allow, block, or count.
    /// </summary>
    public partial class AwsWafRuleGroupRulesDetails
    {
        /// <summary>
        /// Gets and sets the property Action. 
        /// <para>
        /// Provides information about what action WAF should take on a web request when it matches
        /// the criteria defined in the rule. 
        /// </para>
        /// </summary>
        public AwsWafRuleGroupRulesActionDetails Action { get; set; }

        /// <summary>
        /// Checks to see if the Action property is set.
        /// </summary>
        internal bool IsSetAction() => this.Action != null;

        /// <summary>
        /// Gets and sets the property Priority. 
        /// <para>
        /// If you define more than one rule in a web ACL, WAF evaluates each request against
        /// the rules in order based on the value of <c>Priority</c>.
        /// </para>
        /// </summary>
        public int? Priority { get; set; }

        /// <summary>
        /// Checks to see if the Priority property is set.
        /// </summary>
        internal bool IsSetPriority() => this.Priority.HasValue;

        /// <summary>
        /// Gets and sets the property RuleId. 
        /// <para>
        /// The rule ID for a rule. 
        /// </para>
        /// </summary>
        public string RuleId { get; set; }

        /// <summary>
        /// Checks to see if the RuleId property is set.
        /// </summary>
        internal bool IsSetRuleId() => this.RuleId != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of rule. 
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
