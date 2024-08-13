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
 * Do not modify this file. This file is generated from the lookoutequipment-2020-12-15.normal.json service model.
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
        private AutoPromotionResult _autoPromotionResult;
        private string _autoPromotionResultReason;
        private DateTime? _createdAt;
        private DataPreProcessingConfiguration _dataPreProcessingConfiguration;
        private string _datasetArn;
        private string _datasetName;
        private DateTime? _evaluationDataEndTime;
        private DateTime? _evaluationDataStartTime;
        private string _failedReason;
        private long? _importedDataSizeInBytes;
        private DateTime? _importJobEndTime;
        private DateTime? _importJobStartTime;
        private LabelsInputConfiguration _labelsInputConfiguration;
        private DateTime? _lastUpdatedTime;
        private string _modelArn;
        private ModelDiagnosticsOutputConfiguration _modelDiagnosticsOutputConfiguration;
        private S3Object _modelDiagnosticsResultsObject;
        private string _modelMetrics;
        private string _modelName;
        private ModelQuality _modelQuality;
        private long? _modelVersion;
        private string _modelVersionArn;
        private string _offCondition;
        private string _priorModelMetrics;
        private int? _retrainingAvailableDataInDays;
        private string _roleArn;
        private string _schema;
        private string _serverSideKmsKeyId;
        private string _sourceModelVersionArn;
        private ModelVersionSourceType _sourceType;
        private ModelVersionStatus _status;
        private DateTime? _trainingDataEndTime;
        private DateTime? _trainingDataStartTime;
        private DateTime? _trainingExecutionEndTime;
        private DateTime? _trainingExecutionStartTime;

        /// <summary>
        /// Gets and sets the property AutoPromotionResult. 
        /// <para>
        /// Indicates whether the model version was promoted to be the active version after retraining
        /// or if there was an error with or cancellation of the retraining. 
        /// </para>
        /// </summary>
        public AutoPromotionResult AutoPromotionResult
        {
            get { return this._autoPromotionResult; }
            set { this._autoPromotionResult = value; }
        }

        // Check to see if AutoPromotionResult property is set
        internal bool IsSetAutoPromotionResult()
        {
            return this._autoPromotionResult != null;
        }

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
        [AWSProperty(Min=1, Max=256)]
        public string AutoPromotionResultReason
        {
            get { return this._autoPromotionResultReason; }
            set { this._autoPromotionResultReason = value; }
        }

        // Check to see if AutoPromotionResultReason property is set
        internal bool IsSetAutoPromotionResultReason()
        {
            return this._autoPromotionResultReason != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Indicates the time and date at which the machine learning model version was created.
        /// </para>
        /// </summary>
        public DateTime? CreatedAt
        {
            get { return this._createdAt; }
            set { this._createdAt = value; }
        }

        // Check to see if CreatedAt property is set
        internal bool IsSetCreatedAt()
        {
            return this._createdAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DataPreProcessingConfiguration.
        /// </summary>
        public DataPreProcessingConfiguration DataPreProcessingConfiguration
        {
            get { return this._dataPreProcessingConfiguration; }
            set { this._dataPreProcessingConfiguration = value; }
        }

        // Check to see if DataPreProcessingConfiguration property is set
        internal bool IsSetDataPreProcessingConfiguration()
        {
            return this._dataPreProcessingConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the dataset used to train the model version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string DatasetArn
        {
            get { return this._datasetArn; }
            set { this._datasetArn = value; }
        }

        // Check to see if DatasetArn property is set
        internal bool IsSetDatasetArn()
        {
            return this._datasetArn != null;
        }

        /// <summary>
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// The name of the dataset used to train the model version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
        public string DatasetName
        {
            get { return this._datasetName; }
            set { this._datasetName = value; }
        }

        // Check to see if DatasetName property is set
        internal bool IsSetDatasetName()
        {
            return this._datasetName != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationDataEndTime. 
        /// <para>
        /// The date on which the data in the evaluation set began being gathered. If you imported
        /// the version, this is the date that the evaluation set data in the source version finished
        /// being gathered.
        /// </para>
        /// </summary>
        public DateTime? EvaluationDataEndTime
        {
            get { return this._evaluationDataEndTime; }
            set { this._evaluationDataEndTime = value; }
        }

        // Check to see if EvaluationDataEndTime property is set
        internal bool IsSetEvaluationDataEndTime()
        {
            return this._evaluationDataEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EvaluationDataStartTime. 
        /// <para>
        /// The date on which the data in the evaluation set began being gathered. If you imported
        /// the version, this is the date that the evaluation set data in the source version began
        /// being gathered.
        /// </para>
        /// </summary>
        public DateTime? EvaluationDataStartTime
        {
            get { return this._evaluationDataStartTime; }
            set { this._evaluationDataStartTime = value; }
        }

        // Check to see if EvaluationDataStartTime property is set
        internal bool IsSetEvaluationDataStartTime()
        {
            return this._evaluationDataStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property FailedReason. 
        /// <para>
        /// The failure message if the training of the model version failed.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
        public string FailedReason
        {
            get { return this._failedReason; }
            set { this._failedReason = value; }
        }

        // Check to see if FailedReason property is set
        internal bool IsSetFailedReason()
        {
            return this._failedReason != null;
        }

        /// <summary>
        /// Gets and sets the property ImportedDataSizeInBytes. 
        /// <para>
        /// The size in bytes of the imported data. This field appears if the model version was
        /// imported.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0)]
        public long? ImportedDataSizeInBytes
        {
            get { return this._importedDataSizeInBytes; }
            set { this._importedDataSizeInBytes = value; }
        }

        // Check to see if ImportedDataSizeInBytes property is set
        internal bool IsSetImportedDataSizeInBytes()
        {
            return this._importedDataSizeInBytes.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImportJobEndTime. 
        /// <para>
        /// The date and time when the import job completed. This field appears if the model version
        /// was imported.
        /// </para>
        /// </summary>
        public DateTime? ImportJobEndTime
        {
            get { return this._importJobEndTime; }
            set { this._importJobEndTime = value; }
        }

        // Check to see if ImportJobEndTime property is set
        internal bool IsSetImportJobEndTime()
        {
            return this._importJobEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ImportJobStartTime. 
        /// <para>
        /// The date and time when the import job began. This field appears if the model version
        /// was imported.
        /// </para>
        /// </summary>
        public DateTime? ImportJobStartTime
        {
            get { return this._importJobStartTime; }
            set { this._importJobStartTime = value; }
        }

        // Check to see if ImportJobStartTime property is set
        internal bool IsSetImportJobStartTime()
        {
            return this._importJobStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LabelsInputConfiguration.
        /// </summary>
        public LabelsInputConfiguration LabelsInputConfiguration
        {
            get { return this._labelsInputConfiguration; }
            set { this._labelsInputConfiguration = value; }
        }

        // Check to see if LabelsInputConfiguration property is set
        internal bool IsSetLabelsInputConfiguration()
        {
            return this._labelsInputConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property LastUpdatedTime. 
        /// <para>
        /// Indicates the last time the machine learning model version was updated.
        /// </para>
        /// </summary>
        public DateTime? LastUpdatedTime
        {
            get { return this._lastUpdatedTime; }
            set { this._lastUpdatedTime = value; }
        }

        // Check to see if LastUpdatedTime property is set
        internal bool IsSetLastUpdatedTime()
        {
            return this._lastUpdatedTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the parent machine learning model that this version
        /// belong to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property ModelDiagnosticsOutputConfiguration. 
        /// <para>
        /// The Amazon S3 location where Amazon Lookout for Equipment saves the pointwise model
        /// diagnostics for the model version.
        /// </para>
        /// </summary>
        public ModelDiagnosticsOutputConfiguration ModelDiagnosticsOutputConfiguration
        {
            get { return this._modelDiagnosticsOutputConfiguration; }
            set { this._modelDiagnosticsOutputConfiguration = value; }
        }

        // Check to see if ModelDiagnosticsOutputConfiguration property is set
        internal bool IsSetModelDiagnosticsOutputConfiguration()
        {
            return this._modelDiagnosticsOutputConfiguration != null;
        }

        /// <summary>
        /// Gets and sets the property ModelDiagnosticsResultsObject. 
        /// <para>
        /// The Amazon S3 output prefix for where Lookout for Equipment saves the pointwise model
        /// diagnostics for the model version.
        /// </para>
        /// </summary>
        public S3Object ModelDiagnosticsResultsObject
        {
            get { return this._modelDiagnosticsResultsObject; }
            set { this._modelDiagnosticsResultsObject = value; }
        }

        // Check to see if ModelDiagnosticsResultsObject property is set
        internal bool IsSetModelDiagnosticsResultsObject()
        {
            return this._modelDiagnosticsResultsObject != null;
        }

        /// <summary>
        /// Gets and sets the property ModelMetrics. 
        /// <para>
        /// Shows an aggregated summary, in JSON format, of the model's performance within the
        /// evaluation time range. These metrics are created when evaluating the model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50000)]
        public string ModelMetrics
        {
            get { return this._modelMetrics; }
            set { this._modelMetrics = value; }
        }

        // Check to see if ModelMetrics property is set
        internal bool IsSetModelMetrics()
        {
            return this._modelMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name of the machine learning model that this version belongs to.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=200)]
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
        public ModelQuality ModelQuality
        {
            get { return this._modelQuality; }
            set { this._modelQuality = value; }
        }

        // Check to see if ModelQuality property is set
        internal bool IsSetModelQuality()
        {
            return this._modelQuality != null;
        }

        /// <summary>
        /// Gets and sets the property ModelVersion. 
        /// <para>
        /// The version of the machine learning model.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? ModelVersion
        {
            get { return this._modelVersion; }
            set { this._modelVersion = value; }
        }

        // Check to see if ModelVersion property is set
        internal bool IsSetModelVersion()
        {
            return this._modelVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ModelVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ModelVersionArn
        {
            get { return this._modelVersionArn; }
            set { this._modelVersionArn = value; }
        }

        // Check to see if ModelVersionArn property is set
        internal bool IsSetModelVersionArn()
        {
            return this._modelVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property OffCondition. 
        /// <para>
        /// Indicates that the asset associated with this sensor has been shut off. As long as
        /// this condition is met, Lookout for Equipment will not use data from this asset for
        /// training, evaluation, or inference.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string OffCondition
        {
            get { return this._offCondition; }
            set { this._offCondition = value; }
        }

        // Check to see if OffCondition property is set
        internal bool IsSetOffCondition()
        {
            return this._offCondition != null;
        }

        /// <summary>
        /// Gets and sets the property PriorModelMetrics. 
        /// <para>
        /// If the model version was retrained, this field shows a summary of the performance
        /// of the prior model on the new training range. You can use the information in this
        /// JSON-formatted object to compare the new model version and the prior model version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=50000)]
        public string PriorModelMetrics
        {
            get { return this._priorModelMetrics; }
            set { this._priorModelMetrics = value; }
        }

        // Check to see if PriorModelMetrics property is set
        internal bool IsSetPriorModelMetrics()
        {
            return this._priorModelMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property RetrainingAvailableDataInDays. 
        /// <para>
        /// Indicates the number of days of data used in the most recent scheduled retraining
        /// run. 
        /// </para>
        /// </summary>
        public int? RetrainingAvailableDataInDays
        {
            get { return this._retrainingAvailableDataInDays; }
            set { this._retrainingAvailableDataInDays = value; }
        }

        // Check to see if RetrainingAvailableDataInDays property is set
        internal bool IsSetRetrainingAvailableDataInDays()
        {
            return this._retrainingAvailableDataInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the role that was used to train the model version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
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
        /// Gets and sets the property Schema. 
        /// <para>
        /// The schema of the data used to train the model version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1000000)]
        public string Schema
        {
            get { return this._schema; }
            set { this._schema = value; }
        }

        // Check to see if Schema property is set
        internal bool IsSetSchema()
        {
            return this._schema != null;
        }

        /// <summary>
        /// Gets and sets the property ServerSideKmsKeyId. 
        /// <para>
        /// The identifier of the KMS key key used to encrypt model version data by Amazon Lookout
        /// for Equipment.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=1024)]
        public string ServerSideKmsKeyId
        {
            get { return this._serverSideKmsKeyId; }
            set { this._serverSideKmsKeyId = value; }
        }

        // Check to see if ServerSideKmsKeyId property is set
        internal bool IsSetServerSideKmsKeyId()
        {
            return this._serverSideKmsKeyId != null;
        }

        /// <summary>
        /// Gets and sets the property SourceModelVersionArn. 
        /// <para>
        /// If model version was imported, then this field is the arn of the source model version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string SourceModelVersionArn
        {
            get { return this._sourceModelVersionArn; }
            set { this._sourceModelVersionArn = value; }
        }

        // Check to see if SourceModelVersionArn property is set
        internal bool IsSetSourceModelVersionArn()
        {
            return this._sourceModelVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property SourceType. 
        /// <para>
        /// Indicates whether this model version was created by training or by importing.
        /// </para>
        /// </summary>
        public ModelVersionSourceType SourceType
        {
            get { return this._sourceType; }
            set { this._sourceType = value; }
        }

        // Check to see if SourceType property is set
        internal bool IsSetSourceType()
        {
            return this._sourceType != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The current status of the model version.
        /// </para>
        /// </summary>
        public ModelVersionStatus Status
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
        /// Gets and sets the property TrainingDataEndTime. 
        /// <para>
        /// The date on which the training data finished being gathered. If you imported the version,
        /// this is the date that the training data in the source version finished being gathered.
        /// </para>
        /// </summary>
        public DateTime? TrainingDataEndTime
        {
            get { return this._trainingDataEndTime; }
            set { this._trainingDataEndTime = value; }
        }

        // Check to see if TrainingDataEndTime property is set
        internal bool IsSetTrainingDataEndTime()
        {
            return this._trainingDataEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrainingDataStartTime. 
        /// <para>
        /// The date on which the training data began being gathered. If you imported the version,
        /// this is the date that the training data in the source version began being gathered.
        /// </para>
        /// </summary>
        public DateTime? TrainingDataStartTime
        {
            get { return this._trainingDataStartTime; }
            set { this._trainingDataStartTime = value; }
        }

        // Check to see if TrainingDataStartTime property is set
        internal bool IsSetTrainingDataStartTime()
        {
            return this._trainingDataStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrainingExecutionEndTime. 
        /// <para>
        /// The time when the training of the version completed.
        /// </para>
        /// </summary>
        public DateTime? TrainingExecutionEndTime
        {
            get { return this._trainingExecutionEndTime; }
            set { this._trainingExecutionEndTime = value; }
        }

        // Check to see if TrainingExecutionEndTime property is set
        internal bool IsSetTrainingExecutionEndTime()
        {
            return this._trainingExecutionEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property TrainingExecutionStartTime. 
        /// <para>
        /// The time when the training of the version began.
        /// </para>
        /// </summary>
        public DateTime? TrainingExecutionStartTime
        {
            get { return this._trainingExecutionStartTime; }
            set { this._trainingExecutionStartTime = value; }
        }

        // Check to see if TrainingExecutionStartTime property is set
        internal bool IsSetTrainingExecutionStartTime()
        {
            return this._trainingExecutionStartTime.HasValue; 
        }

    }
}