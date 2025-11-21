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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.Braket.Model
{
    /// <summary>
    /// Container for the parameters to the CreateJob operation.
    /// Creates an Amazon Braket hybrid job.
    /// </summary>
    public partial class CreateJobRequest : AmazonBraketRequest
    {
        private AlgorithmSpecification _algorithmSpecification;
        private List<Association> _associations = AWSConfigs.InitializeCollections ? new List<Association>() : null;
        private JobCheckpointConfig _checkpointConfig;
        private string _clientToken;
        private DeviceConfig _deviceConfig;
        private Dictionary<string, string> _hyperParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private List<InputFileConfig> _inputDataConfig = AWSConfigs.InitializeCollections ? new List<InputFileConfig>() : null;
        private InstanceConfig _instanceConfig;
        private string _jobName;
        private JobOutputDataConfig _outputDataConfig;
        private string _roleArn;
        private JobStoppingCondition _stoppingCondition;
        private Dictionary<string, string> _tags = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Gets and sets the property AlgorithmSpecification. 
        /// <para>
        /// Definition of the Amazon Braket job to be created. Specifies the container image the
        /// job uses and information about the Python scripts used for entry and training.
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
        /// Gets and sets the property Associations. 
        /// <para>
        /// The list of Amazon Braket resources associated with the hybrid job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=1)]
        public List<Association> Associations
        {
            get { return this._associations; }
            set { this._associations = value; }
        }

        // Check to see if Associations property is set
        internal bool IsSetAssociations()
        {
            return this._associations != null && (this._associations.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property CheckpointConfig. 
        /// <para>
        /// Information about the output locations for hybrid job checkpoint data.
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
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// The client token associated with this request that guarantees that the request is
        /// idempotent.
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
        /// Gets and sets the property DeviceConfig. 
        /// <para>
        /// The quantum processing unit (QPU) or simulator used to create an Amazon Braket hybrid
        /// job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property HyperParameters. 
        /// <para>
        /// Algorithm-specific parameters used by an Amazon Braket hybrid job that influence the
        /// quality of the training job. The values are set with a map of JSON key:value pairs,
        /// where the key is the name of the hyperparameter and the value is the value of the
        /// hyperparameter.
        /// </para>
        ///  <important> 
        /// <para>
        /// Do not include any security-sensitive information including account access IDs, secrets,
        /// or tokens in any hyperparameter fields. As part of the shared responsibility model,
        /// you are responsible for any potential exposure, unauthorized access, or compromise
        /// of your sensitive data if caused by security-sensitive information included in the
        /// request hyperparameter variable or plain text fields.
        /// </para>
        ///  </important>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
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
            return this._hyperParameters != null && (this._hyperParameters.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// A list of parameters that specify the name and type of input data and where it is
        /// located.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=20)]
        public List<InputFileConfig> InputDataConfig
        {
            get { return this._inputDataConfig; }
            set { this._inputDataConfig = value; }
        }

        // Check to see if InputDataConfig property is set
        internal bool IsSetInputDataConfig()
        {
            return this._inputDataConfig != null && (this._inputDataConfig.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property InstanceConfig. 
        /// <para>
        /// Configuration of the resource instances to use while running the hybrid job on Amazon
        /// Braket.
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
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the Amazon Braket hybrid job.
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
        /// The path to the S3 location where you want to store hybrid job artifacts and the encryption
        /// key used to store them.
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
        /// container on behalf of user, and output results and hybrid job details to the users'
        /// s3 buckets.
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
        /// Gets and sets the property StoppingCondition. 
        /// <para>
        ///  The user-defined criteria that specifies when a hybrid job stops running.
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
        /// Tags to be added to the hybrid job you're creating.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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