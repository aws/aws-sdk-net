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
 * Do not modify this file. This file is generated from the sagemaker-2017-07-24.normal.json service model.
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
namespace Amazon.SageMaker.Model
{
    /// <summary>
    /// The collection of settings used by an AutoML job V2 for the tabular problem type.
    /// </summary>
    public partial class TabularJobConfig
    {
        private CandidateGenerationConfig _candidateGenerationConfig;
        private AutoMLJobCompletionCriteria _completionCriteria;
        private string _featureSpecificationS3Uri;
        private bool? _generateCandidateDefinitionsOnly;
        private AutoMLMode _mode;
        private ProblemType _problemType;
        private string _sampleWeightAttributeName;
        private string _targetAttributeName;

        /// <summary>
        /// Gets and sets the property CandidateGenerationConfig. 
        /// <para>
        /// The configuration information of how model candidates are generated.
        /// </para>
        /// </summary>
        public CandidateGenerationConfig CandidateGenerationConfig
        {
            get { return this._candidateGenerationConfig; }
            set { this._candidateGenerationConfig = value; }
        }

        // Check to see if CandidateGenerationConfig property is set
        internal bool IsSetCandidateGenerationConfig()
        {
            return this._candidateGenerationConfig != null;
        }

        /// <summary>
        /// Gets and sets the property CompletionCriteria.
        /// </summary>
        public AutoMLJobCompletionCriteria CompletionCriteria
        {
            get { return this._completionCriteria; }
            set { this._completionCriteria = value; }
        }

        // Check to see if CompletionCriteria property is set
        internal bool IsSetCompletionCriteria()
        {
            return this._completionCriteria != null;
        }

        /// <summary>
        /// Gets and sets the property FeatureSpecificationS3Uri. 
        /// <para>
        /// A URL to the Amazon S3 data source containing selected features from the input data
        /// source to run an Autopilot job V2. You can input <c>FeatureAttributeNames</c> (optional)
        /// in JSON format as shown below: 
        /// </para>
        ///  
        /// <para>
        ///  <c>{ "FeatureAttributeNames":["col1", "col2", ...] }</c>.
        /// </para>
        ///  
        /// <para>
        /// You can also specify the data type of the feature (optional) in the format shown below:
        /// </para>
        ///  
        /// <para>
        ///  <c>{ "FeatureDataTypes":{"col1":"numeric", "col2":"categorical" ... } }</c> 
        /// </para>
        ///  <note> 
        /// <para>
        /// These column keys may not include the target column.
        /// </para>
        ///  </note> 
        /// <para>
        /// In ensembling mode, Autopilot only supports the following data types: <c>numeric</c>,
        /// <c>categorical</c>, <c>text</c>, and <c>datetime</c>. In HPO mode, Autopilot can support
        /// <c>numeric</c>, <c>categorical</c>, <c>text</c>, <c>datetime</c>, and <c>sequence</c>.
        /// </para>
        ///  
        /// <para>
        /// If only <c>FeatureDataTypes</c> is provided, the column keys (<c>col1</c>, <c>col2</c>,..)
        /// should be a subset of the column names in the input data. 
        /// </para>
        ///  
        /// <para>
        /// If both <c>FeatureDataTypes</c> and <c>FeatureAttributeNames</c> are provided, then
        /// the column keys should be a subset of the column names provided in <c>FeatureAttributeNames</c>.
        /// 
        /// </para>
        ///  
        /// <para>
        /// The key name <c>FeatureAttributeNames</c> is fixed. The values listed in <c>["col1",
        /// "col2", ...]</c> are case sensitive and should be a list of strings containing unique
        /// values that are a subset of the column names in the input data. The list of columns
        /// provided must not include the target column.
        /// </para>
        /// </summary>
        [AWSProperty(Min=0, Max=1024)]
        public string FeatureSpecificationS3Uri
        {
            get { return this._featureSpecificationS3Uri; }
            set { this._featureSpecificationS3Uri = value; }
        }

        // Check to see if FeatureSpecificationS3Uri property is set
        internal bool IsSetFeatureSpecificationS3Uri()
        {
            return this._featureSpecificationS3Uri != null;
        }

        /// <summary>
        /// Gets and sets the property GenerateCandidateDefinitionsOnly. 
        /// <para>
        /// Generates possible candidates without training the models. A model candidate is a
        /// combination of data preprocessors, algorithms, and algorithm parameter settings.
        /// </para>
        /// </summary>
        public bool? GenerateCandidateDefinitionsOnly
        {
            get { return this._generateCandidateDefinitionsOnly; }
            set { this._generateCandidateDefinitionsOnly = value; }
        }

