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
    /// Parameters that define how to split a dataset into training data and testing data,
    /// and the number of iterations to perform. These parameters are specified in the predefined
    /// algorithms and can be overridden in the <a>CreatePredictor</a> request.
    /// 
    ///  
    /// <para>
    /// For example, suppose that you have a dataset with data collection frequency set to
    /// every day and you have 200 days worth of data (that is, 200 data points). Now suppose
    /// that you set the <code>NumberOfBacktestWindows</code> to 2 and the <code>BackTestWindowOffset</code>
    /// parameter to 20. The algorithm splits the data twice. The first time, the algorithm
    /// trains the model using the first 180 data points and uses the last 20 data points
    /// for evaluation. The second time, the algorithm trains the model using the first 160
    /// data points and uses the last 40 data points for evaluation.
    /// </para>
    /// </summary>
    public partial class EvaluationParameters
    {
        private int? _backTestWindowOffset;
        private int? _numberOfBacktestWindows;

        /// <summary>
        /// Gets and sets the property BackTestWindowOffset. 
        /// <para>
        /// The point from the end of the dataset where you want to split the data for model training
        /// and evaluation. The value is specified as the number of data points.
        /// </para>
        /// </summary>
        public int BackTestWindowOffset
        {
            get { return this._backTestWindowOffset.GetValueOrDefault(); }
            set { this._backTestWindowOffset = value; }
        }

        // Check to see if BackTestWindowOffset property is set
        internal bool IsSetBackTestWindowOffset()
        {
            return this._backTestWindowOffset.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property NumberOfBacktestWindows. 
        /// <para>
        /// The number of times to split the input data. The default is 1. The range is 1 through
        /// 5.
        /// </para>
        /// </summary>
        public int NumberOfBacktestWindows
        {
            get { return this._numberOfBacktestWindows.GetValueOrDefault(); }
            set { this._numberOfBacktestWindows = value; }
        }

        // Check to see if NumberOfBacktestWindows property is set
        internal bool IsSetNumberOfBacktestWindows()
        {
            return this._numberOfBacktestWindows.HasValue; 
        }

    }
}