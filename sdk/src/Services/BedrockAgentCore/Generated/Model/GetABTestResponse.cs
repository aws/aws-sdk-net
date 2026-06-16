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
    /// This is the response object from the GetABTest operation.
    /// </summary>
    public partial class GetABTestResponse : AmazonWebServiceResponse
    {
        private string _abTestArn;
        private string _abTestId;
        private DateTime? _createdAt;
        private string _currentRunId;
        private string _description;
        private List<string> _errorDetails = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private ABTestEvaluationConfig _evaluationConfig;
        private ABTestExecutionStatus _executionStatus;
        private string _gatewayArn;
        private GatewayFilter _gatewayFilter;
        private DateTime? _maxDurationExpiresAt;
        private string _name;
        private ABTestResults _results;
        private string _roleArn;
        private DateTime? _startedAt;
        private ABTestStatus _status;
        private DateTime? _stoppedAt;
        private DateTime? _updatedAt;
        private List<Variant> _variants = AWSConfigs.InitializeCollections ? new List<Variant>() : null;

        /// <summary>
        /// Gets and sets the property AbTestArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the A/B test.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AbTestArn
        {
            get { return this._abTestArn; }
            set { this._abTestArn = value; }
        }

        // Check to see if AbTestArn property is set
        internal bool IsSetAbTestArn()
        {
            return this._abTestArn != null;
        }

        /// <summary>
        /// Gets and sets the property AbTestId. 
        /// <para>
        /// The unique identifier of the A/B test.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string AbTestId
        {
            get { return this._abTestId; }
            set { this._abTestId = value; }
        }

        // Check to see if AbTestId property is set
        internal bool IsSetAbTestId()
        {
            return this._abTestId != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The timestamp when the A/B test was created.
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
        /// Gets and sets the property CurrentRunId. 
        /// <para>
        /// The identifier of the current run of the A/B test.
        /// </para>
        /// </summary>
        public string CurrentRunId
        {
            get { return this._currentRunId; }
            set { this._currentRunId = value; }
        }

        // Check to see if CurrentRunId property is set
        internal bool IsSetCurrentRunId()
        {
            return this._currentRunId != null;
        }

        /// <summary>
        /// Gets and sets the property Description. 
        /// <para>
        /// The description of the A/B test.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        /// The error details if the A/B test encountered failures.
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
        /// Gets and sets the property EvaluationConfig. 
        /// <para>
        /// The evaluation configuration for measuring variant performance.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ABTestEvaluationConfig EvaluationConfig
        {
            get { return this._evaluationConfig; }
            set { this._evaluationConfig = value; }
        }

        // Check to see if EvaluationConfig property is set
        internal bool IsSetEvaluationConfig()
        {
            return this._evaluationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionStatus. 
        /// <para>
        /// The execution status indicating whether the A/B test is currently running.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ABTestExecutionStatus ExecutionStatus
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
        /// Gets and sets the property GatewayArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the gateway used for traffic splitting.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string GatewayArn
        {
            get { return this._gatewayArn; }
            set { this._gatewayArn = value; }
        }

        // Check to see if GatewayArn property is set
        internal bool IsSetGatewayArn()
        {
            return this._gatewayArn != null;
        }

        /// <summary>
        /// Gets and sets the property GatewayFilter. 
        /// <para>
        /// The gateway filter restricting which target paths are included.
        /// </para>
        /// </summary>
        public GatewayFilter GatewayFilter
        {
            get { return this._gatewayFilter; }
            set { this._gatewayFilter = value; }
        }

        // Check to see if GatewayFilter property is set
        internal bool IsSetGatewayFilter()
        {
            return this._gatewayFilter != null;
        }

        /// <summary>
        /// Gets and sets the property MaxDurationExpiresAt. 
        /// <para>
        /// The timestamp when the A/B test will automatically expire.
        /// </para>
        /// </summary>
        public DateTime? MaxDurationExpiresAt
        {
            get { return this._maxDurationExpiresAt; }
            set { this._maxDurationExpiresAt = value; }
        }

        // Check to see if MaxDurationExpiresAt property is set
        internal bool IsSetMaxDurationExpiresAt()
        {
            return this._maxDurationExpiresAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the A/B test.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string Name
        {
            get { return this._name; }
            set { this._name = value; }
        }

        // Check to see if Name property is set
        internal bool IsSetName()
        {
            return this._name != null;
        }

        /// <summary>
        /// Gets and sets the property Results. 
        /// <para>
        /// The statistical results of the A/B test, including per-evaluator metrics and significance
        /// analysis.
        /// </para>
        /// </summary>
        public ABTestResults Results
        {
            get { return this._results; }
            set { this._results = value; }
        }

        // Check to see if Results property is set
        internal bool IsSetResults()
        {
            return this._results != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The IAM role ARN used by the A/B test.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property StartedAt. 
        /// <para>
        /// The timestamp when the A/B test was started.
        /// </para>
        /// </summary>
        public DateTime? StartedAt
        {
            get { return this._startedAt; }
            set { this._startedAt = value; }
        }

        // Check to see if StartedAt property is set
        internal bool IsSetStartedAt()
        {
            return this._startedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the A/B test.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public ABTestStatus Status
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
        /// Gets and sets the property StoppedAt. 
        /// <para>
        /// The timestamp when the A/B test was stopped.
        /// </para>
        /// </summary>
        public DateTime? StoppedAt
        {
            get { return this._stoppedAt; }
            set { this._stoppedAt = value; }
        }

        // Check to see if StoppedAt property is set
        internal bool IsSetStoppedAt()
        {
            return this._stoppedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property UpdatedAt. 
        /// <para>
        /// The timestamp when the A/B test was last updated.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property Variants. 
        /// <para>
        /// The list of variants in the A/B test.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Required=true, Min=2, Max=2)]
        public List<Variant> Variants
        {
            get { return this._variants; }
            set { this._variants = value; }
        }

        // Check to see if Variants property is set
        internal bool IsSetVariants()
        {
            return this._variants != null && (this._variants.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}