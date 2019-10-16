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
    /// Container for the parameters to the GetAccuracyMetrics operation.
    /// Provides metrics on the accuracy of the models that were trained by the <a>CreatePredictor</a>
    /// operation. Use metrics to see how well the model performed and to decide whether to
    /// use the predictor to generate a forecast.
    /// 
    ///  
    /// <para>
    /// Metrics are generated for each backtest window evaluated. For more information, see
    /// <a>EvaluationParameters</a>.
    /// </para>
    ///  
    /// <para>
    /// The parameters of the <code>filling</code> method determine which items contribute
    /// to the metrics. If <code>zero</code> is specified, all items contribute. If <code>nan</code>
    /// is specified, only those items that have complete data in the range being evaluated
    /// contribute. For more information, see <a>FeaturizationMethod</a>.
    /// </para>
    ///  
    /// <para>
    /// For an example of how to train a model and review metrics, see <a>getting-started</a>.
    /// </para>
    /// </summary>
    public partial class GetAccuracyMetricsRequest : AmazonForecastServiceRequest
    {
        private string _predictorArn;

        /// <summary>
        /// Gets and sets the property PredictorArn. 
        /// <para>
        /// The Amazon Resource Name (ARN) of the predictor to get metrics for.
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Max=256)]
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

    }
}