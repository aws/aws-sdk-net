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
    /// Container for the parameters to the CreateModel operation.
    /// Creates a machine learning model for data inference. 
    /// 
    ///  
    /// <para>
    /// A machine-learning (ML) model is a mathematical model that finds patterns in your
    /// data. In Amazon Lookout for Equipment, the model learns the patterns of normal behavior
    /// and detects abnormal behavior that could be potential equipment failure (or maintenance
    /// events). The models are made by analyzing normal data and abnormalities in machine
    /// behavior that have already occurred.
    /// </para>
    ///  
    /// <para>
    /// Your model is trained using a portion of the data from your dataset and uses that
    /// data to learn patterns of normal behavior and abnormal patterns that lead to equipment
    /// failure. Another portion of the data is used to evaluate the model's accuracy. 
    /// </para>
    /// </summary>
    public partial class CreateModelRequest : AmazonLookoutEquipmentRequest
    {
        private string _clientToken;
        private DataPreProcessingConfiguration _dataPreProcessingConfiguration;
        private string _datasetName;
        private DatasetSchema _datasetSchema;
        private DateTime? _evaluationDataEndTime;
        private DateTime? _evaluationDataStartTime;
        private LabelsInputConfiguration _labelsInputConfiguration;
        private ModelDiagnosticsOutputConfiguration _modelDiagnosticsOutputConfiguration;
        private string _modelName;
        private string _offCondition;
        private string _roleArn;
        private string _serverSideKmsKeyId;
        private List<Tag> _tags = AWSConfigs.InitializeCollections ? new List<Tag>() : null;
        private DateTime? _trainingDataEndTime;
        private DateTime? _trainingDataStartTime;

        /// <summary>
        /// Gets and sets the property ClientToken. 
        /// <para>
        /// A unique identifier for the request. If you do not set the client request token, Amazon
        /// Lookout for Equipment generates one. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ClientToken
        {
            get { return this._clientToken; }
            set { this._clientToken = value; }
        }

        // Check to see if ClientToken property is set
        internal bool IsSetClientToken()
        {
            return this._clientToken != null;
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
        /// Gets and sets the property DatasetName. 
        /// <para>
        /// The name of the dataset for the machine learning model being created. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
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
        /// Gets and sets the property DatasetSchema. 
        /// <para>
        /// The data schema for the machine learning model being created. 
        /// </para>
        /// </summary>
        public DatasetSchema DatasetSchema
        {
            get { return this._datasetSchema; }
            set { this._datasetSchema = value; }
        }

        // Check to see if DatasetSchema property is set
        internal bool IsSetDatasetSchema()
        {
            return this._datasetSchema != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationDataEndTime. 
        /// <para>
        ///  Indicates the time reference in the dataset that should be used to end the subset
        /// of evaluation data for the machine learning model. 
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
        /// Indicates the time reference in the dataset that should be used to begin the subset
        /// of evaluation data for the machine learning model. 
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
        /// Gets and sets the property LabelsInputConfiguration. 
        /// <para>
        /// The input configuration for the labels being used for the machine learning model that's
        /// being created. 
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
        /// Gets and sets the property ModelDiagnosticsOutputConfiguration. 
        /// <para>
        /// The Amazon S3 location where you want Amazon Lookout for Equipment to save the pointwise
        /// model diagnostics. You must also specify the <c>RoleArn</c> request parameter.
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
        /// Gets and sets the property ModelName. 
        /// <para>
        /// The name for the machine learning model to be created.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=200)]
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
        /// being used to create the machine learning model. 
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
        /// Gets and sets the property ServerSideKmsKeyId. 
        /// <para>
        /// Provides the identifier of the KMS key used to encrypt model data by Amazon Lookout
        /// for Equipment. 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
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
        /// Gets and sets the property Tags. 
        /// <para>
        ///  Any tags associated with the machine learning model being created. 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data for this property is returned
        /// from the service the property will also be null. This was changed to improve performance and allow the SDK and caller
        /// to distinguish between a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> Tags
        {
            get { return this._tags; }
            set { this._tags = value; }
        }

        // Check to see if Tags property is set
        internal bool IsSetTags()
        {
            return this._tags != null && (this._tags.Count > 0 || !AWSConfigs.InitializeCollections); 
        }

        /// <summary>
        /// Gets and sets the property TrainingDataEndTime. 
        /// <para>
        /// Indicates the time reference in the dataset that should be used to end the subset
        /// of training data for the machine learning model. 
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
        /// Indicates the time reference in the dataset that should be used to begin the subset
        /// of training data for the machine learning model. 
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

    }
}