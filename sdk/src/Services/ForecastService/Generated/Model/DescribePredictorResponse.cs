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
 * Do not modify this file. This file is generated from the forecast-2018-06-26.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// This is the response object from the DescribePredictor operation.
    /// </summary>
    public partial class DescribePredictorResponse : AmazonWebServiceResponse
    {
        private string _algorithmArn;
        private List<string> _autoMLAlgorithmArns = new List<string>();
        private DateTime? _creationTime;
        private List<string> _datasetImportJobArns = new List<string>();
        private EncryptionConfig _encryptionConfig;
        private EvaluationParameters _evaluationParameters;
        private FeaturizationConfig _featurizationConfig;
        private int? _forecastHorizon;
        private List<string> _forecastTypes = new List<string>();
        private HyperParameterTuningJobConfig _hpoConfig;
        private InputDataConfig _inputDataConfig;
        private DateTime? _lastModificationTime;
        private string _message;
        private bool? _performAutoML;
        private bool? _performHPO;
        private string _predictorArn;
        private PredictorExecutionDetails _predictorExecutionDetails;
        private string _predictorName;
        private string _status;
        private Dictionary<string, string> _trainingParameters = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AlgorithmArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the algorithm used for model training.
        /// </para>
        /// </summary>
        [AWSProperty(Max=256)]
        public string AlgorithmArn
        {
            get { return this._algorithmArn; }
            set { this._algorithmArn = value; }
        }

        // Check to see if AlgorithmArn property is set
        internal bool IsSetAlgorithmArn()
        {
            return this._algorithmArn != null;
        }

        /// <summary>
        /// Gets and sets the property AutoMLAlgorithmArns. 
        /// <para>
        /// When <code>PerformAutoML</code> is specified, the ARN of the chosen algorithm.
        /// </para>
        /// </summary>
        public List<string> AutoMLAlgorithmArns
        {
            get { return this._autoMLAlgorithmArns; }
            set { this._autoMLAlgorithmArns = value; }
        }

        // Check to see if AutoMLAlgorithmArns property is set
        internal bool IsSetAutoMLAlgorithmArns()
        {
            return this._autoMLAlgorithmArns != null && this._autoMLAlgorithmArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property CreationTime. 
        /// <para>
        /// When the model training task was created.
        /// </para>
        /// </summary>
        public DateTime CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property DatasetImportJobArns. 
        /// <para>
        /// An array of the ARNs of the dataset import jobs used to import training data for the
        /// predictor.
        /// </para>
        /// </summary>
        public List<string> DatasetImportJobArns
        {
            get { return this._datasetImportJobArns; }
            set { this._datasetImportJobArns = value; }
        }

        // Check to see if DatasetImportJobArns property is set
        internal bool IsSetDatasetImportJobArns()
        {
            return this._datasetImportJobArns != null && this._datasetImportJobArns.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property EncryptionConfig. 
        /// <para>
        /// An AWS Key Management Service (KMS) key and the AWS Identity and Access Management
        /// (IAM) role that Amazon Forecast can assume to access the key.
        /// </para>
        /// </summary>
        public EncryptionConfig EncryptionConfig
        {
            get { return this._encryptionConfig; }
            set { this._encryptionConfig = value; }
        }

        // Check to see if EncryptionConfig property is set
        internal bool IsSetEncryptionConfig()
        {
            return this._encryptionConfig != null;
        }

        /// <summary>
        /// Gets and sets the property EvaluationParameters. 
        /// <para>
        /// Used to override the default evaluation parameters of the specified algorithm. Amazon
        /// Forecast evaluates a predictor by splitting a dataset into training data and testing
        /// data. The evaluation parameters define how to perform the split and the number of
        /// iterations.
        /// </para>
        /// </summary>
        public EvaluationParameters EvaluationParameters
        {
            get { return this._evaluationParameters; }
            set { this._evaluationParameters = value; }
        }

        // Check to see if EvaluationParameters property is set
        internal bool IsSetEvaluationParameters()
        {
            return this._evaluationParameters != null;
        }

        /// <summary>
        /// Gets and sets the property FeaturizationConfig. 
        /// <para>
        /// The featurization configuration.
        /// </para>
        /// </summary>
        public FeaturizationConfig FeaturizationConfig
        {
            get { return this._featurizationConfig; }
            set { this._featurizationConfig = value; }
        }

        // Check to see if FeaturizationConfig property is set
        internal bool IsSetFeaturizationConfig()
        {
            return this._featurizationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ForecastHorizon. 
        /// <para>
        /// The number of time-steps of the forecast. The forecast horizon is also called the
        /// prediction length.
        /// </para>
        /// </summary>
        public int ForecastHorizon
        {
            get { return this._forecastHorizon.GetValueOrDefault(); }
            set { this._forecastHorizon = value; }
        }

        // Check to see if ForecastHorizon property is set
        internal bool IsSetForecastHorizon()
        {
            return this._forecastHorizon.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ForecastTypes. 
        /// <para>
        /// The forecast types used during predictor training. Default value is <code>["0.1","0.5","0.9"]</code>
        /// 
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=20)]
        public List<string> ForecastTypes
        {
            get { return this._forecastTypes; }
            set { this._forecastTypes = value; }
        }

        // Check to see if ForecastTypes property is set
        internal bool IsSetForecastTypes()
        {
            return this._forecastTypes != null && this._forecastTypes.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HPOConfig. 
        /// <para>
        /// The hyperparameter override values for the algorithm.
        /// </para>
        /// </summary>
        public HyperParameterTuningJobConfig HPOConfig
        {
            get { return this._hpoConfig; }
            set { this._hpoConfig = value; }
        }

        // Check to see if HPOConfig property is set
        internal bool IsSetHPOConfig()
        {
            return this._hpoConfig != null;
        }

        /// <summary>
        /// Gets and sets the property InputDataConfig. 
        /// <para>
        /// Describes the dataset group that contains the data to use to train the predictor.
        /// </para>
        /// </summary>
        public InputDataConfig InputDataConfig
        {
            get { return this._inputDataConfig; }
            set { this._inputDataConfig = value; }
        }

        // Check to see if InputDataConfig property is set
        internal bool IsSetInputDataConfig()
        {
            return this._inputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property LastModificationTime. 
        /// <para>
        /// Initially, the same as <code>CreationTime</code> (when the status is <code>CREATE_PENDING</code>).
        /// This value is updated when training starts (when the status changes to <code>CREATE_IN_PROGRESS</code>),
        /// and when training has completed (when the status changes to <code>ACTIVE</code>) or
        /// fails (when the status changes to <code>CREATE_FAILED</code>).
        /// </para>
        /// </summary>
        public DateTime LastModificationTime
        {
            get { return this._lastModificationTime.GetValueOrDefault(); }
            set { this._lastModificationTime = value; }
        }

        // Check to see if LastModificationTime property is set
        internal bool IsSetLastModificationTime()
        {
            return this._lastModificationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Message. 
        /// <para>
        /// If an error occurred, an informational message about the error.
        /// </para>
        /// </summary>
        public string Message
        {
            get { return this._message; }
            set { this._message = value; }
        }

        // Check to see if Message property is set
        internal bool IsSetMessage()
        {
            return this._message != null;
        }

        /// <summary>
        /// Gets and sets the property PerformAutoML. 
        /// <para>
        /// Whether the predictor is set to perform AutoML.
        /// </para>
        /// </summary>
        public bool PerformAutoML
        {
            get { return this._performAutoML.GetValueOrDefault(); }
            set { this._performAutoML = value; }
        }

        // Check to see if PerformAutoML property is set
        internal bool IsSetPerformAutoML()
        {
            return this._performAutoML.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PerformHPO. 
        /// <para>
        /// Whether the predictor is set to perform hyperparameter optimization (HPO).
        /// </para>
        /// </summary>
        public bool PerformHPO
        {
            get { return this._performHPO.GetValueOrDefault(); }
            set { this._performHPO = value; }
        }

        // Check to see if PerformHPO property is set
        internal bool IsSetPerformHPO()
        {
            return this._performHPO.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property PredictorArn. 
        /// <para>
        /// The ARN of the predictor.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string PredictorArn
        {
            get { return this._predictorArn; }
            set { this._predictorArn = value; }
        }

        // Check to see if PredictorArn property is set
        internal bool IsSetPredictorArn()
        {
            return this._predictorArn != null;
        }

        /// <summary>
        /// Gets and sets the property PredictorExecutionDetails. 
        /// <para>
        /// Details on the the status and results of the backtests performed to evaluate the accuracy
        /// of the predictor. You specify the number of backtests to perform when you call the
        /// operation.
        /// </para>
        /// </summary>
        public PredictorExecutionDetails PredictorExecutionDetails
        {
            get { return this._predictorExecutionDetails; }
            set { this._predictorExecutionDetails = value; }
        }

        // Check to see if PredictorExecutionDetails property is set
        internal bool IsSetPredictorExecutionDetails()
        {
            return this._predictorExecutionDetails != null;
        }

        /// <summary>
        /// Gets and sets the property PredictorName. 
        /// <para>
        /// The name of the predictor.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string PredictorName
        {
            get { return this._predictorName; }
            set { this._predictorName = value; }
        }

        // Check to see if PredictorName property is set
        internal bool IsSetPredictorName()
        {
            return this._predictorName != null;
        }

        /// <summary>
        /// Gets and sets the property Status. 
        /// <para>
        /// The status of the predictor. States include:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>ACTIVE</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>CREATE_PENDING</code>, <code>CREATE_IN_PROGRESS</code>, <code>CREATE_FAILED</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>DELETE_PENDING</code>, <code>DELETE_IN_PROGRESS</code>, <code>DELETE_FAILED</code>
        /// 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>UPDATE_PENDING</code>, <code>UPDATE_IN_PROGRESS</code>, <code>UPDATE_FAILED</code>
        /// 
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// The <code>Status</code> of the predictor must be <code>ACTIVE</code> before you can
        /// use the predictor to create a forecast.
        /// </para>
        ///  </note>
        /// </summary>
        [AWSProperty(Max=256)]
        public string Status
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
        /// Gets and sets the property TrainingParameters. 
        /// <para>
        /// The default training parameters or overrides selected during model training. When
        /// running AutoML or choosing HPO with CNN-QR or DeepAR+, the optimized values for the
        /// chosen hyperparameters are returned. For more information, see <a>aws-forecast-choosing-recipes</a>.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=100)]
        public Dictionary<string, string> TrainingParameters
        {
            get { return this._trainingParameters; }
            set { this._trainingParameters = value; }
        }

        // Check to see if TrainingParameters property is set
        internal bool IsSetTrainingParameters()
        {
            return this._trainingParameters != null && this._trainingParameters.Count > 0; 
        }

    }
}