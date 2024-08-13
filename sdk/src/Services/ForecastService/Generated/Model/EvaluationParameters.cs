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

#pragma warning disable CS0612,CS0618,CS1570
namespace Amazon.ForecastService.Model
{
    /// <summary>
    /// Parameters that define how to split a dataset into training data and testing data,
    /// and the number of iterations to perform. These parameters are specified in the predefined
    /// algorithms but you can override them in the <a>CreatePredictor</a> request.
    /// </summary>
    public partial class EvaluationParameters
    {
        private int? _backTestWindowOffset;
        private int? _numberOfBacktestWindows;

        /// <summary>
        /// Gets and sets the property BackTestWindowOffset. 
        /// <para>
        /// The point from the end of the dataset where you want to split the data for model training
        /// and testing (evaluation). Specify the value as the number of data points. The default
        /// is the value of the forecast horizon. <c>BackTestWindowOffset</c> can be used to mimic
        /// a past virtual forecast start date. This value must be greater than or equal to the
        /// forecast horizon and less than half of the TARGET_TIME_SERIES dataset length.
        /// </para>
        ///  
        /// <para>
        ///  <c>ForecastHorizon</c> &lt;= <c>BackTestWindowOffset</c> &lt; 1/2 * TARGET_TIME_SERIES
        /// dataset length
        /// </para>
        /// </summary>
        public int? BackTestWindowOffset
        {
            get { return this._backTestWindowOffset; }
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
        /// The number of times to split the input data. The default is 1. Valid values are 1
        /// through 5.
        /// </para>
        /// </summary>
        public int? NumberOfBacktestWindows
        {
            get { return this._numberOfBacktestWindows; }
            set { this._numberOfBacktestWindows = value; }
        }

        // Check to see if NumberOfBacktestWindows property is set
        internal bool IsSetNumberOfBacktestWindows()
        {
            return this._numberOfBacktestWindows.HasValue; 
        }

    }
}