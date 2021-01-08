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
    /// Contains details on the backtests performed to evaluate the accuracy of the predictor.
    /// The tests are returned in descending order of accuracy, with the most accurate backtest
    /// appearing first. You specify the number of backtests to perform when you call the
    /// operation.
    /// </summary>
    public partial class PredictorExecutionDetails
    {
        private List<PredictorExecution> _predictorExecutions = new List<PredictorExecution>();

        /// <summary>
        /// Gets and sets the property PredictorExecutions. 
        /// <para>
        /// An array of the backtests performed to evaluate the accuracy of the predictor against
        /// a particular algorithm. The <code>NumberOfBacktestWindows</code> from the object determines
        /// the number of windows in the array.
        /// </para>
        /// </summary>
        [AWSProperty(Min=1, Max=5)]
        public List<PredictorExecution> PredictorExecutions
        {
            get { return this._predictorExecutions; }
            set { this._predictorExecutions = value; }
        }

        // Check to see if PredictorExecutions property is set
        internal bool IsSetPredictorExecutions()
        {
            return this._predictorExecutions != null && this._predictorExecutions.Count > 0; 
        }

    }
}