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
    /// This is the response object from the GetModelCustomizationJob operation.
    /// </summary>
    public partial class GetModelCustomizationJobResponse : AmazonWebServiceResponse
    {
        private string _baseModelArn;
        private string _clientRequestToken;
        private DateTime? _creationTime;
        private CustomizationConfig _customizationConfig;
        private CustomizationType _customizationType;
        private DateTime? _endTime;
        private string _failureMessage;
        private Dictionary<string, string> _hyperParameters = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;
        private string _jobArn;
        private string _jobName;
        private DateTime? _lastModifiedTime;
        private OutputDataConfig _outputDataConfig;
        private string _outputModelArn;
        private string _outputModelKmsKeyArn;
        private string _outputModelName;
        private string _roleArn;
        private ModelCustomizationJobStatus _status;
        private StatusDetails _statusDetails;
        private TrainingDataConfig _trainingDataConfig;
        private TrainingMetrics _trainingMetrics;
        private ValidationDataConfig _validationDataConfig;
        private List<ValidatorMetric> _validationMetrics = AWSConfigs.InitializeCollections ? new List<ValidatorMetric>() : null;
        private VpcConfig _vpcConfig;

        /// <summary>
        /// Gets and sets the property BaseModelArn. 
        /// <para>
        /// Amazon Resource Name (ARN) of the base model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property ClientRequestToken. 
        /// <para>
        /// The token that you specified in the <c>CreateCustomizationJob</c> request.
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
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// Time that the resource was created.
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
        /// Gets and sets the property EndTime. 
        /// <para>
        /// Time that the resource transitioned to terminal state.
        /// </para>
        /// </summary>
        public DateTime? EndTime
        {
            get { return this._endTime; }
            set { this._endTime = value; }
        }

        // Check to see if EndTime property is set
        internal bool IsSetEndTime()
        {
            return this._endTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailureMessage. 
        /// <para>
        /// Information about why the job failed.
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
        /// The hyperparameter values for the job. For details on the format for different models,
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
        /// Gets and sets the property JobArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the customization job.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1011)]
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
        /// The name of the customization job.
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
        /// Gets and sets the property LastModifiedTime. 
        /// <para>
        /// Time that the resource was last modified.
        /// </para>
        /// </summary>
        public DateTime? LastModifiedTime
        {
            get { return this._lastModifiedTime; }
            set { this._lastModifiedTime = value; }
        }

        // Check to see if LastModifiedTime property is set
        internal bool IsSetLastModifiedTime()
        {
            return this._lastModifiedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OutputDataConfig. 
        /// <para>
        /// Output data configuration 
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
        /// Gets and sets the property OutputModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the output model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=1011)]
        public string OutputModelArn
        {
            get { return this._outputModelArn; }
            set { this._outputModelArn = value; }
        }

        // Check to see if OutputModelArn property is set
        internal bool IsSetOutputModelArn()
        {
            return this._outputModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property OutputModelKmsKeyArn. 
        /// <para>
        /// The custom model is encrypted at rest using this key.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string OutputModelKmsKeyArn
        {
            get { return this._outputModelKmsKeyArn; }
            set { this._outputModelKmsKeyArn = value; }
        }

        // Check to see if OutputModelKmsKeyArn property is set
        internal bool IsSetOutputModelKmsKeyArn()
        {
            return this._outputModelKmsKeyArn != null;
        }

        /// <summary>
        /// Gets and sets the property OutputModelName. 
        /// <para>
        /// The name of the output model.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string OutputModelName
        {
            get { return this._outputModelName; }
            set { this._outputModelName = value; }
        }

        // Check to see if OutputModelName property is set
        internal bool IsSetOutputModelName()
        {
            return this._outputModelName != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the IAM role.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the job. A successful job transitions from in-progress to completed
        /// when the output model is ready to use. If the job failed, the failure message contains
        /// information about why the job failed.
        /// </para>
        /// </summary>
        public ModelCustomizationJobStatus Status
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
        /// Gets and sets the property StatusDetails. 
        /// <para>
        /// For a Distillation job, the details about the statuses of the sub-tasks of the customization
        /// job. 
        /// </para>
        /// </summary>
        public StatusDetails StatusDetails
        {
            get { return this._statusDetails; }
            set { this._statusDetails = value; }
        }

        // Check to see if StatusDetails property is set
        internal bool IsSetStatusDetails()
        {
            return this._statusDetails != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingDataConfig. 
        /// <para>
        /// Contains information about the training dataset.
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
        [AWSProperty(Required=true)]
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
        /// The loss metric for each validator that you provided in the createjob request.
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

        /// <summary>
        /// Gets and sets the property VpcConfig. 
        /// <para>
        /// VPC configuration for the custom model job.
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