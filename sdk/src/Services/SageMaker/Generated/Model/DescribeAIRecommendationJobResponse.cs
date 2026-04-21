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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeAIRecommendationJob operation.
    /// </summary>
    public partial class DescribeAIRecommendationJobResponse : AmazonWebServiceResponse
    {
        private string _aiRecommendationJobArn;
        private string _aiRecommendationJobName;
        private AIRecommendationJobStatus _aiRecommendationJobStatus;
        private string _aiWorkloadConfigIdentifier;
        private AIRecommendationComputeSpec _computeSpec;
        private DateTime? _creationTime;
        private DateTime? _endTime;
        private string _failureReason;
        private AIRecommendationInferenceSpecification _inferenceSpecification;
        private AIModelSource _modelSource;
        private bool? _optimizeModel;
        private AIRecommendationOutputResult _outputConfig;
        private AIRecommendationPerformanceTarget _performanceTarget;
        private List<AIRecommendation> _recommendations = AWSConfigs.InitializeCollections ? new List<AIRecommendation>() : null;
        private string _roleArn;
        private DateTime? _startTime;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;

        /// <summary>
        /// Gets and sets the property AIRecommendationJobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the AI recommendation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string AIRecommendationJobArn
        {
            get { return this._aiRecommendationJobArn; }
            set { this._aiRecommendationJobArn = value; }
        }

        // Check to see if AIRecommendationJobArn property is set
        internal bool IsSetAIRecommendationJobArn()
        {
            return this._aiRecommendationJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property AIRecommendationJobName. 
        /// <para>
        /// The name of the AI recommendation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string AIRecommendationJobName
        {
            get { return this._aiRecommendationJobName; }
            set { this._aiRecommendationJobName = value; }
        }

        // Check to see if AIRecommendationJobName property is set
        internal bool IsSetAIRecommendationJobName()
        {
            return this._aiRecommendationJobName != null;
        }

        /// <summary>
        /// Gets and sets the property AIRecommendationJobStatus. 
        /// <para>
        /// The status of the AI recommendation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AIRecommendationJobStatus AIRecommendationJobStatus
        {
            get { return this._aiRecommendationJobStatus; }
            set { this._aiRecommendationJobStatus = value; }
        }

        // Check to see if AIRecommendationJobStatus property is set
        internal bool IsSetAIRecommendationJobStatus()
        {
            return this._aiRecommendationJobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AIWorkloadConfigIdentifier. 
        /// <para>
        /// The name or Amazon Resource Name (ARN) of the AI workload configuration used for this
        /// recommendation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AIWorkloadConfigIdentifier
        {
            get { return this._aiWorkloadConfigIdentifier; }
            set { this._aiWorkloadConfigIdentifier = value; }
        }

        // Check to see if AIWorkloadConfigIdentifier property is set
        internal bool IsSetAIWorkloadConfigIdentifier()
        {
            return this._aiWorkloadConfigIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ComputeSpec. 
        /// <para>
        /// The compute resource specification for the recommendation job.
        /// </para>
        /// </summary>
        public AIRecommendationComputeSpec ComputeSpec
        {
            get { return this._computeSpec; }
            set { this._computeSpec = value; }
        }

        // Check to see if ComputeSpec property is set
        internal bool IsSetComputeSpec()
        {
            return this._computeSpec != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that indicates when the recommendation job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? CreationTime
        {
            get { return this._creationTime; }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// A timestamp that indicates when the recommendation job completed.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the recommendation job failed, the reason it failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FailureReason
        {
            get { return this._failureReason; }
            set { this._failureReason = value; }
        }

        // Check to see if FailureReason property is set
        internal bool IsSetFailureReason()
        {
            return this._failureReason != null;
        }

        /// <summary>
        /// Gets and sets the property InferenceSpecification. 
        /// <para>
        /// The inference framework configuration.
        /// </para>
        /// </summary>
        public AIRecommendationInferenceSpecification InferenceSpecification
        {
            get { return this._inferenceSpecification; }
            set { this._inferenceSpecification = value; }
        }

        // Check to see if InferenceSpecification property is set
        internal bool IsSetInferenceSpecification()
        {
            return this._inferenceSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property ModelSource. 
        /// <para>
        /// The source of the model that was analyzed.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AIModelSource ModelSource
        {
            get { return this._modelSource; }
            set { this._modelSource = value; }
        }

        // Check to see if ModelSource property is set
        internal bool IsSetModelSource()
        {
            return this._modelSource != null;
        }

        /// <summary>
        /// Gets and sets the property OptimizeModel. 
        /// <para>
        /// Whether model optimization techniques were allowed.
        /// </para>
        /// </summary>
        public bool? OptimizeModel
        {
            get { return this._optimizeModel; }
            set { this._optimizeModel = value; }
        }

        // Check to see if OptimizeModel property is set
        internal bool IsSetOptimizeModel()
        {
            return this._optimizeModel.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputConfig. 
        /// <para>
        /// The output configuration for the recommendation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AIRecommendationOutputResult OutputConfig
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
        /// Gets and sets the property PerformanceTarget. 
        /// <para>
        /// The performance targets specified for the recommendation job.
        /// </para>
        /// </summary>
        public AIRecommendationPerformanceTarget PerformanceTarget
        {
            get { return this._performanceTarget; }
            set { this._performanceTarget = value; }
        }

        // Check to see if PerformanceTarget property is set
        internal bool IsSetPerformanceTarget()
        {
            return this._performanceTarget != null;
        }

        /// <summary>
        /// Gets and sets the property Recommendations. 
        /// <para>
        /// The list of optimization recommendations generated by the job. Each recommendation
        /// includes optimization details, deployment configuration, expected performance metrics,
        /// and the associated benchmark job ARN.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<AIRecommendation> Recommendations
        {
            get { return this._recommendations; }
            set { this._recommendations = value; }
        }

        // Check to see if Recommendations property is set
        internal bool IsSetRecommendations()
        {
            return this._recommendations != null && (this._recommendations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role used by the recommendation job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=2048)]
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
        /// Gets and sets the property StartTime. 
        /// <para>
        /// A timestamp that indicates when the recommendation job started running.
        /// </para>
        /// </summary>
        public DateTime? StartTime
        {
            get { return this._startTime; }
            set { this._startTime = value; }
        }

        // Check to see if StartTime property is set
        internal bool IsSetStartTime()
        {
            return this._startTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The tags associated with the recommendation job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=50)]
        public List<Tag> Tags
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