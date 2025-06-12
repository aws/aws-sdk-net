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
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
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
namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// Container for the parameters to the CreateModelCustomizationJob operation.
    /// Creates a fine-tuning job to customize a base model.
    /// 
    ///  
    /// <para>
    /// You specify the base foundation model and the location of the training data. After
    /// the model-customization job completes successfully, your custom model resource will
    /// be ready to use. Amazon Bedrock returns validation loss metrics and output generations
    /// after the job completes. 
    /// </para>
    ///  
    /// <para>
    /// For information on the format of training and validation data, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/model-customization-prepare.html">Prepare
    /// the datasets</a>.
    /// </para>
    ///  
    /// <para>
    ///  Model-customization jobs are asynchronous and the completion time depends on the
    /// base model and the training/validation data size. To monitor a job, use the <c>GetModelCustomizationJob</c>
    /// operation to retrieve the job status.
    /// </para>
    ///  
    /// <para>
    /// For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models.html">Custom
    /// models</a> in the <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/what-is-service.html">Amazon
    /// Bedrock User Guide</a>.
    /// </para>
    /// </summary>
    public partial class CreateModelCustomizationJobRequest : AmazonBedrockRequest
    {
        private string _baseModelIdentifier;
        private string _clientRequestToken;
        private CustomizationConfig _customizationConfig;
        private CustomizationType _customizationType;
        private string _customModelKmsKeyId;
        private string _customModelName;
        private List<Tag> _customModelTags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private Dictionary<string, string> _hyperParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _jobName;
        private List<Tag> _jobTags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private OutputDataConfig _outputDataConfig;
        private string _roleArn;
        private TrainingDataConfig _trainingDataConfig;
        private ValidationDataConfig _validationDataConfig;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property BaseModelIdentifier. 
        /// <para>
        /// Name of the base model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string BaseModelIdentifier
        {
            get { return this._baseModelIdentifier; }
            set { this._baseModelIdentifier = value; }
        }

        // Check to see if BaseModelIdentifier property is set
        internal bool IsSetBaseModelIdentifier()
        {
            return this._baseModelIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// A unique, case-sensitive identifier to ensure that the API request completes no more
        /// than one time. If this token matches a previous request, Amazon Bedrock ignores the
        /// request, but does not return an error. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/Run_Instance_Idempotency.html">Ensuring
        /// idempotency</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property CustomizationConfig. 
        /// <para>
        /// The customization configuration for the model customization job.
        /// </para>
        /// </summary>
        public CustomizationConfig CustomizationConfig
        {
            get { return this._customizationConfig; }
            set { this._customizationConfig = value; }
        }

        // Check to see if CustomizationConfig property is set
        internal bool IsSetCustomizationConfig()
        {
            return this._customizationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CustomizationType. 
        /// <para>
        /// The customization type.
        /// </para>
        /// </summary>
        public CustomizationType CustomizationType
        {
            get { return this._customizationType; }
            set { this._customizationType = value; }
        }

        // Check to see if CustomizationType property is set
        internal bool IsSetCustomizationType()
        {
            return this._customizationType != null;
        }

        /// <summary>
        /// Gets and sets the property CustomModelKmsKeyId. 
        /// <para>
        /// The custom model is encrypted at rest using this key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string CustomModelKmsKeyId
        {
            get { return this._customModelKmsKeyId; }
            set { this._customModelKmsKeyId = value; }
        }

        // Check to see if CustomModelKmsKeyId property is set
        internal bool IsSetCustomModelKmsKeyId()
        {
            return this._customModelKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property CustomModelName. 
        /// <para>
        /// A name for the resulting custom model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string CustomModelName
        {
            get { return this._customModelName; }
            set { this._customModelName = value; }
        }

        // Check to see if CustomModelName property is set
        internal bool IsSetCustomModelName()
        {
            return this._customModelName != null;
        }

        /// <summary>
        /// Gets and sets the property CustomModelTags. 
        /// <para>
        /// Tags to attach to the resulting custom model.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> CustomModelTags
        {
            get { return this._customModelTags; }
            set { this._customModelTags = value; }
        }

        // Check to see if CustomModelTags property is set
        internal bool IsSetCustomModelTags()
        {
            return this._customModelTags != null && (this._customModelTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property HyperParameters. 
        /// <para>
        /// Parameters related to tuning the model. For details on the format for different models,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models-hp.html">Custom
        /// model hyperparameters</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
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
        /// Gets and sets the property JobName. 
        /// <para>
        /// A name for the fine-tuning job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Gets and sets the property JobTags. 
        /// <para>
        /// Tags to attach to the job.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> JobTags
        {
            get { return this._jobTags; }
            set { this._jobTags = value; }
        }

        // Check to see if JobTags property is set
        internal bool IsSetJobTags()
        {
            return this._jobTags != null && (this._jobTags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// S3 location for the output data.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputDataConfig OutputDataConfig
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
        /// The Amazon Resource Name (ARN) of an IAM service role that Amazon Bedrock can assume
        /// to perform tasks on your behalf. For example, during model training, Amazon Bedrock
        /// needs your permission to read input data from an S3 bucket, write model artifacts
        /// to an S3 bucket. To pass this role to Amazon Bedrock, the caller of this API must
        /// have the <c>iam:PassRole</c> permission. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
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
        /// Gets and sets the property TrainingDataConfig. 
        /// <para>
        /// Information about the training dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
        public TrainingDataConfig TrainingDataConfig
        {
            get { return this._trainingDataConfig; }
            set { this._trainingDataConfig = value; }
        }

        // Check to see if TrainingDataConfig property is set
        internal bool IsSetTrainingDataConfig()
        {
            return this._trainingDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationDataConfig. 
        /// <para>
        /// Information about the validation dataset. 
        /// </para>
        /// </summary>
        public ValidationDataConfig ValidationDataConfig
        {
            get { return this._validationDataConfig; }
            set { this._validationDataConfig = value; }
        }

        // Check to see if ValidationDataConfig property is set
        internal bool IsSetValidationDataConfig()
        {
            return this._validationDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// The configuration of the Virtual Private Cloud (VPC) that contains the resources that
        /// you're using for this job. For more information, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/vpc-model-customization.html">Protect
        /// your model customization jobs using a VPC</a>.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig
        {
            get { return this._vpcConfig; }
            set { this._vpcConfig = value; }
        }

        // Check to see if VpcConfig property is set
        internal bool IsSetVpcConfig()
        {
            return this._vpcConfig != null;
        }

    }
}