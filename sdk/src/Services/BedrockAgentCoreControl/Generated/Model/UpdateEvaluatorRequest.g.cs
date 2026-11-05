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
    /// Container for the parameters to the UpdateEvaluator operation. Updates a custom evaluator's
    /// configuration, description, or evaluation level. Built-in evaluators cannot be updated.
    /// The evaluator must not be locked for modification.
    /// </summary>
    public partial class UpdateEvaluatorRequest : AmazonBedrockAgentCoreControlRequest
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
        ///  The updated description of the evaluator. 
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
        ///  The updated configuration for the evaluator. Specify either LLM-as-a-Judge settings
        /// with instructions, rating scale, and model configuration, or code-based settings with
        /// a customer-managed Lambda function. 
        /// </para>
        /// </summary>
        public EvaluatorConfig EvaluatorConfig { get; set; }

        /// <summary>
        /// Checks to see if the EvaluatorConfig property is set.
        /// </summary>
        internal bool IsSetEvaluatorConfig() => this.EvaluatorConfig != null;

        /// <summary>
        /// Gets and sets the property EvaluatorId. 
        /// <para>
        ///  The unique identifier of the evaluator to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 111)]
        public string EvaluatorId { get; set; }

        /// <summary>
        /// Checks to see if the EvaluatorId property is set.
        /// </summary>
        internal bool IsSetEvaluatorId() => this.EvaluatorId != null;

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of a customer managed KMS key to use for encrypting
        /// sensitive evaluator data. Specify a new key ARN to rotate the encryption key, or specify
        /// a key ARN to add encryption to an evaluator that was previously created without one.
        /// When you rotate to a new key, the service decrypts the existing data with the old
        /// key and re-encrypts it with the new key. Only symmetric encryption KMS keys are supported.
        /// For more information, see <a href="https://docs.aws.amazon.com/bedrock-agentcore/latest/devguide/evaluations-encryption.html">Encryption
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
        ///  The updated evaluation level (<c>TOOL_CALL</c>, <c>TRACE</c>, or <c>SESSION</c>)
        /// that determines the scope of evaluation. 
        /// </para>
        /// </summary>
        public EvaluatorLevel Level { get; set; }

        /// <summary>
        /// Checks to see if the Level property is set.
        /// </summary>
        internal bool IsSetLevel() => this.Level != null;
    }
}
