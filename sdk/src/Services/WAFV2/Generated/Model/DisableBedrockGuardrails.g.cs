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
    /// Turns off the use of Amazon Bedrock Guardrails in the AI security managed rule group.
    /// The rule group continues to run its own inspections. 
    /// 
    ///  
    /// <para>
    /// This is used in the <c>BedrockGuardrails</c> setting of <c>AWSManagedRulesAISecurityRuleSet</c>.
    /// 
    /// </para>
    ///  
    /// <para>
    /// JSON specification: <c>"Disable": {}</c> 
    /// </para>
    /// </summary>
    public partial class DisableBedrockGuardrails
    {
    }
}
