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
    /// This is the response object from the GetAccuracyMetrics operation.
    /// </summary>
    public partial class GetAccuracyMetricsResponse : AmazonWebServiceResponse
    {
        private AutoMLOverrideStrategy _autoMLOverrideStrategy;
        private bool? _isAutoPredictor;
        private OptimizationMetric _optimizationMetric;
        private List<EvaluationResult> _predictorEvaluationResults = new List<EvaluationResult>();

        /// <summary>
        /// Gets and sets the property AutoMLOverrideStrategy. <note> 
        /// <para>
        ///  The <code>LatencyOptimized</code> AutoML override strategy is only available in private
        /// beta. Contact Amazon Web Services Support or your account manager to learn more about
        /// access privileges. 
        /// </para>
        ///  </note> 
        /// <para>
        /// The AutoML strategy used to train the predictor. Unless <code>LatencyOptimized</code>
        /// is specified, the AutoML strategy optimizes predictor accuracy.
        /// </para>
        ///  
        /// <para>
        /// This parameter is only valid for predictors trained using AutoML.
        /// </para>
        /// </summary>
        public AutoMLOverrideStrategy AutoMLOverrideStrategy
        {
            get { return this._autoMLOverrideStrategy; }
            set { this._autoMLOverrideStrategy = value; }
        }

        // Check to see if AutoMLOverrideStrategy property is set
        internal bool IsSetAutoMLOverrideStrategy()
        {
            return this._autoMLOverrideStrategy != null;
        }

        /// <summary>
        /// Gets and sets the property IsAutoPredictor. 
        /// <para>
        /// Whether the predictor was created with <a>CreateAutoPredictor</a>.
        /// </para>
        /// </summary>
        public bool IsAutoPredictor
        {
            get { return this._isAutoPredictor.GetValueOrDefault(); }
            set { this._isAutoPredictor = value; }
        }

        // Check to see if IsAutoPredictor property is set
        internal bool IsSetIsAutoPredictor()
        {
            return this._isAutoPredictor.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property OptimizationMetric. 
        /// <para>
        /// The accuracy metric used to optimize the predictor.
        /// </para>
        /// </summary>
        public OptimizationMetric OptimizationMetric
        {
            get { return this._optimizationMetric; }
            set { this._optimizationMetric = value; }
        }

        // Check to see if OptimizationMetric property is set
        internal bool IsSetOptimizationMetric()
        {
            return this._optimizationMetric != null;
        }

        /// <summary>
        /// Gets and sets the property PredictorEvaluationResults. 
        /// <para>
        /// An array of results from evaluating the predictor.
        /// </para>
        /// </summary>
        public List<EvaluationResult> PredictorEvaluationResults
        {
            get { return this._predictorEvaluationResults; }
            set { this._predictorEvaluationResults = value; }
        }

        // Check to see if PredictorEvaluationResults property is set
        internal bool IsSetPredictorEvaluationResults()
        {
            return this._predictorEvaluationResults != null && this._predictorEvaluationResults.Count > 0; 
        }

    }
}