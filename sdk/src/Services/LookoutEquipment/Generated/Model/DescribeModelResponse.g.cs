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

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// This is the response object from the DescribeModel operation.
    /// </summary>
    public partial class DescribeModelResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AccumulatedInferenceDataEndTime. 
        /// <para>
        /// Indicates the end time of the inference data that has been accumulated. 
        /// </para>
        /// </summary>
        public DateTime? AccumulatedInferenceDataEndTime { get; set; }

        /// <summary>
        /// Checks to see if the AccumulatedInferenceDataEndTime property is set.
        /// </summary>
        internal bool IsSetAccumulatedInferenceDataEndTime() => this.AccumulatedInferenceDataEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property AccumulatedInferenceDataStartTime. 
        /// <para>
        /// Indicates the start time of the inference data that has been accumulated. 
        /// </para>
        /// </summary>
        public DateTime? AccumulatedInferenceDataStartTime { get; set; }

        /// <summary>
        /// Checks to see if the AccumulatedInferenceDataStartTime property is set.
        /// </summary>
        internal bool IsSetAccumulatedInferenceDataStartTime() => this.AccumulatedInferenceDataStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property ActiveModelVersion. 
        /// <para>
        /// The name of the model version used by the inference schedular when running a scheduled
        /// inference execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? ActiveModelVersion { get; set; }

        /// <summary>
        /// Checks to see if the ActiveModelVersion property is set.
        /// </summary>
        internal bool IsSetActiveModelVersion() => this.ActiveModelVersion.HasValue;

        /// <summary>
        /// Gets and sets the property ActiveModelVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model version used by the inference scheduler
        /// when running a scheduled inference execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ActiveModelVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the ActiveModelVersionArn property is set.
        /// </summary>
        internal bool IsSetActiveModelVersionArn() => this.ActiveModelVersionArn != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Indicates the time and date at which the machine learning model was created. 
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DataPreProcessingConfiguration. 
        /// <para>
        /// The configuration is the <c>TargetSamplingRate</c>, which is the sampling rate of
        /// the data after post processing by Amazon Lookout for Equipment. For example, if you
        /// provide data that has been collected at a 1 second level and you want the system to
        /// resample the data at a 1 minute rate before training, the <c>TargetSamplingRate</c>
        /// is 1 minute.
        /// </para>
        ///  
        /// <para>
        /// When providing a value for the <c>TargetSamplingRate</c>, you must attach the prefix
        /// "PT" to the rate you want. The value for a 1 second rate is therefore <i>PT1S</i>,
        /// the value for a 15 minute rate is <i>PT15M</i>, and the value for a 1 hour rate is
        /// <i>PT1H</i> 
        /// </para>
        /// </summary>
        public DataPreProcessingConfiguration DataPreProcessingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataPreProcessingConfiguration property is set.
        /// </summary>
        internal bool IsSetDataPreProcessingConfiguration() => this.DataPreProcessingConfiguration != null;

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        /// The Amazon Resouce Name (ARN) of the dataset used to create the machine learning model
        /// being described. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string DatasetArn { get; set; }

        /// <summary>
        /// Checks to see if the DatasetArn property is set.
        /// </summary>
        internal bool IsSetDatasetArn() => this.DatasetArn != null;

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// The name of the dataset being used by the machine learning being described. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string DatasetName { get; set; }

        /// <summary>
        /// Checks to see if the DatasetName property is set.
        /// </summary>
        internal bool IsSetDatasetName() => this.DatasetName != null;

        /// <summary>
        /// Gets and sets the property EvaluationDataEndTime. 
        /// <para>
        ///  Indicates the time reference in the dataset that was used to end the subset of evaluation
        /// data for the machine learning model. 
        /// </para>
        /// </summary>
        public DateTime? EvaluationDataEndTime { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationDataEndTime property is set.
        /// </summary>
        internal bool IsSetEvaluationDataEndTime() => this.EvaluationDataEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property EvaluationDataStartTime. 
        /// <para>
        ///  Indicates the time reference in the dataset that was used to begin the subset of
        /// evaluation data for the machine learning model. 
        /// </para>
        /// </summary>
        public DateTime? EvaluationDataStartTime { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationDataStartTime property is set.
        /// </summary>
        internal bool IsSetEvaluationDataStartTime() => this.EvaluationDataStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property FailedReason. 
        /// <para>
        /// If the training of the machine learning model failed, this indicates the reason for
        /// that failure. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5000)]
        public string FailedReason { get; set; }

        /// <summary>
        /// Checks to see if the FailedReason property is set.
        /// </summary>
        internal bool IsSetFailedReason() => this.FailedReason != null;

        /// <summary>
        /// Gets and sets the property ImportJobEndTime. 
        /// <para>
        /// The date and time when the import job was completed. This field appears if the active
        /// model version was imported.
        /// </para>
        /// </summary>
        public DateTime? ImportJobEndTime { get; set; }

        /// <summary>
        /// Checks to see if the ImportJobEndTime property is set.
        /// </summary>
        internal bool IsSetImportJobEndTime() => this.ImportJobEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property ImportJobStartTime. 
        /// <para>
        /// The date and time when the import job was started. This field appears if the active
        /// model version was imported.
        /// </para>
        /// </summary>
        public DateTime? ImportJobStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ImportJobStartTime property is set.
        /// </summary>
        internal bool IsSetImportJobStartTime() => this.ImportJobStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property LabelsInputConfiguration. 
        /// <para>
        /// Specifies configuration information about the labels input, including its S3 location.
        /// 
        /// </para>
        /// </summary>
        public LabelsInputConfiguration LabelsInputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LabelsInputConfiguration property is set.
        /// </summary>
        internal bool IsSetLabelsInputConfiguration() => this.LabelsInputConfiguration != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// Indicates the last time the machine learning model was updated. The type of update
        /// is not specified. 
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property LatestScheduledRetrainingAvailableDataInDays. 
        /// <para>
        /// Indicates the number of days of data used in the most recent scheduled retraining
        /// run. 
        /// </para>
        /// </summary>
        public int? LatestScheduledRetrainingAvailableDataInDays { get; set; }

        /// <summary>
        /// Checks to see if the LatestScheduledRetrainingAvailableDataInDays property is set.
        /// </summary>
        internal bool IsSetLatestScheduledRetrainingAvailableDataInDays() => this.LatestScheduledRetrainingAvailableDataInDays.HasValue;

        /// <summary>
        /// Gets and sets the property LatestScheduledRetrainingFailedReason. 
        /// <para>
        /// If the model version was generated by retraining and the training failed, this indicates
        /// the reason for that failure. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 5000)]
        public string LatestScheduledRetrainingFailedReason { get; set; }

        /// <summary>
        /// Checks to see if the LatestScheduledRetrainingFailedReason property is set.
        /// </summary>
        internal bool IsSetLatestScheduledRetrainingFailedReason() => this.LatestScheduledRetrainingFailedReason != null;

        /// <summary>
        /// Gets and sets the property LatestScheduledRetrainingModelVersion. 
        /// <para>
        /// Indicates the most recent model version that was generated by retraining. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? LatestScheduledRetrainingModelVersion { get; set; }

        /// <summary>
        /// Checks to see if the LatestScheduledRetrainingModelVersion property is set.
        /// </summary>
        internal bool IsSetLatestScheduledRetrainingModelVersion() => this.LatestScheduledRetrainingModelVersion.HasValue;

        /// <summary>
        /// Gets and sets the property LatestScheduledRetrainingStartTime. 
        /// <para>
        /// Indicates the start time of the most recent scheduled retraining run. 
        /// </para>
        /// </summary>
        public DateTime? LatestScheduledRetrainingStartTime { get; set; }

        /// <summary>
        /// Checks to see if the LatestScheduledRetrainingStartTime property is set.
        /// </summary>
        internal bool IsSetLatestScheduledRetrainingStartTime() => this.LatestScheduledRetrainingStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property LatestScheduledRetrainingStatus. 
        /// <para>
        /// Indicates the status of the most recent scheduled retraining run. 
        /// </para>
        /// </summary>
        public ModelVersionStatus LatestScheduledRetrainingStatus { get; set; }

        /// <summary>
        /// Checks to see if the LatestScheduledRetrainingStatus property is set.
        /// </summary>
        internal bool IsSetLatestScheduledRetrainingStatus() => this.LatestScheduledRetrainingStatus != null;

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the machine learning model being described. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ModelArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelArn property is set.
        /// </summary>
        internal bool IsSetModelArn() => this.ModelArn != null;

        /// <summary>
        /// Gets and sets the property ModelDiagnosticsOutputConfiguration. 
        /// <para>
        /// Configuration information for the model's pointwise model diagnostics.
        /// </para>
        /// </summary>
        public ModelDiagnosticsOutputConfiguration ModelDiagnosticsOutputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ModelDiagnosticsOutputConfiguration property is set.
        /// </summary>
        internal bool IsSetModelDiagnosticsOutputConfiguration() => this.ModelDiagnosticsOutputConfiguration != null;

        /// <summary>
        /// Gets and sets the property ModelMetrics. 
        /// <para>
        /// The Model Metrics show an aggregated summary of the model's performance within the
        /// evaluation time range. This is the JSON content of the metrics created when evaluating
        /// the model. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50000)]
        public string ModelMetrics { get; set; }

        /// <summary>
        /// Checks to see if the ModelMetrics property is set.
        /// </summary>
        internal bool IsSetModelMetrics() => this.ModelMetrics != null;

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the machine learning model being described. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 200)]
        public string ModelName { get; set; }

        /// <summary>
        /// Checks to see if the ModelName property is set.
        /// </summary>
        internal bool IsSetModelName() => this.ModelName != null;

        /// <summary>
        /// Gets and sets the property ModelQuality. 
        /// <para>
        /// Provides a quality assessment for a model that uses labels. If Lookout for Equipment
        /// determines that the model quality is poor based on training metrics, the value is
        /// <c>POOR_QUALITY_DETECTED</c>. Otherwise, the value is <c>QUALITY_THRESHOLD_MET</c>.
        /// </para>
        ///  
        /// <para>
        /// If the model is unlabeled, the model quality can't be assessed and the value of <c>ModelQuality</c>
        /// is <c>CANNOT_DETERMINE_QUALITY</c>. In this situation, you can get a model quality
        /// assessment by adding labels to the input dataset and retraining the model.
        /// </para>
        ///  
        /// <para>
        /// For information about using labels with your models, see <a href="https://docs.aws.amazon.com/lookout-for-equipment/latest/ug/understanding-labeling.html">Understanding
        /// labeling</a>.
        /// </para>
        ///  
        /// <para>
        /// For information about improving the quality of a model, see <a href="https://docs.aws.amazon.com/lookout-for-equipment/latest/ug/best-practices.html">Best
        /// practices with Amazon Lookout for Equipment</a>.
        /// </para>
        /// </summary>
        public ModelQuality ModelQuality { get; set; }

        /// <summary>
        /// Checks to see if the ModelQuality property is set.
        /// </summary>
        internal bool IsSetModelQuality() => this.ModelQuality != null;

        /// <summary>
        /// Gets and sets the property ModelVersionActivatedAt. 
        /// <para>
        /// The date the active model version was activated.
        /// </para>
        /// </summary>
        public DateTime? ModelVersionActivatedAt { get; set; }

        /// <summary>
        /// Checks to see if the ModelVersionActivatedAt property is set.
        /// </summary>
        internal bool IsSetModelVersionActivatedAt() => this.ModelVersionActivatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property NextScheduledRetrainingStartDate. 
        /// <para>
        /// Indicates the date and time that the next scheduled retraining run will start on.
        /// Lookout for Equipment truncates the time you provide to the nearest UTC day.
        /// </para>
        /// </summary>
        public DateTime? NextScheduledRetrainingStartDate { get; set; }

        /// <summary>
        /// Checks to see if the NextScheduledRetrainingStartDate property is set.
        /// </summary>
        internal bool IsSetNextScheduledRetrainingStartDate() => this.NextScheduledRetrainingStartDate.HasValue;

        /// <summary>
        /// Gets and sets the property OffCondition. 
        /// <para>
        /// Indicates that the asset associated with this sensor has been shut off. As long as
        /// this condition is met, Lookout for Equipment will not use data from this asset for
        /// training, evaluation, or inference.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 2048)]
        public string OffCondition { get; set; }

        /// <summary>
        /// Checks to see if the OffCondition property is set.
        /// </summary>
        internal bool IsSetOffCondition() => this.OffCondition != null;

        /// <summary>
        /// Gets and sets the property PreviousActiveModelVersion. 
        /// <para>
        /// The model version that was set as the active model version prior to the current active
        /// model version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? PreviousActiveModelVersion { get; set; }

        /// <summary>
        /// Checks to see if the PreviousActiveModelVersion property is set.
        /// </summary>
        internal bool IsSetPreviousActiveModelVersion() => this.PreviousActiveModelVersion.HasValue;

        /// <summary>
        /// Gets and sets the property PreviousActiveModelVersionArn. 
        /// <para>
        /// The ARN of the model version that was set as the active model version prior to the
        /// current active model version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string PreviousActiveModelVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the PreviousActiveModelVersionArn property is set.
        /// </summary>
        internal bool IsSetPreviousActiveModelVersionArn() => this.PreviousActiveModelVersionArn != null;

        /// <summary>
        /// Gets and sets the property PreviousModelVersionActivatedAt. 
        /// <para>
        /// The date and time when the previous active model version was activated.
        /// </para>
        /// </summary>
        public DateTime? PreviousModelVersionActivatedAt { get; set; }

        /// <summary>
        /// Checks to see if the PreviousModelVersionActivatedAt property is set.
        /// </summary>
        internal bool IsSetPreviousModelVersionActivatedAt() => this.PreviousModelVersionActivatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property PriorModelMetrics. 
        /// <para>
        /// If the model version was retrained, this field shows a summary of the performance
        /// of the prior model on the new training range. You can use the information in this
        /// JSON-formatted object to compare the new model version and the prior model version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 50000)]
        public string PriorModelMetrics { get; set; }

        /// <summary>
        /// Checks to see if the PriorModelMetrics property is set.
        /// </summary>
        internal bool IsSetPriorModelMetrics() => this.PriorModelMetrics != null;

        /// <summary>
        /// Gets and sets the property RetrainingSchedulerStatus. 
        /// <para>
        /// Indicates the status of the retraining scheduler. 
        /// </para>
        /// </summary>
        public RetrainingSchedulerStatus RetrainingSchedulerStatus { get; set; }

        /// <summary>
        /// Checks to see if the RetrainingSchedulerStatus property is set.
        /// </summary>
        internal bool IsSetRetrainingSchedulerStatus() => this.RetrainingSchedulerStatus != null;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of a role with permission to access the data source
        /// for the machine learning model being described. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string RoleArn { get; set; }

        /// <summary>
        /// Checks to see if the RoleArn property is set.
        /// </summary>
        internal bool IsSetRoleArn() => this.RoleArn != null;

        /// <summary>
        /// Gets and sets the property Schema. 
        /// <para>
        /// A JSON description of the data that is in each time series dataset, including names,
        /// column names, and data types. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1000000)]
        public string Schema { get; set; }

        /// <summary>
        /// Checks to see if the Schema property is set.
        /// </summary>
        internal bool IsSetSchema() => this.Schema != null;

        /// <summary>
        /// Gets and sets the property ServerSideKmsKeyId. 
        /// <para>
        /// Provides the identifier of the KMS key used to encrypt model data by Amazon Lookout
        /// for Equipment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 1024)]
        public string ServerSideKmsKeyId { get; set; }

        /// <summary>
        /// Checks to see if the ServerSideKmsKeyId property is set.
        /// </summary>
        internal bool IsSetServerSideKmsKeyId() => this.ServerSideKmsKeyId != null;

        /// <summary>
        /// Gets and sets the property SourceModelVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the source model version. This field appears if
        /// the active model version was imported.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string SourceModelVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceModelVersionArn property is set.
        /// </summary>
        internal bool IsSetSourceModelVersionArn() => this.SourceModelVersionArn != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies the current status of the model being described. Status describes the status
        /// of the most recent action of the model. 
        /// </para>
        /// </summary>
        public ModelStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TrainingDataEndTime. 
        /// <para>
        ///  Indicates the time reference in the dataset that was used to end the subset of training
        /// data for the machine learning model. 
        /// </para>
        /// </summary>
        public DateTime? TrainingDataEndTime { get; set; }

        /// <summary>
        /// Checks to see if the TrainingDataEndTime property is set.
        /// </summary>
        internal bool IsSetTrainingDataEndTime() => this.TrainingDataEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property TrainingDataStartTime. 
        /// <para>
        ///  Indicates the time reference in the dataset that was used to begin the subset of
        /// training data for the machine learning model. 
        /// </para>
        /// </summary>
        public DateTime? TrainingDataStartTime { get; set; }

        /// <summary>
        /// Checks to see if the TrainingDataStartTime property is set.
        /// </summary>
        internal bool IsSetTrainingDataStartTime() => this.TrainingDataStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property TrainingExecutionEndTime. 
        /// <para>
        /// Indicates the time at which the training of the machine learning model was completed.
        /// 
        /// </para>
        /// </summary>
        public DateTime? TrainingExecutionEndTime { get; set; }

        /// <summary>
        /// Checks to see if the TrainingExecutionEndTime property is set.
        /// </summary>
        internal bool IsSetTrainingExecutionEndTime() => this.TrainingExecutionEndTime.HasValue;

        /// <summary>
        /// Gets and sets the property TrainingExecutionStartTime. 
        /// <para>
        /// Indicates the time at which the training of the machine learning model began. 
        /// </para>
        /// </summary>
        public DateTime? TrainingExecutionStartTime { get; set; }

        /// <summary>
        /// Checks to see if the TrainingExecutionStartTime property is set.
        /// </summary>
        internal bool IsSetTrainingExecutionStartTime() => this.TrainingExecutionStartTime.HasValue;
    }
}
