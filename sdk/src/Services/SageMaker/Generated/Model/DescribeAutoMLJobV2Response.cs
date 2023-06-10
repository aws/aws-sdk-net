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
    /// This is the response object from the DescribeAutoMLJobV2 operation.
    /// </summary>
    public partial class DescribeAutoMLJobV2Response : AmazonWebServiceResponse
    {
        private string _autoMLJobArn;
        private List<AutoMLJobChannel> _autoMLJobInputDataConfig = new List<AutoMLJobChannel>();
        private string _autoMLJobName;
        private AutoMLJobObjective _autoMLJobObjective;
        private AutoMLJobSecondaryStatus _autoMLJobSecondaryStatus;
        private AutoMLJobStatus _autoMLJobStatus;
        private AutoMLProblemTypeConfig _autoMLProblemTypeConfig;
        private AutoMLCandidate _bestCandidate;
        private DateTime? _creationTime;
        private AutoMLDataSplitConfig _dataSplitConfig;
        private DateTime? _endTime;
        private string _failureReason;
        private DateTime? _lastModifiedTime;
        private ModelDeployConfig _modelDeployConfig;
        private ModelDeployResult _modelDeployResult;
        private AutoMLOutputDataConfig _outputDataConfig;
        private List<AutoMLPartialFailureReason> _partialFailureReasons = new List<AutoMLPartialFailureReason>();
        private string _roleArn;
        private AutoMLSecurityConfig _securityConfig;

        /// <summary>
        /// Gets and sets the property AutoMLJobArn. 
        /// <para>
        /// Returns the Amazon Resource Name (ARN) of the AutoML V2 job.
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
        /// Gets and sets the property AutoMLJobInputDataConfig. 
        /// <para>
        /// Returns an array of channel objects describing the input data and their location.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2)]
        public List<AutoMLJobChannel> AutoMLJobInputDataConfig
        {
            get { return this._autoMLJobInputDataConfig; }
            set { this._autoMLJobInputDataConfig = value; }
        }

        // Check to see if AutoMLJobInputDataConfig property is set
        internal bool IsSetAutoMLJobInputDataConfig()
        {
            return this._autoMLJobInputDataConfig != null && this._autoMLJobInputDataConfig.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property AutoMLJobName. 
        /// <para>
        /// Returns the name of the AutoML V2 job.
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
        /// Returns the secondary status of the AutoML V2 job.
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
        /// Returns the status of the AutoML V2 job.
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
        /// Gets and sets the property AutoMLProblemTypeConfig. 
        /// <para>
        /// Returns the configuration settings of the problem type set for the AutoML V2 job.
        /// </para>
        /// </summary>
        public AutoMLProblemTypeConfig AutoMLProblemTypeConfig
        {
            get { return this._autoMLProblemTypeConfig; }
            set { this._autoMLProblemTypeConfig = value; }
        }

        // Check to see if AutoMLProblemTypeConfig property is set
        internal bool IsSetAutoMLProblemTypeConfig()
        {
            return this._autoMLProblemTypeConfig != null;
        }

        /// <summary>
        /// Gets and sets the property BestCandidate. 
        /// <para>
        /// Information about the candidate produced by an AutoML training job V2, including its
        /// status, steps, and other properties.
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
        /// Returns the creation time of the AutoML V2 job.
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
        /// Gets and sets the property DataSplitConfig. 
        /// <para>
        /// Returns the configuration settings of how the data are split into train and validation
        /// datasets.
        /// </para>
        /// </summary>
        public AutoMLDataSplitConfig DataSplitConfig
        {
            get { return this._dataSplitConfig; }
            set { this._dataSplitConfig = value; }
        }

        // Check to see if DataSplitConfig property is set
        internal bool IsSetDataSplitConfig()
        {
            return this._dataSplitConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Returns the end time of the AutoML V2 job.
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
        /// Returns the reason for the failure of the AutoML V2 job, when applicable.
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
        /// Returns a list of reasons for partial failures within an AutoML V2 job.
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The ARN of the Identity and Access Management role that has read permission to the
        /// input data location and write permission to the output data location in Amazon S3.
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
        /// Gets and sets the property SecurityConfig. 
        /// <para>
        /// Returns the security configuration for traffic encryption or Amazon VPC settings.
        /// </para>
        /// </summary>
        public AutoMLSecurityConfig SecurityConfig
        {
            get { return this._securityConfig; }
            set { this._securityConfig = value; }
        }

        // Check to see if SecurityConfig property is set
        internal bool IsSetSecurityConfig()
        {
            return this._securityConfig != null;
        }

    }
}