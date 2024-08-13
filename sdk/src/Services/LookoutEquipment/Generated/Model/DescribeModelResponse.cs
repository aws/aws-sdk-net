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
    /// This is the response object from the DescribeModel operation.
    /// </summary>
    public partial class DescribeModelResponse : AmazonWebServiceResponse
    {
        private DateTime? _accumulatedInferenceDataEndTime;
        private DateTime? _accumulatedInferenceDataStartTime;
        private long? _activeModelVersion;
        private string _activeModelVersionArn;
        private DateTime? _createdAt;
        private DataPreProcessingConfiguration _dataPreProcessingConfiguration;
        private string _datasetArn;
        private string _datasetName;
        private DateTime? _evaluationDataEndTime;
        private DateTime? _evaluationDataStartTime;
        private string _failedReason;
        private DateTime? _importJobEndTime;
        private DateTime? _importJobStartTime;
        private LabelsInputConfiguration _labelsInputConfiguration;
        private DateTime? _lastUpdatedTime;
        private int? _latestScheduledRetrainingAvailableDataInDays;
        private string _latestScheduledRetrainingFailedReason;
        private long? _latestScheduledRetrainingModelVersion;
        private DateTime? _latestScheduledRetrainingStartTime;
        private ModelVersionStatus _latestScheduledRetrainingStatus;
        private string _modelArn;
        private ModelDiagnosticsOutputConfiguration _modelDiagnosticsOutputConfiguration;
        private string _modelMetrics;
        private string _modelName;
        private ModelQuality _modelQuality;
        private DateTime? _modelVersionActivatedAt;
        private DateTime? _nextScheduledRetrainingStartDate;
        private string _offCondition;
        private long? _previousActiveModelVersion;
        private string _previousActiveModelVersionArn;
        private DateTime? _previousModelVersionActivatedAt;
        private string _priorModelMetrics;
        private RetrainingSchedulerStatus _retrainingSchedulerStatus;
        private string _roleArn;
        private string _schema;
        private string _serverSideKmsKeyId;
        private string _sourceModelVersionArn;
        private ModelStatus _status;
        private DateTime? _trainingDataEndTime;
        private DateTime? _trainingDataStartTime;
        private DateTime? _trainingExecutionEndTime;
        private DateTime? _trainingExecutionStartTime;

        /// <summary>
        /// Gets and sets the property AccumulatedInferenceDataEndTime. 
        /// <para>
        /// Indicates the end time of the inference data that has been accumulated. 
        /// </para>
        /// </summary>
        public DateTime? AccumulatedInferenceDataEndTime
        {
            get { return this._accumulatedInferenceDataEndTime; }
            set { this._accumulatedInferenceDataEndTime = value; }
        }

        // Check to see if AccumulatedInferenceDataEndTime property is set
        internal bool IsSetAccumulatedInferenceDataEndTime()
        {
            return this._accumulatedInferenceDataEndTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property AccumulatedInferenceDataStartTime. 
        /// <para>
        /// Indicates the start time of the inference data that has been accumulated. 
        /// </para>
        /// </summary>
        public DateTime? AccumulatedInferenceDataStartTime
        {
            get { return this._accumulatedInferenceDataStartTime; }
            set { this._accumulatedInferenceDataStartTime = value; }
        }

        // Check to see if AccumulatedInferenceDataStartTime property is set
        internal bool IsSetAccumulatedInferenceDataStartTime()
        {
            return this._accumulatedInferenceDataStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ActiveModelVersion. 
        /// <para>
        /// The name of the model version used by the inference schedular when running a scheduled
        /// inference execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? ActiveModelVersion
        {
            get { return this._activeModelVersion; }
            set { this._activeModelVersion = value; }
        }

        // Check to see if ActiveModelVersion property is set
        internal bool IsSetActiveModelVersion()
        {
            return this._activeModelVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ActiveModelVersionArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the model version used by the inference scheduler
        /// when running a scheduled inference execution.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string ActiveModelVersionArn
        {
            get { return this._activeModelVersionArn; }
            set { this._activeModelVersionArn = value; }
        }

        // Check to see if ActiveModelVersionArn property is set
        internal bool IsSetActiveModelVersionArn()
        {
            return this._activeModelVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Indicates the time and date at which the machine learning model was created. 
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
        /// The Amazon Resouce Name (ARN) of the dataset used to create the machine learning model
        /// being described. 
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
        /// The name of the dataset being used by the machine learning being described. 
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
        ///  Indicates the time reference in the dataset that was used to end the subset of evaluation
        /// data for the machine learning model. 
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
        ///  Indicates the time reference in the dataset that was used to begin the subset of
        /// evaluation data for the machine learning model. 
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
        /// If the training of the machine learning model failed, this indicates the reason for
        /// that failure. 
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
        /// Gets and sets the property ImportJobEndTime. 
        /// <para>
        /// The date and time when the import job was completed. This field appears if the active
        /// model version was imported.
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
        /// The date and time when the import job was started. This field appears if the active
        /// model version was imported.
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
        /// <para>
        /// Specifies configuration information about the labels input, including its S3 location.
        /// 
        /// </para>
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
        /// Indicates the last time the machine learning model was updated. The type of update
        /// is not specified. 
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
        /// Gets and sets the property LatestScheduledRetrainingAvailableDataInDays. 
        /// <para>
        /// Indicates the number of days of data used in the most recent scheduled retraining
        /// run. 
        /// </para>
        /// </summary>
        public int? LatestScheduledRetrainingAvailableDataInDays
        {
            get { return this._latestScheduledRetrainingAvailableDataInDays; }
            set { this._latestScheduledRetrainingAvailableDataInDays = value; }
        }

        // Check to see if LatestScheduledRetrainingAvailableDataInDays property is set
        internal bool IsSetLatestScheduledRetrainingAvailableDataInDays()
        {
            return this._latestScheduledRetrainingAvailableDataInDays.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestScheduledRetrainingFailedReason. 
        /// <para>
        /// If the model version was generated by retraining and the training failed, this indicates
        /// the reason for that failure. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5000)]
        public string LatestScheduledRetrainingFailedReason
        {
            get { return this._latestScheduledRetrainingFailedReason; }
            set { this._latestScheduledRetrainingFailedReason = value; }
        }

        // Check to see if LatestScheduledRetrainingFailedReason property is set
        internal bool IsSetLatestScheduledRetrainingFailedReason()
        {
            return this._latestScheduledRetrainingFailedReason != null;
        }

        /// <summary>
        /// Gets and sets the property LatestScheduledRetrainingModelVersion. 
        /// <para>
        /// Indicates the most recent model version that was generated by retraining. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? LatestScheduledRetrainingModelVersion
        {
            get { return this._latestScheduledRetrainingModelVersion; }
            set { this._latestScheduledRetrainingModelVersion = value; }
        }

        // Check to see if LatestScheduledRetrainingModelVersion property is set
        internal bool IsSetLatestScheduledRetrainingModelVersion()
        {
            return this._latestScheduledRetrainingModelVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestScheduledRetrainingStartTime. 
        /// <para>
        /// Indicates the start time of the most recent scheduled retraining run. 
        /// </para>
        /// </summary>
        public DateTime? LatestScheduledRetrainingStartTime
        {
            get { return this._latestScheduledRetrainingStartTime; }
            set { this._latestScheduledRetrainingStartTime = value; }
        }

        // Check to see if LatestScheduledRetrainingStartTime property is set
        internal bool IsSetLatestScheduledRetrainingStartTime()
        {
            return this._latestScheduledRetrainingStartTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LatestScheduledRetrainingStatus. 
        /// <para>
        /// Indicates the status of the most recent scheduled retraining run. 
        /// </para>
        /// </summary>
        public ModelVersionStatus LatestScheduledRetrainingStatus
        {
            get { return this._latestScheduledRetrainingStatus; }
            set { this._latestScheduledRetrainingStatus = value; }
        }

        // Check to see if LatestScheduledRetrainingStatus property is set
        internal bool IsSetLatestScheduledRetrainingStatus()
        {
            return this._latestScheduledRetrainingStatus != null;
        }

        /// <summary>
        /// Gets and sets the property ModelArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the machine learning model being described. 
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
        /// Configuration information for the model's pointwise model diagnostics.
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
        /// Gets and sets the property ModelMetrics. 
        /// <para>
        /// The Model Metrics show an aggregated summary of the model's performance within the
        /// evaluation time range. This is the JSON content of the metrics created when evaluating
        /// the model. 
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
        /// The name of the machine learning model being described. 
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
        /// Gets and sets the property ModelVersionActivatedAt. 
        /// <para>
        /// The date the active model version was activated.
        /// </para>
        /// </summary>
        public DateTime? ModelVersionActivatedAt
        {
            get { return this._modelVersionActivatedAt; }
            set { this._modelVersionActivatedAt = value; }
        }

        // Check to see if ModelVersionActivatedAt property is set
        internal bool IsSetModelVersionActivatedAt()
        {
            return this._modelVersionActivatedAt.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NextScheduledRetrainingStartDate. 
        /// <para>
        /// Indicates the date and time that the next scheduled retraining run will start on.
        /// Lookout for Equipment truncates the time you provide to the nearest UTC day.
        /// </para>
        /// </summary>
        public DateTime? NextScheduledRetrainingStartDate
        {
            get { return this._nextScheduledRetrainingStartDate; }
            set { this._nextScheduledRetrainingStartDate = value; }
        }

        // Check to see if NextScheduledRetrainingStartDate property is set
        internal bool IsSetNextScheduledRetrainingStartDate()
        {
            return this._nextScheduledRetrainingStartDate.HasValue; 
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
        /// Gets and sets the property PreviousActiveModelVersion. 
        /// <para>
        /// The model version that was set as the active model version prior to the current active
        /// model version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1)]
        public long? PreviousActiveModelVersion
        {
            get { return this._previousActiveModelVersion; }
            set { this._previousActiveModelVersion = value; }
        }

        // Check to see if PreviousActiveModelVersion property is set
        internal bool IsSetPreviousActiveModelVersion()
        {
            return this._previousActiveModelVersion.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PreviousActiveModelVersionArn. 
        /// <para>
        /// The ARN of the model version that was set as the active model version prior to the
        /// current active model version.
        /// </para>
        /// </summary>
        [AWSProperty(Min=20, Max=2048)]
        public string PreviousActiveModelVersionArn
        {
            get { return this._previousActiveModelVersionArn; }
            set { this._previousActiveModelVersionArn = value; }
        }

        // Check to see if PreviousActiveModelVersionArn property is set
        internal bool IsSetPreviousActiveModelVersionArn()
        {
            return this._previousActiveModelVersionArn != null;
        }

        /// <summary>
        /// Gets and sets the property PreviousModelVersionActivatedAt. 
        /// <para>
        /// The date and time when the previous active model version was activated.
        /// </para>
        /// </summary>
        public DateTime? PreviousModelVersionActivatedAt
        {
            get { return this._previousModelVersionActivatedAt; }
            set { this._previousModelVersionActivatedAt = value; }
        }

        // Check to see if PreviousModelVersionActivatedAt property is set
        internal bool IsSetPreviousModelVersionActivatedAt()
        {
            return this._previousModelVersionActivatedAt.HasValue; 
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
        /// Gets and sets the property RetrainingSchedulerStatus. 
        /// <para>
        /// Indicates the status of the retraining scheduler. 
        /// </para>
        /// </summary>
        public RetrainingSchedulerStatus RetrainingSchedulerStatus
        {
            get { return this._retrainingSchedulerStatus; }
            set { this._retrainingSchedulerStatus = value; }
        }

        // Check to see if RetrainingSchedulerStatus property is set
        internal bool IsSetRetrainingSchedulerStatus()
        {
            return this._retrainingSchedulerStatus != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of a role with permission to access the data source
        /// for the machine learning model being described. 
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
        /// A JSON description of the data that is in each time series dataset, including names,
        /// column names, and data types. 
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
        /// Provides the identifier of the KMS key used to encrypt model data by Amazon Lookout
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
        /// The Amazon Resource Name (ARN) of the source model version. This field appears if
        /// the active model version was imported.
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
        /// Gets and sets the property Status. 
        /// <para>
        /// Specifies the current status of the model being described. Status describes the status
        /// of the most recent action of the model. 
        /// </para>
        /// </summary>
        public ModelStatus Status
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
        ///  Indicates the time reference in the dataset that was used to end the subset of training
        /// data for the machine learning model. 
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
        ///  Indicates the time reference in the dataset that was used to begin the subset of
        /// training data for the machine learning model. 
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
        /// Indicates the time at which the training of the machine learning model was completed.
        /// 
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
        /// Indicates the time at which the training of the machine learning model began. 
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