        // Check to see if GenerateCandidateDefinitionsOnly property is set
        internal bool IsSetGenerateCandidateDefinitionsOnly()
        {
            return this._generateCandidateDefinitionsOnly.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property Mode. 
        /// <para>
        /// The method that Autopilot uses to train the data. You can either specify the mode
        /// manually or let Autopilot choose for you based on the dataset size by selecting <c>AUTO</c>.
        /// In <c>AUTO</c> mode, Autopilot chooses <c>ENSEMBLING</c> for datasets smaller than
        /// 100 MB, and <c>HYPERPARAMETER_TUNING</c> for larger ones.
        /// </para>
        ///  
        /// <para>
        /// The <c>ENSEMBLING</c> mode uses a multi-stack ensemble model to predict classification
        /// and regression tasks directly from your dataset. This machine learning mode combines
        /// several base models to produce an optimal predictive model. It then uses a stacking
        /// ensemble method to combine predictions from contributing members. A multi-stack ensemble
        /// model can provide better performance over a single model by combining the predictive
        /// capabilities of multiple models. See <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-model-support-validation.html#autopilot-algorithm-support">Autopilot
        /// algorithm support</a> for a list of algorithms supported by <c>ENSEMBLING</c> mode.
        /// </para>
        ///  
        /// <para>
        /// The <c>HYPERPARAMETER_TUNING</c> (HPO) mode uses the best hyperparameters to train
        /// the best version of a model. HPO automatically selects an algorithm for the type of
        /// problem you want to solve. Then HPO finds the best hyperparameters according to your
        /// objective metric. See <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-model-support-validation.html#autopilot-algorithm-support">Autopilot
        /// algorithm support</a> for a list of algorithms supported by <c>HYPERPARAMETER_TUNING</c>
        /// mode.
        /// </para>
        /// </summary>
        public AutoMLMode Mode
        {
            get { return this._mode; }
            set { this._mode = value; }
        }

        // Check to see if Mode property is set
        internal bool IsSetMode()
        {
            return this._mode != null;
        }

        /// <summary>
        /// Gets and sets the property ProblemType. 
        /// <para>
        /// The type of supervised learning problem available for the model candidates of the
        /// AutoML job V2. For more information, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-datasets-problem-types.html#autopilot-problem-types">
        /// SageMaker Autopilot problem types</a>.
        /// </para>
        ///  <note> 
        /// <para>
        /// You must either specify the type of supervised learning problem in <c>ProblemType</c>
        /// and provide the <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_CreateAutoMLJobV2.html#sagemaker-CreateAutoMLJobV2-request-AutoMLJobObjective">AutoMLJobObjective</a>
        /// metric, or none at all.
        /// </para>
        ///  </note>
        /// </summary>
        public ProblemType ProblemType
        {
            get { return this._problemType; }
            set { this._problemType = value; }
        }

        // Check to see if ProblemType property is set
        internal bool IsSetProblemType()
        {
            return this._problemType != null;
        }

        /// <summary>
        /// Gets and sets the property SampleWeightAttributeName. 
        /// <para>
        /// If specified, this column name indicates which column of the dataset should be treated
        /// as sample weights for use by the objective metric during the training, evaluation,
        /// and the selection of the best model. This column is not considered as a predictive
        /// feature. For more information on Autopilot metrics, see <a href="https://docs.aws.amazon.com/sagemaker/latest/dg/autopilot-metrics-validation.html">Metrics
        /// and validation</a>.
        /// </para>
        ///  
        /// <para>
        /// Sample weights should be numeric, non-negative, with larger values indicating which
        /// rows are more important than others. Data points that have invalid or no weight value
        /// are excluded.
        /// </para>
        ///  
        /// <para>
        /// Support for sample weights is available in <a href="https://docs.aws.amazon.com/sagemaker/latest/APIReference/API_AutoMLAlgorithmConfig.html">Ensembling</a>
        /// mode only.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string SampleWeightAttributeName
        {
            get { return this._sampleWeightAttributeName; }
            set { this._sampleWeightAttributeName = value; }
        }

        // Check to see if SampleWeightAttributeName property is set
        internal bool IsSetSampleWeightAttributeName()
        {
            return this._sampleWeightAttributeName != null;
        }

        /// <summary>
        /// Gets and sets the property TargetAttributeName. 
        /// <para>
        /// The name of the target variable in supervised learning, usually represented by 'y'.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1)]
        public string TargetAttributeName
        {
            get { return this._targetAttributeName; }
            set { this._targetAttributeName = value; }
        }

        // Check to see if TargetAttributeName property is set
        internal bool IsSetTargetAttributeName()
        {
            return this._targetAttributeName != null;
        }

    }
}