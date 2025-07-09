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
    /// This is the response object from the GetCustomModel operation.
    /// </summary>
    public partial class GetCustomModelResponse : AmazonWebServiceResponse
    {
        private string _baseModelArn;
        private DateTime? _creationTime;
        private CustomizationConfig _customizationConfig;
        private CustomizationType _customizationType;
        private string _failureMessage;
        private Dictionary<string, string> _hyperParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _jobArn;
        private string _jobName;
        private string _modelArn;
        private string _modelKmsKeyArn;
        private string _modelName;
        private ModelStatus _modelStatus;
        private OutputDataConfig _outputDataConfig;
        private TrainingDataConfig _trainingDataConfig;
        private TrainingMetrics _trainingMetrics;
        private ValidationDataConfig _validationDataConfig;
        private List<ValidatorMetric> _validationMetrics = AWSConfigs.InitializeCollections ? new List<ValidatorMetric>() : null;

        /// <summary>
        /// Gets and sets the property BaseModelArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the base model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=1011)]
        public string BaseModelArn
        {
            get { return this._baseModelArn; }
            set { this._baseModelArn = value; }
        }

        // Check to see if BaseModelArn property is set
        internal bool IsSetBaseModelArn()
        {
            return this._baseModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Creation time of the model.
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
        /// Gets and sets the property CustomizationConfig. 
        /// <para>
        /// The customization configuration for the custom model.
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
        /// The type of model customization.
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
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// A failure message for any issues that occurred when creating the custom model. This
        /// is included for only a failed CreateCustomModel operation.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=2048)]
        public string FailureMessage
        {
            get { return this._failureMessage; }
            set { this._failureMessage = value; }
        }

        // Check to see if FailureMessage property is set
        internal bool IsSetFailureMessage()
        {
            return this._failureMessage != null;
        }

        /// <summary>
        /// Gets and sets the property HyperParameters. 
        /// <para>
        /// Hyperparameter values associated with this model. For details on the format for different
        /// models, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models-hp.html">Custom
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
        /// Gets and sets the property JobArn. 
        /// <para>
        /// Job Amazon Resource Name (ARN) associated with this model. For models that you create
        /// with the <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_CreateCustomModel.html">CreateCustomModel</a>
        /// API operation, this is <c>NULL</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1011)]
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
        /// Job name associated with this model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
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
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// Amazon Resource Name (ARN) associated with this model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1011)]
        public string ModelArn
        {
            get { return this._modelArn; }
            set { this._modelArn = value; }
        }

        // Check to see if ModelArn property is set
        internal bool IsSetModelArn()
        {
            return this._modelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ModelKmsKeyArn. 
        /// <para>
        /// The custom model is encrypted at rest using this key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string ModelKmsKeyArn
        {
            get { return this._modelKmsKeyArn; }
            set { this._modelKmsKeyArn = value; }
        }

        // Check to see if ModelKmsKeyArn property is set
        internal bool IsSetModelKmsKeyArn()
        {
            return this._modelKmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// Model name associated with this model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

        /// <summary>
        /// Gets and sets the property ModelStatus. 
        /// <para>
        /// The current status of the custom model. Possible values include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>Creating</c> - The model is being created and validated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Active</c> - The model has been successfully created and is ready for use.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>Failed</c> - The model creation process failed. Check the <c>failureMessage</c>
        /// field for details.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public ModelStatus ModelStatus
        {
            get { return this._modelStatus; }
            set { this._modelStatus = value; }
        }

        // Check to see if ModelStatus property is set
        internal bool IsSetModelStatus()
        {
            return this._modelStatus != null;
        }

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// Output data configuration associated with this custom model.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TrainingDataConfig. 
        /// <para>
        /// Contains information about the training dataset.
        /// </para>
        /// </summary>
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
        /// Gets and sets the property TrainingMetrics. 
        /// <para>
        /// Contains training metrics from the job creation.
        /// </para>
        /// </summary>
        public TrainingMetrics TrainingMetrics
        {
            get { return this._trainingMetrics; }
            set { this._trainingMetrics = value; }
        }

        // Check to see if TrainingMetrics property is set
        internal bool IsSetTrainingMetrics()
        {
            return this._trainingMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationDataConfig. 
        /// <para>
        /// Contains information about the validation dataset.
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
        /// Gets and sets the property ValidationMetrics. 
        /// <para>
        /// The validation metrics from the job creation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ValidatorMetric> ValidationMetrics
        {
            get { return this._validationMetrics; }
            set { this._validationMetrics = value; }
        }

        // Check to see if ValidationMetrics property is set
        internal bool IsSetValidationMetrics()
        {
            return this._validationMetrics != null && (this._validationMetrics.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

    }
}