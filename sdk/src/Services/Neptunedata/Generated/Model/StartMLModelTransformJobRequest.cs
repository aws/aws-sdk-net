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
    /// Container for the parameters to the StartMLModelTransformJob operation.
    /// Creates a new model transform job. See <a href="https://docs.aws.amazon.com/neptune/latest/userguide/machine-learning-model-transform.html">Use
    /// a trained model to generate new model artifacts</a>.
    /// 
    ///  
    /// <para>
    /// When invoking this operation in a Neptune cluster that has IAM authentication enabled,
    /// the IAM user or role making the request must have a policy attached that allows the
    /// <a href="https://docs.aws.amazon.com/neptune/latest/userguide/iam-dp-actions.html#startmlmodeltransformjob">neptune-db:StartMLModelTransformJob</a>
    /// IAM action in that cluster.
    /// </para>
    /// </summary>
    public partial class StartMLModelTransformJobRequest : AmazonNeptunedataRequest
    {
        private string _baseProcessingInstanceType;
        private int? _baseProcessingInstanceVolumeSizeInGB;
        private CustomModelTransformParameters _customModelTransformParameters;
        private string _dataProcessingJobId;
        private string _id;
        private string _mlModelTrainingJobId;
        private string _modelTransformOutputS3Location;
        private string _neptuneIamRoleArn;
        private string _s3OutputEncryptionKMSKey;
        private string _sagemakerIamRoleArn;
        private List<string> _securityGroupIds = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private List<string> _subnets = AWSConfigs.InitializeCollections ? new List<string>() : null;
        private string _trainingJobName;
        private string _volumeEncryptionKMSKey;

        /// <summary>
        /// Gets and sets the property BaseProcessingInstanceType. 
        /// <para>
        /// The type of ML instance used in preparing and managing training of ML models. This
        /// is an ML compute instance chosen based on memory requirements for processing the training
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
        /// Gets and sets the property BaseProcessingInstanceVolumeSizeInGB. 
        /// <para>
        /// The disk volume size of the training instance in gigabytes. The default is 0. Both
        /// input data and the output model are stored on disk, so the volume size must be large
        /// enough to hold both data sets. If not specified or 0, Neptune ML selects a disk volume
        /// size based on the recommendation generated in the data processing step.
        /// </para>
        /// </summary>
        public int? BaseProcessingInstanceVolumeSizeInGB
        {
            get { return this._baseProcessingInstanceVolumeSizeInGB; }
            set { this._baseProcessingInstanceVolumeSizeInGB = value; }
        }

        // Check to see if BaseProcessingInstanceVolumeSizeInGB property is set
        internal bool IsSetBaseProcessingInstanceVolumeSizeInGB()
        {
            return this._baseProcessingInstanceVolumeSizeInGB.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property CustomModelTransformParameters. 
        /// <para>
        /// Configuration information for a model transform using a custom model. The <c>customModelTransformParameters</c>
        /// object contains the following fields, which must have values compatible with the saved
        /// model parameters from the training job:
        /// </para>
        /// </summary>
        public CustomModelTransformParameters CustomModelTransformParameters
        {
            get { return this._customModelTransformParameters; }
            set { this._customModelTransformParameters = value; }
        }

        // Check to see if CustomModelTransformParameters property is set
        internal bool IsSetCustomModelTransformParameters()
        {
            return this._customModelTransformParameters != null;
        }

        /// <summary>
        /// Gets and sets the property DataProcessingJobId. 
        /// <para>
        /// The job ID of a completed data-processing job. You must include either <c>dataProcessingJobId</c>
        /// and a <c>mlModelTrainingJobId</c>, or a <c>trainingJobName</c>.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property Id. 
        /// <para>
        /// A unique identifier for the new job. The default is an autogenerated UUID.
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
        /// Gets and sets the property MlModelTrainingJobId. 
        /// <para>
        /// The job ID of a completed model-training job. You must include either <c>dataProcessingJobId</c>
        /// and a <c>mlModelTrainingJobId</c>, or a <c>trainingJobName</c>.
        /// </para>
        /// </summary>
        public string MlModelTrainingJobId
        {
            get { return this._mlModelTrainingJobId; }
            set { this._mlModelTrainingJobId = value; }
        }

        // Check to see if MlModelTrainingJobId property is set
        internal bool IsSetMlModelTrainingJobId()
        {
            return this._mlModelTrainingJobId != null;
        }

        /// <summary>
        /// Gets and sets the property ModelTransformOutputS3Location. 
        /// <para>
        /// The location in Amazon S3 where the model artifacts are to be stored.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public string ModelTransformOutputS3Location
        {
            get { return this._modelTransformOutputS3Location; }
            set { this._modelTransformOutputS3Location = value; }
        }

        // Check to see if ModelTransformOutputS3Location property is set
        internal bool IsSetModelTransformOutputS3Location()
        {
            return this._modelTransformOutputS3Location != null;
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
        /// The ARN of an IAM role for SageMaker execution. This must be listed in your DB cluster
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
        /// Gets and sets the property TrainingJobName. 
        /// <para>
        /// The name of a completed SageMaker training job. You must include either <c>dataProcessingJobId</c>
        /// and a <c>mlModelTrainingJobId</c>, or a <c>trainingJobName</c>.
        /// </para>
        /// </summary>
        public string TrainingJobName
        {
            get { return this._trainingJobName; }
            set { this._trainingJobName = value; }
        }

        // Check to see if TrainingJobName property is set
        internal bool IsSetTrainingJobName()
        {
            return this._trainingJobName != null;
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