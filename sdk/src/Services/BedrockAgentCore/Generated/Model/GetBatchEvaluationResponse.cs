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
 * Do not modify this file. This file is generated from the bedrock-agentcore-2024-02-28.normal.json service model.
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
namespace Amazon.BedrockAgentCore.Model
{
    /// <summary>
    /// This is the response object from the GetBatchEvaluation operation.
    /// </summary>
    public partial class GetBatchEvaluationResponse : AmazonWebServiceResponse
    {
        private string _batchEvaluationArn;
        private string _batchEvaluationId;
        private string _batchEvaluationName;
        private DateTime? _createdAt;
        private DataSourceConfig _dataSourceConfig;
        private string _description;
        private List<string> _errorDetails = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private EvaluationJobResults _evaluationResults;
        private List<Evaluator> _evaluators = AWSConfigs.InitializeCollections ? new List<Evaluator>() : null;
        private ExecutionSummaryClusteringResultContent _executionSummaryResult;
        private FailureAnalysisResultContent _failureAnalysisResult;
        private List<Insight> _insights = AWSConfigs.InitializeCollections ? new List<Insight>() : null;
        private string _kmsKeyArn;
        private OutputConfig _outputConfig;
        private BatchEvaluationStatus _status;
        private DateTime? _updatedAt;
        private UserIntentClusteringResultContent _userIntentResult;

        /// <summary>
        /// Gets and sets the property BatchEvaluationArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the batch evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BatchEvaluationArn
        {
            get { return this._batchEvaluationArn; }
            set { this._batchEvaluationArn = value; }
        }

        // Check to see if BatchEvaluationArn property is set
        internal bool IsSetBatchEvaluationArn()
        {
            return this._batchEvaluationArn != null;
        }

        /// <summary>
        /// Gets and sets the property BatchEvaluationId. 
        /// <para>
        /// The unique identifier of the batch evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BatchEvaluationId
        {
            get { return this._batchEvaluationId; }
            set { this._batchEvaluationId = value; }
        }

        // Check to see if BatchEvaluationId property is set
        internal bool IsSetBatchEvaluationId()
        {
            return this._batchEvaluationId != null;
        }

        /// <summary>
        /// Gets and sets the property BatchEvaluationName. 
        /// <para>
        /// The name of the batch evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string BatchEvaluationName
        {
            get { return this._batchEvaluationName; }
            set { this._batchEvaluationName = value; }
        }

        // Check to see if BatchEvaluationName property is set
        internal bool IsSetBatchEvaluationName()
        {
            return this._batchEvaluationName != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the batch evaluation was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataSourceConfig. 
        /// <para>
        /// The data source configuration specifying where agent traces are pulled from.
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
        /// The description of the batch evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
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
        /// Gets and sets the property ErrorDetails. 
        /// <para>
        /// The error details if the batch evaluation encountered failures.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<string> ErrorDetails
        {
            get { return this._errorDetails; }
            set { this._errorDetails = value; }
        }

        // Check to see if ErrorDetails property is set
        internal bool IsSetErrorDetails()
        {
            return this._errorDetails != null && (this._errorDetails.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property EvaluationResults. 
        /// <para>
        /// The aggregated evaluation results, including session completion counts and evaluator
        /// score summaries.
        /// </para>
        /// </summary>
        public EvaluationJobResults EvaluationResults
        {
            get { return this._evaluationResults; }
            set { this._evaluationResults = value; }
        }

        // Check to see if EvaluationResults property is set
        internal bool IsSetEvaluationResults()
        {
            return this._evaluationResults != null;
        }

        /// <summary>
        /// Gets and sets the property Evaluators. 
        /// <para>
        /// The list of evaluators applied during the batch evaluation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<Evaluator> Evaluators
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
        /// Gets and sets the property ExecutionSummaryResult.
        /// </summary>
        public ExecutionSummaryClusteringResultContent ExecutionSummaryResult
        {
            get { return this._executionSummaryResult; }
            set { this._executionSummaryResult = value; }
        }

        // Check to see if ExecutionSummaryResult property is set
        internal bool IsSetExecutionSummaryResult()
        {
            return this._executionSummaryResult != null;
        }

        /// <summary>
        /// Gets and sets the property FailureAnalysisResult.
        /// </summary>
        public FailureAnalysisResultContent FailureAnalysisResult
        {
            get { return this._failureAnalysisResult; }
            set { this._failureAnalysisResult = value; }
        }

        // Check to see if FailureAnalysisResult property is set
        internal bool IsSetFailureAnalysisResult()
        {
            return this._failureAnalysisResult != null;
        }

        /// <summary>
        /// Gets and sets the property Insights. 
        /// <para>
        /// The list of insight analyses applied during the batch evaluation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=10)]
        public List<Insight> Insights
        {
            get { return this._insights; }
            set { this._insights = value; }
        }

        // Check to see if Insights property is set
        internal bool IsSetInsights()
        {
            return this._insights != null && (this._insights.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property KmsKeyArn. 
        /// <para>
        /// The ARN of the KMS key used to encrypt evaluation data.
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
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The output configuration specifying where evaluation results are written.
        /// </para>
        /// </summary>
        public OutputConfig OutputConfig
        {
            get { return this._outputConfig; }
            set { this._outputConfig = value; }
        }

        // Check to see if OutputConfig property is set
        internal bool IsSetOutputConfig()
        {
            return this._outputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the batch evaluation.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public BatchEvaluationStatus Status
        {
            get { return this._status; }
            set { this._status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this._status != null;
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the batch evaluation was last updated.
        /// </para>
        /// </summary>
        public DateTime? UpdatedAt
        {
            get { return this._updatedAt; }
            set { this._updatedAt = value; }
        }

        // Check to see if UpdatedAt property is set
        internal bool IsSetUpdatedAt()
        {
            return this._updatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UserIntentResult.
        /// </summary>
        public UserIntentClusteringResultContent UserIntentResult
        {
            get { return this._userIntentResult; }
            set { this._userIntentResult = value; }
        }

        // Check to see if UserIntentResult property is set
        internal bool IsSetUserIntentResult()
        {
            return this._userIntentResult != null;
        }

    }
}