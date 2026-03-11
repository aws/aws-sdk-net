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
    /// Container for the parameters to the UpdateOnlineEvaluationConfig operation.
    /// Updates an online evaluation configuration's settings, including rules, data sources,
    /// evaluators, and execution status. Changes take effect immediately for ongoing evaluations.
    /// </summary>
    public partial class UpdateOnlineEvaluationConfigRequest : AmazonBedrockAgentCoreControlRequest
    {
        private string _clientToken;
        private DataSourceConfig _dataSourceConfig;
        private string _description;
        private string _evaluationExecutionRoleArn;
        private List<EvaluatorReference> _evaluators = AWSConfigs.InitializeCollections ? new List<EvaluatorReference>() : null;
        private OnlineEvaluationExecutionStatus _executionStatus;
        private string _onlineEvaluationConfigId;
        private Rule _rule;

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
        ///  The updated data source configuration specifying CloudWatch log groups and service
        /// names to monitor. 
        /// </para>
        /// </summary>
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
        ///  The updated description of the online evaluation configuration. 
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
        /// Gets and sets the property EvaluationExecutionRoleArn. 
        /// <para>
        ///  The updated Amazon Resource Name (ARN) of the IAM role used for evaluation execution.
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        ///  The updated list of evaluators to apply during online evaluation. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
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
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        ///  The updated execution status to enable or disable the online evaluation. 
        /// </para>
        /// </summary>
        public OnlineEvaluationExecutionStatus ExecutionStatus
        {
            get { return this._executionStatus; }
            set { this._executionStatus = value; }
        }

        // Check to see if ExecutionStatus property is set
        internal bool IsSetExecutionStatus()
        {
            return this._executionStatus != null;
        }

        /// <summary>
        /// Gets and sets the property OnlineEvaluationConfigId. 
        /// <para>
        ///  The unique identifier of the online evaluation configuration to update. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string OnlineEvaluationConfigId
        {
            get { return this._onlineEvaluationConfigId; }
            set { this._onlineEvaluationConfigId = value; }
        }

        // Check to see if OnlineEvaluationConfigId property is set
        internal bool IsSetOnlineEvaluationConfigId()
        {
            return this._onlineEvaluationConfigId != null;
        }

        /// <summary>
        /// Gets and sets the property Rule. 
        /// <para>
        ///  The updated evaluation rule containing sampling configuration, filters, and session
        /// settings. 
        /// </para>
        /// </summary>
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

    }
}