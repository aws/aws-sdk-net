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
 * Do not modify this file. This file is generated from the neptunedata-2023-08-01.normal.json service model.
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
namespace Amazon.Neptunedata.Model
{
    /// <summary>
    /// Container for the parameters to the StartMLModelTrainingJob operation.
    /// Creates a new Neptune ML model training job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-api-modeltraining.html">Model
    /// training using the <c>modeltraining</c> command</a>.
    /// 
    ///  
    /// <para>
    /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
    /// the IAM user or role making the request must have a policy attached that allows the
    /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#startmlmodeltrainingjob">neptune-db:StartMLModelTrainingJob</a>
    /// IAM action in that cluster.
    /// </para>
    /// </summary>
    public partial class StartMLModelTrainingJobRequest : AmazonNeptunedataRequest
    {
        private string _baseProcessingInstanceType;
        private CustomModelTrainingParameters _customModelTrainingParameters;
        private string _dataProcessingJobId;
        private bool? _enableManagedSpotTraining;
        private string _id;
        private int? _maxhpoNumberOfTrainingJobs;
        private int? _maxhpoParallelTrainingJobs;
        private string _neptuneIamRoleArn;
        private string _previousModelTrainingJobId;
        private string _s3OutputEncryptionKMSKey;
        private string _sagemakerIamRoleArn;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _subnets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _trainingInstanceType;
        private int? _trainingInstanceVolumeSizeInGB;
        private int? _trainingTimeOutInSeconds;
        private string _trainModelS3Location;
        private string _volumeEncryptionKMSKey;

        /// <summary>
        /// Gets and sets the property BaseProcessingInstanceType. 
        /// <para>
        /// The type of ML instance used in preparing and managing training of ML models. This
        /// is a CPU instance chosen based on memory requirements for processing the training
        /// data and model.
        /// </para>
        /// </summary>
        public string BaseProcessingInstanceType
        {
            get { return this._baseProcessingInstanceType; }
            set { this._baseProcessingInstanceType = value; }
        }

        // Check to see if BaseProcessingInstanceType property is set
        internal bool IsSetBaseProcessingInstanceType()
        {
            return this._baseProcessingInstanceType != null;
        }

        /// <summary>
        /// Gets and sets the property CustomModelTrainingParameters. 
        /// <para>
        /// The configuration for custom model training. This is a JSON object.
        /// </para>
        /// </summary>
        public CustomModelTrainingParameters CustomModelTrainingParameters
        {
            get { return this._customModelTrainingParameters; }
            set { this._customModelTrainingParameters = value; }
        }

        // Check to see if CustomModelTrainingParameters property is set
        internal bool IsSetCustomModelTrainingParameters()
        {
            return this._customModelTrainingParameters != null;
        }

        /// <summary>
        /// Gets and sets the property DataProcessingJobId. 
        /// <para>
        /// The job ID of the completed data-processing job that has created the data that the
        /// training will work with.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string DataProcessingJobId
        {
            get { return this._dataProcessingJobId; }
            set { this._dataProcessingJobId = value; }
        }

        // Check to see if DataProcessingJobId property is set
        internal bool IsSetDataProcessingJobId()
        {
            return this._dataProcessingJobId != null;
        }

        /// <summary>
        /// Gets and sets the property EnableManagedSpotTraining. 
        /// <para>
        /// Optimizes the cost of training machine-learning models by using Amazon Elastic Compute
        /// Cloud spot instances. The default is <c>False</c>.
        /// </para>
        /// </summary>
        public bool? EnableManagedSpotTraining
        {
            get { return this._enableManagedSpotTraining; }
            set { this._enableManagedSpotTraining = value; }
        }

