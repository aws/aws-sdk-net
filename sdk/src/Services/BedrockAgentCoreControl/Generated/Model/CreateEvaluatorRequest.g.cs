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

namespace Amazon.BedrockAgentCoreControl.Model
{
    /// <summary>
    /// Container for the parameters to the CreateEvaluator operation. Creates a custom evaluator
    /// for agent quality assessment. Custom evaluators can use either LLM-as-a-Judge configurations
    /// with user-defined prompts, rating scales, and model settings, or code-based configurations
    /// with customer-managed Lambda functions to evaluate agent performance at tool call,
    /// trace, or session levels.
    /// </summary>
    public partial class CreateEvaluatorRequest : AmazonBedrockAgentCoreControlRequest
    {
        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If you don't specify this field, a value is randomly generated for
        /// you. If this token matches a previous request, the service ignores the request, but
        /// doesn't return an error. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 33, Max = 256)]
        public string ClientToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientToken property is set.
        /// </summary>
        internal bool IsSetClientToken() => this.ClientToken != null;

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the evaluator that explains its purpose and evaluation criteria.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive = true, Min = 1, Max = 200)]
        public string Description { get; set; }

        /// <summary>
        /// Checks to see if the Description property is set.
        /// </summary>
        internal bool IsSetDescription() => this.Description != null;

        /// <summary>
        /// Gets and sets the property EvaluatorConfig. 
        /// <para>
        ///  The configuration for the evaluator. Specify either LLM-as-a-Judge settings with
        /// instructions, rating scale, and model configuration, or code-based settings with a
        /// customer-managed Lambda function. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluatorConfig EvaluatorConfig { get; set; }

        /// <summary>
        /// Checks to see if the EvaluatorConfig property is set.
        /// </summary>
        internal bool IsSetEvaluatorConfig() => this.EvaluatorConfig != null;

        /// <summary>
        /// Gets and sets the property EvaluatorName. 
        /// <para>
        ///  The name of the evaluator. Must be unique within your account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string EvaluatorName { get; set; }

        /// <summary>
        /// Checks to see if the EvaluatorName property is set.
        /// </summary>
        internal bool IsSetEvaluatorName() => this.EvaluatorName != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of a customer managed KMS key to use for encrypting
        /// sensitive evaluator data, including instructions and rating scale. If you don't specify
        /// a KMS key, the evaluator data is encrypted with an Amazon Web Services owned key.
        /// Only symmetric encryption KMS keys are supported. For more information, see <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/devguide/evaluations-encryption.html">Encryption
        /// at rest for AgentCore Evaluations</a>. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string KmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the KmsKeyArn property is set.
        /// </summary>
        internal bool IsSetKmsKeyArn() => this.KmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property Level. 
        /// <para>
        ///  The evaluation level that determines the scope of evaluation. Valid values are <c>TOOL_CALL</c>
        /// for individual tool invocations, <c>TRACE</c> for single request-response interactions,
        /// or <c>SESSION</c> for entire conversation sessions. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public EvaluatorLevel Level { get; set; }

        /// <summary>
        /// Checks to see if the Level property is set.
        /// </summary>
        internal bool IsSetLevel() => this.Level != null;

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of tag keys and values to assign to an AgentCore Evaluator. Tags enable you
        /// to categorize your resources in different ways, for example, by purpose, owner, or
        /// environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 50)]
        public Dictionary<string, string> Tags { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the Tags property is set.
        /// </summary>
        internal bool IsSetTags() => this.Tags != null && (this.Tags.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
