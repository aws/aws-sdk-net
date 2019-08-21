/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Container for the parameters to the CreatePredictor operation.
    /// Creates an Amazon Forecast predictor.
    /// 
    ///  
    /// <para>
    /// In the request, you provide a dataset group and either specify an algorithm or let
    /// Amazon Forecast choose the algorithm for you using AutoML. If you specify an algorithm,
    /// you also can override algorithm-specific hyperparameters.
    /// </para>
    ///  
    /// <para>
    /// Amazon Forecast uses the chosen algorithm to train a model using the latest version
    /// of the datasets in the specified dataset group. The result is called a predictor.
    /// You then generate a forecast using the <a>CreateForecast</a> operation.
    /// </para>
    ///  
    /// <para>
    /// After training a model, the <code>CreatePredictor</code> operation also evaluates
    /// it. To see the evaluation metrics, use the <a>GetAccuracyMetrics</a> operation. Always
    /// review the evaluation metrics before deciding to use the predictor to generate a forecast.
    /// </para>
    ///  
    /// <para>
    /// Optionally, you can specify a featurization configuration to fill and aggragate the
    /// data fields in the <code>TARGET_TIME_SERIES</code> dataset to improve model training.
    /// For more information, see <a>FeaturizationConfig</a>.
    /// </para>
    ///  
    /// <para>
    ///  <b>AutoML</b> 
    /// </para>
    ///  
    /// <para>
    /// If you set <code>PerformAutoML</code> to <code>true</code>, Amazon Forecast evaluates
    /// each algorithm and chooses the one that minimizes the <code>objective function</code>.
    /// The <code>objective function</code> is defined as the mean of the weighted p10, p50,
    /// and p90 quantile losses. For more information, see <a>EvaluationResult</a>.
    /// </para>
    ///  
    /// <para>
    /// When AutoML is enabled, the following properties are disallowed:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <code>AlgorithmArn</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>HPOConfig</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>PerformHPO</code> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <code>TrainingParameters</code> 
    /// </para>
    ///  </li> </ul> 
    /// <para>
    /// To get a list of all your predictors, use the <a>ListPredictors</a> operation.
    /// </para>
    ///  <note> 
    /// <para>
    /// The <code>Status</code> of the predictor must be <code>ACTIVE</code>, signifying that
    /// training has completed, before you can use the predictor to create a forecast. Use
    /// the <a>DescribePredictor</a> operation to get the status.
    /// </para>
    ///  </note>
    /// </summary>
    public partial class CreatePredictorRequest : AmazonForecastServiceRequest
    {
        private string _algorithmArn;
        private EncryptionConfig _encryptionConfig;
        private EvaluationParameters _evaluationParameters;
        private FeaturizationConfig _featurizationConfig;
        private int? _forecastHorizon;
        private HyperParameterTuningJobConfig _hpoConfig;
        private InputDataConfig _inputDataConfig;
        private bool? _performAutoML;
        private bool? _performHPO;
        private string _predictorName;
        private Dictionary<string, string> _trainingParameters = new Dictionary<string, string>();

        /// <summary>
        /// Gets and sets the property AlgorithmArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the algorithm to use for model training. Required
        /// if <code>PerformAutoML</code> is not set to <code>true</code>.
        /// </para>
        ///  <p class="title"> <b>Supported algorithms</b> 
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>arn:aws:forecast:::algorithm/ARIMA</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:forecast:::algorithm/Deep_AR_Plus</code> 
        /// </para>
        ///  
        /// <para>
        ///  <code>- supports hyperparameter optimization (HPO)</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:forecast:::algorithm/ETS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:forecast:::algorithm/NPTS</code> 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>arn:aws:forecast:::algorithm/Prophet</code> 
        /// </para>
        ///  </li> </ul>
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
        [AWSProperty(Required=true)]
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
        /// Specifies the number of time-steps that the model is trained to predict. The forecast
        /// horizon is also called the prediction length.
        /// </para>
        ///  
        /// <para>
        /// For example, if you configure a dataset for daily data collection (using the <code>DataFrequency</code>
        /// parameter of the <a>CreateDataset</a> operation) and set the forecast horizon to 10,
        /// the model returns predictions for 10 days.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property HPOConfig. 
        /// <para>
        /// Provides hyperparameter override values for the algorithm. If you don't provide this
        /// parameter, Amazon Forecast uses default values. The individual algorithms specify
        /// which hyperparameters support hyperparameter optimization (HPO). For more information,
        /// see <a>aws-forecast-choosing-recipes</a>.
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
        [AWSProperty(Required=true)]
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
        /// Gets and sets the property PerformAutoML. 
        /// <para>
        /// Whether to perform AutoML. The default value is <code>false</code>. In this case,
        /// you are required to specify an algorithm.
        /// </para>
        ///  
        /// <para>
        /// If you want Amazon Forecast to evaluate the algorithms it provides and choose the
        /// best algorithm and configuration for your training dataset, set <code>PerformAutoML</code>
        /// to <code>true</code>. This is a good option if you aren't sure which algorithm is
        /// suitable for your application.
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
        /// Whether to perform hyperparameter optimization (HPO). HPO finds optimal hyperparameter
        /// values for your training data. The process of performing HPO is known as a hyperparameter
        /// tuning job.
        /// </para>
        ///  
        /// <para>
        /// The default value is <code>false</code>. In this case, Amazon Forecast uses default
        /// hyperparameter values from the chosen algorithm.
        /// </para>
        ///  
        /// <para>
        /// To override the default values, set <code>PerformHPO</code> to <code>true</code> and
        /// supply the <a>HyperParameterTuningJobConfig</a> object. The tuning job specifies an
        /// objective metric, the hyperparameters to optimize, and the valid range for each hyperparameter.
        /// </para>
        ///  
        /// <para>
        /// The following algorithms support HPO:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// DeepAR+
        /// </para>
        ///  </li> </ul>
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
        /// Gets and sets the property PredictorName. 
        /// <para>
        /// A name for the predictor.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
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
        /// Gets and sets the property TrainingParameters. 
        /// <para>
        /// The training parameters to override for model training. The parameters that you can
        /// override are listed in the individual algorithms in <a>aws-forecast-choosing-recipes</a>.
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