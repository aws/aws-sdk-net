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
    /// This is the response object from the DescribeInferenceRecommendationsJob operation.
    /// </summary>
    public partial class DescribeInferenceRecommendationsJobResponse : AmazonWebServiceResponse
    {
        private DateTime? _completionTime;
        private DateTime? _creationTime;
        private List<EndpointPerformance> _endpointPerformances = AWSConfigs.InitializeCollections ? new List<EndpointPerformance>() : null;
        private string _failureReason;
        private List<InferenceRecommendation> _inferenceRecommendations = AWSConfigs.InitializeCollections ? new List<InferenceRecommendation>() : null;
        private RecommendationJobInputConfig _inputConfig;
        private string _jobArn;
        private string _jobDescription;
        private string _jobName;
        private RecommendationJobType _jobType;
        private DateTime? _lastModifiedTime;
        private string _roleArn;
        private RecommendationJobStatus _status;
        private RecommendationJobStoppingConditions _stoppingConditions;

        /// <summary>
        /// Gets and sets the property CompletionTime. 
        /// <para>
        /// A timestamp that shows when the job completed.
        /// </para>
        /// </summary>
        public DateTime? CompletionTime
        {
            get { return this._completionTime; }
            set { this._completionTime = value; }
        }

        // Check to see if CompletionTime property is set
        internal bool IsSetCompletionTime()
        {
            return this._completionTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// A timestamp that shows when the job was created.
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
        /// Gets and sets the property EndpointPerformances. 
        /// <para>
        /// The performance results from running an Inference Recommender job on an existing endpoint.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<EndpointPerformance> EndpointPerformances
        {
            get { return this._endpointPerformances; }
            set { this._endpointPerformances = value; }
        }

        // Check to see if EndpointPerformances property is set
        internal bool IsSetEndpointPerformances()
        {
            return this._endpointPerformances != null && (this._endpointPerformances.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// If the job fails, provides information why the job failed.
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
        /// Gets and sets the property InferenceRecommendations. 
        /// <para>
        /// The recommendations made by Inference Recommender.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=1, Max=10)]
        public List<InferenceRecommendation> InferenceRecommendations
        {
            get { return this._inferenceRecommendations; }
            set { this._inferenceRecommendations = value; }
        }

        // Check to see if InferenceRecommendations property is set
        internal bool IsSetInferenceRecommendations()
        {
            return this._inferenceRecommendations != null && (this._inferenceRecommendations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InputConfig. 
        /// <para>
        /// Returns information about the versioned model package Amazon Resource Name (ARN),
        /// the traffic pattern, and endpoint configurations you provided when you initiated the
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationJobInputConfig InputConfig
        {
            get { return this._inputConfig; }
            set { this._inputConfig = value; }
        }

        // Check to see if InputConfig property is set
        internal bool IsSetInputConfig()
        {
            return this._inputConfig != null;
        }

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=256)]
        public string JobArn
        {
            get { return this._jobArn; }
            set { this._jobArn = value; }
        }

        // Check to see if JobArn property is set
        internal bool IsSetJobArn()
        {
            return this._jobArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobDescription. 
        /// <para>
        /// The job description that you provided when you initiated the job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=128)]
        public string JobDescription
        {
            get { return this._jobDescription; }
            set { this._jobDescription = value; }
        }

        // Check to see if JobDescription property is set
        internal bool IsSetJobDescription()
        {
            return this._jobDescription != null;
        }

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the job. The name must be unique within an Amazon Web Services Region
        /// in the Amazon Web Services account.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=64)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property JobType. 
        /// <para>
        /// The job type that you provided when you initiated the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationJobType JobType
        {
            get { return this._jobType; }
            set { this._jobType = value; }
        }

        // Check to see if JobType property is set
        internal bool IsSetJobType()
        {
            return this._jobType != null;
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// A timestamp that shows when the job was last modified.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Amazon Web Services Identity and Access Management
        /// (IAM) role you provided when you initiated the job.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public RecommendationJobStatus Status
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
        /// Gets and sets the property StoppingConditions. 
        /// <para>
        /// The stopping conditions that you provided when you initiated the job.
        /// </para>
        /// </summary>
        public RecommendationJobStoppingConditions StoppingConditions
        {
            get { return this._stoppingConditions; }
            set { this._stoppingConditions = value; }
        }

        // Check to see if StoppingConditions property is set
        internal bool IsSetStoppingConditions()
        {
            return this._stoppingConditions != null;
        }

    }
}