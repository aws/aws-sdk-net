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
 * Do not modify this file. This file is generated from the smithy.json service model.
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
        /// <summary>
        /// Gets and sets the property BaseModelArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the base model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 1011)]
        public string BaseModelArn { get; set; }

        /// <summary>
        /// Checks to see if the BaseModelArn property is set.
        /// </summary>
        internal bool IsSetBaseModelArn() => this.BaseModelArn != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Creation time of the model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property CustomizationConfig. 
        /// <para>
        /// The customization configuration for the custom model.
        /// </para>
        /// </summary>
        public CustomizationConfig CustomizationConfig { get; set; }

        /// <summary>
        /// Checks to see if the CustomizationConfig property is set.
        /// </summary>
        internal bool IsSetCustomizationConfig() => this.CustomizationConfig != null;

        /// <summary>
        /// Gets and sets the property CustomizationType. 
        /// <para>
        /// The type of model customization.
        /// </para>
        /// </summary>
        public CustomizationType CustomizationType { get; set; }

        /// <summary>
        /// Checks to see if the CustomizationType property is set.
        /// </summary>
        internal bool IsSetCustomizationType() => this.CustomizationType != null;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// A failure message for any issues that occurred when creating the custom model. This
        /// is included for only a failed CreateCustomModel operation.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 2048)]
        public string FailureMessage { get; set; }

        /// <summary>
        /// Checks to see if the FailureMessage property is set.
        /// </summary>
        internal bool IsSetFailureMessage() => this.FailureMessage != null;

        /// <summary>
        /// Gets and sets the property HyperParameters. 
        /// <para>
        /// Hyperparameter values associated with this model. For details on the format for different
        /// models, see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models-hp.html">Custom
        /// model hyperparameters</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public Dictionary<string, string> HyperParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the HyperParameters property is set.
        /// </summary>
        internal bool IsSetHyperParameters() => this.HyperParameters != null && (this.HyperParameters.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property JobArn. 
        /// <para>
        /// Job Amazon Resource Name (ARN) associated with this model. For models that you create
        /// with the <a href="https://docs.aws.amazon.com/bedrock/latest/APIReference/API_CreateCustomModel.html">CreateCustomModel</a>
        /// API operation, this is <c>NULL</c>.
        /// </para>
        /// </summary>
        [AWSProperty(Max = 1011)]
        public string JobArn { get; set; }

        /// <summary>
        /// Checks to see if the JobArn property is set.
        /// </summary>
        internal bool IsSetJobArn() => this.JobArn != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// Job name associated with this model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// Amazon Resource Name (ARN) associated with this model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 20, Max = 1011)]
        public string ModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelArn property is set.
        /// </summary>
        internal bool IsSetModelArn() => this.ModelArn != null;

        /// <summary>
        /// Gets and sets the property ModelKmsKeyArn. 
        /// <para>
        /// The custom model is encrypted at rest using this key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string ModelKmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelKmsKeyArn property is set.
        /// </summary>
        internal bool IsSetModelKmsKeyArn() => this.ModelKmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// Model name associated with this model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

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
        public ModelStatus ModelStatus { get; set; }

        /// <summary>
        /// Checks to see if the ModelStatus property is set.
        /// </summary>
        internal bool IsSetModelStatus() => this.ModelStatus != null;

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// Output data configuration associated with this custom model.
        /// </para>
        /// </summary>
        public OutputDataConfig OutputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputDataConfig property is set.
        /// </summary>
        internal bool IsSetOutputDataConfig() => this.OutputDataConfig != null;

        /// <summary>
        /// Gets and sets the property TrainingDataConfig. 
        /// <para>
        /// Contains information about the training dataset.
        /// </para>
        /// </summary>
        public TrainingDataConfig TrainingDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the TrainingDataConfig property is set.
        /// </summary>
        internal bool IsSetTrainingDataConfig() => this.TrainingDataConfig != null;

        /// <summary>
        /// Gets and sets the property TrainingMetrics. 
        /// <para>
        /// Contains training metrics from the job creation.
        /// </para>
        /// </summary>
        public TrainingMetrics TrainingMetrics { get; set; }

        /// <summary>
        /// Checks to see if the TrainingMetrics property is set.
        /// </summary>
        internal bool IsSetTrainingMetrics() => this.TrainingMetrics != null;

        /// <summary>
        /// Gets and sets the property ValidationDataConfig. 
        /// <para>
        /// Contains information about the validation dataset.
        /// </para>
        /// </summary>
        public ValidationDataConfig ValidationDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the ValidationDataConfig property is set.
        /// </summary>
        internal bool IsSetValidationDataConfig() => this.ValidationDataConfig != null;

        /// <summary>
        /// Gets and sets the property ValidationMetrics. 
        /// <para>
        /// The validation metrics from the job creation.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<ValidatorMetric> ValidationMetrics { get; set; } = AWSConfigs.InitializeCollections ? new List<ValidatorMetric>() : null;

        /// <summary>
        /// Checks to see if the ValidationMetrics property is set.
        /// </summary>
        internal bool IsSetValidationMetrics() => this.ValidationMetrics != null && (this.ValidationMetrics.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
