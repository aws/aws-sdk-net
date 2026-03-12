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
    /// Container for the parameters to the CreateEvaluator operation.
    /// Creates a custom evaluator for agent quality assessment. Custom evaluators use LLM-as-a-Judge
    /// configurations with user-defined prompts, rating scales, and model settings to evaluate
    /// agent performance at tool call, trace, or session levels.
    /// </summary>
    public partial class CreateEvaluatorRequest : AmazonBedrockAgentCoreControlRequest
    {
        private string _clientToken;
        private string _description;
        private EvaluatorConfig _evaluatorConfig;
        private string _evaluatorName;
        private EvaluatorLevel _level;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

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
        ///  The description of the evaluator that explains its purpose and evaluation criteria.
        /// 
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
        ///  The configuration for the evaluator, including LLM-as-a-Judge settings with instructions,
        /// rating scale, and model configuration. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property EvaluatorName. 
        /// <para>
        ///  The name of the evaluator. Must be unique within your account. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string EvaluatorName
        {
            get { return this._evaluatorName; }
            set { this._evaluatorName = value; }
        }

        // Check to see if EvaluatorName property is set
        internal bool IsSetEvaluatorName()
        {
            return this._evaluatorName != null;
        }

        /// <summary>
        /// Gets and sets the property Level. 
        /// <para>
        ///  The evaluation level that determines the scope of evaluation. Valid values are <c>TOOL_CALL</c>
        /// for individual tool invocations, <c>TRACE</c> for single request-response interactions,
        /// or <c>SESSION</c> for entire conversation sessions. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of tag keys and values to assign to an AgentCore Evaluator. Tags enable you
        /// to categorize your resources in different ways, for example, by purpose, owner, or
        /// environment.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public Dictionary<string, string> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}