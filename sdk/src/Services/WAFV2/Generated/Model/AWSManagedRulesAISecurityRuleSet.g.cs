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
    /// Configures the use of the AI security managed rule group, <c>AWSManagedRulesAISecurityRuleSet</c>.
    /// This configuration is used in <c>ManagedRuleGroupConfig</c>. 
    /// 
    ///  
    /// <para>
    /// The rule group always runs its own inspections. The configuration that you provide
    /// here determines whether the rule group also uses Amazon Bedrock Guardrails to inspect
    /// web requests, or web requests and responses. 
    /// </para>
    ///  
    /// <para>
    /// Use of this rule group is not supported in Firewall Manager. 
    /// </para>
    /// </summary>
    public partial class AWSManagedRulesAISecurityRuleSet
    {
        /// <summary>
        /// Gets and sets the property BedrockGuardrails. 
        /// <para>
        /// Specifies whether and how the rule group uses Amazon Bedrock Guardrails. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public BedrockGuardrails BedrockGuardrails { get; set; }

        /// <summary>
        /// Checks to see if the BedrockGuardrails property is set.
        /// </summary>
        internal bool IsSetBedrockGuardrails() => this.BedrockGuardrails != null;
    }
}
