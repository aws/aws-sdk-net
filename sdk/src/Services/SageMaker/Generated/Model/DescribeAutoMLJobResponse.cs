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

namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// This is the response object from the DescribeAutoMLJob operation.
    /// </summary>
    public partial class DescribeAutoMLJobResponse : AmazonWebServiceResponse
    {
        private string _autoMLJobArn;
        private AutoMLJobArtifacts _autoMLJobArtifacts;
        private AutoMLJobConfig _autoMLJobConfig;
        private string _autoMLJobName;
        private AutoMLJobObjective _autoMLJobObjective;
        private AutoMLJobSecondaryStatus _autoMLJobSecondaryStatus;
        private AutoMLJobStatus _autoMLJobStatus;
        private AutoMLCandidate _bestCandidate;
        private DateTime? _creationTime;
        private DateTime? _endTime;
        private string _failureReason;
        private bool? _generateCandidateDefinitionsOnly;
        private List<AutoMLChannel> _inputDataConfig = new List<AutoMLChannel>();
        private DateTime? _lastModifiedTime;
        private ModelDeployConfig _modelDeployConfig;
        private ModelDeployResult _modelDeployResult;
        private AutoMLOutputDataConfig _outputDataConfig;
        private List<AutoMLPartialFailureReason> _partialFailureReasons = new List<AutoMLPartialFailureReason>();
        private ProblemType _problemType;
        private ResolvedAttributes _resolvedAttributes;
        private string _roleArn;

        /// <summary>
        /// Gets and sets the property AutoMLJobArn. 
        /// <para>
        /// Returns the ARN of the AutoML job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=256)]
        public string AutoMLJobArn
        {
            get { return this._autoMLJobArn; }
            set { this._autoMLJobArn = value; }
        }

        // Check to see if AutoMLJobArn property is set
        internal bool IsSetAutoMLJobArn()
        {
            return this._autoMLJobArn != null;
        }

        /// <summary>
        /// Gets and sets the property AutoMLJobArtifacts. 
        /// <para>
        /// Returns information on the job's artifacts found in <code>AutoMLJobArtifacts</code>.
        /// </para>
        /// </summary>
        public AutoMLJobArtifacts AutoMLJobArtifacts
        {
            get { return this._autoMLJobArtifacts; }
            set { this._autoMLJobArtifacts = value; }
        }

        // Check to see if AutoMLJobArtifacts property is set
        internal bool IsSetAutoMLJobArtifacts()
        {
            return this._autoMLJobArtifacts != null;
        }

        /// <summary>
        /// Gets and sets the property AutoMLJobConfig. 
        /// <para>
        /// Returns the configuration for the AutoML job.
        /// </para>
        /// </summary>
        public AutoMLJobConfig AutoMLJobConfig
        {
            get { return this._autoMLJobConfig; }
            set { this._autoMLJobConfig = value; }
        }

        // Check to see if AutoMLJobConfig property is set
        internal bool IsSetAutoMLJobConfig()
        {
            return this._autoMLJobConfig != null;
        }

        /// <summary>
        /// Gets and sets the property AutoMLJobName. 
        /// <para>
        /// Returns the name of the AutoML job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=32)]
        public string AutoMLJobName
        {
            get { return this._autoMLJobName; }
            set { this._autoMLJobName = value; }
        }

        // Check to see if AutoMLJobName property is set
        internal bool IsSetAutoMLJobName()
        {
            return this._autoMLJobName != null;
        }

        /// <summary>
        /// Gets and sets the property AutoMLJobObjective. 
        /// <para>
        /// Returns the job's objective.
        /// </para>
        /// </summary>
        public AutoMLJobObjective AutoMLJobObjective
        {
            get { return this._autoMLJobObjective; }
            set { this._autoMLJobObjective = value; }
        }

        // Check to see if AutoMLJobObjective property is set
        internal bool IsSetAutoMLJobObjective()
        {
            return this._autoMLJobObjective != null;
        }

        /// <summary>
        /// Gets and sets the property AutoMLJobSecondaryStatus. 
        /// <para>
        /// Returns the secondary status of the AutoML job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoMLJobSecondaryStatus AutoMLJobSecondaryStatus
        {
            get { return this._autoMLJobSecondaryStatus; }
            set { this._autoMLJobSecondaryStatus = value; }
        }

        // Check to see if AutoMLJobSecondaryStatus property is set
        internal bool IsSetAutoMLJobSecondaryStatus()
        {
            return this._autoMLJobSecondaryStatus != null;
        }

        /// <summary>
        /// Gets and sets the property AutoMLJobStatus. 
        /// <para>
        /// Returns the status of the AutoML job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoMLJobStatus AutoMLJobStatus
        {
            get { return this._autoMLJobStatus; }
            set { this._autoMLJobStatus = value; }
        }

        // Check to see if AutoMLJobStatus property is set
        internal bool IsSetAutoMLJobStatus()
        {
            return this._autoMLJobStatus != null;
        }

        /// <summary>
        /// Gets and sets the property BestCandidate. 
        /// <para>
        /// The best model candidate selected by SageMaker Autopilot using both the best objective
        /// metric and lowest <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-metrics-validation.html">InferenceLatency</a>
        /// for an experiment.
        /// </para>
        /// </summary>
        public AutoMLCandidate BestCandidate
        {
            get { return this._bestCandidate; }
            set { this._bestCandidate = value; }
        }

        // Check to see if BestCandidate property is set
        internal bool IsSetBestCandidate()
        {
            return this._bestCandidate != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Returns the creation time of the AutoML job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
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
        /// Returns the end time of the AutoML job.
        /// </para>
        /// </summary>
        public DateTime EndTime
        {
            get { return this._endTime.GetValueOrDefault(); }
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
        /// Returns the failure reason for an AutoML job, when applicable.
        /// </para>
        /// </summary>
        [AWSProperty(Max=1024)]
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
        /// Gets and sets the property GenerateCandidateDefinitionsOnly. 
        /// <para>
        /// Indicates whether the output for an AutoML job generates candidate definitions only.
        /// </para>
        /// </summary>
        public bool GenerateCandidateDefinitionsOnly
        {
            get { return this._generateCandidateDefinitionsOnly.GetValueOrDefault(); }
            set { this._generateCandidateDefinitionsOnly = value; }
        }

        // Check to see if GenerateCandidateDefinitionsOnly property is set
        internal bool IsSetGenerateCandidateDefinitionsOnly()
        {
            return this._generateCandidateDefinitionsOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// Returns the input data configuration for the AutoML job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<AutoMLChannel> InputDataConfig
        {
            get { return this._inputDataConfig; }
            set { this._inputDataConfig = value; }
        }

        // Check to see if InputDataConfig property is set
        internal bool IsSetInputDataConfig()
        {
            return this._inputDataConfig != null && this._inputDataConfig.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// Returns the job's last modified time.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public DateTime LastModifiedTime
        {
            get { return this._lastModifiedTime.GetValueOrDefault(); }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelDeployConfig. 
        /// <para>
        /// Indicates whether the model was deployed automatically to an endpoint and the name
        /// of that endpoint if deployed automatically.
        /// </para>
        /// </summary>
        public ModelDeployConfig ModelDeployConfig
        {
            get { return this._modelDeployConfig; }
            set { this._modelDeployConfig = value; }
        }

        // Check to see if ModelDeployConfig property is set
        internal bool IsSetModelDeployConfig()
        {
            return this._modelDeployConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ModelDeployResult. 
        /// <para>
        /// Provides information about endpoint for the model deployment.
        /// </para>
        /// </summary>
        public ModelDeployResult ModelDeployResult
        {
            get { return this._modelDeployResult; }
            set { this._modelDeployResult = value; }
        }

        // Check to see if ModelDeployResult property is set
        internal bool IsSetModelDeployResult()
        {
            return this._modelDeployResult != null;
        }

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// Returns the job's output data config.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AutoMLOutputDataConfig OutputDataConfig
        {
            get { return this._outputDataConfig; }
            set { this._outputDataConfig = value; }
        }

        // Check to see if OutputDataConfig property is set
        internal bool IsSetOutputDataConfig()
        {
            return this._outputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property PartialFailureReasons. 
        /// <para>
        /// Returns a list of reasons for partial failures within an AutoML job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<AutoMLPartialFailureReason> PartialFailureReasons
        {
            get { return this._partialFailureReasons; }
            set { this._partialFailureReasons = value; }
        }

        // Check to see if PartialFailureReasons property is set
        internal bool IsSetPartialFailureReasons()
        {
            return this._partialFailureReasons != null && this._partialFailureReasons.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property ProblemType. 
        /// <para>
        /// Returns the job's problem type.
        /// </para>
        /// </summary>
        public ProblemType ProblemType
        {
            get { return this._problemType; }
            set { this._problemType = value; }
        }

        // Check to see if ProblemType property is set
        internal bool IsSetProblemType()
        {
            return this._problemType != null;
        }

        /// <summary>
        /// Gets and sets the property ResolvedAttributes. 
        /// <para>
        /// Contains <code>ProblemType</code>, <code>AutoMLJobObjective</code>, and <code>CompletionCriteria</code>.
        /// If you do not provide these values, they are auto-inferred. If you do provide them,
        /// the values used are the ones you provide.
        /// </para>
        /// </summary>
        public ResolvedAttributes ResolvedAttributes
        {
            get { return this._resolvedAttributes; }
            set { this._resolvedAttributes = value; }
        }

        // Check to see if ResolvedAttributes property is set
        internal bool IsSetResolvedAttributes()
        {
            return this._resolvedAttributes != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the Identity and Access Management (IAM) role that
        /// has read permission to the input data location and write permission to the output
        /// data location in Amazon S3.
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

    }
}