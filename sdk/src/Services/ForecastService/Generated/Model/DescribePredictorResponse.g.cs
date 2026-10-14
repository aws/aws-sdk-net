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

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// This is the response object from the DescribePredictor operation.
    /// </summary>
    public partial class DescribePredictorResponse : AmazonWebServiceResponse
    {
        /// <summary>
        /// Gets and sets the property AlgorithmArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the algorithm used for model training.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string AlgorithmArn { get; set; }

        /// <summary>
        /// Checks to see if the AlgorithmArn property is set.
        /// </summary>
        internal bool IsSetAlgorithmArn() => this.AlgorithmArn != null;

        /// <summary>
        /// Gets and sets the property AutoMLAlgorithmArns. 
        /// <para>
        /// When <c>PerformAutoML</c> is specified, the ARN of the chosen algorithm.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> AutoMLAlgorithmArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the AutoMLAlgorithmArns property is set.
        /// </summary>
        internal bool IsSetAutoMLAlgorithmArns() => this.AutoMLAlgorithmArns != null && (this.AutoMLAlgorithmArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property AutoMLOverrideStrategy. <note> 
        /// <para>
        ///  The <c>LatencyOptimized</c> AutoML override strategy is only available in private
        /// beta. Contact Amazon Web Services Support or your account manager to learn more about
        /// access privileges. 
        /// </para>
        ///  </note> 
        /// <para>
        /// The AutoML strategy used to train the predictor. Unless <c>LatencyOptimized</c> is
        /// specified, the AutoML strategy optimizes predictor accuracy.
        /// </para>
        ///  
        /// <para>
        /// This parameter is only valid for predictors trained using AutoML.
        /// </para>
        /// </summary>
        public AutoMLOverrideStrategy AutoMLOverrideStrategy { get; set; }

        /// <summary>
        /// Checks to see if the AutoMLOverrideStrategy property is set.
        /// </summary>
        internal bool IsSetAutoMLOverrideStrategy() => this.AutoMLOverrideStrategy != null;

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the model training task was created.
        /// </para>
        /// </summary>
        public DateTime? CreationTime { get; set; }

        /// <summary>
        /// Checks to see if the CreationTime property is set.
        /// </summary>
        internal bool IsSetCreationTime() => this.CreationTime.HasValue;

        /// <summary>
        /// Gets and sets the property DatasetImportJobArns. 
        /// <para>
        /// An array of the ARNs of the dataset import jobs used to import training data for the
        /// predictor.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<string> DatasetImportJobArns { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the DatasetImportJobArns property is set.
        /// </summary>
        internal bool IsSetDatasetImportJobArns() => this.DatasetImportJobArns != null && (this.DatasetImportJobArns.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property EncryptionConfig. 
        /// <para>
        /// An Key Management Service (KMS) key and the Identity and Access Management (IAM) role
        /// that Amazon Forecast can assume to access the key.
        /// </para>
        /// </summary>
        public EncryptionConfig EncryptionConfig { get; set; }

        /// <summary>
        /// Checks to see if the EncryptionConfig property is set.
        /// </summary>
        internal bool IsSetEncryptionConfig() => this.EncryptionConfig != null;

        /// <summary>
        /// Gets and sets the property EstimatedTimeRemainingInMinutes. 
        /// <para>
        /// The estimated time remaining in minutes for the predictor training job to complete.
        /// </para>
        /// </summary>
        public long? EstimatedTimeRemainingInMinutes { get; set; }

        /// <summary>
        /// Checks to see if the EstimatedTimeRemainingInMinutes property is set.
        /// </summary>
        internal bool IsSetEstimatedTimeRemainingInMinutes() => this.EstimatedTimeRemainingInMinutes.HasValue;

        /// <summary>
        /// Gets and sets the property EvaluationParameters. 
        /// <para>
        /// Used to override the default evaluation parameters of the specified algorithm. Amazon
        /// Forecast evaluates a predictor by splitting a dataset into training data and testing
        /// data. The evaluation parameters define how to perform the split and the number of
        /// iterations.
        /// </para>
        /// </summary>
        public EvaluationParameters EvaluationParameters { get; set; }

        /// <summary>
        /// Checks to see if the EvaluationParameters property is set.
        /// </summary>
        internal bool IsSetEvaluationParameters() => this.EvaluationParameters != null;

        /// <summary>
        /// Gets and sets the property FeaturizationConfig. 
        /// <para>
        /// The featurization configuration.
        /// </para>
        /// </summary>
        public FeaturizationConfig FeaturizationConfig { get; set; }

        /// <summary>
        /// Checks to see if the FeaturizationConfig property is set.
        /// </summary>
        internal bool IsSetFeaturizationConfig() => this.FeaturizationConfig != null;

        /// <summary>
        /// Gets and sets the property ForecastHorizon. 
        /// <para>
        /// The number of time-steps of the forecast. The forecast horizon is also called the
        /// prediction length.
        /// </para>
        /// </summary>
        public int? ForecastHorizon { get; set; }

        /// <summary>
        /// Checks to see if the ForecastHorizon property is set.
        /// </summary>
        internal bool IsSetForecastHorizon() => this.ForecastHorizon.HasValue;

        /// <summary>
        /// Gets and sets the property ForecastTypes. 
        /// <para>
        /// The forecast types used during predictor training. Default value is <c>["0.1","0.5","0.9"]</c>
        /// 
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 1, Max = 20)]
        public List<string> ForecastTypes { get; set; } = AWSConfigs.InitializeCollections ? new List<string>() : null;

        /// <summary>
        /// Checks to see if the ForecastTypes property is set.
        /// </summary>
        internal bool IsSetForecastTypes() => this.ForecastTypes != null && (this.ForecastTypes.Count > 0 || !AWSConfigs.InitializeCollections);

        /// <summary>
        /// Gets and sets the property HPOConfig. 
        /// <para>
        /// The hyperparameter override values for the algorithm.
        /// </para>
        /// </summary>
        public HyperParameterTuningJobConfig HPOConfig { get; set; }

        /// <summary>
        /// Checks to see if the HPOConfig property is set.
        /// </summary>
        internal bool IsSetHPOConfig() => this.HPOConfig != null;

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// Describes the dataset group that contains the data to use to train the predictor.
        /// </para>
        /// </summary>
        public InputDataConfig InputDataConfig { get; set; }

        /// <summary>
        /// Checks to see if the InputDataConfig property is set.
        /// </summary>
        internal bool IsSetInputDataConfig() => this.InputDataConfig != null;

        /// <summary>
        /// Gets and sets the property IsAutoPredictor. 
        /// <para>
        /// Whether the predictor was created with <a>CreateAutoPredictor</a>.
        /// </para>
        /// </summary>
        public bool? IsAutoPredictor { get; set; }

        /// <summary>
        /// Checks to see if the IsAutoPredictor property is set.
        /// </summary>
        internal bool IsSetIsAutoPredictor() => this.IsAutoPredictor.HasValue;

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// The last time the resource was modified. The timestamp depends on the status of the
        /// job:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>CREATE_PENDING</c> - The <c>CreationTime</c>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_IN_PROGRESS</c> - The current timestamp.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_STOPPING</c> - The current timestamp.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_STOPPED</c> - When the job stopped.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>ACTIVE</c> or <c>CREATE_FAILED</c> - When the job finished or failed.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        public DateTime? LastModificationTime { get; set; }

        /// <summary>
        /// Checks to see if the LastModificationTime property is set.
        /// </summary>
        internal bool IsSetLastModificationTime() => this.LastModificationTime.HasValue;

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// If an error occurred, an informational message about the error.
        /// </para>
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Checks to see if the Message property is set.
        /// </summary>
        internal bool IsSetMessage() => this.Message != null;

        /// <summary>
        /// Gets and sets the property OptimizationMetric. 
        /// <para>
        /// The accuracy metric used to optimize the predictor.
        /// </para>
        /// </summary>
        public OptimizationMetric OptimizationMetric { get; set; }

        /// <summary>
        /// Checks to see if the OptimizationMetric property is set.
        /// </summary>
        internal bool IsSetOptimizationMetric() => this.OptimizationMetric != null;

        /// <summary>
        /// Gets and sets the property PerformAutoML. 
        /// <para>
        /// Whether the predictor is set to perform AutoML.
        /// </para>
        /// </summary>
        public bool? PerformAutoML { get; set; }

        /// <summary>
        /// Checks to see if the PerformAutoML property is set.
        /// </summary>
        internal bool IsSetPerformAutoML() => this.PerformAutoML.HasValue;

        /// <summary>
        /// Gets and sets the property PerformHPO. 
        /// <para>
        /// Whether the predictor is set to perform hyperparameter optimization (HPO).
        /// </para>
        /// </summary>
        public bool? PerformHPO { get; set; }

        /// <summary>
        /// Checks to see if the PerformHPO property is set.
        /// </summary>
        internal bool IsSetPerformHPO() => this.PerformHPO.HasValue;

        /// <summary>
        /// Gets and sets the property PredictorArn. 
        /// <para>
        /// The ARN of the predictor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string PredictorArn { get; set; }

        /// <summary>
        /// Checks to see if the PredictorArn property is set.
        /// </summary>
        internal bool IsSetPredictorArn() => this.PredictorArn != null;

        /// <summary>
        /// Gets and sets the property PredictorExecutionDetails. 
        /// <para>
        /// Details on the the status and results of the backtests performed to evaluate the accuracy
        /// of the predictor. You specify the number of backtests to perform when you call the
        /// operation.
        /// </para>
        /// </summary>
        public PredictorExecutionDetails PredictorExecutionDetails { get; set; }

        /// <summary>
        /// Checks to see if the PredictorExecutionDetails property is set.
        /// </summary>
        internal bool IsSetPredictorExecutionDetails() => this.PredictorExecutionDetails != null;

        /// <summary>
        /// Gets and sets the property PredictorName. 
        /// <para>
        /// The name of the predictor.
        /// </para>
        /// </summary>
        [AWSProperty(Min = 1, Max = 63)]
        public string PredictorName { get; set; }

        /// <summary>
        /// Checks to see if the PredictorName property is set.
        /// </summary>
        internal bool IsSetPredictorName() => this.PredictorName != null;

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the predictor. States include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <c>ACTIVE</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_PENDING</c>, <c>CREATE_IN_PROGRESS</c>, <c>CREATE_FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>DELETE_PENDING</c>, <c>DELETE_IN_PROGRESS</c>, <c>DELETE_FAILED</c> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <c>CREATE_STOPPING</c>, <c>CREATE_STOPPED</c> 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <c>Status</c> of the predictor must be <c>ACTIVE</c> before you can use the predictor
        /// to create a forecast.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Min = 0, Max = 256)]
        public string Status { get; set; }

        /// <summary>
        /// Checks to see if the Status property is set.
        /// </summary>
        internal bool IsSetStatus() => this.Status != null;

        /// <summary>
        /// Gets and sets the property TrainingParameters. 
        /// <para>
        /// The default training parameters or overrides selected during model training. When
        /// running AutoML or choosing HPO with CNN-QR or DeepAR+, the optimized values for the
        /// chosen hyperparameters are returned. For more information, see <a>aws-forecast-choosing-recipes</a>.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        [AWSProperty(Min = 0, Max = 100)]
        public Dictionary<string, string> TrainingParameters { get; set; } = AWSConfigs.InitializeCollections ? new Dictionary<string, string>() : null;

        /// <summary>
        /// Checks to see if the TrainingParameters property is set.
        /// </summary>
        internal bool IsSetTrainingParameters() => this.TrainingParameters != null && (this.TrainingParameters.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
