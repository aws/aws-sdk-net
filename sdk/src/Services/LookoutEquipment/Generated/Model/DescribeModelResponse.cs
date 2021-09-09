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

namespace Amazon.LookoutEquipment.Model
{
    /// <summary>
    /// This is the response object from the DescribeModel operation.
    /// </summary>
    public partial class DescribeModelResponse : AmazonWebServiceResponse
    {
        private DateTime? _createdAt;
        private DataPreProcessingConfiguration _dataPreProcessingConfiguration;
        private string _datasetArn;
        private string _datasetName;
        private DateTime? _evaluationDataEndTime;
        private DateTime? _evaluationDataStartTime;
        private string _failedReason;
        private LabelsInputConfiguration _labelsInputConfiguration;
        private DateTime? _lastUpdatedTime;
        private string _modelArn;
        private string _modelMetrics;
        private string _modelName;
        private string _offCondition;
        private string _roleArn;
        private string _schema;
        private string _serverSideKmsKeyId;
        private ModelStatus _status;
        private DateTime? _trainingDataEndTime;
        private DateTime? _trainingDataStartTime;
        private DateTime? _trainingExecutionEndTime;
        private DateTime? _trainingExecutionStartTime;

        /// <summary>
        /// Gets and sets the property CreatedAt. 
        /// <para>
        /// Indicates the time and date at which the ML model was created. 
        /// </para>
        /// </summary>
        public DateTime CreatedAt
        {
            get { return this._createdAt.GetValueOrDefault(); }
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
        /// The configuration is the <code>TargetSamplingRate</code>, which is the sampling rate
        /// of the data after post processing by Amazon Lookout for Equipment. For example, if
        /// you provide data that has been collected at a 1 second level and you want the system
        /// to resample the data at a 1 minute rate before training, the <code>TargetSamplingRate</code>
        /// is 1 minute.
        /// </para>
        ///  
        /// <para>
        /// When providing a value for the <code>TargetSamplingRate</code>, you must attach the
        /// prefix "PT" to the rate you want. The value for a 1 second rate is therefore <i>PT1S</i>,
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
        /// The Amazon Resouce Name (ARN) of the dataset used to create the ML model being described.
        /// 
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
        /// The name of the dataset being used by the ML being described. 
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
        /// data for the ML model. 
        /// </para>
        /// </summary>
        public DateTime EvaluationDataEndTime
        {
            get { return this._evaluationDataEndTime.GetValueOrDefault(); }
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
        /// evaluation data for the ML model. 
        /// </para>
        /// </summary>
        public DateTime EvaluationDataStartTime
        {
            get { return this._evaluationDataStartTime.GetValueOrDefault(); }
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
        /// If the training of the ML model failed, this indicates the reason for that failure.
        /// 
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
        /// Indicates the last time the ML model was updated. The type of update is not specified.
        /// 
        /// </para>
        /// </summary>
        public DateTime LastUpdatedTime
        {
            get { return this._lastUpdatedTime.GetValueOrDefault(); }
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
        /// The Amazon Resource Name (ARN) of the ML model being described. 
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
        /// The name of the ML model being described. 
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
        /// Gets and sets the property RoleArn. 
        /// <para>
        ///  The Amazon Resource Name (ARN) of a role with permission to access the data source
        /// for the ML model being described. 
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
        /// data for the ML model. 
        /// </para>
        /// </summary>
        public DateTime TrainingDataEndTime
        {
            get { return this._trainingDataEndTime.GetValueOrDefault(); }
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
        /// training data for the ML model. 
        /// </para>
        /// </summary>
        public DateTime TrainingDataStartTime
        {
            get { return this._trainingDataStartTime.GetValueOrDefault(); }
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
        /// Indicates the time at which the training of the ML model was completed. 
        /// </para>
        /// </summary>
        public DateTime TrainingExecutionEndTime
        {
            get { return this._trainingExecutionEndTime.GetValueOrDefault(); }
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
        /// Indicates the time at which the training of the ML model began. 
        /// </para>
        /// </summary>
        public DateTime TrainingExecutionStartTime
        {
            get { return this._trainingExecutionStartTime.GetValueOrDefault(); }
            set { this._trainingExecutionStartTime = value; }
        }

        // Check to see if TrainingExecutionStartTime property is set
        internal bool IsSetTrainingExecutionStartTime()
        {
            return this._trainingExecutionStartTime.HasValue; 
        }

    }
}