        // Check to see if EnableManagedSpotTraining property is set
        internal bool IsSetEnableManagedSpotTraining()
        {
            return this._enableManagedSpotTraining.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier for the new job. The default is An autogenerated UUID.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property MaxHPONumberOfTrainingJobs. 
        /// <para>
        /// Maximum total number of training jobs to start for the hyperparameter tuning job.
        /// The default is 2. Neptune ML automatically tunes the hyperparameters of the machine
        /// learning model. To obtain a model that performs well, use at least 10 jobs (in other
        /// words, set <c>maxHPONumberOfTrainingJobs</c> to 10). In general, the more tuning runs,
        /// the better the results.
        /// </para>
        /// </summary>
        public int? MaxHPONumberOfTrainingJobs
        {
            get { return this._maxhpoNumberOfTrainingJobs; }
            set { this._maxhpoNumberOfTrainingJobs = value; }
        }

        // Check to see if MaxHPONumberOfTrainingJobs property is set
        internal bool IsSetMaxHPONumberOfTrainingJobs()
        {
            return this._maxhpoNumberOfTrainingJobs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property MaxHPOParallelTrainingJobs. 
        /// <para>
        /// Maximum number of parallel training jobs to start for the hyperparameter tuning job.
        /// The default is 2. The number of parallel jobs you can run is limited by the available
        /// resources on your training instance.
        /// </para>
        /// </summary>
        public int? MaxHPOParallelTrainingJobs
        {
            get { return this._maxhpoParallelTrainingJobs; }
            set { this._maxhpoParallelTrainingJobs = value; }
        }

        // Check to see if MaxHPOParallelTrainingJobs property is set
        internal bool IsSetMaxHPOParallelTrainingJobs()
        {
            return this._maxhpoParallelTrainingJobs.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NeptuneIamRoleArn. 
        /// <para>
        /// The ARN of an IAM role that provides Neptune access to SageMaker and Amazon S3 resources.
        /// This must be listed in your DB cluster parameter group or an error will occur.
        /// </para>
        /// </summary>
        public string NeptuneIamRoleArn
        {
            get { return this._neptuneIamRoleArn; }
            set { this._neptuneIamRoleArn = value; }
        }

        // Check to see if NeptuneIamRoleArn property is set
        internal bool IsSetNeptuneIamRoleArn()
        {
            return this._neptuneIamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property PreviousModelTrainingJobId. 
        /// <para>
        /// The job ID of a completed model-training job that you want to update incrementally
        /// based on updated data.
        /// </para>
        /// </summary>
        public string PreviousModelTrainingJobId
        {
            get { return this._previousModelTrainingJobId; }
            set { this._previousModelTrainingJobId = value; }
        }

        // Check to see if PreviousModelTrainingJobId property is set
        internal bool IsSetPreviousModelTrainingJobId()
        {
            return this._previousModelTrainingJobId != null;
        }

        /// <summary>
        /// Gets and sets the property S3OutputEncryptionKMSKey. 
        /// <para>
        /// The Amazon Key Management Service (KMS) key that SageMaker uses to encrypt the output
        /// of the processing job. The default is none.
        /// </para>
        /// </summary>
        public string S3OutputEncryptionKMSKey
        {
            get { return this._s3OutputEncryptionKMSKey; }
            set { this._s3OutputEncryptionKMSKey = value; }
        }

        // Check to see if S3OutputEncryptionKMSKey property is set
        internal bool IsSetS3OutputEncryptionKMSKey()
        {
            return this._s3OutputEncryptionKMSKey != null;
        }

        /// <summary>
        /// Gets and sets the property SagemakerIamRoleArn. 
        /// <para>
        /// The ARN of an IAM role for SageMaker execution.This must be listed in your DB cluster
        /// parameter group or an error will occur.
        /// </para>
        /// </summary>
        public string SagemakerIamRoleArn
        {
            get { return this._sagemakerIamRoleArn; }
            set { this._sagemakerIamRoleArn = value; }
        }

        // Check to see if SagemakerIamRoleArn property is set
        internal bool IsSetSagemakerIamRoleArn()
        {
            return this._sagemakerIamRoleArn != null;
        }

        /// <summary>
        /// Gets and sets the property SecurityGroupIds. 
        /// <para>
        /// The VPC security group IDs. The default is None.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> SecurityGroupIds
        {
            get { return this._securityGroupIds; }
            set { this._securityGroupIds = value; }
        }

        // Check to see if SecurityGroupIds property is set
        internal bool IsSetSecurityGroupIds()
        {
            return this._securityGroupIds != null && (this._securityGroupIds.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property Subnets. 
        /// <para>
        /// The IDs of the subnets in the Neptune VPC. The default is None.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> Subnets
        {
            get { return this._subnets; }
            set { this._subnets = value; }
        }

        // Check to see if Subnets property is set
        internal bool IsSetSubnets()
        {
            return this._subnets != null && (this._subnets.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrainingInstanceType. 
        /// <para>
        /// The type of ML instance used for model training. All Neptune ML models support CPU,
        /// GPU, and multiGPU training. The default is <c>ml.p3.2xlarge</c>. Choosing the right
        /// instance type for training depends on the task type, graph size, and your budget.
        /// </para>
        /// </summary>
        public string TrainingInstanceType
        {
            get { return this._trainingInstanceType; }
            set { this._trainingInstanceType = value; }
        }

        // Check to see if TrainingInstanceType property is set
        internal bool IsSetTrainingInstanceType()
        {
            return this._trainingInstanceType != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingInstanceVolumeSizeInGB. 
        /// <para>
        /// The disk volume size of the training instance. Both input data and the output model
        /// are stored on disk, so the volume size must be large enough to hold both data sets.
        /// The default is 0. If not specified or 0, Neptune ML selects a disk volume size based
        /// on the recommendation generated in the data processing step.
        /// </para>
        /// </summary>
        public int? TrainingInstanceVolumeSizeInGB
        {
            get { return this._trainingInstanceVolumeSizeInGB; }
            set { this._trainingInstanceVolumeSizeInGB = value; }
        }

        // Check to see if TrainingInstanceVolumeSizeInGB property is set
        internal bool IsSetTrainingInstanceVolumeSizeInGB()
        {
            return this._trainingInstanceVolumeSizeInGB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrainingTimeOutInSeconds. 
        /// <para>
        /// Timeout in seconds for the training job. The default is 86,400 (1 day).
        /// </para>
        /// </summary>
        public int? TrainingTimeOutInSeconds
        {
            get { return this._trainingTimeOutInSeconds; }
            set { this._trainingTimeOutInSeconds = value; }
        }

        // Check to see if TrainingTimeOutInSeconds property is set
        internal bool IsSetTrainingTimeOutInSeconds()
        {
            return this._trainingTimeOutInSeconds.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrainModelS3Location. 
        /// <para>
        /// The location in Amazon S3 where the model artifacts are to be stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string TrainModelS3Location
        {
            get { return this._trainModelS3Location; }
            set { this._trainModelS3Location = value; }
        }

        // Check to see if TrainModelS3Location property is set
        internal bool IsSetTrainModelS3Location()
        {
            return this._trainModelS3Location != null;
        }

        /// <summary>
        /// Gets and sets the property VolumeEncryptionKMSKey. 
        /// <para>
        /// The Amazon Key Management Service (KMS) key that SageMaker uses to encrypt data on
        /// the storage volume attached to the ML compute instances that run the training job.
        /// The default is None.
        /// </para>
        /// </summary>
        public string VolumeEncryptionKMSKey
        {
            get { return this._volumeEncryptionKMSKey; }
            set { this._volumeEncryptionKMSKey = value; }
        }

        // Check to see if VolumeEncryptionKMSKey property is set
        internal bool IsSetVolumeEncryptionKMSKey()
        {
            return this._volumeEncryptionKMSKey != null;
        }

    }
}