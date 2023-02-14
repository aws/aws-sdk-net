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
 * Do not modify this file. This file is generated from the emr-containers-2020-10-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.EMRContainers.Model
{
    /// <summary>
    /// This entity describes a job run. A job run is a unit of work, such as a Spark jar,
    /// PySpark script, or SparkSQL query, that you submit to Amazon EMR on EKS.
    /// </summary>
    public partial class JobRun
    {
        private string _arn;
        private string _clientToken;
        private ConfigurationOverrides _configurationOverrides;
        private DateTime? _createdAt;
        private string _createdBy;
        private string _executionRoleArn;
        private FailureReason _failureReason;
        private DateTime? _finishedAt;
        private string _id;
        private JobDriver _jobDriver;
        private string _name;
        private string _releaseLabel;
        private RetryPolicyConfiguration _retryPolicyConfiguration;
        private RetryPolicyExecution _retryPolicyExecution;
        private JobRunState _state;
        private string _stateDetails;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();
        private string _virtualClusterId;

        /// <summary>
        /// Gets and sets the property Arn. 
        /// <para>
        /// The ARN of job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=60, Max=1024)]
        public string Arn
        {
            get { return this._arn; }
            set { this._arn = value; }
        }

        // Check to see if Arn property is set
        internal bool IsSetArn()
        {
            return this._arn != null;
        }

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token used to start a job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property ConfigurationOverrides. 
        /// <para>
        /// The configuration settings that are used to override default configuration.
        /// </para>
        /// </summary>
        public ConfigurationOverrides ConfigurationOverrides
        {
            get { return this._configurationOverrides; }
            set { this._configurationOverrides = value; }
        }

        // Check to see if ConfigurationOverrides property is set
        internal bool IsSetConfigurationOverrides()
        {
            return this._configurationOverrides != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time when the job run was created.
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CreatedBy. 
        /// <para>
        /// The user who created the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string CreatedBy
        {
            get { return this._createdBy; }
            set { this._createdBy = value; }
        }

        // Check to see if CreatedBy property is set
        internal bool IsSetCreatedBy()
        {
            return this._createdBy != null;
        }

        /// <summary>
        /// Gets and sets the property ExecutionRoleArn. 
        /// <para>
        /// The execution role ARN of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ExecutionRoleArn
        {
            get { return this._executionRoleArn; }
            set { this._executionRoleArn = value; }
        }

        // Check to see if ExecutionRoleArn property is set
        internal bool IsSetExecutionRoleArn()
        {
            return this._executionRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// The reasons why the job run has failed.
        /// </para>
        /// </summary>
        public FailureReason FailureReason
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
        /// Gets and sets the property FinishedAt. 
        /// <para>
        /// The date and time when the job run has finished.
        /// </para>
        /// </summary>
        public DateTime FinishedAt
        {
            get { return this._finishedAt.GetValueOrDefault(); }
            set { this._finishedAt = value; }
        }

        // Check to see if FinishedAt property is set
        internal bool IsSetFinishedAt()
        {
            return this._finishedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// The ID of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        // Check to see if Id property is set
        internal bool IsSetId()
        {
            return this._id != null;
        }

        /// <summary>
        /// Gets and sets the property JobDriver. 
        /// <para>
        /// Parameters of job driver for the job run.
        /// </para>
        /// </summary>
        public JobDriver JobDriver
        {
            get { return this._jobDriver; }
            set { this._jobDriver = value; }
        }

        // Check to see if JobDriver property is set
        internal bool IsSetJobDriver()
        {
            return this._jobDriver != null;
        }

        /// <summary>
        /// Gets and sets the property Name. 
        /// <para>
        /// The name of the job run.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
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
        /// Gets and sets the property ReleaseLabel. 
        /// <para>
        /// The release version of Amazon EMR.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string ReleaseLabel
        {
            get { return this._releaseLabel; }
            set { this._releaseLabel = value; }
        }

        // Check to see if ReleaseLabel property is set
        internal bool IsSetReleaseLabel()
        {
            return this._releaseLabel != null;
        }

        /// <summary>
        /// Gets and sets the property RetryPolicyConfiguration. 
        /// <para>
        /// The configuration of the retry policy that the job runs on.
        /// </para>
        /// </summary>
        public RetryPolicyConfiguration RetryPolicyConfiguration
        {
            get { return this._retryPolicyConfiguration; }
            set { this._retryPolicyConfiguration = value; }
        }

        // Check to see if RetryPolicyConfiguration property is set
        internal bool IsSetRetryPolicyConfiguration()
        {
            return this._retryPolicyConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property RetryPolicyExecution. 
        /// <para>
        /// The current status of the retry policy executed on the job.
        /// </para>
        /// </summary>
        public RetryPolicyExecution RetryPolicyExecution
        {
            get { return this._retryPolicyExecution; }
            set { this._retryPolicyExecution = value; }
        }

        // Check to see if RetryPolicyExecution property is set
        internal bool IsSetRetryPolicyExecution()
        {
            return this._retryPolicyExecution != null;
        }

        /// <summary>
        /// Gets and sets the property State. 
        /// <para>
        /// The state of the job run. 
        /// </para>
        /// </summary>
        public JobRunState State
        {
            get { return this._state; }
            set { this._state = value; }
        }

        // Check to see if State property is set
        internal bool IsSetState()
        {
            return this._state != null;
        }

        /// <summary>
        /// Gets and sets the property StateDetails. 
        /// <para>
        /// Additional details of the job run state.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string StateDetails
        {
            get { return this._stateDetails; }
            set { this._stateDetails = value; }
        }

        // Check to see if StateDetails property is set
        internal bool IsSetStateDetails()
        {
            return this._stateDetails != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// The assigned tags of the job run.
        /// </para>
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
            return this._tags != null && this._tags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property VirtualClusterId. 
        /// <para>
        /// The ID of the job run's virtual cluster.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public string VirtualClusterId
        {
            get { return this._virtualClusterId; }
            set { this._virtualClusterId = value; }
        }

        // Check to see if VirtualClusterId property is set
        internal bool IsSetVirtualClusterId()
        {
            return this._virtualClusterId != null;
        }

    }
}