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
    /// This is the response object from the GetAccuracyMetrics operation.
    /// </summary>
    public partial class GetAccuracyMetricsResponse : AmazonWebServiceResponse
    {
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
        /// Gets and sets the property PredictorEvaluationResults. 
        /// <para>
        /// An array of results from evaluating the predictor.
        /// </para>
        /// <para />
        /// Starting with version 4 of the SDK this property will default to null. If no data
        /// for this property is returned from the service the property will also be null. This
        /// was changed to improve performance and allow the SDK and caller to distinguish between
        /// a property not set or a property being empty to clear out a value. To retain the previous
        /// SDK behavior set the AWSConfigs.InitializeCollections static property to true.
        /// </summary>
        public List<EvaluationResult> PredictorEvaluationResults { get; set; } = AWSConfigs.InitializeCollections ? new List<EvaluationResult>() : null;

        /// <summary>
        /// Checks to see if the PredictorEvaluationResults property is set.
        /// </summary>
        internal bool IsSetPredictorEvaluationResults() => this.PredictorEvaluationResults != null && (this.PredictorEvaluationResults.Count > 0 || !AWSConfigs.InitializeCollections);
    }
}
