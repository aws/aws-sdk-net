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
    /// This is the response object from the DescribeModelVersion operation.
    /// </summary>
    public partial class DescribeModelVersionResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AutoPromotionResult. 
        /// <para>
        /// Indicates whether the model version was promoted to be the active version after retraining
        /// or if there was an error with or cancellation of the retraining. 
        /// </para>
        /// </summary>
        public AutoPromotionResult AutoPromotionResult { get; set; }

        /// <summary>
        /// Checks to see if the AutoPromotionResult property is set.
        /// </summary>
        internal bool IsSetAutoPromotionResult() => this.AutoPromotionResult != null;

        /// <summary>
        /// Gets and sets the property AutoPromotionResultReason. 
        /// <para>
        /// Indicates the reason for the <c>AutoPromotionResult</c>. For example, a model might
        /// not be promoted if its performance was worse than the active version, if there was
        /// an error during training, or if the retraining scheduler was using <c>MANUAL</c> promote
        /// mode. The model will be promoted in <c>MANAGED</c> promote mode if the performance
        /// is better than the previous model. 
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 256)]
        public string AutoPromotionResultReason { get; set; }

        /// <summary>
        /// Checks to see if the AutoPromotionResultReason property is set.
        /// </summary>
        internal bool IsSetAutoPromotionResultReason() => this.AutoPromotionResultReason != null;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Indicates the time and date at which the machine learning model version was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Checks to see if the CreatedAt property is set.
        /// </summary>
        internal bool IsSetCreatedAt() => this.CreatedAt.HasValue;

        /// <summary>
        /// Gets and sets the property DataPreProcessingConfiguration.
        /// </summary>
        public DataPreProcessingConfiguration DataPreProcessingConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the DataPreProcessingConfiguration property is set.
        /// </summary>
        internal bool IsSetDataPreProcessingConfiguration() => this.DataPreProcessingConfiguration != null;

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset used to train the model version.
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
        /// The name of the dataset used to train the model version.
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
        /// The date on which the data in the evaluation set began being gathered. If you imported
        /// the version, this is the date that the evaluation set data in the source version finished
        /// being gathered.
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
        /// The date on which the data in the evaluation set began being gathered. If you imported
        /// the version, this is the date that the evaluation set data in the source version began
        /// being gathered.
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
        /// The failure message if the training of the model version failed.
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
        /// The date and time when the import job completed. This field appears if the model version
        /// was imported.
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
        /// The date and time when the import job began. This field appears if the model version
        /// was imported.
        /// </para>
        /// </summary>
        public DateTime? ImportJobStartTime { get; set; }

        /// <summary>
        /// Checks to see if the ImportJobStartTime property is set.
        /// </summary>
        internal bool IsSetImportJobStartTime() => this.ImportJobStartTime.HasValue;

        /// <summary>
        /// Gets and sets the property ImportedDataSizeInBytes. 
        /// <para>
        /// The size in bytes of the imported data. This field appears if the model version was
        /// imported.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0)]
        public long? ImportedDataSizeInBytes { get; set; }

        /// <summary>
        /// Checks to see if the ImportedDataSizeInBytes property is set.
        /// </summary>
        internal bool IsSetImportedDataSizeInBytes() => this.ImportedDataSizeInBytes.HasValue;

        /// <summary>
        /// Gets and sets the property LabelsInputConfiguration.
        /// </summary>
        public LabelsInputConfiguration LabelsInputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the LabelsInputConfiguration property is set.
        /// </summary>
        internal bool IsSetLabelsInputConfiguration() => this.LabelsInputConfiguration != null;

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// Indicates the last time the machine learning model version was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime { get; set; }

        /// <summary>
        /// Checks to see if the LastUpdatedTime property is set.
        /// </summary>
        internal bool IsSetLastUpdatedTime() => this.LastUpdatedTime.HasValue;

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the parent machine learning model that this version
        /// belong to.
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
        /// The Amazon S3 location where Amazon Lookout for Equipment saves the pointwise model
        /// diagnostics for the model version.
        /// </para>
        /// </summary>
        public ModelDiagnosticsOutputConfiguration ModelDiagnosticsOutputConfiguration { get; set; }

        /// <summary>
        /// Checks to see if the ModelDiagnosticsOutputConfiguration property is set.
        /// </summary>
        internal bool IsSetModelDiagnosticsOutputConfiguration() => this.ModelDiagnosticsOutputConfiguration != null;

        /// <summary>
        /// Gets and sets the property ModelDiagnosticsResultsObject. 
        /// <para>
        /// The Amazon S3 output prefix for where Lookout for Equipment saves the pointwise model
        /// diagnostics for the model version.
        /// </para>
        /// </summary>
        public S3Object ModelDiagnosticsResultsObject { get; set; }

        /// <summary>
        /// Checks to see if the ModelDiagnosticsResultsObject property is set.
        /// </summary>
        internal bool IsSetModelDiagnosticsResultsObject() => this.ModelDiagnosticsResultsObject != null;

        /// <summary>
        /// Gets and sets the property ModelMetrics. 
        /// <para>
        /// Shows an aggregated summary, in JSON format, of the model's performance within the
        /// evaluation time range. These metrics are created when evaluating the model.
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
        /// The name of the machine learning model that this version belongs to.
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
        /// Gets and sets the property ModelVersion. 
        /// <para>
        /// The version of the machine learning model.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1)]
        public long? ModelVersion { get; set; }

        /// <summary>
        /// Checks to see if the ModelVersion property is set.
        /// </summary>
        internal bool IsSetModelVersion() => this.ModelVersion.HasValue;

        /// <summary>
        /// Gets and sets the property ModelVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string ModelVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the ModelVersionArn property is set.
        /// </summary>
        internal bool IsSetModelVersionArn() => this.ModelVersionArn != null;

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
        /// Gets and sets the property RetrainingAvailableDataInDays. 
        /// <para>
        /// Indicates the number of days of data used in the most recent scheduled retraining
        /// run. 
        /// </para>
        /// </summary>
        public int? RetrainingAvailableDataInDays { get; set; }

        /// <summary>
        /// Checks to see if the RetrainingAvailableDataInDays property is set.
        /// </summary>
        internal bool IsSetRetrainingAvailableDataInDays() => this.RetrainingAvailableDataInDays.HasValue;

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role that was used to train the model version.
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
        /// The schema of the data used to train the model version.
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
        /// The identifier of the KMS key key used to encrypt model version data by Amazon Lookout
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
        /// If model version was imported, then this field is the arn of the source model version.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 20, Max = 2048)]
        public string SourceModelVersionArn { get; set; }

        /// <summary>
        /// Checks to see if the SourceModelVersionArn property is set.
        /// </summary>
        internal bool IsSetSourceModelVersionArn() => this.SourceModelVersionArn != null;

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// Indicates whether this model version was created by training or by importing.
        /// </para>
        /// </summary>
        public ModelVersionSourceType SourceType { get; set; }

        /// <summary>
        /// Checks to see if the SourceType property is set.
        /// </summary>
        internal bool IsSetSourceType() => this.SourceType != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the model version.
        /// </para>
        /// </summary>
        public ModelVersionStatus Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TrainingDataEndTime. 
        /// <para>
        /// The date on which the training data finished being gathered. If you imported the version,
        /// this is the date that the training data in the source version finished being gathered.
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
        /// The date on which the training data began being gathered. If you imported the version,
        /// this is the date that the training data in the source version began being gathered.
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
        /// The time when the training of the version completed.
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
        /// The time when the training of the version began.
        /// </para>
        /// </summary>
        public DateTime? TrainingExecutionStartTime { get; set; }

        /// <summary>
        /// Checks to see if the TrainingExecutionStartTime property is set.
        /// </summary>
        internal bool IsSetTrainingExecutionStartTime() => this.TrainingExecutionStartTime.HasValue;
    }
}
