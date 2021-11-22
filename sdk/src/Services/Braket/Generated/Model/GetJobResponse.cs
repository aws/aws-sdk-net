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
 * Do not modify this file. This file is generated from the braket-2019-09-01.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Braket.Model
{
    /// <summary>
    /// This is the response object from the GetJob operation.
    /// </summary>
    public partial class GetJobResponse : AmazonWebServiceResponse
    {
        private AlgorithmSpecification _algorithmSpecification;
        private int? _billableDuration;
        private JobCheckpointConfig _checkpointConfig;
        private DateTime? _createdAt;
        private DeviceConfig _deviceConfig;
        private DateTime? _endedAt;
        private List<JobEventDetails> _events = new List<JobEventDetails>();
        private string _failureReason;
        private Dictionary<string, string> _hyperParameters = new Dictionary<string, string>();
        private List<InputFileConfig> _inputDataConfig = new List<InputFileConfig>();
        private InstanceConfig _instanceConfig;
        private string _jobArn;
        private string _jobName;
        private JobOutputDataConfig _outputDataConfig;
        private string _roleArn;
        private DateTime? _startedAt;
        private JobPrimaryStatus _status;
        private JobStoppingCondition _stoppingCondition;
        private Dictionary<string, string> _tags = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AlgorithmSpecification. 
        /// <para>
        /// Definition of the Amazon Braket job created. Specifies the container image the job
        /// uses, information about the Python scripts used for entry and training, and the user-defined
        /// metrics used to evaluation the job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public AlgorithmSpecification AlgorithmSpecification
        {
            get { return this._algorithmSpecification; }
            set { this._algorithmSpecification = value; }
        }

        // Check to see if AlgorithmSpecification property is set
        internal bool IsSetAlgorithmSpecification()
        {
            return this._algorithmSpecification != null;
        }

        /// <summary>
        /// Gets and sets the property BillableDuration. 
        /// <para>
        /// The billable time the Amazon Braket job used to complete.
        /// </para>
        /// </summary>
        public int BillableDuration
        {
            get { return this._billableDuration.GetValueOrDefault(); }
            set { this._billableDuration = value; }
        }

        // Check to see if BillableDuration property is set
        internal bool IsSetBillableDuration()
        {
            return this._billableDuration.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CheckpointConfig. 
        /// <para>
        /// Information about the output locations for job checkpoint data.
        /// </para>
        /// </summary>
        public JobCheckpointConfig CheckpointConfig
        {
            get { return this._checkpointConfig; }
            set { this._checkpointConfig = value; }
        }

        // Check to see if CheckpointConfig property is set
        internal bool IsSetCheckpointConfig()
        {
            return this._checkpointConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// The date and time that the Amazon Braket job was created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property DeviceConfig. 
        /// <para>
        /// The quantum processing unit (QPU) or simulator used to run the Amazon Braket job.
        /// </para>
        /// </summary>
        public DeviceConfig DeviceConfig
        {
            get { return this._deviceConfig; }
            set { this._deviceConfig = value; }
        }

        // Check to see if DeviceConfig property is set
        internal bool IsSetDeviceConfig()
        {
            return this._deviceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EndedAt. 
        /// <para>
        /// The date and time that the Amazon Braket job ended.
        /// </para>
        /// </summary>
        public DateTime EndedAt
        {
            get { return this._endedAt.GetValueOrDefault(); }
            set { this._endedAt = value; }
        }

        // Check to see if EndedAt property is set
        internal bool IsSetEndedAt()
        {
            return this._endedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Events. 
        /// <para>
        /// Details about the type and time events occurred related to the Amazon Braket job.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<JobEventDetails> Events
        {
            get { return this._events; }
            set { this._events = value; }
        }

        // Check to see if Events property is set
        internal bool IsSetEvents()
        {
            return this._events != null && this._events.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property FailureReason. 
        /// <para>
        /// A description of the reason why an Amazon Braket job failed, if it failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
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
        /// Gets and sets the property HyperParameters. 
        /// <para>
        /// Algorithm-specific parameters used by an Amazon Braket job that influence the quality
        /// of the traiing job. The values are set with a string of JSON key:value pairs, where
        /// the key is the name of the hyperparameter and the value is the value of th hyperparameter.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public Dictionary<string, string> HyperParameters
        {
            get { return this._hyperParameters; }
            set { this._hyperParameters = value; }
        }

        // Check to see if HyperParameters property is set
        internal bool IsSetHyperParameters()
        {
            return this._hyperParameters != null && this._hyperParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// A list of parameters that specify the name and type of input data and where it is
        /// located.
        /// </para>
        /// </summary>
        public List<InputFileConfig> InputDataConfig
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
        /// Gets and sets the property InstanceConfig. 
        /// <para>
        /// The resource instances to use while running the hybrid job on Amazon Braket.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public InstanceConfig InstanceConfig
        {
            get { return this._instanceConfig; }
            set { this._instanceConfig = value; }
        }

        // Check to see if InstanceConfig property is set
        internal bool IsSetInstanceConfig()
        {
            return this._instanceConfig != null;
        }

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The ARN of the Amazon Braket job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the Amazon Braket job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=50)]
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
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// The path to the S3 location where job artifacts are stored and the encryption key
        /// used to store them there.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobOutputDataConfig OutputDataConfig
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of an IAM role that Amazon Braket can assume to perform
        /// tasks on behalf of a user. It can access user resources, run an Amazon Braket job
        /// container on behalf of user, and output resources to the s3 buckets of a user.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// The date and time that the Amazon Braket job was started.
        /// </para>
        /// </summary>
        public DateTime StartedAt
        {
            get { return this._startedAt.GetValueOrDefault(); }
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
        /// The status of the Amazon Braket job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public JobPrimaryStatus Status
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
        /// Gets and sets the property StoppingCondition. 
        /// <para>
        /// The user-defined criteria that specifies when to stop a job running.
        /// </para>
        /// </summary>
        public JobStoppingCondition StoppingCondition
        {
            get { return this._stoppingCondition; }
            set { this._stoppingCondition = value; }
        }

        // Check to see if StoppingCondition property is set
        internal bool IsSetStoppingCondition()
        {
            return this._stoppingCondition != null;
        }

        /// <summary>
        /// Gets and sets the property Tags. 
        /// <para>
        /// A tag object that consists of a key and an optional value, used to manage metadata
        /// for Amazon Braket resources.
        /// </para>
        /// </summary>
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

    }
}