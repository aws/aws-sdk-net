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
    /// Container for the parameters to the GetAccuracyMetrics operation.
    /// Provides metrics on the accuracy of the models that were trained by the <a>CreatePredictor</a>
    /// operation. Use metrics to see how well the model performed and to decide whether to
    /// use the predictor to generate a forecast. For more information, see <a href="https://docs.aws.amazon.com/forecast/latest/dg/metrics.html">Predictor
    /// Metrics</a>.
    /// 
    ///  
    /// <para>
    /// This operation generates metrics for each backtest window that was evaluated. The
    /// number of backtest windows (<code>NumberOfBacktestWindows</code>) is specified using
    /// the <a>EvaluationParameters</a> object, which is optionally included in the <code>CreatePredictor</code>
    /// request. If <code>NumberOfBacktestWindows</code> isn't specified, the number defaults
    /// to one.
    /// </para>
    ///  
    /// <para>
    /// The parameters of the <code>filling</code> method determine which items contribute
    /// to the metrics. If you want all items to contribute, specify <code>zero</code>. If
    /// you want only those items that have complete data in the range being evaluated to
    /// contribute, specify <code>nan</code>. For more information, see <a>FeaturizationMethod</a>.
    /// </para>
    ///  <note> 
    /// <para>
    /// Before you can get accuracy metrics, the <code>Status</code> of the predictor must
    /// be <code>ACTIVE</code>, signifying that training has completed. To get the status,
    /// use the <a>DescribePredictor</a> operation.
    /// </para>
    ///  </note>
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