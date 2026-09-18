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
    /// This is the response object from the GetModelCustomizationJob operation.
    /// </summary>
    public partial class GetModelCustomizationJobResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property BaseModelArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the base model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public string BaseModelArn { get; set; }

        /// <summary>
        /// Checks to see if the BaseModelArn property is set.
        /// </summary>
        internal bool IsSetBaseModelArn() => this.BaseModelArn != null;

        /// <summary>
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The token that you specified in the <c>CreateCustomizationJob</c> request.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string ClientRequestToken { get; set; }

        /// <summary>
        /// Checks to see if the ClientRequestToken property is set.
        /// </summary>
        internal bool IsSetClientRequestToken() => this.ClientRequestToken != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Time that the resource was created.
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
        /// The customization configuration for the model customization job.
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
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Time that the resource transitioned to terminal state.
        /// </para>
        /// </summary>
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// Checks to see if the EndTime property is set.
        /// </summary>
        internal bool IsSetEndTime() => this.EndTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// Information about why the job failed.
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
        /// The hyperparameter values for the job. For details on the format for different models,
        /// see <a href="https://docs.aws.amazon.com/bedrock/latest/userguide/custom-models-hp.html">Custom
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
        /// The Amazon Resource Name (ARN) of the customization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 1011)]
        public string JobArn { get; set; }

        /// <summary>
        /// Checks to see if the JobArn property is set.
        /// </summary>
        internal bool IsSetJobArn() => this.JobArn != null;

        /// <summary>
        /// Gets and sets the property JobName. 
        /// <para>
        /// The name of the customization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string JobName { get; set; }

        /// <summary>
        /// Checks to see if the JobName property is set.
        /// </summary>
        internal bool IsSetJobName() => this.JobName != null;

        /// <summary>
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// Time that the resource was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModifiedTime property is set.
        /// </summary>
        internal bool IsSetLastModifiedTime() => this.LastModifiedTime.HasValue;

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// Output data configuration 
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
        public OutputDataConfig OutputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the OutputDataConfig property is set.
        /// </summary>
        internal bool IsSetOutputDataConfig() => this.OutputDataConfig != null;

        /// <summary>
        /// Gets and sets the property OutputModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the output model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 1011)]
        public string OutputModelArn { get; set; }

        /// <summary>
        /// Checks to see if the OutputModelArn property is set.
        /// </summary>
        internal bool IsSetOutputModelArn() => this.OutputModelArn != null;

        /// <summary>
        /// Gets and sets the property OutputModelKmsKeyArn. 
        /// <para>
        /// The custom model is encrypted at rest using this key.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string OutputModelKmsKeyArn { get; set; }

        /// <summary>
        /// Checks to see if the OutputModelKmsKeyArn property is set.
        /// </summary>
        internal bool IsSetOutputModelKmsKeyArn() => this.OutputModelKmsKeyArn != null;

        /// <summary>
        /// Gets and sets the property OutputModelName. 
        /// <para>
        /// The name of the output model.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Min = 1, Max = 63)]
        public string OutputModelName { get; set; }

        /// <summary>
        /// Checks to see if the OutputModelName property is set.
        /// </summary>
        internal bool IsSetOutputModelName() => this.OutputModelName != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the job. A successful job transitions from in-progress to completed
        /// when the output model is ready to use. If the job failed, the failure message contains
        /// information about why the job failed.
        /// </para>
        /// </summary>
        public ModelCustomizationJobStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// For a Distillation job, the details about the statuses of the sub-tasks of the customization
        /// job. 
        /// </para>
        /// </summary>
        public StatusDetails StatusDetails { get; set; }

        /// <summary>
        /// Checks to see if the StatusDetails property is set.
        /// </summary>
        internal bool IsSetStatusDetails() => this.StatusDetails != null;

        /// <summary>
        /// Gets and sets the property TrainingDataConfig. 
        /// <para>
        /// Contains information about the training dataset.
        /// </para>
        /// </summary>
        [AWSProperty(Required = true)]
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
        [AWSProperty(Required = true)]
        public ValidationDataConfig ValidationDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the ValidationDataConfig property is set.
        /// </summary>
        internal bool IsSetValidationDataConfig() => this.ValidationDataConfig != null;

        /// <summary>
        /// Gets and sets the property ValidationMetrics. 
        /// <para>
        /// The loss metric for each validator that you provided in the createjob request.
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

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// VPC configuration for the custom model job.
        /// </para>
        /// </summary>
        public VpcConfig VpcConfig { get; set; }

        /// <summary>
        /// Checks to see if the VpcConfig property is set.
        /// </summary>
        internal bool IsSetVpcConfig() => this.VpcConfig != null;
    }
}
