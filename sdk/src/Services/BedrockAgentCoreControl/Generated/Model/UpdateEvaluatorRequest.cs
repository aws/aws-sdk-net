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
 * Do not modify this file. This file is generated from the bedrock-agentcore-control-2023-06-05.normal.json service model.
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
    /// Container for the parameters to the UpdateEvaluator operation.
    /// Updates a custom evaluator's configuration, description, or evaluation level. Built-in
    /// evaluators cannot be updated. The evaluator must not be locked for modification.
    /// </summary>
    public partial class UpdateEvaluatorRequest : AmazonBedrockAgentCoreControlRequest
    {
        private string _clientToken;
        private string _description;
        private EvaluatorConfig _evaluatorConfig;
        private string _evaluatorId;
        private string _kmsKeyArn;
        private EvaluatorLevel _level;

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
        [AWSProperty(Min=33, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The updated description of the evaluator. 
        /// </para>
        /// </summary>
        [AWSProperty(Sensitive=true, Min=1, Max=200)]
        public string Description
        {
            get { return this._description; }
            set { this._description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this._description != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluatorConfig. 
        /// <para>
        ///  The updated configuration for the evaluator. Specify either LLM-as-a-Judge settings
        /// with instructions, rating scale, and model configuration, or code-based settings with
        /// a customer-managed Lambda function. 
        /// </para>
        /// </summary>
        public EvaluatorConfig EvaluatorConfig
        {
            get { return this._evaluatorConfig; }
            set { this._evaluatorConfig = value; }
        }

        // Check to see if EvaluatorConfig property is set
        internal bool IsSetEvaluatorConfig()
        {
            return this._evaluatorConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluatorId. 
        /// <para>
        ///  The unique identifier of the evaluator to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EvaluatorId
        {
            get { return this._evaluatorId; }
            set { this._evaluatorId = value; }
        }

        // Check to see if EvaluatorId property is set
        internal bool IsSetEvaluatorId()
        {
            return this._evaluatorId != null;
        }

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
        [AWSProperty(Min=1, Max=2048)]
        public string KmsKeyArn
        {
            get { return this._kmsKeyArn; }
            set { this._kmsKeyArn = value; }
        }

        // Check to see if KmsKeyArn property is set
        internal bool IsSetKmsKeyArn()
        {
            return this._kmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property Level. 
        /// <para>
        ///  The updated evaluation level (<c>TOOL_CALL</c>, <c>TRACE</c>, or <c>SESSION</c>)
        /// that determines the scope of evaluation. 
        /// </para>
        /// </summary>
        public EvaluatorLevel Level
        {
            get { return this._level; }
            set { this._level = value; }
        }

        // Check to see if Level property is set
        internal bool IsSetLevel()
        {
            return this._level != null;
        }

    }
}