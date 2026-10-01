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
    /// Details about an Network Firewall rule group. Rule groups are used to inspect and
    /// control network traffic. Stateless rule groups apply to individual packets. Stateful
    /// rule groups apply to packets in the context of their traffic flow.
    /// 
    ///  
    /// <para>
    /// Rule groups are referenced in firewall policies. 
    /// </para>
    /// </summary>
    public partial class AwsNetworkFirewallRuleGroupDetails
    {
        /// <summary>
        /// Gets and sets the property Capacity. 
        /// <para>
        /// The maximum number of operating resources that this rule group can use.
        /// </para>
        /// </summary>
        public int? Capacity { get; set; }

        /// <summary>
        /// Checks to see if the Capacity property is set.
        /// </summary>
        internal bool IsSetCapacity() => this.Capacity.HasValue;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// A description of the rule group.
        /// </para>
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property RuleGroup. 
        /// <para>
        /// Details about the rule group.
        /// </para>
        /// </summary>
        public RuleGroupDetails RuleGroup { get; set; }

        /// <summary>
        /// Checks to see if the RuleGroup property is set.
        /// </summary>
        internal bool IsSetRuleGroup() => this.RuleGroup != null;

        /// <summary>
        /// Gets and sets the property RuleGroupArn. 
        /// <para>
        /// The ARN of the rule group.
        /// </para>
        /// </summary>
        public string RuleGroupArn { get; set; }

        /// <summary>
        /// Checks to see if the RuleGroupArn property is set.
        /// </summary>
        internal bool IsSetRuleGroupArn() => this.RuleGroupArn != null;

        /// <summary>
        /// Gets and sets the property RuleGroupId. 
        /// <para>
        /// The identifier of the rule group.
        /// </para>
        /// </summary>
        public string RuleGroupId { get; set; }

        /// <summary>
        /// Checks to see if the RuleGroupId property is set.
        /// </summary>
        internal bool IsSetRuleGroupId() => this.RuleGroupId != null;

        /// <summary>
        /// Gets and sets the property RuleGroupName. 
        /// <para>
        /// The descriptive name of the rule group.
        /// </para>
        /// </summary>
        public string RuleGroupName { get; set; }

        /// <summary>
        /// Checks to see if the RuleGroupName property is set.
        /// </summary>
        internal bool IsSetRuleGroupName() => this.RuleGroupName != null;

        /// <summary>
        /// Gets and sets the property Type. 
        /// <para>
        /// The type of rule group. A rule group can be stateful or stateless.
        /// </para>
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// Checks to see if the Type property is set.
        /// </summary>
        internal bool IsSetType() => this.Type != null;
    }
}
