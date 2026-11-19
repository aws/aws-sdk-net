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
    /// A single entry in the IPS section of a Next Generation policy. An entry either references
    /// an existing IPS engine rule group by ARN or embeds a rule group directly in the policy.
    /// IPS section entries don't use a priority.
    /// </summary>
    public partial class IpsRuleGroupEntry
    {
        /// <summary>
        /// Gets and sets the property InlineRuleGroup. 
        /// <para>
        /// An IPS engine rule group defined directly in the policy, instead of referenced by
        /// ARN. Provide either <c>InlineRuleGroup</c> to embed a rule group or <c>ResourceArn</c>
        /// to reference an existing rule group.
        /// </para>
        /// </summary>
        public IpsRuleGroup InlineRuleGroup { get; set; }

        /// <summary>
        /// Checks to see if the InlineRuleGroup property is set.
        /// </summary>
        internal bool IsSetInlineRuleGroup() => this.InlineRuleGroup != null;

        /// <summary>
        /// Gets and sets the property Override. 
        /// <para>
        /// The setting that allows the policy owner to change the behavior of the IPS engine
        /// rule group within this policy, such as changing a managed rule group's action from
        /// <c>DROP</c> to <c>ALERT</c>.
        /// </para>
        /// </summary>
        public IpsRuleGroupOverride Override { get; set; }

        /// <summary>
        /// Checks to see if the Override property is set.
        /// </summary>
        internal bool IsSetOverride() => this.Override != null;

        /// <summary>
        /// Gets and sets the property ResourceArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an existing IPS engine rule group to reference in
        /// this entry. Provide either <c>ResourceArn</c> to reference an existing rule group
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
