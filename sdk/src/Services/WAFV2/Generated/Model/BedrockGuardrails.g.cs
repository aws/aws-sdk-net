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
    /// Specifies whether the AI security managed rule group, <c>AWSManagedRulesAISecurityRuleSet</c>,
    /// uses Amazon Bedrock Guardrails to inspect web requests, or web requests and responses.
    /// 
    /// 
    ///  
    /// <para>
    /// Specify exactly one of the following settings: <c>Disable</c>, <c>ProtectRequestOnly</c>,
    /// or <c>ProtectRequestAndResponse</c>. 
    /// </para>
    /// </summary>
    public partial class BedrockGuardrails
    {
        /// <summary>
        /// Gets and sets the property Disable. 
        /// <para>
        /// Turns off the use of Amazon Bedrock Guardrails. The rule group continues to run its
        /// own inspections. 
        /// </para>
        ///  
        /// <para>
        /// JSON specification: <c>"Disable": {}</c> 
        /// </para>
        /// </summary>
        public DisableBedrockGuardrails Disable { get; set; }

        /// <summary>
        /// Checks to see if the Disable property is set.
        /// </summary>
        internal bool IsSetDisable() => this.Disable != null;

        /// <summary>
        /// Gets and sets the property ProtectRequestAndResponse. 
        /// <para>
        /// Uses Amazon Bedrock Guardrails to inspect web requests and the responses to them.
        /// 
        /// </para>
        /// </summary>
        public BedrockGuardrailsRequestAndResponse ProtectRequestAndResponse { get; set; }

        /// <summary>
        /// Checks to see if the ProtectRequestAndResponse property is set.
        /// </summary>
        internal bool IsSetProtectRequestAndResponse() => this.ProtectRequestAndResponse != null;

        /// <summary>
        /// Gets and sets the property ProtectRequestOnly. 
        /// <para>
        /// Uses Amazon Bedrock Guardrails to inspect web requests. 
        /// </para>
        /// </summary>
        public BedrockGuardrailsRequestOnly ProtectRequestOnly { get; set; }

        /// <summary>
        /// Checks to see if the ProtectRequestOnly property is set.
        /// </summary>
        internal bool IsSetProtectRequestOnly() => this.ProtectRequestOnly != null;
    }
}
