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
    /// This is the response object from the GetAccuracyMetrics operation.
    /// </summary>
    public partial class GetAccuracyMetricsResponse : AmazonWebServiceResponse
    {
        private List<EvaluationResult> _predictorEvaluationResults = new List<EvaluationResult>();

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