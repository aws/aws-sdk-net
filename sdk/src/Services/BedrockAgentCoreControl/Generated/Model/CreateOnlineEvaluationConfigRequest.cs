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
    /// Container for the parameters to the CreateOnlineEvaluationConfig operation.
    /// Creates an online evaluation configuration for continuous monitoring of agent performance.
    /// Online evaluation automatically samples live traffic from CloudWatch logs at specified
    /// rates and applies evaluators to assess agent quality in production.
    /// </summary>
    public partial class CreateOnlineEvaluationConfigRequest : AmazonBedrockAgentCoreControlRequest
    {
        private string _clientToken;
        private DataSourceConfig _dataSourceConfig;
        private string _description;
        private bool? _enableOnCreate;
        private string _evaluationExecutionRoleArn;
        private List<EvaluatorReference> _evaluators = AWSConfigs.InitializeCollections ? new List<EvaluatorReference>() : null;
        private string _onlineEvaluationConfigName;
        private Rule _rule;
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
        /// Gets and sets the property DataSourceConfig. 
        /// <para>
        ///  The data source configuration that specifies CloudWatch log groups and service names
        /// to monitor for agent traces. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DataSourceConfig DataSourceConfig
        {
            get { return this._dataSourceConfig; }
            set { this._dataSourceConfig = value; }
        }

        // Check to see if DataSourceConfig property is set
        internal bool IsSetDataSourceConfig()
        {
            return this._dataSourceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        ///  The description of the online evaluation configuration that explains its monitoring
        /// purpose and scope. 
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
        /// Gets and sets the property EnableOnCreate. 
        /// <para>
        ///  Whether to enable the online evaluation configuration immediately upon creation.
        /// If true, evaluation begins automatically. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public bool? EnableOnCreate
        {
            get { return this._enableOnCreate; }
            set { this._enableOnCreate = value; }
        }

        // Check to see if EnableOnCreate property is set
        internal bool IsSetEnableOnCreate()
        {
            return this._enableOnCreate.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvaluationExecutionRoleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of the IAM role that grants permissions to read from
        /// CloudWatch logs, write evaluation results, and invoke Amazon Bedrock models for evaluation.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string EvaluationExecutionRoleArn
        {
            get { return this._evaluationExecutionRoleArn; }
            set { this._evaluationExecutionRoleArn = value; }
        }

        // Check to see if EvaluationExecutionRoleArn property is set
        internal bool IsSetEvaluationExecutionRoleArn()
        {
            return this._evaluationExecutionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property Evaluators. 
        /// <para>
        ///  The list of evaluators to apply during online evaluation. Can include both built-in
        /// evaluators and custom evaluators created with <c>CreateEvaluator</c>. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=10)]
        public List<EvaluatorReference> Evaluators
        {
            get { return this._evaluators; }
            set { this._evaluators = value; }
        }

        // Check to see if Evaluators property is set
        internal bool IsSetEvaluators()
        {
            return this._evaluators != null && (this._evaluators.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OnlineEvaluationConfigName. 
        /// <para>
        ///  The name of the online evaluation configuration. Must be unique within your account.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OnlineEvaluationConfigName
        {
            get { return this._onlineEvaluationConfigName; }
            set { this._onlineEvaluationConfigName = value; }
        }

        // Check to see if OnlineEvaluationConfigName property is set
        internal bool IsSetOnlineEvaluationConfigName()
        {
            return this._onlineEvaluationConfigName != null;
        }

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        ///  The evaluation rule that defines sampling configuration, filters, and session detection
        /// settings for the online evaluation. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public Rule Rule
        {
            get { return this._rule; }
            set { this._rule = value; }
        }

        // Check to see if Rule property is set
        internal bool IsSetRule()
        {
            return this._rule != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A map of tag keys and values to assign to an AgentCore Online Evaluation Config. Tags
        /// enable you to categorize your resources in different ways, for example, by purpose,
        /// owner, or environment.
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